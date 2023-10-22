using System.Text;
using Hosting_System_of_a_Hotel_at_C_Sharp.Model;

Console.OutputEncoding = Encoding.UTF8;

// Create guest models and register on the guest list..
List<Person> guests = new List<Person>();

Person person1 = new Person(name: "guest 1");
Person person2 = new Person(name: "guest 2");

guests.Add(person1);
guests.Add(person2);

// Create the suite
Suite suite = new Suite(typeSuite: "Premium", capacity: 2, dailyValue: 30);

// Create a new reservation, passing the suite and guests..
Reservation reservation = new Reservation(reservedDay: 12);
reservation.RegisterSuite(suite);
reservation.RegisterGuests(guests);

// Displays the number of guests and the daily rate..
Console.WriteLine($"Guests: {reservation.GetQuantityGuests()}");
Console.WriteLine($"Daily value: {reservation.CalculateDailyValue()}");
