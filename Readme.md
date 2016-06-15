# Facebook Messenger .NET Client

A .NET Core client for Facebook Messenger platform.

### Installation

``````
Install-Package Messenger.Client
``````

To use ASP.NET Core extensions use *Messenger.Client.Extensions* package.

``````
Install-Package Messenger.Client.Extensions
``````



### Documentation

#### Configuration

To register the client add the following line in your Startup.cs file

``````c#
public class Startup {
	public void ConfigureServices(IServiceCollection services)
    {
    	...
        services.AddMessengerClient("%ACCESS_TOKEN%");
    }
}
``````



#### IMessengerMessageSender

*IMessengerMessageSender* allows you to send a message to specific Messenger user.

```c#
[Route("api/webhook")]
public class FacebookController() {
	private readonly IMessengerMessageSender messageSender;
  
    public FacebookController(IMessengerMessageSender messageSender) {
      this.messageSender = messageSender;
    }

    ...

    private Task SendMessage(String text, MessengerUser recipient)
    {
      var reply = new MessengerMessage {Text = text};
      return messageSender.SendAsync(reply, recipient);
    }
    ...
}
```



