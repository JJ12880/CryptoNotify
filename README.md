CryptoNotify
============

###ABOUT###



CryptoNotify is a desktop application that alerts the user to a completed filled order on the Bittrex Exchange.

###LATEST VERSION###


The current version is v0.9-beta 3

Binaries can be found here https://github.com/JJ12880/CryptoNotify/releases
Sources can be found here  https://github.com/JJ12880/CryptoNotify



###INSTALLATION###


No installation necessary. CryptoNotify was designed to run from a single .exe file for speed and ease of use. 
CryptoNotify.exe will generate all the resources it needs at runtime. 




###REQUIREMENTS###


CryptoNotify works by monitoring your account using the private API provided by Bittrex. In order to do this, the 
program will need a set of working read-only API keys. API keys are specified in the settings menu. To get or  
generate a set of API keys, go to "Settings" and then "API Keys" in the upper right hand corner of the Bittrex Website. 
Turn off all options other than "Read Info". CryptoNotify does not send your API keys anywhere or transmit them
in any fashion. Without a working set of API keys, CryptoNotify will not function. 


###FEATURES NEW IN BETA 3

+ New interface and settings layout. 
+ Now able to send alerts by email (requires SMTP configuration)
+ Support for sending alerts from email to SMS
+ Popup window now contains link to bittrex
+ Moved news section to main user interface
+ Ability to set refresh interval. 
+ Improved data validation for settings
+ Bug Fixes
	+ Fixed bug where alert was generated every time program started if a partially filled order was present





###EXISTING FEATURES ###


Fully configurable notification options allow you to be alerted via:


+ Popup window on the desktop
+ System tray message
+ Sound alert
+ Simple user interface with connection status information
+ Minimizes to the system tray so you can set and forget. 
+ Alerts generated for partial trades.

  
You can select one, two, or all options in any combination that suits your needs. 



###CONTACT###
JJ12880
cryptonotify@gmail.com

CoinBlab http://coinblab.com/profile/JJ12880

Or send a message through GitHub


###Acknowledgements###

Many Thanks to Ganastor for early beta testing, ideas, and bug hunting

###History###


#####v0.9-beta.3

- Now able to send alerts by email 
- Support for sending alerts from email to SMS
- added to Bittrex in pop-up window
- Moved news section to main user interface
- Ability to set refresh interval. 
- Improved data validation for settings
- Added tabs to settings page
- Interface redesign
- Code restructure to make it easier to add future features
- added alerts for available updates
- Various Bug Fixes
- removed BYC donation address

#####v0.9-beta.2.2

-Added support for partially completed trades
-Added ByteCent donation address
-Fixed bug where news window would hang 
-Re-sized a few message windows.
-reorganized code

#####v0.9-beta.2.1

-First Public release