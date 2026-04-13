using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

public static class ConsoleHelper
{
    public static void PrintHeader()
    {
        var header = new[]
  {
    @" _______ _    _ ____  ____  ____   ",
    @"|_   _| |  | | __ )| __ )| __ )  ",
    @"  | | | |  | |  _ \|  _ \|  _ \  ",
    @"  | | | |__| | |_) | |_) | |_) | ",
    @"  |_|  \____/|____/|____/|____/  ",
    "",
    @"      TURBO SECURITY - Cyber Security Guardian",
    "",
};
        Console.ForegroundColor = ConsoleColor.Cyan;
        foreach (var line in header)
            Console.WriteLine(line);
        Console.ResetColor();
    }

    public static void PrintMessage(string message)
    {
        var previous = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Turbo Security: " + message);
        Console.ForegroundColor = previous;
    }
}

