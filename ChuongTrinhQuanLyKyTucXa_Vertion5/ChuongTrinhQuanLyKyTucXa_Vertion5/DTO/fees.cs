using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5.DTO
{
    [Table (Name = "fees")]
    public class fees
    {
        [Column(IsPrimaryKey = true)]
        public long MobileNo { get; set; }

        [Column]
        public string fmonth { get; set; }
        [Column]
        public long amount { get; set; }
    }
}
