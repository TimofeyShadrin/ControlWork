namespace ControlWork
{
    class Program
    {
        public static void Main(string[] args)
        {
            // string text = "Do you can cook? My friend, Bob!";
            // text = text.ToLower();
            // string stringOfSymbols = ":;'/?.>,<[]{}|`~!@#$%^&*()+-/";
            // char[] symbols = stringOfSymbols.ToCharArray();
            // char[] stringArray = text.ToCharArray();
            // foreach (char c in symbols)
            // {
            //     for (int i = 0; i < stringArray.Length; i++)
            //         if (stringArray[i] == c)
            //             stringArray[i] = ' ';
            // }

            // text = String.Join("", stringArray);
            // string[] result = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // Console.WriteLine("[" + String.Join(", ", result) + "]");
            // List<string> resultList = new List<string>();
            // foreach (string word in result)
            // {
            //     if (word.Length <= 3)
            //         resultList.Add(word);
            // }
            // Console.WriteLine("[" + String.Join(", ", resultList) + "]");
            Methods.FillStringArray();
            Console.Clear();
            Console.WriteLine("В");
            Console.WriteLine("Вы ввели следующие строки:");
            Console.WriteLine("[" + String.Join(", ", Methods.array) + "]");
        }
    }
}
