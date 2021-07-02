using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Sklad
{
    public class Dota

    {
        public DataTable Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");                
                                                                           
            SqlConnection sqlConnection = new SqlConnection("data source = homeserver27rus.ddns.net; initial catalog =Stas_bd; user id =stas_kursach; password =ytujhg664hg2; MultipleActiveResultSets = True; App = EntityFramework");
            sqlConnection.Open();                                           
            SqlCommand sqlCommand = sqlConnection.CreateCommand();          
            sqlCommand.CommandText = selectSQL;                             
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand); 
            sqlDataAdapter.Fill(dataTable);                                 
            return dataTable;

        }

    }
}
