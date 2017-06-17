using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.Classes.EnemyClasses;
using RPG.Classes.HeroClasses;
using RPG.Classes.MenuClasses;
using System.Data;
using RPG.Classes.Interfaces;
using System.Data.SqlClient;

namespace RPG.Classes.MenuClasses
{
    public class SQLRumorsDAL : IRumorDAL
    {
        private string connectionString; 

        public SQLRumorsDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public List<string> GetRumor(Hero player)
        {
            List<string> rumors = new List<string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "select RumorText from Rumor inner join Hero_Rumor on Rumor.RumorID = Hero_Rumor.RumorID inner join HeroType on HeroType.HeroID = Hero_Rumor.HeroID where HeroType.Hero = @type;";
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@type", player.GetType().Name);
                    conn.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string s = Convert.ToString(reader["RumorText"]);
                        rumors.Add(s);
                    }

                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return rumors;
        }
    }
}
