using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("data source=.;database=sample;integrated security=True");
            

            SqlCommand cmd= new SqlCommand("Select * from EMP where ID=102", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                string ID = dr["ID"].ToString();
                string EMPName = dr["EMPName"].ToString();
                string Salary = dr["Salary"].ToString();
                Console.WriteLine(ID+""+EMPName+""+Salary);
            }
            
            dr.Close();
            
            conn.Close();
            Console.ReadKey();

        }
    }
}
