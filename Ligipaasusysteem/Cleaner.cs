using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipaasusysteem
{
    class Cleaner : Employee
    {
        public Cleaner()
        {
            Title = "Cleaner";
            RightsToRooms = new string[] { "HeadDoor", "Kitchen",
                "DataProcessingRoom", "DevelopersRoom" };
        }
    }
}
