using System;

namespace MoneyReturn
{
    public class Program
    {
        static bool converted;
        static void Main(string[] args)
        {
            int price = 0;
            int paid = 0;
            do
            {
                Console.Write("Částka k platbě: ");
                ConvertInt(ref price, Console.ReadLine(), 0);
            } while (!converted);
            do
            {
                Console.Write("Zaplaceno: ");
                ConvertInt(ref paid, Console.ReadLine(), price);
            } while (!converted);

            int needReturn = paid - price;
            ReturnMoney(needReturn);
        }

        static int[,] moneyArray = new int[12, 2] { { 5000, 0 }, { 2000, 0 }, { 1000, 0 }, { 500, 0 }, { 200, 0 }, { 100, 0 }, { 50, 0 }, { 20, 0 }, { 10, 0 }, { 5, 0 }, { 2, 0 }, { 1, 0 } };
        
        public static int[,] ReturnMoney(int needReturn)
        {
            Console.WriteLine("Vrátit:");
            for (int i = 0; i < moneyArray.GetLength(0); i++)
            {
                moneyArray[i, 1] = needReturn / moneyArray[i, 0];
                needReturn %= moneyArray[i, 0];
                if (moneyArray[i, 1] != 0)
                    Console.WriteLine($"- {moneyArray[i, 0]}Kč - {moneyArray[i, 1]}x");
            }
            return moneyArray;
        }

        public static void ConvertInt(ref int x, string sx, int min)
        {
            try
            {
                x = Convert.ToInt32(sx);
                if (x >= min)
                    converted = true;
                else
                {
                    Console.WriteLine("Málo peněz");
                    converted = false;
                }
            }
            catch 
            {
                converted = false;
            }
        }
    }
}
