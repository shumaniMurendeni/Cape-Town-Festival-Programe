using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapeTownFestival.Entities
{
    public class Festival
    {
        private int id;
        private string name;
        private string location;
        private string theme;
        private DateTime date;

        //Define Property Methods
        #region Properety Methods
        public int ID {
            get { return id; }
            set {
                if (value > 0) { id = value; }
                else { MessageBox.Show("Festival id cannot be less than 1.\nValue not stored."); }
            }
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public string Location {
            get { return location; }
            set { location = value; }
        }
        public string Theme {
            get { return theme; }
            set { theme = value; }
        }
        public DateTime Date{
            get { return date.Date; }
            set { date = value; }
        }
        #endregion
        #region Constructors
        //Define Constructors
        public Festival() { }

        public Festival(int Id, string aName, string aLocation, string aTheme, DateTime aDate) {
            ID = Id;
            Name = aName;
            Location = aLocation;
            Theme = aTheme;
            Date = aDate;
        }
        #endregion
        
    }
}
