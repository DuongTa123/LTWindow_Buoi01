﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace Bai06_1
{
    class KetNoi
    {
        string sqlConnect;
        public KetNoi()
        {
            sqlConnect = ConfigurationManager.ConnectionStrings["ChuoiKN"].ToString();
        }    
        public  SqlConnection getConnect()
        {
            SqlConnection conn = new SqlConnection(sqlConnect);
            return conn;
        }    
    }
}
