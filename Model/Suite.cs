namespace Hosting_System_of_a_Hotel_at_C_Sharp.Model
{
    public class Suite
    {
        public Suite() {}   

        public Suite(string typeSuite, int capacity, decimal dailyValue)
        {
            TypeSuite = typeSuite;
            Capacity = capacity;
            DailyValue = dailyValue;
        }

        public string TypeSuite { get; set; }
        public int Capacity { get; set; }
        public decimal DailyValue { get; set; }
    }
}