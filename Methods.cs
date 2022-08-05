namespace ControlWork
{
    class Methods
    {
        public static string[] array = new string[0];

        public static void FillStringArray()
        {
            Console.Clear();
            Console.Write(
                "\n\tПожалуйста введите несколько строк для заполнения массива.\n"
                    + "\tЧтобы остановить процесс нажмите Escape.\n"
            );
            int i = 0;
            Array.Resize(ref array, 0);
            ConsoleKeyInfo choise;
            while (true)
            {
                Console.Write($"\tВведите элемнт c индексом No {i}: ");
                string? str = Console.ReadLine();
                if (!String.IsNullOrEmpty(str))
                    AddToArray(ref array, str);
                Console.Write($"\tПродолжить ввод? ");
                choise = Console.ReadKey();
                Console.WriteLine();
                if (choise.Key == ConsoleKey.Escape)
                {
                    break;
                }
                i++;
            }
        }

        public static void AddToArray(ref string[] arrayOfStrings, string text)
        {
            int lenght = arrayOfStrings.Length;
            Array.Resize(ref arrayOfStrings, lenght + 1);
            array[arrayOfStrings.Length - 1] = text;
        }
    }
}
