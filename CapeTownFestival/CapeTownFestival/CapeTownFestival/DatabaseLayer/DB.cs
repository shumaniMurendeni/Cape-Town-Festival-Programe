using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Name Spaces
using System.Data;
using System.Data.SqlClient;
using CapeTownFestival.Properties;
using System.Configuration;

namespace CapeTownFestival.DatabaseLayer
{
    public class DB
    {
        private string strConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CapeTownFestival.mdf;Integrated Security = True";
        protected SqlConnection cnMain;

        public DB() {
            try
            {
                cnMain = new SqlConnection(strConn);
                cnMain.Close();
            }
            catch (SystemException e) {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }

        protected bool UpdateDataSource(SqlCommand currentCommand) {
            bool success;
            try
            {
                //open connection
                cnMain.Open();

                currentCommand.CommandType = CommandType.Text;
                currentCommand.ExecuteNonQuery();

                //close the connection
                cnMain.Close();
                //System.Windows.Forms.MessageBox.Show("true"); DEBUG TRACE STATEMENT
                success = true;
            }
            catch (Exception err) {
                System.Windows.Forms.MessageBox.Show(err.Message + " " + err.StackTrace); //DEBUG TRACE STATEMENT
                success = false;
            }

            return success;
        }
    }
}
