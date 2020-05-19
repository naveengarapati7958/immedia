using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebApp.DataLayer;
using WebApp.Models;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMMEDIADbContext _context;
        private const string BaseUrl = "https://localhost:44395/";
        public HomeController(ILogger<HomeController> logger, IMMEDIADbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> GetVenuesByPlace(string placename, string lat, string lng)
        {
            var model = await GetVenues(placename, lat, lng);
            return View("Index", model);
        }
        public async Task<VenuesViewModel> GetVenues(string place, string lat = null, string lng = null)
        {
            var _client = new HttpClient();
            _client.BaseAddress = new Uri(BaseUrl);
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var api = !string.IsNullOrEmpty(place) ? string.Format("api/landmark/getbyplace/{0}", place) : string.Format("api/landmark/getbyplace/{0}/{1}", lat, lng);

            var httpResponse = await _client.GetAsync(api);

            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve landmarks");
            }
            var content = await httpResponse.Content.ReadAsStringAsync();
            var tasks = JsonConvert.DeserializeObject<Landmarks>(content);
            List<SelectListItem> venueslist = new List<SelectListItem>();
            venueslist.Add(new SelectListItem { Text = "Select Venue", Value = string.Empty });
            List<VenueModel> vm = new List<VenueModel>();
            foreach (var x in tasks.response.groups[0].items)
            {
                var venueexist = _context.Venues.FirstOrDefault(p => p.id.Equals(x.venue.id));
                if (venueexist == null) vm.Add(new VenueModel { id = x.venue.id, name = x.venue.name });               
                venueslist.Add(new SelectListItem()
                {
                    Text = x.venue.name,
                    Value = x.venue.id
                });
            }
            ViewBag.Venues = venueslist;
            var model = new VenuesViewModel()
            {
                listItems = venueslist,
                SelectedValue = 1
            };

            //Insert into DB 
            _context.Venues.AddRange(vm);
            _context.SaveChanges();

            return model;
        }
        public IActionResult Index()
        {
            VenuesViewModel indexViewModel = new VenuesViewModel();
            indexViewModel.listItems = new List<SelectListItem>
            {
                new SelectListItem {Text = "Select Venue", Value = string.Empty}
            };
            return View(indexViewModel);
        }

        public async Task<IActionResult> Photos(string id, string n)
        {
            var _client = new HttpClient();
            _client.BaseAddress = new Uri(BaseUrl);
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var api = string.Format("api/landmark/getphotos/{0}", id);
            var httpResponse = await _client.GetAsync(api);
            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve photos");
            }
            var content = await httpResponse.Content.ReadAsStringAsync();
            var tasks = JsonConvert.DeserializeObject<PhotosViewModel>(content);
            List<PhotosViewModel.Items> photos = new List<PhotosViewModel.Items>();
            List<PhotoModel> photoModel = new List<PhotoModel>();
            foreach (var x in tasks.response.photos.items)
            {
                var photoexist = _context.Venues.FirstOrDefault(p => p.id.Equals(x.id));
                if (photoexist == null) photoModel.Add(new PhotoModel { id = x.id, prefix = x.prefix, suffix = x.suffix, width = x.width, height = x.height, venueid = id });
                photos.Add(new PhotosViewModel.Items
                {
                    id = x.id,
                    prefix = x.prefix,
                    suffix = x.suffix,
                    width = x.width,
                    height = x.height,
                    venueid = id,
                    venuename = n
                });
            }
            ViewBag.Photos = photos;
            var model = new PhotosViewModel()
            {
                photoList = photos
            };
            //Insert into DB 
            _context.Photos.AddRange(photoModel);
            _context.SaveChanges();
            return View(model);
        }

        public async Task<IActionResult> PhotoDetails(string id)
        {
            var _client = new HttpClient();
            _client.BaseAddress = new Uri(BaseUrl);
            _client.DefaultRequestHeaders.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var api = string.Format("api/landmark/getphotodetails/{0}", id);
            var httpResponse = await _client.GetAsync(api);
            if (!httpResponse.IsSuccessStatusCode)
            {
                throw new Exception("Cannot retrieve photo details");
            }
            var content = await httpResponse.Content.ReadAsStringAsync();
            var tasks = JsonConvert.DeserializeObject<PhotoDetails>(content);
          
            ViewBag.Photos = tasks;
            return View(tasks);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        //private IEnumerable<SelectListItem> GetColors()
        //{
        //    return new SelectListItem[]
        //    {
        //        new SelectListItem() { Text = "Select Place", Value = string.Empty }
        //    };
        //}

    }
}
