using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Zapota.DAO;
using Zapota.Entities;

namespace Zapota.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WellnessController : ControllerBase
    {
        private readonly IWellnessRepository<Wellness> wellnessRepository;

        public WellnessController(IWellnessRepository<Wellness> wellnessRepository)
        {
            this.wellnessRepository = wellnessRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Wellness>> Get()
        {
            return wellnessRepository.GetAll(); 
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Wellness> Get(Guid Id)
        {
            return wellnessRepository.Get(Id);
        }
    

        // POST api/values
        [HttpPost]
        public void Post([FromBody] JObject value)
        {
            Wellness posted = value.ToObject<Wellness>();
            wellnessRepository.Save(posted);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(Guid Id, [FromBody] JObject value)
        {
            Wellness posted = value.ToObject<Wellness>();
            posted.Id = Id;// Ensure an id is attached
            wellnessRepository.Save(posted);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Guid Id)
        {
            wellnessRepository.Delete(Id);
        }
    }
}
