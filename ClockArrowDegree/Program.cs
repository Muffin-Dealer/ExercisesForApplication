using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockArrowDegree
{
    class Program
    {
        static void Main(string[] args)
        {

            char answer = 'y';
            while (answer == 'y')
            {
                execute();
                Console.WriteLine("do you want to continue press 'y' if yes:");
                answer = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
        }

        static public void execute()
        {
            bool correct;
            int hours;
            int minutes;

            //Checking if numbers are entered correctly if not repeats
            do
            {
                correct = true;
                try
                {
                    Console.WriteLine("Iveskite valandas: ");
                    hours = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Iveskite minutes: ");
                    minutes = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    hours = 0;
                    minutes = 0;
                    correct = false;
                    Console.WriteLine("Netinkamai ivedėte laiką");
                }

                if (hours > 24 || hours < 0)
                {
                    Console.WriteLine("iveskite realų laiką");
                    correct = false;
                }
                else if (minutes > 60 || minutes < 0)
                {
                    Console.WriteLine("iveskite realų laiką");
                    correct = false;
                }
            }
            while (!correct);

            //turns minutes in to hour if needed
            if (minutes == 60)
            {
                hours++;
                minutes = 0;
            }
            //turns 24 to 12 hours
            if (hours >= 12)
                hours = hours % 12;

            //counts angles of minutes and hours from 12 o'clock
            decimal hourAngle = (((360 / 12) * hours) + ((decimal)30 / 60 * minutes));
            decimal minuteAngle = (360 / 60) * minutes;

            //gets the angle between the minute and hour anrrows
            decimal AngleBetween = (hourAngle > minuteAngle) 
                ? CalculateAngle(hourAngle, minuteAngle) : CalculateAngle(minuteAngle, hourAngle);


            Console.WriteLine("Kampas tarp valandos ir minutės rodyklių: {0}\u00B0", AngleBetween);

        }
        /// <summary>
        /// subtracts the smaller angle from the bigger one, and returns the angle that is lower than 180
        /// </summary>
        /// <param name="angle1"></param>
        /// <param name="angle2"></param>
        /// <returns></returns>
        static public decimal CalculateAngle(decimal angle1, decimal angle2)
        {
            decimal angle = angle1 - angle2;
            return (angle < 180) ? angle : (360 - angle);
        }


    }
}
