using System;
namespace Track.Models
{
    public class TrackConfig
    {
        public string Id { get; set; }
        public string Name { get; set; }


        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
    }
}
