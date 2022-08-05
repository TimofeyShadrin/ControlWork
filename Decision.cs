namespace ControlWork
{
    class Decisions : Methods
    {
        public static void Task()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(
                "\n\tВы смотрите программу, которая из имеющегося массива строк\n"
                    + "\tформирует массив из строк, длина которых\n"
                    + "\tменьше либо равна трем символам.\n"
            );
            Console.ResetColor();
            FillStringArray();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n\tВы ввели следущий массива строк:\n");
            Console.ResetColor();
            PrintArray(ref array);
            GetResult();
            if (result.Length > 0 && array.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\tРЕЗУЛЬТАТ:");
                Console.ResetColor();
                PrintArray(ref result);
            }
            else if (result.Length == 0 && array.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\tРЕЗУЛЬТАТ:");
                Console.ResetColor();
                Console.WriteLine("\n\tВсе строки введенные Вами больше трех символов.\n");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\tНажмите любую клавишу для выхода из программы: ");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
        }
    }
}
