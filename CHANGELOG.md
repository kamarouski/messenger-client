# 0.6.0
**Changes**
* Added sender actions (mark seen, typing indicator)
* Added 'webview_share_button' setting on URL button

**Breaking Changes**

* Renamed MessengerPersistentMenuAction to MessengerPersistentMenuItem
To migrate from previous versions simply rename all instances of MessengerPersistentMenuAction to MessengerPersistentMenuItem
* Added structured enums across entire SDK surface
To migrate from previous versions replace all instances of magic strings to their respective enum values
ie:
- for MessengerAttachment, instead of setting 'Type = "template"' use 'Type = MessengerAttachmentType.Template'
- for MessengerButton, instead of setting 'Type = "web_urL"' use 'Type = MessengerButtonType.WebURL'
- etc.

# 0.5.0
**Changes**

* Messenger Platform 1.4 Persistent menu support. Use *IMessengerProfileService* to manage menu, get started button and greeting text.

# 0.4.2

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
