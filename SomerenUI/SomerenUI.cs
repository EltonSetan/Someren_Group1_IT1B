using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SomerenDAL;
using SomerenLogic;
using SomerenModel;
using SomerenService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
            InitializeComboBoxes();
            ShowDashboardPanel();
        }

        private void ShowPanel(Panel panelToShow)
        {

            foreach (var panel in new[] { pnlDashboard, pnlStudents, teacherpanel, pnlActivity, roomsPanel, panelDrinks, vatPanel, pnlRevenueReport, pnlTimetable })

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

        private List<Drink> GetDrinks()
        {
            return new DrinkService().GetDrinks();
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
                List<Student> Student1 = GetStudents();
                DisplayStudent1(Student1);
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks, listViewDrinksCashRegister); // Replace with the name of the ListView for the Cash Register panel
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the cash panel: " + e.Message);
            }
        }
        private void DisplayStudent1(List<Student> Student1)
        {
            listViewStudetnsCashRegister.Clear();
            listViewStudetnsCashRegister.View = View.Details;
            listViewStudetnsCashRegister.Columns.AddRange(new[] {
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
                listViewStudetnsCashRegister.Items.Add(item);
            }

            listViewStudetnsCashRegister.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

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

        private void DisplayDrinks(List<Drink> drinks, ListView targetListView)
        {
            targetListView.Clear();
            targetListView.View = View.Details;
            targetListView.Columns.AddRange(new[] {
        new ColumnHeader { Text = "Drink ID" },
        new ColumnHeader { Text = "Drink Name" },
        new ColumnHeader { Text = "Stock" },
        new ColumnHeader { Text = "Alcoholic" },
        new ColumnHeader { Text = "Price" },
    });

            foreach (Drink drink in drinks)
            {
                var item = new ListViewItem(drink.drinkId.ToString());
                item.SubItems.AddRange(new[] {
            drink.drinkName,
            drink.Stock.ToString(),
            drink.isAlcoholic.ToString(),
            drink.drinkPrice.ToString("C", CultureInfo.CurrentCulture),
        });
                item.Tag = drink;
                targetListView.Items.Add(item);
            }

            targetListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ShowActivitiesPanel()
        {
            ShowPanel(pnlActivity);

            try
            {
                List<Activities> activities = GetActivities();
                DisplayActivities(activities);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Something went wrong while loading the activities: {e.Message}");
            }
        }

        private void ShowDrinksPanel()
        {
            ShowPanel(panelDrinks);

            try
            {
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks, listViewdrinks); // Replace with the name of the ListView for the Drinks panel
            }
            catch (Exception e)
            {
                MessageBox.Show($"Something went wrong while loading the drinks: {e.Message}");
            }
        }


        private void ShowVATPanel()
        {
            ShowPanel(vatPanel);
        }


        private List<Activities> GetActivities()
        {
            return new ActivityService().GetActivity();
        }

        private void DisplayActivities(List<Activities> activities)
        {
            lvActivities.Clear();
            lvActivities.View = View.Details;
            lvActivities.Columns.AddRange(new[] {
        new ColumnHeader { Text = "Activity ID" },
        new ColumnHeader { Text = "Name" },
        new ColumnHeader { Text = "Date" },
        new ColumnHeader { Text = "End Time" },
    });

            foreach (Activities activity in activities)
            {
                var item = new ListViewItem(activity.Id.ToString());
                item.SubItems.AddRange(new[] {
                activity.Name.ToString(),
                activity.Date.ToString(),
                activity.EndTime.ToString(),

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

                int sales = GetSales(startDate, endDate);
                double turnover = GetTurnover(startDate, endDate);
                int nrOfCustomers = GetTotalCustomers(startDate, endDate);

                DisplayReport(sales, turnover, nrOfCustomers);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Something went wrong while loading the revenue report: {e.Message}");
            }
        }


        private int GetSales(DateTime startDate, DateTime endDate)
        {
            return new RevenueReportService().GetSales(startDate, endDate);
        }

        private double GetTurnover(DateTime startDate, DateTime endDate)
        {
            return new RevenueReportService().GetTurnover(startDate, endDate);
        }

        private int GetTotalCustomers(DateTime startDate, DateTime endDate)
        {
            return new RevenueReportService().GetTotalCustomers(startDate, endDate);
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
                  turnover.ToString("C", CultureInfo.CurrentCulture),
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

        private void drinkStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
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
            if (listViewStudetnsCashRegister.SelectedItems.Count == 0 || listViewDrinksCashRegister.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student and a drink.");
                return;
            }

            var selectedStudent = (Student)listViewStudetnsCashRegister.SelectedItems[0].Tag;
            var selectedDrink = (Drink)listViewDrinksCashRegister.SelectedItems[0].Tag;

            try
            {
                new CashRegisterService().AddSale(selectedStudent.Id, selectedDrink.drinkId);
                MessageBox.Show("Checkout successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing the sale: {ex.Message}");
            }

            // Refresh the students and drinks lists
            Showcashpanel();
        }
        private void ListViewStudetnsCashRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = "Total Price: --";
        }

        private void ListViewDrinksCashRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudetnsCashRegister.SelectedItems.Count == 0 || listViewDrinksCashRegister.SelectedItems.Count == 0)
            {
                lblTotalPrice.Text = "Total Price: --";
                return;
            }

            var selectedDrink = (Drink)listViewDrinksCashRegister.SelectedItems[0].Tag;
            double amountPaid = selectedDrink.drinkPrice;

            // Update the lblTotalPrice with the total price of the selected items
            lblTotalPrice.Text = $"Total Price: {amountPaid.ToString("C", CultureInfo.CurrentCulture)}";
        }

        private void vATCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowVATPanel();
        }


        private void listViewdrinks_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewdrinks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewdrinks.SelectedItems[0];
                Drink selectedDrink = selectedItem.Tag as Drink;

                txtDrinkId.Text = selectedDrink.drinkId.ToString();
                txtDrinkName.Text = selectedDrink.drinkName;
                txtPriceOfDrink.Text = selectedDrink.drinkPrice.ToString();
                txtIsAlcoholic.Text = selectedDrink.isAlcoholic;
                txtStock.Text = selectedDrink.Stock.ToString();

                // Change the Add button to Update
                btnAdd.Text = "Update";
                btnAdd.Click -= BtnAdd_Click; // Remove the Add event handler
                btnAdd.Click += BtnUpdate_Click; // Add the Update event handler
            }
        }
        private void listViewdrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewdrinks.SelectedItems.Count == 0)
            {
                // Clear input fields
                txtDrinkId.Clear();
                txtDrinkName.Clear();
                txtStock.Clear();
                txtPriceOfDrink.Clear();
                txtIsAlcoholic.Clear();

                // Change the Update button back to Add if it's not already "Add"
                if (btnAdd.Text != "Add")
                {
                    btnAdd.Text = "Add";
                    btnAdd.Click -= BtnUpdate_Click; // Remove the Update event handler
                    btnAdd.Click += BtnAdd_Click; // Add the Add event handler
                }
            }
        }


        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            DrinkService drinkService = new DrinkService();

            // Get the input values and create a new Drink object
            int DrinkId = int.Parse(txtDrinkId.Text);
            string DrinkName = txtDrinkName.Text;
            double PriceOfDrink = double.Parse(txtPriceOfDrink.Text);
            string isAlcoholic = txtIsAlcoholic.Text;
            int Stock = int.Parse(txtStock.Text);

            Drink updatedDrink = new Drink()
            {
                drinkId = DrinkId,
                drinkName = DrinkName,
                drinkPrice = PriceOfDrink,
                isAlcoholic = isAlcoholic,
                Stock = Stock
            };

            drinkService.UpdateDrink(updatedDrink);
            DisplayDrinks(drinkService.GetDrinks(), listViewdrinks);

            // Clear input fields after updating the drink
            txtDrinkId.Clear();
            txtDrinkName.Clear();
            txtStock.Clear();
            txtPriceOfDrink.Clear();
            txtIsAlcoholic.Clear();

            // Change the Update button back to Add
            btnAdd.Text = "Add";
            btnAdd.Click -= BtnUpdate_Click; // Remove the Update event handler
            btnAdd.Click += BtnAdd_Click; // Add the Add event handler
        }



        private void BtnRemove_Click(object sender, EventArgs e)
        {
            DrinkService drinkService = new DrinkService();
            if (listViewdrinks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewdrinks.SelectedItems[0];
                Drink selectedDrink = selectedItem.Tag as Drink;

                // Check if the drink has been sold
                if (selectedDrink.TimesSold == 0)
                {
                    drinkService.RemoveDrink(selectedDrink.drinkId);
                    DisplayDrinks(drinkService.GetDrinks(), listViewdrinks);
                }
                else
                {
                    MessageBox.Show("Cannot remove a drink that has been sold.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a drink to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DrinkService drinkService = new DrinkService();

            // Automatically generate the next available drinkId
            int DrinkId = drinkService.GetNextDrinkId();
            txtDrinkId.Text = DrinkId.ToString();

            // Get the input values and create a new Drink object
            string DrinkName = txtDrinkName.Text;
            double PriceOfDrink = double.Parse(txtPriceOfDrink.Text);
            string isAlcoholic = txtIsAlcoholic.Text;
            int Stock = int.Parse(txtStock.Text);

            Drink newDrink = new Drink()
            {
                drinkId = DrinkId,
                drinkName = DrinkName,
                drinkPrice = PriceOfDrink,
                isAlcoholic = isAlcoholic,
                Stock = Stock
            };

            drinkService.AddDrink(newDrink);
            DisplayDrinks(drinkService.GetDrinks(), listViewdrinks);

            // Clear input fields after adding a new drink
            txtDrinkId.Clear();
            txtDrinkName.Clear();
            txtStock.Clear();
            txtPriceOfDrink.Clear();
            txtIsAlcoholic.Clear();
        }

        private void btnCalculateVAT_Click(object sender, EventArgs e)
        {
            int year = int.Parse(cmbYear.SelectedItem.ToString());
            int quarter = cmbQuarter.SelectedIndex + 1;

            DateTime startDate = new DateTime(year, 3 * quarter - 2, 1);
            DateTime endDate = startDate.AddMonths(3).AddDays(-1);

            VATDao vatDao = new VATDao();
            (decimal lowTariffTotal, decimal highTariffTotal) = vatDao.GetVATTotals(startDate, endDate);

            DisplayResults(startDate, endDate, lowTariffTotal, highTariffTotal);
        }


        private void DisplayResults(DateTime startDate, DateTime endDate, decimal lowTariffTotal, decimal highTariffTotal)
        {
            lblQuarterDates.Text = $"Quarter runs from: {startDate.ToString("dd-MM-yyyy")} to: {endDate.ToString("dd-MM-yyyy")}";
            lblLowTariffTotal.Text = $"Total VAT (low tariff, 6%) amount payable: {lowTariffTotal.ToString("C", CultureInfo.CurrentCulture)}";
            lblHighTariffTotal.Text = $"Total VAT (high tariff, 21%) amount payable: {highTariffTotal.ToString("C", CultureInfo.CurrentCulture)}";
            lblTotalVAT.Text = $"Total VAT amount payable: {(lowTariffTotal + highTariffTotal).ToString("C", CultureInfo.CurrentCulture)}";
        }

        private void revenueReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowRevenuePanel();
        }

        private void monthCalendarStartDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime startDate = monthCalendarStartDate.SelectionRange.Start;
            lblRevenueDateRange.Text = $"Revenue Report from {monthCalendarStartDate.SelectionRange.Start.ToString("dd/MM/yyyy")} to {monthCalendarEndDate.SelectionRange.Start.ToString("dd/MM/yyyy")}";
            ShowRevenuePanel();
        }

        private void monthCalendarEndDate_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime endDate = monthCalendarEndDate.SelectionRange.Start;
            lblRevenueDateRange.Text = $"Revenue Report from {monthCalendarStartDate.SelectionRange.Start.ToString("dd/MM/yyyy")} to {endDate.ToString("dd/MM/yyyy")}";
            ShowRevenuePanel();
        }

        private void timetableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowTimetablePanel();
        }

        private void ShowTimetablePanel()
        {
            ShowPanel(pnlTimetable);

            DateTime monday = new GregorianCalendar().AddDays(datePickerTimetable.Value,-(int)datePickerTimetable.Value.DayOfWeek + 1);
            DateTime tuesday = monday.AddDays(1);
            DateTime wednesday = tuesday.AddDays(1);
            DateTime thursday = wednesday.AddDays(1);
            DateTime friday = thursday.AddDays(1);

            List<DateTime> weekdays = new List<DateTime>(); 
            weekdays.Add(monday);
            weekdays.Add(tuesday);
            weekdays.Add(wednesday);
            weekdays.Add(thursday);
            weekdays.Add(friday);

            List<Panel> weekPanels = new List<Panel>();
            weekPanels.Add(pnlMonday);
            weekPanels.Add(pnlTuesday);
            weekPanels.Add(pnlWednesday);
            weekPanels.Add(pnlThursday);
            weekPanels.Add(pnlFriday);

            int counter = 0;

            
            foreach (DateTime day in weekdays)
            {   
                List<TimetableActivity> activities = GetTimetableActivities(day);
                
                foreach (TimetableActivity activity in activities)
                {
                    activity.TimeOfActivity = activity.TimeOfActivity;
                    activity.NameOfActivity = activity.NameOfActivity;
                    activity.Supervisors = GetSupervisors(activity.activityId);
                 
                    ucActivity activityControl = new ucActivity(activity.NameOfActivity,activity.Supervisors, activity.TimeOfActivity);
                    weekPanels[counter].Controls.Add(activityControl);
                }
                counter++;
            }
        }

        private List<Teacher> GetSupervisors(int activityId)
        {
            return new TimetableService().GetSupervisors(activityId);
        }

        private List<TimetableActivity> GetTimetableActivities(DateTime date)
        {
            return new TimetableService().GetTimetableActivities(date);
        }

        private void datePickerTimetable_ValueChanged(object sender, EventArgs e)
        {
            pnlMonday.Controls.Clear();  
            pnlTuesday.Controls.Clear();
            pnlWednesday.Controls.Clear();
            pnlThursday.Controls.Clear();
            pnlFriday.Controls.Clear();
            ShowTimetablePanel();
		}
		
        private void lvActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActivityService activityService = new ActivityService();

            if (lvActivities.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = lvActivities.SelectedItems[0];
                int id = int.Parse(selectedItem.SubItems[0].Text);
                Activities selectedActivity = selectedItem.Tag as Activities;

                txtActivityID.Text = selectedActivity.Id.ToString();
                txtName.Text = selectedActivity.Name;
                txtDate.Text =selectedActivity.Date;
                txtEndTime.Text = selectedActivity.EndTime.ToString(); 
                
                // Change the Add button to Update
                btnAd.Text = "Change";
                btnAd.Click -= btnAd_Click; // Remove the Add event handler
                btnAd.Click += btnChange_Click; // Add the Update event handler
            }
            else
            {
                // Clear input fields
                txtActivityID.Clear();
                txtName.Clear();
                txtStock.Clear();
                txtDate.Clear();
                txtEndTime.Clear();

                // Change the Update button back to Add if it's not already "Add"
                if (btnAd.Text != "Add")
                {
                    btnAd.Text = "Add";
                    btnAd.Click -= btnChange_Click; // Remove the Update event handler
                    btnAd.Click += btnAd_Click; // Add the Add event handler
                }
            }
        }

        private void btnAd_Click(object sender, EventArgs e)
        {
            ActivityService activityService = new ActivityService();
            
            try
            {
                Activities activity = new Activities()
                {
                    Id = int.Parse(txtActivityID.Text),
                    Name = txtName.Text,
                    Date = txtDate.Text,
                    EndTime = DateTime.Parse(txtEndTime.Text),

                };
                activityService.AddActivity(activity);
                DisplayActivities(activityService.GetActivity());
            }
            catch (Exception)
            {
                MessageBox.Show($"Please use the correct format and fill in all fields.");
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ActivityService activityService = new ActivityService();
            Activities selectedActivity = (Activities)lvActivities.SelectedItems[0].Tag;

            try
            {
                selectedActivity.Id = int.Parse(txtActivityID.Text);
                selectedActivity.Name = txtName.Text;
                selectedActivity.Date = txtDate.Text;
                selectedActivity.EndTime = DateTime.Parse(txtEndTime.Text);
                activityService.UpdateActivity(selectedActivity);
                DisplayActivities(activityService.GetActivity());
            }
            catch (Exception)
            {

                MessageBox.Show($"Please use the correct format and fill in all fields.");
            }

            // Clear input fields after updating the activity
            txtActivityID.Clear();
            txtName.Clear();
            txtDate.Clear();
            txtEndTime.Clear();
            

            // Change the Update button back to Add
            btnAd.Text = "Add";
            btnAd.Click -= btnChange_Click; // Remove the Update event handler
            btnAd.Click += btnAd_Click; // Add the Add event handler

        }

        private void btnRemo_Click(object sender, EventArgs e)
        {
            ActivityService activityService = new ActivityService();

            DialogResult result = MessageBox.Show("Are you sure you want to remove this activity?","Confirm removal", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Activities selectedActivity = (Activities)lvActivities.SelectedItems[0].Tag;
                activityService.DeleteActivity(selectedActivity);
                DisplayActivities(activityService.GetActivity());
            }
        }
    }
}