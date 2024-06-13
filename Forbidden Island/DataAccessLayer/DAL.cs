using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Forbidden_Island.DataAccessLayer
{
    public class DAL
    {
        public DAL()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ForbiddenIslandDB"].ConnectionString;
        }
        private string connectionString = "Data Source=ASUSDRG4N\\SQLDRG4N;Initial Catalog=ForbiddenIslandDB;Integrated Security=True;Trust Server Certificate=True";

        public DataTable GetPlayers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Players", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void AddPlayer(string name, string role)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Player (Name, Role) VALUES (@Name, @Role)", conn);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Role", role);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdatePlayerPosition(int playerId, int position)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Players SET Position = @Position WHERE PlayerId = @PlayerId", conn);
                cmd.Parameters.AddWithValue("@PlayerId", playerId);
                cmd.Parameters.AddWithValue("@Position", position);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void AddAction(int playerId, string actionType, string direction, int actionCount)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Action (PlayerId, ActionType, Direction, ActionCount) VALUES (@PlayerId, @ActionType, @Direction, @ActionCount)", conn);
                cmd.Parameters.AddWithValue("@PlayerId", playerId);
                cmd.Parameters.AddWithValue("@ActionType", actionType);
                cmd.Parameters.AddWithValue("@Direction", direction);
                cmd.Parameters.AddWithValue("@ActionCount", actionCount);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}