using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace ChamadasHttpClient.Chamadas
{
    public class Chamada : IChamada
    {
        private IHttpClientFactory _clientFactory;

        public Chamada(IHttpClientFactory clientFactory)
        {
            this._clientFactory = clientFactory;
        }
        public Task<string> RetornaDadosApi()
        {
            var mockyClient = _clientFactory.CreateClient("mocky");

            return mockyClient.GetStringAsync("/v2/5185415ba171ea3a00704eed");
        }

        
    }
}