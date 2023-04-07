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
            supervisorsToolStripMenuItem = new ToolStripMenuItem();
            participantsToolStripMenuItem = new ToolStripMenuItem();
            timetableToolStripMenuItem = new ToolStripMenuItem();
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
            StartTime = new ColumnHeader();
            lvActivities = new ListView();
            EndTime = new ColumnHeader();
            pnlActivity = new Panel();
            txtEndTime = new TextBox();
            txtDate = new TextBox();
            txtName = new TextBox();
            txtActivityID = new TextBox();
            lblEndTime = new Label();
            lblDate = new Label();
            lblName = new Label();
            lblActivityID = new Label();
            btnRefresh = new Button();
            btnChange = new Button();
            btnRemo = new Button();
            btnAd = new Button();
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
            cmbQuarter = new ComboBox();
            cmbYear = new ComboBox();
            pictureBox = new PictureBox();
            lblVATReportHeader = new Label();
            pnlRevenueReport = new Panel();
            lblRevenueReportHeader = new Label();
            lvRevenueReport = new ListView();
            lblRevenueDateRange = new Label();
            lblChooseEndDate = new Label();
            lblChooseStartDate = new Label();
            monthCalendarEndDate = new MonthCalendar();
            monthCalendarStartDate = new MonthCalendar();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).BeginInit();
            cashpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lecturersPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)activitiesPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)revenuePictureBox).BeginInit();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem, drinksToolStripMenuItem, supervisorsToolStripMenuItem, participantsToolStripMenuItem, timetableToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(17, 7, 0, 7);
            menuStrip1.Size = new System.Drawing.Size(1614, 56);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
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
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(287, 46);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
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
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(150, 42);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
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
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(121, 42);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // drinksToolStripMenuItem
            // 
            drinksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drinkStockToolStripMenuItem, cashRegisterToolStripMenuItem, revenueReportToolStripMenuItem, vATCalculationToolStripMenuItem });
            drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            drinksToolStripMenuItem.Size = new System.Drawing.Size(116, 42);
            drinksToolStripMenuItem.Text = "Drinks";
            // 
            // drinkStockToolStripMenuItem
            // 
            drinkStockToolStripMenuItem.Name = "drinkStockToolStripMenuItem";
            drinkStockToolStripMenuItem.Size = new System.Drawing.Size(349, 46);
            drinkStockToolStripMenuItem.Text = "Drink Stock";
            drinkStockToolStripMenuItem.Click += drinkStockToolStripMenuItem_Click;
            // 
            // cashRegisterToolStripMenuItem
            // 
            cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(349, 46);
            cashRegisterToolStripMenuItem.Text = "Cash Register";
            cashRegisterToolStripMenuItem.Click += cashRegisterToolStripMenuItem_Click;
            // 
            // revenueReportToolStripMenuItem
            // 
            revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            revenueReportToolStripMenuItem.Size = new System.Drawing.Size(349, 46);
            revenueReportToolStripMenuItem.Text = "Revenue Report";
            revenueReportToolStripMenuItem.Click += revenueReportToolStripMenuItem_Click;
            // 
            // vATCalculationToolStripMenuItem
            // 
            vATCalculationToolStripMenuItem.Name = "vATCalculationToolStripMenuItem";
            vATCalculationToolStripMenuItem.Size = new System.Drawing.Size(349, 46);
            vATCalculationToolStripMenuItem.Text = "VAT calculation";
            vATCalculationToolStripMenuItem.Click += vATCalculationToolStripMenuItem_Click;
            // 
            // supervisorsToolStripMenuItem
            // 
            supervisorsToolStripMenuItem.Name = "supervisorsToolStripMenuItem";
            supervisorsToolStripMenuItem.Size = new System.Drawing.Size(179, 42);
            supervisorsToolStripMenuItem.Text = "Supervisors";
            // 
            // participantsToolStripMenuItem
            // 
            participantsToolStripMenuItem.Name = "participantsToolStripMenuItem";
            participantsToolStripMenuItem.Size = new System.Drawing.Size(179, 42);
            participantsToolStripMenuItem.Text = "Participants";
            // 
            // timetableToolStripMenuItem
            // 
            timetableToolStripMenuItem.Name = "timetableToolStripMenuItem";
            timetableToolStripMenuItem.Size = new System.Drawing.Size(159, 42);
            timetableToolStripMenuItem.Text = "Timetable";
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(dashboardPictureBox);
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Dock = DockStyle.Fill;
            pnlDashboard.Location = new System.Drawing.Point(0, 0);
            pnlDashboard.Margin = new Padding(6, 11, 6, 11);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1614, 1046);
            pnlDashboard.TabIndex = 1;
            // 
            // dashboardPictureBox
            // 
            dashboardPictureBox.Image = Resources.someren;
            dashboardPictureBox.Location = new System.Drawing.Point(1341, 0);
            dashboardPictureBox.Margin = new Padding(2, 7, 2, 7);
            dashboardPictureBox.Name = "dashboardPictureBox";
            dashboardPictureBox.Size = new System.Drawing.Size(272, 259);
            dashboardPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            dashboardPictureBox.TabIndex = 2;
            dashboardPictureBox.TabStop = false;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(36, 54);
            lblDashboard.Margin = new Padding(6, 0, 6, 0);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(487, 38);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
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
            cashpanel.Margin = new Padding(4);
            cashpanel.Name = "cashpanel";
            cashpanel.Size = new System.Drawing.Size(1596, 1033);
            cashpanel.TabIndex = 3;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new System.Drawing.Point(943, 894);
            btnCheckout.Margin = new Padding(6, 7, 6, 7);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new System.Drawing.Size(178, 56);
            btnCheckout.TabIndex = 2;
            btnCheckout.Text = "Buy";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // listViewStudetnsCashRegister
            // 
            listViewStudetnsCashRegister.FullRowSelect = true;
            listViewStudetnsCashRegister.GridLines = true;
            listViewStudetnsCashRegister.Location = new System.Drawing.Point(54, 85);
            listViewStudetnsCashRegister.Margin = new Padding(4);
            listViewStudetnsCashRegister.Name = "listViewStudetnsCashRegister";
            listViewStudetnsCashRegister.Size = new System.Drawing.Size(1063, 330);
            listViewStudetnsCashRegister.TabIndex = 0;
            listViewStudetnsCashRegister.UseCompatibleStateImageBehavior = false;
            listViewStudetnsCashRegister.SelectedIndexChanged += ListViewStudetnsCashRegister_SelectedIndexChanged;
            // 
            // listViewDrinksCashRegister
            // 
            listViewDrinksCashRegister.FullRowSelect = true;
            listViewDrinksCashRegister.GridLines = true;
            listViewDrinksCashRegister.Location = new System.Drawing.Point(54, 447);
            listViewDrinksCashRegister.Margin = new Padding(4);
            listViewDrinksCashRegister.Name = "listViewDrinksCashRegister";
            listViewDrinksCashRegister.Size = new System.Drawing.Size(1063, 330);
            listViewDrinksCashRegister.TabIndex = 4;
            listViewDrinksCashRegister.UseCompatibleStateImageBehavior = false;
            listViewDrinksCashRegister.SelectedIndexChanged += ListViewDrinksCashRegister_SelectedIndexChanged;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Location = new System.Drawing.Point(77, 894);
            lblTotalPrice.Margin = new Padding(6, 0, 6, 0);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new System.Drawing.Size(150, 38);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "Total price:";
            // 
            // lblCashRegister
            // 
            lblCashRegister.AutoSize = true;
            lblCashRegister.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblCashRegister.Location = new System.Drawing.Point(21, 9);
            lblCashRegister.Margin = new Padding(6, 0, 6, 0);
            lblCashRegister.Name = "lblCashRegister";
            lblCashRegister.Size = new System.Drawing.Size(313, 65);
            lblCashRegister.TabIndex = 3;
            lblCashRegister.Text = "Cash Register";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.someren;
            pictureBox1.Location = new System.Drawing.Point(1341, 0);
            pictureBox1.Margin = new Padding(2, 7, 2, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(272, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // listViewdrinks
            // 
            listViewdrinks.FullRowSelect = true;
            listViewdrinks.GridLines = true;
            listViewdrinks.Location = new System.Drawing.Point(54, 92);
            listViewdrinks.Margin = new Padding(4);
            listViewdrinks.Name = "listViewdrinks";
            listViewdrinks.Size = new System.Drawing.Size(1063, 221);
            listViewdrinks.TabIndex = 1;
            listViewdrinks.UseCompatibleStateImageBehavior = false;
            // 
            // btnRemove
            // 
            btnRemove.Location = new System.Drawing.Point(1419, 469);
            btnRemove.Margin = new Padding(6, 7, 6, 7);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new System.Drawing.Size(178, 56);
            btnRemove.TabIndex = 6;
            btnRemove.Text = "Remove drink";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += BtnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(1419, 384);
            btnAdd.Margin = new Padding(6, 7, 6, 7);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(178, 56);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add drink";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // txtStock
            // 
            txtStock.Location = new System.Drawing.Point(891, 384);
            txtStock.Margin = new Padding(6, 7, 6, 7);
            txtStock.Name = "txtStock";
            txtStock.PlaceholderText = "50";
            txtStock.Size = new System.Drawing.Size(231, 45);
            txtStock.TabIndex = 4;
            // 
            // txtPriceOfDrink
            // 
            txtPriceOfDrink.Location = new System.Drawing.Point(1168, 384);
            txtPriceOfDrink.Margin = new Padding(6, 7, 6, 7);
            txtPriceOfDrink.Name = "txtPriceOfDrink";
            txtPriceOfDrink.PlaceholderText = "2.50";
            txtPriceOfDrink.Size = new System.Drawing.Size(231, 45);
            txtPriceOfDrink.TabIndex = 5;
            // 
            // txtIsAlcoholic
            // 
            txtIsAlcoholic.Location = new System.Drawing.Point(611, 384);
            txtIsAlcoholic.Margin = new Padding(6, 7, 6, 7);
            txtIsAlcoholic.Name = "txtIsAlcoholic";
            txtIsAlcoholic.PlaceholderText = "yes/no";
            txtIsAlcoholic.Size = new System.Drawing.Size(231, 45);
            txtIsAlcoholic.TabIndex = 6;
            // 
            // txtDrinkName
            // 
            txtDrinkName.Location = new System.Drawing.Point(328, 384);
            txtDrinkName.Margin = new Padding(6, 7, 6, 7);
            txtDrinkName.Name = "txtDrinkName";
            txtDrinkName.PlaceholderText = "Beer";
            txtDrinkName.Size = new System.Drawing.Size(231, 45);
            txtDrinkName.TabIndex = 3;
            // 
            // txtDrinkId
            // 
            txtDrinkId.Location = new System.Drawing.Point(39, 384);
            txtDrinkId.Margin = new Padding(6, 7, 6, 7);
            txtDrinkId.Name = "txtDrinkId";
            txtDrinkId.PlaceholderText = "15";
            txtDrinkId.Size = new System.Drawing.Size(231, 45);
            txtDrinkId.TabIndex = 7;
            // 
            // studentsPictureBox
            // 
            studentsPictureBox.Image = Resources.someren;
            studentsPictureBox.Location = new System.Drawing.Point(1341, 0);
            studentsPictureBox.Margin = new Padding(2, 7, 2, 7);
            studentsPictureBox.Name = "studentsPictureBox";
            studentsPictureBox.Size = new System.Drawing.Size(272, 259);
            studentsPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            studentsPictureBox.TabIndex = 2;
            studentsPictureBox.TabStop = false;
            // 
            // lecturersPictureBox
            // 
            lecturersPictureBox.Image = Resources.someren;
            lecturersPictureBox.Location = new System.Drawing.Point(1341, 0);
            lecturersPictureBox.Margin = new Padding(2, 7, 2, 7);
            lecturersPictureBox.Name = "lecturersPictureBox";
            lecturersPictureBox.Size = new System.Drawing.Size(272, 259);
            lecturersPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            lecturersPictureBox.TabIndex = 2;
            lecturersPictureBox.TabStop = false;
            // 
            // activitiesPictureBox
            // 
            activitiesPictureBox.Image = Resources.someren;
            activitiesPictureBox.Location = new System.Drawing.Point(1322, 11);
            activitiesPictureBox.Margin = new Padding(2, 7, 2, 7);
            activitiesPictureBox.Name = "activitiesPictureBox";
            activitiesPictureBox.Size = new System.Drawing.Size(272, 259);
            activitiesPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            activitiesPictureBox.TabIndex = 2;
            activitiesPictureBox.TabStop = false;
            // 
            // roomsPictureBox
            // 
            roomsPictureBox.Image = Resources.someren;
            roomsPictureBox.Location = new System.Drawing.Point(1341, 0);
            roomsPictureBox.Margin = new Padding(2, 7, 2, 7);
            roomsPictureBox.Name = "roomsPictureBox";
            roomsPictureBox.Size = new System.Drawing.Size(272, 259);
            roomsPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            roomsPictureBox.TabIndex = 2;
            roomsPictureBox.TabStop = false;
            // 
            // revenuePictureBox
            // 
            revenuePictureBox.Image = Resources.someren;
            revenuePictureBox.Location = new System.Drawing.Point(1341, 0);
            revenuePictureBox.Margin = new Padding(2, 7, 2, 7);
            revenuePictureBox.Name = "revenuePictureBox";
            revenuePictureBox.Size = new System.Drawing.Size(272, 259);
            revenuePictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            revenuePictureBox.TabIndex = 2;
            revenuePictureBox.TabStop = false;
            // 
            // stockPictureBox
            // 
            stockPictureBox.Image = Resources.someren;
            stockPictureBox.Location = new System.Drawing.Point(1341, 0);
            stockPictureBox.Margin = new Padding(2, 7, 2, 7);
            stockPictureBox.Name = "stockPictureBox";
            stockPictureBox.Size = new System.Drawing.Size(272, 259);
            stockPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            stockPictureBox.TabIndex = 3;
            stockPictureBox.TabStop = false;
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(studentsLabel);
            pnlStudents.Controls.Add(studentsPictureBox);
            pnlStudents.Dock = DockStyle.Fill;
            pnlStudents.Location = new System.Drawing.Point(0, 0);
            pnlStudents.Margin = new Padding(6, 9, 6, 9);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(1614, 1046);
            pnlStudents.TabIndex = 2;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(28, 85);
            listViewStudents.Margin = new Padding(2, 7, 2, 7);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(1281, 621);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = View.Details;
            // 
            // studentsLabel
            // 
            studentsLabel.AutoSize = true;
            studentsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            studentsLabel.Location = new System.Drawing.Point(21, 9);
            studentsLabel.Margin = new Padding(6, 0, 6, 0);
            studentsLabel.Name = "studentsLabel";
            studentsLabel.Size = new System.Drawing.Size(211, 65);
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
            roomsPanel.Margin = new Padding(2);
            roomsPanel.Name = "roomsPanel";
            roomsPanel.Size = new System.Drawing.Size(1614, 1046);
            roomsPanel.TabIndex = 3;
            // 
            // listViewRooms
            // 
            listViewRooms.Location = new System.Drawing.Point(28, 85);
            listViewRooms.Margin = new Padding(2);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(1281, 621);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = View.Details;
            // 
            // roomsLabel
            // 
            roomsLabel.AutoSize = true;
            roomsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            roomsLabel.Location = new System.Drawing.Point(21, 9);
            roomsLabel.Margin = new Padding(6, 0, 6, 0);
            roomsLabel.Name = "roomsLabel";
            roomsLabel.Size = new System.Drawing.Size(173, 65);
            roomsLabel.TabIndex = 0;
            roomsLabel.Text = "Rooms";
            // 
            // lecturersLabel
            // 
            lecturersLabel.AutoSize = true;
            lecturersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lecturersLabel.Location = new System.Drawing.Point(21, 9);
            lecturersLabel.Margin = new Padding(6, 0, 6, 0);
            lecturersLabel.Name = "lecturersLabel";
            lecturersLabel.Size = new System.Drawing.Size(220, 65);
            lecturersLabel.TabIndex = 0;
            lecturersLabel.Text = "Lecturers";
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 50;
            // 
            // Activity
            // 
            Activity.Text = "Activity";
            Activity.Width = 200;
            // 
            // StartTime
            // 
            StartTime.Text = "Start Time";
            StartTime.Width = 100;
            // 
            // lvActivities
            // 
            lvActivities.Columns.AddRange(new ColumnHeader[] { Id, Activity, StartTime, EndTime });
            lvActivities.FullRowSelect = true;
            lvActivities.GridLines = true;
            lvActivities.Location = new System.Drawing.Point(24, 103);
            lvActivities.Margin = new Padding(2);
            lvActivities.Name = "lvActivities";
            lvActivities.Size = new System.Drawing.Size(1196, 730);
            lvActivities.TabIndex = 1;
            lvActivities.UseCompatibleStateImageBehavior = false;
            lvActivities.View = View.Details;
            lvActivities.SelectedIndexChanged += lvActivities_SelectedIndexChanged;
            // 
            // EndTime
            // 
            EndTime.Text = "End Time";
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
            pnlActivity.Controls.Add(btnRefresh);
            pnlActivity.Controls.Add(btnChange);
            pnlActivity.Controls.Add(btnRemo);
            pnlActivity.Controls.Add(btnAd);
            pnlActivity.Controls.Add(lvActivities);
            pnlActivity.Controls.Add(lblActivity);
            pnlActivity.Controls.Add(activitiesPictureBox);
            pnlActivity.Dock = DockStyle.Fill;
            pnlActivity.Location = new System.Drawing.Point(0, 56);
            pnlActivity.Margin = new Padding(2);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new System.Drawing.Size(1614, 1046);
            pnlActivity.TabIndex = 4;
            // 
            // txtEndTime
            // 
            txtEndTime.Location = new System.Drawing.Point(1275, 862);
            txtEndTime.Name = "txtEndTime";
            txtEndTime.Size = new System.Drawing.Size(200, 45);
            txtEndTime.TabIndex = 14;
            // 
            // txtDate
            // 
            txtDate.Location = new System.Drawing.Point(891, 858);
            txtDate.Name = "txtDate";
            txtDate.Size = new System.Drawing.Size(200, 45);
            txtDate.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(538, 855);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(200, 45);
            txtName.TabIndex = 12;
            // 
            // txtActivityID
            // 
            txtActivityID.Location = new System.Drawing.Point(169, 861);
            txtActivityID.Name = "txtActivityID";
            txtActivityID.Size = new System.Drawing.Size(200, 45);
            txtActivityID.TabIndex = 11;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Location = new System.Drawing.Point(1119, 858);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new System.Drawing.Size(132, 38);
            lblEndTime.TabIndex = 10;
            lblEndTime.Text = "End Time";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new System.Drawing.Point(799, 862);
            lblDate.Name = "lblDate";
            lblDate.Size = new System.Drawing.Size(75, 38);
            lblDate.TabIndex = 9;
            lblDate.Text = "Date";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(441, 861);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(91, 38);
            lblName.TabIndex = 8;
            lblName.Text = "Name";
            // 
            // lblActivityID
            // 
            lblActivityID.AutoSize = true;
            lblActivityID.Location = new System.Drawing.Point(32, 849);
            lblActivityID.Name = "lblActivityID";
            lblActivityID.Size = new System.Drawing.Size(142, 38);
            lblActivityID.TabIndex = 7;
            lblActivityID.Text = "Activity ID";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new System.Drawing.Point(1275, 913);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(150, 46);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new System.Drawing.Point(891, 915);
            btnChange.Name = "btnChange";
            btnChange.Size = new System.Drawing.Size(150, 46);
            btnChange.TabIndex = 5;
            btnChange.Text = "Update";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // btnRemo
            // 
            btnRemo.Location = new System.Drawing.Point(538, 915);
            btnRemo.Name = "btnRemo";
            btnRemo.Size = new System.Drawing.Size(150, 46);
            btnRemo.TabIndex = 4;
            btnRemo.Text = "Remove";
            btnRemo.UseVisualStyleBackColor = true;
            btnRemo.Click += btnRemo_Click;
            // 
            // btnAd
            // 
            btnAd.Location = new System.Drawing.Point(180, 915);
            btnAd.Name = "btnAd";
            btnAd.Size = new System.Drawing.Size(150, 46);
            btnAd.TabIndex = 3;
            btnAd.Text = "Add";
            btnAd.UseVisualStyleBackColor = true;
            btnAd.Click += btnAd_Click;
            // 
            // lblActivity
            // 
            lblActivity.AutoSize = true;
            lblActivity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblActivity.Location = new System.Drawing.Point(24, 11);
            lblActivity.Margin = new Padding(6, 0, 6, 0);
            lblActivity.Name = "lblActivity";
            lblActivity.Size = new System.Drawing.Size(217, 65);
            lblActivity.TabIndex = 2;
            lblActivity.Text = "Activities";
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
            listViewteachers.Location = new System.Drawing.Point(32, 101);
            listViewteachers.Margin = new Padding(6, 9, 6, 9);
            listViewteachers.Name = "listViewteachers";
            listViewteachers.Size = new System.Drawing.Size(1463, 730);
            listViewteachers.TabIndex = 9999999;
            listViewteachers.UseCompatibleStateImageBehavior = false;
            listViewteachers.View = View.Details;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(teacherpanel);
            panelContainer.Controls.Add(pnlDashboard);
            panelContainer.Controls.Add(panelDrinks);
            panelContainer.Controls.Add(pnlStudents);
            panelContainer.Controls.Add(cashpanel);
            panelContainer.Controls.Add(vatPanel);
            panelContainer.Controls.Add(pnlRevenueReport);
            panelContainer.Controls.Add(roomsPanel);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new System.Drawing.Point(0, 56);
            panelContainer.Margin = new Padding(2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new System.Drawing.Size(1614, 1046);
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
            panelDrinks.Margin = new Padding(6, 7, 6, 7);
            panelDrinks.Name = "panelDrinks";
            panelDrinks.Size = new System.Drawing.Size(1614, 1102);
            panelDrinks.TabIndex = 3;
            // 
            // drinksStockLabel
            // 
            drinksStockLabel.AutoSize = true;
            drinksStockLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            drinksStockLabel.Location = new System.Drawing.Point(21, 11);
            drinksStockLabel.Margin = new Padding(6, 0, 6, 0);
            drinksStockLabel.Name = "drinksStockLabel";
            drinksStockLabel.Size = new System.Drawing.Size(162, 65);
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
            vatPanel.Margin = new Padding(6, 7, 6, 7);
            vatPanel.Name = "vatPanel";
            vatPanel.Size = new System.Drawing.Size(1614, 1046);
            vatPanel.TabIndex = 3;
            // 
            // btnCalculateVAT
            // 
            btnCalculateVAT.Location = new System.Drawing.Point(729, 840);
            btnCalculateVAT.Margin = new Padding(6, 7, 6, 7);
            btnCalculateVAT.Name = "btnCalculateVAT";
            btnCalculateVAT.Size = new System.Drawing.Size(178, 56);
            btnCalculateVAT.TabIndex = 11;
            btnCalculateVAT.Text = "Calculate VAT";
            btnCalculateVAT.UseVisualStyleBackColor = true;
            btnCalculateVAT.Click += btnCalculateVAT_Click;
            // 
            // lblTotalVAT
            // 
            lblTotalVAT.AutoSize = true;
            lblTotalVAT.Location = new System.Drawing.Point(71, 858);
            lblTotalVAT.Margin = new Padding(6, 0, 6, 0);
            lblTotalVAT.Name = "lblTotalVAT";
            lblTotalVAT.Size = new System.Drawing.Size(598, 38);
            lblTotalVAT.TabIndex = 10;
            lblTotalVAT.Text = "Total VAT amount payable: ____________________ ";
            // 
            // lblHighTariffTotal
            // 
            lblHighTariffTotal.AutoSize = true;
            lblHighTariffTotal.Location = new System.Drawing.Point(60, 510);
            lblHighTariffTotal.Margin = new Padding(6, 0, 6, 0);
            lblHighTariffTotal.Name = "lblHighTariffTotal";
            lblHighTariffTotal.Size = new System.Drawing.Size(802, 38);
            lblHighTariffTotal.TabIndex = 9;
            lblHighTariffTotal.Text = "Total VAT (high tariff, 21%) amount payable: ____________________";
            // 
            // lblLowTariffTotal
            // 
            lblLowTariffTotal.AutoSize = true;
            lblLowTariffTotal.Location = new System.Drawing.Point(60, 407);
            lblLowTariffTotal.Margin = new Padding(6, 0, 6, 0);
            lblLowTariffTotal.Name = "lblLowTariffTotal";
            lblLowTariffTotal.Size = new System.Drawing.Size(775, 38);
            lblLowTariffTotal.TabIndex = 8;
            lblLowTariffTotal.Text = "Total VAT (low tariff, 6%) amount payable: ____________________";
            // 
            // lblQuarterDates
            // 
            lblQuarterDates.AutoSize = true;
            lblQuarterDates.Location = new System.Drawing.Point(60, 306);
            lblQuarterDates.Margin = new Padding(6, 0, 6, 0);
            lblQuarterDates.Name = "lblQuarterDates";
            lblQuarterDates.Size = new System.Drawing.Size(618, 38);
            lblQuarterDates.TabIndex = 7;
            lblQuarterDates.Text = "Quarter runs from: _____________ to:______________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(60, 206);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(195, 38);
            label2.TabIndex = 6;
            label2.Text = "Select quarter:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(60, 110);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(158, 38);
            label1.TabIndex = 5;
            label1.Text = "Select year:";
            // 
            // cmbQuarter
            // 
            cmbQuarter.FormattingEnabled = true;
            cmbQuarter.Location = new System.Drawing.Point(328, 199);
            cmbQuarter.Margin = new Padding(6, 7, 6, 7);
            cmbQuarter.Name = "cmbQuarter";
            cmbQuarter.Size = new System.Drawing.Size(283, 46);
            cmbQuarter.TabIndex = 4;
            // 
            // cmbYear
            // 
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new System.Drawing.Point(328, 103);
            cmbYear.Margin = new Padding(6, 7, 6, 7);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new System.Drawing.Size(283, 46);
            cmbYear.TabIndex = 3;
            // 
            // pictureBox
            // 
            pictureBox.Image = Resources.someren;
            pictureBox.Location = new System.Drawing.Point(1341, 0);
            pictureBox.Margin = new Padding(4, 7, 4, 7);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(272, 259);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
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
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1614, 1102);
            Controls.Add(pnlActivity);
            Controls.Add(panelContainer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(9, 13, 9, 13);
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
            ((System.ComponentModel.ISupportInitialize)revenuePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockPictureBox).EndInit();
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
        private System.Windows.Forms.ColumnHeader StartTime;

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
        private ColumnHeader EndTime;
        private Label lblEndTime;
        private Label lblDate;
        private Label lblName;
        private Label lblActivityID;
        private Button btnRefresh;
        private Button btnChange;
        private Button btnRemo;
        private Button btnAd;
        private TextBox txtDate;
        private TextBox txtName;
        private TextBox txtActivityID;
        private TextBox txtEndTime;
    }
}