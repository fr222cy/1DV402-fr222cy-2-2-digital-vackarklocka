using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_digital_vackarklocka
{

    class Program
    {


        static void Main(string[] args)
        {

            //Test 1
            ViewTestHeader("Test 1. \nTest av standarnkonstruktorn.");
            AlarmClock testC1 = new AlarmClock();
            Console.WriteLine(testC1.ToString());

            //Test 2
            ViewTestHeader("Test 2. \nTest av konstruktorn med två parametrar (9, 42).");
            AlarmClock testC2 = new AlarmClock(9, 42);
            Console.WriteLine(testC2.ToString());

            //Test 3
            ViewTestHeader("Test 3. \nTest av konstruktorn med fyra parametrar (13, 42 ,7 ,35).");
            AlarmClock testC3 = new AlarmClock(13, 24, 7, 35);
            Console.WriteLine(testC3.ToString());

            //Test 4
            ViewTestHeader("Test 4. \nStäller befintligt AlarmClock-Object till 23:58 och låter den gå 13 minuter.");
            AlarmClock testC4 = new AlarmClock(23, 58, 7, 35);
            Run(testC4, 13);
            Console.WriteLine(testC4.ToString());

            //Test 5
            ViewTestHeader("Test 5. \nStäller befintligt AlarmClock-Object till tiden 6:12 och alarmtiden till 6:15\noch låter den gå till 6 minuter.");
            AlarmClock testC5 = new AlarmClock(6, 13, 6, 15);
            Run(testC5, 6);
            Console.WriteLine(testC5.ToString());

            //Test 6
            ViewTestHeader("Test 6. \nTestar egenskaperna så att undantag kastas då tid och alarmtid \ntilldelas felaktiga värden.");
            AlarmClock testC6 = new AlarmClock();
            


            try
            {
                testC6.Hour = 24;

            }
            catch (ArgumentException)
            {
                ViewErrorMessage("Timmen är inte i intervallet 0-23.");
            }
            try
            {
                testC6.Minute = 61;
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("Timmen är inte i intervallet 0-23.");
            }
            try
            {
                testC6.AlarmHour = 24;
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("AlarmTimmen är inte i intervallet 0-23.");
            }
            try
            {
                testC6.AlarmMinute = 61;
            }
            catch (ArgumentException)
            {
                ViewErrorMessage("Alarmminuten är inte i intervallet 0-59.");
            }

            //Test 7
            ViewTestHeader("Test 7. \nTestar konstruktorer så att undantag kastas då tid och alarmtid \ntilldelas felaktiga värden.");
           
            try
            {
                AlarmClock testC7 = new AlarmClock(24, 0, 0, 0);
            }
            catch
            {
                ViewErrorMessage("Timmen är inte i intervallet 0-23.");
            }
            try
            {
                AlarmClock testC7 = new AlarmClock(0, 61, 0, 0);
            }
            catch
            {
                ViewErrorMessage("Minuten är inte i intervallet 0-59");
            }
            try
            {
                AlarmClock testC7 = new AlarmClock(0, 0, 24, 0);
            }
            catch
            {
                ViewErrorMessage("Alarmtimmen är inte i intervallet 0-23.");
            }
            try
            {
                AlarmClock testC7 = new AlarmClock(0, 0, 0, 61);
            }
            catch
            {
                ViewErrorMessage("Alarmminuten är inte i intervallet 0-59.");
            }
        }
        //Run Metoden
        static void Run(AlarmClock test, int minutes)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║       Väckarklockan URLED <TM>       ║ ");
            Console.WriteLine(" ║        Modellnr.:1DV402S2L2A         ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine();

            for (int i = 0; i < minutes; i++)
            {
                if (test.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine((test.ToString()) + "♫" +"     BEEP BEEP BEEP!!!");
                    Console.ResetColor();
                }
                else
                {
                   Console.WriteLine(test.ToString());
                }
            }

        }

        static void ViewErrorMessage(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        static void ViewTestHeader(string header)
        {
            
            Console.Write("==================================\n");
            Console.WriteLine(header);
            Console.WriteLine();
            
        }
    }
}
