using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    public interface IPaymentProvider
    {
        void ProcessPayment(decimal amount);

    }
    public class PayPalProvider : IPaymentProvider
    { 
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} payment through PayPal");
        }
    }
    public class StripeProvider : IPaymentProvider
    { 
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing ${amount} payment throeugh Stripe");
        }
    }

    public interface IPaymentProviderFactory
    {
        IPaymentProvider CreatePaymentProvider();
    }

    public class PayPalFactory : IPaymentProviderFactory 
    {
        public IPaymentProvider CreatePaymentProvider()
        {
            return new PayPalProvider();
        }
    }

    public class StripeFactory : IPaymentProviderFactory
    {
        public IPaymentProvider CreatePaymentProvider()
        {
            return new StripeProvider();
        }
    }




}
