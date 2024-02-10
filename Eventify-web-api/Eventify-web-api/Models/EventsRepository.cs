namespace Eventify_web_api.Models
{
    public static class EventsRepository
    {
        private static List<Event> _events = new List<Event>()
        {
         new Event { EventId=1, Name = "First event", Description = "this is first event" },
         new Event { EventId=2, Name = "Second event", Description = "this is second event" },
         new Event { EventId=3, Name = "Third event", Description = "this is third event" }
        };

       public static void AddEvent (Event eevent)    //create----------------------------------
        {
            var maxId = _events.Max( x => x.EventId );
            eevent.EventId = maxId +1;
            _events.Add(eevent);

        }
        public static List<Event> GetEvents() => _events;



        public static Event? GetEventById(int eventId)    //read------------------------------
        {
            var eevent = _events.FirstOrDefault( x => x.EventId == eventId );
            if ( eevent != null )
            {
                return new Event
                {
                    EventId = eevent.EventId,
                    Name = eevent.Name,
                    Description = eevent.Description,
                };
            }
            return null;
        }

        public static void UpdateEvent (int eventId,  Event eevent)   //update-----------------------
        {
            if (eventId != eevent.EventId) return;
            var eventToUpdate = _events.FirstOrDefault(x => x.EventId == eventId);
            if (eventToUpdate != null)
            {
                eventToUpdate.Name = eevent.Name;
                eventToUpdate.Description = eevent.Description;
            }
        }


        public static void DeleteEvent(int eventId)           //delete------------------------------
        {
            var eevent = _events.FirstOrDefault( x => x.EventId == eventId );
            if( eevent != null )
            {
                _events.Remove(eevent);
            }
        }




    }
}
