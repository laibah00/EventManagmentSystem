using System;
using System.Collections.Generic;

public class EventService
{
    private EventRepository eventRepository;

    public EventService(EventRepository eventRepository)
    {
        this.eventRepository = eventRepository;
    }

    public void AddEvent(string eventName)
    {
        eventRepository.AddEvent(eventName);
    }

    public List<Event> GetEvents()
    {
        return eventRepository.GetEvents();
    }
}
