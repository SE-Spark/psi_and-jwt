using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Authentication.BAL.Logics;
using Authentication.DAL.Entities;

namespace Authentication.Controllers
{
    [Route("api/wk")]
    [ApiController]
    public class WorkController : ControllerBase
    {


        [HttpGet]
        public IEnumerable<Object> Get()
        {
            return new WorkLogic().Get();
        }
        [Route("{id}")]
        [HttpGet]
        public Object Get(Guid id)
        {
            return new WorkLogic().Get(id);
        }
        [Route("add")]
        [HttpPost]
        public int Add(Work ct)
        {
            return new WorkLogic().Insert(ct);
        }

        [Route("edit")]
        [HttpPut]
        public int Edit(Work ct)
        {
            return new WorkLogic().Update(ct);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public int Delete(Guid id)
        {
            return new WorkLogic().Delete(id);
        }
    }
}