using System;
using System.Collections.Generic;
using Authentication.BAL.Logics;
using Authentication.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Authentication.Controllers
{
    [Route("api/cr")]
    [ApiController]
    public class CriminalController : ControllerBase
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
            return new CitizenLogic().Update(ct);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public int DeleteCitizen(Guid id)
        {
            return new CitizenLogic().Delete(id);
        }
    }
}