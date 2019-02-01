# Toja Discord Bot
  * Discord Bot written in C# using Discord.NET library

## Features

  * Automatic role assigment on join
  * Annoucments in desired text channel when someone joins and leaves
  
## Installation

  * Installation: Download the source code and you will need to modify following lines:
  ### on line 41 replace <1234> with your BOT token ID
  ```csharp
  string Token = "1234"; //Edit This <Bot Token ID>
  ```
  
  ### on line 51 and 63 replace <1234> with Channel ID where you want bot to announce stuff
  ```csharp
  var channel = Client.GetChannel(1234) as SocketTextChannel; //Edit this! <Channel ID>
  ```
  
  ### on line 73 replace <1234> with Role ID for Member role
  ```csharp
  ulong roleID = 1234; //Edit This! <Member role ID>
  ```
  
  * Requirements: .NET 4.5 framework or higher.
  
## TO-DO
  
  * None.
