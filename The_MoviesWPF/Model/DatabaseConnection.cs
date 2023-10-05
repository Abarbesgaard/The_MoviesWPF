using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_MoviesWPF.Model
{

    public class DatabaseConnection
    {
        public string DatabaseConnectionString()
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("DBCON.json").Build();

            string ConnectionString = config.GetConnectionString("MyDBConnection");

            return ConnectionString;

        }
    }

}
