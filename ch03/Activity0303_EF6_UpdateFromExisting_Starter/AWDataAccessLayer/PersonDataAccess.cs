using AWDataLayerObjects;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace AWDataAccessLayer
{
    public class PersonDataAccess
    {
        //in a real class application, there would be better architecture.
        //I'm stubbing this in to simulate the end result
        public DataSet GetPeople(string filter, string cnstr)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlDataAdapter da = null;
            DataSet ds = new DataSet();
            try
            {
                connection = new SqlConnection(cnstr);
                string command = string.Format("Select * from [Person].[Person] where LastName like '%{0}%'", filter);
                cmd = new SqlCommand(command, connection);
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;

                cmd.Connection.Open();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
            }
            catch (System.Exception ex)
            {
                //unique logging logic.
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                if (connection != null)
                {
                    if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                        cmd = null;
                    }
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    connection = null;
                }
            }
            
            return ds;
        }

        public Person GetPerson(int ID, string cnstr)
        {
            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            Person p = new Person();
            try
            {
                connection = new SqlConnection(cnstr);
                string command = string.Format("Select * from [Person].[Person] where BusinessEntityId ='{0}'", ID);
                cmd = new SqlCommand(command, connection);
                cmd.CommandType = CommandType.Text;
                cmd.CommandTimeout = 0;

                cmd.Connection.Open();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    p.BusinessEntityID = Convert.ToInt32(dr["BusinessEntityID"]);
                    p.PersonType = dr.IsDBNull(dr.GetOrdinal("PersonType")) ? "" : dr["PersonType"].ToString();
                    p.Title = dr.IsDBNull(dr.GetOrdinal("Title")) ? "" : dr["Title"].ToString();
                    p.FirstName = dr.IsDBNull(dr.GetOrdinal("FirstName")) ? "" : dr["FirstName"].ToString();
                    p.LastName = dr.IsDBNull(dr.GetOrdinal("LastName")) ? "" : dr["LastName"].ToString();
                    p.Suffix = dr.IsDBNull(dr.GetOrdinal("Suffix")) ? "" : dr["Suffix"].ToString();
                }
            }
            catch (System.Exception ex)
            {
                //unique logging logic.
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                if (connection != null)
                {
                    if (cmd != null && cmd.Connection.State == ConnectionState.Open)
                    {
                        cmd.Connection.Close();
                        cmd = null;
                    }
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    connection = null;
                }
            }

            return p;
        }
    }
}
