﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book
    {
        public Book(string title, int year, params string[] author)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>(author);
        }

        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; }
    }
}
