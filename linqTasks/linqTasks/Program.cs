using static LinqTasks.ListGenerators;
using LinqTasks;


// var prds = ProductList.Where(p=>p.UnitsInStock == 0);
//  prds = ProductList.Where(p=>p.UnitsInStock >0 && p.UnitPrice > 3m);

//foreach (var item in prds)
//{
//    Console.WriteLine(item);
//}




//string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
//for (int i = 0; i < Arr.Length; i++)
//{
//    if (Arr[i].ToString().Length < i)
//    {

//        Console.WriteLine(Arr[i]);
//    }

//}


//var prod = ProductList.First(p=>p.UnitsInStock==0);
//var prod = ProductList.FirstOrDefault(p=>p.UnitPrice>1000);

//Console.WriteLine(prod);



//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//var prod = Arr.Where(p => p > 5).Skip(1).FirstOrDefault();

//Console.WriteLine(prod);





//var prod = ProductList.Select(p => p.Category).Distinct();
//foreach (var item in prod)
//{
//    Console.WriteLine(item);
//}



//int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

//var num = Arr.Where(x => x % 2 != 0).Count();
//Console.WriteLine(num);



var c = CustomerList.Select(p=>p.Orders);

foreach (var item in c)
{
    for (var i = 1;item.Length > 0; i++)
    {
        Console.WriteLine(item[i]);

    }
}

















