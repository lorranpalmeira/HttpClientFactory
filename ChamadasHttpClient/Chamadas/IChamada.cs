using System.IO;
using System.Threading.Tasks;

namespace ChamadasHttpClient.Chamadas
{
    public interface IChamada
    {
         
        Task<string> RetornaDadosApi();
        
    }
}