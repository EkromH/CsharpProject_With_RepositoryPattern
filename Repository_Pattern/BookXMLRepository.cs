using Repository_Domain;
using Repository_Pattern;
using Repository_Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class BookXMLRepository : XMLRepositoryBase<XMLSet<Book>, Book, int>,
IBookRepository
{
    public BookXMLRepository() : base("BookInformation.xml")
    {
    }

}
