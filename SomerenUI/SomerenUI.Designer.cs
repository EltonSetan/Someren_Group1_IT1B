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
            this.dashboardPictureBox = new System.Windows.Forms.PictureBox();
            this.lblDashboard = new System.Windows.Forms.Label();
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
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.Activity = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.lvActivities = new System.Windows.Forms.ListView();
            this.pnlActivity = new System.Windows.Forms.Panel();
            this.lblActivity = new System.Windows.Forms.Label();
            this.teacherpanel = new System.Windows.Forms.Panel();
            this.listViewteachers = new System.Windows.Forms.ListView();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.participantspanel = new System.Windows.Forms.Panel();
            this.removeParticipantButton = new System.Windows.Forms.Button();
            this.addParticipantButton = new System.Windows.Forms.Button();
            this.nonParticipantsBtn = new System.Windows.Forms.Button();
            this.participantsBtn = new System.Windows.Forms.Button();
            this.listviewnonparticipants = new System.Windows.Forms.ListView();
            this.listviewparticipants = new System.Windows.Forms.ListView();
            this.listviewactivity1 = new System.Windows.Forms.ListView();
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
            this.participantspanel.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1076, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(202, 34);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(202, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.roomsToolStripMenuItem.Text = "Rooms";
            // 
            // drinksToolStripMenuItem
            // 
            this.drinksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drinkStockToolStripMenuItem,
            this.cashRegisterToolStripMenuItem,
            this.revenueReportToolStripMenuItem,
            this.vATCalculationToolStripMenuItem});
            this.drinksToolStripMenuItem.Name = "drinksToolStripMenuItem";
            this.drinksToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.drinksToolStripMenuItem.Text = "Drinks";
            // 
            // drinkStockToolStripMenuItem
            // 
            this.drinkStockToolStripMenuItem.Name = "drinkStockToolStripMenuItem";
            this.drinkStockToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.drinkStockToolStripMenuItem.Text = "Drink Stock";
            // 
            // cashRegisterToolStripMenuItem
            // 
            this.cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            this.cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.cashRegisterToolStripMenuItem.Text = "Cash Register";
            // 
            // revenueReportToolStripMenuItem
            // 
            this.revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            this.revenueReportToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.revenueReportToolStripMenuItem.Text = "Revenue Report";
            // 
            // vATCalculationToolStripMenuItem
            // 
            this.vATCalculationToolStripMenuItem.Name = "vATCalculationToolStripMenuItem";
            this.vATCalculationToolStripMenuItem.Size = new System.Drawing.Size(238, 34);
            this.vATCalculationToolStripMenuItem.Text = "VAT calculation";
            // 
            // supervisorsToolStripMenuItem
            // 
            this.supervisorsToolStripMenuItem.Name = "supervisorsToolStripMenuItem";
            this.supervisorsToolStripMenuItem.Size = new System.Drawing.Size(120, 29);
            this.supervisorsToolStripMenuItem.Text = "Supervisors";
            // 
            // participantsToolStripMenuItem
            // 
            this.participantsToolStripMenuItem.Name = "participantsToolStripMenuItem";
            this.participantsToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.participantsToolStripMenuItem.Text = "Participants";
            this.participantsToolStripMenuItem.Click += new System.EventHandler(this.participantsToolStripMenuItem_Click);
            // 
            // timetableToolStripMenuItem
            // 
            this.timetableToolStripMenuItem.Name = "timetableToolStripMenuItem";
            this.timetableToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.timetableToolStripMenuItem.Text = "Timetable";
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.dashboardPictureBox);
            this.pnlDashboard.Controls.Add(this.lblDashboard);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1076, 688);
            this.pnlDashboard.TabIndex = 1;
            // 
            // dashboardPictureBox
            // 
            this.dashboardPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.dashboardPictureBox.Location = new System.Drawing.Point(894, 0);
            this.dashboardPictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.dashboardPictureBox.Name = "dashboardPictureBox";
            this.dashboardPictureBox.Size = new System.Drawing.Size(181, 171);
            this.dashboardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dashboardPictureBox.TabIndex = 2;
            this.dashboardPictureBox.TabStop = false;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Location = new System.Drawing.Point(24, 35);
            this.lblDashboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(313, 25);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Welcome to the Someren Application!";
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
            this.cashpanel.Name = "cashpanel";
            this.cashpanel.Size = new System.Drawing.Size(1064, 679);
            this.cashpanel.TabIndex = 3;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(629, 588);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(119, 37);
            this.btnCheckout.TabIndex = 2;
            this.btnCheckout.Text = "Buy";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // listViewStudetnsCashRegister
            // 
            this.listViewStudetnsCashRegister.FullRowSelect = true;
            this.listViewStudetnsCashRegister.GridLines = true;
            this.listViewStudetnsCashRegister.Location = new System.Drawing.Point(36, 56);
            this.listViewStudetnsCashRegister.Name = "listViewStudetnsCashRegister";
            this.listViewStudetnsCashRegister.Size = new System.Drawing.Size(710, 219);
            this.listViewStudetnsCashRegister.TabIndex = 0;
            this.listViewStudetnsCashRegister.UseCompatibleStateImageBehavior = false;
            // 
            // listViewDrinksCashRegister
            // 
            this.listViewDrinksCashRegister.FullRowSelect = true;
            this.listViewDrinksCashRegister.GridLines = true;
            this.listViewDrinksCashRegister.Location = new System.Drawing.Point(36, 294);
            this.listViewDrinksCashRegister.Name = "listViewDrinksCashRegister";
            this.listViewDrinksCashRegister.Size = new System.Drawing.Size(710, 219);
            this.listViewDrinksCashRegister.TabIndex = 4;
            this.listViewDrinksCashRegister.UseCompatibleStateImageBehavior = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(51, 588);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(96, 25);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total price:";
            // 
            // lblCashRegister
            // 
            this.lblCashRegister.AutoSize = true;
            this.lblCashRegister.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCashRegister.Location = new System.Drawing.Point(14, 6);
            this.lblCashRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCashRegister.Name = "lblCashRegister";
            this.lblCashRegister.Size = new System.Drawing.Size(234, 48);
            this.lblCashRegister.TabIndex = 3;
            this.lblCashRegister.Text = "Cash Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox1.Location = new System.Drawing.Point(894, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // listViewdrinks
            // 
            this.listViewdrinks.FullRowSelect = true;
            this.listViewdrinks.GridLines = true;
            this.listViewdrinks.Location = new System.Drawing.Point(36, 60);
            this.listViewdrinks.Name = "listViewdrinks";
            this.listViewdrinks.Size = new System.Drawing.Size(710, 147);
            this.listViewdrinks.TabIndex = 1;
            this.listViewdrinks.UseCompatibleStateImageBehavior = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(946, 309);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(119, 37);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove drink";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(946, 253);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 37);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add drink";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(594, 253);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.PlaceholderText = "50";
            this.txtStock.Size = new System.Drawing.Size(155, 31);
            this.txtStock.TabIndex = 4;
            // 
            // txtPriceOfDrink
            // 
            this.txtPriceOfDrink.Location = new System.Drawing.Point(779, 253);
            this.txtPriceOfDrink.Margin = new System.Windows.Forms.Padding(4);
            this.txtPriceOfDrink.Name = "txtPriceOfDrink";
            this.txtPriceOfDrink.PlaceholderText = "2.50";
            this.txtPriceOfDrink.Size = new System.Drawing.Size(155, 31);
            this.txtPriceOfDrink.TabIndex = 5;
            // 
            // txtIsAlcoholic
            // 
            this.txtIsAlcoholic.Location = new System.Drawing.Point(407, 253);
            this.txtIsAlcoholic.Margin = new System.Windows.Forms.Padding(4);
            this.txtIsAlcoholic.Name = "txtIsAlcoholic";
            this.txtIsAlcoholic.PlaceholderText = "yes/no";
            this.txtIsAlcoholic.Size = new System.Drawing.Size(155, 31);
            this.txtIsAlcoholic.TabIndex = 6;
            // 
            // txtDrinkName
            // 
            this.txtDrinkName.Location = new System.Drawing.Point(219, 253);
            this.txtDrinkName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDrinkName.Name = "txtDrinkName";
            this.txtDrinkName.PlaceholderText = "Beer";
            this.txtDrinkName.Size = new System.Drawing.Size(155, 31);
            this.txtDrinkName.TabIndex = 3;
            // 
            // txtDrinkId
            // 
            this.txtDrinkId.Location = new System.Drawing.Point(26, 253);
            this.txtDrinkId.Margin = new System.Windows.Forms.Padding(4);
            this.txtDrinkId.Name = "txtDrinkId";
            this.txtDrinkId.PlaceholderText = "15";
            this.txtDrinkId.Size = new System.Drawing.Size(155, 31);
            this.txtDrinkId.TabIndex = 7;
            // 
            // studentsPictureBox
            // 
            this.studentsPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.studentsPictureBox.Location = new System.Drawing.Point(894, 0);
            this.studentsPictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.studentsPictureBox.Name = "studentsPictureBox";
            this.studentsPictureBox.Size = new System.Drawing.Size(181, 171);
            this.studentsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.studentsPictureBox.TabIndex = 2;
            this.studentsPictureBox.TabStop = false;
            // 
            // lecturersPictureBox
            // 
            this.lecturersPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.lecturersPictureBox.Location = new System.Drawing.Point(894, 0);
            this.lecturersPictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.lecturersPictureBox.Name = "lecturersPictureBox";
            this.lecturersPictureBox.Size = new System.Drawing.Size(181, 171);
            this.lecturersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.lecturersPictureBox.TabIndex = 2;
            this.lecturersPictureBox.TabStop = false;
            // 
            // activitiesPictureBox
            // 
            this.activitiesPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.activitiesPictureBox.Location = new System.Drawing.Point(894, 0);
            this.activitiesPictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.activitiesPictureBox.Name = "activitiesPictureBox";
            this.activitiesPictureBox.Size = new System.Drawing.Size(181, 171);
            this.activitiesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.activitiesPictureBox.TabIndex = 2;
            this.activitiesPictureBox.TabStop = false;
            // 
            // roomsPictureBox
            // 
            this.roomsPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.roomsPictureBox.Location = new System.Drawing.Point(894, 0);
            this.roomsPictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.roomsPictureBox.Name = "roomsPictureBox";
            this.roomsPictureBox.Size = new System.Drawing.Size(181, 171);
            this.roomsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.roomsPictureBox.TabIndex = 2;
            this.roomsPictureBox.TabStop = false;
            // 
            // revenuePictureBox
            // 
            this.revenuePictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.revenuePictureBox.Location = new System.Drawing.Point(894, 0);
            this.revenuePictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.revenuePictureBox.Name = "revenuePictureBox";
            this.revenuePictureBox.Size = new System.Drawing.Size(181, 171);
            this.revenuePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.revenuePictureBox.TabIndex = 2;
            this.revenuePictureBox.TabStop = false;
            // 
            // stockPictureBox
            // 
            this.stockPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.stockPictureBox.Location = new System.Drawing.Point(894, 0);
            this.stockPictureBox.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.stockPictureBox.Name = "stockPictureBox";
            this.stockPictureBox.Size = new System.Drawing.Size(181, 171);
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
            this.pnlStudents.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnlStudents.Name = "pnlStudents";
            this.pnlStudents.Size = new System.Drawing.Size(1076, 688);
            this.pnlStudents.TabIndex = 2;
            // 
            // listViewStudents
            // 
            this.listViewStudents.Location = new System.Drawing.Point(19, 56);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
            this.listViewStudents.Name = "listViewStudents";
            this.listViewStudents.Size = new System.Drawing.Size(855, 410);
            this.listViewStudents.TabIndex = 1;
            this.listViewStudents.UseCompatibleStateImageBehavior = false;
            this.listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // studentsLabel
            // 
            this.studentsLabel.AutoSize = true;
            this.studentsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.studentsLabel.Location = new System.Drawing.Point(14, 6);
            this.studentsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studentsLabel.Name = "studentsLabel";
            this.studentsLabel.Size = new System.Drawing.Size(157, 48);
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
            this.roomsPanel.Size = new System.Drawing.Size(1076, 688);
            this.roomsPanel.TabIndex = 3;
            // 
            // listViewRooms
            // 
            this.listViewRooms.Location = new System.Drawing.Point(19, 56);
            this.listViewRooms.Margin = new System.Windows.Forms.Padding(1);
            this.listViewRooms.Name = "listViewRooms";
            this.listViewRooms.Size = new System.Drawing.Size(855, 410);
            this.listViewRooms.TabIndex = 1;
            this.listViewRooms.UseCompatibleStateImageBehavior = false;
            this.listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // roomsLabel
            // 
            this.roomsLabel.AutoSize = true;
            this.roomsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roomsLabel.Location = new System.Drawing.Point(14, 6);
            this.roomsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roomsLabel.Name = "roomsLabel";
            this.roomsLabel.Size = new System.Drawing.Size(129, 48);
            this.roomsLabel.TabIndex = 0;
            this.roomsLabel.Text = "Rooms";
            // 
            // lecturersLabel
            // 
            this.lecturersLabel.AutoSize = true;
            this.lecturersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lecturersLabel.Location = new System.Drawing.Point(14, 6);
            this.lecturersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lecturersLabel.Name = "lecturersLabel";
            this.lecturersLabel.Size = new System.Drawing.Size(165, 48);
            this.lecturersLabel.TabIndex = 0;
            this.lecturersLabel.Text = "Lecturers";
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
            this.lvActivities.Location = new System.Drawing.Point(21, 66);
            this.lvActivities.Margin = new System.Windows.Forms.Padding(1);
            this.lvActivities.Name = "lvActivities";
            this.lvActivities.Size = new System.Drawing.Size(977, 482);
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
            this.pnlActivity.Size = new System.Drawing.Size(1076, 688);
            this.pnlActivity.TabIndex = 4;
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActivity.Location = new System.Drawing.Point(16, 7);
            this.lblActivity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(162, 48);
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
            this.teacherpanel.Size = new System.Drawing.Size(1076, 688);
            this.teacherpanel.TabIndex = 3;
            // 
            // listViewteachers
            // 
            this.listViewteachers.Location = new System.Drawing.Point(21, 66);
            this.listViewteachers.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.listViewteachers.Name = "listViewteachers";
            this.listViewteachers.Size = new System.Drawing.Size(977, 482);
            this.listViewteachers.TabIndex = 9999999;
            this.listViewteachers.UseCompatibleStateImageBehavior = false;
            this.listViewteachers.View = System.Windows.Forms.View.Details;
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.participantspanel);
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
            this.panelContainer.Location = new System.Drawing.Point(0, 37);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(1);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1076, 688);
            this.panelContainer.TabIndex = 2;
            // 
            // participantspanel
            // 
            this.participantspanel.Controls.Add(this.removeParticipantButton);
            this.participantspanel.Controls.Add(this.addParticipantButton);
            this.participantspanel.Controls.Add(this.nonParticipantsBtn);
            this.participantspanel.Controls.Add(this.participantsBtn);
            this.participantspanel.Controls.Add(this.listviewnonparticipants);
            this.participantspanel.Controls.Add(this.listviewparticipants);
            this.participantspanel.Controls.Add(this.listviewactivity1);
            this.participantspanel.Location = new System.Drawing.Point(0, 0);
            this.participantspanel.Name = "participantspanel";
            this.participantspanel.Size = new System.Drawing.Size(1073, 685);
            this.participantspanel.TabIndex = 3;
            // 
            // removeParticipantButton
            // 
            this.removeParticipantButton.Location = new System.Drawing.Point(52, 560);
            this.removeParticipantButton.Name = "removeParticipantButton";
            this.removeParticipantButton.Size = new System.Drawing.Size(281, 34);
            this.removeParticipantButton.TabIndex = 6;
            this.removeParticipantButton.Text = "Click here to remove Participant!";
            this.removeParticipantButton.UseVisualStyleBackColor = true;
            // 
            // addParticipantButton
            // 
            this.addParticipantButton.Location = new System.Drawing.Point(52, 514);
            this.addParticipantButton.Name = "addParticipantButton";
            this.addParticipantButton.Size = new System.Drawing.Size(281, 34);
            this.addParticipantButton.TabIndex = 5;
            this.addParticipantButton.Text = "Click here to add Participant!";
            this.addParticipantButton.UseVisualStyleBackColor = true;
            this.addParticipantButton.Click += new System.EventHandler(this.addParticipantButton_Click);
            // 
            // nonParticipantsBtn
            // 
            this.nonParticipantsBtn.Location = new System.Drawing.Point(483, 241);
            this.nonParticipantsBtn.Name = "nonParticipantsBtn";
            this.nonParticipantsBtn.Size = new System.Drawing.Size(190, 34);
            this.nonParticipantsBtn.TabIndex = 4;
            this.nonParticipantsBtn.Text = "Non-Participants";
            this.nonParticipantsBtn.UseVisualStyleBackColor = true;
            this.nonParticipantsBtn.Click += new System.EventHandler(this.nonParticipantsBtn_Click);
            // 
            // participantsBtn
            // 
            this.participantsBtn.Location = new System.Drawing.Point(51, 241);
            this.participantsBtn.Name = "participantsBtn";
            this.participantsBtn.Size = new System.Drawing.Size(112, 34);
            this.participantsBtn.TabIndex = 3;
            this.participantsBtn.Text = "Participants";
            this.participantsBtn.UseVisualStyleBackColor = true;
            this.participantsBtn.Click += new System.EventHandler(this.participantsBtn_Click);
            // 
            // listviewnonparticipants
            // 
            this.listviewnonparticipants.FullRowSelect = true;
            this.listviewnonparticipants.GridLines = true;
            this.listviewnonparticipants.Location = new System.Drawing.Point(483, 281);
            this.listviewnonparticipants.Name = "listviewnonparticipants";
            this.listviewnonparticipants.Size = new System.Drawing.Size(362, 213);
            this.listviewnonparticipants.TabIndex = 2;
            this.listviewnonparticipants.UseCompatibleStateImageBehavior = false;
            // 
            // listviewparticipants
            // 
            this.listviewparticipants.FullRowSelect = true;
            this.listviewparticipants.GridLines = true;
            this.listviewparticipants.Location = new System.Drawing.Point(51, 281);
            this.listviewparticipants.Name = "listviewparticipants";
            this.listviewparticipants.Size = new System.Drawing.Size(397, 213);
            this.listviewparticipants.TabIndex = 1;
            this.listviewparticipants.UseCompatibleStateImageBehavior = false;
            // 
            // listviewactivity1
            // 
            this.listviewactivity1.FullRowSelect = true;
            this.listviewactivity1.GridLines = true;
            this.listviewactivity1.Location = new System.Drawing.Point(51, 56);
            this.listviewactivity1.Name = "listviewactivity1";
            this.listviewactivity1.Size = new System.Drawing.Size(797, 170);
            this.listviewactivity1.TabIndex = 0;
            this.listviewactivity1.UseCompatibleStateImageBehavior = false;
            this.listviewactivity1.View = System.Windows.Forms.View.Details;
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
            this.panelDrinks.Margin = new System.Windows.Forms.Padding(4);
            this.panelDrinks.Name = "panelDrinks";
            this.panelDrinks.Size = new System.Drawing.Size(1076, 725);
            this.panelDrinks.TabIndex = 3;
            // 
            // drinksStockLabel
            // 
            this.drinksStockLabel.AutoSize = true;
            this.drinksStockLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.drinksStockLabel.Location = new System.Drawing.Point(14, 7);
            this.drinksStockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drinksStockLabel.Name = "drinksStockLabel";
            this.drinksStockLabel.Size = new System.Drawing.Size(120, 48);
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
            this.vatPanel.Margin = new System.Windows.Forms.Padding(4);
            this.vatPanel.Name = "vatPanel";
            this.vatPanel.Size = new System.Drawing.Size(1076, 688);
            this.vatPanel.TabIndex = 3;
            // 
            // btnCalculateVAT
            // 
            this.btnCalculateVAT.Location = new System.Drawing.Point(486, 553);
            this.btnCalculateVAT.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateVAT.Name = "btnCalculateVAT";
            this.btnCalculateVAT.Size = new System.Drawing.Size(119, 37);
            this.btnCalculateVAT.TabIndex = 11;
            this.btnCalculateVAT.Text = "Calculate VAT";
            this.btnCalculateVAT.UseVisualStyleBackColor = true;
            // 
            // lblTotalVAT
            // 
            this.lblTotalVAT.AutoSize = true;
            this.lblTotalVAT.Location = new System.Drawing.Point(47, 565);
            this.lblTotalVAT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalVAT.Name = "lblTotalVAT";
            this.lblTotalVAT.Size = new System.Drawing.Size(372, 25);
            this.lblTotalVAT.TabIndex = 10;
            this.lblTotalVAT.Text = "Total VAT amount payable: ____________________ ";
            // 
            // lblHighTariffTotal
            // 
            this.lblHighTariffTotal.AutoSize = true;
            this.lblHighTariffTotal.Location = new System.Drawing.Point(40, 335);
            this.lblHighTariffTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHighTariffTotal.Name = "lblHighTariffTotal";
            this.lblHighTariffTotal.Size = new System.Drawing.Size(503, 25);
            this.lblHighTariffTotal.TabIndex = 9;
            this.lblHighTariffTotal.Text = "Total VAT (high tariff, 21%) amount payable: ____________________";
            // 
            // lblLowTariffTotal
            // 
            this.lblLowTariffTotal.AutoSize = true;
            this.lblLowTariffTotal.Location = new System.Drawing.Point(40, 268);
            this.lblLowTariffTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLowTariffTotal.Name = "lblLowTariffTotal";
            this.lblLowTariffTotal.Size = new System.Drawing.Size(486, 25);
            this.lblLowTariffTotal.TabIndex = 8;
            this.lblLowTariffTotal.Text = "Total VAT (low tariff, 6%) amount payable: ____________________";
            // 
            // lblQuarterDates
            // 
            this.lblQuarterDates.AutoSize = true;
            this.lblQuarterDates.Location = new System.Drawing.Point(40, 201);
            this.lblQuarterDates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuarterDates.Name = "lblQuarterDates";
            this.lblQuarterDates.Size = new System.Drawing.Size(379, 25);
            this.lblQuarterDates.TabIndex = 7;
            this.lblQuarterDates.Text = "Quarter runs from: _____________ to:______________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select quarter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select year:";
            // 
            // cmbQuarter
            // 
            this.cmbQuarter.FormattingEnabled = true;
            this.cmbQuarter.Location = new System.Drawing.Point(219, 131);
            this.cmbQuarter.Margin = new System.Windows.Forms.Padding(4);
            this.cmbQuarter.Name = "cmbQuarter";
            this.cmbQuarter.Size = new System.Drawing.Size(190, 33);
            this.cmbQuarter.TabIndex = 4;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(219, 68);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(4);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(190, 33);
            this.cmbYear.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.pictureBox.Location = new System.Drawing.Point(894, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(181, 171);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // lblVATReportHeader
            // 
            this.lblVATReportHeader.AutoSize = true;
            this.lblVATReportHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVATReportHeader.Location = new System.Drawing.Point(14, 7);
            this.lblVATReportHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVATReportHeader.Name = "lblVATReportHeader";
            this.lblVATReportHeader.Size = new System.Drawing.Size(196, 48);
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
            this.pnlRevenueReport.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRevenueReport.Name = "pnlRevenueReport";
            this.pnlRevenueReport.Size = new System.Drawing.Size(1064, 679);
            this.pnlRevenueReport.TabIndex = 3;
            // 
            // lblRevenueReportHeader
            // 
            this.lblRevenueReportHeader.AutoSize = true;
            this.lblRevenueReportHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRevenueReportHeader.Location = new System.Drawing.Point(14, 7);
            this.lblRevenueReportHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRevenueReportHeader.Name = "lblRevenueReportHeader";
            this.lblRevenueReportHeader.Size = new System.Drawing.Size(272, 48);
            this.lblRevenueReportHeader.TabIndex = 6;
            this.lblRevenueReportHeader.Text = "Revenue Report";
            // 
            // lvRevenueReport
            // 
            this.lvRevenueReport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvRevenueReport.Location = new System.Drawing.Point(21, 441);
            this.lvRevenueReport.Margin = new System.Windows.Forms.Padding(1);
            this.lvRevenueReport.MultiSelect = false;
            this.lvRevenueReport.Name = "lvRevenueReport";
            this.lvRevenueReport.Size = new System.Drawing.Size(827, 219);
            this.lvRevenueReport.TabIndex = 5;
            this.lvRevenueReport.UseCompatibleStateImageBehavior = false;
            // 
            // lblRevenueDateRange
            // 
            this.lblRevenueDateRange.AutoSize = true;
            this.lblRevenueDateRange.Location = new System.Drawing.Point(21, 412);
            this.lblRevenueDateRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRevenueDateRange.Name = "lblRevenueDateRange";
            this.lblRevenueDateRange.Size = new System.Drawing.Size(136, 25);
            this.lblRevenueDateRange.TabIndex = 4;
            this.lblRevenueDateRange.Text = "Revenue Report";
            // 
            // lblChooseEndDate
            // 
            this.lblChooseEndDate.AutoSize = true;
            this.lblChooseEndDate.Location = new System.Drawing.Point(533, 68);
            this.lblChooseEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseEndDate.Name = "lblChooseEndDate";
            this.lblChooseEndDate.Size = new System.Drawing.Size(171, 25);
            this.lblChooseEndDate.TabIndex = 3;
            this.lblChooseEndDate.Text = "Choose an end date";
            // 
            // lblChooseStartDate
            // 
            this.lblChooseStartDate.AutoSize = true;
            this.lblChooseStartDate.Location = new System.Drawing.Point(21, 68);
            this.lblChooseStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseStartDate.Name = "lblChooseStartDate";
            this.lblChooseStartDate.Size = new System.Drawing.Size(166, 25);
            this.lblChooseStartDate.TabIndex = 2;
            this.lblChooseStartDate.Text = "Choose a start date";
            // 
            // monthCalendarEndDate
            // 
            this.monthCalendarEndDate.Location = new System.Drawing.Point(533, 110);
            this.monthCalendarEndDate.Margin = new System.Windows.Forms.Padding(13);
            this.monthCalendarEndDate.Name = "monthCalendarEndDate";
            this.monthCalendarEndDate.ShowToday = false;
            this.monthCalendarEndDate.ShowTodayCircle = false;
            this.monthCalendarEndDate.TabIndex = 1;
            // 
            // monthCalendarStartDate
            // 
            this.monthCalendarStartDate.Location = new System.Drawing.Point(21, 110);
            this.monthCalendarStartDate.Margin = new System.Windows.Forms.Padding(13);
            this.monthCalendarStartDate.MaxDate = new System.DateTime(2024, 3, 22, 0, 0, 0, 0);
            this.monthCalendarStartDate.Name = "monthCalendarStartDate";
            this.monthCalendarStartDate.ShowToday = false;
            this.monthCalendarStartDate.ShowTodayCircle = false;
            this.monthCalendarStartDate.TabIndex = 0;
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 725);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "SomerenUI";
            this.Text = "SomerenApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardPictureBox)).EndInit();
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
            this.participantspanel.ResumeLayout(false);
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
        private ToolStripMenuItem supervisorsToolStripMenuItem;
        private ToolStripMenuItem participantsToolStripMenuItem;
        private ToolStripMenuItem timetableToolStripMenuItem;
        private Panel participantspanel;
        private ListView listviewnonparticipants;
        private ListView listviewparticipants;
        private ListView listviewactivity1;
        private Button nonParticipantsBtn;
        private Button participantsBtn;
        private Button removeParticipantButton;
        private Button addParticipantButton;
    }
}