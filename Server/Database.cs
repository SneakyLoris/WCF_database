using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Server
{
    // static
    public static class Database
    {
        // private string stringConn = "";
        private static SqlConnection conn;

        public static bool Connect(string connStr)
        {
            try
            {
                conn = new SqlConnection(connStr);
                return true;
            }
            catch
            {
                throw new FaultException<SQLError>(new SQLError("", conn.ConnectionString), "ExecutePC failed", new FaultCode("SQLError"));
            }

        }
        private static int ExecuteNonQuery(SqlCommand cmd)
        {
            int res = 0;

            // Думаю не очень это все
            // Получается отлавливаю неправильную ошибку и отправляю правильную
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw new FaultException<SQLError>(new SQLError(cmd.CommandText, conn.ConnectionString), "ExecutePC failed", new FaultCode("SQLError"));
            }

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    cmd.Connection = conn;
                    res = cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                throw new FaultException<SQLError>(new SQLError(cmd.CommandText, conn.ConnectionString, "This ID is uccupied"), "This ID is uccupied", new FaultCode("SQLError"));
            }
            conn.Close();

            return res;
        }

        // Взять
        private static void ExecuteQueryPC(SqlCommand cmd, out BindingList<Computer> comp)
        {
            comp = new BindingList<Computer>();

            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw new FaultException<SQLError>(new SQLError(cmd.CommandText, conn.ConnectionString), "ExecutePC failed", new FaultCode("SQLError"));
            }

            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    cmd.Connection = conn;
                    var dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                comp.Add(new Computer(
                                    dr.GetInt32(0),
                                    dr.GetString(1),
                                    dr.GetString(2),
                                    dr.GetString(3),
                                    dr.GetString(4),
                                    dr.GetInt32(5),
                                    dr.GetInt32(6),
                                    dr.GetBoolean(7),
                                    dr.GetBoolean(8),
                                    dr.GetBoolean(9)
                                ));

                            }
                        }
                    }
                }
            }
            catch
            {
                throw new FaultException<SQLError>(new SQLError(cmd.CommandText, conn.ConnectionString), "Read Error", new FaultCode("SQLError"));
            }
            conn.Close();
        }

        public static BindingList<Computer> GetDataPC()
        {
            BindingList<Computer> comp;
            SqlCommand cmd = new SqlCommand();
            var query = "SELECT * FROM Computer;";
            cmd.CommandText = query;

            ExecuteQueryPC(cmd, out comp);
            return comp;
        }

        // Создать
        public static void InsertDataPC(Computer comp)
        {
            var query = "INSERT INTO Computer(" +
                        "id, name, CPUname, GPUname, motherboard, POWER, MEM, SSD, HDD, OS) " +
                        "VALUES (@id, @name, @CPUname, @GPUname, @motherboard, @POWER, @MEM, @SSD, @HDD, @OS)" +
                        ";";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("id", comp.ID);
            cmd.Parameters.AddWithValue("name", comp.Name);
            cmd.Parameters.AddWithValue("CPUname", comp.CPU);
            cmd.Parameters.AddWithValue("GPUname", comp.GPU);
            cmd.Parameters.AddWithValue("motherboard", comp.Motherboard);
            cmd.Parameters.AddWithValue("POWER", comp.Power);
            cmd.Parameters.AddWithValue("MEM", comp.Memory);
            cmd.Parameters.AddWithValue("SSD", comp.SSD);
            cmd.Parameters.AddWithValue("HDD", comp.HDD);
            cmd.Parameters.AddWithValue("OS", comp.OS);

            ExecuteNonQuery(cmd);
        }

        // Не удаляет
        public static void DeleteDataPC(Computer comp)
        {
            string query = $"DELETE FROM Computer WHERE id={comp.ID}";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            int num = ExecuteNonQuery(cmd);
            Console.WriteLine($"Удалено объектов: {num}");
        }

        public static void UpdateDataPC(Computer comp)
        {
            string query = $"UPDATE Computer SET name='{comp.Name}', CPUname='{comp.CPU}', GPUname='{comp.GPU}', motherboard='{comp.Motherboard}', POWER={comp.Power}, MEM={comp.Memory}, SSD={(comp.SSD ? 1:0)}, HDD={(comp.HDD ? 1:0)}, OS={(comp.OS ? 1:0)} WHERE id={comp.ID}";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            int num = ExecuteNonQuery(cmd);
            Console.WriteLine($"Изменено объектов: {num}"); 
        }
    }

    [DataContract]
    public class SQLError
    {
        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Command { get; set; }

        [DataMember]
        public string Connection {  get; set; }

        public SQLError(string cmd, string cnn = "null", string dsc = "Ошибка подключения")
        {
            Description = dsc;
            Command = $"Command: {cmd}";
            Connection = $"Connection string: {cnn}";
        }
        public SQLError()
        {
            Description = "Ошибка подключения";
            Command = "Empty command";
            Connection = "null";
        }
    }

}

