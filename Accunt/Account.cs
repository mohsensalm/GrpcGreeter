

namespace Console.Account
{
        public class Account
        {
         public static int Balance { get; set; }
        public int DepositAmount { get; set; }
        public int WithdrawAmount { get; set; }

        public Account(int balance)
            {
                Balance = balance;
            }
           

            public async Task<int> Remaning()
            {

                return Balance;
            }
            public Task<List<string>> ListOfDucuments()
            {
                var p = new List<string> { "bill", "profile" };
                return Task.FromResult(p);
            }
        }
}
