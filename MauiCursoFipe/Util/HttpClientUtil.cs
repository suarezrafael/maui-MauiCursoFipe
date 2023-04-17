using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiCursoFipe.Util
{
    public class HttpClientUtil
    {
        public static async Task<string> ConsHttpClientAsync(string endereco)
        {
			var client =new HttpClient();	
			try
			{
				HttpResponseMessage response = await client.GetAsync(endereco).ConfigureAwait(false);
				response.EnsureSuccessStatusCode();
				string reponseBody = await response.Content.ReadAsStringAsync();

				return reponseBody;
			}
			catch (Exception)
			{
				return "";
				
			}
        }

    }
}
