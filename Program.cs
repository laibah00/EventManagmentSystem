using System;

class Program
{
    static void Main()
    {
        var eventRepository = new EventRepository();
        var eventService = new EventService(eventRepository);

        Console.WriteLine("Welcome to the Event Management System!");

        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Add Event");
            Console.WriteLine("2. View Events");
            Console.WriteLine("3. Exit");

            int choice = InputHelper.GetChoice();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the event name: ");
                    string eventName = Console.ReadLine();
                    eventService.AddEvent(eventName);
                    Console.WriteLine($"Event '{eventName}' added successfully!");
                    break;
                case 2:
                    ViewEvents(eventService);
                    break;
                case 3:
                    Console.WriteLine("Exiting Event Management System. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void ViewEvents(EventService eventService)
    {
        var events = eventService.GetEvents();
        Console.WriteLine("\nList of Events:");
        
        if (events.Count == 0)
        {
            Console.WriteLine("No events available.");
        }
        else
        {
            foreach (var e in events)
            {
                Console.WriteLine($"{e.Id}. {e.Name}");
            }
        }
    }
}
