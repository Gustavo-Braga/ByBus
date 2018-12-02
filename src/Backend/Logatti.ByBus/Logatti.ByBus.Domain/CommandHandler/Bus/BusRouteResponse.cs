using System;
using System.Collections.Generic;
using System.Text;

namespace Logatti.ByBus.Domain.CommandHandler.Bus
{
    public class BusRouteResponse
    {
        public BusRouteResponse()
        {
            Mock0 = "deu success";
            Mock1 = "deu success";
            Mock2 = "deu success";
            Mock3 = "deu success";
            Mock4 = "deu success";
            Mock5 = "deu success";
        }

        public string Mock0 { get; set; }
        public string Mock1{ get; set; }
        public string Mock2 { get; set; }
        public string Mock3 { get; set; }
        public string Mock4 { get; set; }
        public string Mock5 { get; set; }

    }
}
