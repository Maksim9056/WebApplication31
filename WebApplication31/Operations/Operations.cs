using Data.Data;
using Librari.root.user;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApplication31.Operations
{
    public class Operations
    {
        public void Start()
        {
            try
            {                     
                using (WorkForData data = new WorkForData())
                {

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }


        public void adduser(User user)
        {
           
            using (WorkForData  data = new WorkForData())
            {
                data.Users.AddRange(user);
                data.SaveChanges();
            }

        }
        public User SelectUser(User user)
        {
            User user1 = null;
            try
            {
              
                using (WorkForData data = new WorkForData())
                {
                    
                    user1 = data.Users.FirstOrDefault(u => u.Mail == user.Mail && u.Password ==user.Password);
                }


                //using (WorkForData data = new WorkForData())
                //{

                //   var users = data.Users.ToList();
                //}
                return user1;
            }
            catch (Exception)
            {

            }
            return user1;
        }
    }
}
