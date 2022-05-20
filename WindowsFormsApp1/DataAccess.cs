using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace WindowsFormsApp1
{
    internal class DataAccess
    {
        public List<Person> GetPeople(string lastName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Baza")))
            {
                // var output = connection.Query<Person>($"select * from People where LastName = '{ lastName }' ").ToList();
                var output = connection.Query<Person>("dbo.People_GetByLastName @LastName", new { LastName = lastName}).ToList();
                return output;
            }
        }

        public void InsertPerson(string firstName, string lastName, string emailAddress, string login, string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Baza")))
            {
                //Person newPerson = new Person { Firstname = firstName, Lastname = lastName, EmailAddress = emailAddress, Login = login, Password = password }
                List<Person> people = new List<Person>();

                people.Add(new Person { Firstname = firstName, Lastname = lastName, EmailAddress = emailAddress, Login = login, Password = password });

                connection.Execute("dbo.People_Insert @FirstName, @LastName, @EmailAddress, @Login, @Password", people);     
            }
        }
    }
}
