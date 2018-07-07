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
        public int total { get; set; }
        int id { get; set; }
        int customerName { get; set; }
        TransactionQueue accountTransactions { get; set; }

        public void ApplyTransaction(int trans)
        {
            total = +trans;
        }
    }
    public class CheckingAccount : BankAccount
    {
        int ServiceFee { get; set; }

        //Create transaction for yearly service fee
        public void newServiceFee()
        {
            var yearlyFee = 100;
            ApplyTransaction(yearlyFee);
        }
        //submit the transaction to the queue

    }
    // public class SavingAccount : BankAccount
    // {
    //     int interestRate { get; set; }
    //     Transaction interest { get; set; }

    //     public void interestCharge()
    //     {
    //         var interest = total + interestRate;
    //         ApplyTransaction(interest);
    //     }
    // }
    // public class Transaction : BankAccount
    // {
    //     int amount { get; set; }
    //     DateTime date { get; set; }
    //     string type { get; set; }

    //     //Transactions only come as two base types (you must deduce the types). 
    //     //Accounts can have more complicated transactions however when in a bank account a transaction only affects one item deduce that item.
    // }
    public class TransactionQueue : BankAccount
    {
        List<Transaction> transactions;
        void enque(Transaction trans)
        {
            transactions.Add(trans);
        }

        void deque()
        {
            var transactionAmount = Convert.ToInt32(transactions[0]);
            ApplyTransaction(transactionAmount);
            transactions.RemoveAt(0);
        }
        public void request(string r)
        {
            deque();
        }
        public void request(Transaction tranny)
        {
            enque(tranny);
        }
    }
}
