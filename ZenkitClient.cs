using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Zenkit.Base.Api.Models;

namespace Zenkit.Base.Api
{
    public class ZenkitClient : IDisposable
    {
        private const string ZenkitBaseHost = "https://base.zenkit.com";
        private const string ZenkitApiVersion = "v1";
        private readonly HttpClient client = new HttpClient();
        private string apiKey;

        public ZenkitClient(string apiKey)
        {
            this.apiKey = apiKey;
            client.DefaultRequestHeaders.Add(Constants.ZenkitApiKeyHeader, apiKey);
        }

        #region Elements
        public async Task<List<ElementCategory>> GetElementCategoriesAsync()
        {
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, $"{ZenkitBaseHost}/api/{ZenkitApiVersion}/elementcategories");
            var response = await this.client.SendAsync(requestMessage);

            return await response.Content.ReadAsJsonAsync<List<ElementCategory>>();
        }

        public async Task<List<Element>> GetElementsInCollectionAsync(
            string listAllId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"{ZenkitBaseHost}/api/{ZenkitApiVersion}/lists/{listAllId}/elements");
            var response = await this.client.SendAsync(request);

            return await response.Content.ReadAsJsonAsync<List<Element>>();
        }
        #endregion

        #region Entries
        public async Task<FilterResponse> GetEntriesFromFilterAsync(
            string listShortId,
            Filter filter)
        {
            bool hasMoreResults = false;
            int skip = 0;
            FilterResponse filterResponse = new FilterResponse();
            do
            {
                filter.Skip = skip;
                var request = new HttpRequestMessage(HttpMethod.Post, $"{ZenkitBaseHost}/api/{ZenkitApiVersion}/lists/{listShortId}/entries/filter/list");
                request.Content = new StringContent(JsonSerializer.Serialize(filter), System.Text.Encoding.UTF8, System.Net.Mime.MediaTypeNames.Application.Json);

                var response = await this.client.SendAsync(request);
                var results = await response.Content.ReadAsJsonAsync<FilterResponse>();
                filterResponse.CountData = results.CountData;
                filterResponse.CountDataPerGroup = results.CountDataPerGroup;

                if (filterResponse.ListEntries == null)
                {
                    filterResponse.ListEntries = results.ListEntries;
                }
                else
                {
                    filterResponse.ListEntries.AddRange(results.ListEntries);
                }

                hasMoreResults = results.ListEntries.Count > 0;
                skip += Constants.FetchCount;
            }
            while (hasMoreResults);

            return filterResponse;
        }
        #endregion


        public void Dispose()
        {
            client.Dispose();
        }
    }
}
