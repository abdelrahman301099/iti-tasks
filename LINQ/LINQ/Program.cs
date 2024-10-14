namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ => Language Integrated Query
            //      => +40 Extention methods for the classes that Implement
            //         Built-In interface "IEnumrable" Named as LINQ Existed at class Enumrable
            //         categorized to 13 category
            //      => We can use LINQ to deal with any type of DB
            // Sequence:
            // 1-Local (List, Array,.....)
            // 2- Remote (Data Base)


            //extention Method  static class => static function => add (this) in the function params

            //string str = "ss";
            //Console.WriteLine(str.extMethod());

            //Anonymous obj var emp = new {ID=12, Address= "Cairo"} ==>init by default (يعني بيتحط فيه داتا وقت الانشياليز فقط) emp.ID = 5 XXX

            //member function have this
            //static function hav not this 

            //=>Syntax of LINQ

            //List<int> nums = new List<int>() { 1,2,3,4,5,6};

            //1-Fluent
            //       1.1 call "call LINQ operator " as a static function through Enumrable class

            //var evenNums = Enumerable.Where(nums, item => item % 2 == 0);
            //foreach (var item in evenNums)
            //{
            //    Console.WriteLine(item);
            //}

            //1.2 call "LINQ opera tor" as extension method
            // var oddNums = nums.Where(num=>num % 2 == 1);
            //foreach (var item in oddNums)
            //{
            //    Console.WriteLine(item);
            //}

            //Query Syntax => Must begin with {from}, end with {select or group by}

            //var oddNums= from n in nums
            //             where n%2 == 0
            //             select n;


            //Excutin waies
            //1-Deffersd Excution (بيتنفذ ف الاخر خالص يعني لما بيحصله كومبيل)
            //EX
            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //var oddNums = nums.Where(n => n % 2 == 1);

            //nums.AddRange(new int[] { 7,8, 9, 10 });
            //foreach (var item in oddNums)
            //{
            //    Console.WriteLine();//expected 1 3 5(لان المفروض احنا زودنا بعد م عملنا الليست )
            //                        // actual 1 3 5 7 9(لان زي م قولنا هو بيستنى لحد اخر لحظه)
            //}
            //Immediate Excution(ب نضيف كاستينج اوبيراتور او اجريجيت عشان يتم التنفيذ ف نفس اللحظه)
            //var oddNums = nums.Where(n => n % 2 == 1).ToList();
            //or single return functions

            //LINQ 13 Categories


            //first category   input sequence ===> output sequence

            //second sequence  input sequence ====> output single value
            //second sequence  input void ====> output sequence


            //Defferd


            //1-Filteration/Restrection Operator {Where}
            // input => Func
            //return => bool
            //fluent Syntax or Query Syntax

            //=====>Indexed Where => valid only with flurnt syntax only
            //input => func(element, index)
            //return => bool





            //2-Transformation/Projection Operators {Select and select Many}
            //input => Func(ele)
            //return => TResult 
            //fluent Syntax or Query Syntax

            //=====>Indexed Selectae

            //var result = CustomerList.Select(c=>c.CustomerName) //return one string
            //var result = CustomerList.SelectMany(c=>c.orders) //return one group string =>بيكون اكبر من اللي داخل





            //3-Ordering Operators 
            //OrderBy =>Asc
            //OrderBy().ThenBy()
            //OrderByDecending =>Dsc
            //OrderBy().ThenByDescending ()

            //4-Generation Operartors  ===>valid Only with fluent Syntax
            //Enumrable.Range(0, 100)
            //Enumrable.Repeat(2, 20) >> repeat num 2 20times 
            //Enumrable.Empty<Product>().TArray() >> will create Array of size 0 


            //5-Set Operators >> Union Family

            //Seq01.Union(Seq02) >> Seq01, Seq02 shuild by froom the same DT >> remove duplication
            //Seq01.Concat(Seq02) >> Seq01, Seq02 shuild by froom the same DT >> does notremove duplication
            //Seq01.Distinct(Seq02) >> Seq01, Seq02 shuild by froom the same DT >>  remove duplication
            //Seq01.Intersect(Seq02) >> Seq01, Seq02 shuild by froom the same DT >>  المتشابه
            //Seq01.Except(Seq02) >>return element that not in seq02
            //

            //6-Quentifires Operators >> returns boolean

            //Any() if seq containes at least one element will reeturn true
            //Any(condetion)  if seq containes at least one element match the condetion reeturn true
            //All(()=>) check if all elemnts match the condetion
            //seq01.SquenceEqual(seq02) return true if the two sequens are equal


            //7-Zipping operators >>ZIP
            //List<string> names =new List<string> { "Ali", "Adham", "rady"};
            //List<int> list = Enumerable.Range(1, 3).ToList();
            //var res = list.Zip(names);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}





            //Immideate 

            //1-Element Operators

            //////First() => (ممكن تاخد func و بترجع bool) // FirstOrDefault()
            /////=>return First Element

            //////Last() // LastOrDefault()
            /////=>return Last Element

            //ElementAt(Index) // elementAatOrDefault()

            //Single(); =>if list have more than element it will throw exception
            //singleOrDefault()

            //2-Aggregate Operators 


            //Count(func)
            //Max() {ICoparable}
            //Min()
            //Sum()
            //Averge()
            //Aggregate()


            //3- casting Operators

            //**Where returns IEnumrable always 
            //ToList() =>convert from IEnumrable to List
            //ToArray() =>convert from IEnumrable to Array
            //ToDictionary();
            //ToHashSet()















        }
    }
}
