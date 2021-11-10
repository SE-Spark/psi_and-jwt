using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Authentication.BAL.Logics;
using Authentication.DAL.Entities;

namespace Authentication.Controllers
{
    [Route("api/of")]
    [ApiController]
    public class OfficerController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Object> Get()
        {
            return new OfficerLogic().Get();
        }
        [Route("{id}")]
        [HttpGet]
        public Object Get(Guid id)
        {
            return new OfficerLogic().Get(id);
        }
        [Route("add")]
        [HttpPost]
        public int Add(Officer ct)
        {
            return new OfficerLogic().Insert(ct);
        }

        [Route("edit/{id}")]
        [HttpPut]
        public int Edit(Officer ct)
        {
            return new OfficerLogic().Update(ct);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public int Delete(Guid id)
        {
            return new OfficerLogic().Delete(id);
        }
    }
}