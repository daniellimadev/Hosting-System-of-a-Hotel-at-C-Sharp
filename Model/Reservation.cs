namespace Hosting_System_of_a_Hotel_at_C_Sharp.Model
{
    public class Reservation
    {
        public List<Person> Guests { get; set;}
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reservation() {}
        
        public Reservation(int reservedDay)
        {
            ReservedDays = reservedDay;
        }

        public void RegisterGuests(List<Person> guests)
        {
            if(guests.Any() && guests.Count <= Suite.Capacity)
            {
                Guests = guests;
            }
            else
            {
                if(guests.Count > Suite.Capacity)
                {
                    throw new Exception("Capacity greater than the quantity allowed in the suite!!");
                }
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetQuantityGuests()
        {
            return Guests.Count;
        }

        public decimal CalculateDailyValue()
        {
            decimal value = ReservedDays * Suite.DailyValue;

            if(ReservedDays >= 10)
            {
                decimal discount = Convert.ToDecimal(value * 10 / 100);
                return value - discount;
            }

            return value;
        }
    }
}