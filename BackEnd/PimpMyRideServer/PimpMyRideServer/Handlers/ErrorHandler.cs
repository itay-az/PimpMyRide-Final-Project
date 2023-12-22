using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Responses;

namespace PimpMyRideServer.Handlers
{
    public class ErrorHandler
    {
        public static ActionResult onFailure(string message, string errorCode, int statusCode = StatusCodes.Status404NotFound, string details = null, List<ValidationError> validationErrors = null)
        {
            var errorResponse = new ErrorResponse
            {
                Success = false,
                Message = message,
                StatusCode = statusCode,
                ErrorCode = errorCode,
                Details = details,
                ValidationErrors = validationErrors
            };

            JsonResult jsonResult = new JsonResult(errorResponse);
            jsonResult.StatusCode = statusCode;

            return jsonResult;
        }
    }
}
