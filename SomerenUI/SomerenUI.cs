using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();

            // Create an instance of a ListView column sorter and assign it 
            // to the ListView control.
            lvwColumnSorter = new ListViewColumnSorter();
            this.listViewTeachers.ListViewItemSorter = lvwColumnSorter;
        }

        //Dit is om de listviews te sorteren
        private ListViewColumnSorter lvwColumnSorter;

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Registratie");
        }

        private void showPanel(string panelName)
        {

            if (panelName == "Dashboard")
            {

                // hide all other panels
                pnl_Teachers.Hide();
                imgTeachersLogo.Hide();
                pnl_Students.Hide();
                imgStudentsLogo.Hide();
                pnl_Rooms.Hide();
                imgRoomsLogo.Hide();
                pnl_DrinkSupply.Hide();
                pnl_Revenue.Hide();
                pnl_CashRegister.Hide();
                pnl_Activity.Hide();
                pnl_Schedule.Hide();
                pnl_Registratie.Hide();


                // show dashboard
                pnl_Dashboard.Show();
                imgDashboardLogo.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                imgDashboardLogo.Hide();
                pnl_Teachers.Hide();
                imgTeachersLogo.Hide();
                pnl_Rooms.Hide();
                imgRoomsLogo.Hide();
                pnl_DrinkSupply.Hide();
                pnl_Revenue.Hide();
                pnl_CashRegister.Hide();
                pnl_Activity.Hide();
                pnl_Schedule.Hide();
                pnl_Registratie.Hide();


                // show students
                pnl_Students.Show();
                imgStudentsLogo.Show();

                // fill the students listview within the students panel with a list of students
                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                // clear the listview before filling it again
                listViewStudents.Items.Clear();

                foreach (SomerenModel.Student s in studentList)
                {
                    ListViewItem li = new ListViewItem(s.Number.ToString());
                    li.SubItems.Add(s.Name);
                    li.SubItems.Add(s.BirthDate.ToString());
                    listViewStudents.Items.Add(li);
                }
            }
            else if (panelName == "Teachers")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                imgDashboardLogo.Hide();
                pnl_Students.Hide();
                imgStudentsLogo.Hide();
                pnl_Rooms.Hide();
                imgRoomsLogo.Hide();
                pnl_DrinkSupply.Hide();
                pnl_Revenue.Hide();
                pnl_CashRegister.Hide();
                pnl_Activity.Hide();
                pnl_Schedule.Hide();
                pnl_Registratie.Hide();


                // show Teachers
                pnl_Teachers.Show();
                imgTeachersLogo.Show();



                // fill the teacher listview within the teacher panel with a list of teacher
                SomerenLogic.Teacher_Service teachService = new SomerenLogic.Teacher_Service();
                List<Teacher> teacherList = teachService.GetTeachers();

                // clear the listview before filling it again
                listViewTeachers.Items.Clear();

                foreach (SomerenModel.Teacher t in teacherList)
                {
                    string supervisor;

                    if (t.IsSupervisor == true)
                    {
                        supervisor = "Yes";
                    }
                    else
                    {
                        supervisor = "No";
                    }

                    ListViewItem list = new ListViewItem(t.Number.ToString());
                    list.SubItems.Add(t.Name);
                    list.SubItems.Add(supervisor);
                    listViewTeachers.Items.Add(list);
                }
            }
            else if (panelName == "Rooms")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                imgDashboardLogo.Hide();
                pnl_Teachers.Hide();
                imgTeachersLogo.Hide();
                pnl_Students.Hide();
                imgStudentsLogo.Hide();
                pnl_DrinkSupply.Hide();
                pnl_Revenue.Hide();
                pnl_CashRegister.Hide();
                pnl_Activity.Hide();
                pnl_Schedule.Hide();
                pnl_Registratie.Hide();

                // show Rooms
                pnl_Rooms.Show();
                imgRoomsLogo.Show();

                // fill the rooms listview within the rooms panel with a list of rooms
                SomerenLogic.Room_Service roomService = new SomerenLogic.Room_Service();
                List<Room> roomList = roomService.GetRooms();

                // clear the listview before filling it again
                listViewRooms.Items.Clear();

                foreach (SomerenModel.Room r in roomList)
                {
                    ListViewItem li = new ListViewItem(r.Number.ToString());
                    listViewRooms.Items.Add(li);
                    li.SubItems.Add(r.Capacity.ToString());
                    li.SubItems.Add(r.Type.ToString());
                }
            }
            else if (panelName == "DrinkSupply")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                imgDashboardLogo.Hide();
                pnl_Teachers.Hide();
                imgTeachersLogo.Hide();
                pnl_Students.Hide();
                imgStudentsLogo.Hide();
                pnl_Rooms.Hide();
                imgRoomsLogo.Hide();
                pnl_Revenue.Hide();
                pnl_CashRegister.Hide();
                pnl_Activity.Hide();
                pnl_Schedule.Hide();
                pnl_Registratie.Hide();


                // show Rooms
                pnl_DrinkSupply.Show();



                // fill the drank listview within the drank panel with a list of drank
                SomerenLogic.Drank_Service drank_Service = new SomerenLogic.Drank_Service();
                List<Drank> drankList = drank_Service.GetDrank();

                // clear the listview before filling it again
                listViewDrankVoorraad.Items.Clear();

                foreach (SomerenModel.Drank d in drankList)
                {
                    ListViewItem li = new ListViewItem(d.Name);
                    listViewDrankVoorraad.Items.Add(li);
                    li.SubItems.Add(d.Number.ToString());
                    li.SubItems.Add(d.Voorraad.ToString());
                    li.SubItems.Add(d.Prijs.ToString());

                    if (d.Voorraad < 10)
                    {
                        li.SubItems.Add("te laag");
                    }
                    else
                    {
                        li.SubItems.Add("Genoeg");
                    }
                }
            }
            else if (panelName == "DrinkSupply")
            {
                // hide all other panels
                pnl_Dashboard.Hide();
                imgDashboardLogo.Hide();
                pnl_Teachers.Hide();
                imgTeachersLogo.Hide();
                pnl_Students.Hide();
                imgStudentsLogo.Hide();
                pnl_Rooms.Hide();
                imgRoomsLogo.Hide();
                pnl_Revenue.Hide();
                pnl_CashRegister.Hide();
                pnl_Activity.Hide();
                pnl_Schedule.Hide();
                pnl_Registratie.Hide();


                // show Rooms
                pnl_DrinkSupply.Show();
            }
            else if (panelName == "Revenue")
            {
                pnl_Dashboard.Hide();
                imgDashboardLogo.Hide();
                pnl_Teachers.Hide();
                imgTeachersLogo.Hide();
                pnl_Students.Hide();
                imgStudentsLogo.Hide();
                pnl_Rooms.Hide();
                imgRoomsLogo.Hide();
                pnl_DrinkSupply.Hide();
                pnl_CashRegister.Hide();
                pnl_Activity.Hide();
                pnl_Schedule.Hide();
                pnl_Registratie.Hide();

                pnl_Revenue.Show();

                DateTime startDate = dateTimePickerStartDate.Value;
                DateTime endDate = dateTimePickerEndDate.Value;

                DateTime startDateOnly = startDate.Date;
                DateTime endDateOnly = endDate.Date;

                SomerenLogic.Revenue_Service revenueService = new SomerenLogic.Revenue_Service();
                List<Revenue> revenueList = revenueService.GetRevenue();

                listViewRevenue.Items.Clear();

                if (startDate <= endDate)
                {

                    int totalSales = 0, totalRevenue = 0, numberOfStudents = 0;

                    List<int> studentList = new List<int>();

                    foreach (SomerenModel.Revenue r in revenueList)
                    {
                        if (startDateOnly == r.Date || endDateOnly == r.Date)
                        {
                            totalSales++;
                            totalRevenue += r.Price;

                            if (studentList.IndexOf(r.StudentNumber) < 0)
                            {
                                studentList.Add(r.StudentNumber);
                                numberOfStudents++;
                            }
                        }
                    }

                    ListViewItem list = new ListViewItem(totalSales.ToString());
                    list.SubItems.Add(totalRevenue.ToString());
                    list.SubItems.Add(numberOfStudents.ToString());
                    listViewRevenue.Items.Add(list);
                }
                else
                {
                    MessageBox.Show("Start date can't be higher than end date", "Error");
                }
            }
            else if (panelName == "CashRegister")
            {
                pnl_Dashboard.Hide();
                imgDashboardLogo.Hide();
                pnl_Teachers.Hide();
                imgTeachersLogo.Hide();
                pnl_Students.Hide();
                imgStudentsLogo.Hide();
                pnl_Rooms.Hide();
                imgRoomsLogo.Hide();
                pnl_DrinkSupply.Hide();
                pnl_Revenue.Hide();
                pnl_Activity.Hide();
                pnl_Schedule.Hide();
                pnl_Registratie.Hide();

                pnl_CashRegister.Show();

                SomerenLogic.CashRegister_Service cashRegisterService = new SomerenLogic.CashRegister_Service();
                List<CashRegister> cashRegisters = cashRegisterService.GetCashRegisters();

                SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
                List<Student> studentList = studService.GetStudents();

                listViewCRStudents.Items.Clear();
                foreach (SomerenModel.Student s in studentList)
                {
                    ListViewItem li = new ListViewItem(s.Number.ToString());
                    listViewCRStudents.Items.Add(li);
                    li.SubItems.Add(s.Name);
                }
                listViewCRDrank.Items.Clear();
                foreach (SomerenModel.CashRegister c in cashRegisters)
                {
                    ListViewItem li = new ListViewItem(c.DrankID.ToString());
                    listViewCRDrank.Items.Add(li);
                    li.SubItems.Add(c.DrankNaam);
                }
            } //meneer otter kan geen dammen bouwen want hij is geen bever
            else if (panelName == "Activity")
            {
                pnl_Dashboard.Hide();
                imgDashboardLogo.Hide();
                pnl_Teachers.Hide();
                imgTeachersLogo.Hide();
                pnl_Students.Hide();
                imgStudentsLogo.Hide();
                pnl_Rooms.Hide();
                imgRoomsLogo.Hide();
                pnl_DrinkSupply.Hide();
                pnl_Revenue.Hide();
                pnl_CashRegister.Hide();
                pnl_Schedule.Hide();
                pnl_Registratie.Hide();

                pnl_Activity.Show();

                SomerenLogic.Activity_Service activityService = new SomerenLogic.Activity_Service();
                List<Activity> activities = activityService.GetActivities();

                listViewActivity.Items.Clear();
                foreach (SomerenModel.Activity A in activities)
                {
                    ListViewItem li = new ListViewItem(A.activityID.ToString());
                    listViewActivity.Items.Add(li);
                    li.SubItems.Add(A.activityName);
                    li.SubItems.Add(A.numberOfStudents.ToString());
                    li.SubItems.Add(A.numerOfDocents.ToString());
                }
            }
            else if (panelName == "Schedule")
            {
                pnl_Dashboard.Hide();
                imgDashboardLogo.Hide();
                pnl_Teachers.Hide();
                imgTeachersLogo.Hide();
                pnl_Students.Hide();
                imgStudentsLogo.Hide();
                pnl_Rooms.Hide();
                imgRoomsLogo.Hide();
                pnl_DrinkSupply.Hide();
                pnl_Revenue.Hide();
                pnl_CashRegister.Hide();
                pnl_Activity.Hide();
                pnl_Registratie.Hide();

                pnl_Schedule.Show();

                SomerenLogic.Schedule_Service scheduleService = new SomerenLogic.Schedule_Service();
                List<Schedule> schedules = scheduleService.GetSchedules();

                listViewSchedule.Items.Clear();

                foreach (SomerenModel.Schedule S in schedules)
                {
                    ListViewItem li = new ListViewItem(S.RoosterID.ToString());

                    //li.SubItems.Add(S.RoosterID.ToString());
                    li.SubItems.Add(S.Supervisors.ToString());

                    DateTime date = S.StartDate.Date;
                    string dateString = date.ToString("dd-MM-yyyy");
                    li.SubItems.Add(dateString);

                    string timeString = S.StartTime.ToString(@"hh\:mm");
                    li.SubItems.Add(timeString);

                    timeString = S.EndTime.ToString(@"hh\:mm");
                    li.SubItems.Add(timeString);


                    listViewSchedule.Items.Add(li);
                }
            }
            else if (panelName == "Registratie")
            {
                pnl_Dashboard.Hide();
                imgDashboardLogo.Hide();
                pnl_Teachers.Hide();
                imgTeachersLogo.Hide();
                pnl_Students.Hide();
                imgStudentsLogo.Hide();
                pnl_Rooms.Hide();
                imgRoomsLogo.Hide();
                pnl_DrinkSupply.Hide();
                pnl_Revenue.Hide();
                pnl_CashRegister.Hide();
                pnl_Activity.Hide();
                pnl_Schedule.Hide();

                pnl_Registratie.Show();
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }
        private void img_Dashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teachers");
        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }

        private void drinkSupplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("DrinkSupply");
        }

        private void revenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Revenue");
        }

        private void btnVoorraadAanpassen_Click(object sender, EventArgs e)
        {
            string value = "";
            
            ListViewItem item;

            if (txtAanpassenValue.Text == "")
            {
                MessageBox.Show("Geef een geldige waarde op. (Niet niks)");
                return;
            }
            if (!IsInt(txtAanpassenValue.Text))
            {
                MessageBox.Show("Geef een geldige waarde op. (Moet een cijfer zijn. Geen comma waarden)");
                return;
            }
            try
            {
                value = txtAanpassenValue.Text;
                item = listViewDrankVoorraad.SelectedItems[0];
                SomerenLogic.Drank_Service drank_Service = new Drank_Service();
                drank_Service.UpdateVoorraad(item.Text, value);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecteer een item");
                return;
            }

            showPanel("DrinkSupply");
        }
        private void cashregisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("CashRegister");
        }

        private void btn_afrekene_Click(object sender, EventArgs e)
        {
            SomerenLogic.CashRegister_Service cashRegisterService = new SomerenLogic.CashRegister_Service();
            List<CashRegister> cashRegisters = cashRegisterService.GetCashRegisters();

            SomerenLogic.Student_Service studService = new SomerenLogic.Student_Service();
            List<Student> studentList = studService.GetStudents();

            ListViewItem student = listViewCRStudents.SelectedItems[0];
            ListViewItem drankje = listViewCRDrank.SelectedItems[0];
            cashRegisterService.Db_Bar_Update_verkoop(int.Parse(drankje.Text), int.Parse(student.Text));

        }
        private void btnNaamAanpassen_Click(object sender, EventArgs e)
        {
            string value = "";
            if (txtAanpassenValue.Text == "")
            {
                MessageBox.Show("Geef een geldige waarde op. (Niet niks)");
                return;
            }
            try
            {
                value = txtAanpassenValue.Text;

                ListViewItem item = listViewDrankVoorraad.SelectedItems[0];
                SomerenLogic.Drank_Service drank_Service = new Drank_Service();
                drank_Service.UpdateNaam(item.Text, value);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecteer een item");
                return;
            }
            
            showPanel("DrinkSupply");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            showPanel("Revenue");
        }

        private void btnNieuwDrank_Click(object sender, EventArgs e)
        {
            if (txtNieuwNaam.Text == "" || txtNieuwPrijs.Text == "" || txtNieuwVoorraad.Text == "")
            {
                MessageBox.Show("De invoer boxen mogen niet leeg zijn. Probeer het opnieuw makker");
                return;
            }
            try
            {
                SomerenLogic.Drank_Service drank_Service = new Drank_Service();
                drank_Service.NieuwDrankje(txtNieuwNaam.Text, txtNieuwVoorraad.Text, txtNieuwPrijs.Text);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecteer een item");
            }

            showPanel("DrinkSupply");
        }

        private void btnPrijsAanpassen_Click(object sender, EventArgs e)
        {
            string value = "";
            if (txtAanpassenValue.Text == "")
            {
                MessageBox.Show("Geef een geldige waarde op. (Niet niks)");
                return;
            }
            if (!IsInt(txtAanpassenValue.Text))
            {
                MessageBox.Show("Geef een geldige waarde op. (Moet een cijfer zijn. Geen comma waarden)");
                return;
            }
            try
            {
                value = txtAanpassenValue.Text;
                ListViewItem item = listViewDrankVoorraad.SelectedItems[0];
                SomerenLogic.Drank_Service drank_Service = new Drank_Service();
                drank_Service.UpdatePrijs(item.Text, value);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecteer een item");
                return;
            }

            showPanel("DrinkSupply");
        }

        private bool IsInt(string testValue)
        {
            return int.TryParse(testValue, out int nummer);
        }

        private void activitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Activity");
        }

        private void btnNewActivity_Click(object sender, EventArgs e)
        {
            if (NewName.Text == "" || NewStudents.Text == "" || NewDocents.Text == "")
            {
                MessageBox.Show("De invoer boxen mogen niet leeg zijn. Probeer het opnieuw makker");
                return;
            }
            try
            {
                SomerenLogic.Activity_Service activity_Service = new Activity_Service();
                activity_Service.NewActivity(NewName.Text, int.Parse(NewStudents.Text), int.Parse(NewDocents.Text));
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Geen geldig cijfer");
            }

            showPanel("Activity");

        }

        private void Change_Name_Click(object sender, EventArgs e)
        {
            string value = "";
            if (txtValue.Text == "")
            {
                MessageBox.Show("The value can't be nothing");
                return;
            }
            try
            {
                value = txtValue.Text;
                ListViewItem item = listViewActivity.SelectedItems[0];
                SomerenLogic.Activity_Service activity_Service = new Activity_Service();
                activity_Service.UpdateName(value, int.Parse(item.Text));
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an item");
                return;
            }

            showPanel("Activity");
        }

        private void Change_Students_Click(object sender, EventArgs e)
        {
            string value = "";
            if (txtValue.Text == "")
            {
                MessageBox.Show("The value can't be nothing");
                return;
            }
            if (!IsInt(txtValue.Text))
            {
                MessageBox.Show("Not a valid value(Only number, No comma's)");
                return;
            }
            try
            {
                value = txtValue.Text;
                ListViewItem item = listViewActivity.SelectedItems[0];
                SomerenLogic.Activity_Service activity_Service = new Activity_Service();
                activity_Service.UpdateStudent(value, int.Parse(item.Text));
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an Item");
                return;
            }

            showPanel("Activity");
        }

        private void Change_Docents_Click(object sender, EventArgs e)
        {
            string value = "";
            if (txtValue.Text == "")
            {
                MessageBox.Show("The value can't be nothing");
                return;
            }
            if (!IsInt(txtValue.Text))
            {
                MessageBox.Show("Not a valid value(Only number, No comma's)");
                return;
            }
            try
            {
                value = txtValue.Text;
                ListViewItem item = listViewActivity.SelectedItems[0];
                SomerenLogic.Activity_Service activity_Service = new Activity_Service();
                activity_Service.UpdateDocent(value, int.Parse(item.Text));
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an item");
                return;
            }

            showPanel("Activity");
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure?", "sure?", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    ListViewItem item = listViewActivity.SelectedItems[0];
                    SomerenLogic.Activity_Service activity_Service = new Activity_Service();
                    activity_Service.Delete(int.Parse(item.Text));
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Select an item");
                    return;
                }
            }
            showPanel("Activity");
        }

        private void listViewTeachers_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.listViewTeachers.Sort();
        }

        private void btnUpgradeToSupervisor_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listViewTeachers.SelectedItems[0];
                Teacher_Service teacher_Service = new Teacher_Service();

                if (item.SubItems[2].Text == "No")
                {
                    teacher_Service.DowngradeSupervisorToTeacher(item.Text);
                }
                else
                {
                    MessageBox.Show("Cannot upgrade teacher who is already a supervisor");
                }

                teacher_Service.UpgradeTeacherToSupervisor(item.Text);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an item");
                return;
            }

            showPanel("Teachers");
        }

        private void btnDowngradeToTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listViewTeachers.SelectedItems[0];
                Teacher_Service teacher_Service = new Teacher_Service();

                if (item.SubItems[2].Text == "Yes")
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to demote this supervisor to teacher?", "Are you sure?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        teacher_Service.DowngradeSupervisorToTeacher(item.Text);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Cannot downgrade a teacher who is not a supervisor");
                }

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select an item");
                return;
            }

            showPanel("Teachers");
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Schedule");
        }

        private void btn_ChangeSchedule_Click(object sender, EventArgs e)
        {
            SomerenLogic.Schedule_Service schedules = new SomerenLogic.Schedule_Service();

            string firstSelection = listViewSchedule.SelectedItems[0].Text;
            string secondSelection = listViewSchedule.SelectedItems[1].Text;

            schedules.SwapActivityTime(firstSelection, secondSelection);

            showPanel("Schedule");
        }

        private void btnRegistreren_Click(object sender, EventArgs e)
        {
            Gebruiker_Service gebruiker_Service = new Gebruiker_Service();
            const string LICENTIESLEUTEL = "XsZAb-tgz3PsD-qYh69un-WQCEx";

            if (txtLicentiesleutel.Text == "" || txtRegistrerenEmail.Text == "" || txtRegistrerenNaam.Text == "")
            {
                MessageBox.Show("The value can't be nothing");
                return;
            }
            if (txtLicentiesleutel.Text.Equals(LICENTIESLEUTEL))
            {
                string naam, email;
                naam = txtRegistrerenNaam.Text;
                email = txtRegistrerenEmail.Text;
                bool requestAdminRights = false;

                DialogResult dialogResult1 = MessageBox.Show("Do you want to ask an admin for admin rights?", "Request admin rights?", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.Yes)
                {
                    requestAdminRights = true;
                }
                else if (dialogResult1 == DialogResult.No)
                {
                    requestAdminRights = false;
                }

                gebruiker_Service.AddUser(naam, email, requestAdminRights);
            }
            else
            {
                MessageBox.Show("Dit is geen geldige licentiesleutel");
                return;
            }



            //Admin aanvraag code moet gebruikt worden nadat er is ingelogt door een admin.

            //List<Gebruiker> gebruikers = gebruiker_Service.GetUserMetAdminAanvraag();
            //if (gebruikers.Count != 0)
            //{
            //    foreach (Gebruiker gebruiker in gebruikers){
            //        string naam = gebruiker.Naam;
            //        string email = gebruiker.Email;

            //        string dialogText = string.Format("Do you want to give this person admin rights? {0}Naam: {1} Email: {2}", Environment.NewLine, naam, email);
            //        DialogResult dialogResult2 = MessageBox.Show(dialogText, "Admin Rights Request", MessageBoxButtons.YesNo);
            //        if (dialogResult2 == DialogResult.Yes)
            //        {
            //            gebruiker_Service.UpdateAdminRights(true, gebruiker.Gebruiker_ID.ToString());
            //            gebruiker_Service.UpdateAdminAanvraagStaus(false, gebruiker.Gebruiker_ID.ToString());
            //        }
            //        else if (dialogResult2 == DialogResult.No)
            //        {
            //            gebruiker_Service.UpdateAdminAanvraagStaus(false, gebruiker.Gebruiker_ID.ToString());
            //        }
            //}
            //}
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SomerenLogic.Gebruiker_Service gebruiker_Service = new SomerenLogic.Gebruiker_Service();
            List<Gebruiker> gebruikers = gebruiker_Service.GetUsers();

            if (txt_email.Text == "" || txt_wachtwoord.Text == "")
            {
                MessageBox.Show("Email en/of wachtwoord mag niet leeg zijn");
            }
            else
            {
                string email = txt_email.Text;
                string wachtwoord = txt_wachtwoord.Text;
                bool emailBekend = false;

                foreach (Gebruiker gebruiker in gebruikers)
                {
                    if (gebruiker.Email == email)
                    {
                        emailBekend = true;
                        if (gebruiker.Wachtwoord == wachtwoord)
                        {
                            showPanel("Dashboard");
                        }
                        else
                        {
                            MessageBox.Show("Ongeldig wachtwoord");
                            break;
                        }
                    }
                }
                if (!emailBekend)
                {
                    MessageBox.Show("Dit email is niet bekent, registreer eerst");
                }
            }       
        }
    }
}
