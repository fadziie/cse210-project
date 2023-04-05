using System;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Elm St", "Othertown", "NY", "67890");
        Address address3 = new Address("789 Oak St", "Somewhere", "FL", "54321");

        Lecture lecture = new Lecture("The Future of Technology", "A talk about the latest innovations in technology", new DateTime(2023, 5, 1, 14, 0, 0), address1, "John Smith", 50);
        Reception reception = new Reception("Networking Mixer", "An opportunity to meet and mingle with other professionals", new DateTime(2023, 6, 1, 18, 0, 0), address2, "rsvp@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Community Picnic", "A fun-filled day of food, games, and community", new DateTime(2023, 7, 1, 12 , 0, 0),address3 );

        Console.WriteLine("Event Details:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(gathering.GetFullDetails());

        Console.ReadLine();
    }
}







