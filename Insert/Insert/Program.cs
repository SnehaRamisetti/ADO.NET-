using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            string DC = "data source=.;database=Customer;integrated security=True";
            SqlConnection Con = new SqlConnection(DC);

            try
            {
                
                Con.Open();
                Console.WriteLine("Enter ID of the Customer");
                int ID=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter NAME of the Customer");
                 string NAME =  Console.ReadLine();
                Console.WriteLine("Enter ITEM of the Customer");
               string ITEM = Console.ReadLine();
                Console.WriteLine("Enter CITY of the Customer");
                string CITY = Console.ReadLine();
                string Insert = "INSERT INTO Details VALUES("+ID+",'"+NAME+"','"+ITEM+"','"+CITY+"')";
                SqlCommand Cmd= new SqlCommand(Insert, Con);
                Cmd.ExecuteNonQuery();
                Console.WriteLine("successfully inserted");
            }
            catch
            {
                Console.WriteLine("Exception Occurred");
            }
            finally
            {
                Con.Close();
            }
            Console.ReadKey();
        }
    }
}
