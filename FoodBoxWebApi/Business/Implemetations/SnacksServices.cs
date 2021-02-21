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
    public class SnacksServices : ISnacksServices
    {

        private readonly ConfigurationSettings configuration;

        public SnacksServices(ConfigurationSettings configuration)
        {
            this.configuration = configuration;
        }

        public async Task<List<SnacksDTO>> GetSnacks()
        {
            using (var connection = new SqlConnection(configuration.ConnectionStrings))
            {
                await connection.OpenAsync();

                var sql = "exec [SP_Snacks]";

                var ret = await connection.QueryAsync<SnacksDTO>(sql);
                return ret.ToList();
            }

        }

        public async Task<SnacksDTO> GetSnacksById(int id)
        {
            using (var connection = new SqlConnection(configuration.ConnectionStrings))
            {
                await connection.OpenAsync();

                var sql = "exec [SP_SnacksById] @id_snacks";
                var values = new { id_snacks = id };

                var ret = await connection.QueryFirstOrDefaultAsync<SnacksDTO>(sql,values);
                return ret;
            }

        }
    }
}
