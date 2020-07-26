using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson2607
{
    public class RoomForTwo : Room
    {
        public RoomForTwo(int roomNumber, float price) : base(roomNumber, price)
        {

        }
        protected override void SetFeatuers()
        {
            features = "Two Beds, Tv, AC, Balconey, Minibar";
            Console.WriteLine($"Room features: {features}");
        }
    }
}
