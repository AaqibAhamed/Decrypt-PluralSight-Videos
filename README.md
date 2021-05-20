# Decrypt PluralSight Videos
When you download offline videos through the Pluralsight app, the videos saved to the device are encrypted, and you can only watch it on their app.
This tool is made to decrypt the videos (.psv), decrypt module folder names, rearrange the course folders, overall decrypting the entire course.

Based on: https://github.com/vinhloc1996/DecryptPluralSightVideos

# Change log:
* Version 1.9.1
    + Fix Module and clip index wrong format.

# In This Version:
+ Fix video can't play with POP version 1.0.291
+ Switch to use the original file. If in the future, POP change the Encrypt Algorithm, you can replace the `Pluralsight.Domain.dll` existing in this program with the latest file from POP, and maybe it works without any fixing

# Added Feature:
+ Add GUI
+ Auto detected default Pluralsight Path
+ List all Course downloaded (except unfinished download)
+ Fix decrypt wrong Video (wrong name of video decrypted)
+ More features, you can check it :D.

# Getting Started
* This tool requires .Net Framework `4.7.2` or above.

# Installing
* Download the latest binary from [here](https://github.com/dhorseman1710/Decrypt-PluralSight-GUI/archive/refs/heads/main.zip).
* Extract the zip file, open file DecryptPluralSightVideosGUI.exe.
* Default Pluralsight Path is `C:\Users\<UserName>\AppData\Local\Pluralsight\courses`

# How to use
* Step 1: Open file `DecryptPluralSightVideosGUI.exe`.
* Step 2: Select the course path and DB file. Note: The course path always include `\courses` at the end of the path.
* Step 3: After select exactly all paths, press the `Read course` button.
* Step 4: Select the courses want to decrypt or press the `Select all` button to select all courses.
* Step 5: Choose the option you want
  - Decrypt: Decrypt the course.
  - Create sub: Create the subtitle file.
  - Delete: Delete course after decrypt.
* Step 6: After choosing the option, press `Run` and waiting for the decrypt process finish.

**Notes:**
   + Please don't remove the course from POP before decrypt. You can check the Delete checkbox to remove the course after the course decrypted.
   + You can delete all courses by select all courses, check the `Delete` checkbox only, and press `Run`.
   + Some courses don't have subtitles, so the subtitle file will not be generated.
   + You can watch video guide [here](https://youtu.be/mPytcMQY9Ck)
# Author
- Loc Nguyen.
- Hieu Phan
- sitiom

# Version
- This current version is `1.9.0.0`.

# Reference
- This tool has been made by myself but some functions about running command-line tools or style of code that I refer from [Lynda-Decryptor](https://github.com/h4ck-rOOt/Lynda-Decryptor).

# Copyright ©
- This software is freeware and open source. Please don't use it for commercial.
