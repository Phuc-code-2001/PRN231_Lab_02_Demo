using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ODataBookStore.EDM;
using System.Collections;
using System.Collections.Generic;

namespace ODataBookStore.DataSamples
{
    public class DataSources
    {
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<Press> Presses { get; set; }

        public DataSources()
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    ISBN="987-0-321-87758-1",
                    Title="Essential C# 5.0 (out of support)",
                    Author="PhucHT",
                    Price=59.99M,
                    Location=new Address()
                    {
                        City="Bac Lieu",
                        Stress="88 Truong Dien",
                    },
                    Press = new Press()
                    {
                        Name="Chua te cua nhung chiec sung",
                        Category=Category.Book
                    }
                },
                new Book()
                {
                    ISBN="987-0-321-87758-1",
                    Title="Premium C# 6.0 (longterm support)",
                    Author="BangDDH",
                    Price=29.99M,
                    Location=new Address()
                    {
                        City="Can Tho",
                        Stress="8181818181",
                    },
                    Press = new Press()
                    {
                        Name="Chua te cua nhung chiec mom",
                        Category=Category.EBook
                    }
                },
            };
        }

    }
}

