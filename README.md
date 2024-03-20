

## Tasks CLASS

<details>
  <summary>
  Description of task 1 
  </summary>
    

    Please, create MyAccessModifiers class with next members:
    int field birthYear is unavailable anywhere except this class

    string field personalInfo that is accessible within descendants of this class

    string field IdNumber that is accessible only within descendants in the current assembly

    constructor should be available from everywhere in the program and accept int for birth year, string for idNumber, string for personalInfo parameters to initialize three fields mentioned above. (Note, that the order of parameters must be exact as described)

    int property Age which returns the difference between the current year and birthYear and can be accessed everywhere, but only for reading

    common for all instances of the class byte field averageMiddleAge with default value 50

    string property Name accessible anywhere in the current assembly

    string property NickName that can be read anywhere in the program and set only in the current assembly

    method HasLivedHalfOfLife available only for descendants of the class in other assemblies and for all in the current.

    overload operator ==. The operator returns true if name, age, and personalInfo  of objects are equal

  </details>
<br>
<details>
  <summary>
  Description of Task 2
  </summary>

    
    Create a Point class which models a 2D point with x and y coordinates should contain:

    Two instance variables x and y  of int type, that will be available only in this class.

    A constructor that constructs a point with the given x and y coordinates.

    A method GetXYPair() which returns the x and y in a 2-element int array. This method should be available everywhere in the current assembly

    A method called Distance(int x, int y) that returns the distance (double) from this point to another point at the given (x, y) coordinates.

    An overloaded Distance(Point point) method that returns the distance from this point to the given Point instance.

    The distance methods should be available everywhere in the current assembly and in descendant classes in other assemblies;

    Create explicit cast to double operator that returns the distance (double) from this point to the origin (0, 0).

  </details>
<br>
<details>
  <summary>
  Description of Task 3
  </summary>

     Create class Fraction with private int fields numerator and denominator that can only be initialized on creation or in constructor

     Create a constructor to initialize these values

     Define operators unary and binary + and - (example: Fraction(-167, 100) - Fraction(3, 2) should result in "-317 / 100")

     Define the ! operator that will return reversed fraction - with numerator as denominator and denominator as numerator (For example, Fraction(-3, 100) results to "-100 / 3")

     Define binary  * and / operations.

     All operations should return simplified fractions.

     Define ToString() method which will return string representing Fraction in the format numerator / denominator. 

     Value should be simplified: numerator and denominator divided by the greatest common divisor. 

     if  numerator and denominator are both negative, the fraction should become positive. 

     If only denominator is negative the sign should be outputted before numerator without space.

     Define Equals method and operators == and !=. Fractions are equal if their simplified versions are equal. 

     (for example, 20/25 is equal to 4/5)

     Define GetHashCode() method with the implementation of your choice.
  </details>
<br>
 
  <details>
  <summary>
  Description of Task 4
  </summary>

    Suppose, you have class

    public abstract class CloseableResource
    {
       public void Close()
       {

       }
    }

    Please, create class DisposePatternImplementer that implements Disposable pattern and inherits from CloseableResource class

    Print such lines of information in the method responsible for releasing managed and unmanaged resources:

    "Disposing by developer" if the object of the class is disposed by developer

    or "Disposing by GC" if the object is disposed by garbage collector

    also, you should ensure that method Close() is called in either case.
   
  </details>
<br>
<details>
  <summary>
  Description of Task 5
  </summary>

    Please, make refactoring of the code:

    We know that adult  doesn't have childIDNumber 
    child doesn't have passportNumber.
    Create a public constructor in each class to initialize all their fields (make the first parameter of type int and the second one for name initialization).
    Accessibility of the fields should be the least possible, but the same in all assemblies.
    Add ToString() method to Child and Adult classes that will return a string in the format: "name document_number"

    public class Person
    {
        protected string childIDNumber;
    }

    public class Child
    {
        private int yearOfBirth;
        private string healthInfo;
        private string name;
        public string GetHealthStatus() { return name + ": " + yearOfBirth + ". " + healthInfo; }
    }

    public class Adult
    {
        private int yearOfBirth;
        private string healthInfo;
        private string passportNumber;
        private string name;
        public string GetHealthStatus() {return name + ": " + yearOfBirth + ". " + healthInfo; }

    }    
  
  </details>
<br>

## Tasks CLASS CLASSES
<details>
  <summary>
  Description of Task 1
  </summary>

     
    Create class Employee.

    Create two derived classes: Developer and Tester.

    Class Employee should contain internal string field name and private DateTime field hiringDate.

    Class Developer should contain private string field programmingLanguage.

    Class Tester should contain private bool field isAuthomation.

    Class Employee should contain public constructor that accepts two arguments (name and hiringDate).

    Class Employee should contain public int method Experience() that calculates the count off full years of experience. This method should be the same for the derived classes.

    Class Tester should contain the constructor that accepts three arguments: name, hiringDate and isAuthomation.

    Class Developer should contain the constructor that accepts three arguments: name, hiringDate and programmingLanguage.

    Class Employee should contain public void method ShowInfo() that prints the such string:

    "<name> has <Experience> years of experience".

    Class Developer should contain public void method ShowInfo() that prints the such string:

    "<name> has <Experience> years of experience

    <name> is <programmingLanguage> programmer".

    Please, pay attention that the first line as the same as for appropriate Employee’s method.

    Class Tester should contain public void method ShowInfo() that prints the such string

    “<name> is authomated tester and has <Experience> year(s) of experience”

    If isAuthomated field is true

    Or

    “<name> is manual tester and has <Experience> year(s) of experience”

    If isAuthomated field is false.
  </details>
<br>
<details>
  <summary>
  Description of Task 2
  </summary>
  

    Create abstract class Car and two derived classes: SportCar and Lory.

    Class Car should have the next fields: internal string mark, internal int prodYear.

    Class SportCar should have the next fields: internal string mark, internal int prodYear, private int maxSpeed.

    Class Lory should have internal string mark, internal int prodYear and private double loadCapacity.

    Create also appropriable constructors that allow create class instances with all the fields.

    Every class should have public void method ShowInfo().

    For class Car this method should display message:

    “Mark : <mark>,

    Producted in <prodYear>”

    For SportCar this method should display message:

    “Mark : <mark>,

    Producted in <prodYear>

    Maximum speed is <maxSpeed>”

    For Lory this method should display message:

    “Mark : <mark>,

    Producted in <prodYear>

    The load capacity is <loadCapacity>”

    Please organize the code optimally.
  </details>
<br>

<details>
  <summary>
  Description of Task 3
  </summary>

    Create three classes: Science, Mathematics and Physics. Organize inheritance in the correct way.

    Create method Awards() so that the next code

    Science science1 = new Mathematics();
    Science science2 = new Physics();
    Science science3 = new Science();

    science1.Awards();
    science2.Awards();
    science3.Awards();

    Gives the next output
    We dont need any awards, but we still obtain The Abel Prize that nobody else can!
    We can obtain The Nobel Prize
    We can obtain The Nobel Prize
  </details>
<br>

<details>
  <summary>
  Description of Task 4
  </summary>
    

    Create three classes: ChessFigure, Bishop and Rook. Organize inheritance in the correct way.

    Class Bishop should have void method Move() that outputs the message "Moves by a diagonal!".

    Class Rook should have void method Move() that outputs the message "Moves straight!".

    Every class that is derived from class ChessFigure must implement void method Move().
   </details>
<br>

<details>
  <summary>
  Description of Task 5
  </summary>

    For finish, let’s talk about the cats. The big cats.

    Please, create class Acinonychini. This class has two sub-classes, that live now: Acinonyx and Puma.

    Create these sub-classes too. It’s known that Puma has sub-classed and they may be created later. Acinonyx has no sub-classed, so it’s sub-classes can’t be created anywhen.

    Create For all the classes those fields, properties and methods that you think they need.
  </details>
<br>


## Tasks DELEGATES

<details>
  <summary>
  Description of Task 1
  </summary>

    Create a program that can be used for calculation of 4 arithmetic operations (+, -, *, /) according to tasks:

    1) declare a delegate CalcDelegate referring to a function Calc with three parameters (two numbers and one - operation sign) and a numerical result;

    2) define a class CalcProgram and within this class:

    2.1) define a static function Calc for computation with the same signature as the delegate. Note: in case of denominator=0, the function returns 0.

    2.2) create a public object funcCalc of delegate type and pass the function Calc as an argument.
  </details>
<br>
<details>
  <summary>
  Description of Task 2
  </summary>

    
    Define a class StringExtensions with an extension method WordCount(…) for class String that counts the number of words in a given string. 

    1. The 'word' means the sequence of letters, digits, and service symbols, which are limited by a space or punctuation symbol.
    2. Try to use string.Split() method and pass array of delimiters (' ', '.', '?', '!', '-', ';', ':', ',') as the first parameter. 
  </details>
<br>

<details>
  <summary>
  Description of Task 3
  </summary>

    Define a static method ListWithPositive that receives the List of negative and positive elements as a parameter. 

    The method  ListWithPositive uses the FindAll method on the List type. The argument to FindAll will use the anonymous method syntax. The predicate in FindAll will use an evaluated boolean expression, causing the anonymous function to return true if the argument is positive and less than or equal to 10.

    The method  ListWithPositive returns the list of positive elements.
  </details>
<br>
<details>
  <summary>
  Description of Task 4
  </summary>

    Define a class IListExtensions with an extension method IncreaseWith(…) that takes an instance of a class, that implements the interface list of integers (IList<int>). Method IncreaseWith(…) increases the value of each item by a certain number. 

    Define a class  IEnumerableExtensions with an extension method ToString(). ToString() loops through a collection and converts a sequence of elements (list of integers) to a meaningful string (items separated with ', ' and surrounded with '[' and ']').
  </details>
<br>

<details>
  <summary>
  Description of Task 5
  </summary>

    Define an event  Show of EventHandler type.

    Define four static methods: Dog(), Cat(), Mouse(), Elephant(). Each method outputs the corresponding inscription of an animal: "Dog", "Cat", "Mouse" or "Elephant".

    Define the class EventProgram and constructor with these four method instances added to the invocation list of Show event. Invoke event out of the constructor.
  </details>
<br>


## Tasks INTERFACES
<details>
  <summary>
  Description of Task 1
  </summary>
    

    Define an Interface ISwimmable with declared method Swim() printinging the text "I can swim!" by default.

    Define an interface IFlyable with read-only property MaxHeight returning 0 by default (use default implementation for this property).

    In this interface, declare a method Fly() printing the text "I can fly at XX meters height!" by default, where XX is the value of MaxHeight property.

    Define an interface IRunnable with read-only property MaxSpeed returning 0 by default (use default implementation for this property).

    In this interface, declare a method Run() printing the text "I can run up to XX kilometers per hour!" by default, where XX is the value of MaxSpeed property.

    Define an interface IAnimal with read-only property LifeDuration returning 0 by default (use default implementation for this property).

    In this interface, declare a method Voice() printing the text "No voice!" by default.

    Besides, declare a method ShowInfo() printing the text "I am a XX and I live approximately YY years." by default,
    where XX is the name of the class implementing the interface,
    YY is the value of LifeDuration property.

    Define a class named Cat implementing the IAnimal and IRunnable interface.

    In this class, implement autoproperties as needed.

    Implement the Voice() method printing "Meow!"

    Define a class named Eagle implementing the IAnimal and IFlyable interface.

    In this class, implement autoproperties as needed.

    Define a class named Shark implementing the IAnimal and ISwimmable interface.

    In this class, implement autoproperties as needed.
  </details>
<br>
<details>
  <summary>
  Description of Task 2
  </summary>
    

    Define an interface IAnimal with property Name, methods Voice() and Feed()

    Define two classes Cat and Dog, which implement this interface.

    For the class Dog,
    the Voice() method should print "Woof" on the Console,
    the Feed() method should print "I eat meat" on the Console.

    For the class Cat,

    the Voice() method should print "Mew" on the Console,
    the Feed() method should print "I eat mice" on the Console.
  </details>
<br>

<details>
  <summary>
  Description of Task 3
  </summary>


    Define ColourEnum enum consisting of 3 colours : Red, Green, Blue (give names according to the convention).

    Define an interface IColoured with read-only property Colour returning red colour by default (use default implementation for this property).

    Define an interface IDocument with the following members:

    - static field defaultText with the value "Lorem ipsum";

    - public property Pages, which means the number of pages, with default implementation returning 0 by default;

    - public property Name without default implementation (String);

    - method AddPages with default implementation that increments the property Pages by the number which is input parameter of the method;

    - method Rename with default implementation that changes the property Name to the one specified as input parameter of the meth
    Define a class ColouredDocument implementing both interfaces above. The class should have public properties Name, Pages and Colour. Do not implement any methods in the class. Define a constructor for this class with colour parameter along with default constructor.

    Define a class Example with a void static method Do. In this method, create an instance doc1 of the class ColouredDocument with Name="Document1". Change the name of the document to "Document2" using the Rename method. Print into console this property before and after renaming
  </details>
<br>

## Tasks COLLECTIONS

<details>
  <summary>
  Description of Task 1
  </summary>
  

    We have the next collection:  

    Dictionary<string, string> persons = new Dictionary<string, string>();
    {
    persons.Add("id11111", "Admin");
    persons.Add("id12345", "User1");
    persons.Add("id98765", "User2");
    persons.Add("id56743", "User3");
    persons.Add("id73920", "User4");
    }
    1) In class MyProgram please create a method that should take a collection of arguments SearchKeys(Dictionary<string, string> persons) in which print all keys from this collection

    2) method that should take a collection of arguments SearchValues(Dictionary<string, string> persons) in which print all values from this collection

    3) and method that should take a collection of arguments SearchAdmin(Dictionary<string, string> persons) in which search value "Admin" and print information in format Key + " " + Value 
  </details>
<br>

<details>
  <summary>
  Description of Task 2
  </summary>
    

    You have the next Main realization: 

    {
    var products = new List<Product>();
    products.Add(new Product { Name = "SmartTV", Price = 400, Category = "Electronics" });
    products.Add(new Product { Name = "Lenovo ThinkPad", Price = 1000, Category = "Electronics" });
    products.Add(new Product { Name = "Iphone", Price = 700, Category = "Electronics" });
    products.Add(new Product { Name = "Orange", Price = 2, Category = "Fruits" });
    products.Add(new Product { Name = "Banana", Price = 3, Category = "Fruits" });
    ILookup<string, Product> lookup = products.ToLookup(prod => prod.Category);
    TotalPrice(lookup);
    Console.ReadKey();
   }

    Please create a method TotalPrice(ILookup<string, Product> lookup) in which print (Name + " " + Price) from one category and total price for products from these categories (Key + " " + totalPriceForCategory)
  </details>
<br>

<details>
  <summary>
  Description of Task 3
  </summary>

    In class MyProgram:
    1) Create a method that should take a collection of arguments Position(List<int> numbers) in which find and Console.WriteLine all positions of element 5 in this collection

    2) Create a method that should take a collection of arguments Remove(List<int> numbers) in which remove from collection all elements, which are greater than 20. and print collection

    3) Create a method that should take a collection of arguments Insert(List<int> numbers)  in which insert elements -5,-6,-7 in positions 3, 6, 8 and print collection

    4) Create a method that should take a collection of arguments Sort(List<int> numbers) in which sorting collection and print collection

  </details>
<br>

## Tasks IENUMERABLE
<details>
  <summary>
  Description of Task 1
  </summary>

    There are children that stand in a circle. They use a counter to get them one by one out of the circle. Counter characteristic is a number of syllables. Children cont themselves with the counter and the child on whom the counter ends, leaves the circle.

    You need to create class CircleOfChildren, add a constructor with IEnumerable<string> parameter that will represent children in the circle.

    Add named iterator  GetChildrenInOrder that takes two int parameters: first for syllables count and second for a count of children that should leave the circle.

    if syllables count is equal to or less than 0 than no children leave the circle.

    We should be able to call GetChildrenInOrder with only one parameter. In this case, all children leave the circle. 

    If the second parameter is bigger than the total amount of children in a circle than all children should leave the circle. The same with 0 or less value.



   For example, we have a circle with nicknames: Halya1,  Olya2, Ira3, Andriy4, Josh5 and suppose, all children should leave the circle. The counter has 3 syllables.

    Then exit order should be: Ira3, Halya1, Josh5, Olya2, Andriy4



    Also create OutputUtils class with static ExitOutput method that takes 3 parameters: CircleOfChildren, syllables count and count of children that should leave the circle

    The last parameter - optional.

    The method should print to console the names of children in the order of their living the circle. Print space after every name.
  </details>
<br>

<details>
  <summary>
  Description of Task 2
  </summary>

    Suppose, you have class Book:

    public class Book     
    {         
    public string Title { get; set; }         
    public string Author { get; set; }        
    public int PageCount { get; set; }         
    public Book(string title, string author, int pageCount)         
    {             
    Title = title;            
    Author = author;             
    PageCount = pageCount;
    }    


    Please, implement class Library with public property Books of generic IEnumerable type that can be set only inside the class,

   and public property Filter (generic predicate) that sets a condition on book. The default value of Filter: any book satisfies the condition.

    The constructor of Library class takes 1 parameter for initialization Books property.

    Implement GetEnumerator method that will allow to enumerate by only those books that satisfy the condition in Filter.

    Do not use yields in this task.

    Create  MyEnumerator class that implements IEnumerator<Book>.

    The constructor of MyEnumerator takes 2 parameters: for initialization books and filter.

    Implement all the necessary methods and properties in MyEnumerator.



    Implement MyUtils class with public static method GetFiltered that takes generics IEnumerable and Predicate and returns list of filtered books using Library class and its enumerator.
  </details>
<br>

<details>
  <summary>
  Description of Task 3
  </summary>

    Inside a class ShowPower define a static method SuperPower(). SuperPower() has two integer input parameters: number and degree. The method will  calculate the power of a given number according to degree parameter.

    Note: Don't use Pow().

    The method involves to yield the intermediate result of the calculation on the each iteration.
  </details>
  <br>

  <details>
  <summary>
  Description of Task 4
  </summary>
  

    Within the class, ShowPowerRange create a static method PowerRanger() that takes in integer degree, start, finish. 

    The method returns all the numbers from the range [start, finish] (inclusive and finish > 0 and start > 0) that are equal to the degree-th power of any positive integer.

    In the case start > finish, or start < 0, or finish < 0 the method returns 0.

    The method involves yielding the intermediate result on each iteration.
  </details>
<br>



## TasksLINQ

<details>
  <summary>
  Description of Task 1
  </summary>

    Please, implement the SumOfElementsOddPositions method that returns sum of elements with odd indexes in the array of doubles

    (You don't need to verify on null parameter value. Assume that parameter will always be not null)
  </details>
<br>

<details>
  <summary>
  Description of Task 2
  </summary>

    Please, implement EvaluateAggregate method that takes 

    an array of doubles as the first parameter, 

    a delegate that defines an aggregate behavior as the second, 

    a delegate that defines a condition for the index as the third parameter.

    The method should return a result of an aggregate operation for the elements with indexes that satisfy the condition set by the third parameter

    (You don't need to verify on null parameter values. Assume that parameters will always be not null)
  </details>
<br>

<details>
  <summary>
  Description of Task 3
  </summary>

    Please, create a method ProductWithCondition that takes a list of integers as a parameter and returns a product of elements that satisfy a condition that is passed as a second parameter.

    The second parameter should be a Func that takes an integer as a parameter and returns bool.

    If the first parameter or result of filtering contains 0 elements the method must return 1.

    (You don't need to verify on null parameter values. Assume that parameters will always be not null)
  </details>
<br>

<details>
  <summary>
  Description of Task 4
  </summary>

    Please, create a static method GetWord takes 2 string parameters: 

   first - initial string with a sequence of words separated by space 

    second - a word for comparison.

    The method should find the longest word in the first parameter, that is longer than the second parameter if there is one, 

    otherwise, the second parameter should be the result of the search.

    The method should return the part of the found word, starting from the first 'a' char. 

    If there isn't 'a' char in the found word, the method should return an empty string.

    (You don't need to verify on null parameter values. Assume that parameters will always be not null)
  </details>
<br>

<details>
  <summary>
  Description of Task 5
  </summary>
  

    Please, create Department class with public string property Name, int Id and Worker Manager.

    Create constructor with string, int and Manager parameters for initializing the properties.

    Create Worker class with public int property Id, string Name, decimal Salary and Department Department.

    Create constructor with string, decimal, Department parameters to initialize the properties.

   Implement public Serialize method that returns string that contains serialized Worker object in json format.

    Worker that is created like this 

    Worker w = new Worker("Anna", 700, new Department("Mechanics", 1, new Worker("Tom", 600, null)));     * 
    should be serialized into the next string:     

    {
    "Full name": "Anna",
    "Salary": 700,
    "Department": {
   "Name": "Mechanics",
    "Id": 1,
    "Manager": {
    "Full name": "Tom",
    "Salary": 600
   }
    }
    }
    note that Id property should not be serialized and Name property should be represented as Full name

    Also, implement public static method Deserialize that takes a string as a parameter and returns a deserialized Worker object from it.
  </details>
<br>

## Tasks MULTITHREADING

<details>
  <summary>
  Description of Task 1
  </summary>

  
    Implement ParallelUtils class that will be able to execute an operation in a parallel thread.

    The constructor of ParallelUtils takes 3 parameters: 

    1) The Func<T, T, TR> to define an operation that will be executed, 

    2) The operand1 of type T 

    3) Tperand2 of type T.

    The ParallelUtils class should have public Result property of type TR where the result of the operation must be written when it's executed.

    Implement method StartEvaluation that will start the evaluation (of the function passed into constructor) in a parallel thread 

    Implement method Evaluate that will start the evaluation (of the function passed into constructor) in a parallel thread and wait until it's executed
  </details>
<br>

<details>
  <summary>
  Description of Task 2
  </summary>

    We have the class MainThreadProgram. Please create three methods: Calculator, Product, and Sum.

    Method Sum() should ask the user to enter 5 numbers in the form “Enter the 1st number:”, “Enter the 2nd number:” etc. and calculate their sum. After that, it should output the message “Sum is: <sum>”. 

    Method Product() should generate a List of 10 consequent integer numbers from 1 to 10 and calculate their product. Then it should wait for 10 seconds. After that, it should output the message “Product is: <product>”. 

    The Calculator() method should create two threads: productThread and sumThread, and call the Product and Sum methods in appropriate threads. This method should return a tuple of two threads: (sumThread, productThread).
  </details>
<br>

<details>
  <summary>
  Description of Task 3
  </summary>

    Please, look at the code below.

    static void Tasks()
    {
    int[] sequence_array = new int [10];
    Task「］tasksl = new Task[3]
    {
    new Task(() =>
    {
    for (int 1 = 0; 1 < 10; 1++)
    {
    sequence_array［i］=i*i；
    }
    Console WriteLine ("Calculated!");
    }),
    new Task(() =›
    {
    for（int 1=0,i< 10;i++）
    {
    Console.Writeline (i);
    }
    Console.WriteLine ("Bye!");
    });
    new Task(() =>
    {
    for （int i= 0;i<10;1++）
    ｛
    Console WriteLine (sequence_array [1]);
    }
    Console WriteLine("Bye!");
    })
    };
    Console WriteLine("Work Done! ");
    }

    Please, refactor this code so that Tasks() gives the next output:
    Calculated!
    0
    1
    2
    3
    4
    5
    6
    7
    8
    9
    Bye!
    0
    1
    4
    9
    16
    25
    36
    49
    64
    81
    Bye!
    Main done!
  </details>
<br>

<details>
  <summary>
  Description of Task 4
  </summary>

    Please create a class MyProgram.

    Create a method Counter that takes one parameter of int type.

    This method should start two threads. 

    One of them calculates the factorial of Counter's argument (n! = 1 * 2 * ... * (n - 1) * n).

    The second thread calculates the appropriate number of Fibonaci sequence (fibo(0) = 0, fibo(1) = 1, ... fibo(n) = fibo(n-1) + fibo(n-2)).

    Please implement the additional methods.

    Method Counter should display two messages:

    "Factorial is: <factorial>"

    "Fibbonaci number is: <fibo>".

    The sequence of outputs matters.

    Example:

    Input: MyProgram.Counter(4);

    Output:  

    Factorial is: 24

    Fibbonaci number is: 3
  </details>
<br>

<details>
  <summary>
  Description of Task 5
  </summary>

    You have MyThreads class in the answer window below. Please, investigate it: there is some problem with this class.

    Fix the problem.



    The test starts both threads with the code:

    MyThreads.Thread1.start();
    MyThreads.Thread2.start();


    The goal of each thread is to make some evaluations, update m and n fields and not switch between threads while loop is executed.



    You need to get an output like this:



    Thread1 n = 0
    Thread1 n = 1
    Thread1 n = 2
    Thread1 n = 3
    Thread1 n = 4
    Thread2 m = 0
    Thread2 m = 1
    Thread2 m = 2
    Thread2 m = 3
    Thread2 m = 4
    Thread2 n = 5
    Thread2 n = 6
    Thread2 n = 7
    Thread2 n = 8
    Thread2 n = 9
    Thread2 success!
    Thread1 m = 5
    Thread1 m = 6
    Thread1 m = 7
    Thread1 m = 8
    Thread1 m = 9
    Thread1 success!
    Please, don't change actions that change variables or print output within run() methods. Use only thread synchronization assets.
  </details>
<br>


## Tasks ASYNCHRONOUS 

<details>
  <summary>
  Description of Task 1
  </summary>

    Suppose we have a class named Calc which has a method Seq
    generating n-th member of a certain number sequence (starting from 1).

    Define a class named CalcAsync. In this class:

    Write an asynchronous static method PrintSeqAsync taking integer parameter n,
    that prints out the following:
    "Seq[X] = Y", where X is the value of input parameter n, Y is n-th member of the sequence.
    Use Task as return type.
  </details>
<br>

<details>
  <summary>
  Description of Task 2
  </summary>

    Suppose we have a class named Calc which has a method Seq
    generating n-th member of a certain number sequence (starting from 1).

    Define a class named CalcAsync. In this class:

    Write an asynchronous static method TaskPrintSeqAsync taking integer parameter n,
    that prints out the following:
    "Seq[X] = Y", where X is the value of input parameter n, Y is n-th member of the sequence.
    Use Task as return type

    Implement an extention method named PrintStatusIfChanged
    which takes, as parameters, a task along with its previous status,
    prints out the status if it was changed, and updates the old one (given by the parameter).

    Implement an extention method named TrackStatus which takes, as a parameter, a task,
    and continuously checks a status of the task, and prints out its status if changed.
  </details>
<br>

<details>
  <summary>
  Description of Task 3
  </summary>

    Suppose we have a class named Calc which has a method Seq
    generating n-th member of a certain number sequence (starting from 1).

    Define a class named CalcAsync. In this class:

    Write an asynchronous stream called SeqStreamAsync taking integer parameter n,
    that returns a collection of n tuples
    consisting of a number i (from 1 to n) and i-th member of the sequence.

    Write an asynchronous static method PrintStream
    taking an asynchronous stream of tuples consisting of 2 integer numbers,
    which prints the collection as follows:
    "Seq[X] = Y", where X is the first item of a tuple, Y is the second one.
  </details>
<br>

<details>
  <summary>
  Description of Task 4
  </summary>

    Suppose we have a class named Calc which has a method Seq
    generating n-th member of a certain number sequence (starting from 1).

    Define a class named CalcAsync. In this class:

    Write an asynchronous static method PrintSpecificSeqElementsAsync
    taking an array of integers as a patameter,
    which performs a calculation of apropriate sequence member
    according to each number in the input array
    and prints out the result as follows:
    "Seq[X] = Y", where X is a number from input array, Y is the corresponding sequence member.
    Each calculation should be performed in a separate task.
    After last calculation is performed, the list of found exceptions should be printed.

    (The method Seq generates appropriate exception for non-positive input parameter.)
  </details>
<br>



## Tasks REFLECTION

<details>
  <summary>
  Description of Task 1
  </summary>

    Create a class ReflectFields with public static string field Name and three public static int fields: MeasureX, MeasureY, and MeasureZ.

    Within this class define a public static  method OutputFields() which contains the loop through fields of the class ReflectFields and display  (in console) their names and values as the formatted string ("{0} (<type>) = {1}", name, value). <type> means the string representation of int or string type of field.

    Note. System.Reflection provides a way to enumerate fields and properties. We get the FieldInfo objects for those fields and then display them.
  </details>
<br>

<details>
  <summary>
  Description of Task 2
  </summary>

  
    Within the class ReflectMethod you have to:

    1) define the public static class Methods with three public static methods: Hello(), Welcome() and Bye(). Each of them takes a string parameter and provides the console output of formatted string according to its name:

    ("Hello:parameter={0}", parameter)

    ("Welcome:parameter={0}", parameter)

    ("Bye:parameter={0}", parameter)

    2) define the public static method InvokeMethod() which takes the string array as parameter. 

    The logic of the method involves:

    - to form a collection of methods from the class Methods, 

    - to iterate over this collection by the method name, 

    - to invoke the method and pass it parameters from the array one by one.
  </details>
<br>

<details>
  <summary>
  Description of Task 3
  </summary>

    
    Within the class ReflectProperties you have to:
    1) create public class TestProperties with four properties:
    - public string FirstName;
    - internal string LastName;
    - protected int Age;
    - private string PhoneNumber.
    2) define a static method WriteProperties() that contains logic:
    - form the collection of the properties of TestProperties class;
    - iterate through the collection;
    - provide the console output of the name, type, read/write ability, and accessibility level of every property.
  </details>
<br>

<details>
  <summary>
  Description of Task 4
  </summary>

  
    Within the class ReflectorAssembly you have to:

    1) define three classes LargeBox, Box, and SmallBox. Each of them contains two static methods with string parameter size:

    -  UnPackingBox() outputs in console ("I am unpacking {0} box.", size);

    - InBox() - ("I am in {0} box.", size);

    2) define two interfaces: 

    - ILookingForBox with static method LookForBox() takes string parameter;

    - IPackingBox with static method PackBox() takes a string parameter.

    3) define the static  method WriteAssemblies() which contains the following logic:

    - get calling assembly;

    - get all types within the assembly;

    - iterating through the collection of types;

    - providing the output is it class, method, and name of the type;

    - all methods of the class have to be invoked with the parameter according to the name of the class.

    Note. You have to exclude classes Task and Reflector (with their methods) from the output.
  </details>
<br>

<details>
  <summary>
  Description of Task 5
  </summary>

    Within the class ReflectFullClass define a static method WriteAllInClass(). The method will take one parameter of Type type (f.e. class). 

    The method outputs a greeting with the class and allows it to iterate through the class and output the names of all custom members of the class (fields, properties, methods), 
    interfaces, and the total quantity of every member and interface.
  </details>
<br>












































