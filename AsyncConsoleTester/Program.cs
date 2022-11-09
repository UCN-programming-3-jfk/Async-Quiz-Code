internal class Program
{
    private static async Task Main(string[] args)
    {
        //One();
        //Two();
        //Three();
        //await Three();
        //await Four();
        //await Five();
    }
    private static async void One()
    {
        Console.WriteLine("A");
        SlowGetAsync(10_000);
        Console.WriteLine("B");
        Task.Delay(5_000);
        Console.WriteLine("C");
    }


    private static async void Two()
    {
        Console.WriteLine("A");
        await SlowGetAsync(10);
        Console.WriteLine("B");
        await Task.Delay(5_000);
        Console.WriteLine("C");
    }
    private static async Task Three()
    {
        Console.WriteLine("A");
        string result = await SlowGetAsync(10_000);
        Console.WriteLine("B");
        Task.Delay(5_000).Wait();
        Console.WriteLine("C");
        Console.WriteLine(result);
    }


    private static async Task Four()
    {
        Console.WriteLine("A");
        Task<string> getSlow = SlowGetAsync(10_000);
        Console.WriteLine("B");
        Task.Delay(5_000).Wait();
        Console.WriteLine("C");
        Console.WriteLine(getSlow.Result);
    }

    private static async Task Five()
    {
        Console.WriteLine("A");
        await Task.Delay(5_000);
        Console.WriteLine("B");
        Console.WriteLine(await SlowGetAsync(10_000));
        Console.WriteLine("C");
    }


    private static async Task<string> SlowGetAsync(int msToWait)
    {
        Console.WriteLine("D");
        await Task.Delay(msToWait);
        return "E";
    }
}