using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using WebApp3.DataBase.Model;
using Dapper;
using System.Data;
using System.Threading.Tasks;

namespace WebApp3.DataBase.DataAccess
{
    public class EmployeeDataAcces
    {
        public void AddOrEdit(Employee emp)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                DynamicParameters parameter = new DynamicParameters();


                parameter.Add("@NationalIDNumber", emp.NationalIDNumber, DbType.String);
                parameter.Add("@LoginID", emp.LoginID, DbType.String);
                //parameter.Add("@OrganizationNode", emp.OrganizationLevel, DbType.String);
                //parameter.Add("@OrganizationLevel", emp.OrganizationLevel, DbType.Int32);
                parameter.Add("@JobTitle", emp.JobTitle, DbType.String);
                parameter.Add("@BirthDate", emp.BirthDate, DbType.Date);
                parameter.Add("@MaritalStatus", emp.MaritalStatus, DbType.String);
                parameter.Add("@Gender", emp.Gender, DbType.String);
                parameter.Add("@HireDate", emp.HireDate, DbType.Date);
                parameter.Add("@SalariedFlag", emp.SalariedFlag, DbType.Boolean); ;
                parameter.Add("@VacationHours", emp.VacationHours, DbType.Int32);
                parameter.Add("@SickLeaveHours", emp.SickLeaveHours, DbType.Int32);
                parameter.Add("@CurrentFlag", emp.CurrentFlag, DbType.Boolean);
                parameter.Add("@rowguid", emp.rowguid, DbType.Guid);
                parameter.Add("@ImagePath", emp.ImagePath, DbType.String);

                //output parameters example
                //parameter.Add("@b", dbType: DbType.Int32, direction: ParameterDirection.Output);
                //parameter.Add("@c", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

                connection.Open();
                int rowcount = connection.Execute("[HumanResources].[uspAddorEditEmployee]", parameter, commandType: CommandType.StoredProcedure);
                //IEnumerable<Address> address = connection.Query<Address>(sql);
                connection.Close();
            }
        }
        
        /// <summary>
        /// Forma de llamdo asyncrono
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public Task AddOrEditAsync(Employee emp)
        {
            return Task.Run(() => { AddOrEdit(emp); });
        }


    }
}
