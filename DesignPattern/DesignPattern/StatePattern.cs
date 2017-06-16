using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatten.DesignPattern
{
    public class Account
    {
        private readonly string password = "123456";

        private int tryCount = 0;

        public Account()
        {
            // 账启初始化时为，normal状态

            this.State = new Normal(this);
        }

        public AccountState State { get; set; }

        public void Validate(string pwd)
        {
            if (pwd != password)
            {
                tryCount++;

                State.Show(tryCount);
            }
        }

    }

    public abstract class AccountState
    {
        protected Account account;
        protected int maxTryCount;

        public abstract void Show(int tryCount);
    }

    public class Normal : AccountState
    {
        public Normal(Account account)
        {
            this.account = account;
            maxTryCount = 2;
        }

        public override void Show(int tryCount)
        {
            Console.WriteLine("Account State is Normal");
            StateChange(tryCount);
        }

        private void StateChange(int tryCount)
        {
            if (tryCount >= maxTryCount)
            {
                account.State = new Forbidden(this.account);
            }
        }

    }

    public class Forbidden : AccountState
    {
        public Forbidden(Account account)
        {
            this.account = account;
            maxTryCount = 5;
        }

        public override void Show(int tryCount)
        {
            Console.WriteLine("Account State is Forbidden");
            StateChange(tryCount);

        }

        private void StateChange(int tryCount)
        {
            if (tryCount >= maxTryCount)
            {
                account.State = new Locked(account);
            }
        }

    }

    public class Locked : AccountState
    {
        public Locked(Account account)
        {
        }

        public override void Show(int tryCount)
        {
            Console.WriteLine("Account State is Locked");
        }

    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Account account = new Account();

    //        for (int i = 0; i < 6; i++)
    //        {
    //            account.Validate("111111");
    //        }

    //        Console.ReadKey();
    //    }
    //}
}
