using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace samplewebapp.Pages
{
    public class IndexModel : PageModel
    {
        public string ID { get; set; }
        public string InstanceName { get; set; }

        private readonly IConfiguration _configuration;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void OnGet()
        {
            ID = Dns.GetHostName();
            InstanceName = _configuration["InstanceName"];
        }
    }
}
