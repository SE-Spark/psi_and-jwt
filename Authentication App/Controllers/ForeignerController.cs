using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Authentication.BAL.Logics;
using Authentication.DAL.Entities;

namespace Authentication.Controllers
{
    [Route("api/fr")]
    [ApiController]
    public class ForeignerController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Object> Get()
        {
            return new ForeignerLogic().Get();
        }
        [Route("{id}")]
        [HttpGet]
        public Object Get(Guid id)
        {
            return new ForeignerLogic().Get(id);
        }
        [Route("add")]
        [HttpPost]
        public int Add(Foreigner ct)
        {
            return new ForeignerLogic().Insert(ct);
        }

        [Route("edit/{id}")]
        [HttpPut]
        public int Edit(Foreigner ct)
        {
            return new ForeignerLogic().Update(ct);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public int Delete(Guid id)
        {
            return new ForeignerLogic().Delete(id);
        }
    }
}