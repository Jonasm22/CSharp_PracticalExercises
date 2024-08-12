namespace StoringLog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Logs";
            string filePath = System.IO.Path.Combine(directoryPath, "log.txt");
            string message = "this is a log entry";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);

            }


            File.AppendAllText(filePath, "Hello Wold" + "\n");
            Console.ReadKey();

        }
    }
}
