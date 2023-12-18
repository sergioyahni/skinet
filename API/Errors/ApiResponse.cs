using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            string res = null;
            switch(statusCode)
            {
                case 400:
                res = "Bad request.";
                break;
                case 401:
                res = "Not Authorized";
                break;
                case 404:
                res = "Not Found.";
                break;
                case 500:
                res = "Server Error";
                break;
                default:
                res = "Undefined Error.";
                break;
            }
            
            return res;
        }
    }
}