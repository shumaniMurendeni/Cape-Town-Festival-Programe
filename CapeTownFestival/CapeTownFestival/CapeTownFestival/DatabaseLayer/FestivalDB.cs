using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using CapeTownFestival.Entities;

namespace CapeTownFestival.DatabaseLayer
{
    public class FestivalDB:DB
    {
        private Collection<Festival> festivals;
        private static string table1 ="Festival";

        #region Constructor
        public FestivalDB() : base() {
            string sqlString = "SELECT * FROM " + table1;
            festivals = new Collection<Festival>();
            readDataFromTable(sqlString);
        }
        #endregion

        #region Data Reader
        public void readDataFromTable(string sqlString) {

            //Declare references
            SqlDataReader reader;
            SqlCommand command;

            try
            {
                command = new SqlCommand(sqlString, cnMain);
                cnMain.Open();
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();
                if (reader.HasRows) {
                    fillFestivals(reader);
                }
               // System.Windows.Forms.MessageBox.Show(festivals.Count.ToString()); Debug Trace window
                reader.Close();
                cnMain.Close();

                return;
            }
            catch (Exception e) { System.Windows.Forms.MessageBox.Show(e.ToString()); }

        }
        #endregion
        #region Fill Collection
        public void fillFestivals(SqlDataReader reader) {
            festivals = new Collection<Festival>();
            Festival festival;

            while (reader.Read()) {
                festival = new Festival();
                festival.ID = reader.GetInt32(0);
                festival.Name = reader.GetString(1).Trim();
                festival.Location = reader.GetString(2).Trim();
                festival.Theme = reader.GetString(3).Trim();
                festival.Date = reader.GetDateTime(4);
                festivals.Add(festival);

            }
        }
        #endregion

        #region Property Methods
        public Collection<Festival> Festivals {
            get { return festivals; }
        }
        #endregion
    }
}
