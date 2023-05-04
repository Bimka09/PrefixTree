using PrefixTree;

var a = new PrefTree();

a.insert("apple");
Console.WriteLine(a.Search("apple"));   // return True
Console.WriteLine(a.Search("app"));     // return False
Console.WriteLine(a.StartsWith("app")); // return True
a.insert("app");
Console.WriteLine(a.Search("app"));