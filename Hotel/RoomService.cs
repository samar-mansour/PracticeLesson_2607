using PracticeLesson2607;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class RoomService
    {
        internal void CleanRoom(RoomForTwo roomForTwo)
        {
            roomForTwo.SetIsClean(true);
            Console.WriteLine($"{roomForTwo.GetFeatures()} have been cleaned");
        }

        internal void CleanRoom(FamilyRoom familyRoom)
        {
            familyRoom.SetIsClean(true);
            Console.WriteLine($"{familyRoom.GetFeatures()} have been cleaned");
        }

        internal void CleanRoom(Suite suite)
        {
            suite.SetIsClean(true);
            Console.WriteLine($"{suite.GetFeatures()} have been cleaned");
        }
    }
}
