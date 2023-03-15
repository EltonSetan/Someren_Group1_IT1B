using SomerenService;
using SomerenModel;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            ShowDashboardPanel();
        }

        private void ShowDashboardPanel()
        {
            // hide all other panels
            pnlStudents.Hide();
            teacherpanel.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();

            // show students
            pnlStudents.Show();

            try
            {
                // get and display all students
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void ShowTeachersPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();

            // show students
            teacherpanel.Show();

            try
            {
                // get and display all students
                List<Teacher> teachers = GetTeachers();
                DisplayTeachers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the teachers: " + e.Message);
            }
        }
        private List<Student> GetStudents()
        {
            StudentService studentService = new StudentService();
            List<Student> students = studentService.GetStudents();
            return students;
        }

        private List<Teacher> GetTeachers()
        {
            LecturersService teacherService = new LecturersService();
            List<Teacher> teachers = teacherService.GetTeachers();
            return teachers;
        }
        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Clear();

            foreach (Student student in students)
            {
                ListViewItem li = new ListViewItem(student.Name);
                li.Tag = student;   // link student object to listview item
                listViewStudents.Items.Add(li);
            }
        }
        private void DisplayTeachers(List<Teacher> teachers)
        {
            // clear the listview before filling it
            listViewteachers.Clear();

            listViewteachers.View = View.Details;
            listViewteachers.Columns.Add("Lecturer ID");
            listViewteachers.Columns.Add("First Name");
            listViewteachers.Columns.Add("Last Name");
            listViewteachers.Columns.Add("Age");
            listViewteachers.Columns.Add("Phone Number");
            listViewteachers.Columns.Add("RoomId");
            listViewteachers.Columns.Add("DrinkId");
            listViewteachers.Columns.Add("IsSupervisor");

            foreach (Teacher teacher in teachers)
            {

                ListViewItem item = new ListViewItem(teacher.Number.ToString());
                item.SubItems.Add(teacher.Name);
                item.SubItems.Add(teacher.LastName);
                item.SubItems.Add(teacher.Age.ToString());
                item.SubItems.Add(teacher.TelephoneNumber.ToString());
                item.SubItems.Add(teacher.RoomId.ToString());
                item.SubItems.Add(teacher.DrinkId.ToString());
                item.SubItems.Add(teacher.IsSupervisor);
                item.Tag = teacher;
                listViewteachers.Items.Add(item);
            }
            listViewteachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void dashboardToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void teacherpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeachersPanel();
        }
    }
}