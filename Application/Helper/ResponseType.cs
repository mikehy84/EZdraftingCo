using Domain.Entities;
using System.Net;

namespace Application.Helper
{
    public class ResponseType
    {
        public ApiResponse HandleException(Exception ex)
        {
            var apiResponse = new ApiResponse()
            {
                StatusCode = HttpStatusCode.InternalServerError,
                IsSuccess = false,
                ErrorMessages = new List<string> { ValidationMessage.An_Unexpected_Error_Occurred, ex.Message }
            };

            return apiResponse;
        }


        public ApiResponse NotFound(string message)
        {
            var apiResponse = new ApiResponse()
            {
                StatusCode = HttpStatusCode.NotFound,
                IsSuccess = true,
                ErrorMessages = new List<string> { message }
            };
            return apiResponse;
        }


        public ApiResponse BadRequest(string message)
        {
            var apiResponse = new ApiResponse()
            {
                StatusCode = HttpStatusCode.BadRequest,
                IsSuccess = false,
                ErrorMessages = new List<string> { message }
            };
            return apiResponse;
        }


        public ApiResponse Ok<T>(T Args)
        {
            var apiResponse = new ApiResponse()
            {
                StatusCode = HttpStatusCode.OK,
                IsSuccess = true,
                Result = Args
            };
            return apiResponse;
        }


        public ApiResponse Created(Project car)
        {
            var apiResponse = new ApiResponse()
            {
                StatusCode = HttpStatusCode.Created,
                IsSuccess = true,
                Result = car,
                CreatedId = car.Id
            };
            return apiResponse;
        }
    }
}
