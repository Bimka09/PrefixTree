using PrefixTree;

var a = new PrefTree();
a.insert("dog", "cat");
Console.WriteLine(a.StartsWith("cat"));
Console.WriteLine(a.Search("cat"));