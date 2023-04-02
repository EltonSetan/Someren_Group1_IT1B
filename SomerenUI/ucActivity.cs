using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;

namespace SomerenUI
{
    public partial class ucActivity : UserControl
    {
        private Label lblActivityName;
        private Label lblSupervisors;
        private Label lblDateOfActivity;
        public ucActivity(string activityName, List<Teacher> supervisors, DateTime dateOfActivity)
        {
            InitializeComponent();
            Dock= DockStyle.Top;
            lblActivityName.Text = activityName;
            lblDateOfActivity.Text = dateOfActivity.ToString("t");

            if (supervisors.Count > 0)
            {
                foreach (Teacher teacher in supervisors)
                {
                    if ((supervisors.Count -1) == supervisors.IndexOf(teacher))
                    {
                        lblSupervisors.Text += $"{teacher.Name} {teacher.LastName} ";
                    }
                    else
                    {
                        lblSupervisors.Text += $"{teacher.Name} {teacher.LastName}, ";
                    }
                }  
            }
            else
            {
                lblSupervisors.Text = "Unsupervised";
            }
        }
    }
}

