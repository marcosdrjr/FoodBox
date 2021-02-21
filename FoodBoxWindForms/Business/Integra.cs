using FoodBoxLibrary.Models.DTOS;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBoxWindForms.Business
{
    public class Integra
    {
        public string uri = "https://localhost:44306/api";
        public static List<ProductDTO> GetLisProducts()
        {
            var client = new RestClient("https://localhost:44306/api/Product");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "text/plain");
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<List<ProductDTO>>(response.Content);
            return ret;
        }

        public static List<SnacksDTO> GetLisSnacks()
        {
            var client = new RestClient("https://localhost:44306/api/Snacks");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "text/plain");
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<List<SnacksDTO>>(response.Content);
            return ret;
        }

        public static List<RequestsSolicitationCodeDTO> GetLisRequestsSolicitation()
        {
            var client = new RestClient("https://localhost:44306/api/SolicitationFood");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "text/plain");
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<List<SolicitationFoodDTO>>(response.Content);
            if (ret.Count() == 0) return null;
            var listRequestsSolicitation = new List<RequestsSolicitationCodeDTO>();
            foreach (var item in ret)
            {
                var req = new RequestsSolicitationCodeDTO (item.id_solicitation_food);
                listRequestsSolicitation.Add(req);
            }
            return listRequestsSolicitation;
        }

        public static SolicitationProductSnacksDTO PostSnacks(SolicitationProductSnacksDTO solicitationProductSnacks)
        {
            var json = JsonConvert.SerializeObject(solicitationProductSnacks);
            var client = new RestClient("https://localhost:44306/api/Snacks");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("accept", "text/plain");
            request.AddHeader("Content-Type", "application/json");

            request.AddParameter("application/json", json, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            var ret = JsonConvert.DeserializeObject<SolicitationProductSnacksDTO>(response.Content);
            return ret;
        }
    }
}
