using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SEN381_API_GROUP3.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicalServiceProviderController : ControllerBase
    {
        // GET: api/<MedicalServiceProviderController>
        [HttpGet]
        public IEnumerable<string> getProviderList()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MedicalServiceProviderController>/5
        [HttpGet("{id}")]
        public string getproviderDetails (int id)
        {
            return "value";
        }

        // POST api/<MedicalServiceProviderController>
        [HttpPost]
        public void insertProvider([FromBody] string value)
        {
        }

        // PUT api/<MedicalServiceProviderController>/5
        [HttpPut("{id}")]
        public void updateProvider(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MedicalServiceProviderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
