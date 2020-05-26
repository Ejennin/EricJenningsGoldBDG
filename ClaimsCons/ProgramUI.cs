using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimsCons
{
    class ProgramUI
    {
        public void Run()
        {
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
                    "1. See all Claims\n " +
                    "2. Take care of next claim\n " +
                    "3. Enter a new claim\n " +
                    "4. Exit");
                    
                //get the users input
                Console.WriteLine("What would you like to do? Please enter a number 1-4");

                string input = Console.ReadLine();
                //Evaluate the users input
                switch (input)
                {
                    case "1":
                        //ViewAllClaims();

                        break;
                    case "2":
                        //ClaimQue();
                        break;

                    case "3":
                       // NewClaim();
                        break;

                    case "4":
                        Console.WriteLine("GoodBye");
                        //Console.ReadLine();
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;


                }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void ViewAllClaims()
        {

        }

        private void ClaimQue()
        {

        }

        private void NewClaim()
        {

        }



       /* private void SeedClaimsCont()
        {
            ClaimsCont cl1 = new ClaimsCont(1, "Car", "Car accident on 465", 400.00, new DateTime(2018, 11, 11), new DateTime(2018, 05, 05), true);
            ClaimsCont cl2 = new ClaimsCont(2, "Home", "House fire in kitchen", 4000.00, new DateTime(2018, 07, 06), new DateTime(2018, 08, 07), true);
            ClaimsCont cl3 = new ClaimsCont(3, "Theft", "Stolen pancakes", 4.00, new DateTime(2018, 06, 06), new DateTime(2018, 05, 05), false);

            _listOfContent.Add(cl1);
            _listOfContent.Add(cl2);
            _listOfContent.Add(cl3);


        }*/


    }
}