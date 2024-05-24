using ChuongTrinhQuanLyKyTucXa_Version5;
using ChuongTrinhQuanLyKyTucXa_Vertion5.BUS;
using ChuongTrinhQuanLyKyTucXa_Vertion5.DTO;
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
    public partial class AllStudents : Form
    {
        private newStudentBUS studentBUS;

        public AllStudents()
        {
            InitializeComponent();
            studentBUS = new newStudentBUS();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AllStudents_Load(object sender, EventArgs e)
        {
            List<newStudent> students = studentBUS.GetStudents();
            guna2DataGridView1.DataSource = students;
        }
    }
}
