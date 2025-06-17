
using System.ComponentModel;

static string PwdGenerator(int length, string complexity)
{
    if (length < 8)
    {
        return "Your password is too short.";
    }

    string chars;
    string password = "";
    Random rand = new Random();

    switch (complexity)
    {
        case "1":
            chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            break;
        case "2":
            chars = "!#$%&0123456789?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]abcdefghijklmnopqrstuvwxyz";
            break;
        case "3":
            chars = "!#$%\"&\'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz{|}~";
            break;
        default:
            return "Invalid option chosen";
    }

    for (int i = 0; i < length; i++)
    {
        int character = rand.Next(chars.Length);
        password += chars[character];
    }

    return "Your password is: " + password;
}

Console.WriteLine("Which set of characters should be used for generating your password?");
Console.WriteLine("1. Simple - Uppercase and lowercase letters and numbers");
Console.WriteLine("2. Moderate - letters, numbers and symbols (#!% etc.)");
Console.WriteLine("3. Strong - All charaters (excluding space)");
Console.Write("Your choice: ");
string complexity = Console.ReadLine();

Console.WriteLine("");

Console.Write("Choose length of your password (min. 8 characters): ");
int length = int.Parse(Console.ReadLine());

Console.WriteLine(PwdGenerator(length, complexity));