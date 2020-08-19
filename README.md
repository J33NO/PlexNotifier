"# plex-notifier-windows-app" 

A small app that will allow server admins to send sms notifications to their Plex users informing them of new movies, maintenance, etc.

This is setup to use a small localdb database to store the user information and also requires a Twilio account which costs $1.00/month.
Use this link to setup Twilio phone account: https://www.twilio.com/messaging
This instructional video will give you additional information on how Twilio works and how to setup an account: https://www.youtube.com/watch?v=344S512CoP0 (Not my video)

Instructions:
-Setup Sql Server LocalDb
-Add connection string to App.Config
-Setup Twilio account
-Add phone number, account sid, and auth token to App.Config