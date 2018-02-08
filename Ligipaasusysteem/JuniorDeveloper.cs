using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipaasusysteem
{
    class JuniorDeveloper : Developer
    {
        public JuniorDeveloper()
        {
            Title = "Junior Developer";
            RightsToRooms = new string[] { "HeadDoor", "Kitchen",
                "DevelopersRoom" };

        }
    }
}
