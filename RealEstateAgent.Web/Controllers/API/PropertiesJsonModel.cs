namespace RealEstateAgent.Web.Controllers.API
{
    public class PropertiesJsonModel
    {
        public int Id { get; set; }

        public string Address { get; set; }

        public int Price { get; set; }

        public int Size { get; set; }

        public int LastPosted { get; set; }

        public string Owner { get; set; }
    }
}