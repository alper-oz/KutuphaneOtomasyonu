using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Model
{
    public class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime addedTime { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string authority { get; set; }

        public Person()
        {

        }
        public Person(int _ID, string _FirstName, string _LastName, DateTime _addedTime, string _username, string _password, string _authority)
        {
            ID = _ID;
            FirstName = _FirstName;
            LastName = _LastName;
            addedTime = _addedTime;
            username = _username;
            password = _password;
            authority = _authority;
        }

        public void setId(int _ID)
        {
            ID = _ID;
        }
        public int getId()
        {
            return ID;
        }


        public void setFirstName(string _FirstName)
        {
            FirstName = _FirstName;
        }
        public string getFirstName()
        {
            return FirstName;
        }


        public void setLastName(string _LastName)
        {
            LastName = _LastName;
        }
        public string getLastName()
        {
            return LastName;
        }

        public void setaddedTime(DateTime _addedTime)
        {
            addedTime = _addedTime;
        }
        public DateTime getAddedTime()
        {
            return addedTime;
        }
        public void setusername(string _username)
        {
            username = _username;
        }
        public string getusername()
        {
            return username;
        }
        public void setpassword(string _password)
        {
            password = _password;
        }
        public string getpassword()
        {
            return password;
        }
        public void setauthority(string _authority)
        {
            authority = _authority;
        }
        public string getauthority()
        {
            return authority;
        }
        public override string ToString()
        {
            return "Ad Soyad:" + FirstName + " " + LastName;
        }
    }
}
