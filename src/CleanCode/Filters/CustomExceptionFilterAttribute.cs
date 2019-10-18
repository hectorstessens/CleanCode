using System;
using System.Net;
using CleanCode.Crosscutting.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CleanCode.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {

            var code = HttpStatusCode.InternalServerError;
            IActionResult result = new JsonResult(context.Exception.Message);       

             if (context.Exception is QuoteException 
                || context.Exception is NotSupportedException
                 || context.Exception is ValidationException)
            {
                code = HttpStatusCode.BadRequest;
            }

            context.HttpContext.Response.ContentType = "application/json";
            context.HttpContext.Response.StatusCode = (int)code;
            context.Result = result;
        }
    }

}
