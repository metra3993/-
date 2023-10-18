class Program
{
    static int octave = 1;

    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в пианино!");
        Console.WriteLine("Введите ноту (Ноты: Q, W, E, R, T, Y, U; Бемоль: A, S, D, F) или Escape для выхода:");
        while (true)
        {
            string input = Console.ReadLine().ToUpper();

            if (input == "Escape")
            {
                Console.WriteLine("Bye");
                break;
            }

            if (input == "1")
            {
                octave++;
                Console.WriteLine("Текущая октава: " + octave);
                continue;
            }

            PlaySound(input);
        }
    }

    static void PlaySound(string note)
    {
        int baseFrequency = 0;

        switch (note)
        {
            case "Q":
                baseFrequency = 440;
                break;
            case "W":
                baseFrequency = 494;
                break;
            case "E":
                baseFrequency = 523;
                break;
            case "R":
                baseFrequency = 587;
                break;
            case "T":
                baseFrequency = 659;
                break;
            case "Y":
                baseFrequency = 698;
                break;
            case "U":
                baseFrequency = 784;
                break;
            case "A":
                baseFrequency = 415;
                break;
            case "S":
                baseFrequency = 466;
                break;
            case "D":
                baseFrequency = 494;
                break;
            case "F":
                baseFrequency = 554;
                break;
            default:
                Console.WriteLine("ERROR!");
                return;
        }

        int frequency = baseFrequency * (int)Math.Pow(2, octave);
        Console.Beep(frequency, 200);
    }
}
