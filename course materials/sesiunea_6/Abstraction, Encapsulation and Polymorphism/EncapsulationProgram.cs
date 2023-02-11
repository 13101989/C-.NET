namespace Encapsulation
{
    class Bank
    {
        private long accountNumber;
        private string name;
        private int balance;

        public long AccountNumber { get; set;}      
        public string Name {
            get 
            {
                return name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("The parameter is empty or null");
                }
                else
                {
                    name = value; 
                }
            }
        }

        public int GetBalance()
        {
            return balance;
        }

        public void SetBalance(int balance)
        {
            if (balance > 0)
            {
                this.balance = balance;
            }
            else
            {
                Console.WriteLine("Negative balance");
            }
        }

        public void WithdrawAmount() 
        { 
        }
	}

    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.AccountNumber = 123456;
            bank.Name = null;
            bank.SetBalance(100);
            Console.WriteLine("Balance = {0}", bank.GetBalance());
			Console.WriteLine("Name = {0}", bank.Name);

			bank.WithdrawAmount();

            Console.ReadKey();
        }
    }
}