using System;
using System.Threading.Tasks;
using HandsOn.Business.ViewModels;

namespace HandsOn.Business.Interfaces
{
    public interface IDivisorService
    {
        Task<DivisorViewModel> CalculateDivisors(int number);
    }
}
