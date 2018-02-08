using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipaasusysteem
{
    class SeniorDeveloper : Developer
    {
        public SeniorDeveloper()
        {
            Title = "Senior Developer";
            RightsToRooms = new string[] { "Head Door", "Kitchen",
                "Data Processing Room", "Developers Room", "Boss Room" };

        }
    }
}
