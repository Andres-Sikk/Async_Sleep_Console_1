namespace Async_Sleep_Console_1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int tick = 1;
            int amount = 5;
            int delay = 1000;
            while (tick < 3600)
            {
                Console.WriteLine(tick);
                await Task.Delay(delay);
                if (tick % amount == 0)
                {
                    Console.Clear();
                }
                tick++;
            }
        }
    }
}
