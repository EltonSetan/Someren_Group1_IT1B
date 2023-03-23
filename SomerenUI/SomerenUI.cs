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
            foreach (var panel in new[] { pnlDashboard, pnlStudents, teacherpanel, pnlActivity, roomsPanel, pnlRevenueReport })
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
                    //teacher.DrinkId.ToString(),
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

        private void ShowRevenuePanel()
        {
            ShowPanel(pnlRevenueReport);

            try
            {
                DateTime startDate = monthCalendarStartDate.SelectionRange.Start;
                DateTime endDate = monthCalendarEndDate.SelectionRange.End;

                int sales = GetSales(startDate,endDate);
                double turnover = GetTurnover(startDate, endDate);
                int nrOfCustomers = GetTotalCustomers(startDate,endDate);

                DisplayReport(sales, turnover, nrOfCustomers);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Something went wrong while loading the revenue report: {e.Message}");
            }
        }


        private int GetSales(DateTime startDate, DateTime endDate)
        {
            return new CashRegisterService().GetSales(startDate, endDate);
        }

        private double GetTurnover(DateTime startDate, DateTime endDate)
        {
            return new CashRegisterService().GetTurnover(startDate, endDate);
        }

        private int GetTotalCustomers(DateTime startDate, DateTime endDate)
        {
            return new CashRegisterService().GetTotalCustomers(startDate, endDate);
        }

        private void DisplayReport(int sales, double turnover, int nrOfCustomers)
        {
            lvRevenueReport.Clear();
            lvRevenueReport.View = View.Details;
            lvRevenueReport.Columns.AddRange(new[] {
            new ColumnHeader { Text = "Sales" },
            new ColumnHeader { Text = "Turnover" },
            new ColumnHeader { Text = "Number of Customers"}
        });
            List<double> report = new List<double>();
            report.Add(sales);
            report.Add(turnover);
            report.Add(nrOfCustomers);

            var item = new ListViewItem(sales.ToString());
            item.SubItems.AddRange(new[] {
                  turnover.ToString(),
                  nrOfCustomers.ToString()
            });
            item.Tag = report;
            lvRevenueReport.Items.Add(item);

            lvRevenueReport.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();
        }

        private void monthCalendarStartDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime startDate = monthCalendarStartDate.SelectionRange.Start;   
        }

        private void monthCalendarEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime endDate = monthCalendarEndDate.SelectionRange.Start;
            lblRevenueDateRange.Text = $"Revenue Report from {monthCalendarStartDate.SelectionRange.Start.ToString("dd/MM/yyyy")} to {endDate.ToString("dd/MM/yyyy")}";
            ShowRevenuePanel();
        }
    }
}