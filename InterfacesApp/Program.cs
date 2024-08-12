namespace InterfacesApp
{
    public class Program
    {


        static void Main(string[] args)
        {
            IPaymentProcessor crediCardProcessor = new CreditCardProcessor();
            PaymentServices paymentServices = new PaymentServices(crediCardProcessor);
            paymentServices.ProcessOrderPayment(100.00m);

            
                 
            // this code is the same from adove
            IPaymentProcessor paymentProcessor = new PayPalProcessor(); 
            paymentServices = new PaymentServices (paymentProcessor);
            paymentServices.ProcessOrderPayment(2000.00m);


            Console.ReadKey();
        }
    }
}
