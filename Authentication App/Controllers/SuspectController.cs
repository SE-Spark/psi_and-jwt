using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Authentication.BAL.Logics;
using Authentication.DAL.Entities;

namespace Authentication.Controllers
{
    [Route("api/sp")]
    [ApiController]
    public class SuspectController : ControllerBase
    {


        [HttpGet]
        public IEnumerable<Object> Get()
        {
            return new SuspectLogic().Get();
        }
        [Route("{id}")]
        [HttpGet]
        public Object Get(Guid id)
        {
            return new SuspectLogic().Get(id);
        }
        [Route("add")]
        [HttpPost]
        public int Add(Suspect ct)
        {
            return new SuspectLogic().Insert(ct);
        }

        [Route("edit/{id}")]
        [HttpPut]
        public int Edit(Suspect ct)
        {
            return new SuspectLogic().Update(ct);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public int Delete(Guid id)
        {
            return new SuspectLogic().Delete(id);
        }
    }
}