using Microsoft.AspNet.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MessageListenerNetClient.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HubConnection signalRConnection = new HubConnection("http://localhost:35387/");
           
            IHubProxy hubProxy = signalRConnection.CreateHubProxy("BroadCastHub");
            signalRConnection.Start();
            hubProxy.On<string>("bastCat", (message) =>
            {
                string dd = message;
               
            });

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
