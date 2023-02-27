
using InterviewTarget.SOLID;
using InterviewTarget.Test;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

Main();

static void Main()
{
    //int a, b, c, x;
    //a = 90;
    //b = 15;
    //c = 3;
    //x = a - b / 3 + c * 2 - 1;
    //c -= b /= x * b;
    //Console.WriteLine(x);

    // Single Responsible Principle
    //var j = new Journal();
    //j.AddEntry("I smile everyday");
    //j.AddEntry("I ate a bug");
    //Console.WriteLine(j);

    //var p = new Persistence();
    //var filename = @"D:\Coding\tmp.txt";
    //p.SaveToFile(j, filename, true);


    //// Open close Principle
    //var apple = new Product("Apple", Color.Blue, Size.Large);
    //var orange = new Product("Orange", Color.Green, Size.Small);
    //var mango = new Product("Mango", Color.Green, Size.Medium);

    //Product[] products = {apple, orange, mango};

    //var pf = new ProductFilter();
    //Console.WriteLine("Green Products (old):");
    //foreach (var item in pf.FilterByColor(products, Color.Green))
    //{
    //    Console.WriteLine($" - {item.Name} is green");
    //}

    //var bf = new BetterFilter();
    //Console.WriteLine("Green Products (new) :");
    //foreach (var item in bf.Filter(products, new ColorSpecification(Color.Green)))
    //{
    //    Console.WriteLine($" - {item.Name} is green");
    //}

    //Console.WriteLine("Large Size Products");
    //foreach (var item in bf.Filter(products, new SizeSpecification(Size.Large)))
    //{
    //    Console.WriteLine($" - {item.Name} is large ");
    //}

    //Console.WriteLine("Large blue Item");
    //foreach (var item in bf.Filter(products,
    //    new AndSpecification<Product>(new SizeSpecification(Size.Large), new ColorSpecification(Color.Blue))))
    //{
    //    Console.WriteLine($" - {item.Name} is a large and blue");
    //}


    //double facto = Factorial(6);
    //Console.WriteLine(facto.ToString());

    // swap
    //int x = 2, y = 3;
    //Console.WriteLine($"x : {x} and y : {y}");
    //Swap(ref x, ref y);
    //Console.WriteLine($"After swap x : {x} and y : {y}");

    // Get vowels
    //string fromArray = GetVowels(new[] { "apple", "banana", "pear" });
    //Console.WriteLine($"Vowels from array: '{fromArray}'");

    //string fromMultipleArguments = GetVowels("apple", "banana", "pear");
    //Console.WriteLine($"Vowels from multiple arguments : '{fromMultipleArguments}'");

    //string fromNull = GetVowels(null);
    //Console.WriteLine($"Vowels from null : '{fromNull}'");

    //string fromNoValue = GetVowels();
    //Console.WriteLine($"Vowels from no value : '{fromNoValue}'");


    // Get DoubleValues
    //int[] values = { 2, 4, 6, 8 };
    //DoubleValues(values);

    //foreach (var val in values)
    //{
    //    Console.WriteLine($"Values : {val}");
    //}

    // simple chatbot
    //Console.WriteLine("Hello, I am a simple chatbot. How can I help you?");

    //// Load json dataset
    //string json = File.ReadAllText("responses.json");
    //var responses = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

    //while (true)
    //{
    //    string input = Console.ReadLine();

    //    if (responses.ContainsKey(input.ToLower()))
    //    {
    //        Console.WriteLine(responses[input.ToLower()]);
    //    }
    //    else if(input.ToLower() == "bye")
    //    {
    //        Console.WriteLine("Goodbye! have a great day!");
    //        break;
    //    }
    //    else
    //    {
    //        Console.WriteLine("I'm sorry, I didn't understand what you said. Can you please rephrase?");
    //    }
    //}


    //Console.WriteLine("Calculator");

    //ICalculator add = new Add();
    //ICalculator sub = new Subtract();
    //ICalculator dev = new Division();
    //ICalculator mul = new Multiply();

    ////Console.WriteLine(add.Calculate("+", 10, 30));
    ////Console.WriteLine(sub.Calculate("-", 40, 70));
    ////Console.WriteLine(dev.Calculate("/", 50, 0));
    ////Console.WriteLine(mul.Calculate("*", 4,  4));

    //Calculator calculator = new(add, sub, mul, dev);

    //Console.WriteLine(calculator.Calculate("+", 23, 23));
    //Console.WriteLine(calculator.Calculate("-", 23, 3));

    //Dog dog = new()
    //{
    //    Name = "Papi",
    //    Age = 3,
    //    Breed = "Labrador Retriver"
    //};

    //Cat cat = new()
    //{
    //    Name = "Isse",
    //    Age = 2,
    //    FurColor = "Red"
    //};

    //dog.MakeSound();
    //dog.Bark();

    //cat.MakeSound();
    //cat.Meow();


    // Open close principle
    Shape rectangle = new Rectangle { Height = 10, Width = 10 };
    Shape circle = new Circle { Radius = 7 };

    AreaCalculator areaCalculator = new AreaCalculator();

    double rectangleArea = areaCalculator.CalculateArea(rectangle);
    double circleArea = areaCalculator.CalculateArea(circle);

    Console.WriteLine($"Rectangle Area : {rectangleArea}");
    Console.WriteLine($"Circle Area : {circleArea}");

    Console.ReadLine();
}



// Factorials

static double FactorialRecursive(int x)
{
    if (x == 0)
        return 1;

    return x * FactorialRecursive(x - 1);
}

static double Factorial(int num)
{
    if(num == 0) return 1;
    int fact = 1;

    // 6 * 5 * 4 * 3 * 2 * 1 = 720
    for (int i = 1; i <= num; i++)
    {
        fact = fact * i; 
    }
    return fact;
}


//findAllSubstring("Hello");

static void findAllSubstring(string str)
{
    //StringBuilder  stringBuilder= new StringBuilder(str.Length -1);

    //for (int i = 0; i < str.Length; i++)
    //{
    //    stringBuilder.Append(str[i]);
    //    Console.WriteLine(stringBuilder.ToString());
    //}

    for (int i = 0; i < str.Length; ++i)
    {
        StringBuilder subString = new StringBuilder(str.Length - i);
        for (int j = i; j < str.Length; ++j)
        {
            subString.Append(str[j]);
            Console.Write(subString + " ");
        }
    }

}

//bool palidrome = chkPalidrome("121");

//if (palidrome) Console.WriteLine("Palidrome");
//else Console.WriteLine("Not Palidrome");

static bool chkPalidrome(string str)
{
    bool flag = false;
    for (int i = 0, j = str.Length -1; i < str.Length /2; i++,j--)
    {
        if (str[i] == str[j])
        {
            flag = true;
        }

        Console.Write("i = {0} > str[i] = {1} ", i,str[i]);
        Console.WriteLine(str[j]);
    }
    return flag;
}

//ReverseWordOrder("Hi hello, How are you?");
static void ReverseWordOrder(string str)
{
    string[] a = str.Split(' ');
    Array.Reverse(a);
    foreach (var item in a)
    {
        Console.Write(item + " ");
    }
}

// Swap the given numbers
static void Swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}


static string GetVowels(params string[] input)
{
    if (input == null || input.Length == 0)
    {
        return string.Empty;
    }

    var vawels = new char[] { 'A', 'E', 'I', 'O', 'U' };
    return string.Concat(input.SelectMany(word => word.Where(letter => vawels.Contains(char.ToUpper(letter)))));
}

// The example displays the following output:
//     Vowels from array: 'aeaaaea'
//     Vowels from multiple arguments: 'aeaaaea'
//     Vowels from null: ''
//     Vowels from no value: ''


static PersonalInfo GetPersonalInfo(string id)
{
    PersonalInfo personal = new PersonalInfo();

    personal.MiddleName = "Hello";
    personal.Age = 32;
    personal.LastName = "dd";
    personal.FirstName = "sdsd";

    return personal;
}


static void DoubleValues(int[] arr)
{
    for(int i = 0; i <= arr.GetUpperBound(0); i++)   
        arr[i] = arr[i] * 2;    
}