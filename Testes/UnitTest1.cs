using System;
using Xunit;
using System.Net.Http;
using System.Net.Http.Formatting;
using ChamadasHttpClient.Controllers;
using Microsoft.AspNetCore.Mvc;
using ChamadasHttpClient.Chamadas;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using Newtonsoft.Json;
using System.Text;
using System.Net.Http.Headers;
using System.Net.Mime;
using NSubstitute;

namespace Testes
{
    public class UnitTest1
    {
                 

        [Fact]
        public void MockDaChamadaHttpClientFactory()
        {
            var chamadaMock = Substitute.For<IChamada>();
           var httpClientFactoryMock = Substitute.For<IHttpClientFactory>();
            

            var fakeHttpMessageHandler = new FakeHttpMessageHandler(new HttpResponseMessage() {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(JsonConvert.SerializeObject("Hello World"), Encoding.UTF8, "application/json") 
            });
            var fakeHttpClient = new HttpClient(fakeHttpMessageHandler);

            httpClientFactoryMock.CreateClient().Returns(fakeHttpClient);

            

            var chamada = new Chamada(httpClientFactoryMock);
            var helloWorld = chamada.RetornaDadosApi();
           

            Assert.Equal("Hello World", helloWorld);
        }
    }
}
