using System;
using System.Data.SqlClient;

public class SqlConnect
{

    public void Connection()
    {
        string connetionString = null;
        SqlConnection cnn;
        connetionString = "Data Source=127.0.0.1,1433;Initial Catalog=sql_server_demo;User ID=sa;Password=Anhtuan311";
            cnn = new SqlConnection(connetionString);
        try
        {
            cnn.Open();
            Console.WriteLine("Connection Open ! ");
            cnn.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Can not open connection ! " + ex);
        }
    }
}