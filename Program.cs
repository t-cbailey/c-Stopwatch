namespace Stopwatch
{

    class Program
    {
        static void Main(string[] args)
        {

            var stopwatch = new Stopwatch();
            System.ConsoleKey keyPress;
            bool run = true;


            do
            {


                Console.WriteLine("Press space to start or esc to exit");
                System.Console.WriteLine("");
                keyPress = Console.ReadKey().Key;
                if (keyPress == ConsoleKey.Escape) { run = false; }
                else if (keyPress == ConsoleKey.Spacebar)
                {
                    stopwatch.SetStartTime();
                    System.Console.WriteLine("Timer Running...");
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Press space to stop");
                    System.Console.WriteLine("");


                    keyPress = Console.ReadKey().Key;
                    if (keyPress == ConsoleKey.Spacebar)
                    {
                        stopwatch.SetStopTime();
                        System.Console.WriteLine("Timer Stopped");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("The stopwatch ran for {0}", stopwatch.TimeDifference);
                        System.Console.WriteLine("");




                    }

                }

            } while (run);

        }
    }

}
