
namespace Generic_sheet_route
{
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


        }
    }
}
