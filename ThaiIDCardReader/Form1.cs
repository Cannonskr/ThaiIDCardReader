using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThaiNationalIDCard;
using AForge.Video;
using AForge.Controls;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using Gst;
using System.Net.NetworkInformation;
using VisioForge.Libs.AForge.Imaging;
using VisioForge.Libs.MediaFoundation.OPM;
using VisioForge.MediaFramework.GStreamer.Base;
using Pango;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SQLite;
using VisioForge.Libs.DirectShowLib.BDA;
using VisioForge.MediaFramework.DSP;
using System.Reflection.Emit;


namespace ThaiIDCardReader
{
    public partial class Form1 : Form
    {
        string connectionString = string.Empty;// @"Data Source=C:\path\to\database.db;Version=3;";
        VideoCaptureDevice cam;
        FilterInfoCollection dvList;
        private Form popup;
        private System.Windows.Forms.PictureBox pic;
        public List<Personal> people = new List<Personal>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string rootDir_database = Path.Combine(System.Windows.Forms.Application.StartupPath, "database");
            string file_database = rootDir_database + @"\database.db";
            var tempconn = @"Data Source=" + file_database + ";Version=3;";
            connectionString = tempconn;
            if (!Directory.Exists(rootDir_database))
            {
                Directory.CreateDirectory(rootDir_database);
            }
            
            if (!File.Exists(file_database))
            {
                // Create a new  database file
                SQLiteConnection.CreateFile(file_database);
                

                // Open a connection to the database
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Create a new table
                    // "LegalID|TH_Title|TH_FirstName|TH_LastName|IssueDate|ExpireDate|InsertTime
                    using (SQLiteCommand command = new SQLiteCommand("CREATE TABLE carddata (LegalID TEXT, TH_Title TEXTT, TH_FirstName TEXTT, TH_LastName TEXTT, IssueDate TEXTT, ExpireDate TEXTT, InsertTime TEXTT)", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }

            dataGridView1.Visible = false;
            btn_save_card.Visible = false;
            btn_upload_img.Visible = false;
            chkPause.Visible = false;
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";

            cmdConn.Text = "";
            cmbList.Visible = false;    
            btn_open_cam.Visible = false;   
            btn_view_image.Visible = false;
            tabControl1.Visible = false;


            dvList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in dvList)
            {
                cmbList.Items.Add(info.Name);
            }
            cmbList.SelectedIndex = 0;
            //chkPause.Enabled = false;
        }
        private void btn_readcard_Click(object sender, EventArgs e)
        {
            // create object for connect id card
            ThaiIDCard card = new ThaiIDCard();
            // create Object for get all data with image
            Personal personal = card.readAllPhoto();
            people.Clear();
            // check data
            if (personal != null)
            {
                label1.Text = "read data success.";
                label1.ForeColor = System.Drawing.Color.Green;
                btn_readcard.Enabled = false;
                btn_save_card.Enabled = true;
                btn_save_card.Visible = true;
                people.Add(personal);
                // set dataSource property of datagridview
                dataGridView1.DataSource = people;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.Visible = true;
                dataGridView1.Rows[0].Height = 200;
            }
            else
            {
                label1.Text = "read data error.";
                label1.ForeColor = System.Drawing.Color.Red;
                btn_save_card.Enabled = false;
                dataGridView1.Visible = false;
                btn_save_card.Visible = false;
                btn_upload_img.Visible = false;
                label2.Text = "";
                label3.Text = "";
                label4.Text = "";
                label5.Text = "";
            }
        }
        private void btn_save_card_Click(object sender, EventArgs e)
        {
            string rootDir_image = Path.Combine(System.Windows.Forms.Application.StartupPath, "image");
            var Citizenid_temp = (Convert.ToUInt64(people.FirstOrDefault().Citizenid) + 9999999).ToString();
            string pathSave = Path.Combine(rootDir_image, Citizenid_temp);
            
            
            //check path for image
            if (Directory.Exists(pathSave))
            {
                // remove file in dir
                string[] files = Directory.GetFiles(pathSave);
                foreach (string file in files)
                {
                    System.IO.File.Delete(file);
                }
                // remove sub dir
                string[] directories = Directory.GetDirectories(pathSave);
                foreach (string directory in directories)
                {
                    Directory.Delete(directory, true);
                }
                // remove main dir
                Directory.Delete(pathSave, true);
            }
            //create path
           
            Directory.CreateDirectory(pathSave);
            //save image
            var pathSaveImage = Path.Combine(pathSave, Citizenid_temp + "_Card");
            ConvertByteArrayToFile(people.FirstOrDefault().PhotoBitmap, pathSaveImage + ".jpg");

            string rootDir_text = Path.Combine(System.Windows.Forms.Application.StartupPath, "data");
            string file_text = Path.Combine(rootDir_text, "data.csv");

            //check path for image
            if (!Directory.Exists(rootDir_text))
            {
                //create dir
                Directory.CreateDirectory(rootDir_text);
            }

            if (!File.Exists(file_text))
            {
                //Create file data
                using (StreamWriter writer = new StreamWriter(file_text))
                {
                    // write header
                    writer.WriteLine("LegalID|TH_Title|TH_FirstName|TH_LastName|IssueDate|ExpireDate|InsertTime");
                }
            }

            //save data to text file
            AppendToFile(file_text,people.FirstOrDefault());
            //save data to database
            InsertToDatabase(people.FirstOrDefault());

           
            label2.Text = "Path:" + pathSave; //"save data success.";
            label2.ForeColor = System.Drawing.Color.Green;
            label3.Text = "ImageCard:" + pathSaveImage; //"save data success.";
            label3.ForeColor = System.Drawing.Color.Green;
            label4.Text = "TextFile:" + file_text; //"save data success.";
            label4.ForeColor = System.Drawing.Color.Green;
            btn_upload_img.Visible = true;
            btn_upload_img.Enabled = true;
            btn_save_card.Enabled = false;
            cmdConn.Text = "-";
            cmbList.Visible = true;
            btn_open_cam.Visible = true;
            btn_view_image.Visible = true;
            btn_view_image.Enabled = false;
            tabControl1.Visible = true;
            
            btn_open_cam.Enabled = true;
            cmbList.Enabled = true;
            btn_view_image.Enabled = true;
            btn_upload_img.Enabled = true;
            btn_auto_up_img.Enabled = true;

        }
        private void ConvertByteArrayToFile(Bitmap photoBitmap, string pathSaveImage)
        {
            int width = 296; // set the desired width of the image
            int height = 356; // set the desired height of the image

            //resize image
            Bitmap img = resizedBitmap(photoBitmap, width, height);

            // Save the Bitmap to a file
            img.Save(pathSaveImage, ImageFormat.Jpeg);
            //photoBitmap.Save(pathSaveImage, ImageFormat.Jpeg);
        }
        public Bitmap resizedBitmap(Bitmap inputBitmap, int newWidth, int newHeight)
        {
            Bitmap outputBitmap = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(outputBitmap))
            {
                graphics.DrawImage(inputBitmap, 0, 0, newWidth, newHeight);
            }

            return outputBitmap;
        }
        private static void ConvertByteArrayToFile(byte[] byteArray, string filePath)
        {
            //float resolution = 300; // set the resolution to 300 DPI
            //int width = 800; // set the desired width of the image
            //int height = 600; // set the desired height of the image
            //using (MemoryStream memoryStream = new MemoryStream(byteArray))
            //{

            //using (Bitmap bitmap = new Bitmap(memoryStream))
            //{
            //    Bitmap resizedBitmap = new Bitmap(width, height);

            //    for (int x = 0; x < width; x++)
            //    {
            //        for (int y = 0; y < height; y++)
            //        {
            //            System.Drawing.Color pixelColor = bitmap.GetPixel((x * bitmap.Width) / width, (y * bitmap.Height) / height);
            //            resizedBitmap.SetPixel(x, y, pixelColor);
            //        }
            //    }

            //    resizedBitmap.Save(filePath, ImageFormat.Png);
            //}
            //using (System.Drawing.Image image = System.Drawing.Image.FromStream(memoryStream))
            //{
            //    image.Save(filePath, ImageFormat.Png);
            //}
            //using (Bitmap bitmap = new Bitmap(memoryStream))
            //{
            //    bitmap.SetResolution(resolution, resolution);
            //    bitmap.Save(filePath, ImageFormat.Png);
            //}
            //}
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                fileStream.Write(byteArray, 0, byteArray.Length);
                fileStream.Flush();
            }
        }
        private void SaveTextFile(Personal personal, string pathTextFile)
        {
            using (StreamWriter sw = new StreamWriter(pathTextFile))
            {
                sw.WriteLine("Citizenid|" + personal.Citizenid);
                sw.WriteLine("Th_Firstname|" + personal.Th_Firstname);
                sw.WriteLine("Th_Lastname|" + personal.Th_Lastname);
                sw.WriteLine("En_Firstname|" + personal.En_Firstname);
                sw.WriteLine("En_Lastname|" + personal.En_Lastname);
            }
        }
        public void AppendToFile(string filePath, Personal personal)
        {
            // Create a new StreamWriter object and open the file for appending
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                // Write the text to the file
                writer.WriteLine(String.Concat(personal.Citizenid, "|", personal.Th_Prefix, "|", personal.Th_Firstname, "|", personal.Th_Lastname, "|", personal.Issue, "|", personal.Expire,"|", System.DateTime.Now.ToString()));
            }
        }
        private void InsertToDatabase(Personal personal)
        {

            // Define the data to insert into the carddata table
            string legalID = personal.Citizenid;
            string thTitle = personal.Th_Prefix;
            string thFirstName = personal.Th_Firstname;
            string thLastName = personal.Th_Lastname;
            string issueDate = personal.Issue.ToString("yyyy-MM-dd");
            string expireDate = personal.Expire.ToString("yyyy-MM-dd");
            string insertTime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Create an INSERT INTO statement to insert the data into the carddata table
            string insertSql = "INSERT INTO carddata (LegalID, TH_Title, TH_FirstName, TH_LastName, IssueDate, ExpireDate, InsertTime) " +
                               $"VALUES ('{legalID}', '{thTitle}', '{thFirstName}', '{thLastName}', '{issueDate}', '{expireDate}', '{insertTime}')";

            // Open a connection to the database
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Execute the INSERT INTO command
                using (SQLiteCommand command = new SQLiteCommand(insertSql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
        private void btn_upload_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog1.FileName;
                string rootDir = Path.Combine(System.Windows.Forms.Application.StartupPath, "image");
                var Citizenid_temp = (Convert.ToUInt64(people.FirstOrDefault().Citizenid) + 9999999).ToString();
                string pathSave = Path.Combine(rootDir, Citizenid_temp);
                var pathSaveImage = Path.Combine(pathSave, Citizenid_temp + "_Camera" + ".jpg");
                // Move the selected file to the save path
                File.Move(selectedFilePath, pathSaveImage);
                label5.Text = "ImageCam:" + pathSaveImage; //"save data success.";
                label5.ForeColor = System.Drawing.Color.Green;

                btn_upload_img.Enabled = false;
                btn_save_card.Enabled = false;
                btn_upload_img.Enabled = false;
                btn_open_cam.Enabled = false;
                cmbList.Enabled = false;
                btn_view_image.Enabled = false;
                btn_upload_img.Enabled = false;
                btn_auto_up_img.Enabled = false;
            }

        }
        private void btn_open_cam_Click(object sender, EventArgs e)
        {
            if (cam == null)
            {
                cam = new VideoCaptureDevice(dvList[cmbList.SelectedIndex].MonikerString);
                foreach (VideoCapabilities capabilty in cam.VideoCapabilities)
                {
                    if (capabilty.FrameSize.Width == 1920 && capabilty.FrameSize.Height == 1080)
                    {
                        cam.VideoResolution = capabilty;
                        break;
                    }
                }
                cam.NewFrame += cam_NewFrame;
                cam.Start();
                cmdConn.Text = "connect";
                chkPause.Enabled = true;
                btn_open_cam.Enabled = true;

                // Create a new form to display the webcam stream
                popup = new Form();
                popup.Text = "Webcam Stream";
                popup.StartPosition = FormStartPosition.CenterScreen;
                popup.ClientSize = new Size(640, 360);

                // Create a new PictureBox control to display the webcam stream
                pic = new System.Windows.Forms.PictureBox();
                pic.Dock = DockStyle.Fill;
                popup.Controls.Add(pic);

                // Start the video source and set the PictureBox as the video source player
                VideoSourcePlayer videoSourcePlayer = new VideoSourcePlayer();
                videoSourcePlayer.VideoSource = cam;
                videoSourcePlayer.Dock = DockStyle.Fill;
                pic.Controls.Add(videoSourcePlayer);
                videoSourcePlayer.Start();

                // Create a new button to capture the image
                Button btnCapture = new Button();
                btnCapture.Text = "Capture";
                btnCapture.Dock = DockStyle.Bottom;
                btnCapture.Click += btnCapture_Click;
                popup.Controls.Add(btnCapture);

                chkPause.Visible = true;
                popup.ShowDialog();
            }
            else
            {
                cam.Stop();
                cam = null;
                cmdConn.Text = "disconnect";
                chkPause.Enabled = false;
            }
        }
        private void cmbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cam != null)
            {
                cam.Stop();
                cam = null;
                cmdConn.Text = "disconnect";
                chkPause.Enabled = false;
                btn_open_cam.Enabled = true;
            }
        }
        void cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap b = (Bitmap)eventArgs.Frame.Clone();
            pic.Image = b;
        }
        private void chkPause_Click(object sender, EventArgs e)
        {
            if (cam.IsRunning)
            {
                cam.Stop();
                cam = null;
                cmdConn.Text = "disconnect";
                chkPause.Enabled = false;
            }
        }
        private void btnCapture_Click(object sender, EventArgs e)
        {
            if (pic != null && popup != null && !popup.IsDisposed)
            {
                var dir_image_cam = @"temp";
                if (!Directory.Exists(dir_image_cam))
                {
                    Directory.CreateDirectory(dir_image_cam);
                }
                Bitmap frame = (Bitmap)((Bitmap)pic.Image).Clone();
                var path_file_temp = Path.Combine(dir_image_cam, @"temp.jpg");
                try
                {

               
                    if(File.Exists(path_file_temp))
                    {
                        File.Delete(path_file_temp);
                    }
                    frame.Save(path_file_temp, System.Drawing.Imaging.ImageFormat.Jpeg);
                    popup.Close();
                    cam.Stop();
                    cam = null;
                    cmdConn.Text = "disconnect";
                    chkPause.Enabled = false;
                    btn_view_image.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to save the image. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_view_image.Enabled = false;
                }
            }
        }
        private void btn_view_image_Click(object sender, EventArgs e)
        {

            //var dir_image_cam = @"temp";
            //var path_file_temp = Path.Combine(dir_image_cam, @"temp.jpg");

            //var popupForm = new Form();
            //popupForm.ClientSize = new Size(640, 360);
            //popupForm.Text = "Selected Image";
            //popupForm.Icon = this.Icon;
            //popupForm.StartPosition = FormStartPosition.CenterScreen;


            //var pictureBox = new System.Windows.Forms.PictureBox();
            //pictureBox.Dock = DockStyle.Fill;
            //System.Drawing.Image image = System.Drawing.Image.FromFile(path_file_temp);
            //pictureBox.Image = image;
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


            //popupForm.Controls.Add(pictureBox);
            //popupForm.ShowDialog();
            var dir_image_cam = @"temp";
            var path_file_temp = Path.Combine(dir_image_cam, @"temp.jpg");

            Process.Start("explorer.exe", path_file_temp);

        }
        private void btn_auto_up_img_Click(object sender, EventArgs e)
        {

            string rootDir_image = Path.Combine(System.Windows.Forms.Application.StartupPath, "image");
            var Citizenid_temp = (Convert.ToUInt64(people.FirstOrDefault().Citizenid) + 9999999).ToString();
            string pathSave = Path.Combine(rootDir_image, Citizenid_temp);
            //save image
            var pathSaveImage = Path.Combine(pathSave, Citizenid_temp + "_Camera.jpg");
            // Move the selected file to the save path
            var dir_image_cam = @"temp";
            var path_file_temp = Path.Combine(dir_image_cam, @"temp.jpg");

            if(!File.Exists(path_file_temp))
            {
                MessageBox.Show("Picture file was not found. Please take the picture again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //try
            //{
            File.Move(path_file_temp, pathSaveImage);
            label6.Text = "ImageCam:" + pathSaveImage; //"save data success.";
            label6.ForeColor = System.Drawing.Color.Green;

            btn_open_cam.Enabled = false;
            cmbList.Enabled = false;
            btn_view_image.Enabled = false;
            btn_upload_img.Enabled = false;
            btn_auto_up_img.Enabled = false;
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Unable to save the image. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void New_Click(object sender, EventArgs e)
        {
            string rootDir_database = Path.Combine(System.Windows.Forms.Application.StartupPath, "database");
            string file_database = rootDir_database + @"\database.db";
            var tempconn = @"Data Source=" + file_database + ";Version=3;";
            connectionString = tempconn;
            if (!Directory.Exists(rootDir_database))
            {
                Directory.CreateDirectory(rootDir_database);
            }

            if (!File.Exists(file_database))
            {
                // Create a new  database file
                SQLiteConnection.CreateFile(file_database);


                // Open a connection to the database
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Create a new table
                    // "LegalID|TH_Title|TH_FirstName|TH_LastName|IssueDate|ExpireDate|InsertTime
                    using (SQLiteCommand command = new SQLiteCommand("CREATE TABLE carddata (LegalID TEXT, TH_Title TEXTT, TH_FirstName TEXTT, TH_LastName TEXTT, IssueDate TEXTT, ExpireDate TEXTT, InsertTime TEXTT)", connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }

            dataGridView1.Visible = false;
            btn_save_card.Visible = false;
            btn_upload_img.Visible = false;
            btn_readcard.Enabled = true;
            chkPause.Visible = false;
            label1.Text = "wait for reading....";
            label1.ForeColor = System.Drawing.Color.Black;
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";

            cmdConn.Text = "";
            cmbList.Visible = false;
            btn_open_cam.Visible = false;
            btn_view_image.Visible = false;
            tabControl1.Visible = false;


            //dvList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //foreach (FilterInfo info in dvList)
            //{
            //    cmbList.Items.Add(info.Name);
            //}
            cmbList.SelectedIndex = 0;
            //chkPause.Enabled = false;



        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Select all data from the table
                using (SQLiteCommand command = new SQLiteCommand("SELECT * FROM carddata", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        // Write the data to a CSV file
                        using (StreamWriter writer = new StreamWriter("carddata.csv"))
                        {
                            // Write the header row
                            writer.WriteLine("LegalID|TH_Title|TH_FirstName|TH_LastName|IssueDate|ExpireDate|InsertTime");

                            // Write the data rows
                            while (reader.Read())
                            {
                                writer.WriteLine($"{reader["LegalID"]}|{reader["TH_Title"]}|{reader["TH_FirstName"]}|{reader["TH_LastName"]}|{reader["IssueDate"]}|{reader["ExpireDate"]}|{reader["InsertTime"]}");
                            }
                        }
                    }
                }
            }
        }

        //private void btn_open_folder_Click(object sender, EventArgs e)
        //{
        //    var dir_image_cam = @"temp";
        //    var path_file_temp = Path.Combine(dir_image_cam, @"temp.jpg");

        //    Process.Start("explorer.exe", path_file_temp);

        //}
    }

}
