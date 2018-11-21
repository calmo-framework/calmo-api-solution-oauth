
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Http.Results;

namespace $safeprojectname$.Controllers
{
    /// <inheritdoc />
    public class BaseController : ApiController
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public ResponseMessageResult NoContent()
        {
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.NoContent));
        }
    }
}