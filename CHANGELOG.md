


**Breaking Changes**

* *MessengerPayload* class was refactored and made abstract. You are no longer able to create its instance. Use specific classes for payloads instead like *MessengerButtonsPayload*, *MessengerListPayload* etc
* *MessengerThreadSettings* class was refactored and made abstract. Now you need to use specific classes for settings like *MessengerGettingStartedSetting*, *MessegerPersistentMenuSetting* etc

**Changes**

* Now you can easily whitelist domains via *IMessengerThreadSettingsService*
* Receipt element structure has been fixed

# 0.3.0

**Changes**
* Moved to .NET Standard Library 1.6
* Updated project structure to VS2017 (just because I can)
* Web Views
* List Templates

# 0.2.5

**Changes**

* Added support for messenger thread settings update via *IMessengerThreadSettingsService*. It allows updating stuff like Persistent Menu or Welcome screen for messenger chatbots.