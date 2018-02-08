using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipaasusysteem
{
    public abstract class Rooms
    {
        public string Room;

        public static void ChooseRoomToEnter()
        {
            string InputRoom;

            while (true)
            {
                Console.WriteLine("Which room do you want to enter?");
                Console.WriteLine(
                    "Kitchen" +
                    "\nData Processing Room" +
                    "\nDevelopers Room" +
                    "\nBoss Room");
                string userInput = Console.ReadLine();
                Console.Clear();
                switch (userInput.ToLower())
                {
                    case "kitchen":
                        InputRoom = "Kitchen"; 
                        Employee.EnterRoom(InputRoom);
                        break;
                    case "data processing room":
                        InputRoom = "Data Processing Room";
                        Employee.EnterRoom(InputRoom);
                        break;
                    case "developers room":
                        InputRoom = "Developers Room";
                        Employee.EnterRoom(InputRoom);
                        break;
                    case "boss room":
                        InputRoom = "Boss Room";
                        Employee.EnterRoom(InputRoom);
                        break;
                }
                Console.Clear();
            }
        }
    
    }
}
