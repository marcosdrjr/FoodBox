using FoodBoxLibrary.Models.DTOS;
using FoodBoxWebApi.Business.Intefaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using FoodBoxWebApi.Settings;

namespace FoodBoxWebApi.Business.Implemetations
{
    public class SolicitationFoodServices : ISolicitationFoodServices
    {
        private readonly ConfigurationSettings configuration;

        public SolicitationFoodServices(ConfigurationSettings configuration)
        {
            this.configuration = configuration;
        }

        public async Task<List<SolicitationFoodDTO>> GetSolicitationFood()
        {
            using (var connection = new SqlConnection(configuration.ConnectionStrings))
            {
                await connection.OpenAsync();

                var sql = "exec [SP_solicitation_food]";

                var ret = await connection.QueryAsync<SolicitationFoodDTO>(sql);
                return ret.ToList();
            }

        }

        public async Task<SolicitationFoodDTO> GetSolicitationFoodById(int id)
        {
            using (var connection = new SqlConnection(configuration.ConnectionStrings))
            {
                await connection.OpenAsync();

                var sql = "exec [SP_solicitation_foodById] @id_solicitation_food";
                var values = new { id_solicitation_food = id };

                var ret = await connection.QueryFirstOrDefaultAsync<SolicitationFoodDTO>(sql, values);
                return ret;
            }

        }
    }
}
