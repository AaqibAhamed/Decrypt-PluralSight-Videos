# Decrypt PluralSight Videos[![Build Status](https://travis-ci.org/vinhloc1996/DecryptPluralSightVideos.svg?branch=master)](https://travis-ci.org/vinhloc1996/DecryptPluralSightVideos)
When you donwload a video to watch offline through plural sight app, the video was encrypted and can only be watched by their app. This tool has been made to decrypt the videos, it will decrypt the video, rearrange the course folder name, decrypt module folder name, and for all, decrypt video of plural sight (.psv).

# Getting Started
This tool requires .Net Framework `4.5.2` or above.

## Installing
* Download the latest binary from [here](https://github.com/vinhloc1996/DecryptPluralSightVideos/releases/download/1.0.0.0/DecryptPluralSightVideos_v1.0.zip).
* Extract the zip file, open commandline and navigate to extracted folder containing DecryptPluralSightVideos.exe.
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

# Author
- Loc Nguyen.

# Version
- This current version is `1.1.0.0`.

# Refference
- This tool has been made by myself but some functions about running commandline tools or style of code that I refer from [Lynda-Decryptor](https://github.com/h4ck-rOOt/Lynda-Decryptor).
