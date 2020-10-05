using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//add other namespaces
using CapeTownFestival.DatabaseLayer;
using CapeTownFestival.Entities;

namespace CapeTownFestival.PresentationLayer
{
    public partial class VisitorsForm : Form
    {
        private string crudOption = "view";
        public bool closed;
        VisitorsDB visitorsDB;
        Collection<Person> visitors;
        public VisitorsForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            closed = false;
            visitorsDB = new VisitorsDB();
            formState();
            visitors = visitorsDB.Visitors; 
            //visitors.Add(new Person("Shumani","Woolsack Residence",22,'M',"Venda"));
            setUpVisitorsView();
        }

        #region Form Events
        private void VisitorsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            closed = true;
        }

        private void VisitorsForm_Load(object sender, EventArgs e)
        {
            
            enableEntries(false);
        }

        private void VisitorsForm_Activated(object sender, EventArgs e)
        {

        }

        //Event for when the user selects a visitor in the form.
        private void VisitorsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VisitorsListView.SelectedItems.Count > 0)
            {
                var visit = VisitorsListView.SelectedIndices;
                displayDetails(visitors[visit[0]]);
            }
        }
        #endregion


        #region button clicks
        private void AddButton_Click(object sender, EventArgs e)
        {
            crudOption = "add";
            formState();
            NameTextBox.Text = "";
            AgeTextBox.Text = "";
            CultureTextBox.Text = "";
            AddressTextBox.Text = "";
            MaleRadioButton.Checked = false;
            FemaleRadioButton.Checked = false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            crudOption = "edit";
            formState();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Check to see if the use has selected a visitor or not.
            if (VisitorsListView.SelectedItems.Count > 0)   //if they selected a visitor, delete that visitor
            {
                var index = VisitorsListView.SelectedIndices;
                visitorsDB.databaseDelete(visitors[index[0]]);
                visitors.RemoveAt(index[0]);

            }
            else    //otherwise delete the first visitor in the list as the details shown belong to this visitor
            {
                visitorsDB.databaseDelete(visitors[0]);
                visitors.RemoveAt(0);
            }

            crudOption = "view";
            formState();
            setUpVisitorsView();

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Person tempVisitor = PopulateVisitor();
            
            if (crudOption.Equals("add")) {
                visitors.Add(tempVisitor);
                visitorsDB.databaseAdd(tempVisitor);
            }
            if (crudOption.Equals("edit")) { editVisitor(); ; }
            crudOption = "view";
            formState(); //Updates the form state and enable entries
            setUpVisitorsView(); //Updates visitors list view
        }

        #endregion

        #region Form utilities

        //Edit the visitor and update both the database and the collection
        private void editVisitor() {

            Person person;
            
            //Check to see if the user has selected a visitor
            if (VisitorsListView.SelectedItems.Count > 0)   //edit the selected visitor
            {
                var index = VisitorsListView.SelectedIndices;
                person = visitors[index[0]];
                person.Name = NameTextBox.Text;
                person.Age = Convert.ToInt32(AgeTextBox.Text);
                person.Address = AddressTextBox.Text;
                person.Culture = CultureTextBox.Text;
                if (FemaleRadioButton.Checked) { person.Gender = 'F'; }
                else { person.Gender = 'M'; }

                visitorsDB.databaseEdit(person);
                visitors[index[0]] = person;
            }

            //edit the first visitor in the list as the info displayed belongs to this visitor by default.
            else
            {
                int index = 0;
                person = visitors[index];
                person.Name = NameTextBox.Text;
                person.Age = Convert.ToInt32(AgeTextBox.Text);
                person.Address = AddressTextBox.Text;
                person.Culture = CultureTextBox.Text;
                if (FemaleRadioButton.Checked) { person.Gender = 'F'; }
                else { person.Gender = 'M'; }

                visitorsDB.databaseEdit(person);    //edits the visitor in the database
                visitors[index] = person;           //updates the visitor in the list(Collection).
            }
            

        }

        //Method to create and populate a visitor.
        private Person PopulateVisitor() {
            //Create a new visitor,

            Person tempVisitor = new Person();
            tempVisitor.Name = NameTextBox.Text;
            tempVisitor.Address = AddressTextBox.Text;
            tempVisitor.Culture = CultureTextBox.Text;
            tempVisitor.Age = Convert.ToInt32(AgeTextBox.Text);
            if (FemaleRadioButton.Checked) { tempVisitor.Gender = 'F'; }
            else if (MaleRadioButton.Checked) { tempVisitor.Gender = 'M'; }

            return tempVisitor;
        }

        //Method to display details of a visitor. takes in a Person object.
        private void displayDetails(Person person) {
            NameTextBox.Text = person.Name;
            AddressTextBox.Text = person.Address;
            AgeTextBox.Text = Convert.ToString(person.Age);
            CultureTextBox.Text = person.Culture;

            if (person.Gender == 'F') { FemaleRadioButton.Checked = true; }
            else if (person.Gender == 'M') { MaleRadioButton.Checked = true; }
        }

        //Method to used to check the crudOption and then call the enableEntries with the appropriate state
        private void formState()
        {
            if (crudOption.Equals("view"))
            {
                enableEntries(false);
            }
            else if (crudOption.Equals("edit")) { enableEntries(true); }
            else if (crudOption.Equals("add"))
            {
                enableEntries(true);
                DeleteButton.Visible = false;
            }
        }

        //Method used to control textboxes and buttons
        private void enableEntries(bool state)
        {
            //Text boxes
            NameTextBox.ReadOnly = !state;
            AgeTextBox.ReadOnly = !state;
            CultureTextBox.ReadOnly = !state;
            AddressTextBox.ReadOnly = !state;

            //Radio buttons
            FemaleRadioButton.Enabled = state;
            MaleRadioButton.Enabled = state;

            //Buttons
            AddButton.Visible = !state;
            EditButton.Visible = !state;
            DeleteButton.Visible = state;
            SubmitButton.Visible = state;

            //Lists
            //VisitorsListView.Enabled = !state;
        }
        #endregion
        #region Form Controls

        //Set up the ListView
        private void setUpVisitorsView() {
            ListViewItem VisitorsDetails;

            //Clear current list
            VisitorsListView.Clear();
            VisitorsListView.View = View.Details;
            VisitorsListView.BackColor = Color.White;

            //Column set up
            VisitorsListView.Columns.Insert(0, "Name", 225, HorizontalAlignment.Left);
            VisitorsListView.Columns.Insert(1, "Age", 53, HorizontalAlignment.Left);
            VisitorsListView.Columns.Insert(2, "Gender", 62, HorizontalAlignment.Left);
            VisitorsListView.Columns.Insert(3, "Culture", 65, HorizontalAlignment.Left);
            VisitorsListView.Columns.Insert(4, "Address", 222, HorizontalAlignment.Left);
           
            //Add Visitor details to each List View

            foreach (Person visitor in visitors) {
                VisitorsDetails = new ListViewItem();
                VisitorsDetails.Text = visitor.Name;
                VisitorsDetails.SubItems.Add(visitor.Age.ToString());
                VisitorsDetails.SubItems.Add(visitor.Gender.ToString());
                VisitorsDetails.SubItems.Add(visitor.Culture);
                VisitorsDetails.SubItems.Add(visitor.Address);

                VisitorsListView.Items.Add(VisitorsDetails);
            }

            VisitorsListView.Refresh();
            VisitorsListView.GridLines = true;
            displayDetails(visitors[0]);
            enableEntries(false);
        }

        #endregion
    }
}
