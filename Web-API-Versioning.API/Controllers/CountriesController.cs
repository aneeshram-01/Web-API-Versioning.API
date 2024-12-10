    using Asp.Versioning;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Web_API_Versioning.API.Models.DTOs;

namespace Web_API_Versioning.API.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    public class CountriesController : ControllerBase
    {
        [MapToApiVersion("1.0")]
        [HttpGet]
        public IActionResult GetV1()
        {
            var countriesDomainModel = CountriesData.Get();
            var response = countriesDomainModel.Select(countryDomain => new CountryDtoV1
            {
                Id = countryDomain.Id,
                Name = countryDomain.Name,
            }).ToList();

            return Ok(response);
        }

        [MapToApiVersion("2.0")]
        [HttpGet]
        public IActionResult GetV2()
        {
            var countriesDomainModel = CountriesData.Get();
            var response = countriesDomainModel.Select(countryDomain => new CountryDtoV2
            {
                Id = countryDomain.Id,
                CountryName = countryDomain.Name,
            }).ToList();

            return Ok(response);
        }
    }

}
