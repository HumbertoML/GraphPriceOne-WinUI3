using LinqToDB.Data;
using LinqToDB.DataProvider.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using LinqToDB.Mapping;
using Models;
using LinqToDB;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Connection
{
    public class Connections : DataConnection
    {
        //conexion a nuestra base de datos con sql server
        public Connections() : base(new SqlServerDataProvider("", SqlServerVersion.v2017),
            "Data Source=DESKTOP-R56EJQK\\SQLEXPRESS;Database=GraphPriceOne;Integrated Security=True;")
        {

        }
        public ITable<TProducts> Products => GetTable<TProducts>();
    }
}