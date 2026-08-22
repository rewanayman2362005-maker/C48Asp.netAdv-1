
namespace Generic_sheet_route
{  
    #region Q6 
    //public  interface IRepository<T>
    //{
    //  public T Get(int id);

    //}
    //public class cll: IRepository<int>
    //{
    //  public int Get(int id)
    //    {
    //        return id;
    //    }
    //}
    #endregion
    
    internal class Program
    {
        #region Q2
        //public class continer<T>
        //{
        //    public T item;

        //    public void Add(T item)

        //    { this.item=item
        //          ; }

        //    public T GET()
        //    {return item; }

        //}
        #endregion
        #region Q3 
        //public class Pair<TKey, TValue>
        //{
        //    public TKey Key { get; set; }
        //    public TValue Value { get; set; }

        //    public Pair(TKey key, TValue value)
        //    {
        //        Key = key;
        //        Value = value;
        //    }

        //    public void Display()
        //    {
        //        Console.WriteLine($"Key: {Key}, Value: {Value}");
        //    }
        //}
        #endregion
        #region Q4 
        //partial class emp
        //{
        //    public static void Swap<T>(ref T x, ref T y)
        //    {
        //        T temp =x;
        //        x = y;
        //        y = temp;

        //    }
        //}
        #endregion
        #region Q5 
        //public class cl1
        //{
        //    public static T FindMax<T>(T[] array) where T : IComparable<T>
        //    {
        //        if (array == null || array.Length == 0)
        //            throw new ArgumentException("Array is empty");

        //        T max = array[0];

        //        for (int i = 1; i < array.Length; i++) 
        //        {
        //            if (array[i].CompareTo(max) > 0) 
        //            {
        //                max = array[i];
        //            }
        //        }
        //        return max;
        //    }
        //}
        #endregion
        #region Q7
        //public class box <T> where T : struct
        //    {
        //    public T Value { get; set; }
        //    public box (T value) {
        //        Value = value;
        //    }

        //}
        #endregion

        static void Main(string[] args)
        {
            #region Q1: What is a generic class? Why use generics?
            //  class that can work with any type using a type parameter <T> 
            // becouse code relabilty and provid error , better performance , clear code 
            #endregion
            #region Q2: Write a generic class Container<T> with Add and Get methods.
            //continer<int>  obj1= new continer<int> ();
            //obj1.Add(1);
            //Console.WriteLine(obj1.GET());

            //continer<string> obg2 = new continer<string> ();
            //obg2.Add("Hello");
            //Console.WriteLine(obg2.GET());

            #endregion
            #region Q3: What are multiple type parameters? Write Pair<TKey, TValue>.
            // a generic class can have more than one type parameter
            //Pair<int, string> p1 = new Pair<int, string>(1, "Ahmed");
            //p1.Display(); 

            //Pair<string, double> p2 = new Pair<string, double>("Price", 99.9);
            //p2.Display();

            #endregion
            #region Q4: What is a generic method? Write Swap<T> method.
            //  A method that can work with any type using a type parameter <T> 
            //int x = 5;
            //int y=10;
            //Console.WriteLine($" before swap :{x}, {y}");
            //emp.Swap<int>(ref x, ref y);
            //Console.WriteLine($"  after swap :{x}, {y}");

            //string a = "Hellow";
            //string b = " world";
            //Console.WriteLine($" before swap :{a}, {b}");
            //emp.Swap<string>(ref a, ref b);
            //Console.WriteLine($"After  swap :{a}, {b}");

            #endregion
            #region  Q5: Write a generic method FindMax<T> that finds maximum value
            //int[] arrr = { 1, 2, 3, 4, 5, };
            //cl1.FindMax(arrr);
            #endregion

            #region  Q6: What is a generic interface? Write IRepository<T>.
            // interface can be taken any data type and must any class implemment must specifie type parmenter
            // cll r1 = new cll();
            //int result =  r1.Get(30506070);
            // Console.WriteLine(result);

            #endregion
            #region  Q7: What is the 'struct' constraint? Write an example.
            // constraint the type must be struct 
            //box<int> ob = new box<int>(5);

            #endregion



        }
    }
}
