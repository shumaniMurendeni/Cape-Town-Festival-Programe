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

using CapeTownFestival.Entities;
using CapeTownFestival.DatabaseLayer;

namespace CapeTownFestival.PresentationLayer
{
    public partial class Festivals : Form
    {
        private Collection<Festival> festivalList;
        private FestivalDB festivalDB;
        public bool closed;
        public Festivals()
        {
            InitializeComponent();
            closed = false;
            festivalDB = new FestivalDB();
            festivalList = festivalDB.Festivals;
            FestivalsListView.BackColor = Color.White;
            setUpFestivalView();
            //System.Windows.Forms.MessageBox.Show(festivalList[0].Date.ToShortDateString());
        }


        #region Form Events
        private void Festivals_FormClosed(object sender, FormClosedEventArgs e)
        {
            closed = true;
        }
        #endregion


        #region Form utilities
        /*      private Person PopulateVisitor()
              {
                  Person tempVisitor = new Person();
                  tempVisitor.Name = NameTextBox.Text;
                  tempVisitor.Address = AddressTextBox.Text;
                  tempVisitor.Culture = CultureTextBox.Text;
                  tempVisitor.Age = Convert.ToInt32(AgeTextBox.Text);
                  if (FemaleRadioButton.Checked) { tempVisitor.Gender = 'F'; }
                  else if (MaleRadioButton.Checked) { tempVisitor.Gender = 'M'; }

                  return tempVisitor;
              }

             /* private void displayDetails(Person person)
              {
                  NameTextBox.Text = person.Name;
                  AddressTextBox.Text = person.Address;
                  AgeTextBox.Text = Convert.ToString(person.Age);
                  CultureTextBox.Text = person.Culture;

                  if (person.Gender == 'F') { FemaleRadioButton.Checked = true; }
                  else if (person.Gender == 'M') { MaleRadioButton.Checked = true; }
              }
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

              private void VisitorsListView_SelectedIndexChanged(object sender, EventArgs e)
              {
                  if (VisitorsListView.SelectedItems.Count > 0)
                  {
                      var visit = VisitorsListView.SelectedIndices;
                      displayDetails(visitors[visit[0]]);
                  }
              }*/
        #endregion
        #region Form Controls
        private void setUpFestivalView()
        {
            ListViewItem FestivalDetails;

            //Clear current list
            FestivalsListView.Clear();
            FestivalsListView.View = View.Details;

            //Column set up
            FestivalsListView.Columns.Insert(0, "Name", 160, HorizontalAlignment.Left);
            FestivalsListView.Columns.Insert(1, "Location", 185, HorizontalAlignment.Left);
            FestivalsListView.Columns.Insert(2, "Theme", 100, HorizontalAlignment.Left);
            FestivalsListView.Columns.Insert(3, "Date", 100, HorizontalAlignment.Left);

            //Add Visitor details to each List View
           // System.Windows.Forms.MessageBox.Show("Shumani"); Debug Trace Window
            foreach (Festival festival in festivalList)
            {
                FestivalDetails = new ListViewItem();
                FestivalDetails.Text = festival.Name;
                FestivalDetails.SubItems.Add(festival.Location);
                FestivalDetails.SubItems.Add(festival.Theme);
                FestivalDetails.SubItems.Add(festival.Date.ToShortDateString());

                FestivalsListView.Items.Add(FestivalDetails);
            }

            FestivalsListView.Refresh();
            FestivalsListView.GridLines = true;
            //displayDetails(visitors[0]);
            //enableEntries(false);
        }

        #endregion 
    }
}
