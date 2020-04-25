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
        public DepartmentDAL(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
    }
}
