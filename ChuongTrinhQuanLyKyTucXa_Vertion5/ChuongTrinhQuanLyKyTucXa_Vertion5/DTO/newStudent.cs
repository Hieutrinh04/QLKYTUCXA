using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5.DTO
{
    [Table (Name = "newStudent")]
    public class newStudent
    {
        [Column(IsPrimaryKey = true,IsDbGenerated =true)]
        public int id { get; set; }

        [Column]
        public long mobile { get; set; }
        [Column]
        public string name { get; set; }
        [Column]
        public string fname { get; set; }
        [Column]
        public string mname { get; set; }
        [Column]
        public string email { get; set; }
        [Column]
        public string paddress { get; set; }
        [Column]
        public string college { get; set; }
        [Column]
        public string idproof { get; set; }

        [Column]
        public long roomNo { get; set; }
        [Column]
         public string living { get; set; }
    }
}
