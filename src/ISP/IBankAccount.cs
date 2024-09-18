using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IBankAccount
    {
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }

    // Interface for accounts that earn interest
    public interface IInterestBearingAccount
    {
        void ApplyInterest();
    }

    // Interface for accounts that charge fees
    public interface IFeeChargingAccount
    {
        void CalculateFees();
    }
}
