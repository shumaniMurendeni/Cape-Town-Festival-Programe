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
    public class StallOwnersDB:DB
    {
        private static string table = "StallOwner";
        private static string table1 = "SaleItems";
        private string sqlString = "SELECT * FROM ";
        private Collection<StallOwner> stallOwners;
        private Collection<SaleItem> saleItems;

        #region Property Method
        public Collection<StallOwner> StallOwners {
            get { return stallOwners; }
        }
        #endregion
        #region Constructor
        public StallOwnersDB() : base() {
            sqlString = "SELECT * FROM ";
            stallOwners = new Collection<StallOwner>();
            saleItems = new Collection<SaleItem>();
            databaseRead(sqlString + table, table); //read in stallOwner data
            databaseRead(sqlString + table1, table1); //read in saleItems data
            //databaseAdd(new Person()); DEBUG INHERITANCE KINDA THING
        }
        #endregion
        #region Database operation Methods

        public string databaseRead(string sqlStr, string Table)
        {
            //declare references
            SqlDataReader reader;
            SqlCommand command;

            /*use try and catch so that if an error occurs while reading in data,
             * the application will not crash*/
            try
            {
                command = new SqlCommand(sqlStr, cnMain);
                cnMain.Open();
                command.CommandType = CommandType.Text;
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    /*Check which collection to fill*/
                    if (Table.Equals("StallOwner")) { fillCollection(reader); } //populate the StallOwners arraylist
                    if (Table.Equals("SaleItems")) { addSaleItems(reader); }    ////populate the SaleItems arraylist
                }
                
                reader.Close(); //closing the reader
                cnMain.Close(); //closing the sql connection
                //System.Windows.Forms.MessageBox.Show("DONE"); DEBUG TRACE STATEMENT
                return "done";
            }
            catch (Exception e)
            {
                //System.Windows.Forms.MessageBox.Show(e.ToString()); DEBUG TRACE STATEMENT
                return (e.ToString());
            }
        }

        #endregion

        #region Collection fill
        private void fillCollection(SqlDataReader reader) {
            StallOwner owner;   //declare a stallOwner reference;
            stallOwners = new Collection<StallOwner>(); //Initialising the stallOwner collection or reseting it if it already had stallOwner in it

            while (reader.Read())   //going through the table rows
            {
                owner = new StallOwner();   //Initialising a stallOwner Object
                owner.ID = reader.GetInt32(0);  //set the stall owner's ID
                owner.Name = reader.GetString(1).Trim();    ////set the stall owner's Name
                owner.Age = reader.GetInt32(2); ////set the stall owner's Age
                owner.Address = reader.GetString(3).Trim(); ////set the stall owner's Address
                owner.Gender = Char.Parse(reader.GetString(4).Trim());  ////set the stall owner's gender
                owner.Culture = reader.GetString(5).Trim(); ////set the stall owner's Culture
                //System.Windows.Forms.MessageBox.Show(reader.GetString(5).Length.ToString()); DEBUG

                stallOwners.Add(owner); //Adding the current stall owner to the stall owner array list
                //Console.WriteLine(visitor.Name); DEBUG
            }
        }
        private void addSaleItems(SqlDataReader reader) {
            SaleItem saleItem;
            saleItems = new Collection<SaleItem>();
            int count = 0;
            int itemsPerOwner;

            //System.Windows.Forms.MessageBox.Show("Shumani"); DEBUG TRACE WINDOW
            while (reader.Read())   //going through the table rows
            {
                saleItem = new SaleItem();  //initialising a sale item object
                saleItem.Id = reader.GetInt32(0);   //setting the saleItem ID
                saleItem.Name = reader.GetString(1).Trim(); //setting the saleItem  Name
                saleItem.Cost = reader.GetDecimal(2);   //setting the saleItem Cost
                saleItems.Add(saleItem);    //Adding it to the collection.
            }

            //adding saleItems to the stallowners.
            itemsPerOwner = saleItems.Count / stallOwners.Count;
            for (int i=0; i<stallOwners.Count; i++) {
                do
                {
                    stallOwners[i].SaleItems.Add(saleItems[count]);
                    count++;
                } while ((count < saleItems.Count) && (count%itemsPerOwner != 0));
            }
        }
        #endregion
    }
}
