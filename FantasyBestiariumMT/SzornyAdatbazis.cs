using Devart.Data.MySql;
using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyBestiariumMT
{
    internal class SzornyAdatbazis
    {
        private readonly string connectionString = "fantasybestarium";

        //MySqlConnection cnn = new MySqlConnection("Server=myServerAddress;" +
        //                                  "Database=myDataBase;" +
        //                                  "Uid=myUsername;" +
        //                                  "Pwd=myPassword;");

        MySqlConnection connection = new MySqlConnection(connectionString)
        {


        };
      
              
        

    }
}
