using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Lab22StarWarsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab22StarWarsApi.Controllers
{
    public class StarWarsController : Controller
    {
        public async Task<IActionResult> SearchPersonById()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");
            var response = await client.GetAsync($"people/");
            //Install Microsoft.AspNet.WebApI.Client Nuget Package
            var person = await response.Content.ReadAsAsync<PersonData>();
            return View(person);
        }


        public async Task<IActionResult> GetPersonById(int Id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");
            var response = await client.GetAsync($"people/{Id}");
            //Install Microsoft.AspNet.WebApI.Client Nuget Package
            var person = await response.Content.ReadAsAsync<PersonData>();
            return View(person);
        }

        public async Task<IActionResult> GetPlanetsById(int Id)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://swapi.co/api/");
            var response = await client.GetAsync($"planets/{Id}");
            //Install Microsoft.AspNet.WebApI.Client Nuget Package
            var planets = await response.Content.ReadAsAsync<PlanetData>();
            return View(planets);
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}