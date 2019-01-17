using System;
using System.Collections.Generic;

namespace observersample
{
    public class TaskSubject
    {
        private WareHouseTask _task;
        public TaskSubject(WareHouseTask task)
        {
            _task = task;
        }
        private List<Observer> _observers = new List<Observer>();
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }
        private void Notify(Func<WareHouseTask, bool> changeStatusFunc, Action action)
        {
            var result = changeStatusFunc.Invoke(_task);

            if (result)
                action.Invoke();
        }
        public void ChangeStatus()
        {
            this.Notify(x => x.StatusId == 10, new Action(Update1));

            this.Notify(x => x.TypeId == 1, new Action(Update2));
        }
        
        public void Update1()
        {
            _observers.ForEach(o => { o.Update1(); });
        }
        public void Update2()
        {
            _observers.ForEach(o => { o.Update2(); });
        }
    }
}