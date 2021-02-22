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
    public class PoductServices : IPoductServices
    {
        private readonly ConfigurationSettings configuration;

        public PoductServices(ConfigurationSettings configuration)
        {
            this.configuration = configuration;
        }

        public async Task<List<ProductDTO>> GetPoduct()
        {
            using (var connection = new SqlConnection(configuration.ConnectionStrings))
            {
                await connection.OpenAsync();

                var sql = "exec [SP_GetProduct]";

                var ret = await connection.QueryAsync<ProductDTO>(sql);
                return ret.ToList();
            }
        }

        public async Task<ProductDTO> GetPoductById(int id)
        {   
            using (var connection = new SqlConnection(configuration.ConnectionStrings))
            {
                await connection.OpenAsync();

                var sql = "exec [SP_GetProductById] @id_product";
                var values = new { id_product = id };

                var ret = await connection.QueryFirstOrDefaultAsync<ProductDTO>(sql, values);
                return ret;
            }
        }
    }
}
