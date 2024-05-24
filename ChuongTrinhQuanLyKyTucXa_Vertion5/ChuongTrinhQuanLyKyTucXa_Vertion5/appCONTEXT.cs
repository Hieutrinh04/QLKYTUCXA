using ChuongTrinhQuanLyKyTucXa_Vertion5.DTO;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5
{
    public class appCONTEXT: DataContext
    {
        public Table<employeeSalary> employeeSalaries;
        public Table<fees> fees;
        public Table<newEmployee> newEmployees;
        public Table<newStudent> newStudents;
        public Table<rooms> rooms;

        public static appCONTEXT instance;
        public static appCONTEXT GetInstance()
        {
            if (instance == null)
            {
                instance = new appCONTEXT();
            }
            return instance;
        }
        public appCONTEXT(string connection) : base(connection) { }
        public appCONTEXT() : base(@"Data Source=LAPTOP-V5TS8BLR\HIEU;Initial Catalog=hostelvertion5;User ID=sa;Password=147852369;TrustServerCertificate=True") { }
        
    }
    
}

