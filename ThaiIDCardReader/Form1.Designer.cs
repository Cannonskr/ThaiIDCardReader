namespace ThaiIDCardReader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_readcard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save_card = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.citizenidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoRawDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.photoBitmapDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrHouseNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrVillageNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrLaneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrRoadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrTambolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrAmphurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrProvinceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thPrefixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enPrefixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enFirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enLastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_upload_img = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbList = new System.Windows.Forms.ComboBox();
            this.btn_open_cam = new System.Windows.Forms.Button();
            this.chkPause = new System.Windows.Forms.Button();
            this.cmdConn = new System.Windows.Forms.Label();
            this.btn_view_image = new System.Windows.Forms.Button();
            this.btn_auto_up_img = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.New = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_readcard
            // 
            this.btn_readcard.Location = new System.Drawing.Point(12, 11);
            this.btn_readcard.Name = "btn_readcard";
            this.btn_readcard.Size = new System.Drawing.Size(90, 42);
            this.btn_readcard.TabIndex = 0;
            this.btn_readcard.Text = "1.Read Card";
            this.btn_readcard.UseVisualStyleBackColor = true;
            this.btn_readcard.Click += new System.EventHandler(this.btn_readcard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "wait for reading....";
            // 
            // btn_save_card
            // 
            this.btn_save_card.Enabled = false;
            this.btn_save_card.Location = new System.Drawing.Point(12, 275);
            this.btn_save_card.Name = "btn_save_card";
            this.btn_save_card.Size = new System.Drawing.Size(90, 42);
            this.btn_save_card.TabIndex = 2;
            this.btn_save_card.Text = "2.Save Data";
            this.btn_save_card.UseVisualStyleBackColor = true;
            this.btn_save_card.Click += new System.EventHandler(this.btn_save_card_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.citizenidDataGridViewTextBoxColumn,
            this.photoRawDataGridViewImageColumn,
            this.photoBitmapDataGridViewImageColumn,
            this.addressDataGridViewTextBoxColumn,
            this.addrHouseNoDataGridViewTextBoxColumn,
            this.addrVillageNoDataGridViewTextBoxColumn,
            this.addrLaneDataGridViewTextBoxColumn,
            this.addrRoadDataGridViewTextBoxColumn,
            this.addrTambolDataGridViewTextBoxColumn,
            this.addrAmphurDataGridViewTextBoxColumn,
            this.addrProvinceDataGridViewTextBoxColumn,
            this.issueDataGridViewTextBoxColumn,
            this.expireDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.thPrefixDataGridViewTextBoxColumn,
            this.thFirstnameDataGridViewTextBoxColumn,
            this.thLastnameDataGridViewTextBoxColumn,
            this.enPrefixDataGridViewTextBoxColumn,
            this.enFirstnameDataGridViewTextBoxColumn,
            this.enLastnameDataGridViewTextBoxColumn,
            this.issuerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(898, 208);
            this.dataGridView1.TabIndex = 3;
            // 
            // citizenidDataGridViewTextBoxColumn
            // 
            this.citizenidDataGridViewTextBoxColumn.DataPropertyName = "Citizenid";
            this.citizenidDataGridViewTextBoxColumn.HeaderText = "Citizenid";
            this.citizenidDataGridViewTextBoxColumn.Name = "citizenidDataGridViewTextBoxColumn";
            // 
            // photoRawDataGridViewImageColumn
            // 
            this.photoRawDataGridViewImageColumn.DataPropertyName = "PhotoRaw";
            this.photoRawDataGridViewImageColumn.HeaderText = "PhotoRaw";
            this.photoRawDataGridViewImageColumn.Name = "photoRawDataGridViewImageColumn";
            // 
            // photoBitmapDataGridViewImageColumn
            // 
            this.photoBitmapDataGridViewImageColumn.DataPropertyName = "PhotoBitmap";
            this.photoBitmapDataGridViewImageColumn.HeaderText = "PhotoBitmap";
            this.photoBitmapDataGridViewImageColumn.Name = "photoBitmapDataGridViewImageColumn";
            this.photoBitmapDataGridViewImageColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // addrHouseNoDataGridViewTextBoxColumn
            // 
            this.addrHouseNoDataGridViewTextBoxColumn.DataPropertyName = "addrHouseNo";
            this.addrHouseNoDataGridViewTextBoxColumn.HeaderText = "addrHouseNo";
            this.addrHouseNoDataGridViewTextBoxColumn.Name = "addrHouseNoDataGridViewTextBoxColumn";
            this.addrHouseNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addrVillageNoDataGridViewTextBoxColumn
            // 
            this.addrVillageNoDataGridViewTextBoxColumn.DataPropertyName = "addrVillageNo";
            this.addrVillageNoDataGridViewTextBoxColumn.HeaderText = "addrVillageNo";
            this.addrVillageNoDataGridViewTextBoxColumn.Name = "addrVillageNoDataGridViewTextBoxColumn";
            this.addrVillageNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addrLaneDataGridViewTextBoxColumn
            // 
            this.addrLaneDataGridViewTextBoxColumn.DataPropertyName = "addrLane";
            this.addrLaneDataGridViewTextBoxColumn.HeaderText = "addrLane";
            this.addrLaneDataGridViewTextBoxColumn.Name = "addrLaneDataGridViewTextBoxColumn";
            this.addrLaneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addrRoadDataGridViewTextBoxColumn
            // 
            this.addrRoadDataGridViewTextBoxColumn.DataPropertyName = "addrRoad";
            this.addrRoadDataGridViewTextBoxColumn.HeaderText = "addrRoad";
            this.addrRoadDataGridViewTextBoxColumn.Name = "addrRoadDataGridViewTextBoxColumn";
            this.addrRoadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addrTambolDataGridViewTextBoxColumn
            // 
            this.addrTambolDataGridViewTextBoxColumn.DataPropertyName = "addrTambol";
            this.addrTambolDataGridViewTextBoxColumn.HeaderText = "addrTambol";
            this.addrTambolDataGridViewTextBoxColumn.Name = "addrTambolDataGridViewTextBoxColumn";
            this.addrTambolDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addrAmphurDataGridViewTextBoxColumn
            // 
            this.addrAmphurDataGridViewTextBoxColumn.DataPropertyName = "addrAmphur";
            this.addrAmphurDataGridViewTextBoxColumn.HeaderText = "addrAmphur";
            this.addrAmphurDataGridViewTextBoxColumn.Name = "addrAmphurDataGridViewTextBoxColumn";
            this.addrAmphurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addrProvinceDataGridViewTextBoxColumn
            // 
            this.addrProvinceDataGridViewTextBoxColumn.DataPropertyName = "addrProvince";
            this.addrProvinceDataGridViewTextBoxColumn.HeaderText = "addrProvince";
            this.addrProvinceDataGridViewTextBoxColumn.Name = "addrProvinceDataGridViewTextBoxColumn";
            this.addrProvinceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issueDataGridViewTextBoxColumn
            // 
            this.issueDataGridViewTextBoxColumn.DataPropertyName = "Issue";
            this.issueDataGridViewTextBoxColumn.HeaderText = "Issue";
            this.issueDataGridViewTextBoxColumn.Name = "issueDataGridViewTextBoxColumn";
            this.issueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expireDataGridViewTextBoxColumn
            // 
            this.expireDataGridViewTextBoxColumn.DataPropertyName = "Expire";
            this.expireDataGridViewTextBoxColumn.HeaderText = "Expire";
            this.expireDataGridViewTextBoxColumn.Name = "expireDataGridViewTextBoxColumn";
            this.expireDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thPrefixDataGridViewTextBoxColumn
            // 
            this.thPrefixDataGridViewTextBoxColumn.DataPropertyName = "Th_Prefix";
            this.thPrefixDataGridViewTextBoxColumn.HeaderText = "Th_Prefix";
            this.thPrefixDataGridViewTextBoxColumn.Name = "thPrefixDataGridViewTextBoxColumn";
            this.thPrefixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thFirstnameDataGridViewTextBoxColumn
            // 
            this.thFirstnameDataGridViewTextBoxColumn.DataPropertyName = "Th_Firstname";
            this.thFirstnameDataGridViewTextBoxColumn.HeaderText = "Th_Firstname";
            this.thFirstnameDataGridViewTextBoxColumn.Name = "thFirstnameDataGridViewTextBoxColumn";
            this.thFirstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thLastnameDataGridViewTextBoxColumn
            // 
            this.thLastnameDataGridViewTextBoxColumn.DataPropertyName = "Th_Lastname";
            this.thLastnameDataGridViewTextBoxColumn.HeaderText = "Th_Lastname";
            this.thLastnameDataGridViewTextBoxColumn.Name = "thLastnameDataGridViewTextBoxColumn";
            this.thLastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enPrefixDataGridViewTextBoxColumn
            // 
            this.enPrefixDataGridViewTextBoxColumn.DataPropertyName = "En_Prefix";
            this.enPrefixDataGridViewTextBoxColumn.HeaderText = "En_Prefix";
            this.enPrefixDataGridViewTextBoxColumn.Name = "enPrefixDataGridViewTextBoxColumn";
            this.enPrefixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enFirstnameDataGridViewTextBoxColumn
            // 
            this.enFirstnameDataGridViewTextBoxColumn.DataPropertyName = "En_Firstname";
            this.enFirstnameDataGridViewTextBoxColumn.HeaderText = "En_Firstname";
            this.enFirstnameDataGridViewTextBoxColumn.Name = "enFirstnameDataGridViewTextBoxColumn";
            this.enFirstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enLastnameDataGridViewTextBoxColumn
            // 
            this.enLastnameDataGridViewTextBoxColumn.DataPropertyName = "En_Lastname";
            this.enLastnameDataGridViewTextBoxColumn.HeaderText = "En_Lastname";
            this.enLastnameDataGridViewTextBoxColumn.Name = "enLastnameDataGridViewTextBoxColumn";
            this.enLastnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // issuerDataGridViewTextBoxColumn
            // 
            this.issuerDataGridViewTextBoxColumn.DataPropertyName = "Issuer";
            this.issuerDataGridViewTextBoxColumn.HeaderText = "Issuer";
            this.issuerDataGridViewTextBoxColumn.Name = "issuerDataGridViewTextBoxColumn";
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataSource = typeof(ThaiNationalIDCard.Personal);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "-";
            // 
            // btn_upload_img
            // 
            this.btn_upload_img.Location = new System.Drawing.Point(15, 20);
            this.btn_upload_img.Name = "btn_upload_img";
            this.btn_upload_img.Size = new System.Drawing.Size(103, 23);
            this.btn_upload_img.TabIndex = 7;
            this.btn_upload_img.Text = "Upload Image";
            this.btn_upload_img.UseVisualStyleBackColor = true;
            this.btn_upload_img.Click += new System.EventHandler(this.btn_upload_img_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "-";
            // 
            // cmbList
            // 
            this.cmbList.FormattingEnabled = true;
            this.cmbList.Location = new System.Drawing.Point(105, 17);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(162, 21);
            this.cmbList.TabIndex = 10;
            this.cmbList.SelectedIndexChanged += new System.EventHandler(this.cmbList_SelectedIndexChanged);
            // 
            // btn_open_cam
            // 
            this.btn_open_cam.Location = new System.Drawing.Point(6, 15);
            this.btn_open_cam.Name = "btn_open_cam";
            this.btn_open_cam.Size = new System.Drawing.Size(90, 42);
            this.btn_open_cam.TabIndex = 11;
            this.btn_open_cam.Text = "Open cam";
            this.btn_open_cam.UseVisualStyleBackColor = true;
            this.btn_open_cam.Click += new System.EventHandler(this.btn_open_cam_Click);
            // 
            // chkPause
            // 
            this.chkPause.Location = new System.Drawing.Point(6, 63);
            this.chkPause.Name = "chkPause";
            this.chkPause.Size = new System.Drawing.Size(90, 42);
            this.chkPause.TabIndex = 13;
            this.chkPause.Text = "Pause";
            this.chkPause.UseVisualStyleBackColor = true;
            this.chkPause.Click += new System.EventHandler(this.chkPause_Click);
            // 
            // cmdConn
            // 
            this.cmdConn.AutoSize = true;
            this.cmdConn.Location = new System.Drawing.Point(105, 77);
            this.cmdConn.Name = "cmdConn";
            this.cmdConn.Size = new System.Drawing.Size(10, 13);
            this.cmdConn.TabIndex = 14;
            this.cmdConn.Text = "-";
            // 
            // btn_view_image
            // 
            this.btn_view_image.Location = new System.Drawing.Point(6, 111);
            this.btn_view_image.Name = "btn_view_image";
            this.btn_view_image.Size = new System.Drawing.Size(90, 42);
            this.btn_view_image.TabIndex = 15;
            this.btn_view_image.Text = "View Image";
            this.btn_view_image.UseVisualStyleBackColor = true;
            this.btn_view_image.Click += new System.EventHandler(this.btn_view_image_Click);
            // 
            // btn_auto_up_img
            // 
            this.btn_auto_up_img.Location = new System.Drawing.Point(6, 159);
            this.btn_auto_up_img.Name = "btn_auto_up_img";
            this.btn_auto_up_img.Size = new System.Drawing.Size(90, 42);
            this.btn_auto_up_img.TabIndex = 16;
            this.btn_auto_up_img.Text = "Upload Image";
            this.btn_auto_up_img.UseVisualStyleBackColor = true;
            this.btn_auto_up_img.Click += new System.EventHandler(this.btn_auto_up_img_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 326);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(902, 254);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btn_open_cam);
            this.tabPage1.Controls.Add(this.btn_auto_up_img);
            this.tabPage1.Controls.Add(this.cmbList);
            this.tabPage1.Controls.Add(this.btn_view_image);
            this.tabPage1.Controls.Add(this.chkPause);
            this.tabPage1.Controls.Add(this.cmdConn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(894, 228);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Upload image (Auto)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_upload_img);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 139);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Upload image (Manual)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 17;
            // 
            // New
            // 
            this.New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.New.Location = new System.Drawing.Point(16, 586);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(115, 40);
            this.New.TabIndex = 18;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(824, 586);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(86, 40);
            this.btn_export.TabIndex = 19;
            this.btn_export.Text = "Export .csv";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 658);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.New);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_save_card);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_readcard);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_readcard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save_card;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn citizenidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoRawDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewImageColumn photoBitmapDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrHouseNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrVillageNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrLaneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrRoadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrTambolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrAmphurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrProvinceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thPrefixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enPrefixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enFirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enLastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_upload_img;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbList;
        private System.Windows.Forms.Button btn_open_cam;
        private System.Windows.Forms.Button chkPause;
        private System.Windows.Forms.Label cmdConn;
        private System.Windows.Forms.Button btn_view_image;
        private System.Windows.Forms.Button btn_auto_up_img;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button btn_export;
    }
}

