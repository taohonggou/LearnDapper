using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace LearnDapper.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection connection = new SqlConnection("Data Source=.;Initial Catalog=PracticeDB;User Id=sa;Password=123456;");

            #region insert
            //var result =
            //    connection.Execute("insert into Users values (@UserName, @Email, @Address)", new
            //    {
            //        UserName = "Mr. Li",
            //        Email = "123@qq.com",
            //        Address = "北京"
            //    });

            //var data = Enumerable.Range(0, 10).Select(i => new Users()
            //{
            //    UserName = i+"Computer",
            //    Address = "北京",
            //    Email = i+"@qq.com"
            //});

            //var result = connection.Execute("insert into users values (@UserName, @Email, @Address)", data); 

            //System.Console.WriteLine(result);
            #endregion

            #region query

            //IEnumerable<Users> users = connection.Query<Users>("select * from Users where Username=@username", new { UserName = "Mr. Li" });

            //Type tUsers = typeof(Users);
            //PropertyInfo[] propertyInfos = tUsers.GetProperties();

            //foreach (var user in users)
            //{
            //    foreach (var propertyInfo in propertyInfos)
            //    {
            //        var value = (string)propertyInfo.GetValue(user);
            //        var name = propertyInfo.Name;
            //        System.Console.WriteLine($"{name}==={value}");
            //    }
            //    System.Console.WriteLine("+++++++++++++++++++++++");
            //}
            #endregion

            #region update

            //var result= connection.Execute("update Users set UserName='John' where UserId=@UserId", new
            //{
            //    UserId = 1
            //});

            //System.Console.WriteLine(result);

            #endregion

            #region delete

            var result= connection.Execute("delete from Users where userId=@userid", new
            {
                UserId= "11"
            });

            System.Console.WriteLine(result);

            #endregion

        }
    }

    public class Users
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
