public class Program
{

    public static void write(char c)
    {
        int i = 1000;
        while (i --> 0)
        {
            Console.Write(c);
        }
    }

    public static void write(object o)
    {
        int i = 1000;
        while(i --> 0)
        {
            Console.Write(o);
        }
    }

    public static void Main(string[] args)
    {

        //Task.Factory.StartNew(() => write('.'));
        //var t = new Task(() => write('?'));
        //t.Start();
        //write('-');

        Task.Factory.StartNew(write, "heloo");

        Task t = new Task(write, 123);
        t.Start();


        // Method intentionally left empty.
        Console.WriteLine("Main program done");
        Console.ReadKey();
    }
}