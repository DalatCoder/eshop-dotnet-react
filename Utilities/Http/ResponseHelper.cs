using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShopSolutionReact.ViewModels.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolutionReact.Utilities.Http
{
    public class ResponseHelper
    {
        public static Response GetOkStructure(object data)
        {
            return new Response()
            {
                Status = "success",
                Message = "",
                Data = data
            };
        }

        public static Response GetOkStructure(object data, string message)
        {
            return new Response()
            {
                Status = "success",
                Message = message,
                Data = data
            };
        }

        public static Response GetFailStructure(object data, string message)
        {
            return new Response()
            {
                Status = "fail",
                Message = message,
                Data = null
            };
        }

        public static Response GetErrorStructure(object data, string message = "internal error")
        {
            return new Response()
            {
                Status = "error",
                Message = message,
                Data = null
            };
        }
    }
}
