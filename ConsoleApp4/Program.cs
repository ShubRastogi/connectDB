using System;
using System.Data.SqlClient;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int id;
            string FirstName, LastName, City;
           
            Console.WriteLine("Press 1 for Add student");
            Console.WriteLine("Press 2 for Delete student");
            Console.WriteLine("Press 3 for Update student");
            
            int n = int.Parse(Console.ReadLine());
            SqlConnection con = new SqlConnection("server=COMPND-LTP-1504;database=student;integrated security=true");

            switch (n) {
                case 1:
                    Console.WriteLine("first name ");
                    FirstName = Console.ReadLine();
                    Console.WriteLine("last name ");
                    LastName = Console.ReadLine();
                    Console.WriteLine("city");
                    City = Console.ReadLine();
                    SqlCommand cmd = new SqlCommand("insert into Persons2 values(' " + FirstName + " ',' " + LastName + " ',' " + City + " ')", con);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("REcord Inserted Successfully");

                    break;
                case 2:
                    Console.WriteLine("Enter Employee Id to be deleted");
                    id = int.Parse(Console.ReadLine());

                    SqlCommand cmd1 = new SqlCommand("delete from Persons2 where PersonID= " + id + " ", con);
                    
                    con.Open();
                    cmd1.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("Record Deleted Successfully");

                    break;
                case 3:
                    Console.WriteLine("Enter Student Id to be Updated");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("first name ");
                    FirstName = Console.ReadLine();
                    Console.WriteLine("last name ");
                    LastName = Console.ReadLine();
                    Console.WriteLine("city");
                    City = Console.ReadLine();

                    SqlCommand cmd2 = new SqlCommand("update Persons2 set FirstName=' " + FirstName + " ',LastName=' " + LastName + " ',City=' " + City + " ' where PersonID= " + id + " ", con);
                    con.Open();
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    Console.WriteLine("Record Updated Successfully");
                    break;
                default:
                    break;
            }




            
            
            

        }
    }
}
