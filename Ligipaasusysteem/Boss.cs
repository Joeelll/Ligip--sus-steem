using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipaasusysteem
{
    class Boss : Employee
    {
        public Boss()
        {
            Title = "Boss";
            RightsToRooms = new string[] { "HeadDoor", "Kitchen",
                "DataProcessingRoom", "DevelopersRoom", "BossRoom" };

        }
    }
}
