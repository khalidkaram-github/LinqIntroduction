namespace LinqIntroduction
{
    internal class Program
    {

        static void Main(string[] args)
        {

            #region make sure that collections implement ienumerable interface
            int[] numbersAsArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numbersAsList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var arrayInterfaces = typeof(int[]).GetInterfaces();

            foreach (var i in arrayInterfaces)
            {
                // Console.WriteLine(i);
            }



            Console.WriteLine("----------------------------------------------");
            var listInterfaces = typeof(List<int>).GetInterfaces();

            foreach (var i in listInterfaces)
            {
                //Console.WriteLine(i);
            }
            #endregion

            #region where operator
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var nums = numbers.Where(x => x > 5).Where(c => c < 8);


            foreach (var item in nums)
            {
                //Console.WriteLine(item);
            }

            #endregion

            #region book example


            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

            var query = names.Where(n => n.Contains("a"))
                             .OrderBy(n => n.Length)
                             .Select(n => n.ToUpper());


            foreach (string name in query)
                Console.WriteLine(name);
            #endregion

            #region MyRegion
            //var numbers = new List<int>() { 1, 3, 5, 6, 7, 885, 3, 222, 4, 555 };

            //List<int> oddNumbers = new List<int>();
            //foreach (var number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        oddNumbers.Add(number);
            //    }
            //}

            //foreach (var item in oddNumbers)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


        }
    }
}
