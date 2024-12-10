using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_API_Versioning.API.Models.DTOs;

namespace Web_API_Versioning.API.V1.Controllers
{
    //Route for exitising clients 
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            var countriesDomainModel = CountriesData.Get();

            //Map Domain Model to Dto
            var response = new List<CountryDtoV1>();
            foreach (var countryDomain in countriesDomainModel) 
            {
                response.Add(new CountryDtoV1
                { 
                    Id = countryDomain.Id,
                    Name = countryDomain.Name,
                });
            }
            return Ok(response);
        }
    }
}
