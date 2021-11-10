using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Authentication.BAL.Logics;
using Authentication.DAL.Entities;

namespace Authentication.Controllers
{
    [Route("api/st")]
    [ApiController]
    public class StationController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Object> Get()
        {
            return new StationLogic().Get();
        }
        [Route("{id}")]
        [HttpGet]
        public Object Get(Guid id)
        {
            return new StationLogic().Get(id);
        }
        [Route("add")]
        [HttpPost]
        public int Add(Station ct)
        {
            return new StationLogic().Insert(ct);
        }

        [Route("edit/{id}")]
        [HttpPut]
        public int Edit(Station ct)
        {
            return new StationLogic().Update(ct);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public int Delete(Guid id)
        {
            return new StationLogic().Delete(id);
        }
    }
}