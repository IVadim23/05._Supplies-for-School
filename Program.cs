using System;
using System.Buffers.Text;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add nubmer of pens:");
            int pen = int.Parse(Console.ReadLine());
            double pricepen = pen * 5.80;
            Console.WriteLine("Add nubmer of mark:");
            int mark = int.Parse(Console.ReadLine());
            double pricemark = mark * 7.20;
            Console.WriteLine("Add nubmer of pens:");
            int waterBasedPaint = int.Parse(Console.ReadLine());
            double priceWaterBasedPaint = waterBasedPaint * 1.20;
            double sum = pricepen + pricemark + priceWaterBasedPaint;
            Console.WriteLine("Add discont:");
            double discont = double.Parse(Console.ReadLine());
            double finalprice = sum - (sum * (discont / 100));
            Console.WriteLine("The final price is : \n {0:f2}" , finalprice);
        }
    }
}
