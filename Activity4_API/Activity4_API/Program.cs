interface IExample
{
    //Property
    string StringProperty { get; set; }
    //Instance
    void InstanceExample();  
}

class ClassExample<T>: IExample
{
    private string stringTest = "This is a property test";
    public string StringProperty
    {
        get
        {
            return stringTest;
        }
        set
        {
            if (value == "This is a property test")
                stringTest = "This is a property test";
        }
    }
    public void InstanceExample()
    {
        Console.WriteLine("This is the instance");
    }
    //Index
    private T[] arr = new T[50];
    public T this[int i]
    {
        get { return arr[i];  }
        set { arr[i] = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var newObj = new ClassExample<string>();
        newObj[0] = "Testing indexer";
        Console.WriteLine(newObj[0]);
        newObj.InstanceExample();

        newObj.StringProperty = "This is a property test";
        Console.WriteLine(newObj.StringProperty);
    }
}