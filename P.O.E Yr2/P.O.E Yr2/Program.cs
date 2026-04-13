using System;
using System.Media; // Needed for SoundPlayer

public class Program
{
    public static void Main(string[] args)
    {
        // Full path to WAV file
        string wavFilePath = @"Assets\Turbo_Cybersecurity.wav";

        // Play the WAV file
        PlayStartupSound(wavFilePath);

        ConsoleHelper.PrintHeader();

        var bot = new TurboSecurityBot();
        bot.StartConversation();
    }

    private static void PlayStartupSound(string filePath)
    {
        try
        {
            using (var player = new SoundPlayer(filePath))
            {
                player.Load();        // Load the WAV file
                player.PlaySync();    // Play synchronously
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing sound: {ex.Message}");
        }
    }
}