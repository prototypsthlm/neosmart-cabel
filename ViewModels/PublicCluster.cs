using NeosmartCabel.Models;

namespace NeosmartCabel.ViewModels
{
    public class PublicCluster
    {
        public PublicCluster(Cluster cluster)
        {
            Id = cluster.Sys.Id;
            Title = cluster.Title;
            Text = cluster.Text;
            Icon = cluster.Icon.File.Url;
            HorizontalBanner = cluster.HorizontalBanner.File.Url;
            VerticalBanner = cluster.VerticalBanner.File.Url;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
        public string HorizontalBanner { get; set; }
        public string VerticalBanner { get; set; }
    }
}
