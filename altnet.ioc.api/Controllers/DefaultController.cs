using Microsoft.AspNetCore.Mvc;
using altnet.ioc.api.Domain;

namespace altnet.ioc.api.Controllers
{
    [Produces("application/json")]
    [Route("api/Default")]
    public class DefaultController : Controller
    {
        private ServiceA _serviceA;
        private ServiceB _serviceB;

        public DefaultController(ServiceA serviceA, ServiceB serviceB)
        {
            _serviceA = serviceA;
            _serviceB = serviceB;
        }

        // GET: api/Default
        [HttpGet]
        public int Get()
        {
            var a = _serviceA.GetValueA();
            var b = _serviceB.GetValueB();
            // TODO: Play with the different life cycles of the NumberGenerator
            // TODO: Can you tell what the returned value would be for
            //      Transient?
            //      Singleton?
            //      Scoped?
            return a + b;
        }
    }
}
