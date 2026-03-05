using Medolai.Shared.Models;
using Medolai.Utils.Serializable;
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
    }
}
