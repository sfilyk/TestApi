using Newtonsoft.Json;
using RestSharp;

namespace TaskApi
{
    public class BaseTask
    {
        const string api_key = "9aeff64ba62aa8035dc75b773784dc5e";
        public QuestSessionId GetKeyId()
        {
            var restClient = new RestClient("https://api.themoviedb.org/3");
            var restRequest = new RestRequest($"/authentication/guest_session/new?api_key={api_key}", Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;
            IRestResponse response = restClient.Execute(restRequest);
            var content = response.Content;

            var GetContent = JsonConvert.DeserializeObject<QuestSessionId>(content);
            return GetContent;
        }

    }
}
