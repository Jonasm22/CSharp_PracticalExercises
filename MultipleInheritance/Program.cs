namespace MultipleInheritance
{

   public interface IPrintable
    {
        void Print();
    }

    public  interface IScannable
    {
        void Scan();
    }
    
    public class MultipleFunctionPrinter : IPrintable , IScannable
    {
        public void Print()
        {
            Console.WriteLine("Printing Document");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning Document");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            MultipleFunctionPrinter printer = new MultipleFunctionPrinter();    
            printer.Print();
            printer.Scan();
        }
    }
}
