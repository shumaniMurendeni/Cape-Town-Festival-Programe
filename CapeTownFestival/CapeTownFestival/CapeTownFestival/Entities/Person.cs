using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapeTownFestival.Entities
{
    public class Person
    {
        private int id;
        private string name;
        private string address;
        private int age;
        private char gender;
        private string culture;
        
        #region Property Methods

        public int ID {
            get { return id; }
            set {
                if (value > 0) { id = value; }
                else { MessageBox.Show("Person Id cannot be negative"); }
            }
        }
        public string Name
        {
            get { return name; }
            set {
                if (value.Length > 0) { name = value; }
                else {
                    MessageBox.Show("Name cannot be empty.\nName set to Ts'epo");
                    name = "Ts'epo";
                }
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    MessageBox.Show("Age cannot be negative.\nAge set to 16");
                    age = 16;
                }
            }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Culture
        {
            get { return culture; }
            set { culture = value; }
        }
        #endregion

        #region Constructors

        public Person()
        {
            name = "";
            Address = "";
            Age = 0;
            Gender = 'F';
            Culture = "";
        }

        public Person(string aName, string aAddress, int aAge, char aGender, string aCulture)
        {
            Name = aName;
            Address = aAddress;
            Age = aAge;
            Gender = aGender;
            Culture = aCulture;
        }

        public Person(int aId,string aName, string aAddress, int aAge, char aGender, string aCulture) : this(aName, aAddress, aAge, aGender, aCulture) {
            ID = aId;
        }
        #endregion
        
    }
}
