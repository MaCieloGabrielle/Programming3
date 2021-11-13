using System;

namespace TimeTrack
{
    class LateTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EMPLOYEE TIME TRACKING SYSTEM");
            Console.WriteLine($"Date:  {DateTime.Today.ToShortDateString()}");

            Console.Write("To log your time-in enter your employee ID:");
            string employeeId = Console.ReadLine();

            TimeSpan timein = new TimeSpan(9,36,0);
            Console.WriteLine($"Your login time is recorded: {timein}");
            
            TimeSpan regularHoursBegin = new TimeSpan(8, 0, 0);
            TimeSpan late = new TimeSpan(0,0,0);

          
          if (timein > regularHoursBegin) 
            {
                late = timein - regularHoursBegin;
                Console.WriteLine("LATE");
                Console.WriteLine($"Your late hours is: {late}");
            }
            
            else
            {
             Console.WriteLine("You are just in time");  
            }

            Console.WriteLine("********************************");
            Console.Write("To log your time-out enter your employee id:");
            employeeId = Console.ReadLine();
            
            TimeSpan timeOut = new TimeSpan(17,0, 0);
            
            TimeSpan lunchBreak = new TimeSpan(1, 0, 0);
            TimeSpan totalHours = (timeOut - timein) - lunchBreak;
            Console.WriteLine($"Your logout time is recorded: {timeOut}");

            Console.WriteLine($"Your total hours worked is: {totalHours}");

            
    }
  }
}