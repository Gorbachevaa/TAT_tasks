using System;

namespace TestWordPressBlog
{
    public enum UserRole
    {
        Subscriber,
        Administrator,
        Editor,
        Author,
        Contributor        
    }
    /// <summary>
    /// Class describes user of wordpress.com.
    /// </summary>
    public class User
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string Mail { get; private set; }
        public UserRole Role { get; set; }
        public User() { }
        /// <summary>
        /// Constructor with parametrs.
        /// </summary>
        /// <param name="username">Username</param>
        /// <param name="passwd">Password</param>
        /// <param name="role">User role</param>
        public User(string username, string passwd, UserRole role)
        {
            UserName = username;
            Password = passwd;
            Role = role;
        }
        public User(string username, string passwd, string mail, UserRole role)
        {
            UserName = username;
            Password = passwd;
            Mail = mail;
            Role = role;
        }
        public string GetUserRole(UserRole userRole)
        {
            switch(userRole)
            {
                case UserRole.Administrator:
                    {
                        return "administrstor";
                    }
                case UserRole.Author:
                      {
                          return "author";
                      }
                case UserRole.Contributor:
                      {
                          return "contributor";
                      }
                case UserRole.Editor:
                      {
                          return "editor";
                      }
                case UserRole.Subscriber:
                      {
                          return "subscriber";
                      }
                default:
                      {
                          return String.Empty;
                      }
            }
        }
    }
}
