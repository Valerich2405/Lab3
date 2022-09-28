using System;

namespace Invoice
{
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        private int quantity;

        public Invoice(int Account, string Customer, string Provider)
        {
            this.account = Account;
            this.customer = Customer;
            this.provider = Provider;
        }

        public string Article
        {
            get 
            { 
                return article;
            }
            set 
            { 
                article = value; 
            }
        }

        public int Quantity
        {
            get 
            {
                return quantity; 
            }
            set 
            { 
                quantity = value;
            }
        }

        public double Calculator()
        {
            double sum = 0;
            double price = 23;

            if (quantity > account / price)
            {
                Console.WriteLine("A large quantity of products (exceeds the account).");
            }

            else
            switch (Article)
            {
                case "with VAT":
                    {
                        double tax = 0.2;
                        sum = (price * quantity) + (price * quantity) * tax;
                        Console.WriteLine($"The amount of payment for the ordered goods including VAT = {sum}.");
                        break;
                    }

                case "without VAT":
                    {
                        sum = (price * quantity);
                        Console.WriteLine($"The amount of payment for the ordered product without VAT = {sum}.");
                        break;
                    }
            }

            return sum;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The amount of payment for the ordered goods including VAT (with VAT);");
            Console.WriteLine("The amount of payment for the ordered product without VAT (without VAT).");
            Console.Write("Choose a calculation method: ");

            Invoice invoice = new Invoice(1234, "Zelyunko Stanislav", "Snickers");
            string article = Console.ReadLine();
            invoice.Article = article;

            Console.Write("Enter the quantity of the product: ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            invoice.Quantity = quantity;

            invoice.Calculator();
        }
    }
}
