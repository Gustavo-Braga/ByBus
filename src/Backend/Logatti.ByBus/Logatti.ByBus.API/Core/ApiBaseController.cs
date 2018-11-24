using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Logatti.ByBus.CrossCutting.Notifications;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Logatti.ByBus.API.Core
{
    [EnableCors("AllowAllHeaders")]
    [Route("api/v1/[controller]")]
    public class ApiBaseController : ControllerBase
    {
        private readonly INotificationHandler _notificationHandler;
        private readonly ILogger<ApiBaseController> _logger;
        protected IEnumerable<Notification> _notifications => _notificationHandler.GetNotifications();

        public ApiBaseController(INotificationHandler notificationHandler, ILogger<ApiBaseController> logger)
        {
            _notificationHandler = notificationHandler;
            _logger = logger;
        }
        private bool IsValidOperation()
        {
            return !_notificationHandler.HasNotifications();
        }

        protected async Task<IActionResult> CreateResponse<T>(Func<Task<T>> function)
        {
            try
            {
                _logger.LogInformation("CreateResponse invoked, {@function}", function);

                var data = await function();

                _logger.LogInformation("CreateResponse function();, {@data}", data);

                return Response(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");
                return StatusCode(500, new ApiResponse(notifications: _notifications));
            }
        }

        private new IActionResult Response(object data = null)
        {
            if (IsValidOperation())
            {
                return Ok(new ApiResponse(data: data, success: true));
            }

            return BadRequest(new ApiResponse(notifications: _notifications));
        }

        protected async Task<IActionResult> CreateResponse(Action action)
        {
            try
            {
                _logger.LogInformation("CreateResponse invoked, {@action}", action);

                action();

                return await Task.FromResult(Response());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error");

                return StatusCode(500, new ApiResponse(notifications: _notifications));
            }
        }
    }
}