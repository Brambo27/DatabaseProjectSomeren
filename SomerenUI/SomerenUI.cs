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
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
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
                    ListViewItem li = new ListViewItem(s.Name);
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
                        supervisor = "no";
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
            if (txtAanpassenValue.Text == "")
            {

            }
            else
            {
               value = txtAanpassenValue.Text;
            }
            if (true)
            {

            }
            ListViewItem item;

            try
            {
                item = listViewDrankVoorraad.SelectedItems[0];
                SomerenLogic.Drank_Service drank_Service = new Drank_Service();
                drank_Service.UpdateVoorraad(item.Text, value);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecteer een item");
            }

            showPanel("DrinkSupply");
        }
        private void cashregisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("CashRegister");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            }
            else
            {
                value = txtAanpassenValue.Text;
            }

            try
            {
                ListViewItem item = listViewDrankVoorraad.SelectedItems[0];
                SomerenLogic.Drank_Service drank_Service = new Drank_Service();
                drank_Service.UpdateNaam(item.Text, value);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecteer een item");
            }

            
            showPanel("DrinkSupply");
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            showPanel("Revenue");
        }

        private void btnNieuwDrank_Click(object sender, EventArgs e)
        {
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

            }
            else
            {
                value = txtAanpassenValue.Text;
            }

            try
            {
                ListViewItem item = listViewDrankVoorraad.SelectedItems[0];
                SomerenLogic.Drank_Service drank_Service = new Drank_Service();
                drank_Service.UpdatePrijs(item.Text, value);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Selecteer een item");
            }


            showPanel("DrinkSupply");
        }
    }
}
