﻿// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Runtime.Intrinsics.Arm;
using CsharpTraining_jan2725;



// Day -2 

//ArrayProg ar = new ArrayProg();
//ar.find();
//ar.Multidimenstional();
//ar.JoggedArray();
//ar.joggedString();
//ar.joggedMultidimenstionalArray();


//EvenOdd eo = new EvenOdd();
//eo.evenOdd();

//MoveZeros move = new MoveZeros();
//move.moveZeros();


// Day - 3

//Console.WriteLine("Enter Dog Name:");
//String name = Console.ReadLine();

//Dog dog = new Dog();
//dog.SetName(name);

//Console.WriteLine(dog.GetName());
//dog.Eat();



// Day- 4

//Console.WriteLine("Enter three Person Name:");
//Person[] parr = new Person[3];

//// 1st way

////for(int i = 0; i < parr.Length; i++)
////{
////    parr[i] = new Person() { Name= Console.ReadLine() };

////}


//// 2nd way
//for(int i = 0; i < parr.Length; i++)
//{
//    parr[i] = new Person(Console.ReadLine());
//}


//for (int i = 0; i < parr.Length; i++)
//{
//    Console.WriteLine(parr[i].ToString());
//}



//// StudnetProfessorTest.cs

//Person2 person = new Person2();
//person.Greet();

//Student student = new Student();
//student.SetAge(22);
//student.Greet();
//student.ShowAge();
//student.Study();

//Professor professor = new Professor();
//professor.SetAge(24);
//professor.Greet();
//professor.Explain();


//// PhotoBookTest.cs

//PhotoBook photoBook1 = new PhotoBook();
//Console.WriteLine(photoBook1.GetNumberPages());
//PhotoBook photoBook2 = new PhotoBook(24);
//Console.WriteLine(photoBook2.GetNumberPages());
//BigPhotoBook bigPhotoBook1 = new BigPhotoBook();
//Console.WriteLine(bigPhotoBook1.GetNumberPages());




// Collections

//// List    - is Generic Collection - It is Index based 

// create List
//List<int> id = new List<int>() { 535, 471, 469 };


//// Accessing the Elements
//Console.WriteLine(id[0]);

//// Add elements to List
//id.Add(21);
//id.Add(14);

//// Insert Element into the List
//id.Insert(2, 4);

////Remove Element from the List
//id.Remove(21);

//// Remove Element at specific Index
//id.RemoveAt(4);

//id.Sort();

//Console.WriteLine(id.BinarySearch(535));

//// Iterating the List
//for (int i = 0; i < id.Count; i++)
//{
//    Console.Write(id[i] + " ");
//}

// Console.WriteLine(id);    // it display object addres



//List<String> Languages = new List<String>() { "Telugu", "English", "Hindi" };
//Languages.Add("Kanada");
//Languages.Add("Malayali");
//Languages.Add("Bengali");
//Languages.Add("Assam");

//Console.WriteLine(Languages[2]);

//Languages.Insert(1,"Tamil");

////Languages.Remove("Malayali");
////Languages.RemoveAt(6);

//Languages.Sort();
//Console.WriteLine(Languages.BinarySearch("Kanada"));

////for (int i = 0; i < Languages.Count; i++)
////{
////    Console.Write(Languages[i]+" ");
////}

//String input = Console.ReadLine();
//foreach (String ele in Languages)
//{
//    if(ele==input)
//    Console.Write(ele+" ");
//}


// ArrayList  - index based - non-generic type  - allows different data types
//object d=14;
//ArrayList emp = new ArrayList() { "Dinesh",22,5.5,true,d};
//emp.Add(25);
//emp.Add("Spark");

//Console.WriteLine(emp.Count);
//Console.WriteLine(emp[6]);
//emp[5] ="Wipro";

//emp.Remove(true);
//emp.RemoveAt(2);
//Console.WriteLine(emp.Count);

////for (int i=0; i < emp.Count; i++)
////{
////    Console.Write(emp[i]+" ");

////}

//foreach(object item in emp)
//{
//    Console.Write(item + " ");
//}


// Stack - generic type - stored similar data types - LIFO 

//Stack<String> car = new Stack<String>();

//car.Push("BMW");
//car.Push("Tayota");
//car.Push("Maruthi");

//Console.WriteLine(car.Pop());
//Console.WriteLine(car.Peek());

//foreach( String ele in car)
//{
//    Console.Write(ele+" ");
//}

/* Queue - generic type  - follow FIFO - allows similar type data 
   -> elements that are added first will be removed first
    -> it has two ends  1>rear - elements added 2>front - elements removed  
    -> peek  - displays front element.
*/

//Queue<int> fruits = new Queue<int>();
//{
//    fruits.Enqueue(4);
//    fruits.Enqueue(1);
//    fruits.Enqueue(3);

//    Console.WriteLine(fruits.Dequeue());
//    Console.WriteLine(fruits.Peek());
//    Console.WriteLine(fruits.Contains(5));
//    Console.WriteLine(fruits.Contains(3));

//    foreach (int items in fruits)
//    {
//        Console.Write(items+" ");
//    }
//}


/* Sorted List  
 * -> accessing with index based starting with zero 
 * -> non-generic type  
 * -> dictonary type (Key,Value)
 * -> Keys are sorted in order
 */

//SortedList student = new SortedList() { { 2, "Dinesh" },{ 1, "Obulesu" } };
//student.Add(4,5);
//student.Add(3,false);

//for(int i = 0; i < student.Count; i++)
//{
//    Console.WriteLine(student[i]);
//}
//Console.WriteLine(student[4]);
//Console.WriteLine(student[8]);

//student.Remove(3);

//for(int i = 0; i < student.Count; i++)
//{
//    Console.WriteLine("{0}:{1}",student.GetKey(i),student.GetByIndex(i));
//}

//student.RemoveAt(2);

//for (int i = 0; i < student.Count; i++)
//{
//    Console.WriteLine("{0}:{1}", student.GetKey(i), student.GetByIndex(i));
//}


//  HashTable
//  -> non-generic  Collection - stores as Key-value Pair - acces based on keys 
// key must be unique and not null - values can be duplicate and null

/*
Hashtable table = new Hashtable();

table.Add("India","Modi");
table.Add("China",3);
table.Add("America",1);

Console.WriteLine(table["America"]);
Console.WriteLine($"original value:{table["China"]}");
table["China"] = "carona";
Console.WriteLine($"changed value:{table["China"]}");

foreach(var item in table)
{
    Console.WriteLine("Key={0}",item);
}
foreach(var item in table)
{
    Console.WriteLine("Value={0}",item);
}

table.Remove("America");

Console.WriteLine("After removing");
foreach(DictionaryEntry item in table)
{
    Console.WriteLine("{0}:{1}",item.Key,item.Value);
}
*/

// Dictinary 
// -> it is a generic type- stores data like key value pair - not stored in ordered - accessed based on keys 

/*
Dictionary<int, String> books = new Dictionary<int, String>();
books.Add(3,"rich dad");
books.Add(1,"vivekananda");
books.Add(4, "csharp");
books.Add(2,"react");

Console.WriteLine(books[1]);
books[4] = ".net";
Console.WriteLine("Before deletion");
foreach(KeyValuePair<int, String> item in books)
{
    Console.WriteLine("{0}:{1}", item.Key, item.Value);
}
Console.WriteLine(books.Remove(2));

Console.WriteLine("After deleton");
foreach(KeyValuePair<int,String> item in books)
{
    Console.WriteLine("{0}:{1}",item.Key,item.Value);
}
*/




// Day - 5

// Exception Handling


// User Defined -Exception

//ExceptionProg ue = new ExceptionProg();
//ue.weightException();






// File Handling 
//86876786,878979723,"1/16/2021 3:31:22 PM"
//Transaction t1 = new Transaction(1, 86876786, 878979723, "1/16/2021 3:31:22 PM", "Failed", "Jio");
//t1.ReadTransaction();

//Transaction t2 = new Transaction(1, 86876786, 878979723, "1/16/2021 3:31:22 PM", "Failed", "Jio");
//t2.ReadTransaction();

//Transaction t3 = new Transaction(1, 86876786, 878979723, "1/16/2021 3:31:22 PM", "Failed", "Jio");
//t3.CreateTransaction();
//Transaction t4 = new Transaction(1, 86876786, 878979723, "1/16/2021 3:31:22 PM", "Failed", "Jio");
//t4.CreateTransaction();
//Transaction t5 = new Transaction(1, 86876786, 878979723, "1/16/2021 3:31:22 PM", "Failed", "Jio");
//t5.CreateTransaction();
//Transaction t6 = new Transaction(1, 86876786, 878979723, "1/16/2021 3:31:22 PM", "Failed", "Jio");
//t6.CreateTransaction();
//Transaction t7 = new Transaction(1, 86876786, 878979723, "1/16/2021 3:31:22 PM", "Failed", "Jio");
//t7.CreateTransaction();
//Transaction t8 = new Transaction(1, 86876786, 878979723, "1/16/2021 3:31:22 PM", "Failed", "Jio");
//t8.CreateTransaction();
//Transaction t9 = new Transaction(1, 86876786, 878979723, "1/16/2021 3:31:22 PM", "Failed", "Jio");
//t9.CreateTransaction();
//Transaction t10 = new Transaction(1, 86876786, 878979723, "1/16/2021 3:31:22 PM", "Failed", "Jio");
//t10.CreateTransaction();
//Transaction t11 = new Transaction(1, 86876786, 878979723, "1/16/2021 3:31:22 PM", "Failed", "Jio");
//t11.CreateTransaction();
//Transaction t12 = new Transaction(1, 86876786, 878979723, "1/16/2021 3:31:22 PM", "Sucess", "idea");
//t12.CreateTransaction();


//day -6
// Assignments

//SecondLargestElementArray sl = new SecondLargestElementArray();
//int[] arr = {12,35,1,10,34,1 };
//int[] arr2 = { 10,5,10};
//int[] arr3 = { 10,10,10};
//int result = sl.findSecondLargest(arr3);
//Console.WriteLine(result);


//MaxConsecutiveOnesCount max = new MaxConsecutiveOnesCount();
//int[] arr = {1,1,0,0,1,0,1,0,1,1,1,1};
//Console.WriteLine("Maximum consecutive is: "+max.MaxConsecutiveElements(arr,1));

//int[] arr2 = { 0,0,1,0,1,0,1,0,1,0,1};
//Console.WriteLine("Maximun Consecutive is: "+max.MaxConsecutiveElements(arr2,0));

//MissingAndRepeatingArr mr = new MissingAndRepeatingArr();
//int[] arr2 = { 4,3,6,2,1,1};
//int[] arr = { 3, 1, 3 };
//mr.findMisssingAndRepeating(arr2,6); 

//DuplicateCharacterInString dc = new DuplicateCharacterInString();
//string str = "google";  // Console.ReadLine().ToLower()   - for case insensitivity.    
//dc.findDuplicate(str);

//UniqueCharInStr uc = new UniqueCharInStr();
//string str = "google";
//uc.GetUniqueCharacters(str);

//ReverseEachWordInStr rw = new ReverseEachWordInStr();
//string str = "My name is Vasu";
//rw.reverseEachWord(str);

//ExtractNumericCharacters enc = new ExtractNumericCharacters();
//string[] arr = { "apple1", "banana2", "cherry3" };
//enc.extractNumberFromString(arr);

//Transaction t = new Transaction();
//t.ReadTransaction();

//Network n = new Network();
//n.ReadDateFromFile();


// Day -7

// DelegateDemo d1 = new DelegateDemo();

// SingleCast delegate
//DelegateExample d2 = DelegateDemo.stay;
//DelegateExample d3 = new DelegateExample(DelegateDemo.edu);
//DelegateExample d4 = d1.course;
//d2();
//d3();
//d4();

// Multicast delegate
//delmethod d5 = new delmethod(DelegateDemo.add);
//d5 += new delmethod(d1.sub);
//d5(20,30);
//d5 -= new delmethod(DelegateDemo.add);
//d5(10,40);

// SingleCast delegate Event
//d1.MyEvent += new MyDelegate(d1.Display);
//d1.RaiseEvent();

// MultiCast delegate Event
//d1.MyEvent += new MyDelegate(DelegateDemo.add);
//d1.MyEvent += new MyDelegate(d1.sub);
//d1.RaiseEvent(5,7);



//FuncActionPredecate fap1 = new FuncActionPredecate();
//assigning function as parameter as delegate
//FuncActionPredecate.InvokeDelegate(FuncActionPredecate.PrintNumber, 35);
// assigning method to Func as a paramter /
//int res=FuncActionPredecate.PerformOperation(FuncActionPredecate.Square, 5);
//Console.WriteLine(res);
//  assigning method to Action as a paramter
//FuncActionPredecate.PerformOperation(FuncActionPredecate.PrintMessage,"Hello Dinesh, All is well");
// assigning method to Predicate as a parameter
//bool res=FuncActionPredecate.PerformOperation(FuncActionPredecate.isEven,4);
//Console.WriteLine(res);


// Day-10

//IPaymentProviderFactory factory = new PayPalFactory(); //new StripeFactory
//IPaymentProvider provider = factory.CreatePaymentProvider();
//provider.ProcessPayment(100.00m);


// Day-12

//SwapProgram sp1 = new SwapProgram();
//int a = 15, b = 19;
//sp1.Swap(ref a, ref b);
//Console.WriteLine("A Value is: "+a +" B Value is: "+b);
//String s1 = "Dinesh", s2 = "Kumar";
//sp1.Swap(ref s1,ref s2);
//Console.WriteLine("s1 Value is: " + s1 + " s2 Value is: " + s2);
//Boolean f1 = true, f2 = false;
//sp1.Swap(ref f1,ref f2);
//Console.WriteLine("f1 Value is: " + f1 + " f2 Value is: " + f2);

//ListExample li = new ListExample();
//li.ShowNames();

// new EmpExample().ShowEmploy();

//DelegateExample d1 = new DelegateExample();
//MyDelegate3 del1 =new MyDelegate3(d1.Greeting);
//del1("Dinesh");

//del1 += d1.Course;
//del1 -= d1.Greeting;
////del1("CSharpFS");

//del1 += DelegateExample.EndDate;
//del1("feb20");


// feb-9 th programs on exception Handling

//Practice1 p1 = new Practice1();
//int a = 14, b = 10;
//Console.WriteLine($"Before Swap: a value is: {a}, b value is: {b}");
//p1.Swap(ref a,ref b);
//Console.WriteLine($"After Swap: a value is: {a}, b value is: {b}");

//string s1 = "Dinesh", s2 = "Kumar";
//Console.WriteLine($"Before Swap: s1: {s1}, s2: {s2}");
//p1.Swap(ref s1, ref s2);
//Console.WriteLine($"After Swap: s1: {s1}, s2: {s2}");

//Boolean b1 = true, b2 = false;
//Console.WriteLine($"Before Swap: b1 is: {b1}, b2 is: {b2}");
//p1.Swap(ref b1, ref b2);
//Console.WriteLine($"After Swap: b1 is: {b1}, b2 is: {b2}");


//Practice2 p2 = new Practice2();
//p2.ShowNames();

//Practice3 p3 = new Practice3();
//p3.showEmploy();


//string s1 = "Dinesh ";
//s1.Concat("Kumar");
//Console.WriteLine(s1);

//StringBuilder s2 = new StringBuilder("Dotnet ");
//s2.Append("Full stack");
//Console.WriteLine(s2);



//Excep1 e1 = new Excep1();
//e1.runExcep1();


//Excep2.runExcep2();

//ElectionExcep1 ee2 = new ElectionExcep1();
//ee2.runExcep();

// Dotnet Day - 1 programs

//Day1 d1 = new Day1();
//d1.posNeg();

//Day1.Max3();

Day1.sumSub();













































