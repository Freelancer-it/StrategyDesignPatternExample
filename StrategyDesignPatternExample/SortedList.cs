﻿using System;
using System.Collections.Generic;

namespace StrategyDesignPatternExample
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortstrategy;

        // Dependecy Injection
        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);

            // Iterate over list and display results
            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
