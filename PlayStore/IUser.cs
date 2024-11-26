using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStore
{
    public interface IUser
    {
        void AddUser();
        void Updateuser();
        void Deleteuser();
        void GetUser();
    }
    public abstract class UserAbs
    {
       public abstract void AddUser();
        public abstract void Updateuser();
        public abstract void Deleteuser();
        public abstract void GetUser();

        public void GetUserRoles()
        {
            Console.WriteLine("User");
            Console.WriteLine("Admin");
            Console.WriteLine("SuperAdmin");
        }
    }


    class FB : UserAbs
    {
        public override void AddUser()
        {
            throw new NotImplementedException();
        }

        public override void Deleteuser()
        {
            throw new NotImplementedException();
        }

        public override void GetUser()
        {
            throw new NotImplementedException();
        }

        public override void Updateuser()
        {
            throw new NotImplementedException();
        }
    }
    class Insta : UserAbs { }
    class Amazon : UserAbs { }
}
