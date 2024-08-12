using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Interface Reusability while using Polimorphism
namespace InterfacesApp
{
    //Interface
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);


    }


    /// <summary>
    /// Polymorphism
    /// </summary>
    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Procesing credit car payment of  {amount}");
            //Implement credit card payment Logic

        }
    }

    public class PayPalProcessor : IPaymentProcessor
    {

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Procesing Paypal payment of  {amount}");
            //Implement paypal payment Logic

        }
    }
    // Entender este codigo un poco mas
    public class PaymentServices
    {
        private readonly IPaymentProcessor _processor;

        public PaymentServices(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        public void ProcessOrderPayment(decimal amount)
        {

            _processor.ProcessPayment(amount);

        }


    }
    



}
