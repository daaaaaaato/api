using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pensions.Data;
using Pensions.RequestViewModels.Internal;
using Pensions.ResponseViewModels.Internal;

namespace Pensions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IRepository _repository;

        public UserController(IRepository repository)
        {
            _repository = repository;
        }

        #region TEST METHOD
        [HttpGet]
        [Route("get-user-info")]
        public ResponseModel<GetUserInfoResponseModel> GetUserInfo([FromQuery] GetUserInfoRequestModel request)
        {
            var user = _repository.GetUserById(request.Id);

            if (user == null)
            {
                return ResponseManager<GetUserInfoResponseModel>.CreateResponse(400, new string[] { "user not found" }, null);
            }

            var response = new GetUserInfoResponseModel();

            response.Name = user;



            var financialService = new FinancialService();

            response.Savings = financialService.GetPensionSavingsForUser(request.Id);

            response.Id = request.Id;

            return ResponseManager<GetUserInfoResponseModel>.CreateResponse(200, null, response);
        }
        #endregion


        [Route("test-method")]
        public IActionResult TestMethod(int? id)
        {
            if (!id.HasValue)
                return BadRequest();

            var user = _repository.GetUserById(id.Value);
            
            if (user == null)
            {
                return BadRequest();
            }


            return Ok();
        }
    }
}