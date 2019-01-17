using System;

namespace observersample
{
    public class PickList : Observer
    {
        public override void Update1()
        {
           Console.WriteLine("Picklist 1 in statüsü değişti.");
        }

        public override void Update2()
        {
           Console.WriteLine("Picklist 2 in statüsü değişti.");
        }
    }
}