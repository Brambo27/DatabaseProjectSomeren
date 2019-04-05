using System;

namespace SomerenUI
{
    partial class SomerenUI
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
            System.Windows.Forms.ColumnHeader KamerNummer;
            System.Windows.Forms.Button btnUpgradeToSupervisor;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinkSupplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashregisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Dashboard = new System.Windows.Forms.Panel();
            this.imgDashboardLogo = new System.Windows.Forms.PictureBox();
            this.lbl_Dashboard = new System.Windows.Forms.Label();
            this.lblDrankVoorraad = new System.Windows.Forms.Label();
            this.listViewDrankVoorraad = new System.Windows.Forms.ListView();
            this.Naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Drank_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Voorraad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prijs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VoorraadStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Revenue = new System.Windows.Forms.Panel();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_endDate = new System.Windows.Forms.Label();
            this.lbl_startDate = new System.Windows.Forms.Label();
            this.lbl_Revenue = new System.Windows.Forms.Label();
            this.listViewRevenue = new System.Windows.Forms.ListView();
            this.Sales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Revenue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberOfCustomers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_DrinkSupply = new System.Windows.Forms.Panel();
            this.btnPrijsAanpassen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNieuwPrijs = new System.Windows.Forms.Label();
            this.lblNieuwVoorraad = new System.Windows.Forms.Label();
            this.lblNieuwNaam = new System.Windows.Forms.Label();
            this.txtNieuwVoorraad = new System.Windows.Forms.TextBox();
            this.txtNieuwPrijs = new System.Windows.Forms.TextBox();
            this.txtNieuwNaam = new System.Windows.Forms.TextBox();
            this.btnNieuwDrank = new System.Windows.Forms.Button();
            this.btnNaamAanpassen = new System.Windows.Forms.Button();
            this.txtAanpassenValue = new System.Windows.Forms.TextBox();
            this.btnVoorraadAanpassen = new System.Windows.Forms.Button();
            this.imgStudentsLogo = new System.Windows.Forms.PictureBox();
            this.pnl_Students = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Students = new System.Windows.Forms.Label();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.AantalBedden = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Docentenkamer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Teachers = new System.Windows.Forms.Panel();
            this.btnDowngradeToTeacher = new System.Windows.Forms.Button();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.teacherId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacherSupervisor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacherVak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgTeachersLogo = new System.Windows.Forms.PictureBox();
            this.lbl_Teachers = new System.Windows.Forms.Label();
            this.pnl_Rooms = new System.Windows.Forms.Panel();
            this.imgRoomsLogo = new System.Windows.Forms.PictureBox();
            this.lblRooms = new System.Windows.Forms.Label();
            this.pnl_CashRegister = new System.Windows.Forms.Panel();
            this.lbl_afrekenen = new System.Windows.Forms.Label();
            this.btn_afrekenen = new System.Windows.Forms.Button();
            this.listViewCRDrank = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_CashRegister = new System.Windows.Forms.Label();
            this.listViewCRStudents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Activity = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Change_Docents = new System.Windows.Forms.Button();
            this.Change_Students = new System.Windows.Forms.Button();
            this.Change_Name = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NewDocents = new System.Windows.Forms.TextBox();
            this.NewStudents = new System.Windows.Forms.TextBox();
            this.NewName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewActivity = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ActivityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Students = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Docents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnl_Schedule = new System.Windows.Forms.Panel();
            this.btn_ChangeSchedule = new System.Windows.Forms.Button();
            this.listViewSchedule = new System.Windows.Forms.ListView();
            this.chdrScheduleRoosterID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdrScheduleActivity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdrScheduleSupervisors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdrScheduleDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdrScheduleStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdrScheduleEndTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Schedule = new System.Windows.Forms.Label();
            this.pnl_Registratie = new System.Windows.Forms.Panel();
            this.txt_nieuwGeheimAntwoord = new System.Windows.Forms.TextBox();
            this.txt_nieuweGeheimeVraag = new System.Windows.Forms.TextBox();
            this.lbl_nieuwGeheimAntwoord = new System.Windows.Forms.Label();
            this.lbl_nieuweGeheimeVraag = new System.Windows.Forms.Label();
            this.btn_veranderWachtwoord = new System.Windows.Forms.Button();
            this.txt_nieuwWachtwoord = new System.Windows.Forms.TextBox();
            this.lbl_nieuwWachtwoord = new System.Windows.Forms.Label();
            this.btn_bevestigEmail = new System.Windows.Forms.Button();
            this.btnLogInGeheimeVraag = new System.Windows.Forms.Button();
            this.txt_geheimAntwoord = new System.Windows.Forms.TextBox();
            this.lbl_geheimeVraag = new System.Windows.Forms.Label();
            this.btn_forgotPassword = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_wachtwoord = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_wachtwoord = new System.Windows.Forms.Label();
            this.lbl_inlog_email = new System.Windows.Forms.Label();
            this.lbl_Inloggen = new System.Windows.Forms.Label();
            this.lbl_seperator = new System.Windows.Forms.Label();
            this.txtRegistrerenNaam = new System.Windows.Forms.TextBox();
            this.txtRegistrerenEmail = new System.Windows.Forms.TextBox();
            this.btnRegistreren = new System.Windows.Forms.Button();
            this.lblRegistratieSleutel = new System.Windows.Forms.Label();
            this.txtLicentiesleutel = new System.Windows.Forms.TextBox();
            this.lblRegistratieEmail = new System.Windows.Forms.Label();
            this.lblRegistratieNaam = new System.Windows.Forms.Label();
            this.lblRegistratieTitle = new System.Windows.Forms.Label();
            KamerNummer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            btnUpgradeToSupervisor = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnl_Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboardLogo)).BeginInit();
            this.pnl_Revenue.SuspendLayout();
            this.pnl_DrinkSupply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudentsLogo)).BeginInit();
            this.pnl_Students.SuspendLayout();
            this.pnl_Teachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeachersLogo)).BeginInit();
            this.pnl_Rooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRoomsLogo)).BeginInit();
            this.pnl_CashRegister.SuspendLayout();
            this.pnl_Activity.SuspendLayout();
            this.pnl_Schedule.SuspendLayout();
            this.pnl_Registratie.SuspendLayout();
            this.SuspendLayout();
            // 
            // KamerNummer
            // 
            KamerNummer.Text = "Kamernummer";
            KamerNummer.Width = 100;
            // 
            // btnUpgradeToSupervisor
            // 
            btnUpgradeToSupervisor.Location = new System.Drawing.Point(534, 43);
            btnUpgradeToSupervisor.Name = "btnUpgradeToSupervisor";
            btnUpgradeToSupervisor.Size = new System.Drawing.Size(155, 53);
            btnUpgradeToSupervisor.TabIndex = 6;
            btnUpgradeToSupervisor.Text = "Upgrade selected Teacher to Supervisor";
            btnUpgradeToSupervisor.UseVisualStyleBackColor = true;
            btnUpgradeToSupervisor.Click += new System.EventHandler(this.btnUpgradeToSupervisor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.barToolStripMenuItem,
            this.scheduleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1081, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.dashboardToolStripMenuItem.Text = "Application";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.activitiesToolStripMenuItem.Text = "Activities";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click);
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // barToolStripMenuItem
            // 
            this.barToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drinkSupplyToolStripMenuItem,
            this.cashregisterToolStripMenuItem,
            this.revenueToolStripMenuItem});
            this.barToolStripMenuItem.Name = "barToolStripMenuItem";
            this.barToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.barToolStripMenuItem.Text = "Bar";
            // 
            // drinkSupplyToolStripMenuItem
            // 
            this.drinkSupplyToolStripMenuItem.Name = "drinkSupplyToolStripMenuItem";
            this.drinkSupplyToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.drinkSupplyToolStripMenuItem.Text = "Liquor inventory";
            this.drinkSupplyToolStripMenuItem.Click += new System.EventHandler(this.drinkSupplyToolStripMenuItem_Click);
            // 
            // cashregisterToolStripMenuItem
            // 
            this.cashregisterToolStripMenuItem.Name = "cashregisterToolStripMenuItem";
            this.cashregisterToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cashregisterToolStripMenuItem.Text = "Cashregister";
            this.cashregisterToolStripMenuItem.Click += new System.EventHandler(this.cashregisterToolStripMenuItem_Click);
            // 
            // revenueToolStripMenuItem
            // 
            this.revenueToolStripMenuItem.Name = "revenueToolStripMenuItem";
            this.revenueToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.revenueToolStripMenuItem.Text = "Revenue report";
            this.revenueToolStripMenuItem.Click += new System.EventHandler(this.revenueToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // pnl_Dashboard
            // 
            this.pnl_Dashboard.Controls.Add(this.imgDashboardLogo);
            this.pnl_Dashboard.Controls.Add(this.lbl_Dashboard);
            this.pnl_Dashboard.Location = new System.Drawing.Point(15, 30);
            this.pnl_Dashboard.Name = "pnl_Dashboard";
            this.pnl_Dashboard.Size = new System.Drawing.Size(940, 470);
            this.pnl_Dashboard.TabIndex = 2;
            // 
            // imgDashboardLogo
            // 
            this.imgDashboardLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgDashboardLogo.Image")));
            this.imgDashboardLogo.InitialImage = null;
            this.imgDashboardLogo.Location = new System.Drawing.Point(805, 0);
            this.imgDashboardLogo.Name = "imgDashboardLogo";
            this.imgDashboardLogo.Size = new System.Drawing.Size(130, 123);
            this.imgDashboardLogo.TabIndex = 2;
            this.imgDashboardLogo.TabStop = false;
            this.imgDashboardLogo.Click += new System.EventHandler(this.img_Dashboard_Click);
            // 
            // lbl_Dashboard
            // 
            this.lbl_Dashboard.AutoSize = true;
            this.lbl_Dashboard.Location = new System.Drawing.Point(13, 13);
            this.lbl_Dashboard.Name = "lbl_Dashboard";
            this.lbl_Dashboard.Size = new System.Drawing.Size(185, 13);
            this.lbl_Dashboard.TabIndex = 1;
            this.lbl_Dashboard.Text = "Welcome to the Someren Application!";
            // 
            // lblDrankVoorraad
            // 
            this.lblDrankVoorraad.AutoSize = true;
            this.lblDrankVoorraad.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrankVoorraad.Location = new System.Drawing.Point(11, 11);
            this.lblDrankVoorraad.Name = "lblDrankVoorraad";
            this.lblDrankVoorraad.Size = new System.Drawing.Size(183, 29);
            this.lblDrankVoorraad.TabIndex = 3;
            this.lblDrankVoorraad.Text = "Liquor inventory";
            // 
            // listViewDrankVoorraad
            // 
            this.listViewDrankVoorraad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Naam,
            this.Drank_ID,
            this.Voorraad,
            this.Prijs,
            this.VoorraadStatus});
            this.listViewDrankVoorraad.FullRowSelect = true;
            this.listViewDrankVoorraad.HideSelection = false;
            this.listViewDrankVoorraad.Location = new System.Drawing.Point(16, 41);
            this.listViewDrankVoorraad.Name = "listViewDrankVoorraad";
            this.listViewDrankVoorraad.Size = new System.Drawing.Size(483, 307);
            this.listViewDrankVoorraad.TabIndex = 0;
            this.listViewDrankVoorraad.UseCompatibleStateImageBehavior = false;
            this.listViewDrankVoorraad.View = System.Windows.Forms.View.Details;
            // 
            // Naam
            // 
            this.Naam.DisplayIndex = 1;
            this.Naam.Text = "Name";
            this.Naam.Width = 100;
            // 
            // Drank_ID
            // 
            this.Drank_ID.DisplayIndex = 2;
            this.Drank_ID.Text = "Liquor_ID";
            this.Drank_ID.Width = 81;
            // 
            // Voorraad
            // 
            this.Voorraad.DisplayIndex = 3;
            this.Voorraad.Text = "Inventory";
            this.Voorraad.Width = 81;
            // 
            // Prijs
            // 
            this.Prijs.DisplayIndex = 4;
            this.Prijs.Text = "Price";
            // 
            // VoorraadStatus
            // 
            this.VoorraadStatus.DisplayIndex = 0;
            this.VoorraadStatus.Text = "X";
            // 
            // pnl_Revenue
            // 
            this.pnl_Revenue.Controls.Add(this.dateTimePickerStartDate);
            this.pnl_Revenue.Controls.Add(this.btn_Refresh);
            this.pnl_Revenue.Controls.Add(this.dateTimePickerEndDate);
            this.pnl_Revenue.Controls.Add(this.lbl_endDate);
            this.pnl_Revenue.Controls.Add(this.lbl_startDate);
            this.pnl_Revenue.Controls.Add(this.lbl_Revenue);
            this.pnl_Revenue.Controls.Add(this.listViewRevenue);
            this.pnl_Revenue.Location = new System.Drawing.Point(15, 30);
            this.pnl_Revenue.Name = "pnl_Revenue";
            this.pnl_Revenue.Size = new System.Drawing.Size(940, 470);
            this.pnl_Revenue.TabIndex = 3;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(49, 96);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerStartDate.MaxDate = new System.DateTime(2019, 5, 14, 0, 0, 0, 0);
            this.dateTimePickerStartDate.MinDate = new System.DateTime(2019, 5, 13, 0, 0, 0, 0);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerStartDate.TabIndex = 10;
            this.dateTimePickerStartDate.Value = new System.DateTime(2019, 5, 13, 0, 0, 0, 0);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Refresh.Location = new System.Drawing.Point(37, 199);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(380, 54);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(37, 146);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEndDate.MaxDate = new System.DateTime(2019, 5, 14, 0, 0, 0, 0);
            this.dateTimePickerEndDate.MinDate = new System.DateTime(2019, 5, 13, 0, 0, 0, 0);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEndDate.TabIndex = 8;
            this.dateTimePickerEndDate.Value = new System.DateTime(2019, 5, 14, 0, 0, 0, 0);
            // 
            // lbl_endDate
            // 
            this.lbl_endDate.AutoSize = true;
            this.lbl_endDate.Location = new System.Drawing.Point(39, 126);
            this.lbl_endDate.Name = "lbl_endDate";
            this.lbl_endDate.Size = new System.Drawing.Size(82, 13);
            this.lbl_endDate.TabIndex = 6;
            this.lbl_endDate.Text = "Select end date";
            // 
            // lbl_startDate
            // 
            this.lbl_startDate.AutoSize = true;
            this.lbl_startDate.Location = new System.Drawing.Point(39, 62);
            this.lbl_startDate.Name = "lbl_startDate";
            this.lbl_startDate.Size = new System.Drawing.Size(84, 13);
            this.lbl_startDate.TabIndex = 5;
            this.lbl_startDate.Text = "Select start date";
            // 
            // lbl_Revenue
            // 
            this.lbl_Revenue.AutoSize = true;
            this.lbl_Revenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Revenue.Location = new System.Drawing.Point(32, 10);
            this.lbl_Revenue.Name = "lbl_Revenue";
            this.lbl_Revenue.Size = new System.Drawing.Size(109, 29);
            this.lbl_Revenue.TabIndex = 1;
            this.lbl_Revenue.Text = "Revenue";
            // 
            // listViewRevenue
            // 
            this.listViewRevenue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sales,
            this.Revenue,
            this.NumberOfCustomers});
            this.listViewRevenue.Location = new System.Drawing.Point(37, 266);
            this.listViewRevenue.Name = "listViewRevenue";
            this.listViewRevenue.Size = new System.Drawing.Size(380, 107);
            this.listViewRevenue.TabIndex = 0;
            this.listViewRevenue.UseCompatibleStateImageBehavior = false;
            this.listViewRevenue.View = System.Windows.Forms.View.Details;
            // 
            // Sales
            // 
            this.Sales.Text = "Sales";
            this.Sales.Width = 117;
            // 
            // Revenue
            // 
            this.Revenue.Text = "Revenue";
            this.Revenue.Width = 105;
            // 
            // NumberOfCustomers
            // 
            this.NumberOfCustomers.Text = "Number of customers";
            this.NumberOfCustomers.Width = 148;
            // 
            // pnl_DrinkSupply
            // 
            this.pnl_DrinkSupply.Controls.Add(this.btnPrijsAanpassen);
            this.pnl_DrinkSupply.Controls.Add(this.label1);
            this.pnl_DrinkSupply.Controls.Add(this.lblNieuwPrijs);
            this.pnl_DrinkSupply.Controls.Add(this.lblNieuwVoorraad);
            this.pnl_DrinkSupply.Controls.Add(this.lblNieuwNaam);
            this.pnl_DrinkSupply.Controls.Add(this.txtNieuwVoorraad);
            this.pnl_DrinkSupply.Controls.Add(this.txtNieuwPrijs);
            this.pnl_DrinkSupply.Controls.Add(this.txtNieuwNaam);
            this.pnl_DrinkSupply.Controls.Add(this.btnNieuwDrank);
            this.pnl_DrinkSupply.Controls.Add(this.btnNaamAanpassen);
            this.pnl_DrinkSupply.Controls.Add(this.txtAanpassenValue);
            this.pnl_DrinkSupply.Controls.Add(this.btnVoorraadAanpassen);
            this.pnl_DrinkSupply.Controls.Add(this.lblDrankVoorraad);
            this.pnl_DrinkSupply.Controls.Add(this.listViewDrankVoorraad);
            this.pnl_DrinkSupply.Location = new System.Drawing.Point(15, 30);
            this.pnl_DrinkSupply.Name = "pnl_DrinkSupply";
            this.pnl_DrinkSupply.Size = new System.Drawing.Size(940, 470);
            this.pnl_DrinkSupply.TabIndex = 8;
            // 
            // btnPrijsAanpassen
            // 
            this.btnPrijsAanpassen.Location = new System.Drawing.Point(707, 94);
            this.btnPrijsAanpassen.Name = "btnPrijsAanpassen";
            this.btnPrijsAanpassen.Size = new System.Drawing.Size(75, 72);
            this.btnPrijsAanpassen.TabIndex = 22;
            this.btnPrijsAanpassen.Text = "Change price";
            this.btnPrijsAanpassen.UseVisualStyleBackColor = true;
            this.btnPrijsAanpassen.Click += new System.EventHandler(this.btnPrijsAanpassen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Value:";
            // 
            // lblNieuwPrijs
            // 
            this.lblNieuwPrijs.AutoSize = true;
            this.lblNieuwPrijs.Location = new System.Drawing.Point(388, 384);
            this.lblNieuwPrijs.Name = "lblNieuwPrijs";
            this.lblNieuwPrijs.Size = new System.Drawing.Size(34, 13);
            this.lblNieuwPrijs.TabIndex = 20;
            this.lblNieuwPrijs.Text = "Price:";
            // 
            // lblNieuwVoorraad
            // 
            this.lblNieuwVoorraad.AutoSize = true;
            this.lblNieuwVoorraad.Location = new System.Drawing.Point(196, 384);
            this.lblNieuwVoorraad.Name = "lblNieuwVoorraad";
            this.lblNieuwVoorraad.Size = new System.Drawing.Size(54, 13);
            this.lblNieuwVoorraad.TabIndex = 19;
            this.lblNieuwVoorraad.Text = "Inventory:";
            // 
            // lblNieuwNaam
            // 
            this.lblNieuwNaam.AutoSize = true;
            this.lblNieuwNaam.Location = new System.Drawing.Point(13, 381);
            this.lblNieuwNaam.Name = "lblNieuwNaam";
            this.lblNieuwNaam.Size = new System.Drawing.Size(38, 13);
            this.lblNieuwNaam.TabIndex = 17;
            this.lblNieuwNaam.Text = "Name:";
            // 
            // txtNieuwVoorraad
            // 
            this.txtNieuwVoorraad.Location = new System.Drawing.Point(255, 381);
            this.txtNieuwVoorraad.Name = "txtNieuwVoorraad";
            this.txtNieuwVoorraad.Size = new System.Drawing.Size(100, 20);
            this.txtNieuwVoorraad.TabIndex = 15;
            // 
            // txtNieuwPrijs
            // 
            this.txtNieuwPrijs.Location = new System.Drawing.Point(423, 381);
            this.txtNieuwPrijs.Name = "txtNieuwPrijs";
            this.txtNieuwPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtNieuwPrijs.TabIndex = 14;
            // 
            // txtNieuwNaam
            // 
            this.txtNieuwNaam.Location = new System.Drawing.Point(57, 381);
            this.txtNieuwNaam.Name = "txtNieuwNaam";
            this.txtNieuwNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNieuwNaam.TabIndex = 13;
            // 
            // btnNieuwDrank
            // 
            this.btnNieuwDrank.Location = new System.Drawing.Point(736, 381);
            this.btnNieuwDrank.Margin = new System.Windows.Forms.Padding(2);
            this.btnNieuwDrank.Name = "btnNieuwDrank";
            this.btnNieuwDrank.Size = new System.Drawing.Size(198, 83);
            this.btnNieuwDrank.TabIndex = 12;
            this.btnNieuwDrank.Text = "Add liquor";
            this.btnNieuwDrank.UseVisualStyleBackColor = true;
            this.btnNieuwDrank.Click += new System.EventHandler(this.btnNieuwDrank_Click);
            // 
            // btnNaamAanpassen
            // 
            this.btnNaamAanpassen.Location = new System.Drawing.Point(610, 94);
            this.btnNaamAanpassen.Margin = new System.Windows.Forms.Padding(2);
            this.btnNaamAanpassen.Name = "btnNaamAanpassen";
            this.btnNaamAanpassen.Size = new System.Drawing.Size(79, 72);
            this.btnNaamAanpassen.TabIndex = 11;
            this.btnNaamAanpassen.Text = "Change name";
            this.btnNaamAanpassen.UseVisualStyleBackColor = true;
            this.btnNaamAanpassen.Click += new System.EventHandler(this.btnNaamAanpassen_Click);
            // 
            // txtAanpassenValue
            // 
            this.txtAanpassenValue.Location = new System.Drawing.Point(610, 43);
            this.txtAanpassenValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtAanpassenValue.Name = "txtAanpassenValue";
            this.txtAanpassenValue.Size = new System.Drawing.Size(150, 20);
            this.txtAanpassenValue.TabIndex = 10;
            // 
            // btnVoorraadAanpassen
            // 
            this.btnVoorraadAanpassen.Location = new System.Drawing.Point(510, 94);
            this.btnVoorraadAanpassen.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoorraadAanpassen.Name = "btnVoorraadAanpassen";
            this.btnVoorraadAanpassen.Size = new System.Drawing.Size(84, 72);
            this.btnVoorraadAanpassen.TabIndex = 9;
            this.btnVoorraadAanpassen.Text = "Adjuist inventory";
            this.btnVoorraadAanpassen.UseVisualStyleBackColor = true;
            this.btnVoorraadAanpassen.Click += new System.EventHandler(this.btnVoorraadAanpassen_Click);
            // 
            // imgStudentsLogo
            // 
            this.imgStudentsLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgStudentsLogo.Image")));
            this.imgStudentsLogo.InitialImage = null;
            this.imgStudentsLogo.Location = new System.Drawing.Point(805, 0);
            this.imgStudentsLogo.Name = "imgStudentsLogo";
            this.imgStudentsLogo.Size = new System.Drawing.Size(130, 123);
            this.imgStudentsLogo.TabIndex = 0;
            this.imgStudentsLogo.TabStop = false;
            // 
            // pnl_Students
            // 
            this.pnl_Students.Controls.Add(this.listViewStudents);
            this.pnl_Students.Controls.Add(this.imgStudentsLogo);
            this.pnl_Students.Controls.Add(this.lbl_Students);
            this.pnl_Students.Location = new System.Drawing.Point(15, 30);
            this.pnl_Students.Name = "pnl_Students";
            this.pnl_Students.Size = new System.Drawing.Size(940, 470);
            this.pnl_Students.TabIndex = 4;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName,
            this.studentDOB});
            this.listViewStudents.Location = new System.Drawing.Point(16, 42);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(766, 307);
            this.listViewStudents.TabIndex = 5;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // studentID
            // 
            this.studentID.Text = "ID";
            // 
            // studentName
            // 
            this.studentName.Text = "Name";
            // 
            // studentDOB
            // 
            this.studentDOB.Text = "Date of Birth";
            // 
            // lbl_Students
            // 
            this.lbl_Students.AutoSize = true;
            this.lbl_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Students.Location = new System.Drawing.Point(10, 10);
            this.lbl_Students.Name = "lbl_Students";
            this.lbl_Students.Size = new System.Drawing.Size(107, 29);
            this.lbl_Students.TabIndex = 3;
            this.lbl_Students.Text = "Students";
            // 
            // listViewRooms
            // 
            this.listViewRooms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            KamerNummer,
            this.AantalBedden,
            this.Docentenkamer});
            this.listViewRooms.Location = new System.Drawing.Point(16, 42);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(766, 307);
            this.listViewRooms.TabIndex = 5;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // AantalBedden
            // 
            this.AantalBedden.Text = "AantalBedden";
            this.AantalBedden.Width = 100;
            // 
            // Docentenkamer
            // 
            this.Docentenkamer.Text = "DocentenKamer";
            this.Docentenkamer.Width = 100;
            // 
            // pnl_Teachers
            // 
            this.pnl_Teachers.Controls.Add(this.btnDowngradeToTeacher);
            this.pnl_Teachers.Controls.Add(btnUpgradeToSupervisor);
            this.pnl_Teachers.Controls.Add(this.listViewTeachers);
            this.pnl_Teachers.Controls.Add(this.imgTeachersLogo);
            this.pnl_Teachers.Controls.Add(this.lbl_Teachers);
            this.pnl_Teachers.Location = new System.Drawing.Point(15, 30);
            this.pnl_Teachers.Name = "pnl_Teachers";
            this.pnl_Teachers.Size = new System.Drawing.Size(940, 470);
            this.pnl_Teachers.TabIndex = 6;
            // 
            // btnDowngradeToTeacher
            // 
            this.btnDowngradeToTeacher.Location = new System.Drawing.Point(534, 115);
            this.btnDowngradeToTeacher.Name = "btnDowngradeToTeacher";
            this.btnDowngradeToTeacher.Size = new System.Drawing.Size(155, 51);
            this.btnDowngradeToTeacher.TabIndex = 7;
            this.btnDowngradeToTeacher.Text = "Downgrade slected Supervisor to Teacher";
            this.btnDowngradeToTeacher.UseVisualStyleBackColor = true;
            this.btnDowngradeToTeacher.Click += new System.EventHandler(this.btnDowngradeToTeacher_Click);
            // 
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.teacherId,
            this.teacherSupervisor,
            this.teacherVak});
            this.listViewTeachers.FullRowSelect = true;
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(16, 42);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(507, 307);
            this.listViewTeachers.TabIndex = 5;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            this.listViewTeachers.View = System.Windows.Forms.View.Details;
            this.listViewTeachers.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewTeachers_ColumnClick);
            // 
            // teacherId
            // 
            this.teacherId.Text = "ID";
            this.teacherId.Width = 54;
            // 
            // teacherSupervisor
            // 
            this.teacherSupervisor.Text = "Name";
            this.teacherSupervisor.Width = 139;
            // 
            // teacherVak
            // 
            this.teacherVak.Text = "Supervisor";
            this.teacherVak.Width = 134;
            // 
            // imgTeachersLogo
            // 
            this.imgTeachersLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgTeachersLogo.Image")));
            this.imgTeachersLogo.InitialImage = null;
            this.imgTeachersLogo.Location = new System.Drawing.Point(805, 0);
            this.imgTeachersLogo.Name = "imgTeachersLogo";
            this.imgTeachersLogo.Size = new System.Drawing.Size(130, 123);
            this.imgTeachersLogo.TabIndex = 0;
            this.imgTeachersLogo.TabStop = false;
            // 
            // lbl_Teachers
            // 
            this.lbl_Teachers.AutoSize = true;
            this.lbl_Teachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Teachers.Location = new System.Drawing.Point(10, 10);
            this.lbl_Teachers.Name = "lbl_Teachers";
            this.lbl_Teachers.Size = new System.Drawing.Size(113, 29);
            this.lbl_Teachers.TabIndex = 3;
            this.lbl_Teachers.Text = "Lecturers";
            // 
            // pnl_Rooms
            // 
            this.pnl_Rooms.Controls.Add(this.listViewRooms);
            this.pnl_Rooms.Controls.Add(this.imgRoomsLogo);
            this.pnl_Rooms.Controls.Add(this.lblRooms);
            this.pnl_Rooms.Location = new System.Drawing.Point(15, 30);
            this.pnl_Rooms.Name = "pnl_Rooms";
            this.pnl_Rooms.Size = new System.Drawing.Size(940, 470);
            this.pnl_Rooms.TabIndex = 7;
            // 
            // imgRoomsLogo
            // 
            this.imgRoomsLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgRoomsLogo.Image")));
            this.imgRoomsLogo.InitialImage = null;
            this.imgRoomsLogo.Location = new System.Drawing.Point(805, 0);
            this.imgRoomsLogo.Name = "imgRoomsLogo";
            this.imgRoomsLogo.Size = new System.Drawing.Size(130, 123);
            this.imgRoomsLogo.TabIndex = 0;
            this.imgRoomsLogo.TabStop = false;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRooms.Location = new System.Drawing.Point(10, 10);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(78, 29);
            this.lblRooms.TabIndex = 1;
            this.lblRooms.Text = "Room";
            // 
            // pnl_CashRegister
            // 
            this.pnl_CashRegister.Controls.Add(this.lbl_afrekenen);
            this.pnl_CashRegister.Controls.Add(this.btn_afrekenen);
            this.pnl_CashRegister.Controls.Add(this.listViewCRDrank);
            this.pnl_CashRegister.Controls.Add(this.lbl_CashRegister);
            this.pnl_CashRegister.Controls.Add(this.listViewCRStudents);
            this.pnl_CashRegister.Location = new System.Drawing.Point(12, 30);
            this.pnl_CashRegister.Name = "pnl_CashRegister";
            this.pnl_CashRegister.Size = new System.Drawing.Size(940, 470);
            this.pnl_CashRegister.TabIndex = 9;
            // 
            // lbl_afrekenen
            // 
            this.lbl_afrekenen.AutoSize = true;
            this.lbl_afrekenen.Location = new System.Drawing.Point(707, 192);
            this.lbl_afrekenen.Name = "lbl_afrekenen";
            this.lbl_afrekenen.Size = new System.Drawing.Size(25, 13);
            this.lbl_afrekenen.TabIndex = 4;
            this.lbl_afrekenen.Text = "???";
            // 
            // btn_afrekenen
            // 
            this.btn_afrekenen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btn_afrekenen.Location = new System.Drawing.Point(710, 100);
            this.btn_afrekenen.Name = "btn_afrekenen";
            this.btn_afrekenen.Size = new System.Drawing.Size(198, 66);
            this.btn_afrekenen.TabIndex = 3;
            this.btn_afrekenen.Text = "Afrekenen";
            this.btn_afrekenen.UseVisualStyleBackColor = true;
            this.btn_afrekenen.Click += new System.EventHandler(this.btn_afrekene_Click);
            // 
            // listViewCRDrank
            // 
            this.listViewCRDrank.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewCRDrank.FullRowSelect = true;
            this.listViewCRDrank.HideSelection = false;
            this.listViewCRDrank.Location = new System.Drawing.Point(406, 62);
            this.listViewCRDrank.Name = "listViewCRDrank";
            this.listViewCRDrank.Size = new System.Drawing.Size(255, 371);
            this.listViewCRDrank.TabIndex = 2;
            this.listViewCRDrank.UseCompatibleStateImageBehavior = false;
            this.listViewCRDrank.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "DrankID";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "DrankNaam";
            this.columnHeader4.Width = 150;
            // 
            // lbl_CashRegister
            // 
            this.lbl_CashRegister.AutoSize = true;
            this.lbl_CashRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbl_CashRegister.Location = new System.Drawing.Point(37, 22);
            this.lbl_CashRegister.Name = "lbl_CashRegister";
            this.lbl_CashRegister.Size = new System.Drawing.Size(159, 29);
            this.lbl_CashRegister.TabIndex = 1;
            this.lbl_CashRegister.Text = "CashRegister";
            // 
            // listViewCRStudents
            // 
            this.listViewCRStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewCRStudents.FullRowSelect = true;
            this.listViewCRStudents.HideSelection = false;
            listViewItem3.Tag = "Student_nummer";
            this.listViewCRStudents.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listViewCRStudents.Location = new System.Drawing.Point(45, 62);
            this.listViewCRStudents.MultiSelect = false;
            this.listViewCRStudents.Name = "listViewCRStudents";
            this.listViewCRStudents.Size = new System.Drawing.Size(254, 371);
            this.listViewCRStudents.TabIndex = 0;
            this.listViewCRStudents.UseCompatibleStateImageBehavior = false;
            this.listViewCRStudents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "StudentID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "StudentName";
            this.columnHeader2.Width = 150;
            // 
            // pnl_Activity
            // 
            this.pnl_Activity.Controls.Add(this.Delete);
            this.pnl_Activity.Controls.Add(this.label7);
            this.pnl_Activity.Controls.Add(this.Change_Docents);
            this.pnl_Activity.Controls.Add(this.Change_Students);
            this.pnl_Activity.Controls.Add(this.Change_Name);
            this.pnl_Activity.Controls.Add(this.txtValue);
            this.pnl_Activity.Controls.Add(this.Value);
            this.pnl_Activity.Controls.Add(this.label3);
            this.pnl_Activity.Controls.Add(this.button1);
            this.pnl_Activity.Controls.Add(this.label6);
            this.pnl_Activity.Controls.Add(this.label5);
            this.pnl_Activity.Controls.Add(this.label4);
            this.pnl_Activity.Controls.Add(this.NewDocents);
            this.pnl_Activity.Controls.Add(this.NewStudents);
            this.pnl_Activity.Controls.Add(this.NewName);
            this.pnl_Activity.Controls.Add(this.label2);
            this.pnl_Activity.Controls.Add(this.listViewActivity);
            this.pnl_Activity.Location = new System.Drawing.Point(12, 30);
            this.pnl_Activity.Name = "pnl_Activity";
            this.pnl_Activity.Size = new System.Drawing.Size(943, 470);
            this.pnl_Activity.TabIndex = 23;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(512, 330);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(235, 43);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete selected item";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(402, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(540, 10);
            this.label7.TabIndex = 17;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Change_Docents
            // 
            this.Change_Docents.Location = new System.Drawing.Point(641, 245);
            this.Change_Docents.Name = "Change_Docents";
            this.Change_Docents.Size = new System.Drawing.Size(106, 23);
            this.Change_Docents.TabIndex = 16;
            this.Change_Docents.Text = "Change Docents";
            this.Change_Docents.UseVisualStyleBackColor = true;
            this.Change_Docents.Click += new System.EventHandler(this.Change_Docents_Click);
            // 
            // Change_Students
            // 
            this.Change_Students.Location = new System.Drawing.Point(641, 216);
            this.Change_Students.Name = "Change_Students";
            this.Change_Students.Size = new System.Drawing.Size(106, 23);
            this.Change_Students.TabIndex = 15;
            this.Change_Students.Text = "Change Students";
            this.Change_Students.UseVisualStyleBackColor = true;
            this.Change_Students.Click += new System.EventHandler(this.Change_Students_Click);
            // 
            // Change_Name
            // 
            this.Change_Name.Location = new System.Drawing.Point(641, 187);
            this.Change_Name.Name = "Change_Name";
            this.Change_Name.Size = new System.Drawing.Size(106, 23);
            this.Change_Name.TabIndex = 14;
            this.Change_Name.Text = "Change name";
            this.Change_Name.UseVisualStyleBackColor = true;
            this.Change_Name.Click += new System.EventHandler(this.Change_Name_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(512, 218);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 13;
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Location = new System.Drawing.Point(422, 221);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(34, 13);
            this.Value.TabIndex = 12;
            this.Value.Text = "Value";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(401, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(540, 10);
            this.label3.TabIndex = 11;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(641, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 42);
            this.button1.TabIndex = 10;
            this.button1.Text = "Make new Activity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnNewActivity_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Docents";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(422, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Students";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // NewDocents
            // 
            this.NewDocents.Location = new System.Drawing.Point(512, 128);
            this.NewDocents.Name = "NewDocents";
            this.NewDocents.Size = new System.Drawing.Size(49, 20);
            this.NewDocents.TabIndex = 5;
            // 
            // NewStudents
            // 
            this.NewStudents.Location = new System.Drawing.Point(512, 102);
            this.NewStudents.Name = "NewStudents";
            this.NewStudents.Size = new System.Drawing.Size(49, 20);
            this.NewStudents.TabIndex = 4;
            // 
            // NewName
            // 
            this.NewName.Location = new System.Drawing.Point(512, 76);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(100, 20);
            this.NewName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label2.Location = new System.Drawing.Point(47, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Activity";
            // 
            // listViewActivity
            // 
            this.listViewActivity.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewActivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ActivityName,
            this.Students,
            this.Docents});
            this.listViewActivity.FullRowSelect = true;
            this.listViewActivity.HideSelection = false;
            this.listViewActivity.Location = new System.Drawing.Point(52, 62);
            this.listViewActivity.Name = "listViewActivity";
            this.listViewActivity.Size = new System.Drawing.Size(348, 361);
            this.listViewActivity.TabIndex = 0;
            this.listViewActivity.UseCompatibleStateImageBehavior = false;
            this.listViewActivity.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // ActivityName
            // 
            this.ActivityName.Text = "ActivityName";
            this.ActivityName.Width = 150;
            // 
            // Students
            // 
            this.Students.Text = "Students";
            // 
            // Docents
            // 
            this.Docents.Text = "Docents";
            // 
            // pnl_Schedule
            // 
            this.pnl_Schedule.Controls.Add(this.btn_ChangeSchedule);
            this.pnl_Schedule.Controls.Add(this.listViewSchedule);
            this.pnl_Schedule.Controls.Add(this.lbl_Schedule);
            this.pnl_Schedule.Location = new System.Drawing.Point(11, 30);
            this.pnl_Schedule.Name = "pnl_Schedule";
            this.pnl_Schedule.Size = new System.Drawing.Size(943, 423);
            this.pnl_Schedule.TabIndex = 24;
            // 
            // btn_ChangeSchedule
            // 
            this.btn_ChangeSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btn_ChangeSchedule.Location = new System.Drawing.Point(660, 139);
            this.btn_ChangeSchedule.Name = "btn_ChangeSchedule";
            this.btn_ChangeSchedule.Size = new System.Drawing.Size(225, 71);
            this.btn_ChangeSchedule.TabIndex = 2;
            this.btn_ChangeSchedule.Text = "Change schedule (does work)";
            this.btn_ChangeSchedule.UseVisualStyleBackColor = true;
            this.btn_ChangeSchedule.Click += new System.EventHandler(this.btn_ChangeSchedule_Click);
            // 
            // listViewSchedule
            // 
            this.listViewSchedule.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdrScheduleRoosterID,
            this.chdrScheduleActivity,
            this.chdrScheduleSupervisors,
            this.chdrScheduleDate,
            this.chdrScheduleStartTime,
            this.chdrScheduleEndTime});
            this.listViewSchedule.FullRowSelect = true;
            this.listViewSchedule.HideSelection = false;
            this.listViewSchedule.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listViewSchedule.Location = new System.Drawing.Point(30, 58);
            this.listViewSchedule.Name = "listViewSchedule";
            this.listViewSchedule.Size = new System.Drawing.Size(581, 311);
            this.listViewSchedule.TabIndex = 1;
            this.listViewSchedule.UseCompatibleStateImageBehavior = false;
            this.listViewSchedule.View = System.Windows.Forms.View.Details;
            // 
            // chdrScheduleRoosterID
            // 
            this.chdrScheduleRoosterID.Text = "RoosterID";
            // 
            // chdrScheduleActivity
            // 
            this.chdrScheduleActivity.Text = "Activity";
            this.chdrScheduleActivity.Width = 111;
            // 
            // chdrScheduleSupervisors
            // 
            this.chdrScheduleSupervisors.Text = "Supervisors";
            this.chdrScheduleSupervisors.Width = 106;
            // 
            // chdrScheduleDate
            // 
            this.chdrScheduleDate.Text = "Date";
            this.chdrScheduleDate.Width = 80;
            // 
            // chdrScheduleStartTime
            // 
            this.chdrScheduleStartTime.Text = "Start time";
            this.chdrScheduleStartTime.Width = 101;
            // 
            // chdrScheduleEndTime
            // 
            this.chdrScheduleEndTime.Text = "End time";
            this.chdrScheduleEndTime.Width = 79;
            // 
            // lbl_Schedule
            // 
            this.lbl_Schedule.AutoSize = true;
            this.lbl_Schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbl_Schedule.Location = new System.Drawing.Point(25, 26);
            this.lbl_Schedule.Name = "lbl_Schedule";
            this.lbl_Schedule.Size = new System.Drawing.Size(115, 29);
            this.lbl_Schedule.TabIndex = 0;
            this.lbl_Schedule.Text = "Schedule";
            // 
            // pnl_Registratie
            // 
            this.pnl_Registratie.Controls.Add(this.txt_nieuwGeheimAntwoord);
            this.pnl_Registratie.Controls.Add(this.txt_nieuweGeheimeVraag);
            this.pnl_Registratie.Controls.Add(this.lbl_nieuwGeheimAntwoord);
            this.pnl_Registratie.Controls.Add(this.lbl_nieuweGeheimeVraag);
            this.pnl_Registratie.Controls.Add(this.btn_veranderWachtwoord);
            this.pnl_Registratie.Controls.Add(this.txt_nieuwWachtwoord);
            this.pnl_Registratie.Controls.Add(this.lbl_nieuwWachtwoord);
            this.pnl_Registratie.Controls.Add(this.btn_bevestigEmail);
            this.pnl_Registratie.Controls.Add(this.btnLogInGeheimeVraag);
            this.pnl_Registratie.Controls.Add(this.txt_geheimAntwoord);
            this.pnl_Registratie.Controls.Add(this.lbl_geheimeVraag);
            this.pnl_Registratie.Controls.Add(this.btn_forgotPassword);
            this.pnl_Registratie.Controls.Add(this.btn_login);
            this.pnl_Registratie.Controls.Add(this.txt_wachtwoord);
            this.pnl_Registratie.Controls.Add(this.txt_email);
            this.pnl_Registratie.Controls.Add(this.lbl_wachtwoord);
            this.pnl_Registratie.Controls.Add(this.lbl_inlog_email);
            this.pnl_Registratie.Controls.Add(this.lbl_Inloggen);
            this.pnl_Registratie.Controls.Add(this.lbl_seperator);
            this.pnl_Registratie.Controls.Add(this.txtRegistrerenNaam);
            this.pnl_Registratie.Controls.Add(this.txtRegistrerenEmail);
            this.pnl_Registratie.Controls.Add(this.btnRegistreren);
            this.pnl_Registratie.Controls.Add(this.lblRegistratieSleutel);
            this.pnl_Registratie.Controls.Add(this.txtLicentiesleutel);
            this.pnl_Registratie.Controls.Add(this.lblRegistratieEmail);
            this.pnl_Registratie.Controls.Add(this.lblRegistratieNaam);
            this.pnl_Registratie.Controls.Add(this.lblRegistratieTitle);
            this.pnl_Registratie.Location = new System.Drawing.Point(0, 0);
            this.pnl_Registratie.Name = "pnl_Registratie";
            this.pnl_Registratie.Size = new System.Drawing.Size(1081, 500);
            this.pnl_Registratie.TabIndex = 25;
            this.pnl_Registratie.Visible = false;
            // 
            // txt_nieuwGeheimAntwoord
            // 
            this.txt_nieuwGeheimAntwoord.Location = new System.Drawing.Point(732, 139);
            this.txt_nieuwGeheimAntwoord.Name = "txt_nieuwGeheimAntwoord";
            this.txt_nieuwGeheimAntwoord.Size = new System.Drawing.Size(269, 20);
            this.txt_nieuwGeheimAntwoord.TabIndex = 46;
            this.txt_nieuwGeheimAntwoord.Visible = false;
            // 
            // txt_nieuweGeheimeVraag
            // 
            this.txt_nieuweGeheimeVraag.Location = new System.Drawing.Point(732, 113);
            this.txt_nieuweGeheimeVraag.Name = "txt_nieuweGeheimeVraag";
            this.txt_nieuweGeheimeVraag.Size = new System.Drawing.Size(269, 20);
            this.txt_nieuweGeheimeVraag.TabIndex = 45;
            this.txt_nieuweGeheimeVraag.Visible = false;
            // 
            // lbl_nieuwGeheimAntwoord
            // 
            this.lbl_nieuwGeheimAntwoord.AutoSize = true;
            this.lbl_nieuwGeheimAntwoord.Location = new System.Drawing.Point(552, 142);
            this.lbl_nieuwGeheimAntwoord.Name = "lbl_nieuwGeheimAntwoord";
            this.lbl_nieuwGeheimAntwoord.Size = new System.Drawing.Size(179, 13);
            this.lbl_nieuwGeheimAntwoord.TabIndex = 44;
            this.lbl_nieuwGeheimAntwoord.Text = "Voer een nieuw geheim antwoord in:";
            this.lbl_nieuwGeheimAntwoord.Visible = false;
            // 
            // lbl_nieuweGeheimeVraag
            // 
            this.lbl_nieuweGeheimeVraag.AutoSize = true;
            this.lbl_nieuweGeheimeVraag.Location = new System.Drawing.Point(552, 116);
            this.lbl_nieuweGeheimeVraag.Name = "lbl_nieuweGeheimeVraag";
            this.lbl_nieuweGeheimeVraag.Size = new System.Drawing.Size(174, 13);
            this.lbl_nieuweGeheimeVraag.TabIndex = 43;
            this.lbl_nieuweGeheimeVraag.Text = "Voer een nieuwe geheime vraag in:";
            this.lbl_nieuweGeheimeVraag.Visible = false;
            // 
            // btn_veranderWachtwoord
            // 
            this.btn_veranderWachtwoord.Location = new System.Drawing.Point(653, 179);
            this.btn_veranderWachtwoord.Name = "btn_veranderWachtwoord";
            this.btn_veranderWachtwoord.Size = new System.Drawing.Size(254, 40);
            this.btn_veranderWachtwoord.TabIndex = 42;
            this.btn_veranderWachtwoord.Text = "Bevestig veranderingen";
            this.btn_veranderWachtwoord.UseVisualStyleBackColor = true;
            this.btn_veranderWachtwoord.Visible = false;
            this.btn_veranderWachtwoord.Click += new System.EventHandler(this.btn_veranderWachtwoord_Click);
            // 
            // txt_nieuwWachtwoord
            // 
            this.txt_nieuwWachtwoord.Location = new System.Drawing.Point(555, 89);
            this.txt_nieuwWachtwoord.Name = "txt_nieuwWachtwoord";
            this.txt_nieuwWachtwoord.Size = new System.Drawing.Size(446, 20);
            this.txt_nieuwWachtwoord.TabIndex = 41;
            this.txt_nieuwWachtwoord.Visible = false;
            // 
            // lbl_nieuwWachtwoord
            // 
            this.lbl_nieuwWachtwoord.AutoSize = true;
            this.lbl_nieuwWachtwoord.Location = new System.Drawing.Point(554, 56);
            this.lbl_nieuwWachtwoord.Name = "lbl_nieuwWachtwoord";
            this.lbl_nieuwWachtwoord.Size = new System.Drawing.Size(421, 26);
            this.lbl_nieuwWachtwoord.TabIndex = 40;
            this.lbl_nieuwWachtwoord.Text = "Voer uw nieuwe wachtwoord in van minimaal 8 characters in.\r\nHet wachtwoord moet e" +
    "en hoofdletter, kleine letter, leesteken en een nummer bevatten.";
            this.lbl_nieuwWachtwoord.Visible = false;
            // 
            // btn_bevestigEmail
            // 
            this.btn_bevestigEmail.Location = new System.Drawing.Point(914, 72);
            this.btn_bevestigEmail.Name = "btn_bevestigEmail";
            this.btn_bevestigEmail.Size = new System.Drawing.Size(75, 23);
            this.btn_bevestigEmail.TabIndex = 39;
            this.btn_bevestigEmail.Text = "Bevestig";
            this.btn_bevestigEmail.UseVisualStyleBackColor = true;
            this.btn_bevestigEmail.Visible = false;
            this.btn_bevestigEmail.Click += new System.EventHandler(this.btn_bevestigEmail_Click);
            // 
            // btnLogInGeheimeVraag
            // 
            this.btnLogInGeheimeVraag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLogInGeheimeVraag.Location = new System.Drawing.Point(557, 192);
            this.btnLogInGeheimeVraag.Name = "btnLogInGeheimeVraag";
            this.btnLogInGeheimeVraag.Size = new System.Drawing.Size(339, 32);
            this.btnLogInGeheimeVraag.TabIndex = 38;
            this.btnLogInGeheimeVraag.Text = "Bevestig antwoord";
            this.btnLogInGeheimeVraag.UseVisualStyleBackColor = true;
            this.btnLogInGeheimeVraag.Visible = false;
            this.btnLogInGeheimeVraag.Click += new System.EventHandler(this.btnLogInGeheimeVraag_Click);
            // 
            // txt_geheimAntwoord
            // 
            this.txt_geheimAntwoord.Location = new System.Drawing.Point(555, 151);
            this.txt_geheimAntwoord.Name = "txt_geheimAntwoord";
            this.txt_geheimAntwoord.Size = new System.Drawing.Size(340, 20);
            this.txt_geheimAntwoord.TabIndex = 37;
            this.txt_geheimAntwoord.Visible = false;
            // 
            // lbl_geheimeVraag
            // 
            this.lbl_geheimeVraag.AutoSize = true;
            this.lbl_geheimeVraag.Location = new System.Drawing.Point(553, 126);
            this.lbl_geheimeVraag.Name = "lbl_geheimeVraag";
            this.lbl_geheimeVraag.Size = new System.Drawing.Size(0, 13);
            this.lbl_geheimeVraag.TabIndex = 36;
            this.lbl_geheimeVraag.Visible = false;
            // 
            // btn_forgotPassword
            // 
            this.btn_forgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_forgotPassword.Location = new System.Drawing.Point(556, 238);
            this.btn_forgotPassword.Name = "btn_forgotPassword";
            this.btn_forgotPassword.Size = new System.Drawing.Size(340, 35);
            this.btn_forgotPassword.TabIndex = 35;
            this.btn_forgotPassword.Text = "Wachtwoord vergeten?";
            this.btn_forgotPassword.UseVisualStyleBackColor = true;
            this.btn_forgotPassword.Click += new System.EventHandler(this.btn_forgotPassword_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_login.Location = new System.Drawing.Point(556, 191);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(340, 33);
            this.btn_login.TabIndex = 34;
            this.btn_login.Text = "Log in";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_wachtwoord
            // 
            this.txt_wachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_wachtwoord.Location = new System.Drawing.Point(697, 94);
            this.txt_wachtwoord.Name = "txt_wachtwoord";
            this.txt_wachtwoord.PasswordChar = '*';
            this.txt_wachtwoord.Size = new System.Drawing.Size(199, 20);
            this.txt_wachtwoord.TabIndex = 33;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(697, 73);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(199, 20);
            this.txt_email.TabIndex = 32;
            // 
            // lbl_wachtwoord
            // 
            this.lbl_wachtwoord.AutoSize = true;
            this.lbl_wachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_wachtwoord.Location = new System.Drawing.Point(552, 92);
            this.lbl_wachtwoord.Name = "lbl_wachtwoord";
            this.lbl_wachtwoord.Size = new System.Drawing.Size(102, 20);
            this.lbl_wachtwoord.TabIndex = 31;
            this.lbl_wachtwoord.Text = "Wachtwoord:";
            // 
            // lbl_inlog_email
            // 
            this.lbl_inlog_email.AutoSize = true;
            this.lbl_inlog_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_inlog_email.Location = new System.Drawing.Point(551, 68);
            this.lbl_inlog_email.Name = "lbl_inlog_email";
            this.lbl_inlog_email.Size = new System.Drawing.Size(52, 20);
            this.lbl_inlog_email.TabIndex = 30;
            this.lbl_inlog_email.Text = "Email:";
            // 
            // lbl_Inloggen
            // 
            this.lbl_Inloggen.AutoSize = true;
            this.lbl_Inloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lbl_Inloggen.Location = new System.Drawing.Point(549, 11);
            this.lbl_Inloggen.Name = "lbl_Inloggen";
            this.lbl_Inloggen.Size = new System.Drawing.Size(107, 29);
            this.lbl_Inloggen.TabIndex = 29;
            this.lbl_Inloggen.Text = "Inloggen";
            // 
            // lbl_seperator
            // 
            this.lbl_seperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_seperator.Location = new System.Drawing.Point(533, 0);
            this.lbl_seperator.Name = "lbl_seperator";
            this.lbl_seperator.Size = new System.Drawing.Size(10, 506);
            this.lbl_seperator.TabIndex = 28;
            // 
            // txtRegistrerenNaam
            // 
            this.txtRegistrerenNaam.Location = new System.Drawing.Point(100, 65);
            this.txtRegistrerenNaam.Name = "txtRegistrerenNaam";
            this.txtRegistrerenNaam.Size = new System.Drawing.Size(133, 20);
            this.txtRegistrerenNaam.TabIndex = 27;
            // 
            // txtRegistrerenEmail
            // 
            this.txtRegistrerenEmail.Location = new System.Drawing.Point(100, 86);
            this.txtRegistrerenEmail.Name = "txtRegistrerenEmail";
            this.txtRegistrerenEmail.Size = new System.Drawing.Size(221, 20);
            this.txtRegistrerenEmail.TabIndex = 26;
            // 
            // btnRegistreren
            // 
            this.btnRegistreren.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.btnRegistreren.Location = new System.Drawing.Point(16, 209);
            this.btnRegistreren.Name = "btnRegistreren";
            this.btnRegistreren.Size = new System.Drawing.Size(351, 47);
            this.btnRegistreren.TabIndex = 5;
            this.btnRegistreren.Text = "Registreren";
            this.btnRegistreren.UseVisualStyleBackColor = true;
            this.btnRegistreren.Click += new System.EventHandler(this.btnRegistreren_Click);
            // 
            // lblRegistratieSleutel
            // 
            this.lblRegistratieSleutel.AutoSize = true;
            this.lblRegistratieSleutel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRegistratieSleutel.Location = new System.Drawing.Point(11, 127);
            this.lblRegistratieSleutel.Name = "lblRegistratieSleutel";
            this.lblRegistratieSleutel.Size = new System.Drawing.Size(108, 20);
            this.lblRegistratieSleutel.TabIndex = 4;
            this.lblRegistratieSleutel.Text = "licentiesleutel:";
            // 
            // txtLicentiesleutel
            // 
            this.txtLicentiesleutel.Location = new System.Drawing.Point(15, 148);
            this.txtLicentiesleutel.Name = "txtLicentiesleutel";
            this.txtLicentiesleutel.Size = new System.Drawing.Size(352, 20);
            this.txtLicentiesleutel.TabIndex = 3;
            // 
            // lblRegistratieEmail
            // 
            this.lblRegistratieEmail.AutoSize = true;
            this.lblRegistratieEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRegistratieEmail.Location = new System.Drawing.Point(12, 84);
            this.lblRegistratieEmail.Name = "lblRegistratieEmail";
            this.lblRegistratieEmail.Size = new System.Drawing.Size(52, 20);
            this.lblRegistratieEmail.TabIndex = 2;
            this.lblRegistratieEmail.Text = "Email:";
            // 
            // lblRegistratieNaam
            // 
            this.lblRegistratieNaam.AutoSize = true;
            this.lblRegistratieNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRegistratieNaam.Location = new System.Drawing.Point(11, 63);
            this.lblRegistratieNaam.Name = "lblRegistratieNaam";
            this.lblRegistratieNaam.Size = new System.Drawing.Size(55, 20);
            this.lblRegistratieNaam.TabIndex = 1;
            this.lblRegistratieNaam.Text = "Naam:";
            // 
            // lblRegistratieTitle
            // 
            this.lblRegistratieTitle.AutoSize = true;
            this.lblRegistratieTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblRegistratieTitle.Location = new System.Drawing.Point(10, 11);
            this.lblRegistratieTitle.Name = "lblRegistratieTitle";
            this.lblRegistratieTitle.Size = new System.Drawing.Size(129, 29);
            this.lblRegistratieTitle.TabIndex = 0;
            this.lblRegistratieTitle.Text = "Registratie";
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 505);
            this.Controls.Add(this.pnl_Registratie);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnl_Students);
            this.Controls.Add(this.pnl_CashRegister);
            this.Controls.Add(this.pnl_Revenue);
            this.Controls.Add(this.pnl_Activity);
            this.Controls.Add(this.pnl_DrinkSupply);
            this.Controls.Add(this.pnl_Dashboard);
            this.Controls.Add(this.pnl_Rooms);
            this.Controls.Add(this.pnl_Schedule);
            this.Controls.Add(this.pnl_Teachers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SomerenUI";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SomerenApp";
            this.Load += new System.EventHandler(this.SomerenUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_Dashboard.ResumeLayout(false);
            this.pnl_Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDashboardLogo)).EndInit();
            this.pnl_Revenue.ResumeLayout(false);
            this.pnl_Revenue.PerformLayout();
            this.pnl_DrinkSupply.ResumeLayout(false);
            this.pnl_DrinkSupply.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudentsLogo)).EndInit();
            this.pnl_Students.ResumeLayout(false);
            this.pnl_Students.PerformLayout();
            this.pnl_Teachers.ResumeLayout(false);
            this.pnl_Teachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeachersLogo)).EndInit();
            this.pnl_Rooms.ResumeLayout(false);
            this.pnl_Rooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgRoomsLogo)).EndInit();
            this.pnl_CashRegister.ResumeLayout(false);
            this.pnl_CashRegister.PerformLayout();
            this.pnl_Activity.ResumeLayout(false);
            this.pnl_Activity.PerformLayout();
            this.pnl_Schedule.ResumeLayout(false);
            this.pnl_Schedule.PerformLayout();
            this.pnl_Registratie.ResumeLayout(false);
            this.pnl_Registratie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Dashboard;
        private System.Windows.Forms.Label lbl_Dashboard;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgStudentsLogo;
        private System.Windows.Forms.Panel pnl_Students;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentDOB;
        private System.Windows.Forms.Label lbl_Students;
        private System.Windows.Forms.Panel pnl_Teachers;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.ColumnHeader teacherId;
        private System.Windows.Forms.ColumnHeader teacherSupervisor;
        private System.Windows.Forms.ColumnHeader teacherVak;
        private System.Windows.Forms.PictureBox imgTeachersLogo;
        private System.Windows.Forms.Label lbl_Teachers;
        private System.Windows.Forms.Panel pnl_Rooms;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.ColumnHeader AantalBedden;
        private System.Windows.Forms.ColumnHeader Docentenkamer;
        private System.Windows.Forms.PictureBox imgRoomsLogo;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.Panel pnl_DrinkSupply;
        private System.Windows.Forms.PictureBox imgDashboardLogo;
        private System.Windows.Forms.ListView listViewDrankVoorraad;
        private System.Windows.Forms.Label lblDrankVoorraad;
        private System.Windows.Forms.ToolStripMenuItem barToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinkSupplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashregisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Revenue;
        private System.Windows.Forms.Label lbl_Revenue;
        private System.Windows.Forms.ListView listViewRevenue;
        private System.Windows.Forms.Label lbl_endDate;
        private System.Windows.Forms.Label lbl_startDate;
        private System.Windows.Forms.ColumnHeader Sales;
        private System.Windows.Forms.ColumnHeader Revenue;
        private System.Windows.Forms.ColumnHeader NumberOfCustomers;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.ColumnHeader Naam;
        private System.Windows.Forms.ColumnHeader Drank_ID;
        private System.Windows.Forms.ColumnHeader Voorraad;
        private System.Windows.Forms.ColumnHeader Prijs;
        private System.Windows.Forms.ColumnHeader VoorraadStatus;
        private System.Windows.Forms.Panel pnl_CashRegister;
        private System.Windows.Forms.Label lbl_CashRegister;
        private System.Windows.Forms.ListView listViewCRStudents;
        private System.Windows.Forms.ListView listViewCRDrank;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_afrekenen;
        private System.Windows.Forms.Label lbl_afrekenen;
        private System.Windows.Forms.TextBox txtAanpassenValue;
        private System.Windows.Forms.Button btnVoorraadAanpassen;
        private System.Windows.Forms.Button btnNaamAanpassen;
        private System.Windows.Forms.Button btnNieuwDrank;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label lblNieuwPrijs;
        private System.Windows.Forms.Label lblNieuwVoorraad;
        private System.Windows.Forms.Label lblNieuwNaam;
        private System.Windows.Forms.TextBox txtNieuwVoorraad;
        private System.Windows.Forms.TextBox txtNieuwPrijs;
        private System.Windows.Forms.TextBox txtNieuwNaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrijsAanpassen;
        private System.Windows.Forms.Panel pnl_Activity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewActivity;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader ActivityName;
        private System.Windows.Forms.ColumnHeader Students;
        private System.Windows.Forms.ColumnHeader Docents;
        private System.Windows.Forms.TextBox NewDocents;
        private System.Windows.Forms.TextBox NewStudents;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Change_Docents;
        private System.Windows.Forms.Button Change_Students;
        private System.Windows.Forms.Button Change_Name;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label Value;
        private System.Windows.Forms.Button btnDowngradeToTeacher;
        private System.Windows.Forms.Panel pnl_Schedule;
        private System.Windows.Forms.ListView listViewSchedule;
        private System.Windows.Forms.ColumnHeader chdrScheduleActivity;
        private System.Windows.Forms.ColumnHeader chdrScheduleSupervisors;
        private System.Windows.Forms.ColumnHeader chdrScheduleDate;
        private System.Windows.Forms.ColumnHeader chdrScheduleStartTime;
        private System.Windows.Forms.ColumnHeader chdrScheduleEndTime;
        private System.Windows.Forms.Label lbl_Schedule;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.Button btn_ChangeSchedule;
        private System.Windows.Forms.ColumnHeader chdrScheduleRoosterID;
        private System.Windows.Forms.Panel pnl_Registratie;
        private System.Windows.Forms.Button btnRegistreren;
        private System.Windows.Forms.Label lblRegistratieSleutel;
        private System.Windows.Forms.TextBox txtLicentiesleutel;
        private System.Windows.Forms.Label lblRegistratieEmail;
        private System.Windows.Forms.Label lblRegistratieNaam;
        private System.Windows.Forms.Label lblRegistratieTitle;
        private System.Windows.Forms.TextBox txtRegistrerenNaam;
        private System.Windows.Forms.TextBox txtRegistrerenEmail;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_wachtwoord;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_wachtwoord;
        private System.Windows.Forms.Label lbl_inlog_email;
        private System.Windows.Forms.Label lbl_Inloggen;
        private System.Windows.Forms.Label lbl_seperator;
        private System.Windows.Forms.Button btn_forgotPassword;
        private System.Windows.Forms.TextBox txt_geheimAntwoord;
        private System.Windows.Forms.Label lbl_geheimeVraag;
        private System.Windows.Forms.Button btnLogInGeheimeVraag;
        private System.Windows.Forms.Button btn_bevestigEmail;
        private System.Windows.Forms.TextBox txt_nieuwWachtwoord;
        private System.Windows.Forms.Label lbl_nieuwWachtwoord;
        private System.Windows.Forms.Button btn_veranderWachtwoord;
        private System.Windows.Forms.TextBox txt_nieuwGeheimAntwoord;
        private System.Windows.Forms.TextBox txt_nieuweGeheimeVraag;
        private System.Windows.Forms.Label lbl_nieuwGeheimAntwoord;
        private System.Windows.Forms.Label lbl_nieuweGeheimeVraag;
    }
}

