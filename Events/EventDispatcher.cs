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
            Handlers = new Dictionary<Type, IList<IHandler>>();
        }

        public void AddHandler(Type eventType, IHandler handler)
        {
            if (!Handlers.ContainsKey(eventType))
                Handlers.Add(eventType, new List<IHandler>());

            Handlers[eventType].Add(handler);
        }

        public Dictionary<Type, IList<IHandler>> Handlers;

        public void Dispatch(object myEvent)
        {
            foreach (var handler in Handlers[myEvent.GetType()])
            {
                handler.Handle(myEvent);
            }
        }
    }

    public interface IHandler 
    {
        void Handle(dynamic e);
    }
}
