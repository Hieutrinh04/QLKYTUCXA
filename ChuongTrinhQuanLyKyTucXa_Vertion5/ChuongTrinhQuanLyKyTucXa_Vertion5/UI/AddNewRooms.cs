
using ChuongTrinhQuanLyKyTucXa_Vertion5.BUS;
using ChuongTrinhQuanLyKyTucXa_Vertion5.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ChuongTrinhQuanLyKyTucXa_Version5
{
    public partial class AddNewRooms : Form
    {
        private roomsBUS roomsBUS;

        public AddNewRooms()
        {
            InitializeComponent();
            roomsBUS = new roomsBUS();
        }

        private void DinhDangLuoi()
        {
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 100;


            dataGridView1.Columns[0].HeaderText = "Mã phòng";
            dataGridView1.Columns[1].HeaderText = "Tình trạng";
            dataGridView1.Columns[2].HeaderText = "Đã đặt";


            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.ReadOnly = false;

                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                dataGridView1.RowHeadersVisible = false;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
        }

        private void AddNewRooms_Load(object sender, EventArgs e)
        {
             this.Location = new Point(545, 105);
            labelRoom.Visible = false;
            labelRoomExist.Visible = false;
            LoadRooms();
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

      
        private void LoadRooms()
        {
            List<rooms> rooms = roomsBUS.GetRooms();
            
            dataGridView1.DataSource = rooms;
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            rooms room = roomsBUS.getRoom(int.Parse(txtRoomNo1.Text));


            if (room == null)
            {
                string status = checkBox1.Checked ? "Yes" : "No";
                labelRoomExist.Visible = false;
                rooms insertRoom = new rooms () { roomNo = int.Parse(txtRoomNo1.Text), roomStatus = status , Booked = "No"};
                roomsBUS.insert(insertRoom);
                MessageBox.Show("Đã thêm phòng");
                LoadRooms();
            }
            else
            {
                labelRoomExist.Text = "Phòng đã có ";
                labelRoomExist.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            rooms room = roomsBUS.getRoom(int.Parse(txtRoomNo2.Text));
            if (room == null)
            {
                labelRoom.Text = "Phòng này không tồn tại ";
                labelRoom.Visible = true;
                checkBox2.Checked = false;
            }
            else
            {
                labelRoom.Text = "Phòng này đã tìm thấy ";
                labelRoom.Visible = true;
                dataGridView1.DataSource = room;
                if (room.Booked.Equals("Yes"))
                {
                    checkBox2.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            rooms room = roomsBUS.getRoom(int.Parse(txtRoomNo2.Text));

            if (room != null)
            {
                roomsBUS.delete(room.roomNo);
                LoadRooms();
            }
            else
            {
                MessageBox.Show("Phòng không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string status = checkBox2.Checked ? "Yes" : "No";
            
            if(txtRoomNo2.Text != ""){
                rooms room = roomsBUS.getRoom(int.Parse(txtRoomNo2.Text));
            if (room == null)
            {
                MessageBox.Show("Phòng không tồn tại!");
                return;
            }
                room.roomStatus = status;
                roomsBUS.update(room);
                LoadRooms();
            }
            else
            {
                return;
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {   
                DataGridViewRow selectionRow = dataGridView1.SelectedRows[0];
                var cellValue = selectionRow.Cells[0].Value;
                txtRoomNo2.Text = selectionRow.Cells[0].Value.ToString();
                if (selectionRow.Cells[1].Value.ToString().Equals("Yes")){ 
                    checkBox2.Checked = true; 
                }
                else checkBox2.Checked = false;
            }
        }




    }
}
