using Microsoft.AspNetCore.Mvc;
using PimpMyRideServer.Server.Responses;

namespace PimpMyRideServer.Handlers
{
    // a class that was build for error handling within the handlers for the http requests
    public class ErrorHandler
    {
        // a static function that recives 2 neccesary parameters and other optional parameters for error handling
        // string message - what message will be in the frontend
        // string error code - message header that will be shown in the frontend
        // int status code that is initialized to 404 (not found), the reason behind this is that most errors occured based on not found errors
        // string details - initialized to null, for extension purposes if decided moving forward,
        // list of validation error if give
        // the function builds a json object with all the neccesary information for giving an error for the frontend to use
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
