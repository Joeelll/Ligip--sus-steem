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
                case "cleaner":
                    var Cleaner = new Cleaner();
                    JobTitle = "Cleaner";
                    break;
                case "head cleaner":
                    var HeadCleaner = new HeadCleaner();
                    break;
                case "data processor":
                    var DataProcessor = new DataProcessor();
                    break;
                case "junior developer":
                    var JuniorDeveloper = new JuniorDeveloper();
                    break;
                case "senior developer":
                    var SeniorDeveloper = new SeniorDeveloper();
                    break;
                case "boss":
                    var Boss = new Boss();
                    break;
            }
            Console.Clear();

            Console.WriteLine("Do you want to enter the office? (Y/N)");
            userInput = Console.ReadLine();
            Console.Clear();
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
