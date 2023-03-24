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
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            lecturersToolStripMenuItem = new ToolStripMenuItem();
            activitiesToolStripMenuItem = new ToolStripMenuItem();
            roomsToolStripMenuItem = new ToolStripMenuItem();
            drinksToolStripMenuItem = new ToolStripMenuItem();
            drinkStockToolStripMenuItem = new ToolStripMenuItem();
            cashRegisterToolStripMenuItem = new ToolStripMenuItem();
            revenueReportToolStripMenuItem = new ToolStripMenuItem();
            vATCalculationToolStripMenuItem = new ToolStripMenuItem();
            pnlDashboard = new Panel();
            dashboardPictureBox = new PictureBox();
            lblDashboard = new Label();
            cashpanel = new Panel();
            btnCheckout = new Button();
            listViewStudetnsCashRegister = new ListView();
            listViewDrinksCashRegister = new ListView();
            lblTotalPrice = new Label();
            lblCashRegister = new Label();
            pictureBox1 = new PictureBox();
            listViewdrinks = new ListView();
            btnRemove = new Button();
            btnAdd = new Button();
            txtStock = new TextBox();
            txtPriceOfDrink = new TextBox();
            txtIsAlcoholic = new TextBox();
            txtDrinkName = new TextBox();
            txtDrinkId = new TextBox();
            studentsPictureBox = new PictureBox();
            lecturersPictureBox = new PictureBox();
            activitiesPictureBox = new PictureBox();
            roomsPictureBox = new PictureBox();
			revenuePictureBox = new PictureBox();
            stockPictureBox = new PictureBox();
            pnlStudents = new Panel();
            listViewStudents = new ListView();
            studentsLabel = new Label();
            roomsPanel = new Panel();
            listViewRooms = new ListView();
            roomsLabel = new Label();
            lecturersLabel = new Label();
            Id = new ColumnHeader();
            Activity = new ColumnHeader();
            Date = new ColumnHeader();
            lvActivities = new ListView();
            pnlActivity = new Panel();
            lblActivity = new Label();
            teacherpanel = new Panel();
            listViewteachers = new ListView();
            panelContainer = new Panel();
            panelDrinks = new Panel();
            drinksStockLabel = new Label();
            vatPanel = new Panel();
            btnCalculateVAT = new Button();
            lblTotalVAT = new Label();
            lblHighTariffTotal = new Label();
            lblLowTariffTotal = new Label();
            lblQuarterDates = new Label();
            label2 = new Label();
            label1 = new Label();
            lblVATReportHeader= new Label();
            cmbQuarter = new ComboBox();
            cmbYear = new ComboBox();
            pictureBox = new PictureBox();
            pnlRevenueReport = new Panel();
            lvRevenueReport = new ListView();
            lblRevenueDateRange = new Label();
            lblChooseEndDate = new Label();
            lblChooseStartDate = new Label();
            monthCalendarEndDate = new MonthCalendar();
            monthCalendarStartDate = new MonthCalendar();
			lblRevenueReportHeader = new Label();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).BeginInit();
            cashpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lecturersPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activitiesPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockPictureBox).BeginInit();
            pnlStudents.SuspendLayout();
            roomsPanel.SuspendLayout();
            pnlActivity.SuspendLayout();
            teacherpanel.SuspendLayout();
            panelContainer.SuspendLayout();
            panelDrinks.SuspendLayout();
            vatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            pnlRevenueReport.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, drinksToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(753, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            this.lecturersToolStripMenuItem.Click += new System.EventHandler(this.roomsToolStripMenuItem_Click);
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.activitiesToolStripMenuItem.Text = "Activities";
            this.activitiesToolStripMenuItem.Click += new System.EventHandler(this.activitiesToolStripMenuItem_Click);
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
            // 
            // cashRegisterToolStripMenuItem
            // 
            this.cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            this.cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.cashRegisterToolStripMenuItem.Text = "Cash Register";
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
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drinkStockToolStripMenuItem, cashRegisterToolStripMenuItem, revenueReportToolStripMenuItem, vATCalculationToolStripMenuItem });
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            drinksToolStripMenuItem.Text = "Drinks";
            // 
            // drinkStockToolStripMenuItem
            // 
            drinkStockToolStripMenuItem.Name = "drinkStockToolStripMenuItem";
            drinkStockToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            drinkStockToolStripMenuItem.Text = "Drink Stock";
            drinkStockToolStripMenuItem.Click += drinkStockToolStripMenuItem_Click;
            // 
            // cashRegisterToolStripMenuItem
            // 
            cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            cashRegisterToolStripMenuItem.Text = "Cash Register";
            cashRegisterToolStripMenuItem.Click += cashRegisterToolStripMenuItem_Click;
            // 
            // revenueReportToolStripMenuItem
            // 
            revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            revenueReportToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            revenueReportToolStripMenuItem.Text = "Revenue Report";
            // 
            // vATCalculationToolStripMenuItem
            // 
            vATCalculationToolStripMenuItem.Name = "vATCalculationToolStripMenuItem";
            vATCalculationToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            vATCalculationToolStripMenuItem.Text = "VAT calculation";
            vATCalculationToolStripMenuItem.Click += vATCalculationToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.dashboardPictureBox);
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(861, 548);
            this.pnlDashboard.TabIndex = 1;
            // 
            // dashboardPictureBox
            // 
            dashboardPictureBox.Image = Resources.someren;
            dashboardPictureBox.Location = new System.Drawing.Point(626, 0);
            dashboardPictureBox.Margin = new Padding(1, 3, 1, 3);
            dashboardPictureBox.Name = "dashboardPictureBox";
            dashboardPictureBox.Size = new System.Drawing.Size(127, 116);
            dashboardPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            dashboardPictureBox.TabIndex = 2;
            dashboardPictureBox.TabStop = false;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Location = new System.Drawing.Point(17, 24);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(262, 20);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Welcome to the Someren Application!";
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
            this.pnlRevenueReport.Location = new System.Drawing.Point(0, 0);
            this.pnlRevenueReport.Controls.Add(this.revenuePictureBox);
            this.revenuePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pnlRevenueReport.Name = "pnlRevenueReport";
            this.pnlRevenueReport.Size = new System.Drawing.Size(745, 462);
            this.pnlRevenueReport.TabIndex = 3;
            // 
            // lblRevenueReportHeader
            // 
            this.lblRevenueReportHeader.AutoSize = true;
            lblRevenueReportHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRevenueReportHeader.Location = new System.Drawing.Point(10, 5);
            this.lblRevenueReportHeader.Name = "lblRevenueReportHeader";
            this.lblRevenueReportHeader.Size = new System.Drawing.Size(114, 20);
            this.lblRevenueReportHeader.TabIndex = 6;
            this.lblRevenueReportHeader.Text = "Revenue Report";
            // 
            // lvRevenueReport
            // 
            this.lvRevenueReport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvRevenueReport.Location = new System.Drawing.Point(15, 300);
            this.lvRevenueReport.Margin = new System.Windows.Forms.Padding(1);
            this.lvRevenueReport.MultiSelect = false;
            this.lvRevenueReport.Name = "lvRevenueReport";
            this.lvRevenueReport.Size = new System.Drawing.Size(580, 150);
            this.lvRevenueReport.TabIndex = 5;
            this.lvRevenueReport.UseCompatibleStateImageBehavior = false;
            // 
            // lblRevenueDateRange
            // 
            this.lblRevenueDateRange.AutoSize = true;
            this.lblRevenueDateRange.Location = new System.Drawing.Point(15, 280);
            this.lblRevenueDateRange.Name = "lblRevenueDateRange";
            this.lblRevenueDateRange.Size = new System.Drawing.Size(114, 20);
            this.lblRevenueDateRange.TabIndex = 4;
            this.lblRevenueDateRange.Text = "Revenue Report";
            // 
            // lblChooseEndDate
            // 
            this.lblChooseEndDate.AutoSize = true;
            this.lblChooseEndDate.Location = new System.Drawing.Point(373, 46);
            this.lblChooseEndDate.Name = "lblChooseEndDate";
            this.lblChooseEndDate.Size = new System.Drawing.Size(141, 20);
            this.lblChooseEndDate.TabIndex = 3;
            this.lblChooseEndDate.Text = "Choose an end date";
            // 
            // lblChooseStartDate
            // 
            this.lblChooseStartDate.AutoSize = true;
            this.lblChooseStartDate.Location = new System.Drawing.Point(15, 46);
            this.lblChooseStartDate.Name = "lblChooseStartDate";
            this.lblChooseStartDate.Size = new System.Drawing.Size(137, 20);
            this.lblChooseStartDate.TabIndex = 2;
            this.lblChooseStartDate.Text = "Choose a start date";
            // 
            // monthCalendarEndDate
            // 
            this.monthCalendarEndDate.Location = new System.Drawing.Point(373, 75);
            this.monthCalendarEndDate.Name = "monthCalendarEndDate";
            this.monthCalendarEndDate.ShowToday = false;
            this.monthCalendarEndDate.ShowTodayCircle = false;
            this.monthCalendarEndDate.TabIndex = 1;
            this.monthCalendarEndDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarEndDate_DateChanged);
            // 
            // monthCalendarStartDate
            // 
            this.monthCalendarStartDate.Location = new System.Drawing.Point(15, 75);
            this.monthCalendarStartDate.MaxDate = new System.DateTime(2024, 3, 22, 0, 0, 0, 0);
            this.monthCalendarStartDate.Name = "monthCalendarStartDate";
            this.monthCalendarStartDate.ShowToday = false;
            this.monthCalendarStartDate.ShowTodayCircle = false;
            this.monthCalendarStartDate.TabIndex = 0;
            this.monthCalendarStartDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarStartDate_DateChanged);
            // 
            // cashpanel
            // 
            cashpanel.Controls.Add(btnCheckout);
            cashpanel.Controls.Add(listViewStudetnsCashRegister);
            cashpanel.Controls.Add(listViewDrinksCashRegister);
            cashpanel.Controls.Add(lblTotalPrice);
            cashpanel.Controls.Add(lblCashRegister);
            cashpanel.Controls.Add(pictureBox1);
            cashpanel.Location = new System.Drawing.Point(0, 0);
            cashpanel.Margin = new Padding(2);
            cashpanel.Name = "cashpanel";
            cashpanel.Size = new System.Drawing.Size(745, 462);
            cashpanel.TabIndex = 3;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new System.Drawing.Point(440, 270);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new System.Drawing.Size(83, 25);
            btnCheckout.TabIndex = 2;
            btnCheckout.Text = "Buy";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // listViewStudetnsCashRegister
            // 
            listViewStudetnsCashRegister.FullRowSelect = true;
            listViewStudetnsCashRegister.GridLines = true;
            listViewStudetnsCashRegister.Location = new System.Drawing.Point(25, 38);
            listViewStudetnsCashRegister.Margin = new Padding(2);
            listViewStudetnsCashRegister.Name = "listViewStudetnsCashRegister";
            listViewStudetnsCashRegister.Size = new System.Drawing.Size(498, 101);
            listViewStudetnsCashRegister.TabIndex = 0;
            listViewStudetnsCashRegister.UseCompatibleStateImageBehavior = false;
            listViewStudetnsCashRegister.SelectedIndexChanged += ListView_SelectedIndexChanged;
            // 
            // listViewDrinksCashRegister
            // 
            listViewDrinksCashRegister.FullRowSelect = true;
            listViewDrinksCashRegister.GridLines = true;
            listViewDrinksCashRegister.Location = new System.Drawing.Point(25, 146);
            listViewDrinksCashRegister.Margin = new Padding(2);
            listViewDrinksCashRegister.Name = "listViewDrinksCashRegister";
            listViewDrinksCashRegister.Size = new System.Drawing.Size(498, 101);
            listViewDrinksCashRegister.TabIndex = 4;
            listViewDrinksCashRegister.UseCompatibleStateImageBehavior = false;
            listViewdrinks.SelectedIndexChanged += ListView_SelectedIndexChanged;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new System.Drawing.Point(36, 274);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new System.Drawing.Size(72, 17);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "Total price:";
            // 
            // lblCashRegister
            // 
            lblCashRegister.AutoSize = true;
            lblCashRegister.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCashRegister.Location = new System.Drawing.Point(10, 4);
            lblCashRegister.Name = "lblCashRegister";
            lblCashRegister.Size = new System.Drawing.Size(123, 37);
            lblCashRegister.TabIndex = 3;
            lblCashRegister.Text = "Cash Register";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.someren;
            pictureBox1.Location = new System.Drawing.Point(626, 0);
            pictureBox1.Margin = new Padding(1, 3, 1, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(127, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // listViewdrinks
            // 
            listViewdrinks.FullRowSelect = true;
            listViewdrinks.GridLines = true;
            listViewdrinks.Location = new System.Drawing.Point(25, 41);
            listViewdrinks.Margin = new Padding(2);
            listViewdrinks.Name = "listViewdrinks";
            listViewdrinks.Size = new System.Drawing.Size(498, 101);
            listViewdrinks.TabIndex = 1;
            listViewdrinks.UseCompatibleStateImageBehavior = false;
            
            // 
            // btnRemove
            // 
            btnRemove.Location = new System.Drawing.Point(662, 210);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(83, 25);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove drink";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += BtnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(662, 172);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(83, 25);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add drink";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new System.Drawing.Point(416, 172);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "50";
            txtStock.Size = new System.Drawing.Size(110, 25);
            txtStock.TabIndex = 4;
            // 
            // txtPriceOfDrink
            // 
            txtPriceOfDrink.Location = new System.Drawing.Point(545, 172);
            txtPriceOfDrink.Name = "txtPriceOfDrink";
            txtPriceOfDrink.PlaceholderText = "2.50";
            txtPriceOfDrink.Size = new System.Drawing.Size(110, 25);
            txtPriceOfDrink.TabIndex = 5;
            // 
            // txtIsAlcoholic
            // 
            txtIsAlcoholic.Location = new System.Drawing.Point(285, 172);
            txtIsAlcoholic.Name = "txtIsAlcoholic";
            txtIsAlcoholic.PlaceholderText = "yes/no";
            txtIsAlcoholic.Size = new System.Drawing.Size(110, 25);
            txtIsAlcoholic.TabIndex = 6;
            // 
            // txtDrinkName
            // 
            txtDrinkName.Location = new System.Drawing.Point(153, 172);
            txtDrinkName.Name = "txtDrinkName";
            txtDrinkName.PlaceholderText = "Beer";
            txtDrinkName.Size = new System.Drawing.Size(110, 25);
            txtDrinkName.TabIndex = 3;
            // 
            // txtDrinkId
            // 
            txtDrinkId.Location = new System.Drawing.Point(18, 172);
            txtDrinkId.Name = "txtDrinkId";
            txtDrinkId.PlaceholderText = "15";
            txtDrinkId.Size = new System.Drawing.Size(110, 25);
            txtDrinkId.TabIndex = 7;
            // 
            // studentsPictureBox
            // 
            studentsPictureBox.Image = Resources.someren;
            studentsPictureBox.Location = new System.Drawing.Point(626, 0);
            studentsPictureBox.Margin = new Padding(1, 3, 1, 3);
            studentsPictureBox.Name = "studentsPictureBox";
            studentsPictureBox.Size = new System.Drawing.Size(127, 116);
            studentsPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            studentsPictureBox.TabIndex = 2;
            studentsPictureBox.TabStop = false;
            // 
            // lecturersPictureBox
            // 
            lecturersPictureBox.Image = Resources.someren;
            lecturersPictureBox.Location = new System.Drawing.Point(626, 0);
            lecturersPictureBox.Margin = new Padding(1, 3, 1, 3);
            lecturersPictureBox.Name = "lecturersPictureBox";
            lecturersPictureBox.Size = new System.Drawing.Size(127, 116);
            lecturersPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            lecturersPictureBox.TabIndex = 2;
            lecturersPictureBox.TabStop = false;
            // 
            // activitiesPictureBox
            // 
            activitiesPictureBox.Image = Resources.someren;
            activitiesPictureBox.Location = new System.Drawing.Point(626, 0);
            activitiesPictureBox.Margin = new Padding(1, 3, 1, 3);
            activitiesPictureBox.Name = "activitiesPictureBox";
            activitiesPictureBox.Size = new System.Drawing.Size(127, 116);
            activitiesPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            activitiesPictureBox.TabIndex = 2;
            activitiesPictureBox.TabStop = false;
            // 
            // roomsPictureBox
            // 
            roomsPictureBox.Image = Resources.someren;
            roomsPictureBox.Location = new System.Drawing.Point(626, 0);
            roomsPictureBox.Margin = new Padding(1, 3, 1, 3);
            roomsPictureBox.Name = "roomsPictureBox";
            roomsPictureBox.Size = new System.Drawing.Size(127, 116);
            roomsPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            roomsPictureBox.TabIndex = 2;
            roomsPictureBox.TabStop = false;
            // 
            // revenuePictureBox
            // 
            this.revenuePictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.revenuePictureBox.Location = new System.Drawing.Point(626, 0);
            this.revenuePictureBox.Margin = new System.Windows.Forms.Padding(1,3,1,3);
            this.revenuePictureBox.Name = "revenuePictureBox";
            this.revenuePictureBox.Size = new System.Drawing.Size(127, 116);
            this.revenuePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.revenuePictureBox.TabIndex = 2;
            this.revenuePictureBox.TabStop = false;
            // 
            // stockPictureBox
            // 
            stockPictureBox.Image = Resources.someren;
            stockPictureBox.Location = new System.Drawing.Point(626, 0);
            stockPictureBox.Margin = new Padding(1, 3, 1, 3);
            stockPictureBox.Name = "pictureBox1";
            stockPictureBox.Size = new System.Drawing.Size(127, 116);
            stockPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            stockPictureBox.TabIndex = 3;
            stockPictureBox.TabStop = false;
            // 
            // pnlStudents
            // 
            this.pnlStudents.Controls.Add(this.listViewStudents);
            this.pnlStudents.Controls.Add(this.studentsLabel);
            this.pnlStudents.Controls.Add(this.studentsPictureBox);
            this.pnlStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStudents.Location = new System.Drawing.Point(0, 0);
            this.pnlStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(861, 548);
            this.pnlStudents.TabIndex = 2;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(13, 38);
            listViewStudents.Margin = new Padding(1, 3, 1, 3);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(600, 280);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = View.Details;
            // 
            // studentsLabel
            // 
            studentsLabel.AutoSize = true;
            studentsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            studentsLabel.Location = new System.Drawing.Point(10, 4);
            studentsLabel.Name = "studentsLabel";
            studentsLabel.Size = new System.Drawing.Size(119, 37);
            studentsLabel.TabIndex = 0;
            studentsLabel.Text = "Students";
            // 
            // roomsPanel
            // 
            roomsPanel.Controls.Add(listViewRooms);
            roomsPanel.Controls.Add(roomsLabel);
            roomsPanel.Controls.Add(roomsPictureBox);
            roomsPanel.Dock = DockStyle.Fill;
            roomsPanel.Location = new System.Drawing.Point(0, 0);
            roomsPanel.Margin = new Padding(1);
            roomsPanel.Name = "roomsPanel";
            roomsPanel.Size = new System.Drawing.Size(753, 466);
            roomsPanel.TabIndex = 3;
            // 
            // listViewRooms
            // 
            listViewRooms.Location = new System.Drawing.Point(13, 38);
            listViewRooms.Margin = new Padding(1);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(600, 280);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = View.Details;
            // 
            // roomsLabel
            // 
            roomsLabel.AutoSize = true;
            roomsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            roomsLabel.Location = new System.Drawing.Point(10, 4);
            roomsLabel.Name = "roomsLabel";
            roomsLabel.Size = new System.Drawing.Size(98, 37);
            roomsLabel.TabIndex = 0;
            roomsLabel.Text = "Rooms";
            // 
            // lecturersLabel
            // 
            lecturersLabel.AutoSize = true;
            lecturersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lecturersLabel.Location = new System.Drawing.Point(10, 4);
            lecturersLabel.Name = "lecturersLabel";
            lecturersLabel.Size = new System.Drawing.Size(123, 37);
            lecturersLabel.TabIndex = 0;
            lecturersLabel.Text = "Lecturers";
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 50;
            // 
            // Activity
            // 
            this.Activity.Text = "Activity";
            this.Activity.Width = 200;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 100;
            // 
            // lvActivities
            // 
            this.lvActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Activity,
            this.Date});
            this.lvActivities.FullRowSelect = true;
            this.lvActivities.GridLines = true;
            this.lvActivities.Location = new System.Drawing.Point(15, 45);
            this.lvActivities.Margin = new System.Windows.Forms.Padding(1);
            this.lvActivities.Name = "lvActivities";
            this.lvActivities.Size = new System.Drawing.Size(685, 329);
            this.lvActivities.TabIndex = 1;
            this.lvActivities.UseCompatibleStateImageBehavior = false;
            this.lvActivities.View = System.Windows.Forms.View.Details;
            // 
            // pnlActivity
            // 
            this.pnlActivity.Controls.Add(this.lvActivities);
            this.pnlActivity.Controls.Add(this.lblActivity);
            this.pnlActivity.Controls.Add(this.activitiesPictureBox);
            this.pnlActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActivity.Location = new System.Drawing.Point(0, 0);
            this.pnlActivity.Margin = new System.Windows.Forms.Padding(1);
            this.pnlActivity.Name = "pnlActivity";
            this.pnlActivity.Size = new System.Drawing.Size(861, 548);
            this.pnlActivity.TabIndex = 4;
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivity.Location = new System.Drawing.Point(11, 5);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(135, 41);
            this.lblActivity.TabIndex = 2;
            this.lblActivity.Text = "Activities";
            // 
            // teacherpanel
            // 
            this.teacherpanel.Controls.Add(this.listViewteachers);
            this.teacherpanel.Controls.Add(this.lecturersLabel);
            this.teacherpanel.Controls.Add(this.lecturersPictureBox);
            this.teacherpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherpanel.Location = new System.Drawing.Point(0, 0);
            this.teacherpanel.Margin = new System.Windows.Forms.Padding(1);
            this.teacherpanel.Name = "teacherpanel";
            this.teacherpanel.Size = new System.Drawing.Size(861, 548);
            this.teacherpanel.TabIndex = 3;
            // 
            // listViewteachers
            // 
            this.listViewteachers.Location = new System.Drawing.Point(15, 45);
            this.listViewteachers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewteachers.Name = "listViewteachers";
            this.listViewteachers.Size = new System.Drawing.Size(685, 329);
            this.listViewteachers.TabIndex = 9999999;
            this.listViewteachers.UseCompatibleStateImageBehavior = false;
            this.listViewteachers.View = System.Windows.Forms.View.Details;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(panelDrinks);
            panelContainer.Controls.Add(pnlDashboard);
            panelContainer.Controls.Add(pnlStudents);
            panelContainer.Controls.Add(cashpanel);
            panelContainer.Controls.Add(vatPanel);
			panelContainer.Controls.Add(pnlRevenueReport);
            panelContainer.Controls.Add(roomsPanel);
            panelContainer.Controls.Add(pnlActivity);
            panelContainer.Controls.Add(teacherpanel);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new System.Drawing.Point(0, 27);
            panelContainer.Margin = new Padding(1);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new System.Drawing.Size(753, 466);
            panelContainer.TabIndex = 2;
            // 
            // panelDrinks
            // 
            panelDrinks.Controls.Add(drinksStockLabel);
            panelDrinks.Controls.Add(txtDrinkId);
            panelDrinks.Controls.Add(txtDrinkName);
            panelDrinks.Controls.Add(txtIsAlcoholic);
            panelDrinks.Controls.Add(txtStock);
            panelDrinks.Controls.Add(txtPriceOfDrink);
            panelDrinks.Controls.Add(btnAdd);
            panelDrinks.Controls.Add(btnRemove);
            panelDrinks.Controls.Add(listViewdrinks);
            panelDrinks.Controls.Add(stockPictureBox);
            panelDrinks.Location = new System.Drawing.Point(0, 0);
            panelDrinks.Name = "panelDrinks";
            panelDrinks.Size = new System.Drawing.Size(753, 493);
            panelDrinks.TabIndex = 3;
            // 
            // drinksStockLabel
            // 
            drinksStockLabel.AutoSize = true;
            drinksStockLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            drinksStockLabel.Location = new System.Drawing.Point(10, 5);
            drinksStockLabel.Name = "drinksStockLabel";
            drinksStockLabel.Size = new System.Drawing.Size(91, 37);
            drinksStockLabel.TabIndex = 3;
            drinksStockLabel.Text = "Drinks";
            // 
            // vatPanel
            // 
            vatPanel.Controls.Add(btnCalculateVAT);
            vatPanel.Controls.Add(lblTotalVAT);
            vatPanel.Controls.Add(lblHighTariffTotal);
            vatPanel.Controls.Add(lblLowTariffTotal);
            vatPanel.Controls.Add(lblQuarterDates);
            vatPanel.Controls.Add(label2);
            vatPanel.Controls.Add(label1);
            vatPanel.Controls.Add(cmbQuarter);
            vatPanel.Controls.Add(cmbYear);
            vatPanel.Controls.Add(pictureBox);
            vatPanel.Controls.Add(lblVATReportHeader);
            vatPanel.Dock = DockStyle.Fill;
            vatPanel.Location = new System.Drawing.Point(0, 0);
            vatPanel.Name = "vatPanel";
            vatPanel.Size = new System.Drawing.Size(753, 466);
            vatPanel.TabIndex = 3;
            // 
            // btnCalculateVAT
            // 
            btnCalculateVAT.Location = new System.Drawing.Point(340, 376);
            btnCalculateVAT.Name = "btnCalculateVAT";
            btnCalculateVAT.Size = new System.Drawing.Size(83, 25);
            btnCalculateVAT.TabIndex = 11;
            btnCalculateVAT.Text = "Calculate VAT";
            btnCalculateVAT.UseVisualStyleBackColor = true;
            btnCalculateVAT.Click += btnCalculateVAT_Click;
            // 
            // lblTotalVAT
            // 
            lblTotalVAT.AutoSize = true;
            lblTotalVAT.Location = new System.Drawing.Point(33, 384);
            lblTotalVAT.Name = "lblTotalVAT";
            lblTotalVAT.Size = new System.Drawing.Size(270, 17);
            lblTotalVAT.TabIndex = 10;
            lblTotalVAT.Text = "Total VAT amount payable: ____________________ ";
            // 
            // lblHighTariffTotal
            // 
            lblHighTariffTotal.AutoSize = true;
            lblHighTariffTotal.Location = new System.Drawing.Point(28, 228);
            lblHighTariffTotal.Name = "lblHighTariffTotal";
            lblHighTariffTotal.Size = new System.Drawing.Size(366, 17);
            lblHighTariffTotal.TabIndex = 9;
            lblHighTariffTotal.Text = "Total VAT (high tariff, 21%) amount payable: ____________________";
            // 
            // lblLowTariffTotal
            // 
            lblLowTariffTotal.AutoSize = true;
            lblLowTariffTotal.Location = new System.Drawing.Point(28, 182);
            lblLowTariffTotal.Name = "lblLowTariffTotal";
            lblLowTariffTotal.Size = new System.Drawing.Size(354, 17);
            lblLowTariffTotal.TabIndex = 8;
            lblLowTariffTotal.Text = "Total VAT (low tariff, 6%) amount payable: ____________________";
            // 
            // lblQuarterDates
            // 
            lblQuarterDates.AutoSize = true;
            lblQuarterDates.Location = new System.Drawing.Point(28, 137);
            lblQuarterDates.Name = "lblQuarterDates";
            lblQuarterDates.Size = new System.Drawing.Size(275, 17);
            lblQuarterDates.TabIndex = 7;
            lblQuarterDates.Text = "Quarter runs from: _____________ to:______________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(28, 92);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 17);
            label2.TabIndex = 6;
            label2.Text = "Select quarter:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(28, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 17);
            label1.TabIndex = 5;
            label1.Text = "Select year:";
            //
            // lblVATReportHeader
            //
            lblVATReportHeader.AutoSize = true;
            lblVATReportHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblVATReportHeader.Location = new System.Drawing.Point(10, 5);
            lblVATReportHeader.Name = "lblVATReportHeader";
            lblVATReportHeader.Size = new System.Drawing.Size(114, 20);
            lblVATReportHeader.TabIndex = 7;
            lblVATReportHeader.Text = "VAT Report";
            // 
            // cmbQuarter
            // 
            cmbQuarter.FormattingEnabled = true;
            cmbQuarter.Location = new System.Drawing.Point(153, 89);
            cmbQuarter.Name = "cmbQuarter";
            cmbQuarter.Size = new System.Drawing.Size(134, 25);
            cmbQuarter.TabIndex = 4;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new System.Drawing.Point(153, 46);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new System.Drawing.Size(134, 25);
            cmbYear.TabIndex = 3;
            // 
            // pictureBox
            // 
            pictureBox.Image = Resources.someren;
            pictureBox.Location = new System.Drawing.Point(626, 0);
            pictureBox.Margin = new Padding(2, 3, 2, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(127, 116);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(753, 493);
            Controls.Add(panelContainer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 6, 4, 6);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).EndInit();
            cashpanel.ResumeLayout(false);
            cashpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)lecturersPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)activitiesPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomsPictureBox).EndInit();
			((System.ComponentModel.ISupportInitialize)(revenuePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(stockPictureBox)).EndInit();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            roomsPanel.ResumeLayout(false);
            roomsPanel.PerformLayout();
            pnlActivity.ResumeLayout(false);
            pnlActivity.PerformLayout();
            teacherpanel.ResumeLayout(false);
            teacherpanel.PerformLayout();
            panelContainer.ResumeLayout(false);
            panelDrinks.ResumeLayout(false);
            panelDrinks.PerformLayout();
            vatPanel.ResumeLayout(false);
            vatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            pnlRevenueReport.ResumeLayout(false);
            pnlRevenueReport.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ColumnHeader Date;

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
    }
}