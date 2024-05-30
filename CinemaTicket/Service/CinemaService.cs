using CinemaTicket.Interface;
using CinemaTicket.Model;
using System.Data;
using System.Data.SqlClient;

namespace CinemaTicket.Service
{
    public class CinemaService : ICinemaService
    {
        public bool AddCinema(CinemaModel.AddCinemaInputModel Cinema)
        {
            // add ADO
            const string connectionString =
            "Data Source=.;Initial Catalog=CinemaTicket;"
            + "Integrated Security=true";

            
            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertCinema", connection))
                {
                    try
                    {
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.Add("@CityId", SqlDbType.Int).Value = Cinema.CityId;
                    cmd.Parameters.Add("@CinemaName", SqlDbType.NVarChar).Value = Cinema.CinemaName;
                    cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Cinema.Address;
                    cmd.Parameters.Add("@MainPhoto", SqlDbType.NVarChar).Value = Cinema.MainPhoto;
                    cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = Cinema.Phone;
                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = Cinema.Description;


                    
                    cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }
                }
            }
    }
}
