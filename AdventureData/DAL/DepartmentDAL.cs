using AdventureData.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace AdventureData.DAL
{
    public class DepartmentDAL
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;
        public DepartmentDAL(IConfiguration configuration)
        {
            this._configuration = configuration;
            this._connectionString = this._configuration.GetConnectionString("Default");
        }

        public List<department> GetAllDepartments()
        {
            var lstDepartments = new List<department>();
            try
            {
                using (SqlConnection con = new SqlConnection(_connectionString))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM [HumanResources].[Department]", con);
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        lstDepartments.Add(new department
                        {
                            DepartmentID = rdr.GetInt16("DepartmentID"),
                            Name = rdr.GetString("Name"),
                            GroupName = rdr.GetString("GroupName"),
                            ModifiedDate = rdr.GetDateTime("ModifiedDate")
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return lstDepartments;
        }
    }
}

