using SomerenDAL;
using SomerenUI.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SomerenUI
{
    partial class SomerenUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        public void InitializeComboBoxes() //Is called after initialize component in SomerenUI.cs
        {
            VATDao VATDao = new VATDao();
            List<int> years = VATDao.GetAvailableYears();

            // Fill cmbYear with available years from the database
            cmbYear.DataSource = years;

            // Fill cmbQuarter with quarter options
            cmbQuarter.Items.Add("Q1");
            cmbQuarter.Items.Add("Q2");
            cmbQuarter.Items.Add("Q3");
            cmbQuarter.Items.Add("Q4");
        }



        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        ///  Kappa
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinkStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vATCalculationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.participantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timetableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.dashboardPictureBox = new System.Windows.Forms.PictureBox();
            this.fpnlWeek = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMonday = new System.Windows.Forms.Panel();
            this.pnlWednesday = new System.Windows.Forms.Panel();
            this.pnlThursday = new System.Windows.Forms.Panel();
            this.pnlFriday = new System.Windows.Forms.Panel();
            this.pnlTuesday = new System.Windows.Forms.Panel();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.cashpanel = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.listViewStudetnsCashRegister = new System.Windows.Forms.ListView();
            this.listViewDrinksCashRegister = new System.Windows.Forms.ListView();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblCashRegister = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listViewdrinks = new System.Windows.Forms.ListView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPriceOfDrink = new System.Windows.Forms.TextBox();
            this.txtIsAlcoholic = new System.Windows.Forms.TextBox();
            this.txtDrinkName = new System.Windows.Forms.TextBox();
            this.txtDrinkId = new System.Windows.Forms.TextBox();
            this.studentsPictureBox = new System.Windows.Forms.PictureBox();
            this.lecturersPictureBox = new System.Windows.Forms.PictureBox();
            this.activitiesPictureBox = new System.Windows.Forms.PictureBox();
            this.roomsPictureBox = new System.Windows.Forms.PictureBox();
            this.revenuePictureBox = new System.Windows.Forms.PictureBox();
            this.stockPictureBox = new System.Windows.Forms.PictureBox();
            this.pnlStudents = new System.Windows.Forms.Panel();
            this.listViewStudents = new System.Windows.Forms.ListView();
            this.studentsLabel = new System.Windows.Forms.Label();
            this.roomsPanel = new System.Windows.Forms.Panel();
            this.listViewRooms = new System.Windows.Forms.ListView();
            this.roomsLabel = new System.Windows.Forms.Label();
            this.lecturersLabel = new System.Windows.Forms.Label();
            //this.Id = new System.Windows.Forms.ColumnHeader();
            //this.Activity = new System.Windows.Forms.ColumnHeader();
            //this.Date = new System.Windows.Forms.ColumnHeader();
            this.lvActivities = new System.Windows.Forms.ListView();
            this.pnlActivity = new System.Windows.Forms.Panel();
			txtEndTime = new TextBox();
            txtDate = new TextBox();
            txtName = new TextBox();
            txtActivityID = new TextBox();
            lblEndTime = new Label();
            lblDate = new Label();
            lblName = new Label();
            lblActivityID = new Label();
            btnChange = new Button();
            btnRemo = new Button();
            btnAd = new Button();
            this.lblActivity = new System.Windows.Forms.Label();
            this.teacherpanel = new System.Windows.Forms.Panel();
            this.listViewteachers = new System.Windows.Forms.ListView();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pnlTimetable = new System.Windows.Forms.Panel();
            this.datePickerTimetable = new System.Windows.Forms.DateTimePicker();
            this.lblWeekDate = new System.Windows.Forms.Label();
            this.lblTimetableHeader = new System.Windows.Forms.Label();
            this.panelDrinks = new System.Windows.Forms.Panel();
            this.drinksStockLabel = new System.Windows.Forms.Label();
            this.vatPanel = new System.Windows.Forms.Panel();
            this.btnCalculateVAT = new System.Windows.Forms.Button();
            this.lblTotalVAT = new System.Windows.Forms.Label();
            this.lblHighTariffTotal = new System.Windows.Forms.Label();
            this.lblLowTariffTotal = new System.Windows.Forms.Label();
            this.lblQuarterDates = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbQuarter = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblVATReportHeader = new System.Windows.Forms.Label();
            this.pnlRevenueReport = new System.Windows.Forms.Panel();
            this.lblRevenueReportHeader = new System.Windows.Forms.Label();
            this.lvRevenueReport = new System.Windows.Forms.ListView();
            this.lblRevenueDateRange = new System.Windows.Forms.Label();
            this.lblChooseEndDate = new System.Windows.Forms.Label();
            this.lblChooseStartDate = new System.Windows.Forms.Label();
            this.monthCalendarEndDate = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarStartDate = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardPictureBox)).BeginInit();
            this.fpnlWeek.SuspendLayout();
            this.cashpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenuePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockPictureBox)).BeginInit();
            this.pnlStudents.SuspendLayout();
            this.roomsPanel.SuspendLayout();
            this.pnlActivity.SuspendLayout();
            this.teacherpanel.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.pnlTimetable.SuspendLayout();
            this.panelDrinks.SuspendLayout();
            this.vatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.pnlRevenueReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.lecturersToolStripMenuItem,
            this.activitiesToolStripMenuItem,
            this.roomsToolStripMenuItem,
            this.drinksToolStripMenuItem,
            this.supervisorsToolStripMenuItem,
            this.participantsToolStripMenuItem,
            this.timetableToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(861, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(176, 42);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(287, 46);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(144, 42);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.lecturersToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(147, 42);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.roomsToolStripMenuItem.Text = "Rooms";
            this.roomsToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // drinksToolStripMenuItem
            // 
            this.drinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drinkStockToolStripMenuItem,
            this.cashRegisterToolStripMenuItem,
            this.revenueReportToolStripMenuItem,
            this.vATCalculationToolStripMenuItem});
            this.drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            this.drinksToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.drinksToolStripMenuItem.Text = "Drinks";
            // 
            // drinkStockToolStripMenuItem
            // 
            this.drinkStockToolStripMenuItem.Name = "drinkStockToolStripMenuItem";
            this.drinkStockToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.drinkStockToolStripMenuItem.Text = "Drink Stock";
            this.drinkStockToolStripMenuItem.Click += new System.EventHandler(this.drinkStockToolStripMenuItem_Click);
            // 
            // cashRegisterToolStripMenuItem
            // 
            this.cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            this.cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.cashRegisterToolStripMenuItem.Text = "Cash Register";
            this.cashRegisterToolStripMenuItem.Click += new System.EventHandler(this.cashRegisterToolStripMenuItem_Click);
            // 
            // revenueReportToolStripMenuItem
            // 
            this.revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            this.revenueReportToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.revenueReportToolStripMenuItem.Text = "Revenue Report";
            this.revenueReportToolStripMenuItem.Click += new System.EventHandler(this.revenueReportToolStripMenuItem_Click);
            // 
            // vATCalculationToolStripMenuItem
            // 
            this.vATCalculationToolStripMenuItem.Name = "vATCalculationToolStripMenuItem";
            this.vATCalculationToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.vATCalculationToolStripMenuItem.Text = "VAT calculation";
            this.vATCalculationToolStripMenuItem.Click += new System.EventHandler(this.vATCalculationToolStripMenuItem_Click);
            // 
            // supervisorsToolStripMenuItem
            // 
            this.supervisorsToolStripMenuItem.Name = "supervisorsToolStripMenuItem";
            this.supervisorsToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.supervisorsToolStripMenuItem.Text = "Supervisors";
            // 
            // participantsToolStripMenuItem
            // 
            this.participantsToolStripMenuItem.Name = "participantsToolStripMenuItem";
            this.participantsToolStripMenuItem.Size = new System.Drawing.Size(99, 24);
            this.participantsToolStripMenuItem.Text = "Participants";
            // 
            // timetableToolStripMenuItem
            // 
            this.timetableToolStripMenuItem.Name = "timetableToolStripMenuItem";
            this.timetableToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.timetableToolStripMenuItem.Text = "Timetable";
            this.timetableToolStripMenuItem.Click += new System.EventHandler(this.timetableToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Controls.Add(this.dashboardPictureBox);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(861, 548);
            this.pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Location = new System.Drawing.Point(0, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(262, 20);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // dashboardPictureBox
            // 
            this.dashboardPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.dashboardPictureBox.Location = new System.Drawing.Point(0, 0);
            this.dashboardPictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.dashboardPictureBox.Name = "dashboardPictureBox";
            this.dashboardPictureBox.Size = new System.Drawing.Size(145, 136);
            this.dashboardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dashboardPictureBox.TabIndex = 2;
            this.dashboardPictureBox.TabStop = false;
            // 
            // fpnlWeek
            // 
            this.fpnlWeek.Controls.Add(this.pnlMonday);
            this.fpnlWeek.Controls.Add(this.pnlTuesday);
            this.fpnlWeek.Controls.Add(this.pnlWednesday);
            this.fpnlWeek.Controls.Add(this.pnlThursday);
            this.fpnlWeek.Controls.Add(this.pnlFriday);
            this.fpnlWeek.Location = new System.Drawing.Point(8, 105);
            this.fpnlWeek.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fpnlWeek.Name = "fpnlWeek";
            this.fpnlWeek.Size = new System.Drawing.Size(850, 519);
            this.fpnlWeek.TabIndex = 9;
            // 
            // pnlMonday
            // 
            this.pnlMonday.Location = new System.Drawing.Point(0, 3);
            this.pnlMonday.Name = "pnlMonday";
            this.pnlMonday.Size = new System.Drawing.Size(160, 516);
            this.pnlMonday.TabIndex = 10;
            // 
            // pnlTuesday
            // 
            this.pnlTuesday.Location = new System.Drawing.Point(160, 3);
            this.pnlTuesday.Name = "pnlTuesday";
            this.pnlTuesday.Size = new System.Drawing.Size(160, 516);
            this.pnlTuesday.TabIndex = 11;
            // 
            // pnlWednesday
            // 
            this.pnlWednesday.Location = new System.Drawing.Point(292, 3);
            this.pnlWednesday.Name = "pnlWednesday";
            this.pnlWednesday.Size = new System.Drawing.Size(160, 516);
            this.pnlWednesday.TabIndex = 12;
            // 
            // pnlThursday
            // 
            this.pnlThursday.Location = new System.Drawing.Point(356, 211);
            this.pnlThursday.Name = "pnlThursday";
            this.pnlThursday.Size = new System.Drawing.Size(160, 516);
            this.pnlThursday.TabIndex = 13;
            // 
            // pnlFriday
            // 
            this.pnlFriday.Location = new System.Drawing.Point(499, 211);
            this.pnlFriday.Name = "pnlFriday";
            this.pnlFriday.Size = new System.Drawing.Size(160, 516);
            this.pnlFriday.TabIndex = 14;
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Location = new System.Drawing.Point(49, 81);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(63, 20);
            this.lblMonday.TabIndex = 0;
            this.lblMonday.Text = "Monday";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Location = new System.Drawing.Point(227, 81);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(63, 20);
            this.lblTuesday.TabIndex = 1;
            this.lblTuesday.Text = "Tuesday";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Location = new System.Drawing.Point(389, 81);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(85, 20);
            this.lblWednesday.TabIndex = 1;
            this.lblWednesday.Text = "Wednesday";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Location = new System.Drawing.Point(564, 81);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(68, 20);
            this.lblThursday.TabIndex = 1;
            this.lblThursday.Text = "Thursday";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Location = new System.Drawing.Point(740, 81);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(49, 20);
            this.lblFriday.TabIndex = 1;
            this.lblFriday.Text = "Friday";
            // 
            // cashpanel
            // 
            this.cashpanel.Controls.Add(this.btnCheckout);
            this.cashpanel.Controls.Add(this.listViewStudetnsCashRegister);
            this.cashpanel.Controls.Add(this.listViewDrinksCashRegister);
            this.cashpanel.Controls.Add(this.lblTotalPrice);
            this.cashpanel.Controls.Add(this.lblCashRegister);
            this.cashpanel.Controls.Add(this.pictureBox1);
            this.cashpanel.Location = new System.Drawing.Point(0, 0);
            this.cashpanel.Margin = new System.Windows.Forms.Padding(2);
            this.cashpanel.Name = "cashpanel";
            this.cashpanel.Size = new System.Drawing.Size(851, 544);
            this.cashpanel.TabIndex = 3;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(503, 471);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(95, 29);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Buy";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new EventHandler(btnCheckout_Click);
            // 
            // listViewStudetnsCashRegister
            // 
            this.listViewStudetnsCashRegister.FullRowSelect = true;
            this.listViewStudetnsCashRegister.GridLines = true;
            this.listViewStudetnsCashRegister.Location = new System.Drawing.Point(29, 45);
            this.listViewStudetnsCashRegister.Margin = new System.Windows.Forms.Padding(2);
            this.listViewStudetnsCashRegister.Name = "listViewStudetnsCashRegister";
            this.listViewStudetnsCashRegister.Size = new System.Drawing.Size(569, 176);
            this.listViewStudetnsCashRegister.TabIndex = 0;
            this.listViewStudetnsCashRegister.UseCompatibleStateImageBehavior = false;
            this.listViewStudetnsCashRegister.SelectedIndexChanged += new EventHandler(ListViewStudetnsCashRegister_SelectedIndexChanged);
            // 
            // listViewDrinksCashRegister
            // 
            this.listViewDrinksCashRegister.FullRowSelect = true;
            this.listViewDrinksCashRegister.GridLines = true;
            this.listViewDrinksCashRegister.Location = new System.Drawing.Point(29, 235);
            this.listViewDrinksCashRegister.Margin = new System.Windows.Forms.Padding(2);
            this.listViewDrinksCashRegister.Name = "listViewDrinksCashRegister";
            this.listViewDrinksCashRegister.Size = new System.Drawing.Size(569, 176);
            this.listViewDrinksCashRegister.TabIndex = 4;
            this.listViewDrinksCashRegister.UseCompatibleStateImageBehavior = false;
            this.listViewDrinksCashRegister.SelectedIndexChanged += new EventHandler(ListViewDrinksCashRegister_SelectedIndexChanged);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(41, 471);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(82, 20);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total price:";
            // 
            // lblCashRegister
            // 
            this.lblCashRegister.AutoSize = true;
            this.lblCashRegister.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCashRegister.Location = new System.Drawing.Point(11, 5);
            this.lblCashRegister.Name = "lblCashRegister";
            this.lblCashRegister.Size = new System.Drawing.Size(197, 41);
            this.lblCashRegister.TabIndex = 3;
            this.lblCashRegister.Text = "Cash Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.Location = new System.Drawing.Point(715, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // listViewdrinks
            // 
            this.listViewdrinks.FullRowSelect = true;
            this.listViewdrinks.GridLines = true;
            this.listViewdrinks.Location = new System.Drawing.Point(29, 48);
            this.listViewdrinks.Margin = new System.Windows.Forms.Padding(2);
            this.listViewdrinks.Name = "listViewdrinks";
            this.listViewdrinks.Size = new System.Drawing.Size(569, 118);
            this.listViewdrinks.TabIndex = 1;
            this.listViewdrinks.UseCompatibleStateImageBehavior = false;
            this.listViewdrinks.SelectedIndexChanged += new EventHandler(listViewdrinks_SelectedIndexChanged);
            this.listViewdrinks.MouseClick += new MouseEventHandler(listViewdrinks_MouseClick);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(757, 247);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(95, 29);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove drink";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new EventHandler(BtnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(757, 202);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add drink";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new EventHandler(BtnAdd_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(475, 202);
            this.txtStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStock.Name = "txtStock";
            this.txtStock.PlaceholderText = "50";
            this.txtStock.Size = new System.Drawing.Size(125, 27);
            this.txtStock.TabIndex = 4;
            // 
            // txtPriceOfDrink
            // 
            this.txtPriceOfDrink.Location = new System.Drawing.Point(623, 202);
            this.txtPriceOfDrink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceOfDrink.Name = "txtPriceOfDrink";
            this.txtPriceOfDrink.PlaceholderText = "2.50";
            this.txtPriceOfDrink.Size = new System.Drawing.Size(125, 27);
            this.txtPriceOfDrink.TabIndex = 5;
            // 
            // txtIsAlcoholic
            // 
            this.txtIsAlcoholic.Location = new System.Drawing.Point(326, 202);
            this.txtIsAlcoholic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIsAlcoholic.Name = "txtIsAlcoholic";
            this.txtIsAlcoholic.PlaceholderText = "yes/no";
            this.txtIsAlcoholic.Size = new System.Drawing.Size(125, 27);
            this.txtIsAlcoholic.TabIndex = 6;
            // 
            // txtDrinkName
            // 
            this.txtDrinkName.Location = new System.Drawing.Point(175, 202);
            this.txtDrinkName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDrinkName.Name = "txtDrinkName";
            this.txtDrinkName.PlaceholderText = "Beer";
            this.txtDrinkName.Size = new System.Drawing.Size(125, 27);
            this.txtDrinkName.TabIndex = 3;
            // 
            // txtDrinkId
            // 
            this.txtDrinkId.Location = new System.Drawing.Point(21, 202);
            this.txtDrinkId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDrinkId.Name = "txtDrinkId";
            this.txtDrinkId.PlaceholderText = "15";
            this.txtDrinkId.Size = new System.Drawing.Size(125, 27);
            this.txtDrinkId.TabIndex = 7;
            // 
            // studentsPictureBox
            // 
            this.studentsPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.studentsPictureBox.Location = new System.Drawing.Point(715, 0);
            this.studentsPictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.studentsPictureBox.Name = "studentsPictureBox";
            this.studentsPictureBox.Size = new System.Drawing.Size(145, 136);
            this.studentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.studentsPictureBox.TabIndex = 2;
            this.studentsPictureBox.TabStop = false;
            // 
            // lecturersPictureBox
            // 
            this.lecturersPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.lecturersPictureBox.Location = new System.Drawing.Point(715, 0);
            this.lecturersPictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.lecturersPictureBox.Name = "lecturersPictureBox";
            this.lecturersPictureBox.Size = new System.Drawing.Size(145, 136);
            this.lecturersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lecturersPictureBox.TabIndex = 2;
            this.lecturersPictureBox.TabStop = false;
            // 
            // activitiesPictureBox
            // 
            this.activitiesPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.activitiesPictureBox.Location = new System.Drawing.Point(715, 0);
            this.activitiesPictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.activitiesPictureBox.Name = "activitiesPictureBox";
            this.activitiesPictureBox.Size = new System.Drawing.Size(145, 136);
            this.activitiesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.activitiesPictureBox.TabIndex = 2;
            this.activitiesPictureBox.TabStop = false;
            // 
            // roomsPictureBox
            // 
            this.roomsPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.roomsPictureBox.Location = new System.Drawing.Point(715, 0);
            this.roomsPictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.roomsPictureBox.Name = "roomsPictureBox";
            this.roomsPictureBox.Size = new System.Drawing.Size(145, 136);
            this.roomsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.roomsPictureBox.TabIndex = 2;
            this.roomsPictureBox.TabStop = false;
            // 
            // revenuePictureBox
            // 
            this.revenuePictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.revenuePictureBox.Location = new System.Drawing.Point(715, 0);
            this.revenuePictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.revenuePictureBox.Name = "revenuePictureBox";
            this.revenuePictureBox.Size = new System.Drawing.Size(145, 136);
            this.revenuePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.revenuePictureBox.TabIndex = 2;
            this.revenuePictureBox.TabStop = false;
            // 
            // stockPictureBox
            // 
            this.stockPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.stockPictureBox.Location = new System.Drawing.Point(715, 0);
            this.stockPictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.stockPictureBox.Name = "stockPictureBox";
            this.stockPictureBox.Size = new System.Drawing.Size(145, 136);
            this.stockPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.stockPictureBox.TabIndex = 3;
            this.stockPictureBox.TabStop = false;
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.listViewStudents);
            this.pnlStudents.Controls.Add(this.studentsLabel);
            this.pnlStudents.Controls.Add(this.studentsPictureBox);
            this.pnlStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStudents.Location = new System.Drawing.Point(0, 0);
            this.pnlStudents.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(861, 548);
            this.pnlStudents.TabIndex = 2;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Location = new System.Drawing.Point(15, 45);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(685, 329);
            this.listViewStudents.TabIndex = 1;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // studentsLabel
            // 
            this.studentsLabel.AutoSize = true;
            this.studentsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentsLabel.Location = new System.Drawing.Point(11, 5);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(134, 41);
            this.studentsLabel.TabIndex = 0;
            this.studentsLabel.Text = "Students";
            // 
            // roomsPanel
            // 
            this.roomsPanel.Controls.Add(this.listViewRooms);
            this.roomsPanel.Controls.Add(this.roomsLabel);
            this.roomsPanel.Controls.Add(this.roomsPictureBox);
            this.roomsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roomsPanel.Location = new System.Drawing.Point(0, 0);
            this.roomsPanel.Margin = new System.Windows.Forms.Padding(1);
            this.roomsPanel.Name = "roomsPanel";
            this.roomsPanel.Size = new System.Drawing.Size(861, 548);
            this.roomsPanel.TabIndex = 3;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Location = new System.Drawing.Point(15, 45);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(1);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(685, 329);
            this.listViewRooms.TabIndex = 1;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // roomsLabel
            // 
            this.roomsLabel.AutoSize = true;
            this.roomsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomsLabel.Location = new System.Drawing.Point(11, 5);
            this.roomsLabel.Name = "roomsLabel";
            this.roomsLabel.Size = new System.Drawing.Size(110, 41);
            this.roomsLabel.TabIndex = 0;
            this.roomsLabel.Text = "Rooms";
            // 
            // lecturersLabel
            // 
            this.lecturersLabel.AutoSize = true;
            this.lecturersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lecturersLabel.Location = new System.Drawing.Point(11, 5);
            this.lecturersLabel.Name = "lecturersLabel";
            this.lecturersLabel.Size = new System.Drawing.Size(138, 41);
            this.lecturersLabel.TabIndex = 0;
            this.lecturersLabel.Text = "Lecturers";
            // 
            // lvActivities
            // 
            //this.lvActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            //this.Id,
            //this.Activity,
            //this.Date});
            this.lvActivities.FullRowSelect = true;
            this.lvActivities.GridLines = true;
            this.lvActivities.Location = new System.Drawing.Point(17, 53);
            this.lvActivities.Margin = new System.Windows.Forms.Padding(1);
            this.lvActivities.Name = "lvActivities";
            this.lvActivities.Size = new System.Drawing.Size(650, 300);
            this.lvActivities.TabIndex = 1;
            this.lvActivities.UseCompatibleStateImageBehavior = false;
            this.lvActivities.View = System.Windows.Forms.View.Details;
			lvActivities.SelectedIndexChanged += new EventHandler(lvActivities_SelectedIndexChanged);
            // 
            // pnlActivity
            // 
            pnlActivity.Controls.Add(txtEndTime);
            pnlActivity.Controls.Add(txtDate);
            pnlActivity.Controls.Add(txtName);
            pnlActivity.Controls.Add(txtActivityID);
            pnlActivity.Controls.Add(lblEndTime);
            pnlActivity.Controls.Add(lblDate);
            pnlActivity.Controls.Add(lblName);
            pnlActivity.Controls.Add(lblActivityID);
            pnlActivity.Controls.Add(btnRemo);
            pnlActivity.Controls.Add(btnAd);
            pnlActivity.Controls.Add(lvActivities);
            pnlActivity.Controls.Add(lblActivity);
            pnlActivity.Controls.Add(activitiesPictureBox);
            pnlActivity.Dock = DockStyle.Fill;
            pnlActivity.Location = new System.Drawing.Point(0, 56);
            pnlActivity.Margin = new Padding(2);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new System.Drawing.Size(861, 548);
            pnlActivity.TabIndex = 4;
            // 
            // txtEndTime
            // 
            txtEndTime.Location = new System.Drawing.Point(440, 400);
            txtEndTime.Name = "txtEndTime";
            txtEndTime.Size = new System.Drawing.Size(200, 45);
            txtEndTime.TabIndex = 14;
            // 
            // txtDate
            // 
            txtDate.Location = new System.Drawing.Point(220, 400);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(200, 45);
            txtDate.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(100, 400);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(100, 45);
            txtName.TabIndex = 12;
            // 
            // txtActivityID
            // 
            txtActivityID.Location = new System.Drawing.Point(16, 400);
            txtActivityID.Name = "txtActivityID";
            txtActivityID.Size = new System.Drawing.Size(50, 45);
            txtActivityID.TabIndex = 11;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Location = new System.Drawing.Point(440, 380);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new System.Drawing.Size(132, 38);
            lblEndTime.TabIndex = 10;
            lblEndTime.Text = "End Time";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(220, 380);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(75, 38);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(100, 380);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(91, 38);
            lblName.TabIndex = 8;
            lblName.Text = "Name";
            // 
            // lblActivityID
            // 
            lblActivityID.AutoSize = true;
            lblActivityID.Location = new System.Drawing.Point(15, 380);
            lblActivityID.Name = "lblActivityID";
            lblActivityID.Size = new System.Drawing.Size(142, 38);
            lblActivityID.TabIndex = 7;
            lblActivityID.Text = "Activity ID";
            // 
            // btnRemo
            // 
            btnRemo.Location = new System.Drawing.Point(700, 375);
            btnRemo.Name = "btnRemo";
            btnRemo.Size = new System.Drawing.Size(100, 30);
            btnRemo.TabIndex = 4;
            btnRemo.Text = "Remove";
            btnRemo.UseVisualStyleBackColor = true;
            btnRemo.Click += btnRemo_Click;
            // 
            // btnAd
            // 
            btnAd.Location = new System.Drawing.Point(700, 420);
            btnAd.Name = "btnAd";
            btnAd.Size = new System.Drawing.Size(100, 30);
            btnAd.TabIndex = 3;
            btnAd.Text = "Add";
            btnAd.UseVisualStyleBackColor = true;
            btnAd.Click += btnAd_Click;
            // 
            // lblActivity
            //
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivity.Location = new System.Drawing.Point(13, 6);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(135, 41);
            this.lblActivity.TabIndex = 2;
            this.lblActivity.Text = "Activities";
            // 
            // teacherpanel
            // 
            teacherpanel.Controls.Add(listViewteachers);
            teacherpanel.Controls.Add(lecturersLabel);
            teacherpanel.Controls.Add(lecturersPictureBox);
            teacherpanel.Dock = DockStyle.Fill;
            teacherpanel.Location = new System.Drawing.Point(0, 0);
            teacherpanel.Margin = new Padding(2);
            teacherpanel.Name = "teacherpanel";
            teacherpanel.Size = new System.Drawing.Size(1614, 1046);
            teacherpanel.TabIndex = 3;
            // 
            // listViewteachers
            // 
            this.listViewteachers.Location = new System.Drawing.Point(17, 53);
            this.listViewteachers.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listViewteachers.Name = "listViewteachers";
            this.listViewteachers.Size = new System.Drawing.Size(782, 386);
            this.listViewteachers.TabIndex = 9999999;
            this.listViewteachers.UseCompatibleStateImageBehavior = false;
            this.listViewteachers.View = System.Windows.Forms.View.Details;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.pnlTimetable);
            this.panelContainer.Controls.Add(this.pnlDashboard);
            this.panelContainer.Controls.Add(this.panelDrinks);
            this.panelContainer.Controls.Add(this.pnlStudents);
            this.panelContainer.Controls.Add(this.cashpanel);
            this.panelContainer.Controls.Add(this.vatPanel);
            this.panelContainer.Controls.Add(this.pnlRevenueReport);
            this.panelContainer.Controls.Add(this.roomsPanel);
            this.panelContainer.Controls.Add(this.pnlActivity);
            this.panelContainer.Controls.Add(this.teacherpanel);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 32);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(1);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(861, 548);
            this.panelContainer.TabIndex = 2;
            // 
            // pnlTimetable
            // 
            this.pnlTimetable.Controls.Add(this.lblFriday);
            this.pnlTimetable.Controls.Add(this.lblThursday);
            this.pnlTimetable.Controls.Add(this.lblWednesday);
            this.pnlTimetable.Controls.Add(this.lblTuesday);
            this.pnlTimetable.Controls.Add(this.lblMonday);
            this.pnlTimetable.Controls.Add(this.datePickerTimetable);
            this.pnlTimetable.Controls.Add(this.lblWeekDate);
            this.pnlTimetable.Controls.Add(this.lblTimetableHeader);
            this.pnlTimetable.Controls.Add(this.fpnlWeek);
            this.pnlTimetable.Location = new System.Drawing.Point(0, 0);
            this.pnlTimetable.Name = "pnlTimetable";
            this.pnlTimetable.Size = new System.Drawing.Size(861, 648);
            this.pnlTimetable.TabIndex = 10;
            // 
            // datePickerTimetable
            // 
            this.datePickerTimetable.Location = new System.Drawing.Point(297, 16);
            this.datePickerTimetable.Name = "datePickerTimetable";
            this.datePickerTimetable.Size = new System.Drawing.Size(250, 27);
            this.datePickerTimetable.TabIndex = 12;
            this.datePickerTimetable.Value = new System.DateTime(2023, 3, 20, 0, 0, 0, 0);
            this.datePickerTimetable.ValueChanged += new System.EventHandler(this.datePickerTimetable_ValueChanged);
            // 
            // lblWeekDate
            // 
            this.lblWeekDate.AutoSize = true;
            this.lblWeekDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWeekDate.Location = new System.Drawing.Point(369, 6);
            this.lblWeekDate.Name = "lblWeekDate";
            this.lblWeekDate.Size = new System.Drawing.Size(0, 37);
            this.lblWeekDate.TabIndex = 11;
            // 
            // lblTimetableHeader
            // 
            this.lblTimetableHeader.AutoSize = true;
            this.lblTimetableHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimetableHeader.Location = new System.Drawing.Point(11, 6);
            this.lblTimetableHeader.Name = "lblTimetableHeader";
            this.lblTimetableHeader.Size = new System.Drawing.Size(253, 41);
            this.lblTimetableHeader.TabIndex = 10;
            this.lblTimetableHeader.Text = "Weekly Timetable";
            // 
            // panelDrinks
            // 
            this.panelDrinks.Controls.Add(this.drinksStockLabel);
            this.panelDrinks.Controls.Add(this.txtDrinkId);
            this.panelDrinks.Controls.Add(this.txtDrinkName);
            this.panelDrinks.Controls.Add(this.txtIsAlcoholic);
            this.panelDrinks.Controls.Add(this.txtStock);
            this.panelDrinks.Controls.Add(this.txtPriceOfDrink);
            this.panelDrinks.Controls.Add(this.btnAdd);
            this.panelDrinks.Controls.Add(this.btnRemove);
            this.panelDrinks.Controls.Add(this.listViewdrinks);
            this.panelDrinks.Controls.Add(this.stockPictureBox);
            this.panelDrinks.Location = new System.Drawing.Point(0, 0);
            this.panelDrinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDrinks.Name = "panelDrinks";
            this.panelDrinks.Size = new System.Drawing.Size(861, 580);
            this.panelDrinks.TabIndex = 3;
            // 
            // drinksStockLabel
            // 
            this.drinksStockLabel.AutoSize = true;
            this.drinksStockLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drinksStockLabel.Location = new System.Drawing.Point(11, 6);
            this.drinksStockLabel.Name = "drinksStockLabel";
            this.drinksStockLabel.Size = new System.Drawing.Size(101, 41);
            this.drinksStockLabel.TabIndex = 3;
            this.drinksStockLabel.Text = "Drinks";
            // 
            // vatPanel
            // 
            this.vatPanel.Controls.Add(this.btnCalculateVAT);
            this.vatPanel.Controls.Add(this.lblTotalVAT);
            this.vatPanel.Controls.Add(this.lblHighTariffTotal);
            this.vatPanel.Controls.Add(this.lblLowTariffTotal);
            this.vatPanel.Controls.Add(this.lblQuarterDates);
            this.vatPanel.Controls.Add(this.label2);
            this.vatPanel.Controls.Add(this.label1);
            this.vatPanel.Controls.Add(this.cmbQuarter);
            this.vatPanel.Controls.Add(this.cmbYear);
            this.vatPanel.Controls.Add(this.pictureBox);
            this.vatPanel.Controls.Add(this.lblVATReportHeader);
            this.vatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vatPanel.Location = new System.Drawing.Point(0, 0);
            this.vatPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vatPanel.Name = "vatPanel";
            this.vatPanel.Size = new System.Drawing.Size(861, 548);
            this.vatPanel.TabIndex = 3;
            // 
            // btnCalculateVAT
            // 
            this.btnCalculateVAT.Location = new System.Drawing.Point(389, 442);
            this.btnCalculateVAT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalculateVAT.Name = "btnCalculateVAT";
            this.btnCalculateVAT.Size = new System.Drawing.Size(95, 29);
            this.btnCalculateVAT.TabIndex = 11;
            this.btnCalculateVAT.Text = "Calculate VAT";
            this.btnCalculateVAT.UseVisualStyleBackColor = true;
            this.btnCalculateVAT.Click += new EventHandler(btnCalculateVAT_Click);
            // 
            // lblTotalVAT
            // 
            this.lblTotalVAT.AutoSize = true;
            this.lblTotalVAT.Location = new System.Drawing.Point(38, 452);
            this.lblTotalVAT.Name = "lblTotalVAT";
            this.lblTotalVAT.Size = new System.Drawing.Size(314, 20);
            this.lblTotalVAT.TabIndex = 10;
            this.lblTotalVAT.Text = "Total VAT amount payable: ____________________ ";
            // 
            // lblHighTariffTotal
            // 
            this.lblHighTariffTotal.AutoSize = true;
            this.lblHighTariffTotal.Location = new System.Drawing.Point(32, 268);
            this.lblHighTariffTotal.Name = "lblHighTariffTotal";
            this.lblHighTariffTotal.Size = new System.Drawing.Size(424, 20);
            this.lblHighTariffTotal.TabIndex = 9;
            this.lblHighTariffTotal.Text = "Total VAT (high tariff, 21%) amount payable: ____________________";
            // 
            // lblLowTariffTotal
            // 
            this.lblLowTariffTotal.AutoSize = true;
            this.lblLowTariffTotal.Location = new System.Drawing.Point(32, 214);
            this.lblLowTariffTotal.Name = "lblLowTariffTotal";
            this.lblLowTariffTotal.Size = new System.Drawing.Size(411, 20);
            this.lblLowTariffTotal.TabIndex = 8;
            this.lblLowTariffTotal.Text = "Total VAT (low tariff, 6%) amount payable: ____________________";
            // 
            // lblQuarterDates
            // 
            this.lblQuarterDates.AutoSize = true;
            this.lblQuarterDates.Location = new System.Drawing.Point(32, 161);
            this.lblQuarterDates.Name = "lblQuarterDates";
            this.lblQuarterDates.Size = new System.Drawing.Size(316, 20);
            this.lblQuarterDates.TabIndex = 7;
            this.lblQuarterDates.Text = "Quarter runs from: _____________ to:______________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select quarter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select year:";
            // 
            // cmbQuarter
            // 
            this.cmbQuarter.FormattingEnabled = true;
            this.cmbQuarter.Location = new System.Drawing.Point(175, 105);
            this.cmbQuarter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbQuarter.Name = "cmbQuarter";
            this.cmbQuarter.Size = new System.Drawing.Size(153, 28);
            this.cmbQuarter.TabIndex = 4;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(175, 54);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(153, 28);
            this.cmbYear.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox.Location = new System.Drawing.Point(715, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(145, 136);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // lblVATReportHeader
            // 
            this.lblVATReportHeader.AutoSize = true;
            this.lblVATReportHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVATReportHeader.Location = new System.Drawing.Point(11, 6);
            this.lblVATReportHeader.Name = "lblVATReportHeader";
            this.lblVATReportHeader.Size = new System.Drawing.Size(165, 41);
            this.lblVATReportHeader.TabIndex = 7;
            this.lblVATReportHeader.Text = "VAT Report";
            // 
            // pnlRevenueReport
            // 
            this.pnlRevenueReport.Controls.Add(this.lblRevenueReportHeader);
            this.pnlRevenueReport.Controls.Add(this.lvRevenueReport);
            this.pnlRevenueReport.Controls.Add(this.lblRevenueDateRange);
            this.pnlRevenueReport.Controls.Add(this.lblChooseEndDate);
            this.pnlRevenueReport.Controls.Add(this.lblChooseStartDate);
            this.pnlRevenueReport.Controls.Add(this.monthCalendarEndDate);
            this.pnlRevenueReport.Controls.Add(this.monthCalendarStartDate);
            this.pnlRevenueReport.Controls.Add(this.revenuePictureBox);
            this.pnlRevenueReport.Location = new System.Drawing.Point(0, 0);
            this.pnlRevenueReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlRevenueReport.Name = "pnlRevenueReport";
            this.pnlRevenueReport.Size = new System.Drawing.Size(851, 544);
            this.pnlRevenueReport.TabIndex = 3;
            // 
            // lblRevenueReportHeader
            // 
            this.lblRevenueReportHeader.AutoSize = true;
            this.lblRevenueReportHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRevenueReportHeader.Location = new System.Drawing.Point(11, 6);
            this.lblRevenueReportHeader.Name = "lblRevenueReportHeader";
            this.lblRevenueReportHeader.Size = new System.Drawing.Size(228, 41);
            this.lblRevenueReportHeader.TabIndex = 6;
            this.lblRevenueReportHeader.Text = "Revenue Report";
            // 
            // lvRevenueReport
            // 
            this.lvRevenueReport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvRevenueReport.Location = new System.Drawing.Point(17, 353);
            this.lvRevenueReport.Margin = new System.Windows.Forms.Padding(1);
            this.lvRevenueReport.MultiSelect = false;
            this.lvRevenueReport.Name = "lvRevenueReport";
            this.lvRevenueReport.Size = new System.Drawing.Size(662, 176);
            this.lvRevenueReport.TabIndex = 5;
            this.lvRevenueReport.UseCompatibleStateImageBehavior = false;
            // 
            // lblRevenueDateRange
            // 
            this.lblRevenueDateRange.AutoSize = true;
            this.lblRevenueDateRange.Location = new System.Drawing.Point(17, 329);
            this.lblRevenueDateRange.Name = "lblRevenueDateRange";
            this.lblRevenueDateRange.Size = new System.Drawing.Size(114, 20);
            this.lblRevenueDateRange.TabIndex = 4;
            this.lblRevenueDateRange.Text = "Revenue Report";
            // 
            // lblChooseEndDate
            // 
            this.lblChooseEndDate.AutoSize = true;
            this.lblChooseEndDate.Location = new System.Drawing.Point(426, 54);
            this.lblChooseEndDate.Name = "lblChooseEndDate";
            this.lblChooseEndDate.Size = new System.Drawing.Size(141, 20);
            this.lblChooseEndDate.TabIndex = 3;
            this.lblChooseEndDate.Text = "Choose an end date";
            // 
            // lblChooseStartDate
            // 
            this.lblChooseStartDate.AutoSize = true;
            this.lblChooseStartDate.Location = new System.Drawing.Point(17, 54);
            this.lblChooseStartDate.Name = "lblChooseStartDate";
            this.lblChooseStartDate.Size = new System.Drawing.Size(137, 20);
            this.lblChooseStartDate.TabIndex = 2;
            this.lblChooseStartDate.Text = "Choose a start date";
            // 
            // monthCalendarEndDate
            // 
            this.monthCalendarEndDate.Location = new System.Drawing.Point(426, 88);
            this.monthCalendarEndDate.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendarEndDate.Name = "monthCalendarEndDate";
            this.monthCalendarEndDate.ShowToday = false;
            this.monthCalendarEndDate.ShowTodayCircle = false;
            this.monthCalendarEndDate.TabIndex = 1;
            this.monthCalendarEndDate.DateChanged += new DateRangeEventHandler(this.monthCalendarEndDate_DateChanged);
            // 
            // monthCalendarStartDate
            // 
            this.monthCalendarStartDate.Location = new System.Drawing.Point(17, 88);
            this.monthCalendarStartDate.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendarStartDate.MaxDate = new System.DateTime(2024, 3, 22, 0, 0, 0, 0);
            this.monthCalendarStartDate.Name = "monthCalendarStartDate";
            this.monthCalendarStartDate.ShowToday = false;
            this.monthCalendarStartDate.ShowTodayCircle = false;
            this.monthCalendarStartDate.TabIndex = 0;
            this.monthCalendarStartDate.DateChanged += new DateRangeEventHandler(this.monthCalendarStartDate_DateChanged);
            // 
            // lblVATReportHeader
            // 
            lblVATReportHeader.AutoSize = true;
            lblVATReportHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblVATReportHeader.Location = new System.Drawing.Point(21, 11);
            lblVATReportHeader.Margin = new Padding(6, 0, 6, 0);
            lblVATReportHeader.Name = "lblVATReportHeader";
            lblVATReportHeader.Size = new System.Drawing.Size(263, 65);
            lblVATReportHeader.TabIndex = 7;
            lblVATReportHeader.Text = "VAT Report";
            // 
            // pnlRevenueReport
            // 
            pnlRevenueReport.Controls.Add(lblRevenueReportHeader);
            pnlRevenueReport.Controls.Add(lvRevenueReport);
            pnlRevenueReport.Controls.Add(lblRevenueDateRange);
            pnlRevenueReport.Controls.Add(lblChooseEndDate);
            pnlRevenueReport.Controls.Add(lblChooseStartDate);
            pnlRevenueReport.Controls.Add(monthCalendarEndDate);
            pnlRevenueReport.Controls.Add(monthCalendarStartDate);
            pnlRevenueReport.Controls.Add(revenuePictureBox);
            pnlRevenueReport.Location = new System.Drawing.Point(0, 0);
            pnlRevenueReport.Margin = new Padding(6, 7, 6, 7);
            pnlRevenueReport.Name = "pnlRevenueReport";
            pnlRevenueReport.Size = new System.Drawing.Size(1596, 1033);
            pnlRevenueReport.TabIndex = 3;
            // 
            // lblRevenueReportHeader
            // 
            lblRevenueReportHeader.AutoSize = true;
            lblRevenueReportHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblRevenueReportHeader.Location = new System.Drawing.Point(21, 11);
            lblRevenueReportHeader.Margin = new Padding(6, 0, 6, 0);
            lblRevenueReportHeader.Name = "lblRevenueReportHeader";
            lblRevenueReportHeader.Size = new System.Drawing.Size(363, 65);
            lblRevenueReportHeader.TabIndex = 6;
            lblRevenueReportHeader.Text = "Revenue Report";
            // 
            // lvRevenueReport
            // 
            lvRevenueReport.ImeMode = ImeMode.NoControl;
            lvRevenueReport.Location = new System.Drawing.Point(32, 671);
            lvRevenueReport.Margin = new Padding(2);
            lvRevenueReport.MultiSelect = false;
            lvRevenueReport.Name = "lvRevenueReport";
            lvRevenueReport.Size = new System.Drawing.Size(1238, 330);
            lvRevenueReport.TabIndex = 5;
            lvRevenueReport.UseCompatibleStateImageBehavior = false;
            // 
            // lblRevenueDateRange
            // 
            lblRevenueDateRange.AutoSize = true;
            lblRevenueDateRange.Location = new System.Drawing.Point(32, 626);
            lblRevenueDateRange.Margin = new Padding(6, 0, 6, 0);
            lblRevenueDateRange.Name = "lblRevenueDateRange";
            lblRevenueDateRange.Size = new System.Drawing.Size(213, 38);
            lblRevenueDateRange.TabIndex = 4;
            lblRevenueDateRange.Text = "Revenue Report";
            // 
            // lblChooseEndDate
            // 
            lblChooseEndDate.AutoSize = true;
            lblChooseEndDate.Location = new System.Drawing.Point(799, 103);
            lblChooseEndDate.Margin = new Padding(6, 0, 6, 0);
            lblChooseEndDate.Name = "lblChooseEndDate";
            lblChooseEndDate.Size = new System.Drawing.Size(264, 38);
            lblChooseEndDate.TabIndex = 3;
            lblChooseEndDate.Text = "Choose an end date";
            // 
            // lblChooseStartDate
            // 
            lblChooseStartDate.AutoSize = true;
            lblChooseStartDate.Location = new System.Drawing.Point(32, 103);
            lblChooseStartDate.Margin = new Padding(6, 0, 6, 0);
            lblChooseStartDate.Name = "lblChooseStartDate";
            lblChooseStartDate.Size = new System.Drawing.Size(255, 38);
            lblChooseStartDate.TabIndex = 2;
            lblChooseStartDate.Text = "Choose a start date";
            // 
            // monthCalendarEndDate
            // 
            monthCalendarEndDate.Location = new System.Drawing.Point(799, 168);
            monthCalendarEndDate.Margin = new Padding(19, 20, 19, 20);
            monthCalendarEndDate.Name = "monthCalendarEndDate";
            monthCalendarEndDate.ShowToday = false;
            monthCalendarEndDate.ShowTodayCircle = false;
            monthCalendarEndDate.TabIndex = 1;
            monthCalendarEndDate.DateChanged += monthCalendarEndDate_DateChanged;
            // 
            // monthCalendarStartDate
            // 
            monthCalendarStartDate.Location = new System.Drawing.Point(32, 168);
            monthCalendarStartDate.Margin = new Padding(19, 20, 19, 20);
            monthCalendarStartDate.MaxDate = new DateTime(2024, 3, 22, 0, 0, 0, 0);
            monthCalendarStartDate.Name = "monthCalendarStartDate";
            monthCalendarStartDate.ShowToday = false;
            monthCalendarStartDate.ShowTodayCircle = false;
            monthCalendarStartDate.TabIndex = 0;
            monthCalendarStartDate.DateChanged += monthCalendarStartDate_DateChanged;
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 580);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "SomerenUI";
            this.Text = "SomerenApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardPictureBox)).EndInit();
            this.fpnlWeek.ResumeLayout(false);
            this.fpnlWeek.PerformLayout();
            this.cashpanel.ResumeLayout(false);
            this.cashpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenuePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockPictureBox)).EndInit();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.roomsPanel.ResumeLayout(false);
            this.roomsPanel.PerformLayout();
            this.pnlActivity.ResumeLayout(false);
            this.pnlActivity.PerformLayout();
            this.teacherpanel.ResumeLayout(false);
            this.teacherpanel.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.pnlTimetable.ResumeLayout(false);
            this.pnlTimetable.PerformLayout();
            this.panelDrinks.ResumeLayout(false);
            this.panelDrinks.PerformLayout();
            this.vatPanel.ResumeLayout(false);
            this.vatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.pnlRevenueReport.ResumeLayout(false);
            this.pnlRevenueReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlStudents;
        private System.Windows.Forms.PictureBox dashboardPictureBox;
        private System.Windows.Forms.PictureBox studentsPictureBox;
        private System.Windows.Forms.PictureBox lecturersPictureBox;
        private System.Windows.Forms.PictureBox activitiesPictureBox;
        private System.Windows.Forms.PictureBox roomsPictureBox;
        private System.Windows.Forms.PictureBox revenuePictureBox;
        private System.Windows.Forms.PictureBox stockPictureBox;

        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Panel teacherpanel;
        private System.Windows.Forms.ListView listViewteachers;

        private System.Windows.Forms.Panel pnlActivity;
        private System.Windows.Forms.ListView lvActivities;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Activity;

        private System.Windows.Forms.Panel roomsPanel;
        private System.Windows.Forms.Panel panelDrinks;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.Label roomsLabel;
        private System.Windows.Forms.Label lecturersLabel;
        private System.Windows.Forms.Label studentsLabel;
        private System.Windows.Forms.Panel panelContainer;
        private Label lblActivity;
        private Panel pnlRevenueReport;
        private MonthCalendar monthCalendarStartDate;
        private ListView lvRevenueReport;
        private Label lblRevenueDateRange;
        private Label lblChooseEndDate;
        private Label lblChooseStartDate;
        private ListView listViewDrinks;
        private MonthCalendar monthCalendarEndDate;
        private ToolStripMenuItem drinksToolStripMenuItem;
        private ToolStripMenuItem drinkStockToolStripMenuItem;
        private ToolStripMenuItem cashRegisterToolStripMenuItem;
        private ToolStripMenuItem revenueReportToolStripMenuItem;
        private Panel cashpanel;
        private ListView listViewdrinks;
        private ListView listViewStudetnsCashRegister;
        private Button btnCheckout;
        private Label lblTotalPrice;
        private Label lblCashRegister;
        private PictureBox pictureBox1;
        private ToolStripMenuItem drinksReportToolStripMenuItem;
        private ToolStripMenuItem vATCalculationToolStripMenuItem;
        private Button btnAdd;
        private Button btnRemove;
        private System.Windows.Forms.TextBox txtInlineEditor;
        private TextBox txtDrinkName;
        private TextBox txtStock;
        private TextBox txtPriceOfDrink;
        private TextBox txtIsAlcoholic;
        private TextBox txtDrinkId;
        private Panel vatPanel;
        private ComboBox cmbYear;
        private PictureBox pictureBox;
        private Label lblLowTariffTotal;
        private Label lblQuarterDates;
        private Label label2;
        private Label label1;
        private ComboBox cmbQuarter;
        private Label lblTotalVAT;
        private Label lblHighTariffTotal;
        private Button btnCalculateVAT;
        private ListView listViewDrinksCashRegister;
        private Label drinksStockLabel;
        private Label lblRevenueReportHeader;
        private Label lblVATReportHeader;
        private ToolStripMenuItem supervisorsToolStripMenuItem;
        private ToolStripMenuItem participantsToolStripMenuItem;
        private ToolStripMenuItem timetableToolStripMenuItem;
        private FlowLayoutPanel fpnlWeek;
        private Panel pnlMonday;
        private Panel pnlFriday;
        private Panel pnlThursday;
        private Panel pnlWednesday;
        private Panel pnlTuesday;
        private Label lblMonday;
        private Label lblTuesday;
        private Label lblWednesday;
        private Label lblThursday;
        private Label lblFriday;
        private Panel pnlTimetable;
        private Label lblWeekDate;
        private Label lblTimetableHeader;
        private DateTimePicker datePickerTimetable;
        private ColumnHeader EndTime;
        private Label lblEndTime;
        private Label lblDate;
        private Label lblName;
        private Label lblActivityID;
        private Button btnChange;
        private Button btnRemo;
        private Button btnAd;
        private TextBox txtDate;
        private TextBox txtName;
        private TextBox txtActivityID;
        private TextBox txtEndTime;
    }
}