using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipaasusysteem
{
    class HeadCleaner : Employee
    {
        public HeadCleaner()
        {
            Title = "Head Cleaner";
            RightsToRooms = new string[] { "HeadDoor", "Kitchen",
                "DataProcessingRoom", "DevelopersRoom", "BossRoom" };
        }
    }
}
