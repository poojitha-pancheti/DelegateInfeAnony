using System;

namespace DelegInfeAnony
{
    class Program
    {

        static void Main(string[] args)
        {
            var worker = new Worker();
            //worker.WorkPerformed += Worker_WorkPerformed;
            //worker.WorkCompleted += Worker_WorkCompleted;
            //worker.WorkCompleted -= Worker_WorkCompleted;
            
            worker.WorkPerformed += delegate(object sender, WorkPerformedEventArgs e) 
            {
                Console.WriteLine("Hours worked : " + e.Hours + " " + e.WorkType);
            };
            worker.WorkCompleted += delegate (object sender, EventArgs ee)
            {
                Console.WriteLine("Work is done");
            };

            worker.DoWork(8, WorkType.GenerateReports);

            Console.Read();
        }

        //static void Worker_WorkPerformed(object sender, WorkPerformedEventArgs e)
        //{
        //    Console.WriteLine("Hours worked : " + e.Hours + " " + e.WorkType);
        //}
        //static void Worker_WorkCompleted(object sender, EventArgs e)
        //{
        //    Console.WriteLine("Work is done");

        //}

    }
    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateReports
    }
}

