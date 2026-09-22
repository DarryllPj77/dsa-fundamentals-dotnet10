namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulation of using Collection for an Array");

            var countries = new[] { "Philippines", "USA", "Canada", "Pakistan", "Afghanistan" };
            IEnumerable<string> enumCountries = countries;
            Console.WriteLine("Enumerable");

            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            ICollection<string> colCountries = new List<string>(countries);
            colCountries.Add("Australia");
            colCountries.Remove("USA");
            Console.WriteLine("*********************");
            Console.WriteLine("Collection");
            foreach (var country in colCountries)
            {
                Console.WriteLine(country);
            }
        }
    }
}
