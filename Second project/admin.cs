using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Second_project
{
    class admin
    {
        static string str = @"Data Source=(localdb)\v11.0; Initial Catalog=Library;integrated security=True;";

        public static DataSet query(string Finselect)                       //查
        {
            SqlConnection conn = new SqlConnection(str);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(Finselect);
                SqlDataAdapter da = new SqlDataAdapter(Finselect, conn);
                da.Fill(ds);
            }
            catch { }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public static int Sqlhelper(string help)                            //增 删 改
        {
            SqlConnection conn = new SqlConnection(str);
            int result = 0;
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(help, conn);
                result = cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
