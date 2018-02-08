using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ligipaasusysteem
{
    public abstract class Employee
    {
        public static string Title;
        public static string[] RightsToRooms;

        public static void EnterRoom(string InputRoom)
        {
            foreach (string Room in RightsToRooms)
            {
                if (Room == InputRoom)
                {
                    Console.WriteLine("You successfully enter " + Room + " as a " + Title);
                    Thread.Sleep(2000);
                    Console.Clear();
                    Rooms.ChooseRoomToEnter();
                }
            }
            Console.WriteLine("You don't have enough rights to enter " + InputRoom + " as a " + Title);
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
