namespace ControlWork
{
    class Methods
    {
        public static byte ConditionForFill()
        {
            byte count = 0;
            Console.Write(
                "\n\tПожалуйста введите введите количество вводимых строк\n"
                    + "\tв виде натурального числа: "
            );
            string? number = Console.ReadLine();
            if (!string.IsNullOrEmpty(number))
                count = Convert.ToByte(number.ToString());
            return count;
        }
    }
}
