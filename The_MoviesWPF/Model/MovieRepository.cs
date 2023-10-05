using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace The_MoviesWPF.Model
{
    public class MovieRepository
    {
        private Movie _movie {  get; set; }
        
        public void Add(Movie movie)
        {
            _movie = movie;
            
            string sqlInsertInto = "INSERT INTO Movie(Title, Duration, Genre) Values(@Title,@Duration,@Genre)";
            
            
            DatabaseConnection databaseConnection = new DatabaseConnection();
            using ( SqlConnection conn = new SqlConnection(databaseConnection.DatabaseConnectionString()))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlInsertInto, conn);
                cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = _movie.Title;
                cmd.Parameters.Add("@Duration", SqlDbType.Int).Value = _movie.Duration;
                cmd.Parameters.Add("@Genre", SqlDbType.NVarChar).Value = _movie.Genre;
                cmd.ExecuteNonQuery();
            }
        }

       
    }
}
