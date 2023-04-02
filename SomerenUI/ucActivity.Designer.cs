using System.Windows.Forms;

namespace SomerenUI
{
    partial class ucActivity
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblActivityName = new System.Windows.Forms.Label();
            this.lblDateOfActivity = new System.Windows.Forms.Label();
            this.lblSupervisors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblActivityName
            // 
            this.lblActivityName.AutoSize = true;
            this.lblActivityName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivityName.Location = new System.Drawing.Point(11, 0);
            this.lblActivityName.MaximumSize = new System.Drawing.Size(160, 50);
            this.lblActivityName.Name = "lblActivityName";
            this.lblActivityName.Size = new System.Drawing.Size(0, 20);
            this.lblActivityName.TabIndex = 0;
            // 
            // lblDateOfActivity
            // 
            this.lblDateOfActivity.AutoSize = true;
            this.lblDateOfActivity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateOfActivity.Location = new System.Drawing.Point(11, 30);
            this.lblDateOfActivity.Name = "lblDateOfActivity";
            this.lblDateOfActivity.Size = new System.Drawing.Size(49, 20);
            this.lblDateOfActivity.TabIndex = 1;
            this.lblDateOfActivity.Text = "Time: ";
            // 
            // lblSupervisors
            // 
            this.lblSupervisors.AutoSize = true;
            this.lblSupervisors.MaximumSize = new System.Drawing.Size(100, 160);
            this.lblSupervisors.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSupervisors.Location = new System.Drawing.Point(11, 58);
            this.lblSupervisors.Name = "lblSupervisors";
            this.lblSupervisors.Size = new System.Drawing.Size(87, 20);
            this.lblSupervisors.TabIndex = 1;
            this.lblSupervisors.Text = "Supervisors: ";
            // 
            // ucActivity
            // 
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.lblActivityName);
            this.Controls.Add(this.lblDateOfActivity);
            this.Controls.Add(this.lblSupervisors);
            this.Name = "ucActivity";
            this.Size = new System.Drawing.Size(160, 160);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
