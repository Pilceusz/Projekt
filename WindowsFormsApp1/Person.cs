using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Person
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmailAddress { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public string  FullInfo
        {
            get 
            { 
               
                return $"{ Firstname } { Lastname } ({ EmailAddress})";
            }
            
        }

        
    }
}