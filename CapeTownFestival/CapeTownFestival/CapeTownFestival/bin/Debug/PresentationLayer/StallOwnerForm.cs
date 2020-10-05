using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//add namespaces
using CapeTownFestival.DatabaseLayer;
using CapeTownFestival.Entities;

namespace CapeTownFestival.PresentationLayer
{
    public partial class StallOwnerForm : Form
    {
        StallOwnersDB StallOwnerInfo;
        private Collection<StallOwner> StallOwners;
        private string crudOption;
        public bool closed = false;
        public StallOwnerForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            crudOption = "view";
            StallOwnerListView.BackColor = Color.White;
            SaleItemsListView.BackColor = Color.White;
            AddressTextBox.BackColor = Color.White;
            
            StallOwnerInfo = new StallOwnersDB();
            StallOwners = StallOwnerInfo.StallOwners;

            formState();


            setUpStallOwnersView();
        }

        
        #region Form Events
        private void StallOwnerForm_Load(object sender, EventArgs e)
        {
            MdiParent = this.MdiParent;
        }

        private void StallOwnerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            closed = true;
        }


        #endregion
        #region Form Utility Methods
        private void formState()
        {
            if (crudOption.Equals("view"))
            {
                enableEntries(false);
            }
            if (crudOption.Equals("add"))
            {
                enableEntries(true);
            }
        }
        private void enableEntries(bool state)
        {
            //text boxes
            NameTextBox.ReadOnly = !state;
            AgeTextBox.ReadOnly = !state;
            CultureTextBox.ReadOnly = !state;
            AddressTextBox.ReadOnly = !state;
            
            //Radio Buttons
            FemaleRadioButton.Enabled = state;
            MaleRadioButton.Enabled = state;
            
        }

        private void displayDetails(StallOwner owner) {
            NameTextBox.Text = owner.Name;
            AgeTextBox.Text = owner.Age.ToString();
            CultureTextBox.Text = owner.Culture;
            //IncomeTextBox.Text = owner.Income.ToString();
            AddressTextBox.Text = owner.Address;

            if (owner.Gender == 'F') { FemaleRadioButton.Checked = true; }
            else { MaleRadioButton.Checked = true; }

            setUpSaleItems(owner);
        }
        #endregion

        

        #region Form Controls

        private void setUpStallOwnersView()
        {
            ListViewItem stallOwnerDetails;

            //Clear current list
            StallOwnerListView.Clear();
            StallOwnerListView.View = View.Details;

            //Column set up
            StallOwnerListView.Columns.Insert(0, "Name", 170, HorizontalAlignment.Left);
            StallOwnerListView.Columns.Insert(1, "Age", 59, HorizontalAlignment.Right);
            StallOwnerListView.Columns.Insert(2, "Gender", 59, HorizontalAlignment.Left);
            StallOwnerListView.Columns.Insert(3, "Culture", 100, HorizontalAlignment.Left);
            StallOwnerListView.Columns.Insert(4, "Address", 226, HorizontalAlignment.Left);
            
            //Add Visitor details to each List View

            foreach (StallOwner stallowner in StallOwners)
            {
                stallOwnerDetails = new ListViewItem();
                stallOwnerDetails.Text = stallowner.Name;
                stallOwnerDetails.SubItems.Add(stallowner.Age.ToString());
                stallOwnerDetails.SubItems.Add(stallowner.Gender.ToString());
                stallOwnerDetails.SubItems.Add(stallowner.Culture);
                stallOwnerDetails.SubItems.Add(stallowner.Address);
                //stallOwnerDetails.SubItems.Add(stallowner.Income.ToString());

                StallOwnerListView.Items.Add(stallOwnerDetails);
            }

            StallOwnerListView.Refresh();
            StallOwnerListView.GridLines = true;
            displayDetails(StallOwners[0]);
            enableEntries(false);
        }

        private void setUpSaleItems(StallOwner owner) {
            ListViewItem itemDetails;

            SaleItemsListView.Clear();
            SaleItemsListView.View = View.Details;

            SaleItemsListView.Columns.Insert(0, "Sale Item", 180, HorizontalAlignment.Left);
            SaleItemsListView.Columns.Insert(1, "Cost", 82, HorizontalAlignment.Right);

            foreach (SaleItem item in owner.SaleItems) {
                itemDetails = new ListViewItem();
                itemDetails.Text = item.Name;
                itemDetails.SubItems.Add("R " + item.Cost.ToString());

                SaleItemsListView.Items.Add(itemDetails);
            }
            SaleItemsListView.Refresh();
            SaleItemsListView.GridLines = true;
        }


        #endregion

        private void StallOwnerListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Updating details when the user clicks on the stallowner.
            if (StallOwnerListView.SelectedItems.Count > 0)
            {
                 var owner= StallOwnerListView.SelectedIndices; //gets the index of the selected StallOwner.
                displayDetails(StallOwners[owner[0]]); //Displays details of the selected StallOwner
                                                    /*If more than one owner is selected, it shows the details of the first StallOwner*/
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
