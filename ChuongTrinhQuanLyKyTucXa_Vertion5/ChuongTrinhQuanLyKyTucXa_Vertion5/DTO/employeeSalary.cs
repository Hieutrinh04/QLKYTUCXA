using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5.DTO
{
    [Table (Name = "employeeSalary")]
    public class employeeSalary
    {
        [Column(IsPrimaryKey = true)]
        public long MobileNo { get; set; }

        [Column]
        public string fmonth { get; set; }
        [Column]
        public long amount { get; set; }
        
    }
}
