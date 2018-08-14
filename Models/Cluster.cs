using Contentful.Core.Models;

namespace NeosmartCabel.Models
{
    public class Cluster
    {
        public SystemProperties Sys { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public Asset Icon { get; set; }
        public Asset HorizontalBanner { get; set; }
        public Asset VerticalBanner { get; set; }
    }
}
