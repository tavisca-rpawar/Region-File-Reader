using MongoDB.Bson;
namespace File_Reader
{
    public class Region
    {   
        public long RegionID { get; set; }
        public string RegionName { get; set; }
        public string RegionNameLong { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string SubClassification { get; set; }
    }
}
