using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_API_Versioning.API.Models.DTOs;

namespace Web_API_Versioning.API.V2.Controllers
{
    //Route for new clients 
    [Route("api/v2/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            var countriesDomainModel = CountriesData.Get();

            //Map Domain Model to Dto
            var response = new List<CountryDtoV2>();
            foreach (var countryDomain in countriesDomainModel) 
            {
                response.Add(new CountryDtoV2
                { 
                    Id = countryDomain.Id,
                    CountryName = countryDomain.Name,   //Changed as per requirement
                });
            }
            return Ok(response);
        }
    }
}
