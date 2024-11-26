using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStore
{
    public interface IBranch
    {
        void GetAll();
    }
    public interface IAccount
    {
        void GetAll();
    }
    public abstract class Payment
    {
        public abstract void MakePayment(int acno, int amount);
        public abstract void PaymentStatus(int transactionNo);
        public abstract void CancelPayment();
        public void PayMentCategory()
        {
            Console.WriteLine("NetBanking");
            Console.WriteLine("Credit");
            Console.WriteLine("UPI");
        }
    }
    public class Axis : Payment
    {
        public override void CancelPayment()
        {
            throw new NotImplementedException();
        }

        public override void MakePayment(int acno, int amount)
        {
            throw new NotImplementedException();
        }

        public override void PaymentStatus(int transactionNo)
        {
            throw new NotImplementedException();
        }
    }
    public interface IPayment:IBranch,IAccount,IUser
    {
        void MakePayment(int acno, int amount);
        void PaymentStatus(int transactionNo);
        void CancelPayment();
    }
    class A
    {

    }
    class B
    {

    }
    class C : A, IBranch
    {
        public void GetAll()
        {
            throw new NotImplementedException();
        }
    }
    public class SBI : IPayment
    {
        public void AddUser()
        {
            throw new NotImplementedException();
        }

        public void CancelPayment()
        {
            throw new NotImplementedException();
        }

        public void Deleteuser()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetUser()
        {
            throw new NotImplementedException();
        }

        public void MakePayment(int acno, int amount)
        {
            throw new NotImplementedException();
        }

        public void PaymentStatus(int transactionNo)
        {
            throw new NotImplementedException();
        }

        public void Updateuser()
        {
            throw new NotImplementedException();
        }
    }
    public class HDFC : IPayment
    {
        public void AddUser()
        {
            throw new NotImplementedException();
        }

        public void CancelPayment()
        {
            throw new NotImplementedException();
        }

        public void Deleteuser()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void GetUser()
        {
            throw new NotImplementedException();
        }

        public void MakePayment(int acno, int amount)
        {
            throw new NotImplementedException();
        }

        public void PaymentStatus(int transactionNo)
        {
            throw new NotImplementedException();
        }

        public void Updateuser()
        {
            throw new NotImplementedException();
        }
    }
    public class ICIC : Payment
    {
        public override void CancelPayment()
        {
            throw new NotImplementedException();
        }

        public override void MakePayment(int acno, int amount)
        {
            throw new NotImplementedException();
        }

        public override void PaymentStatus(int transactionNo)
        {
            throw new NotImplementedException();
        }
    }
}
