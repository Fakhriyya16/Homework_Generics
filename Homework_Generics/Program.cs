
using Homework_Generics;

//IntList intList = new IntList();

//intList.Add(1);
//intList.Add(2);
//intList.Add(3);

//var datas = intList.GetAll();

//foreach (var data in datas)
//{
//    Console.WriteLine(data);
//}


DataList<int> dataList = new();

DataList<string> dataList2 = new();

DataList<bool> dataList3 = new();

dataList.Add(1);
dataList.Add(2);
dataList.Add(3);

var result = dataList.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

dataList2.Add("hello");
dataList2.Add("bye");

var result2 = dataList2.GetAll();

//foreach (var item in result2)
//{
//    Console.WriteLine(item);
//}


dataList3.Add(true);
dataList3.Add(false);
dataList3.Add(true);

var result3 = dataList3.GetAll();

//foreach (var item in result3)
//{
//    Console.WriteLine(item);
//}


DataList<Book> dataList4 = new();

dataList4.Add(new Book { Id = 1, Name = "book1" });
dataList4.Add(new Book { Id = 2, Name = "book2" });
dataList4.Add(new Book { Id = 3, Name = "book3" });

var result4 = dataList4.GetAll();

//foreach(Book book in result4)
//{
//    Console.WriteLine(book.Name);
//}

DataList<int> intDatas = new();

intDatas.Add(1);
intDatas.Add(2);
intDatas.Add(3);

var data =  intDatas.GetAll();

//foreach (var item in data)
//{
//    Console.WriteLine(item);
//}

intDatas.Delete(2);

var newData =  intDatas.GetAll();

//foreach (var item in newData)
//{
//    Console.WriteLine(item);
//}


DataList<string> stringList = new();

stringList.Add("Hello");
stringList.Add("Code Academy");
stringList.Add("Bye");

var stringDatas = stringList.GetAll();

//foreach(var item in stringDatas)
//{
//    Console.WriteLine(item);
//}

stringList.Delete("Hello");

var newStringData = stringList.GetAll();

//foreach (var item in newStringData)
//{
//    Console.WriteLine(item);
//}