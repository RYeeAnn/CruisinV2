using System;

namespace CruisinV2.Models
{
    public class WarningLights
    {
        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }
        
        public string Title { get; internal set; }

        public WarningLights()
        {
            
        }
    }
}