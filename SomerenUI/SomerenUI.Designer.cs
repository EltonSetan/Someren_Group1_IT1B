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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SomerenUI));
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lecturersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            activitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            roomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pnlDashboard = new System.Windows.Forms.Panel();
            lblDashboard = new System.Windows.Forms.Label();
            pnlStudents = new System.Windows.Forms.Panel();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            listViewStudents = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            roomsPanel = new System.Windows.Forms.Panel();
            listViewRooms = new System.Windows.Forms.ListView();
            roomsLabel = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            Id = new System.Windows.Forms.ColumnHeader();
            Activity = new System.Windows.Forms.ColumnHeader();
            Date = new System.Windows.Forms.ColumnHeader();
            lvActivities = new System.Windows.Forms.ListView();
            pnlActivity = new System.Windows.Forms.Panel();
            teacherpanel = new System.Windows.Forms.Panel();
            listViewteachers = new System.Windows.Forms.ListView();
            panelContainer = new System.Windows.Forms.Panel();
            menuStrip1.SuspendLayout();
            pnlDashboard.SuspendLayout();
            pnlStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            roomsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlActivity.SuspendLayout();
            teacherpanel.SuspendLayout();
            panelContainer.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem, studentsToolStripMenuItem, lecturersToolStripMenuItem, activitiesToolStripMenuItem, roomsToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(1374, 25);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { dashboardToolStripMenuItem1, exitToolStripMenuItem });
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new System.Drawing.Size(80, 19);
            dashboardToolStripMenuItem.Text = "Application";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 19);
            studentsToolStripMenuItem.Text = "Students";
            studentsToolStripMenuItem.Click += studentsToolStripMenuItem_Click;
            // 
            // lecturersToolStripMenuItem
            // 
            lecturersToolStripMenuItem.Name = "lecturersToolStripMenuItem";
            lecturersToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            lecturersToolStripMenuItem.Text = "Lecturers";
            lecturersToolStripMenuItem.Click += lecturersToolStripMenuItem_Click;
            // 
            // activitiesToolStripMenuItem
            // 
            activitiesToolStripMenuItem.Name = "activitiesToolStripMenuItem";
            activitiesToolStripMenuItem.Size = new System.Drawing.Size(67, 19);
            activitiesToolStripMenuItem.Text = "Activities";
            activitiesToolStripMenuItem.Click += activitiesToolStripMenuItem_Click;
            // 
            // roomsToolStripMenuItem
            // 
            roomsToolStripMenuItem.Name = "roomsToolStripMenuItem";
            roomsToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            roomsToolStripMenuItem.Text = "Rooms";
            roomsToolStripMenuItem.Click += roomsToolStripMenuItem_Click;
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(lblDashboard);
            pnlDashboard.Location = new System.Drawing.Point(14, 36);
            pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new System.Drawing.Size(1072, 621);
            pnlDashboard.TabIndex = 1;
            // 
            // lblDashboard
            // 
            lblDashboard.AutoSize = true;
            lblDashboard.Location = new System.Drawing.Point(15, 17);
            lblDashboard.Name = "lblDashboard";
            lblDashboard.Size = new System.Drawing.Size(208, 15);
            lblDashboard.TabIndex = 0;
            lblDashboard.Text = "Welcome to the Someren Application!";
            // 
            // pnlStudents
            // 
            pnlStudents.Controls.Add(pictureBox1);
            pnlStudents.Controls.Add(listViewStudents);
            pnlStudents.Controls.Add(label1);
            pnlStudents.Location = new System.Drawing.Point(26, 20);
            pnlStudents.Margin = new System.Windows.Forms.Padding(2);
            pnlStudents.Name = "pnlStudents";
            pnlStudents.Size = new System.Drawing.Size(750, 373);
            pnlStudents.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(644, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(104, 98);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // listViewStudents
            // 
            listViewStudents.Location = new System.Drawing.Point(13, 34);
            listViewStudents.Margin = new System.Windows.Forms.Padding(2);
            listViewStudents.Name = "listViewStudents";
            listViewStudents.Size = new System.Drawing.Size(614, 246);
            listViewStudents.TabIndex = 1;
            listViewStudents.UseCompatibleStateImageBehavior = false;
            listViewStudents.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(10, 5);
            label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(107, 32);
            label1.TabIndex = 0;
            label1.Text = "Students";
            // 
            // roomsPanel
            // 
            roomsPanel.Controls.Add(listViewRooms);
            roomsPanel.Controls.Add(roomsLabel);
            roomsPanel.Location = new System.Drawing.Point(10, 20);
            roomsPanel.Margin = new System.Windows.Forms.Padding(1);
            roomsPanel.Name = "roomsPanel";
            roomsPanel.Size = new System.Drawing.Size(750, 373);
            roomsPanel.TabIndex = 3;
            // 
            // listViewRooms
            // 
            listViewRooms.Location = new System.Drawing.Point(13, 34);
            listViewRooms.Margin = new System.Windows.Forms.Padding(2);
            listViewRooms.Name = "listViewRooms";
            listViewRooms.Size = new System.Drawing.Size(614, 246);
            listViewRooms.TabIndex = 1;
            listViewRooms.UseCompatibleStateImageBehavior = false;
            listViewRooms.View = System.Windows.Forms.View.Details;
            // 
            // roomsLabel
            // 
            roomsLabel.AutoSize = true;
            roomsLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            roomsLabel.Location = new System.Drawing.Point(10, 5);
            roomsLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            roomsLabel.Name = "roomsLabel";
            roomsLabel.Size = new System.Drawing.Size(86, 32);
            roomsLabel.TabIndex = 0;
            roomsLabel.Text = "Rooms";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(644, 0);
            pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(104, 98);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
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
            // Date
            // 
            Date.Text = "Date";
            Date.Width = 100;
            // 
            // lvActivities
            // 
            lvActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { Id, Activity, Date });
            lvActivities.FullRowSelect = true;
            lvActivities.GridLines = true;
            lvActivities.Location = new System.Drawing.Point(9, 20);
            lvActivities.Margin = new System.Windows.Forms.Padding(1);
            lvActivities.Name = "lvActivities";
            lvActivities.Size = new System.Drawing.Size(431, 149);
            lvActivities.TabIndex = 1;
            lvActivities.UseCompatibleStateImageBehavior = false;
            lvActivities.View = System.Windows.Forms.View.Details;
            // 
            // pnlActivity
            // 
            pnlActivity.Controls.Add(lvActivities);
            pnlActivity.Location = new System.Drawing.Point(192, 53);
            pnlActivity.Margin = new System.Windows.Forms.Padding(1);
            pnlActivity.Name = "pnlActivity";
            pnlActivity.Size = new System.Drawing.Size(750, 373);
            pnlActivity.TabIndex = 4;
            // 
            // teacherpanel
            // 
            teacherpanel.Controls.Add(pictureBox2);
            teacherpanel.Controls.Add(listViewteachers);
            teacherpanel.Location = new System.Drawing.Point(20, 12);
            teacherpanel.Margin = new System.Windows.Forms.Padding(1);
            teacherpanel.Name = "teacherpanel";
            teacherpanel.Size = new System.Drawing.Size(942, 466);
            teacherpanel.TabIndex = 3;
            // 
            // listViewteachers
            // 
            listViewteachers.Location = new System.Drawing.Point(0, 42);
            listViewteachers.Margin = new System.Windows.Forms.Padding(2);
            listViewteachers.Name = "listViewteachers";
            listViewteachers.Size = new System.Drawing.Size(760, 307);
            listViewteachers.TabIndex = 0;
            listViewteachers.UseCompatibleStateImageBehavior = false;
            listViewteachers.View = System.Windows.Forms.View.Details;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(pnlActivity);
            panelContainer.Controls.Add(teacherpanel);
            panelContainer.Controls.Add(pnlStudents);
            panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            panelContainer.Location = new System.Drawing.Point(0, 25);
            panelContainer.Margin = new System.Windows.Forms.Padding(1);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new System.Drawing.Size(1374, 817);
            panelContainer.TabIndex = 2;

            // Custom Changes
            pnlDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pnlStudents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            teacherpanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            pnlActivity.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            roomsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            pnlDashboard.Dock = DockStyle.Fill;
            pnlStudents.Dock = DockStyle.Fill;
            teacherpanel.Dock = DockStyle.Fill;
            pnlActivity.Dock = DockStyle.Fill;
            roomsPanel.Dock = DockStyle.Fill;

            //End of custom changes
            // 
            // SomerenUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1374, 842);
            Controls.Add(panelContainer);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDashboard);
            Controls.Add(roomsPanel);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "SomerenUI";
            Text = "SomerenApp";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDashboard.ResumeLayout(false);
            pnlDashboard.PerformLayout();
            pnlStudents.ResumeLayout(false);
            pnlStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            roomsPanel.ResumeLayout(false);
            roomsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlActivity.ResumeLayout(false);
            teacherpanel.ResumeLayout(false);
            panelContainer.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listViewStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel teacherpanel;
        private System.Windows.Forms.ListView listViewteachers;
        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Panel pnlActivity;
        private System.Windows.Forms.ListView lvActivities;
        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Activity;
        private System.Windows.Forms.ColumnHeader Date;

        private System.Windows.Forms.Panel roomsPanel;
        private System.Windows.Forms.ListView listViewRooms;
        private System.Windows.Forms.Label roomsLabel;
        private System.Windows.Forms.Panel panelContainer;
    }
}