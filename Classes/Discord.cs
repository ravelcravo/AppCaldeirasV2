using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppCaldeirasV2.Classes
{
    public static class Discord
    {
 
        public static async Task EnviarAlertaDiscord(string webhookUrl, string mensagem)
        {
            HttpClient _httpClient = new HttpClient();

            var payload = new
            {
                content = mensagem,
                username = "Monitoramento de Caldeiras"
            };

            var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");

            await _httpClient.PostAsync(webhookUrl, content);

        }
    }
}
