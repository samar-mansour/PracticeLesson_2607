using Clients;
using Hotel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLesson2607
{
    class Program
    {
        static void Main(string[] args)
        {
            Guest guest = new Guest(123456,"Gary");
            Reception.CheckIn(guest);
        }
    }
}
