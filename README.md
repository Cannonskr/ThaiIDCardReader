# ThaiIDCardReader
Windows Application (ThaiIDCardReader)
สำหรับอ่านข้อมูลบัตรประชาชนผ่านเครื่องอ่านบัตร SmartCard พร้อมเชื่อมต่อกับอุปกรณ์ webcams เพื่อบันทึกภาพจากอุปกรณ์ผ่าน application  
จัดเก็บข้อภายในบัตรในรูปแบบ text file และ local database (sqllite) และข้อมูลรูปภาพลง directory ภาพใน application



# Dependencies
NuGet\Install-Package AForge -Version 2.2.5
NuGet\Install-Package AForge.Controls -Version 2.2.5
NuGet\Install-Package AForge.Video -Version 2.2.5
NuGet\Install-Package AForge.Video.DirectShow -Version 2.2.5
NuGet\Install-Package VisioForge.DotNet.Core.TRIAL -Version 15.1.12
NuGet\Install-Package PCSC -Version 3.7.0
NuGet\Install-Package ThaiNationalIDCard -Version 2.0.0
NuGet\Install-Package SQLite -Version 3.13.0


#run program
1.build program
2.run : ThaiIDCardReader\bin\Debug\ThaiIDCardReader.exe

#screenshot
![image](https://user-images.githubusercontent.com/19383360/234030078-b502118d-39d5-4d72-8719-852bf94bbb3a.png)
