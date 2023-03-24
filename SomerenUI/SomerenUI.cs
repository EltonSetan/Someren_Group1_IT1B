using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using SomerenDAL;
using SomerenLogic;
using SomerenModel;
using SomerenService;

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
            foreach (var panel in new[] { pnlDashboard, pnlStudents, teacherpanel, pnlActivity, roomsPanel, panelDrinks, vatPanel })
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
                    teacher.DrinkId.ToString(),
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

        private void DisplayDrinks(List<Drink> drinks)
        {
            listViewDrinks.Clear();
            listViewDrinks.View = View.Details;
            listViewDrinks.Columns.AddRange(new[] {
        new ColumnHeader { Text = "Drink ID" },
        new ColumnHeader { Text = "Drink Name" },
        new ColumnHeader { Text = "Is Alcoholic" },
        new ColumnHeader { Text = "Stock" },
        new ColumnHeader { Text = "Price of Drink" },
    });

            foreach (Drink drink in drinks)
            {
                var item = new ListViewItem(drink.drinkId.ToString());
                item.SubItems.AddRange(new[] {
            drink.drinkName,
            drink.isAlcoholic.ToString(),
            drink.Stock.ToString(),
            drink.drinkPrice.ToString("F2"), // Display price with two decimal places
        });
                item.Tag = drink;
                listViewDrinks.Items.Add(item);
            }

            listViewDrinks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
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

        private void ShowDrinksPanel()
        {
            ShowPanel(panelDrinks);

            try
            {
                List<Drink> drinks = GetDrinks();
                DisplayDrinks(drinks);
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

        private void drinkStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDrinksPanel();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vATCalculationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowVATPanel();
        }


        private void listViewDrinks_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewDrinks.SelectedItems[0];
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
        private void listViewDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDrinks.SelectedItems.Count == 0)
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
            DisplayDrinks(drinkService.GetDrinks());

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
            if (listViewDrinks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewDrinks.SelectedItems[0];
                Drink selectedDrink = selectedItem.Tag as Drink;

                // Check if the drink has been sold
                if (selectedDrink.TimesSold == 0)
                {
                    drinkService.RemoveDrink(selectedDrink.drinkId);
                    DisplayDrinks(drinkService.GetDrinks());
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

            // Get the input values and create a new Drink object
            int DrinkId = int.Parse(txtDrinkId.Text);
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
            DisplayDrinks(drinkService.GetDrinks());

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
    }
}