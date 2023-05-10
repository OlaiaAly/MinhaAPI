  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinhaAPI.Data.Services;
using MinhaAPI.Data.Models;


namespace MinhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        

        [HttpGet("get-country/name/{name}")]
        public IActionResult GetCountryByName(string name)
        {

            List<CountryModel> country =  CountryServeces.GetCountryByName(name).Result;

            return Ok(country);
        }

        [HttpGet("get-country/capital/{capital}")]
        public IActionResult GetCountryByCapital(string capital)
        {

            List<CountryModel> country = CountryServeces.GetCountryByCapital(capital).Result;

            return Ok(country);
        }

        [HttpGet("get-all-countries")]
        public IActionResult GetAllCountries()
        {
            List<CountryModel> countries = CountryServeces.GetAllCountriesAsync().Result;

            return Ok(countries);
        }

        [HttpGet("get/language/{language}")]
        public IActionResult GetAllCountriesByLanguage(string language)
        {
            
                List<CountryModel> countries = CountryServeces.GetAllCountriesByLanguage(language).Result;

                return Ok(countries);
        }

        [HttpGet("get/currency/{currency}")]
        public IActionResult GetCountryByCurrency(string currency)
        {

            List<CountryModel> countries = CountryServeces.GetCountryByCurrency(currency).Result;

            return Ok(countries);
        }


    }
    
}
