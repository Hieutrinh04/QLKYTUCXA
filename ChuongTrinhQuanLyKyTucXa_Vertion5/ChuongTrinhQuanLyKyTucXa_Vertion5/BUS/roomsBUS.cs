using ChuongTrinhQuanLyKyTucXa_Vertion5.DAO;
using ChuongTrinhQuanLyKyTucXa_Vertion5.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5.BUS
{
    public class roomsBUS
    {
        private roomsDAO roomsDAO;

        public roomsBUS()
        {
            roomsDAO = new roomsDAO();
        }

        public List<rooms> GetRooms()
        {
            return roomsDAO.GetRooms();
        }

        public rooms getRoom(int id)
        {
            return roomsDAO.getRoom(id);
        }

        public void insert(rooms room)
        {
            roomsDAO.insert(room);
        }

        public void delete(long roomId)
        {
            roomsDAO.delete(roomId);
        }

        public void update(rooms room)
        {
            roomsDAO.update(room);
        }

        public List<rooms> FindByStatusAnhBooked(string status, string booked)
        {
            return roomsDAO.FindByStatusAndBooked(status, booked);
        }
    }
}
