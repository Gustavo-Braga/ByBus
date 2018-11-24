using Logatti.ByBus.CrossCutting.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logatti.ByBus.API.Core
{
    public class ApiResponse
    {
        public ApiResponse(object data = null, IEnumerable<Notification> notifications = null, bool success = false)
        {
            this.Data = data;
            this.Success = success;
            this.Notifications = notifications;
        }

        public bool Success { get; }
        public object Data { get; }

        public IEnumerable<Notification> Notifications { get; set; }
    }
}
