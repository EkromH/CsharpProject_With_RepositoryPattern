﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Pattern
{
    public static class RepositoryFactory
    {
        public static TRepository Create<TRepository>(ContextTypes ctype) where
        TRepository : class
        {
            if (typeof(TRepository) == typeof(IBookRepository))
            {
                return new BookXMLRepository() as TRepository;
            }
            return null;
        }
    }
}
