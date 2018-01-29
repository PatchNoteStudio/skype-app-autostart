# Skype App Autostart
This tool add the Skype App for Windows 10 to the Startup so that Skype opens directly when you boot your pc. Unfortunately, it is not possible to open a Windows 10 App on startup. It's still possible with this little trick.

## [Download current version (v1)](https://github.com/MarcoPNS/skype-app-autostart/blob/master/Release/skype_app_autostart_v1.zip?raw=true)

## With this Tool
1. Download the current version of this tool
2. Open this tool and press "Add the Skype App to the Startup"
3. Then Press "Test it" - On the first startup maybe you will be ask which program should start as a default application. Just check the Skype Windows 10 App and mark the box so that Windows should remember your decision.

Now the Windows 10 App of Skype start directly after starting windows.

## Without this Tool
1. press Windows Button + R
2. type in "shell:startup"
3. Now the Autostart folder should be open
4. create a .cmd file.
5. add following to the .cmd file:
"start Skype:"
6. now save and test the .cmd file. On the first startup maybe you will be ask which program should start as a default application. Just check the Skype Windows 10 App and mark the box so that Windows should remember your decision.

Now the Windows 10 App of Skype start directly after starting windows.

## FAQ

#### Why did you created this tool?
The tool was needed in my office after the old Skype Desktop version did not work properly anymore. So they switch to the Windows 10 App Version but this version don't pop up on startup. The users still wanted to have Skype open at windows startup. This option is not available on the Skype app for Windows 10. The tool is for the people who do not want to deal with the cmd and just search a tool which do the work for them. If you know how to use the cmd then read the point *Without this Tool*
#### The Skype Desktop Version starts instead of the Skype Windows 10 App. How can I change it?
You need to change the default app for the "SKYPE" protocol. To get there, press Windows-I to open the Settings app on a machine running Windows 10, and go to System > Default Apps afterwards. Then go to the "choose default apps by protocol" configuration page. Search for the "SKYPE" protocol and change it to the Skype App.


## Credits

Made by Marco Sadowski. 
Check out my [Page](http://patchnotestudio.com/) or my [Twitter](https://twitter.com/MarcoSadowski)

The program icon is from [Icons8](https://icons8.com/)
