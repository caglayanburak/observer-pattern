using System;
using System.Collections.Generic;

namespace ObserverSample
{
    public class TaskSubject
    {
        private readonly WareHouseTask _task;
        private readonly List<Observer> _observers = new List<Observer>();

        public TaskSubject(WareHouseTask task)
        {
            _task = task;
        }

        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void ChangeStatus()
        {
            this.Notify(x => x.StatusId == 10, Update1);
            this.Notify(x => x.TypeId == 1, Update2);
        }

        public void Update1()
        {
            _observers.ForEach(o => o.Update1());
        }

        public void Update2()
        {
            _observers.ForEach(o => o.Update2());
        }

        private void Notify(Func<WareHouseTask, bool> changeStatusFunc, Action action)
        {
            if (changeStatusFunc(_task))
            {
                action();
            }
        }
    }
}
