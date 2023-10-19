using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace hometask_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("the currency values for exchaging");

            foreach (Currency currencies in Enum.GetValues(typeof(Currency)))
            {
                Console.WriteLine(currencies);
            }


            Console.WriteLine("enter your AZE (manat) value for exchanging with other currency values");
            decimal amount1 = Convert.ToDecimal(Console.ReadLine());

            Currency currencyType1 = Currency.Usd;

            Currency currencyType2 = Currency.Euro;

            Currency currencyType3 = Currency.Try;

            Currency currencyType4 = Currency.Rub;

            FindCurrency(currencyType1, amount1);
            FindCurrency(currencyType2, amount1);
            FindCurrency(currencyType3, amount1);
            FindCurrency(currencyType4, amount1);


             static void FindCurrency(Currency currency, decimal aznValue)
            {
                switch (currency)
                {
                    case Currency.Usd:
                        Console.WriteLine("the amount with dollar  " + aznValue * 0.588256M +  " $"); // Dollar
                        break;
                    case Currency.Euro:
                        Console.WriteLine( "the amount with euro  " +  aznValue * 0.554554M + " euro"); 
                        break;
                    case Currency.Try:
                         Console.WriteLine( "the amount with turkish lira  " + aznValue * 16.4622M + " turkish lira"); 
                        break;
                    case Currency.Rub:
                        Console.WriteLine("the amount with russian ruble  " + aznValue * 57.6539M + " russian ruble"); 
                        break;
                    default:
                        Console.WriteLine( "Invalid currency");
                        break;

                }
            }
        }
    }
}