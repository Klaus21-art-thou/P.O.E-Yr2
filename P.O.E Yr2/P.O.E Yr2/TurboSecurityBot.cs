using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Class 2: TurboSecurityBot (chatbot logic)
public class TurboSecurityBot
{
    private readonly Dictionary<string, string> _responses;

    public TurboSecurityBot()
    {
        _responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            { "Hello", "Hi. Ask me about cyber security topics such as malware, phishing, or online safety." },
            { "Turbo Security", "I'm Turbo Security, a simple chatbot created to explain basic cyber security concepts." },
            { "What can you do", "I can answer simple questions about cyber security and give short explanations or tips." },
            { "Purpose", "My purpose is to act as a basic cyber security guide and demonstrate a simple chatbot implementation." },
            { "Cyber Security", "Cyber security is the practice of protecting systems, networks, and data from unauthorized access or damage." },
            { "Types", "Common threats include malware, viruses, phishing, social engineering, and insecure passwords." },
            { "Computer", "A computer is an electronic device that processes instructions to perform tasks and run software." },
            { "Virus", "A virus is malicious software that can replicate and spread by attaching to files or programs." },
            { "Online Safety", "Use strong unique passwords, enable two-factor authentication, and be cautious with links and attachments." },
            { "Phishing", "Phishing is when attackers impersonate trusted sources to steal credentials or deliver malware." },
            { "Malware", "Malware is any software designed to harm or exploit a device, including viruses, trojans, and ransomware." },
            { "Social engineering", "Social engineering manipulates people into revealing confidential information or performing actions." },
            { "Safe Browsing", "Safe browsing means keeping your browser and extensions up to date, preferring HTTPS sites, avoiding suspicious links and downloads, checking site reputation, using strong unique passwords, and using a VPN on untrusted networks." },
            { "Chat", "We can discuss cyber security topics or you can ask for examples, definitions, or simple advice." },
            { "Help", "Ask about \"Cyber Security\", \"Types\", \"Phishing\", \"Safe Browsing\", or say \"Hello\". Say 'Bye' to exit." },
            { "How are you?", "I'm excellent and I'm ready to help with your cyber security questions. What cyber security topic interests you?" },
            { "Im tired", "My apologies i was not programed to deal with boredom but instead i was programmed to help you with cybersecurity protection implementations" },
            { "Can you help me", "Of course! Please ask any questions in relation to cyber security and I will do my best to assist you." },
            { "Bye", "Goodbye! Stay safe online and remember to practice good cyber security habits!" }
        };
    }

    public void StartConversation()
    {
        ConsoleHelper.PrintMessage("Hello, I'm Turbo Security, your personal cyber security guide. Ask me anything about cyber security and I'll do my best to help you. Ask for 'Help' to see topics you can ask about. Say 'Bye' to end the conversation.");

        while (true)
        {
            Console.Write("You: ");
            var input = Console.ReadLine()?.Trim();
            if (string.IsNullOrWhiteSpace(input))
                continue;

            if (IsExitCommand(input))
            {
                ConsoleHelper.PrintMessage(_responses["Bye"]);
                break;
            }

            var response = GetResponse(input);
            ConsoleHelper.PrintMessage(response);
        }
    }

    private bool IsExitCommand(string input)
    {
        return input.Equals("bye", StringComparison.OrdinalIgnoreCase) ||
               input.Equals("goodbye", StringComparison.OrdinalIgnoreCase) ||
               input.Equals("exit", StringComparison.OrdinalIgnoreCase);
    }

    private string GetResponse(string input)
    {
        if (_responses.TryGetValue(input, out var response))
            return response;

        // Fallback: match partial keys (prefer longer)
        foreach (var key in _responses.Keys.OrderByDescending(k => k.Length))
        {
            if (input.IndexOf(key, StringComparison.OrdinalIgnoreCase) >= 0)
                return _responses[key];
        }

        return "I'm not sure I understand. Try asking about \"Cyber Security\", \"Types\", \"Safe Browsing\", or say \"Hello\".";
    }
}
