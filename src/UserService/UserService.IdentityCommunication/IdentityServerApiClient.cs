using System.Net.Http.Json;

namespace UserService.IdentityCommunication
{
    public class IdentityServerApiClient
    {
        private readonly HttpClient _httpClient;
        public IdentityServerApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //GetRolesAsync вернет массив с данными получиными в ответ от идентити сервера
        public async Task<UserModel> GetRolesAsync(string token)
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", token);
            var response = await _httpClient.GetFromJsonAsync<UserModel>("");
            return response;
        }

    }
}

