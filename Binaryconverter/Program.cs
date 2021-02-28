using System;

namespace BinaryConverter
{
    public class Program 
    {
        public static void Main(string[] args) 
        {
            Console.Write("Введите число: "); 
            int number = int.Parse(Console.ReadLine()); 

            string binaryNumber = BinaryConverter.MyConvert(number); 

            Console.WriteLine("Число в двоичной системе, используя свой собственный метод: " + binaryNumber);

            binaryNumber = BinaryConverter.StandartConvert(number);
            Console.WriteLine("Число в двоичной системе, используя стандартный метод: " + binaryNumber);

            Console.ReadLine();
        }
    }
}
