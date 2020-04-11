using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    public class Publisher
    {
        private List<ISubscriber> subscribers = new List<ISubscriber>();
        private bool state = false;

        public void Subscribe(ISubscriber substriber)
        {
            this.subscribers.Add(substriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            this.subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (ISubscriber subscriber in subscribers)
            {
                subscriber.Update();
            }
        }

        public void UpdateState()
        {
            this.state = !state;
            this.NotifySubscribers();
        }

    }
}
