using Account.Entities.Exceptions;

namespace Account.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; private set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainExceptions("Insuffcient account balance");
            }
            if (WithDrawLimit < amount)
            {
                throw new DomainExceptions("Exceeded the limit value");
            }

            Balance -= amount;
        }
    }
}
