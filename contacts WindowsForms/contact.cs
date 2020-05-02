using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Contact
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { if (value.Length > 7)
                {
                    phoneNumber = value;
                }
                else
                {
                    phoneNumber = "0000000000000";
                }
            }
        }

        public Contact() {
            FirstName = "John";
            LastName = "Doe";
            PhoneNumber = "0000000000000";
        }

        public Contact(string firstName, string lastName , string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            string output = String.Empty;
            output += String.Format("{0}, {1}" , LastName,FirstName);
            output += String.Format("{0}", PhoneNumber);

            return output;
        }




    }
}
