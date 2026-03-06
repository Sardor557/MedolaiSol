using Medolai.Shared;
using Medolai.Shared.Models;
using Medolai.Utils.Serializable;
using System.IO;
using System.Net.Http;

namespace Medolai.App.Services
{
    public class GridService
    {
        public async Task<List<GtdDeclarationGridRow>> GetRowsAsync()
        {
            using var client = new HttpClient();
            using var req = new HttpRequestMessage(HttpMethod.Get, "http://localhost:14201/api/v1/Gtd/GetAll");
            using var res = await client.SendAsync(req);
            var json = await res.Content.ReadAsStringAsync();
            var result = json.FromJson<List<GtdDeclarationGridRow>>();
            return result;
        }

        public async Task<AnswerBasic> LoadAsync(string filePath)
        {
            using var client = new HttpClient();

            using var form = new MultipartFormDataContent();
            await using var fileStream = File.OpenRead(filePath);

            using var streamContent = new StreamContent(fileStream);

            form.Add(streamContent, "file", Path.GetFileName(filePath));

            HttpResponseMessage response = await client.PostAsync("http://localhost:14201/api/v1/Gtd/File", form);
            string responseContent = await response.Content.ReadAsStringAsync();

            return responseContent.FromJson<AnswerBasic>();
        }
    }
}
