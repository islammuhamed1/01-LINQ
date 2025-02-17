using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static _01_LINQ.ListGenerator;
namespace _01_LINQ
{
    internal class Program
    {
        public static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            //Q1
            //var OutOfStock = ProductsList.Where(p => p.UnitsInStock == 0);
            //Print(OutOfStock);

            //Q2
            //var ProductsInStockWithCostMoreThan3000 = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.000M);
            //Print(ProductsInStockWithCostMoreThan3000);

            //Q3
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var ShortDigits = Arr.Where((N, I) => N.Length < I); 
            //Print(ShortDigits);
            #endregion
            #region LINQ - Ordering Operators
            //Q1
            //var ProductsOrderedByName = ProductsList.OrderBy(p => p.ProductName);
            //Print(ProductsOrderedByName);

            //Q2
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var SortedWords = Arr.OrderBy(w => w, new CompareWithNonCaseSensitive());
            //Print(SortedWords);

            //Q3
            //var ProductsOrderedByUnitsInStock = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //Print(ProductsOrderedByUnitsInStock);

            //Q4    
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var SortedWords = Arr.OrderBy(number => number.Length)
            //                     .ThenBy(number => number);
            //Print(SortedWords);

            //Q5
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var SortedWords = Arr.OrderBy(number => number, new CompareWithNonCaseSensitive())
            //                     .ThenBy(number => number);
            //Print(SortedWords);

            //Q6
            //var ProductsOrderedByCategoryAndPrice = ProductsList.OrderBy(p => p.Category)
            //                                                    .ThenByDescending(p => p.UnitPrice); 
            //Print(ProductsOrderedByCategoryAndPrice);

            //Q7
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var SortedWords = Arr.OrderBy(number => number.Length)
            //                     .ThenBy(number => number, new CompareWithNonCaseSensitive());
            //Print(SortedWords);

            //Q8
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var ReversedWordAfterOrder = Arr.Where(number => number[1] =='i')
            //                                .Reverse();
            //Print(ReversedWordAfterOrder);
            #endregion
            #region LINQ – Transformation Operators
            //Q1
            //var ProductsName = ProductsList.Select(p => p.ProductName);
            //Print(ProductsName);

            //Q2
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var LowerAndUpperCaseWords = words.Select(word => new {LowerCase = word.ToLower() , UpperCase = word.ToUpper()});
            //Print(LowerAndUpperCaseWords);

            //Q3
            //var ProductDetails = ProductsList.Select(p => new {Name = p.ProductName,  p.UnitsInStock, Price = p.UnitPrice });
            //Print(ProductDetails);

            //Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var MatchedNumbers = Arr.Select((number, index) => $"{number}: {number == index}");
            //Print(MatchedNumbers);

            //Q5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var Pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select $"{a} less than {b}";

            //Print(Pairs);

            //Q6
            //var OrdersLessThan500 = CustomersList.SelectMany(C => C.Orders)
            //                                  .Where(O => O.Total < 500);
            //Print(OrdersLessThan500);

            //Q7
            //var OrderInOrAfter1998 = CustomersList.SelectMany(C => C.Orders)
            //                                      .Where(O => O.OrderDate.Year >= 1998);    
            //Print(OrderInOrAfter1998);

            #endregion
        }
    }
 } 

