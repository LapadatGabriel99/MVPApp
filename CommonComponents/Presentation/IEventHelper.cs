using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonComponents.Presentation
{
    public interface IEventHelper
    {
        void RaisedEvent(Object objectRaisedEvent, EventHandler<AccessTypeEventArgs> eventHandlerRaised, AccessTypeEventArgs accessTypeEventArgs);
        void RaisedEvent(Object objectRaisedEvent, EventHandler eventHandlerRaised, EventArgs eventArgs);
    }
}
