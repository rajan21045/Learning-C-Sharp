using System;
using System.Data;
using System.Data.OleDb;

namespace AccessCRUD
{
    class Program
    {
        OleDbConnection conn;
        OleDbCommand command;

        void CreateConnection()
        {
            string constr =
            @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=D:\Code\ACCESS\testdb.accdb";

            conn = new OleDbConnection(constr);
            conn.Open();

            Console.WriteLine("Database Connected Successfully!");
        }

        void Insert(string sql)
        {
            command = new OleDbCommand(sql, conn);
            command.ExecuteNonQuery();

            Console.WriteLine("Operation Performed Successfully!");
        }

        void SelectRecords(string sql)
        {
            command = new OleDbCommand(sql, conn);

            OleDbDataAdapter adapter =
                new OleDbDataAdapter(command);

            DataTable dt = new DataTable();

            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Console.WriteLine("\nSID\tNAME\tADDRESS\t\tAGE");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Console.WriteLine(
                         dt.Rows[i]["sid"] + "\t" +
                         dt.Rows[i]["name"] + "\t" +
                         dt.Rows[i]["address"] + "\t" +
                         dt.Rows[i]["age"]);
                }
            }
            else
            {
                Console.WriteLine("No Records Found");
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
                    Console.WriteLine("\n1.Insert");
                    Console.WriteLine("2.Select");
                    Console.WriteLine("3.Exit");

                    Console.Write("Enter Choice: ");


                    int n =
                        Convert.ToInt32(Console.ReadLine());

                    string sql = "";
                    int id, age;
                    string nm, add;

                    switch (n)
                    {
                        case 1:

                            Console.Write("Enter Name: ");
                            nm = Console.ReadLine();

                            Console.Write("Enter Address: ");
                            add = Console.ReadLine();

                            Console.Write("Enter Age: ");
                            age = Convert.ToInt32(Console.ReadLine());

                            sql = "INSERT INTO tblStudent(name, address, age) " +
                                    "VALUES('" + nm + "','" + add + "'," + age + ")";

                            obj.Insert(sql);

                            break;

                        case 2:
                            sql = "SELECT * FROM tblStudent WHERE address = 'Kathmandu'";

                            obj.SelectRecords(sql);

                            break;

                        case 3:
                            return;

                        default:

                            Console.WriteLine("Invalid Choice");

                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Connection Failed!");
            }

            Console.ReadKey();
        }
    }
}