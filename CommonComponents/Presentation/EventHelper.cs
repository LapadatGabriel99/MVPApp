using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonComponents.Presentation;

namespace CommonComponents.Presentation
{
    public static class EventHelper
    {
        public static void RaisedEvent(Object objectRaisedEvent, EventHandler<AccessTypeEventArgs> eventHandlerRaised, AccessTypeEventArgs accessTypeEventArgs)
        {
            eventHandlerRaised?.Invoke(objectRaisedEvent, accessTypeEventArgs);
        }

        public static void RaisedEvent(Object objectRaisedEvent, EventHandler eventHandlerRaised, EventArgs eventArgs)
        {
            eventHandlerRaised?.Invoke(objectRaisedEvent, eventArgs);
        }
    }
}
