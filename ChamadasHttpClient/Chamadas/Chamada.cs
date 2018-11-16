using System.Net.Http;

namespace ChamadasHttpClient.Chamadas
{
    public class Chamada : IChamada
    {
        private IHttpClientFactory _clientFactory;

        public Chamada(IHttpClientFactory clientFactory)
        {
            this._clientFactory = clientFactory;
        }
        public string RetornaDadosApi()
        {
            var mockyClient = _clientFactory.CreateClient("mocky");

            return mockyClient.GetStringAsync("/v2/5185415ba171ea3a00704eed").Result;
        }
    }
}