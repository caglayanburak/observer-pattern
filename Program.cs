using System;

namespace ObserverSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var task = new TaskSubject(
                new WareHouseTask { 
                    StatusId = 10, 
                    JobId = 11, 
                    TypeId = 2 
                }
            );
            
            task.Attach(new PickList());
            task.Attach(new Job());

            task.ChangeStatus();

            Console.ReadLine();
        }
    }
}
