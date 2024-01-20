using System.Runtime.InteropServices;
public  class Program
{
    private static void Main(string[] args)
    {


        for (int i = 0; i <= 100; i++)
        {
            Console.WriteLine(i);
        }
        int t = 0;

        do
        {
            Console.WriteLine("do while result is " + t);
            t++;
        }
        while (t < 35);
       Switch();
    }

        static void Switch()
        {
            int day = 7;
            switch (day)
            {
                case 1:

                    Console.WriteLine("Monday");
                    break;

                case 2:

                    Console.WriteLine("Tuesday");
                    break;
                case 3:

                    Console.WriteLine("Wednesday");
                    break;
                case 4:

                    Console.WriteLine("Thursday");
                    break;
                case 5:

                    Console.WriteLine("Friday");
                    break;
                case 6:

                    Console.WriteLine("Saturday");
                    break;
                case 7:

                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Value does not exist");
                    break;

            }
        }
    
}