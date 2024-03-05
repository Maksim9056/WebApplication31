namespace Librari.root.user
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        
        public User(int id,string name ,int age,string mail,string password) 
        {
            Id = id;
            Name = name;
            Age = age;
            Mail = mail;
            Password = password;
        
        }

    }
}
