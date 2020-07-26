using Clients;
using PracticeLesson2607;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public static class Reception
    {
        private const int NUMBER_OF_ROOMS = 100;
        private static int numberOfGusets;
        private static Room[] rooms = new Room[NUMBER_OF_ROOMS];
        private static RoomService roomService = new RoomService();

        public static void CheckIn(Guest guest)
        {
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i].GetGuest() == null)
                {
                    rooms[i].SetGest(guest);
                    numberOfGusets++;
                }
            }
            Console.WriteLine("Unavailable Room");
        }

        public static void Checkout(Room room)
        {
            room.SetGest(null);
            numberOfGusets--;
        }

        public static bool IsRoomFree(Room room)
        {
            if (room.GetGuest() == null)
            {
                return true;
            }
            return false;
        }

        private static void SendRoomService(Room room)
        {
            roomService.CleanRoom(room);
        }
    }
}
