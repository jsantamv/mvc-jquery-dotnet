using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp3.DataBase.Model;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApp3.DataBase.DataAccess
{
    public class AdressDataAccess
    {
        public IEnumerable<Address> AddressList()
        {
            string connString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string sql = "SELECT top 30 AddressID,AddressLine1,AddressLine2,City,StateProvinceID,PostalCode,convert(varchar(60),SpatialLocation) as SpatialLocation,rowguid,ModifiedDate FROM [Person].[Address]";
                connection.Open();
                IEnumerable<Address> address = connection.Query<Address>(sql);
                connection.Close();

                return address;
            }
        }


        public DataTable AddressDataTable()
        {
            string connString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                string sql = "SELECT top 30 AddressID,AddressLine1,AddressLine2,City,StateProvinceID,PostalCode,convert(varchar(60),SpatialLocation) as SpatialLocation,rowguid,ModifiedDate FROM [Person].[Address]";
                connection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql,connection);
                DataTable dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                connection.Close();

                return dtbl; 
            }
        }
    }
}
