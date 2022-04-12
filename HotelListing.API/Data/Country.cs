namespace HotelListing.API.Data
{
    public class Country
    {
        public string Name { get; set; }    
        public int Id { get; set; }
        public string ShortName { get; set; }

        public virtual IList<Hotel> Countries { get; set; }
    }
}
