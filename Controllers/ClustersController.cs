using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contentful.Core;
using Microsoft.AspNetCore.Mvc;
using NeosmartCabel.Models;
using NeosmartCabel.ViewModels;

namespace NeosmartCabel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClustersController : ControllerBase
    {
        private readonly IContentfulClient _client;

        public ClustersController(IContentfulClient client)
        {
            _client = client;
        }

        // GET api/clusters
        [HttpGet]
        public async Task<IEnumerable<PublicCluster>> Get()
        {
            var items = await _client.GetEntriesByType<Cluster>("clusters");
            return items.Select(item => new PublicCluster(item));
        }
    }
}
