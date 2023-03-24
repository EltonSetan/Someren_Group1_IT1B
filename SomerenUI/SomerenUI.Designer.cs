using SomerenModel;
using SomerenUI.Properties;
using System.Resources;
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.dashboardPictureBox = new System.Windows.Forms.PictureBox();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.studentsPictureBox = new System.Windows.Forms.PictureBox();
            this.lecturersPictureBox = new System.Windows.Forms.PictureBox();
            this.activitiesPictureBox = new System.Windows.Forms.PictureBox();
            this.roomsPictureBox = new System.Windows.Forms.PictureBox();
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
            this.pnlRevenueReport = new System.Windows.Forms.Panel();
            this.lvRevenueReport = new System.Windows.Forms.ListView();
            this.lblRevenueDateRange = new System.Windows.Forms.Label();
            this.lblChooseEndDate = new System.Windows.Forms.Label();
            this.lblChooseStartDate = new System.Windows.Forms.Label();
            this.monthCalendarEndDate = new System.Windows.Forms.MonthCalendar();
            this.monthCalendarStartDate = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsPictureBox)).BeginInit();
            this.pnlStudents.SuspendLayout();
            this.roomsPanel.SuspendLayout();
            this.pnlActivity.SuspendLayout();
            this.teacherpanel.SuspendLayout();
            this.panelContainer.SuspendLayout();
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
            this.drinksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(861, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // lecturersToolStripMenuItem
            // 
            this.lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            this.lecturersToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.lecturersToolStripMenuItem.Text = "Lecturers";
            // 
            // activitiesToolStripMenuItem
            // 
            this.activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            this.activitiesToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.activitiesToolStripMenuItem.Text = "Activities";
            // 
            // roomsToolStripMenuItem
            // 
            this.roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            this.roomsToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
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
            this.drinksToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.drinksToolStripMenuItem.Text = "Drinks";
            // 
            // drinkStockToolStripMenuItem
            // 
            this.drinkStockToolStripMenuItem.Name = "drinkStockToolStripMenuItem";
            this.drinkStockToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.drinkStockToolStripMenuItem.Text = "Drink Stock";
            // 
            // cashRegisterToolStripMenuItem
            // 
            this.cashRegisterToolStripMenuItem.Name = "cashRegisterToolStripMenuItem";
            this.cashRegisterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cashRegisterToolStripMenuItem.Text = "Cash Register";
            // 
            // revenueReportToolStripMenuItem
            // 
            this.revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            this.revenueReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.revenueReportToolStripMenuItem.Text = "Revenue Report";
            this.revenueReportToolStripMenuItem.Click += new System.EventHandler(this.revenueReportToolStripMenuItem_Click);
            // 
            // vATCalculationToolStripMenuItem
            // 
            this.vATCalculationToolStripMenuItem.Name = "vATCalculationToolStripMenuItem";
            this.vATCalculationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.vATCalculationToolStripMenuItem.Text = "VAT calculation";
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
            this.dashboardPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.dashboardPictureBox.Location = new System.Drawing.Point(715, 0);
            this.dashboardPictureBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dashboardPictureBox.Name = "dashboardPictureBox";
            this.dashboardPictureBox.Size = new System.Drawing.Size(145, 136);
            this.dashboardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.dashboardPictureBox.TabIndex = 2;
            this.dashboardPictureBox.TabStop = false;
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
            // studentsPictureBox
            // 
            this.studentsPictureBox.Image = global::SomerenUI.Properties.Resources.someren;
            this.studentsPictureBox.Location = new System.Drawing.Point(715, 0);
            this.studentsPictureBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
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
            this.lecturersPictureBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
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
            this.activitiesPictureBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
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
            this.roomsPictureBox.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.roomsPictureBox.Name = "roomsPictureBox";
            this.roomsPictureBox.Size = new System.Drawing.Size(145, 136);
            this.roomsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.roomsPictureBox.TabIndex = 2;
            this.roomsPictureBox.TabStop = false;
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
            this.listViewStudents.Location = new System.Drawing.Point(15, 45);
            this.listViewStudents.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
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
            this.panelContainer.Controls.Add(this.pnlDashboard);
            this.panelContainer.Controls.Add(this.roomsPanel);
            this.panelContainer.Controls.Add(this.pnlActivity);
            this.panelContainer.Controls.Add(this.teacherpanel);
            this.panelContainer.Controls.Add(this.pnlStudents);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 32);
            this.panelContainer.Margin = new System.Windows.Forms.Padding(1);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(861, 548);
            this.panelContainer.TabIndex = 2;
            // 
            // pnlRevenueReport
            // 
            this.pnlRevenueReport.Controls.Add(this.lvRevenueReport);
            this.pnlRevenueReport.Controls.Add(this.lblRevenueDateRange);
            this.pnlRevenueReport.Controls.Add(this.lblChooseEndDate);
            this.pnlRevenueReport.Controls.Add(this.lblChooseStartDate);
            this.pnlRevenueReport.Controls.Add(this.monthCalendarEndDate);
            this.pnlRevenueReport.Controls.Add(this.monthCalendarStartDate);
            this.pnlRevenueReport.Location = new System.Drawing.Point(0, 32);
            this.pnlRevenueReport.Name = "pnlRevenueReport";
            this.pnlRevenueReport.Size = new System.Drawing.Size(861, 548);
            this.pnlRevenueReport.TabIndex = 3;
            // 
            // lvRevenueReport
            // 
            this.lvRevenueReport.Location = new System.Drawing.Point(32, 332);
            this.lvRevenueReport.Name = "lvRevenueReport";
            this.lvRevenueReport.Size = new System.Drawing.Size(623, 204);
            this.lvRevenueReport.TabIndex = 5;
            this.lvRevenueReport.UseCompatibleStateImageBehavior = false;
            // 
            // lblRevenueDateRange
            // 
            this.lblRevenueDateRange.AutoSize = true;
            this.lblRevenueDateRange.Location = new System.Drawing.Point(32, 289);
            this.lblRevenueDateRange.Name = "lblRevenueDateRange";
            this.lblRevenueDateRange.Size = new System.Drawing.Size(114, 20);
            this.lblRevenueDateRange.TabIndex = 4;
            this.lblRevenueDateRange.Text = "Revenue Report";
            // 
            // lblChooseEndDate
            // 
            this.lblChooseEndDate.AutoSize = true;
            this.lblChooseEndDate.Location = new System.Drawing.Point(393, 7);
            this.lblChooseEndDate.Name = "lblChooseEndDate";
            this.lblChooseEndDate.Size = new System.Drawing.Size(141, 20);
            this.lblChooseEndDate.TabIndex = 3;
            this.lblChooseEndDate.Text = "Choose an end date";
            // 
            // lblChooseStartDate
            // 
            this.lblChooseStartDate.AutoSize = true;
            this.lblChooseStartDate.Location = new System.Drawing.Point(32, 7);
            this.lblChooseStartDate.Name = "lblChooseStartDate";
            this.lblChooseStartDate.Size = new System.Drawing.Size(137, 20);
            this.lblChooseStartDate.TabIndex = 2;
            this.lblChooseStartDate.Text = "Choose a start date";
            // 
            // monthCalendarEndDate
            // 
            this.monthCalendarEndDate.Location = new System.Drawing.Point(393, 36);
            this.monthCalendarEndDate.Name = "monthCalendarEndDate";
            this.monthCalendarEndDate.ShowToday = false;
            this.monthCalendarEndDate.ShowTodayCircle = false;
            this.monthCalendarEndDate.TabIndex = 1;
            this.monthCalendarEndDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarEndDate_DateChanged);
            // 
            // monthCalendarStartDate
            // 
            this.monthCalendarStartDate.Location = new System.Drawing.Point(32, 36);
            this.monthCalendarStartDate.MaxDate = new System.DateTime(2024, 3, 22, 0, 0, 0, 0);
            this.monthCalendarStartDate.Name = "monthCalendarStartDate";
            this.monthCalendarStartDate.ShowToday = false;
            this.monthCalendarStartDate.ShowTodayCircle = false;
            this.monthCalendarStartDate.TabIndex = 0;
            this.monthCalendarStartDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarStartDate_DateChanged);
            // 
            // SomerenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 580);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.pnlRevenueReport);
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
            ((System.ComponentModel.ISupportInitialize)(this.studentsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsPictureBox)).EndInit();
            this.pnlStudents.ResumeLayout(false);
            this.pnlStudents.PerformLayout();
            this.roomsPanel.ResumeLayout(false);
            this.roomsPanel.PerformLayout();
            this.pnlActivity.ResumeLayout(false);
            this.pnlActivity.PerformLayout();
            this.teacherpanel.ResumeLayout(false);
            this.teacherpanel.PerformLayout();
            this.panelContainer.ResumeLayout(false);
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
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Panel teacherpanel;
        private System.Windows.Forms.ListView listViewteachers;

        private System.Windows.Forms.Panel pnlActivity;
        private System.Windows.Forms.ListView lvActivities;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Activity;
        private System.Windows.Forms.ColumnHeader Date;

        private System.Windows.Forms.Panel roomsPanel;
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
        private MonthCalendar monthCalendarEndDate;
        private ToolStripMenuItem drinksToolStripMenuItem;
        private ToolStripMenuItem drinkStockToolStripMenuItem;
        private ToolStripMenuItem cashRegisterToolStripMenuItem;
        private ToolStripMenuItem revenueReportToolStripMenuItem;
        private ToolStripMenuItem vATCalculationToolStripMenuItem;
    }
}