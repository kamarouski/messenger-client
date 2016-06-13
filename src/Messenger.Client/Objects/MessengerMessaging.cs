namespace Messenger.Client.Objects
{
    public class MessengerMessaging
    {
        public MessengerUser Sender { get; set; }

        public MessengerUser Recepient { get; set; }

        public long Timestamp { get; set; }

        public MessengerOptin Optin { get; set; }

        public MessengerMessage Message { get; set; }

        public MessengerDelivery Delivery { get; set; }

        public MessengerPostback Postback { get; set; }
    }
}
