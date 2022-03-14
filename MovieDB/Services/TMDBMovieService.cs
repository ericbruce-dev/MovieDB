using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using MovieDB.Enums;
using MovieDB.Models.Settings;
using MovieDB.Models.TMDB;
using MovieDB.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace MovieDB.Services
{
    public class TMDBMovieService : IRemoteMovieService
    {
        private readonly AppSettings _appSettings;
        private readonly IHttpClientFactory _httpClient;

        public TMDBMovieService(IOptions<AppSettings> appSettings, IHttpClientFactory httpClient)
        {
            _appSettings = appSettings.Value;
            _httpClient = httpClient;
        }

        public async Task<ActorDetail> ActorDetailAsync(int id)
        {
            //1 Setup a default instance of MoiveSearch
            ActorDetail actorDetail = new();

            //2 Assemble the full request uri string
            var query = $"{_appSettings.TMDBSettings.BaseUrl}/movie/{id}";
            var queryParams = new Dictionary<string, string>()
            {
                { "api_key", _appSettings.MovieDbSettings.TmdbApiKey },
                { "language", _appSettings.TMDBSettings.QueryOptions.Language }
            };

            var requestUri = QueryHelpers.AddQueryString(query, queryParams);

            //3 Create a client and execute the request
            var client = _httpClient.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var response = await client.SendAsync(request);

            //4 Return the MovieSearch object
            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var dcjs = new DataContractJsonSerializer(typeof(ActorDetail));
                actorDetail = dcjs.ReadObject(responseStream) as ActorDetail;
            }

            return actorDetail;
        }

        public async Task<MovieDetail> MovieDetailAsync(int id)
        {
            //1 Setup a default instance of MoiveSearch
            MovieDetail movieDetail = new();

            //2 Assemble the full request uri string
            var query = $"{_appSettings.TMDBSettings.BaseUrl}/movie/{id}";
            var queryParams = new Dictionary<string, string>()
            {
                { "api_key", _appSettings.MovieDbSettings.TmdbApiKey },
                { "language", _appSettings.TMDBSettings.QueryOptions.Language },
                { "append_to_response", _appSettings.TMDBSettings.QueryOptions.Page }
            };

            var requestUri = QueryHelpers.AddQueryString(query, queryParams);

            //3 Create a client and execute the request
            var client = _httpClient.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var response = await client.SendAsync(request);

            //4 Return the MovieSearch object
            if (response.IsSuccessStatusCode)
            {
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var dcjs = new DataContractJsonSerializer(typeof(MovieDetail));
                movieDetail = dcjs.ReadObject(responseStream) as MovieDetail;
            }

            return movieDetail;
        }

        public async Task<MovieSearch> SearchMoviesAsync(MovieCategory category, int count)
        {
            //Setup a default instance of MoiveSearch
            MovieSearch movieSearch = new();

            //Assemble the full request uri string
            var query = $"{_appSettings.TMDBSettings.BaseUrl}/movie/{category}";
            var queryParams = new Dictionary<string, string>()
            {
                { "api_key", _appSettings.MovieDbSettings.TmdbApiKey },
                { "language", _appSettings.TMDBSettings.QueryOptions.Language },
                { "page", _appSettings.TMDBSettings.QueryOptions.Page }
            };

            var requestUri = QueryHelpers.AddQueryString(query, queryParams);

            //Create a client and execute the request
            var client = _httpClient.CreateClient();
            var request = new HttpRequestMessage(HttpMethod.Get, requestUri);
            var response = await client.SendAsync(request);

            //Return the MovieSearch object
            if (response.IsSuccessStatusCode)
            {
                var dcjs = new DataContractJsonSerializer(typeof(MovieSearch));
                using var responseStream = await response.Content.ReadAsStreamAsync();
                movieSearch = (MovieSearch)dcjs.ReadObject(responseStream);
                movieSearch.Results = movieSearch.Results.Take(count).ToArray();
                movieSearch.Results.ToList().ForEach(result => result.PosterPath = $"{_appSettings.TMDBSettings.BaseImagePath}/{_appSettings.MovieDbSettings.DefaultPosterSize}/{result.PosterPath}");
            }

            return movieSearch;
        }
    }
}
