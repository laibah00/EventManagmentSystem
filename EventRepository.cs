using System;
using System.Collections.Generic;

public class EventRepository
{
    private static List<Event> events = new List<Event>();
    private static int eventIdCounter = 1;

    public void AddEvent(string eventName)
    {
        var newEvent = new Event { Id = eventIdCounter++, Name = eventName };
        events.Add(newEvent);
    }

    public List<Event> GetEvents()
    {
        return events;
    }
}
