using System;
using System.Collections.Generic;

namespace HandsOn.Business.ViewModels
{
    public class DivisorViewModel
    {
        public IEnumerable<int> Divisors { get; set; }

        public IEnumerable<int> PrimeDivisors { get; set; }
    }
}
