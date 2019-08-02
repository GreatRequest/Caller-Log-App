using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Call_Logging_Tool
{
    class Connection
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string port;
        private string uid;
        private string password;

        //Constructor
        public Connection()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "82.33.108.45";
            database = "callmanagment";
            port = "3306";
            uid = "CallLogApp";
            password = "GreatRequestForTest1013254!!";
            string connectionString;
            connectionString = "Server=" + server + ";" + "Port=" + port + ";" + "Database=" +
            database + ";" + "Uid=" + uid + ";" + "Pwd=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Contact administrator");
                        MessageBox.Show(ex.Message);
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public bool Insert(string qry)
        {
            //open connection
            if (this.OpenConnection())
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(qry, connection);
                //Execute command
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected >= 1)
                {
                    this.CloseConnection();
                    return true;
                }
                this.CloseConnection();
            }
            return false;
        }

        /*//Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        *///Select statement
        public DataTable Select(string qry)
        {
            //Create a table to store data
            DataTable dt = new DataTable();
            if (this.OpenConnection())
            {
                //Create Command
                MySqlDataAdapter sqlDa = new MySqlDataAdapter(qry, connection);
                //Fill the tabel with Data
                sqlDa.Fill(dt);
                this.CloseConnection();
                return dt;
            }
            return dt;
            
        }
        /*
        //Count statement
        public int Count()
        {
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }*/
    }
    /*class DBConnect
    {

        public bool dbInit()
        {
            string connString = "Server=localhost; Port=3306; Database=callmanagment; Uid=root; Pwd=GReqWebAdmin1013254@@";
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string title = "Error";
                MessageBox.Show(message, title);
                return false;
            }
            return true;
        }
        
        public DataRow[] dbSelect(string qry)
        {
            dbInit();
            callerLogApp callerLogApp = new callerLogApp();
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = qry;
            var dt = new DataTable();
            dt.Load(command.ExecuteReader());
            var rows = dt.AsEnumerable().ToArray();
            return rows;
        }

        public bool dbInsert(string qry)
        {
            if (dbInit())
            {
                callerLogApp callerLogApp = new callerLogApp();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = qry;
                comm.ExecuteNonQuery();
                dbClose();
                return true;
            }
            return false;
        }

        public void dbClose()
        {
            conn.Close();
        }
            
            
    }*/
}
