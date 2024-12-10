namespace Web_API_Versioning.API.Models.DTOs
{
    public class CountryDtoV1   //For exisitng clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CountryDtoV2  //For new clients
    {
        public int Id { get; set; }
        public string CountryName { get; set; }  //Changed as per requirement
    }
}
