using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GrainInterfaces
{
    interface IDeposit : Orleans.IGrainWithIntegerKey
    {
        Task<decimal> Deposit(decimal amount);
    }
}
