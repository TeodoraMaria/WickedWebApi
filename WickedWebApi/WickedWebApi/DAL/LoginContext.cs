﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using SqlServerConnection;

namespace WickedWebApi.DAL
{
    public class LoginContext : DbContext
    {
        public LoginContext() : base(new SqlConnection(ConfigurationManager.ConnectionStrings["WickedSQL"].ConnectionString),false)
        {

        }
    
        public DbSet<Student> Students { get; set; }
        public DbSet<Account> Accounts { get; set; }

        
        
    }
}