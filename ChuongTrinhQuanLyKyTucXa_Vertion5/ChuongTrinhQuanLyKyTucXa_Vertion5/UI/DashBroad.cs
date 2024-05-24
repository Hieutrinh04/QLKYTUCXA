using ChuongTrinhQuanLyKyTucXa_Version2;
using ChuongTrinhQuanLyKyTucXa_Version5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5
{
    public partial class DashBroad : Form
    {
        public DashBroad()
        {
            InitializeComponent();
        }

        private void btnNewStudents_Click(object sender, EventArgs e)
        {
            NewStudent nsd = new NewStudent();
            nsd.Show();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            AddNewRooms anr = new AddNewRooms();
            anr.Show();
        }

        private void DashBroad_Load(object sender, EventArgs e)
        {

        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUpdateDeletedStudent_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent uds = new UpdateDeleteStudent();
            uds.Show();
        }

        private void btnStudentFees_Click(object sender, EventArgs e)
        {
            StudentFees stf = new StudentFees();
            stf.Show();
        }

        private void btnAllStudents_Click(object sender, EventArgs e)
        {
            AllStudents ass = new AllStudents();
            ass.Show();
        }

        private void btnLeavedStudent_Click(object sender, EventArgs e)
        {
            LeavedStudent lst = new LeavedStudent();
                lst.Show();
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            NewEmployee nee = new NewEmployee();    
            nee.Show();
        }

        private void UpdateDeletedEmployee_Click(object sender, EventArgs e)
        {
            UpdateDeleteEmployee ude = new UpdateDeleteEmployee();
            ude.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void btnEmployeePayment_Click(object sender, EventArgs e)
        {
            EmployeePayment eep = new EmployeePayment();
            eep.Show();
        }

        private void btnLeavedEmployee_Click(object sender, EventArgs e)
        {

            LeavedEmployee lde = new LeavedEmployee();
                lde.Show();
        }

        private void btnAllEmployeeWorking_Click(object sender, EventArgs e)
        {
            AllEmployeeWorking aew = new AllEmployeeWorking();
            aew.Show();
        }
    }
}
