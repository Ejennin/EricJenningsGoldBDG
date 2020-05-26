using RepoCompOut_Repo;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoCompOut_Console
{
    class ProgramUI
    {
        //private readonly List<CompOutContent> _compOutContent = new List<CompOutContent>();
        private readonly CompOutRepo _compOutRepo = new CompOutRepo();
        private List<CompOutContent> _compOutContent;

        //Method that runs the application
        public void Run()
        {
            SeedRepo();
            Menu();
        }
        //menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                //Display options to the user
                Console.WriteLine("Select a menu option:\n " +
                    "1. View all Outings\n " +
                    "2. Create New Outings\n " +
                    "3. View Combined cost for all Outings\n " +
                    "4. View Cost of Outings by Type\n " +
                    "5. Exit");
                //get the users input
                Console.WriteLine("What would you like to do? Please enter a number 1-5");
                
                string input = Console.ReadLine();
                //Evaluate the users input
                switch (input)
                {
                    case "1":
                        ViewAllOutings();

                        break;
                    case "2":
                        AddNewOutings();
                        
                        break;

                    case "3":
                        GetTotalCost();
                        Console.WriteLine();
                        Console.ReadLine();
                        break;

                    case "4":
                        CostByOutingType();
                        //Console.WriteLine(" Enter a Type of Outing");
                        Console.ReadLine();

                        break;

                    case "5":
                        Console.WriteLine("GoodBye");
                        Console.ReadLine();
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;


                }
            }
        }

        private void ViewAllOutings()
        {
            Console.Clear();
            List<CompOutContent> listOfOutings = _compOutRepo.GetCompOutContent();
            foreach (CompOutContent content in listOfOutings)
            {
                Console.WriteLine($"{content.EventType}\n " +
                    $"{content.EventDate}\n" +
                    $"{content.AttendCount}\n" +
                    $"{content.CostOfEvent}\n" +
                    $"{content.TotCostPerson}");
            }
        }
        private void AddNewOutings()
        {
            Console.Clear();


            
            Console.WriteLine("What type of event would you like to add?");
            string eventType = Console.ReadLine().ToLower();

            
            Console.WriteLine("What is the Date of the event? enter as MM/dd/yyyy");
            //accepts date in MM/dd/yyyy format
            DateTime eventDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("How many people attended the event?");
            int attendCount = Convert.ToInt16(Console.ReadLine());

            //Console.WriteLine("What was the Cost of the event?");
            //double costOfEvent = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the Cost Person?");
            double totCostPerson = Convert.ToDouble(Console.ReadLine());

            CompOutContent compOutContentItem = new CompOutContent( attendCount, totCostPerson, eventType, eventDate);

            _compOutRepo.AddCompOuting(compOutContentItem);

            Console.WriteLine("New Outing Added.");
            Console.ReadKey();

        }
        private void GetTotalCost()
        {
            Console.Clear();
            
                List<CompOutContent> listOfOutings = _compOutRepo.GetCompOutContent();
                double totcost = 0;
                foreach (CompOutContent compOutContent in listOfOutings)
                {
                    totcost += compOutContent.CostOfEvent;
                }
                
            

            Console.WriteLine($"{totcost}");
                
        }
        private void CostByOutingType()
        {
            
            
            Console.Clear();
            List<CompOutContent> listOfOutings = _compOutRepo.GetCompOutContent();
            double totcost = 0;
            Console.WriteLine("What event type would you like the total cost of?");
            string userinput = Console.ReadLine();
            foreach (CompOutContent compOutContent in listOfOutings)
            
            {

                if (compOutContent.EventType == userinput.ToLower())
                {
                    totcost += compOutContent.CostOfEvent;
                }

            }
            Console.WriteLine($"{totcost}"); 



            Console.ReadLine();


        }
        public void SeedRepo()
        {
            CompOutContent bowling = new CompOutContent(25, 50.00, "Bowling", new DateTime(2020, 05, 07));
            _compOutRepo.AddCompOuting(bowling);
        }



    }
}