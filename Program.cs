using System;
using System.Collections.Generic;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var app = new GildedRose(new ItemCreator(), new ItemUpdaterFactory());
            app.RunFor(30);
        }
    }
}
