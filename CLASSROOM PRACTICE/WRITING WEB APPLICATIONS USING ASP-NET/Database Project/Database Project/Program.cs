using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace DatabaseTest
{
    class Program
    {
        MySqlConnection conn;
        MySqlCommand command;

        void CreateConnection()
        {
            string constr = "SERVER=localhost;DATABASE=dbtest;UID=testuser;PASSWORD=1234;";
            conn = new MySqlConnection(constr);
            conn.Open();
        }

        void InsertUpdateDelete(string sql)
        {
            command = new MySqlCommand(sql, conn);
            command.ExecuteNonQuery();
            Console.WriteLine("Operation Performed Successfully!");
        }

        void SelectRecords(string sql)
        {
            command = new MySqlCommand(sql, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("Sid\tName\tAddress");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Console.WriteLine(
                        dt.Rows[i]["sid"] + "\t" +
                        dt.Rows[i]["name"] + "\t" +
                        dt.Rows[i]["address"]);
                }
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();

            try
            {
                obj.CreateConnection();

                while (true)
                {
                    Console.WriteLine("\n1.Insert  2.Update  3.Delete  4.Select  5.Exit");
                    Console.Write("Enter choice: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    string sql = "";
                    int id;
                    string nm, add;

                    switch (n)
                    {
                        case 1:
                            Console.Write("Enter Name: ");
                            nm = Console.ReadLine();

                            Console.Write("Enter Address: ");
                            add = Console.ReadLine();

                            sql = $"INSERT INTO tblStudent(name,address) VALUES('{nm}','{add}')";
                            obj.InsertUpdateDelete(sql);
                            break;

                        case 2:
                            Console.Write("Enter ID: ");
                            id = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Enter Name: ");
                            nm = Console.ReadLine();

                            Console.Write("Enter Address: ");
                            add = Console.ReadLine();

                            sql = $"UPDATE tblStudent SET name='{nm}', address='{add}' WHERE sid={id}";
                            obj.InsertUpdateDelete(sql);
                            break;

                        case 3:
                            Console.Write("Enter ID: ");
                            id = Convert.ToInt32(Console.ReadLine());

                            sql = $"DELETE FROM tblStudent WHERE sid={id}";
                            obj.InsertUpdateDelete(sql);
                            break;

                        case 4:
                            sql = "SELECT * FROM tblStudent";
                            obj.SelectRecords(sql);
                            break;

                        case 5:
                            return;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("Connection Failed!");
            }

            Console.ReadKey();
        }
    }
}