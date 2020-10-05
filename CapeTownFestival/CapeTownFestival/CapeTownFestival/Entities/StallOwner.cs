using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CapeTownFestival.Entities
{
    public class StallOwner:Person
    {
        Collection<SaleItem> saleItems;

        #region Property Methods
     
        public Collection<SaleItem> SaleItems {
            get { return saleItems; }
            set { saleItems = value; }
        }
#endregion

        #region Constructors
        public StallOwner(string aName, string aAddress, int aAge, char aGender, string aCulture) : base(aName,aAddress,aAge,aGender,aCulture)
        {
            saleItems = new Collection<SaleItem>();
        }
        public StallOwner(int aId, string aName, string aAddress, int aAge, char aGender, string aCulture) : this(aName, aAddress, aAge, aGender, aCulture)
        {
            ID = aId; 
        }
        public StallOwner() : base() {
            saleItems = new Collection<SaleItem>();
        }
        #endregion
        
    }
}
