using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;
using Veterinary.Models;

namespace Veterinary._Repositories
{
    public class PetRepository : BaseRepository, IPetRepository
    {
        // Constructor
        public PetRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // Methods
        public void AddPet(PetModel pet)
        {
            throw new NotImplementedException();
        }
        public void DeletePet(int id)
        {
            throw new NotImplementedException();
        }
        public void EditPet(PetModel pet)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<PetModel> GetAll()
        {
            var petList = new List<PetModel>();
            using var connection = new SqlConnection(connectionString);
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Pet ORDER BY Pet_Id desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pet = new PetModel
                        {
                            Id = Convert.ToInt32(reader["Pet_Id"]),
                            Name = reader["Pet_Name"].ToString(),
                            Type = reader["Pet_Type"].ToString(),
                            Colour = reader["Pet_Colour"].ToString(),
                        };
                        petList.Add(pet);
                    }
                    return petList;
                }
            }
        }
        public IEnumerable<PetModel> GetByValue(string value)
        {
            var petList = new List<PetModel>();
            var petId = int.TryParse(value, out int result) ? result : 0;
            var petName = value;
            using var connection = new SqlConnection(connectionString);
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Pet
                                            WHERE Pet_Id=@id OR Pet_Name LIKE @name + '%' 
                                            ORDER BY Pet_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = petId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = petName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var pet = new PetModel
                        {
                            Id = Convert.ToInt32(reader["Pet_Id"]),
                            Name = reader["Pet_Name"].ToString(),
                            Type = reader["Pet_Type"].ToString(),
                            Colour = reader["Pet_Colour"].ToString(),
                        };
                        petList.Add(pet);
                    }
                    return petList;
                }
            }
        }
    }

}
