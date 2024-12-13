namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x = 5;
            Console.WriteLine(x);
            //variables ==> location stored in memory to store data(name, datatype, value, size, address)
            //alocate ==> store space in memory
            //size ==> 2^number of bites
            int y = 5;
            Console.WriteLine(y);
            //solution ==> projects ==> classes ==> function 
            //main function is entry point and mus be one entry point in project    
            //i can write any language in .net but must have same cls
            /*memory(RAM)
             1- stack
                    a. store any data with fixed size like int 
                    b. store value type data
                    c. speed of accesbility in stack is fast than heap, cause stack is more arranged than heap
             2- heap
                    a. store reference type
                    b. store data with dynamic size
                    c. it can be exbaned until memory(ram) is full and then program crash
                       but before crash, something called garbage collector try to remove all un unsed space in heap
                    d. size of heap is bigger stack 
             */
            #region newwithclr
            /*
              point = new point(), so with write this NEW
                 ==> allocate or store number of bytes in heap for object
                 ==> intiliaze the allocated bytes in heap with default value of datatype
                 ==> call user_defined constructor
                 ==> assign in reference in stack  the address of object which created in heap
              */
            #endregion

            /* casting
                implict casting (safe casting)
                    ==> from int to double
                explicit casting (un safe casting)
                    ==> it will change the shape of data
                    double x = 1.2;
                    int y = (int) x;
             */
            #region exincasting
            double x2 = 5.2;
            Console.WriteLine(x2);
            int y2 = (int)x2;
            Console.WriteLine(y2);
            long x3 = 111111111111111111;
            int y3 = (int)x3;
            Console.WriteLine(y3); //==> change shape of data 
            #endregion

            #region parse(unsafe) cause it can throw exception and make program stop
            //parse :function ==> exist in all classes and struct of datatype
            //int g = int.Parse(Console.ReadLine());
            //Console.WriteLine(g);
            #endregion

            //CONVERt is class (unsafe) cause it can throw exception and make program stop
            //int g0 = Convert.ToInt32(Console.ReadLine());

            //try parse: function (safe) cause if sucees it return true and assign value to second paramter but if false return zero to assign number
            bool test = int.TryParse(Console.ReadLine(), out x);
                        Console.WriteLine(test);
                        Console.WriteLine(x);

            //bydefaut any fraction is double so if i want to write fraction with decimal or float need to add (m , f)
            double x4 = 1.5;
            float y4 = 1.5f;
            Console.WriteLine(y4);
            decimal x5 = 1.5m;
            Console.WriteLine(x5);

            #region operator
            /*
             1- unary increment and decrement (++,--) work on one operand like variable
                        ++x ==> first increment then do what is next (prefix)
                        x++ ==> first do what is before and then increment
            2- binary operator work with two operand (+, -, *, /, %)
            3- assigned operator ==> x += 5 ==> x = x + 5
            4- relational operator (==, !=, >, <, >=, <=) used with comparsion  and return true or false
            5- logical operator !(reverse)
                                && (and) ==> short circuit like if first is false so result will be false
                                || (or) ==> if one is true result will be true and it short circuit
            6- bitwise operator ==> same as logical operator but long circuit like in (and&&) if first is false, it sill continue and xhexk second condition
            7- ternary operator ==> relational operator(return true or false) ? (here if return true) : (if return false)
                               
             */

            //int y5 = 5;
            //Console.WriteLine(++y5); //like here increment then print
            //Console.WriteLine(y5++); //like here print then increment
            //Console.WriteLine(y5);

            //int sum, n01 = 1, n02 = 2;
                //sum = n01 + n02;
            //Console.WriteLine(sum);
            #endregion





            Console.ReadKey();



        }
    }
}
