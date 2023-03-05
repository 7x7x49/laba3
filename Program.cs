using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            dw dayOfWeek = dw.unknownDay;
            string time = "the time is not specified";

            Console.WriteLine("Enter the number of the day of the week:(1-7)");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the hour(0-23):");
            int hour = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    dayOfWeek = dw.monday;
                    break;
                case 2:
                    dayOfWeek = dw.tuesday;
                    break;
                case 3:
                    dayOfWeek = dw.wednesday;
                    break;
                case 4:
                    dayOfWeek = dw.thursday;
                    break;
                case 5:
                    dayOfWeek = dw.friday;
                    break;
                case 6:
                    dayOfWeek = dw.saturday;
                    break;
                case 7:
                    dayOfWeek = dw.sunday;
                    break;
                default: //если не будет совпадений
                    Console.WriteLine("There are only 7 days of the week.");
                    break;
            }
            string str = dayOfWeek.ToString();
            if (hour >= 7 && hour <= 12) //от 7 до 12 - утро
            {
                time = Convert.ToString(t.morning);
            }
            else if (hour >= 13 && hour <= 18) //от 13 до 18 - день
            {
                time = Convert.ToString(t.afternoon);
            }
            else if (hour >= 19 && hour <= 23) //от 19 до 23 - вечер
            {
                time = Convert.ToString(t.evening);
            }
            else if (hour >= 0 && hour <= 6) //от 0 до 6 - ночь
            {
                time = Convert.ToString(t.night);
            }
            else
            {
                Console.WriteLine("There are only 24 hours in a day.");
            }
            Console.WriteLine($"It`s {str}, {time}.");
            Console.ReadKey();
        }
        enum dw
        {
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
            saturday,
            sunday,
            unknownDay
        }
        enum t
        {
            morning,
            afternoon,
            evening,
            night
        }

    }
}