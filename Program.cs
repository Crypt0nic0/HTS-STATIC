using STATIC;

new Class1().AjouterElement();
new Class2().AjouterElement();

foreach (var e1 in MonCache.GetValues())
{
    Console.WriteLine(e1);
}

