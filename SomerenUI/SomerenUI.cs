using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SomerenModel;
using SomerenService;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            ShowDashboardPanel();
        }

        private void ShowPanel(Panel panelToShow)
        {
            foreach (var panel in new[] { pnlDashboard, pnlStudents, teacherpanel, pnlActivity, roomsPanel })
            {
                panel.Visible = false;
            }

            panelToShow.Visible = true;
            panelToShow.BringToFront();
        }

        private void ShowDashboardPanel()
        {
            ShowPanel(pnlDashboard);
        }

        private void ShowStudentsPanel()
        {
            ShowPanel(pnlStudents);

            try
            {
                List<Student> students = GetStudents();
                DisplayStudents(students);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Something went wrong while loading the students: {e.Message}");
            }
        }

        private List<Student> GetStudents()
        {
            return new StudentService().GetStudents();
        }

        private void DisplayStudents(List<Student> students)
        {
            listViewStudents.Clear();
            listViewStudents.View = View.Details;
            listViewStudents.Columns.AddRange(new[] {
        new ColumnHeader { Text = "Student ID" },
        new ColumnHeader { Text = "First Name" },
        new ColumnHeader { Text = "Last Name" },
        new ColumnHeader { Text = "Phone Number" },
    });

            foreach (Student student in students)
            {
                var item = new ListViewItem(student.Id.ToString());
                item.SubItems.AddRange(new[] {
            student.FirstName,
            student.LastName,
            student.TelephoneNumber.ToString(),
        });
                item.Tag = student;
                listViewStudents.Items.Add(item);
            }

            listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void Showcashpanel()
        {

            ShowPanel(cashpanel);

            try
            {
                // get and display all students
                List<Student> Student1 = GetStudents();
                DisplayStudent1(Student1);
                List<CashRegister> cash = GetCashRegisters();
                DisplayDrinks(cash);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }
        private List<CashRegister> GetCashRegisters()
        {
            CashRegisterService cashregisterService = new CashRegisterService();
            List<CashRegister> cash = cashregisterService.GetCashRegister();
            return cash;
        }
        private List<Student> GetStudent1()
        {
            StudentService studentService = new StudentService();
            List<Student> Student1 = studentService.GetStudents();
            return Student1;
        }
        private void DisplayStudent1(List<Student> Student1)
        {
            listViewstudent1.Clear();
            listViewstudent1.View = View.Details;
            listViewstudent1.Columns.AddRange(new[] {
        new ColumnHeader { Text = "Student ID" },
        new ColumnHeader { Text = "First Name" },
       // new ColumnHeader { Text = "Last Name" },
        //new ColumnHeader { Text = "Phone Number" },
        });

            foreach (Student student in Student1)
            {
                var item = new ListViewItem(student.Id.ToString());
                item.SubItems.AddRange(new[] {
                student.FirstName,
                    //student.LastName,
                    //student.TelephoneNumber.ToString(),
        });
                item.Tag = student;
                listViewstudent1.Items.Add(item);
            }

            listViewstudent1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
        private void DisplayDrinks(List<CashRegister> cash)
        {
            listViewdrinks.Clear();
            listViewdrinks.View = View.Details;
            listViewdrinks.Columns.AddRange(new[] {
        new ColumnHeader { Text = "Drink ID" },
        new ColumnHeader { Text = "Drink Name" },
        new ColumnHeader { Text = "Stock" },
        new ColumnHeader { Text = "Alcoholic" },
        new ColumnHeader { Text = "Price" },
    });

            foreach (CashRegister cashregister in cash)
            {
                var item = new ListViewItem(cashregister.Id.ToString());
                item.SubItems.AddRange(new[] {
            cashregister.Name,
            cashregister.Stock.ToString(),
            cashregister.Alcoholic.ToString(),
            cashregister.Price.ToString(),
        });
                item.Tag = cashregister;
                listViewdrinks.Items.Add(item);
            }

            listViewdrinks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void ShowTeachersPanel()
        {
            ShowPanel(teacherpanel);

            try
            {
                List<Teacher> teachers = GetTeachers();
                DisplayTeachers(teachers);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Something went wrong while loading the teachers: {e.Message}");
            }
        }

        private List<Teacher> GetTeachers()
        {
            return new LecturersService().GetTeachers();
        }

        private void DisplayTeachers(List<Teacher> teachers)
        {
            listViewteachers.Clear();
            listViewteachers.View = View.Details;
            listViewteachers.Columns.AddRange(new[] {
                new ColumnHeader { Text = "Lecturer ID" },
                new ColumnHeader { Text = "First Name" },
                new ColumnHeader { Text = "Last Name" },
                new ColumnHeader { Text = "Age" },
                new ColumnHeader { Text = "Phone Number" },
                new ColumnHeader { Text = "RoomId" },
                new ColumnHeader { Text = "isSupervisor" },
            });

            foreach (Teacher teacher in teachers)
            {
                var item = new ListViewItem(teacher.Number.ToString());
                item.SubItems.AddRange(new[] {
                    teacher.Name,
                    teacher.LastName,
                    teacher.Age.ToString(),
                    teacher.TelephoneNumber.ToString(),
                    teacher.RoomId.ToString(),
                    teacher.isSupervisor,
                   // teacher.DrinkId.ToString(),
                });
                item.Tag = teacher;
                listViewteachers.Items.Add(item);
            }

            listViewteachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ShowRoomsPanel()
        {
            ShowPanel(roomsPanel);

            try
            {
                List<Room> rooms = GetRooms();
                DisplayRooms(rooms);
            }
            catch (Exception e)


            {
                MessageBox.Show($"Something went wrong while loading the rooms: {e.Message}");
            }
        }

        private List<Room> GetRooms()
        {
            return new RoomService().GetRooms();
        }

        private void DisplayRooms(List<Room> rooms)
        {
            listViewRooms.Clear();
            listViewRooms.View = View.Details;
            listViewRooms.Columns.AddRange(new[] {
            new ColumnHeader { Text = "Room ID" },
            new ColumnHeader { Text = "Building" },
            new ColumnHeader { Text = "Floor" },
            new ColumnHeader { Text = "Room type" },
            new ColumnHeader { Text = "Number of beds" },
        });

            foreach (Room room in rooms)
            {
                var item = new ListViewItem(room.RoomId.ToString());
                item.SubItems.AddRange(new[] {
                room.Building.ToString(),
                room.Floor.ToString(),
                room.RoomType,
                room.NrOfBeds.ToString(),
            });
                item.Tag = room;
                listViewRooms.Items.Add(item);
            }

            listViewRooms.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ShowActivitiesPanel()
        {
            ShowPanel(pnlActivity);

            try
            {
                List<Activity> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Something went wrong while loading the activities: {e.Message}");
            }
        }

        private List<Activity> GetActivities()
        {
            return new ActivityService().GetActivity();
        }

        private void DisplayActivities(List<Activity> activities)
        {
            lvActivities.Clear();
            lvActivities.View = View.Details;
            lvActivities.Columns.AddRange(new[] {
        new ColumnHeader { Text = "Activity ID" },
        new ColumnHeader { Text = "Name" },
        new ColumnHeader { Text = "Date" },
    });

            foreach (Activity activity in activities)
            {
                var item = new ListViewItem(activity.Id.ToString());
                item.SubItems.AddRange(new[] {
            activity.Name,
            activity.Date,
        });
                item.Tag = activity;
                lvActivities.Items.Add(item);
            }

            lvActivities.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowDashboardPanel();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentsPanel();
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTeachersPanel();
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowActivitiesPanel();
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRoomsPanel();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cashRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Showcashpanel();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (listViewstudent1.SelectedItems.Count == 0 || listViewdrinks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student and a drink.");
                return;
            }

            var selectedStudent = (Student)listViewstudent1.SelectedItems[0].Tag;
            var selectedDrink = (CashRegister)listViewdrinks.SelectedItems[0].Tag;

            try
            {
                new CashRegisterService().AddSale(selectedStudent.Id, selectedDrink.Id);
                MessageBox.Show("Checkout successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing the sale: {ex.Message}");
            }

            // Refresh the students and drinks lists
            Showcashpanel();
        }



    }
}