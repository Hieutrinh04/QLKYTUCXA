using ChuongTrinhQuanLyKyTucXa_Vertion5.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuongTrinhQuanLyKyTucXa_Vertion5.DAO
{
    public class roomsDAO
    {
        private readonly appCONTEXT appContext;
        public roomsDAO()
        {
            appContext = appCONTEXT.GetInstance();
        }
        
        public List<rooms> GetRooms()
        {
            return appContext.rooms.ToList();
        }

        public rooms getRoom(long  roomId)
        {
            rooms room = appContext.rooms.FirstOrDefault(r => r.roomNo.Equals(roomId));
            return room;
        }

        public void insert(rooms room)
        {
            appContext.rooms.InsertOnSubmit(room);
            appContext.SubmitChanges();
        }

        public void delete(long roomId)
        {
            rooms rooms = appContext.rooms.FirstOrDefault(r => r.roomNo.Equals(roomId));

            if (rooms == null)
            {
                return;
            }
            appContext.rooms.DeleteOnSubmit(rooms);
            appContext.SubmitChanges();

        }

        public void update(rooms room)
        {
            rooms rooms = appContext.rooms.FirstOrDefault(r => r.roomNo.Equals(room.roomNo));

            if (rooms == null)
            {
                return;
            }
            rooms.roomStatus = room.roomStatus.ToString();
            appContext.SubmitChanges();
        }

        public List<rooms> FindByStatusAndBooked(string status, string booked)
        {
            var matchedRooms = appContext.rooms
                                         .Where(r => r.roomStatus == status && r.Booked == booked)
                                         .ToList();
            return matchedRooms;
        }

    }
}
