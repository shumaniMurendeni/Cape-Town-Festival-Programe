using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapeTownFestival.Entities
{
    public class SaleItem
    {
        private string name;
        private decimal cost;
        private int id;

        #region Property Methods
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public decimal Cost {
            get { return cost; }
            set {
                if (value >= 0) { cost = value; }
                else {
                    System.Windows.Forms.MessageBox.Show("Cost cannot be negative\nCost set to 0");
                    cost = 0;
                }
            }
        }
        public int Id {
            get { return id; }
            set {
                if (value > 0) { id = value; }
                else { id = 0; }
            }
        }
        #endregion

        #region Constructors
        public SaleItem() {
            Cost = 0;
            Name = "";
            Id = 0;
        }
        public SaleItem(String aName, decimal aCost) {
            Cost = aCost;
            Name = aName;
        }
        public SaleItem(int aID, String aName, decimal aCost) : this(aName, aCost) {
            Id = aID;
        }
        #endregion
    }
}
