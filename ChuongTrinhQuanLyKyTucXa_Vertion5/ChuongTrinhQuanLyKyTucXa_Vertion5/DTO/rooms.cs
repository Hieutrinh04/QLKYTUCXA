using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5.DTO
{
    [Table (Name = "rooms")]
    public class rooms
    {
        [Column(IsPrimaryKey = true)]
        public long roomNo { get; set; }

        [Column]
        public string roomStatus { get; set; }
        [Column]
        public string Booked { get; set; }
        
    }
}
