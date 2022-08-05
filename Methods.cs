namespace ControlWork
{
    abstract class Methods
    {
        protected static string[] array = new string[0];
        protected static string[] result = new string[0];

        protected static void FillStringArray()
        {
            Console.Clear();
            Console.Write(
                "\n\tПожалуйста введите несколько строк для заполнения массива.\n"
                    + "\tЧтобы остановить процесс введите *ПУСТУЮ* строку.\n\n"
            );
            int i = 0;
            Array.Resize(ref array, 0);
            do
            {
                Console.Write($"\tВведите элемнт c индексом No {i}: ");
                string? str = Console.ReadLine();
                if (str == String.Empty)
                    break;
                if (!String.IsNullOrEmpty(str))
                    AddToArray(ref array, str);
                i++;
            } while (true);
        }

        protected static void AddToArray(ref string[] arrayOfStrings, string text)
        {
            int lenght = arrayOfStrings.Length;
            Array.Resize(ref arrayOfStrings, lenght + 1);
            arrayOfStrings[arrayOfStrings.Length - 1] = text;
        }

        protected static void GetResult()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                    AddToArray(ref result, array[i]);
            }
        }

        protected static void PrintArray(ref string[] currentArray)
        {
            if (currentArray.Length > 0)
                Console.WriteLine("\n\t[" + String.Join(", ", currentArray) + "]\n");
            else
            {
                Console.WriteLine(
                    "\n\tВы не ввели ни одной строки!"
                        + "\n\tС пустым массивом невозможно провести требуемой операции!"
                );
            }
        }
    }
}
