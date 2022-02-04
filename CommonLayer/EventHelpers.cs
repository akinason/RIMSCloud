using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer
{
    public class EventHelpers
    {
        public static void RaiseEvent(object objectRaisingEvent, EventHandler<DataEventArgs> eventHandler, DataEventArgs eventArgs)
        {
            if (eventHandler != null) // Check if there are subscribers to this event.
            {
                eventHandler(objectRaisingEvent, eventArgs); // Notify all subscribers.
            }
        }

        public static void RaiseEvent(object objectRaisingEvent, EventHandler eventHandler, EventArgs eventArgs)
        {
            if (eventHandler != null) // Check if there are subscribers to this event.
            {
                eventHandler(objectRaisingEvent, eventArgs); // Notify all subscribers.
            }
        }

    }
}
