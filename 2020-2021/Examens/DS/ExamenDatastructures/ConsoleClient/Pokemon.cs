
namespace ConsoleClient
{
    public class Pokemon 
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public static string NameSortMethod { get; set; } = "ASC";

        public override string ToString()
        {
            return $"{Name}, my height is {Height} and Weight is {Weight}";
        }
    }
}
