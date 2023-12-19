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

    public static int Textlength(object o)
    {
        Console.WriteLine($"\nTask with id {Task.CurrentId} processing the object {o}");
        return o.ToString().Length;
    }

    public static void Main(string[] args)
    {

        //Task.Factory.StartNew(() => write('.'));
        //var t = new Task(() => write('?'));
        //t.Start();
        //write('-');

        ////This will create a task and then run it
        //Task.Factory.StartNew(write, "heloo");

        ////This will create a task but doesn't run
        //Task t = new Task(write, 123);
        //t.Start();

        string text1 = "testing", text2 = "this";

        Task<int> task1 = new Task<int>(Textlength, text1);
        task1.Start();

        Task<int> task2 = Task.Factory.StartNew(Textlength, text2);

        Console.WriteLine($"The Length of the text 1 is {task1.Result}");
        Console.WriteLine($"The Length of the text 2 is {task2.Result}");

        // Method intentionally left empty.
        Console.WriteLine("Main program done");
        Console.ReadKey();
    }
}