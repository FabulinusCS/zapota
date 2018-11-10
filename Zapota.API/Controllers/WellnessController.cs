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
            return Ok(wellnessRepository.GetAll()); 
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Wellness> Get(Guid Id)
        {
            return Ok(wellnessRepository.Get(Id));
        }
    

        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] JObject value)
        {
            Wellness posted = value.ToObject<Wellness>();
            wellnessRepository.Save(posted);
            return Created($"api/Wellness/{value}", value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid Id, [FromBody] JObject value)
        {
            Wellness posted = value.ToObject<Wellness>();
            posted.Id = Id;// Ensure an id is attached
            wellnessRepository.Save(posted);
            return Accepted(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid Id)
        {
            wellnessRepository.Delete(Id);
            return NoContent();
        }
    }
}
