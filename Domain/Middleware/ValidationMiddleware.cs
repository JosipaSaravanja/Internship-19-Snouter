using Contracts.Response;
using Contracts.Responses;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace Domain.Middleware;
 
public class ValidationMiddleware
{
    private readonly RequestDelegate _next;
 
    public ValidationMiddleware(RequestDelegate next)
    {
        _next = next;
    }
 
    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (ValidationException ex)
        {
            httpContext.Response.StatusCode = 400;
            var validationFailureResponse = new ValidationFailureResponse
            {
                Errors = ex.Errors.Select(x => new ValidationResponse
                {
                    PropertyName = x.PropertyName,
                    Message = x.ErrorMessage,
                })
            };
 
            await httpContext.Response.WriteAsJsonAsync(validationFailureResponse);
        }
    }
}