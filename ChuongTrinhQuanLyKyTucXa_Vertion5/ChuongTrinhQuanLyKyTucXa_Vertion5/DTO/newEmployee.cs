using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5.DTO
{
    [Table (Name = "newEmployee")]
    public class newEmployee
    {
        [Column(IsPrimaryKey = true , IsDbGenerated = true)]
        public int id { get; set; }

        [Column]
        public long emobile { get; set; }
        [Column]
        public string ename { get; set; }
        [Column]
        public string efname { get; set; }
        [Column]
        public string emname { get; set; }
        [Column]
        public string eemail { get; set; }
        [Column]
        public string epaddress { get; set; }
        [Column]
        public string eidproof { get; set; }
        [Column]
        public string edesignation { get; set; }
        [Column]
        public string working { get; set; }

    }
}
