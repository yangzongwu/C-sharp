/*
Thread1       Thread2
  .             .
  .             .
locked        locked
  .             .
  .             .
Resouce1      Resouce2

then Thread1 want Resouce2
then Thread2 want Resouce1

then deadlock
*/
using System;
using System.Threading;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started");
            Account accountA = new Account(101, 5000);
            Account accountB = new Account(102, 3000);

            AccountManager accountManagerA = new AccountManager(accountA, accountB, 1000);
            Thread T1 = new Thread(accountManagerA.Transfer);
            T1.Name = "T1";

            AccountManager accountManagerB = new AccountManager(accountB, accountA, 1000);
            Thread T2 = new Thread(accountManagerB.Transfer);
            T2.Name = "T2";

            T1.Start();
            T2.Start();

            T1.Join();
            T2.Join();
            Console.WriteLine("Main completed");
        }
    }

    public class Account
    {
        double _balance; int _id;
        public Account(int id,double balance)
        {
            this._id = id;
            this._balance = balance;
        }
        public int Id {
            get { return _id; }
        }
        public void Withdraw(double amount)
        {
            _balance -= amount;
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }
    }
    public class AccountManager
    {
        Account _fromAccount; Account _toAccount;double _amountToTransfer;
        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }
        public void Transfer()
        {
            Console.WriteLine(Thread.CurrentThread.Name + "try to acquire lock on" + _fromAccount.Id.ToString());
            lock (_fromAccount)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "acquired lock on" + _fromAccount.Id.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + "suspended for 1 second");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + "back in action and trying to acquire lock on " + _toAccount.Id.ToString());
                lock (_toAccount)
                {
                    Console.WriteLine("This code will not be executed");
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                }
            }
        }
    }
}

/*
Main Started
T2try to acquire lock on101
T1try to acquire lock on101
T2acquired lock on101
T2suspended for 1 second
T2back in action and trying to acquire lock on 102
This code will not be executed
T1acquired lock on101
T1suspended for 1 second
T1back in action and trying to acquire lock on 102
This code will not be executed
Main completed
Press any key to continue . . .
*/
