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
            pnlActivity.Hide();
            roomsPanel.Hide();

            // show dashboard
            pnlDashboard.Show();
        }

        private void ShowStudentsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlActivity.Hide();
            roomsPanel.Hide();

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

        private void ShowRoomsPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlActivity.Hide();
            pnlStudents.Hide();

            // show rooms
            roomsPanel.Show();

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
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
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
        
        private List<Room> GetRooms()
        {
            RoomService roomService = new RoomService();
            List<Room> rooms = roomService.GetRooms();
            return rooms;
        }
        
        private void DisplayStudents(List<Student> students)
        {
            // clear the listview before filling it
            listViewStudents.Clear();
            listViewStudents.View = View.Details;
            listViewStudents.Columns.Add("Student ID");
            listViewStudents.Columns.Add("First Name");
            listViewStudents.Columns.Add("Last Name");
            listViewStudents.Columns.Add("Phone Number");
            //foreach (Student student in students)
            //{
            //    ListViewItem li = new ListViewItem(student.Name);
            //    li.Tag = student;   // link student object to listview item
            //    listViewStudents.Items.Add(li);
            //}
            foreach (Student student in students)
            {

                ListViewItem item = new ListViewItem(student.Id.ToString());
                item.SubItems.Add(student.FirstName);
                item.SubItems.Add(student.LastName);
                item.SubItems.Add(student.TelephoneNumber.ToString());
                item.Tag = student;
                listViewStudents.Items.Add(item);
            }
            listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }
        private void DisplayRooms(List<Room> rooms)
        {
            // clear the listview before filling it
            listViewRooms.Clear();

            listViewRooms.View = View.Details;
            listViewRooms.Columns.Add("Room ID");
            listViewRooms.Columns.Add("Building");
            listViewRooms.Columns.Add("Floor");
            listViewRooms.Columns.Add("Room type");
            listViewRooms.Columns.Add("Number of beds");

            foreach (Room room in rooms)
            {
                ListViewItem item = new ListViewItem(room.RoomId.ToString());
                item.SubItems.Add(room.Building.ToString());
                item.SubItems.Add(room.Floor.ToString());
                item.SubItems.Add(room.RoomType);
                item.SubItems.Add(room.NrOfBeds.ToString());
                item.Tag = room;
                listViewRooms.Items.Add(item);
            }
            listViewRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private List<Activity> GetActivities()
        {
            ActivityService activityService = new ActivityService();
            List<Activity> activities = activityService.GetActivity();
            return activities;
        }

        private void DisplayActivities(List<Activity> activities)
        {
            // clear the listview before filling it
            lvActivities.Items.Clear();

            foreach (Activity activity in activities)
            {
                ListViewItem li = new ListViewItem(activity.Id.ToString());

                li.SubItems.Add(activity.Name);
                li.SubItems.Add(activity.Date);

                li.Tag = activity;   // link student object to listview item

                lvActivities.Items.Add(li);
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
        
        private void ShowActivitiesPanel()
        {
            // hide all other panels
            pnlDashboard.Hide();
            pnlStudents.Hide();
            roomsPanel.Hide();

            // show students
            pnlActivity.Show();

            try
            {
                // get and display all students
                List<Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the activities: " + e.Message);
            }
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }
    }
}

