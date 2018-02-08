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
                    "Kitchen",
                    "\nData Processing Room",
                    "\nDevelopers Room",
                    "\nBoss Room");
                string userInput = Console.ReadLine();
                switch (userInput.ToLower())
                {
                    case "kitchen":
                        InputRoom = "Kitchen"; 
                        Employee.EnterRoom(InputRoom);
                        break;
                    case "data processing room":
                        InputRoom = "DataProcessingRoom";
                        Employee.EnterRoom(InputRoom);
                        break;
                    case "developers":
                        InputRoom = "DevelopersRoom";
                        Employee.EnterRoom(InputRoom);
                        break;
                    case "boss room":
                        InputRoom = "BossRoom";
                        Employee.EnterRoom(InputRoom);
                        break;
                }
            }
        }
    
    }
}
