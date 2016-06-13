namespace Messenger.Client.Objects
{
    public class MessengerMessaging
    {
        public MessangerUser Sender { get; set; }

        public MessangerUser Recepient { get; set; }

        public long Timestamp { get; set; }

        public MessengerOptin Optin { get; set; }

        public MessengerMessage Message { get; set; }

        public MessengerDelivery Delivery { get; set; }

        public MessengerPostback Postback { get; set; }
    }
}
