using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using MinhaAPI.Data.Models;



namespace MinhaAPI.Data.Services
{
    public class CountryServeces {

        public static string content;

        public static async Task<List<CountryModel>> GetAllCountriesAsync()
        {
            List<CountryModel> countries;
            try
            {
                var request =
                  new HttpRequestMessage(HttpMethod.Get, $"https://restcountries.com/v3.1/all?fields=name,capital,region,subregion,subregion,area,timezones,flags");

                using (var client = new HttpClient())
                {
                    var responseCountryRest = await client.SendAsync(request);

                    var contentResp = await responseCountryRest.Content.ReadAsStringAsync();

                    countries = JsonConvert.DeserializeObject<List<CountryModel>>(contentResp);
                
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return countries;

        }



        public static async Task<List<CountryModel>> GetAllCountriesByLanguage(string language)
        {
            List<CountryModel> countries;
            try
            {
                var request =
                  new HttpRequestMessage(HttpMethod.Get, $"https://restcountries.com/v3.1/lang/{language}/?fields=name,capital,region,subregion,subregion,area,timezones,flags");

                using (var client = new HttpClient())
                {
                    var responseCountryRest = await client.SendAsync(request);

                    var contentResp = await responseCountryRest.Content.ReadAsStringAsync();

                    countries = JsonConvert.DeserializeObject<List<CountryModel>>(contentResp);

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            return countries;

        }

        public static  async Task <List<CountryModel>> GetCountryByName(string name)
        {
                  
            List <CountryModel> country;
            try { 
                var request =
                  new HttpRequestMessage(HttpMethod.Get, $"https://restcountries.com/v3.1/name/{name}/?fields=name,capital,region,subregion,subregion,area,timezones,flags");

                using (var client = new HttpClient())
                {
                    var responseCountryRest = await client.SendAsync(request);

                    var contentResp = await responseCountryRest.Content.ReadAsStringAsync();

                    country = JsonConvert.DeserializeObject<List<CountryModel>>(contentResp);

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
           }

            return country;
        }


        public static async Task<List<CountryModel>> GetCountryByCapital( string capital )
        {

            List<CountryModel> country;

            var request =
              new HttpRequestMessage(HttpMethod.Get, $"https://restcountries.com/v3.1/capital/{capital}/?fields=name,capital,region,subregion,subregion,area,timezones,flags");

            using (var client = new HttpClient())
            {
                var responseCountryRest = await client.SendAsync(request);

                var contentResp = await responseCountryRest.Content.ReadAsStringAsync();


                country = JsonConvert.DeserializeObject<List<CountryModel>>(contentResp);

            }

            return country;
        }
    


        public static async Task<List<CountryModel>> GetCountryByCurrency(string currency)
        {

            List<CountryModel> country;

            var request =
              new HttpRequestMessage(HttpMethod.Get, $"https://restcountries.com/v3.1/currency/{currency}?fields=name,capital,region,subregion,subregion,area,timezones,flags");

            using (var client = new HttpClient())
            {
                var responseCountryRest = await client.SendAsync(request);

                var contentResp = await responseCountryRest.Content.ReadAsStringAsync();


                country = JsonConvert.DeserializeObject<List<CountryModel>>(contentResp);

            }

            return country;
        }
    }
     
 }



