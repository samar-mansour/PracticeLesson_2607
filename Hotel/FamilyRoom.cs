using PracticeLesson2607;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class FamilyRoom : Room
    {
        public FamilyRoom(int roomNumber, float price):base(roomNumber, price)
        {
            
        }
        protected override void SetPrice()
        {
            this.price = 100;
            DateTime now = DateTime.Now;
            for (int i = 1; i < 12; i++)
            {
                if (i == 7 || i == 8)
                {
                    float newPrice = this.price + 25;
                    Console.WriteLine($"Price in {now.ToString("MMM")}: {newPrice}$");
                    now.AddMonths(1);
                }
            }
            Console.WriteLine($"Standard price: {this.price}$");
        }
        protected override void SetFeatuers()
        {
            features = "Four Beds: king size bed + Three Twin beds, Tv, AC, Balconey, Minibar";
            Console.WriteLine($"Room features: {features}");
        }
    }
}
