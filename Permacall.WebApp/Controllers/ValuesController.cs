using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Permacall.Application.Accounts.Commands.UpdateAccount;
using Permacall.Application.Accounts.Queries.GetAccount;

namespace Permacall.WebApp.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : BaseController
    {
        // GET api/values
        [HttpGet()]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetAccountViewModel>> Get(int id)
        {
            return Ok(await Mediator.Send(new GetAccountQuery() { AccountId = id }));
        }


        [HttpPost]
        public async Task<ActionResult<string>> UpdateAccount([FromBody] UpdateAccountCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
