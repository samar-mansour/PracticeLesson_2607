using Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson2607
{
    public abstract class Room
    {
        protected int roomNumber;
        protected float price;
        protected Guest guest;
        protected bool isClean;
        protected string features;

        public Room(int roomNumber, float price)
        {
            this.roomNumber = roomNumber;
            this.price = price;

            this.SetFeatuers();
            this.SetPrice();
        }
        public void SetGest(Guest guest)
        {
            this.guest = guest;
        }

        protected virtual void SetPrice()
        {
            this.price = 50;
            DateTime dt = DateTime.Now;
            if (dt.Month == 7 || dt.Month == 8)
            {
                float newPrice = this.price + 25;
                Console.WriteLine($"Price in {dt}: {newPrice}$");
            }
            
            Console.WriteLine($"Standard price: {this.price}$");
        }

        protected abstract void SetFeatuers();

        public int GetRoomNumber()
        {
            return this.roomNumber;
        }

        public float GetPrice()
        {
            return this.price;
        }

        public Guest GetGuest()
        {
            return this.guest;
        }

        public bool IsClean()
        {
            return this.isClean;
        }
        public void SetIsClean(bool clean)
        {
            this.isClean = clean;
        }

        public string GetFeatures()
        {
            return this.features;
        }

        public override string ToString()
        {
            return $"{base.ToString()} informations:\n Guest: {this.GetGuest()}\n Features: {GetFeatures()}\n Room Number: {this.GetRoomNumber()}\n Price: {this.GetPrice()}$";
        }
    }
}
