namespace assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //Write a program that allows the user to enter a number then print it.
            //Console.WriteLine("ENTER NUMBER");
            //int NUMBER;
            //int.TryParse(Console.ReadLine(), out NUMBER);
            //Console.WriteLine($"number u entered: {NUMBER}");
            #endregion

            #region 2
            string non_numerical = "osama";
            int Return;
            bool test_convert = int.TryParse(non_numerical, out Return);
            //Console.WriteLine($"result will be {test_convert} then integar value: {Return}");
            //Console.WriteLine(test_convert? $"can converted so value will be: {Return}" : $"cant converted so value will be: {Return}");
            #endregion

            #region 3
            float test = 1.4f;
            //Console.WriteLine(++test);
            //Console.WriteLine(test + 1.5);
            #endregion

            #region 4
            string test2 = "osama elsafty";
            string Result1 = test2.Substring(0, 5); //take paramter (start point(0), length of new substring(5)) 
            string Result2 = test2.Substring(5); //start point 5 to the end
                                                 //Console.WriteLine(Result1);
                                                 //Console.WriteLine(Result2);
            #endregion

            #region 6
            int var1 = 5, var2;
            var2 = var1;
            //Console.WriteLine($"when assign var1 to var2,so value of 2 will be: {var2}");
            var1 += 5;
            //Console.WriteLine($"after modifiy var1 so var2 = {var2}");
            var2 += 5;
            //Console.WriteLine($"after modifiy var2 so var2 = {var2}");
            #endregion

            #region 7
            string first = "osama", second = " elsafty";
            //Console.WriteLine(first + second);
            //Console.WriteLine($"{first}{second}");
            #endregion

            #region 8
            //double principal, rate, time;
            //Console.WriteLine("enter principal then rate then time");
            //double.TryParse(Console.ReadLine(), out principal);
            //double.TryParse(Console.ReadLine(), out rate);
            //double.TryParse(Console.ReadLine(), out time);
            //double Interest = (principal * rate * time) / 100;
            //Console.WriteLine(Interest);
            #endregion

            #region 9
            //double weight, height;
            // Console.WriteLine("enter weight");
            //double.TryParse(Console.ReadLine(), out weight);
            //Console.WriteLine("enter height");
            //double.TryParse(Console.ReadLine(), out height);
            //double BMI = (weight) / (height * height);
            //Console.WriteLine(BMI);
            #endregion

            #region 10
            //double temp;
            //double.TryParse(Console.ReadLine(), out temp);
            //Console.WriteLine(temp < 10 ? "TOO COLD" : temp > 30 ? "TOO HOT" : "is good");
            #endregion

            #region 11
            /*
            int day, month, year;
            Console.WriteLine("ENTER DAY");
            int.TryParse(Console.ReadLine(), out day);
            Console.WriteLine("ENTER MONTH");
            int.TryParse(Console.ReadLine(), out month);
            Console.WriteLine("ENTER YEAR");
            int.TryParse(Console.ReadLine(), out year);

            if ((day < 32 && day > 0) && (month < 13 && month > 0) && (year < 9999 && year >= 2001))
            {
                Console.WriteLine($"{day} , {month} , {year}\n{day} / {month} / {year}\n{day} - {month} - {year}");
            }
            else
            {
                Console.WriteLine($"u enter not correct data");
            }
            */
            #endregion

            #region 12
            /*
             What is the output of the following C# code?
             DateTime date = new DateTime(2024, 6, 14); Console.WriteLine($"The event is on {date:MM/dd/yyyy}");
              The event is on 06/14/2024
            */
            #endregion

            #region 13
            /*
             Which of the following statements is correct about the C#.NET code snippet given below?
             int d; 
            d = Convert.ToInt32( !(30 < 20) ); //output here is true = 1
            D = 1 //cause when convert from bool to int true will be 1 and false 0
            */
            #endregion

            #region 14
            //6 1
            #endregion

            #region 15
            //first condition(2 + 5 + '' + 7) = 7 7
            #endregion

        }

    }
}
    