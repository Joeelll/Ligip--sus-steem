using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ligipaasusysteem
{
    class Program
    {
        static void Main(string[] args)
        {
            string JobTitle = "";

            Console.WriteLine("Hello! Please choose, who you are: ");
            Console.WriteLine(
                "Cleaner" +
                "\nHead Cleaner" +
                "\nData Processor" +
                "\nJunior Developer" +
                "\nSenior Developer" +
                "\nBoss");
            string userInput = Console.ReadLine();
            switch (userInput.ToLower())
            {
                case "Cleaner":
                    var Cleaner = new Cleaner();
                    JobTitle = "Cleaner";
                    break;
                case "Head Cleaner":
                    var HeadCleaner = new HeadCleaner();
                    break;
                case "Data Processor":
                    var DataProcessor = new DataProcessor();
                    break;
                case "Junior Developer":
                    var JuniorDeveloper = new JuniorDeveloper();
                    break;
                case "Senior Developer":
                    var SeniorDeveloper = new SeniorDeveloper();
                    break;
                case "Boss":
                    var Boss = new Boss();
                    break;
            }

            Console.WriteLine("Do you want to enter the office? (Y/N)");
            userInput = Console.ReadLine();
            if (userInput.ToLower() == "y")
            {
                Rooms.ChooseRoomToEnter();
            }
            else
            {

            }


        }
    }
}
