using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class BankAccount
    {
        //need 4 attributes
        int total { get; set; }
        int id { get; set; }
        int customerName { get; set; }
        TransactionQueue accountTransactions { get; set; }

        public void ApplyTransaction()
        {

        }
    }
    public class CheckingAccount: BankAccount
    {
        int ServiceFee { get; set; }

        //Create transaction for yearly service fee
        public Transaction newServiceFee()
        {
            return new Transaction();
        }
         //submit the transaction to the queue

    }
    public class SavingAccount : BankAccount
    {
        int interestRate { get; set; }
        Transaction interest { get; set; }
    }
    public class Transaction
    {
        int amount { get; set; }
        DateTime date { get; set; }
        string type { get; set; }
        
        //Transactions only come as two base types (you must deduce the types). 
        //Accounts can have more complicated transactions however when in a bank account a transaction only affects one item deduce that item.
    }
    public class TransactionQueue
    {
        List<Transaction> transactions;
        void enque(Transaction trans)
        {

        }

        void deque()
        {

        }
        void enque (string r)
        {
            return
        }
    }
}
