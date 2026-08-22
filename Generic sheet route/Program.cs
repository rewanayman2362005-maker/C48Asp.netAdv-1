
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

        #region Q8 
        //public class box<T> where T : class 
        //{
        //    public T Value { get; set; }
        //    public box(T value)
        //    {
        //        Value = value;
        //    }

        //}
        #endregion
        #region Q9
        //public class Repostor<T> where T : new()
        //{
        //    public T get () 
        //    {
        //        return new T () ;
        //    }

        //}
        //public class el 
        //{
        //    public string name {  get; set; }
        //    public el ()
        //    {
        //        name = "rewan";
        //    }
        //}
        #endregion
        #region Q10
        //public interface IPrintable
        //{
        //    void Print();
        //}

        //public class Printer<T> where T : IPrintable
        //{
        //    public void PrintItem(T item)
        //    {
        //        item.Print();
        //    }
        //}

        //public class Book : IPrintable
        //{
        //    public string Title = "C# Book";
        //    public void Print()
        //    {
        //        Console.WriteLine("Printing Book: " + Title);
        //    }
        //}
        #endregion
        #region Q11
        //public class Animal
        //{
        //    public virtual void Eat()
        //    {
        //        Console.WriteLine("Animal is eating");
        //    }
        //}

        //public class AnimalShelter<T> where T : Animal
        //{
        //    public void Feed(T animal)
        //    {
        //        animal.Eat();
        //    }
        //}

        //public class Dog : Animal
        //{
        //    public override void Eat()
        //    {
        //        Console.WriteLine("Dog is eating bones");
        //    }
        //}
        #endregion
        #region Q12 
        //public interface IComparable<T>
        //{
        //    int CompareTo(T other);
        //}

        //public class Person
        //{
        //    public string Name;
        //}

        //public class Manager<T> where T : class, Person, IComparable<T>, new()
        //{
        //    public T CreateAndCompare()
        //    {
        //        T obj1 = new T();
        //        T obj2 = new T();
        //        obj1.CompareTo(obj2);
        //        return obj1;
        //    }
        //}
        #endregion
        #region Q14 
        //public class SafeList<T>
        //{
        //    private List<T> _list = new List<T>();
        //    public void Add(T item)
        //    {
        //        _list.Add(item);
        //    }
        //    public T Get(int index)
        //    {
        //        if (index < 0 || index >= _list.Count)
        //        {
        //            return default(T);
        //        }
        //        return _list[index];
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

            #region Q8: What is the 'class' constraint? Write an example.
            // constraint the type must be struct 
            //box<string> C = new box<string>("rewan");
            #endregion

            #region Q9: What is the 'new()' constraint? Write an example.
            //  new () is a constractor constraint
            // Repostor<el> r = new Repostor<el> ();
            #endregion
            #region Q10:  What is the interface constraint? Write an example.
            // the constraint the type  must be an interface
            //Printer<Book> p = new Printer<Book>();
            //p.PrintItem(new Book());

            #endregion
            #region Q11: What is the base class constraint? Write an example.
            //AnimalShelter<Dog> shelter = new AnimalShelter<Dog>();
            //shelter.Feed(new Dog());

            #endregion
            #region Q12: How do you apply multiple constraints? Write an example.
            //Manager<Person> m = new Manager<Person>();

            #endregion
            #region Q13: What does the 'default' keyword do in generics?


            //The default keyword in generics is used to return the default value of the type parameter T.  
            //If T is a value type, it returns zero.
            //If T is a reference type, it returns null.
            //It is used to initialize variables or return values from generic methods when the actual type of T is not known.
            #endregion
            #region Q14: Write a SafeList<T> that returns default when the index is invalid.
            //SafeList<int> safeList = new SafeList<int>();
            //safeList.Add(10);
            //safeList.Add(0);
            //Console.WriteLine(safeList.Get(5));
            #endregion

        }
    }
}
