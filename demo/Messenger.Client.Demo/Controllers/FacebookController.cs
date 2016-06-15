using System.Linq;
using System.Threading.Tasks;
using Messenger.Client.Objects;
using Messenger.Client.Services;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Client.Demo.Controllers
{
    [Route("api/webhook")]
    public class FacebookController : Controller
    {
        private readonly IMesengerMessageSender messageSender;

        public FacebookController(IMesengerMessageSender messageSender)
        {
            this.messageSender = messageSender;
        }

        [HttpGet, Produces("text/html")]
        public IActionResult Validate()
        {
            var challenge = Request.Query["hub.challenge"];


            if (challenge.Any())
            {
                return Ok(challenge.First());
            }

            return Ok();
        }

        // Sends echo message back to sender.
        [HttpPost]
        public async Task HandleMessage([FromBody] MessengerObject obj)
        {
            foreach (var entry in obj.Entries)
            {
                await HandleEntry(entry);
            }
        }

        private Task HandleEntry(MessengerEntry entry)
        {
            var messaging = entry.Messaging.First();
            var text = messaging.Message.Text;
            var response = new MessengerMessage {Text = text};
            return messageSender.SendAsync(response, messaging.Sender);
        }
    }
}
