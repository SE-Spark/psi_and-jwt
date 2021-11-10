using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Authentication.BAL.Logics;
using Authentication.DAL.Entities;
using Microsoft.AspNetCore.Authorization;

namespace Authentication.Controllers
{
    [Authorize]
    [Route("api/ct")]
    [ApiController]
    public class CitizenController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Object> Get()
        {
            return new CitizenLogic().Get();
        }
        [Route("{id}")]
        [HttpGet]
        public Object GetCitizens(Guid id)
        {
            return new CitizenLogic().Get(id);
        }
        [Route("add")]
        [HttpPost]
        public int AddCitizen(Citizen ct)
        {
            return new CitizenLogic().Insert(ct);
        }

        [Route("edit/{id}")]
        [HttpPut]
        public int EditCitizen(Citizen ct)
        {
            return new CitizenLogic().Update( ct);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public int DeleteCitizen(Guid id)
        {
            return new CitizenLogic().Delete(id);
        }
    }
}