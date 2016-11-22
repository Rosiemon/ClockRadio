using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
  {
        public class ClockRadio
    {
        public string currentTime;
        public bool alarmState;
        public string currentStation;


        public void CurrentTime()
        {
            currentTime = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine("The current time is {0}", currentTime);
        }


        public void ChangeSettings()
        {
            ClockRadio changeSettings = new ClockRadio();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Select [1] to set the ALARM");
            Console.WriteLine("Select [2] to set the RADIO STATION");
            Console.WriteLine("Select [3] to POWER OFF your CLOCK RADIO");
            string userImput = Console.ReadLine();

            if (userImput == "1")
            {
                changeSettings.SetAlarm();
                changeSettings.ChangeSettings();

            }
            else if (userImput == "2")
            {
                changeSettings.SetStation();
                changeSettings.ChangeSettings();
            }
            else if (userImput == "3")
            {
                changeSettings.PowerOff();
            }
            else
            {
                Console.WriteLine("INVALID INPUT");
                ChangeSettings();
            }
        }


        public void SetAlarm()
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Do you want to turn the alarm to ON?");
            string userImput = Console.ReadLine();

            if (userImput == "yes" || userImput == "y" || userImput == "Yes" || userImput == "Y" || userImput == "YES")
            {
                Console.WriteLine("**********************************************************");
                Console.WriteLine("What station would you like to set the ALARM to?");
                string station = Console.ReadLine();
                Console.WriteLine("**********************************************************");
                Console.WriteLine("Your ALARM station is set to station {0}", station);
                Console.WriteLine("**********************************************************");
            }
            else if (userImput == "no" || userImput == "n" || userImput == "No" || userImput == "N" || userImput == "NO")
            {
                Console.WriteLine("**********************************************************");
                Console.WriteLine("Your ALARM is turned OFf");
                Console.WriteLine("**********************************************************");
            }
            else
            {
                Console.WriteLine("INVALID INPUT select [YES] or [NO]");
                SetAlarm();
            }
        }


        public void SetStation()
        {
            ClockRadio changeSettings = new ClockRadio();

            Console.WriteLine("**********************************************************");
            Console.WriteLine("Would you like to listen to the RADIO now?");
            string userImput = Console.ReadLine();

            if (userImput == "yes" || userImput == "y" || userImput == "Yes" || userImput == "Y" || userImput == "YES")
            {
                Console.WriteLine("**********************************************************");
                Console.WriteLine("What RADIO STATION would you like to JAM out to?");
                string SetStation = Console.ReadLine();
                Console.WriteLine("**********************************************************");
                Console.WriteLine("Your current RADIO STATION is {0}. JAM ON!!!", SetStation);
                Console.WriteLine("**********************************************************");

            }
            else if (userImput == "no" || userImput == "n" || userImput == "No" || userImput == "N" || userImput == "NO")
            {
                Console.WriteLine("**********************************************************");
                Console.WriteLine("Your RADIO is turned OFF!");
                Console.WriteLine("**********************************************************");
                changeSettings.ChangeSettings();
            }
            else
            {
                Console.WriteLine("INVALID INPUT select [YES] or [NO]");
                SetStation();
            }
        }


            public void PowerOff()
        {
            Console.WriteLine("Do you want to turn the CLOCK RADIO [off]?");
            string userImput = Console.ReadLine();
            ClockRadio changeSettings = new ClockRadio();

            if (userImput == "yes" || userImput == "y" || userImput == "Yes" || userImput == "Y" || userImput == "YES")
            {
                Console.WriteLine("**********************************************************");
                Console.WriteLine("Your RADIO will be turned OFf in 6 .. 5 .. 4 ..");
                Console.WriteLine("........3............2....................1...............");
                Console.WriteLine("**********************************************************");
            }
            else if (userImput == "no" || userImput == "n" || userImput == "No" || userImput == "N" || userImput == "NO")
            {
                Console.WriteLine("**********************************************************");
                changeSettings.ChangeSettings();
            }
            else
            {
                Console.WriteLine("INVALID INPUT select [YES] or [NO]");
                PowerOff();
            }

        }
    }
}