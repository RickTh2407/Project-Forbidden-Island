using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Forbidden_Island.DataAccessLayer
{
    internal class DAL
    {
        public DAL()
        {

        }
        public string connectionString = "Data Source=ASUSDRAGON\\SQLEXPRESS;Initial Catalog=Doolhof;Integrated Security=True";
        public List<PathCard> pathCards = new List<PathCard>();
        public List<ObjectiveCard> objectiveCards = new List<ObjectiveCard>();
        public List<ObjectiveCard> ReadObjectives()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM ObjectiveCard ORDER BY Id";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            objectiveCards.Add(new ObjectiveCard(Int32.Parse(reader[0].ToString())
                                , reader[1].ToString()
                                ));
                        }
                    }
                }
            }
            return objectiveCards;
        }
        public List<PathCard> ReadPath()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM PathCard ORDER BY Id";

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pathCards.Add(new PathCard(Int32.Parse(reader[0].ToString())
                                , Int32.Parse(reader[1].ToString())
                                , Boolean.Parse(reader[2].ToString())
                                , Int32.Parse(reader[3].ToString())
                                , Boolean.Parse(reader[4].ToString())
                                , reader[5].ToString()
                                ));
                        }
                    }
                }
            }
            return pathCards;
        }
    }
}