
using ChuongTrinhQuanLyKyTucXa_Vertion5.BUS;
using ChuongTrinhQuanLyKyTucXa_Vertion5.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ChuongTrinhQuanLyKyTucXa_Version5
{
    public partial class NewStudent : Form
    {
        private newStudentBUS studentBUS;
        private roomsBUS roomsBUS;
        public NewStudent()
        {
            InitializeComponent();
            roomsBUS = new roomsBUS();
            studentBUS = new newStudentBUS();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(545, 105);

            LoadComboBox();
        }

        private void LoadComboBox()
        {
            List<rooms> rooms = roomsBUS.FindByStatusAnhBooked("Yes", "No");

            ComboRoomNo.Items.Clear();
            // Kiểm tra nếu bảng có dữ liệu
            if (rooms.Count > 0)
            {
                for (int i = 0; i < rooms.Count; i++)
                {
                    // Lấy giá trị của room từ từng dòng trong bảng
                    Int64 room = rooms[i].roomNo;
                    ComboRoomNo.Items.Add(room);
                }
            }
        }

        private void ClearFields()
        {
            txtMobile.Text = "";
            txtName.Text = "";
            txtFather.Text = "";
            txtMother.Text = "";
            txtEmail.Text = "";
            txtPermaner.Text = "";
            txtCollge.Text = "";
            txtIdProof.Text = "";
            ComboRoomNo.SelectedIndex = -1;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtName.Text != "" && txtFather.Text != "" && txtMother.Text != "" && txtEmail.Text != "" && txtPermaner.Text != "" && txtCollge.Text != "" && txtIdProof.Text != "" && ComboRoomNo.SelectedIndex != -1)
            {
                // Thực hiện lưu thông tin sinh viên vào cơ sở dữ liệu
                // Ví dụ:
                string mobile = txtMobile.Text;
                string name = txtName.Text;
                string father = txtFather.Text;
                string mother = txtMother.Text;
                string email = txtEmail.Text;
                string address = txtPermaner.Text;
                string university = txtCollge.Text;
                string idProof = txtIdProof.Text;
                Int64 roomNo = (Int64)ComboRoomNo.SelectedItem;

                newStudent student = new newStudent() { mobile = long.Parse(txtMobile.Text), name = txtName.Text, mname = txtMother.Text, fname = txtFather.Text, college = txtCollge.Text, email = email, idproof=idProof, living="Yes", roomNo=roomNo, paddress = address };

                studentBUS.AddStudent(student);
                rooms room = roomsBUS.getRoom((int)roomNo);
                room.Booked = "Yes";
                roomsBUS.update(room);

                ClearFields();
                LoadComboBox();
                // Hàm này bạn tự định nghĩa để làm sạch các ô văn bản sau khi lưu thành công.
                
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin của sinh viên", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
