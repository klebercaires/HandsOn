using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HandsOn.Business.Interfaces;
using HandsOn.Business.ViewModels;

namespace HandsOn.Business.Services
{
    public class DivisorService : IDivisorService
    {
        public Task<DivisorViewModel> CalculateDivisors(int number)
        {
            var divisors = DivisorsFromInteger(number);
            var primeDivisors = PrimeDivisorsFromList(divisors);

            var result = new DivisorViewModel
            {
                Divisors = divisors,
                PrimeDivisors = primeDivisors
            };

            return Task.FromResult(result);
        }

        public IEnumerable<int> DivisorsFromInteger(int number)
        {
            var listOfDivisors = new List<int>();

            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    listOfDivisors.Add(i);

            return listOfDivisors;
        }

        public IEnumerable<int> PrimeDivisorsFromList(IEnumerable<int> listOfDivisors)
        {
            var listOfPrimeDivisors = new List<int>();
            foreach (var item in listOfDivisors)
                if (IntegerIsPrime(item)) listOfPrimeDivisors.Add(item);

            return listOfPrimeDivisors;
        }

        public bool IntegerIsPrime(int number)
        {
            //Um número é classificado como primo se ele é maior do que um e é divisível apenas por um e por ele mesmo.
            //Apenas números naturais são classificados como primos.

            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
