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

        public static List<RequestsSolicitationDTO> GetLisRequestsSolicitation()
        {
            var client = new RestClient("https://localhost:44306/api/Snacks");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "text/plain");
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<List<RequestsSolicitationDTO>>(response.Content);
            return ret;
        }

        public static SolicitationProductSnacksDTO PostSnacks(SolicitationProductSnacksDTO solicitationProductSnacks)
        {
            var ret0 = JsonConvert.SerializeObject(solicitationProductSnacks);
            var client = new RestClient("https://localhost:44306/api/Snacks");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("accept", "text/plain");
            IRestResponse response = client.Execute(request);
            var ret = JsonConvert.DeserializeObject<SolicitationProductSnacksDTO>(response.Content);
            return ret;
        }
    }
}
