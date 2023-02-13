
        
Timer ts = new Timer(Callback, null, 500, 1000);
Console.ReadLine();
        
static void Callback(object? obj)
    {
        Console.WriteLine("Hello world");
    }
