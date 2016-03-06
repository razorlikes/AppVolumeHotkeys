##What is "AppVolumeHotkeys"?
AppVolumeHotkeys is an application that lets you control the volume of an application which is listed in Windows' volume mixer.
Its written in C# and is *a learning project* at the moment. To get access to the `ISimpleAudioVolume`, `IAudioSessionEnumerator` and `IAudioSessionControl2`, `IAudioSessionManager2`, `IMMDevice` and `IMMDeviceEnumerator` APIs I used an edited version of 
[Simon Mouriers answer](http://stackoverflow.com/a/14322736) on stackoverflow.com.
[Download latest .exe](https://github.com/razorlikes/AppVolumeHotkeys/releases/download/v1.0/AppVolumeHotkeys.exe)
##How to set it up
You will just need to enter a keyword of the window title of the application you want to control into the textbox. If the application isn't found you could try a longer part of the windows title or try to enter a more specific word in there. Also, Spotify won't work right now and to select Google Chrome you have to enter keywords from your active tab. After that you would just need to click on "Set Name".  
![Image of the new UI](http://i.imgur.com/lnmz6tz.png)  
If you don't have already, select your Hotkeys by clicking into the textbox for the hotkey you want to set and press your desired hotkey and if you want to your modificator(ctrl, alt) and after that click on "Save Hotkeys". You can always delete the set Hotkeys by clicking on "Reset Hotkeys".  
