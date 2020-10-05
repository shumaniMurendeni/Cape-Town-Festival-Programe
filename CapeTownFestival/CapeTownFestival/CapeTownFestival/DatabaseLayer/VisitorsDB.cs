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
    class VisitorsDB:DB
    {
        private static string table = "Visitor";
        private string sqlString;
        private Collection<Person> visitors;

        #region Constructor
        public VisitorsDB() : base()
        {
            visitors = new Collection<Person>(); 
            sqlString = "SELECT * FROM " + table;
            databaseRead(sqlString, table);
        }
        #endregion
        #region Property Methods

        //Property method to get the list of visitors.
        public Collection<Person> Visitors { get { return visitors; } }
        #endregion

        #region DataReader

        //Method to read data from the database and call the fillCollection method to add visitors to the visitors collection.
        public string databaseRead(string sqlStr, string Table) {
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
                
                if (reader.HasRows) {   //check if the reader has entries after running the query
                    fillCollection(reader, Table);  //fill the visitors collection with visitors if the reader has any entries.
                }
                reader.Close(); //close the reader object
                cnMain.Close(); //close the sql connection
                //System.Windows.Forms.MessageBox.Show("DONE"); DEBUG TRACE STATEMENT
                return "done";
            }
            catch (Exception e) {
                //System.Windows.Forms.MessageBox.Show(e.ToString()); DEBUG TRACE STATEMENT
                return (e.ToString());
            }
        }
        #endregion

        #region Fill Collection

        /*Method to fill the visitor collection with visitors.
         Takes in a reader object and string object as parameters*/
        public void fillCollection(SqlDataReader reader, string Table) {
            Person visitor; //declare a visitor object which will be used in the method.
            visitors = new Collection<Person>();    //initialise the visitor collection or reset it

            while (reader.Read())
            {
                //initialise the visitor object
                visitor = new Person();

                //set the visitor variables
                visitor.ID = reader.GetInt32(0);
                visitor.Name = reader.GetString(1).Trim();
                visitor.Age = reader.GetInt32(2);
                visitor.Address = reader.GetString(3).Trim();
                visitor.Gender = Char.Parse(reader.GetString(4).Trim());
                visitor.Culture = reader.GetString(5).Trim();
                //System.Windows.Forms.MessageBox.Show(reader.GetString(5).Length.ToString()); DEBUG

                visitors.Add(visitor);  //add a visitor to the collection
                //Console.WriteLine(visitor.Name); DEBUG
            }
            
        }

        #endregion
        #region Database Operation Methods

        //Method to add a visitor into the database.
        public void databaseAdd(Person person) {
            string strSQL = "";
            strSQL = "INSERT into Visitor ( [Name], Age, [Address], Gender, Culture ) VALUES (" + getValueString(person) ;
            UpdateDataSource(new SqlCommand(strSQL, cnMain));
        }

        //method to update the visitor in the database.
        public void databaseEdit(Person person) {
            string update;
            update = "UPDATE Visitor SET [Name] = N'"+person.Name+"',Age = "+ person.Age+" , [Address] = N'"+person.Address+
                "', Gender = '"+person.Gender+"', Culture = N'"+person.Culture+"' WHERE [Visitor_ID] = "+person.ID;
            if (UpdateDataSource(new SqlCommand(update, cnMain))) { System.Windows.Forms.MessageBox.Show("Success"); } //Edits the visitor in the database and shows a message boss it it is successful

        }

        //Method to delete a visior from the database.
        public void databaseDelete(Person person) {
            //declare references
            string strSQL = "";
            strSQL = "Delete Visitor WHERE (Visitor_ID = " + person.ID + ")";

            UpdateDataSource(new SqlCommand(strSQL, cnMain));   //Update the database. execute the query.

        }

        //Create and format a string to be for the sql sstring.
        private String getValueString(Person person) {
            string aString;

            aString = "N'" + person.Name + "' , " + person.Age +
                " , N'" + person.Address + "' , '" + person.Gender + "' , N'" + person.Culture + "')";


            return aString;
        }
        #endregion
    }
}
