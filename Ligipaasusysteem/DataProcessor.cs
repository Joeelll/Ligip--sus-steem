using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipaasusysteem
{
    class DataProcessor : Employee
    {
        public DataProcessor()
        {
            Title = "Data Processor";
            RightsToRooms = new string[] { "HeadDoor", "Kitchen",
                "DataProcessingRoom" };
        }
    }
}
