
using Newtonsoft.Json;
using Soapnet.Models;

namespace Soapnet.Services
{

    public class CONSULTASPOKEDEX
    {
        private readonly HttpClient _httpcliente;

        private static readonly string UrlBase = "https://pokeapi.co/api/v2";
        public CONSULTASPOKEDEX(HttpClient httpClient)
        {
            _httpcliente = httpClient;
        }


        public async Task<Root> Obtenerlista(int id)
        {
            try
            {
                var client =  _httpcliente;
                var request = new HttpRequestMessage(
                    HttpMethod.Get,
                    $"{UrlBase}/encounter-condition/{(id < 0 ? "1" : id.ToString())}"
                );
                 var response = await client.SendAsync(request);
               
                Console.WriteLine(id);
                string resp = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<Root>(resp) ??  new Root();
                Console.WriteLine("Respuesta: \n" + resp.ToString());
                return result;

            }
            catch (System.Exception)
            {

                return new Root();
            }
        }

    }

}