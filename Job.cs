using System;

namespace observersample
{
    public class Job : Observer
    {
        public override void Update1()
        {
            Console.WriteLine("Job 1 ın statüsü değişti.");
        }

         public override void Update2()
        {
            Console.WriteLine("Job 2 ın statüsü değişti.");
        }
    }
}