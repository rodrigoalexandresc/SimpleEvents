using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class EventDispatcher
    {
        public static EventDispatcher _instance;

        public static EventDispatcher Instance()
        {
            if (_instance == null)
                _instance = new EventDispatcher();
            return _instance;
        }

        public EventDispatcher()
        {
            Handlers = new Dictionary<Type, Action<object>>();
        }

        public Dictionary<Type, Action<object>> Handlers;

        public void Dispatch(object myEvent)
        {
            foreach (var handler in Handlers.Where(o => o.Key == myEvent.GetType()))
            {
                handler.Value.Invoke(myEvent);
            }
        }
    }
}
