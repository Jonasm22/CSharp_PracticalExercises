namespace DependendyInjectionUsingSetter
{
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("Hammering Nails!");
        }

    }

    public class Saw
    {
        public void Use()
        {
            Console.WriteLine("Sawing wood");
        }
    }

    public class Builder
    {
        public Hammer Hammer {  get; set; }
        public Saw Saw { get; set; }

        public void BuilHouse()
        {
            Hammer.Use();
            Saw.Use();
            Console.WriteLine("House Built");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder();

            builder.Hammer = hammer; //Inject dependencies via Setters
            builder.Saw = saw;//Inject dependencies via Setters

            builder.BuilHouse();

            Console.ReadKey();

        }
    }
}
