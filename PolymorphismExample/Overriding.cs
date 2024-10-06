using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{

    public class Payment
    {
        public virtual void Pay(double amount)
        {

        }
    }

    public class CreditCardPayment : Payment
    {
        private string cardNumber;

        public CreditCardPayment(string cardNumber)
        {
            this.cardNumber = cardNumber;
        }

        public override void Pay(double amount)
        {
            Console.WriteLine("Paid $" + amount + " using Credit Card with card number " + cardNumber);
        }
    }

    public class PayPalPayment : Payment
    {
        private string email;

        
        public PayPalPayment(string email)
        {
            this.email = email;
        }

        public override void Pay(double amount)
        {
            Console.WriteLine("Paid $" + amount + " using PayPal with email " + email);
        }
    }

    class Overriding
    {
        static void Main()
        {
            
            Payment payment1 = new CreditCardPayment("1234-5678-9101-1121");
            payment1.Pay(100);

            Payment payment2 = new PayPalPayment("user@gmail.com");
            payment2.Pay(150);

            Console.ReadLine();
        }
    }

}
