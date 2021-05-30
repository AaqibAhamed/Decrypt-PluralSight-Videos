# DISCLAIMER
I am not the original programmer for this project. All software is provided as is. This is a fork from other users. I am only interest in understanding the coding logic.

# Latest Update
The original software is no longer working as Pluralsight has changed the encryption algo. I read the code and also dotpeek the latest version of PluralSight offline video to see what has changed. The whole different is only 1 file VideoEncryption.cs and 1 line of code in that called XorBuffer

# Software Logic
All courses related info are stored in a sqlite database (pluralsight.db). It has the following tables.
* Analytics
* Clips
* ClipTranscript
* ClipView
* Course
* CourseAccess
* CourseProgress
* Module
* Settings
* User
* UserProfile
* Version

The important files are the PsStream.cs VideoEncryption.cs and the VirtualFileCache.cs. Study those if you are interested in learning. Well at least I learnt it.

The recent change of Encryption algo is in VideoEncryption.cs

## Installing
* I have not intention of releasing binary file. Dont wanna hurt other people's intellectual property. THIS IS ONLY FOR EDUCATIONAL PURPOSE.
* For more information about flags using on this tool, execute this command in the commandline ``DecryptPluralSightVideos /HELP``.
1. Note: All the flag in this tool is ``case-insensitive``.
2. Note: Usually the Pluralsight app will put the downloaded courses in the path:
`C:\Users\<UserName>\AppData\Local\Pluralsight\courses`

## Example Execute Commands
- ```DecryptPluralSightVideos /F "C:\Users\MyUser\AppData\Local\Pluralsight\courses" /DB "C:\Users\MyUser\AppData\Local\Pluralsight\pluralsight.db" /TRANS /RM /OUT "E:\Course"```
### Explainations
- `/F [PATH]` will define the location of downloaded courses that you has been passed right behind it **(You don't need to point to any specified course, the tool will be decrypted all courses it found in your `courses path`)**.
- `/DB [PATH]` will define the location of the database file, it will locate at Pluralsight folder.
- `/TRANS` will create a subtitles file (.srt) of each videos **(Some course will not have the subtitiles)**.
- `/RM` will remove the course in the database file. After course is delete in database file, open the Pluralsight app and the the courses folder will be deleted automatic.
- `/OUT [PATH]` will define the path that you want to put the decrypted courses. **If you don't use this flag, the decrypted courses will be placed in the same location with encrypted courses.**

## Troubleshooting
1. In case you experience a "Path too long" exception, try to use an UNC path for export. You can share your local hard drive and connect to it using an UNC path. This way, Windows will use its Unicode API and in turn support path lengths with to 32k characters.
- For example, if your export folder is ```C:\Export```, share the drive with share name ```C``` and use the following export path instead: ```\\localhost\C\Export```.

