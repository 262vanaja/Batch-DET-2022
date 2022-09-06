//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace Batch_DET_2022
//{
//    internal class linq
//    {
//        private static bool result;

//        public static object FristLetter { get; private set; }

//        public static void Main()
//        {
//            Employee();
//            //Sample_OrderBy_Lambda();

//            //}
//            //       private static void SampleLinq()
//            //        {
//            //            //Data source
//            //            List<int> numbers = new List<int>();
//            //            numbers.Add(101);
//            //            numbers.Add(100);
//            //            numbers.Add(121);
//            //            numbers.Add(123);

//            //            //Query creation.sql type

//            //            var numQuery = from num in numbers
//            //                           select num;



//            //            //Query creation.
//            //            foreach (int num in numQuery)
//            //            {
//            //                Console.Write(" {0} ", num);
//            //            }
//            //            Console.ReadLine();
//            //        }

//            //    }
//            //}

//            //          static void Sample_OrderBy_Lambda()
//            //          {
//            //           int[] number = { 1,7,8,8,};

//            //           var result = number.OrderBy(x => x);

//            //           Console.WriteLine("Ordered list of numbers:");
//            //           foreach (int number in result)

//            //            Console.WriteLine(number);
//            //}
//            //          }
//            //   }
//            //static void Sample_Skip_Lambda()
//            //{
//            //    string[] words = { "one", "two", "three", "four", "five", "six" };

//            //    var result = words.Skip(4);

//            //    Console.WriteLine("Skips the first 2 words:");
//            //    foreach (string word in result)
//            //      Console.WriteLine(word);
//            //}




//            //static void Sample_SkipWhile_Lambda()
//            //{
//            //    string[] words = { "one", "two", "three", "four", "five", "six" };

//            //    var result = words.SkipWhile(w => w.Length == 1);

//            //    Console.WriteLine("Skips words while the condition is met:");
//            //    foreach (string word in result)
//            //    Console.WriteLine(word);
//            //}
//            //static void Sample_Take_Lambda()
//            //{
//            //    int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

//            //    var result = numbers.Take(2);

//            //    Console.WriteLine("Takes the first 2 numbers only:");
//            //    foreach (int number in result)
//            //     Console.WriteLine(number);
//            //}

//            //static void Sample_ElementAt_Lambda()
//            //{
//            //    string[] words = { "One", "Two", "Three","four"};

//            //    var result = words.ElementAt(3);

//            //    Console.WriteLine("Element at index 3 in the array is:");
//            //    Console.WriteLine(result);
//            //}
//            //static void Sample_ElementAtOrDefault_Lambda()
//            //{
//            //    string[] colors = { "Red", "Green", "Blue","Yellow" };

//            //    var resultIndex2 = colors.ElementAtOrDefault(2);

//            //    var resultIndex7 = colors.ElementAtOrDefault(7);

//            //    Console.WriteLine("Element at index 2 in the array contains:");
//            //    Console.WriteLine(resultIndex2);

//            //    Console.WriteLine("Element at index 7 in the array does not exist:");
//            //    Console.WriteLine(resultIndex7 == null);
//            //}
//            //static void Sample_First_Lambda_Simple()
//            //{
//            //    string[] names = { "ram", "beam" };

//            //    var result = names.First();

//            //    Console.WriteLine("First element in the array is:");
//            //    Console.WriteLine(result);
//            //}
//            //static void Sample_First_Lambda_Conditional()
//            //{
//            //    string[] countries = { "India", "USA", "UK" };

//            //    var result = countries.First(c => c.Length == 2);

//            //    Console.WriteLine("First element with a length of 6 characters:");
//            //    Console.WriteLine(result);
//            //}
//            //static void Sample_LastOrDefault_Conditional()
//            //{
//            //    string[] words = { "one", "two", "three" };

//            //    var result = words.LastOrDefault(w => w.Length == 3);

//            //    var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

//            //    Console.WriteLine("Last element in the words array having a length of 3:");
//            //    Console.WriteLine(result);

//            //    Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
//            //    Console.WriteLine(resultNoMatch == null);
//            //}
//            //static void Sample_Single_Lambda()
//            //{
//            //    string[] names1 = { "vanu" };
//            //    string[] names3 = { "vanu", "Harshi","Lucky" };
//            //    string[] empty = { };

//            //    var result1 = names3.Single();

//            //    Console.WriteLine("The only name in the array is:");
//            //    Console.WriteLine(result1);

//            //    try
//            //    {
//            //        // This will throw an exception because array contains no elements
//            //        var resultEmpty = empty.Single();
//            //    }
//            //    catch (Exception e)
//            //    {
//            //        Console.WriteLine(e.Message);
//            //    }

//            //    try
//            //    {
//            //        // This will throw an exception as well because array contains more than one element
//            //        var result3 = names3.Single();
//            //    }
//            //    catch (Exception e)
//            //    {
//            //        Console.WriteLine(e.Message);
//            //    }
//            //}
//            //static void Sample_SingleOrDefault_Lambda()
//            //{
//            //    string[] names1 = { "Lucky" };
//            //    string[] names3 = { "jio", "harshi", "vanu" };
//            //    string[] empty = { };

//            //    var result1 = names1.SingleOrDefault();

//            //    var resultEmpty = empty.SingleOrDefault();

//            //    Console.WriteLine("The only name in the array is:");
//            //    Console.WriteLine(result1);

//            //    Console.WriteLine("As array is empty, SingleOrDefault yields null:");
//            //    Console.WriteLine(resultEmpty == null);

//            //    try
//            //    {
//            //        // This will throw an exception as well because array contains more than one element
//            //        var result3 = names3.SingleOrDefault();
//            //    }
//            //    catch (Exception e)
//            //    {
//            //        Console.WriteLine(e.Message);
//            //    }
//            //static void Sample_Aggregate_Lambda_Simple()
//            //{
//            //    var numbers = new int[] { 1, 2, 3, 4, 5 };

//            //    var result = numbers.Aggregate((a, b) => a * b);

//            //    Console.WriteLine("Aggregated numbers by multiplication:");
//            //    Console.WriteLine(result);
//            //}
//            //static void Sample_Aggregate_Lambda_Seed()
//            //{
//            //    var numbers = new int[] { 1, 2, 3, 4, 5 };

//            //    var result = numbers.Aggregate(9, (a, b) => a + b);

//            //    Console.WriteLine("Aggregated numbers by addition with a seed of 10:");
//            //    Console.WriteLine(result);
//            //}
//            //static void Sample_Average_Lambda()
//            //{
//            //    int[] numbers = { 8, 8, 10, 10 };

//            //    var result = numbers.Average();

//            //    Console.WriteLine("Average is:");
//            //    Console.WriteLine(result);
//            //}
//            //static void Sample_Count_Lambda()
//            //{
//            //    string[] names = { "ab", "bc", "cd", "de" };

//            //    var result = names.Count();

//            //    Console.WriteLine("Counting names gives:");
//            //    Console.WriteLine(result);
//            //}

//            //static void Sample_LongCount_Lambda()
//            //{
//            //    // Create array which is 5 elements larger than Int32.MaxValue
//            //    var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 5));

//            //    Int64 result = largeArr.LongCount();

//            //    Console.WriteLine("Counting largeArr elements:");
//            //    Console.WriteLine(result);
//            //}
//            //static void Sample_Max_Lambda()
//            //{
//            //    int[] numbers = { 2, 8, 5, 6, 1 };

//            //    var result = numbers.Max();

//            //    Console.WriteLine("Highest number is:");
//            //    Console.WriteLine(result);
//            //}
//            //static void Sample_Min_Lambda()
//            //{
//            //    int[] numbers = { 6, 9, 0, 7, 5 };

//            //    var result = numbers.Min();

//            //    Console.WriteLine("Lowest number is:");
//            //    Console.WriteLine(result);
//            //}
//            //static void Sample_Sum_Lambda()
//            //{
//            //    int[] numbers = { 2, 5, 10 };

//            //    var result = numbers.Sum();

//            //   Console.WriteLine("Summing the numbers yields:");
//            //   Console.WriteLine(result);
//            //}
//            //static void Sample_Distinct_Lambda()
//            //{
//            //    int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

//            //    var result = numbers.Distinct();

//            //    Console.WriteLine("Distinct removes duplicate elements:");
//            //    foreach (int number in result)
//            //      Console.WriteLine(number);
//            //}
//            //static void Sample_Except_Lambda()
//            //{
//            //    int[] numbers1 = { 1, 2, 3 };
//            //    int[] numbers2 = { 3, 4, 5 };

//            //    var result = numbers1.Except(numbers2);

//            //    Console.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
//            //    foreach (int number in result)
//            //    Console.WriteLine(number);
//            //}
//            //static void Sample_Intersect_Lambda()
//            //{
//            //    int[] numbers1 = { 1, 2, 3 };
//            //    int[] numbers2 = { 3, 4, 5 };

//            //    var result = numbers1.Intersect(numbers2);

//            //    Console.WriteLine("Intersect creates a single sequence with only the duplicates:");
//            //    foreach (int number in result)
//            //    Console.WriteLine(number);
//            //}

//            //static void Sample_First_Lambda_Conditional()
//            //{
//            //    string[] names = { "john", "peter", "jacob", "harry", "jackson" };

//            //    var result = names.Where(word => word.Contains('a'));



//            //    foreach (var word in result)
//            //    Console.WriteLine(word);

//            //}

//        }
//        //static void Sample_GroupBy_Lambda()
//        //{
//        //    List<string> words = new List<string> { "basket", "blueberry", "chimpanze", "abacue", "banana", " apple", "cheese" };

//        //    var wordGroups = words.GroupBy(x => x[0]).Select 

//        //    (y => new { FristLetter = y.Key, words = y });
//        //    foreach (var items in wordGroups)
//        //    {

//        //        Console.WriteLine("words thet start with the" + 
//        //                        "letter '{0}':",
//        //            items.FristLetter);


//        //           foreach (var w in items.words)
//        //            {
//        //                Debug.WriteLine(w);
//        //            }
//        public class Employee
//        {
//            public Employee()
//            {

//            }

//            public Employee(int id, string name, string dept)
//            {
//                this.ID = id;
//                this.Name = name;
//                this.Dept = dept;

//            }
//            public int ID { get; set; }
//            public string Name { get; set; }
//            public string Dept { get; set; }

//        }


//    }
//}


    


    

