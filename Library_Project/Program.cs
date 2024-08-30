using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository_Domain;
using Repository_Pattern;

namespace LibraryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRun = true; while (isRun)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("================= Select Your Process=================");
Console.WriteLine("Press 1 : To Get a Book Information");
Console.WriteLine("Press 2 : To Create a New Book Information");
Console.WriteLine("Press 3 : To Exit The Application"); string
inputKey = Console.ReadLine();
Console.Clear();
if (inputKey == "1")
{
var source =
RepositoryFactory.Create<IBookRepository>(ContextTypes.XMLSource);
var items = source.GetAll();
Console.WriteLine();
Console.WriteLine("=============Book Information===========");
foreach (var item in items) { Console.WriteLine(item.BookName
+ ", " + item.AuthorName + ", " + item.Edition + ", " + item.CellPhoneNo); }
Console.Write("Press any key to continue...");
Console.ReadKey();
}
else if (inputKey == "2")
{
Book bk = new Book();
Console.Write("Book Name : ");

bk.BookName = Console.ReadLine();
Console.Write("Author Name : ");
bk.AuthorName = Console.ReadLine();
Console.Write("Edition No. : ");
bk.Edition = Console.ReadLine();
Console.Write("Cell Phone No. : ");
bk.CellPhoneNo = Console.ReadLine();
Console.Clear();
IBookRepository source =
RepositoryFactory.Create<IBookRepository>(ContextTypes.XMLSource);
try
{
source.Insert(bk);
}
catch (Exception ex)
{
Console.Write(ex);
Console.ReadKey();
continue;
}
}
else if (inputKey == "3")
{
isRun = false;
}
}
        }
    }
}
