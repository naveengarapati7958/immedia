using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using API.Models;
using API.Models.Details;
using API.Models.Photos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandmarkController : ControllerBase
    {
        private const string BaseUrl = "https://api.foursquare.com/v2";
        private const string apiauth = "v=20200511&client_id=T1QHICJK4NPR3RZWWRRV3YZY5YL3QJKHVLMKRX0B1YYL0AIY&client_secret=XK0Q3KYJOSN51XTTRZDJ1JWNYOEHDXVEXMHUQPLBQKN35FX3";

        // GET: api/getbyplace/place
        [Route("getbyplace/{place}")]
        [HttpGet]
        public async Task<Landmark> GetLandmarksByPlace(string place)
        {
            string s = string.Empty;
            if (!string.IsNullOrEmpty(place))
                s = string.Format("{0}/venues/explore?near={1}&{2}", BaseUrl, place, apiauth);
     
            var _client = new HttpClient();          
            var httpResponse = await _client.GetAsync(s);

            if (!httpResponse.IsSuccessStatusCode)
            { 
                throw new Exception("Cannot retrieve landmarks");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var tasks = JsonConvert.DeserializeObject<Landmark>(content);

            return tasks;
        }

        // GET: api/getbyplace/lat/lng
        [Route("getbyplace/{lat}/{lng}")]
        [HttpGet]
        public async Task<Landmark> GetLandmarksByPlace(string lat, string lng)
        {
            string s = string.Empty;
            if (!string.IsNullOrEmpty(lat) && !string.IsNullOrEmpty(lng))
                s = string.Format("{0}/venues/explore?ll={1},{2}&{3}", BaseUrl, lat, lng, apiauth);

            var _client = new HttpClient();
            var httpResponse = await _client.GetAsync(s);

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve landmarks");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var tasks = JsonConvert.DeserializeObject<Landmark>(content);

            return tasks;
        }


        // GET: api/getphotos/id
        [Route("getphotos/{id}")]
        [HttpGet]
        public async Task<Photo> GetPhotosByVenue(string id)
        {
            string s = string.Empty;
            if (!string.IsNullOrEmpty(id))
                s = string.Format("{0}/venues/{1}/photos?&{2}", BaseUrl, id, apiauth);

            var _client = new HttpClient();
            var httpResponse = await _client.GetAsync(s);

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve photos");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var tasks = JsonConvert.DeserializeObject<Photo>(content);

            return tasks;
        }

        // GET: api/getphotodetails/id
        [Route("getphotodetails/{id}")]
        [HttpGet]
        public async Task<PhotoDetails> GetPhotoDetails(string id)
        {
            string s = string.Empty;
            if (!string.IsNullOrEmpty(id))
                s = string.Format("{0}/photos/{1}?&{2}", BaseUrl, id, apiauth);

            var _client = new HttpClient();
            var httpResponse = await _client.GetAsync(s);

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve photos");
            }

            var content = await httpResponse.Content.ReadAsStringAsync();
            var tasks = JsonConvert.DeserializeObject<PhotoDetails>(content);

            return tasks;
        }


    }
}
