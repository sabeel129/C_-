using System;

namespace PaymentSystem
{

    public interface IPayment
    {
        void MakePayment(double Amount);
    }
    public class PaypalPayment : IPayment
    {
        public void MakePayment(double Amount)
        {
            Console.WriteLine(Amount);
        }
    }
    public class UPIPayment : IPayment
    {
        public void MakePayment(double Amount)
        {
            Console.WriteLine(Amount);
        }
    }
    public class Creditcard : IPayment
    {
        public void MakePayment(double Amount)
        {
            Console.WriteLine(Amount);
        }

    }
    class program
    {
        static void Main()
        {
            IPayment Paypal = new PaypalPayment();
            IPayment UPI = new UPIPayment();
            IPayment Creditcard = new Creditcard();

            double Amount = 1500;


            Console.WriteLine("using Credit card");
            Paypal.MakePayment(Amount);

            Console.WriteLine("using paypal");
            UPI.MakePayment(Amount);

            Console.WriteLine("using creditcard");
            Creditcard.MakePayment(Amount);
        }
    }
}
