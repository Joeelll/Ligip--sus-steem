﻿using System;
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
            RightsToRooms = new string[] { "HeadDoor", "Kitchen",
                "DataProcessingRoom", "DevelopersRoom", "BossRoom" };

        }
    }
}
