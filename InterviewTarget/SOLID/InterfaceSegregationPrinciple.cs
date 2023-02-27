using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTarget.SOLID
{
    public interface IPayment
    {
        void Charge(double amount);
        void Refund(double amount);
    }

    public interface IAuthorization
    {
        void Authorize();
        void Capture();
        void VoidTransaction();
    }

    public class CreditCardPayment : IAuthorization, IPayment
    {
        public void Authorize()
        {
            throw new NotImplementedException();
        }

        public void Capture()
        {
            throw new NotImplementedException();
        }

        public void Charge(double amount)
        {
            throw new NotImplementedException();
        }

        public void Refund(double amount)
        {
            throw new NotImplementedException();
        }

        public void VoidTransaction()
        {
            throw new NotImplementedException();
        }
    }

    public class PayPalPayment : IPayment
    {
        public void Charge(double amount)
        {
            throw new NotImplementedException();
        }

        public void Refund(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
