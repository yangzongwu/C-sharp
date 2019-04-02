//1.Acquiring locks in a specific defined order
//2.Mutexclass
//3.Monitor.TryEnter()method

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
        public Account(int id, double balance)
        {
            this._id = id;
            this._balance = balance;
        }
        public int Id
        {
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
        Account _fromAccount; Account _toAccount; double _amountToTransfer;
        public AccountManager(Account fromAccount, Account toAccount, double amountToTransfer)
        {
            this._fromAccount = fromAccount;
            this._toAccount = toAccount;
            this._amountToTransfer = amountToTransfer;
        }
        public void Transfer()
        {
            object _lock1, _lock2;
            if (_fromAccount.Id < _toAccount.Id)
            {
                _lock1 = _fromAccount; _lock2 = _toAccount;
            }
            else
            {
                _lock1 = _toAccount; _lock2 = _fromAccount;
            }
            lock (_lock1)
            {
                Thread.Sleep(1000);
                lock (_lock2)
                {
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                }
            }


            Console.WriteLine(Thread.CurrentThread.Name + "try to acquire lock on" + ((Account)_lock1).Id.ToString());
            lock (_lock1)
            {
                Console.WriteLine(Thread.CurrentThread.Name + "acquired lock on" + ((Account)_lock1).Id.ToString());
                Console.WriteLine(Thread.CurrentThread.Name + "suspended for 1 second");
                Thread.Sleep(1000);
                Console.WriteLine(Thread.CurrentThread.Name + "back in action and trying to acquire lock on " + ((Account)_lock2).Id.ToString());
                lock (_lock2)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + "acquired lock on" + ((Account)_lock2).Id.ToString());
                    _fromAccount.Withdraw(_amountToTransfer);
                    _toAccount.Deposit(_amountToTransfer);
                    Console.WriteLine(Thread.CurrentThread.Name + " Transfer " + _amountToTransfer.ToString() + " from " + _fromAccount.Id.ToString() + "to" + _toAccount.Id.ToString());
                }

            }
        }
    }
}

/*
 Main Started
T1try to acquire lock on101
T2try to acquire lock on101
T1acquired lock on101
T1suspended for 1 second
T1back in action and trying to acquire lock on 102
T1acquired lock on102
T1 Transfer 1000 from 101to102
T2acquired lock on101
T2suspended for 1 second
T2back in action and trying to acquire lock on 102
T2acquired lock on102
T2 Transfer 1000 from 102to101
Main completed
Press any key to continue . . .
    
*/
