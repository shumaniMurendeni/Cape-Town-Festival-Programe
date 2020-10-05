using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapeTownFestival.PresentationLayer
{
    public partial class MDICTF : Form
    {
        //private int childFormNumber = 0;
        private StallOwnerForm stallOwnerForm;
        private VisitorsForm visitorForm;
        Festivals festivalsForm;

        #region Constructor
        public MDICTF()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        #endregion

        #region Form Utilities

        //Set up the Festival Forms
        private void viewFestivals() {
            festivalsForm = new Festivals();
            festivalsForm.MdiParent = this;
            festivalsForm.StartPosition = FormStartPosition.Manual;
            festivalsForm.Show();
        }

        //Set up the StallOwners Form
        private void ViewStallOwners()
        {                                                   
            stallOwnerForm = new StallOwnerForm();
            stallOwnerForm.MdiParent = this;
            stallOwnerForm.StartPosition =FormStartPosition.Manual;
            stallOwnerForm.Show();
        }

        //Set up the Visitors Form
        private void ViewVisitors() {
            visitorForm = new VisitorsForm(); 
            visitorForm.MdiParent = this;
            visitorForm.StartPosition = FormStartPosition.Manual;
            visitorForm.Show();
        }
        #endregion

        #region ToolsStrip Events
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void viewStallOwnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stallOwnerForm == null) { ViewStallOwners(); }
            else if (stallOwnerForm.closed) { ViewStallOwners(); }
            else {
                stallOwnerForm.Close();
                ViewStallOwners();
            }
        }

        private void viewCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (visitorForm == null) { ViewVisitors(); }
            else if (visitorForm.closed) { ViewVisitors(); }
            else
            {
                visitorForm.Close();
                ViewVisitors();
            }
        }
        private void viewFestivalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (festivalsForm == null) { viewFestivals(); }
            else if (festivalsForm.closed) { viewFestivals(); }
            else {
                festivalsForm.Close();
                viewFestivals();
            }
            
        }

        #endregion


    }
}
