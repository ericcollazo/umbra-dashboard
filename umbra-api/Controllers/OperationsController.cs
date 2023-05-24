using Microsoft.AspNetCore.Mvc;
using react_learn.Models;
using react_learn.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace react_learn.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperationsController : Controller
    {
        private readonly ILogger<OperationsController> _logger;

        public OperationsController(ILogger<OperationsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Operation>? Get()
        {
            return LoadData.Operations();
        }

    }
}