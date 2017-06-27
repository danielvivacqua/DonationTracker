using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonationTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a receipt (on console)
            //Ask how many donations
            //Get details of the money donated
            Console.WriteLine("Welcome to your Donation Tracker!");
            Console.WriteLine("Please enter the information below as prompted.");

            //How many ones
            Console.WriteLine("How many $1 bills do you have for me?");
            int ones = int.Parse(Console.ReadLine());
            int onesInDollars = ones * 1;

            //How many fives
            Console.WriteLine("How many $5 bills do you have for me?");
            int fives = int.Parse(Console.ReadLine());
            int fivesInDollars = fives * 5;

            //How many tens
            Console.WriteLine("How many $10 bills do you have for me?");
            int tens = int.Parse(Console.ReadLine());
            int tensInDollars = tens * 10;

            //How many twenties
            Console.WriteLine("How many $20 bills do you have for me?");
            int twenties = int.Parse(Console.ReadLine());
            int twentiesInDollars = twenties * 20;

            //How many fifties
            Console.WriteLine("How many $50 bills do you have for me?");
            int fifties = int.Parse(Console.ReadLine());
            int fiftiesInDollars = fifties * 50;

            //How many hundreds
            Console.WriteLine("How many $100 bills do you have for me?");
            int hundreds = int.Parse(Console.ReadLine());
            int hundredsInDollars = hundreds * 100;

            //How many quarters
            Console.WriteLine("How many quarters do you have for me?");
            int quarters = int.Parse(Console.ReadLine());
            double quartersInDollars = quarters * .25d;

            //Ask for personal information
            //Name
            Console.WriteLine("Please tell me your name.");
            string yourName = Console.ReadLine();

            //Address
            Console.WriteLine("What is your address?");
            string yourAddress = Console.ReadLine();

            //Email address
            Console.WriteLine("What is your email address?");
            string yourEmail = Console.ReadLine();

            //Fiscal year
            Console.WriteLine("What is the current fiscal year? If you don't know, look it up.");
            string fiscalYear = Console.ReadLine();

            //Print their personal information 
            Console.WriteLine("Your name is " + yourName);
            Console.WriteLine("Your address is " + yourAddress);
            Console.WriteLine("Your email address is " + yourEmail);
            Console.WriteLine("The fiscal year is " + fiscalYear);

            //and the donation amount
            double donationAmount = (onesInDollars + fivesInDollars + tensInDollars + twentiesInDollars + fiftiesInDollars + hundredsInDollars + quartersInDollars);
            Console.WriteLine("Your donation total was $" + donationAmount);
            //Be polite
            Console.WriteLine("Thank you for your donation.");
        }
    }
}
