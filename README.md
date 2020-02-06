# NutStash

**Why the name?**
Originally the name was "Apple Addon". The name was given because the flag for the start of the embedded file was arbitrarily just "Apple!". But after several people were like, "Apple? What does this have to do with Apple products?" I decided to take a different friend's advice and just follow the nomenclature of all my "Net" tools and name it "Nut"-something. He continued, though there is no networking going on behind the scenes, he thought that it just fits in and squirrels hide away nuts in plain sight, very similar to what this program does. "NutStash" it is.

# How-to:

**Download the program:**
Get it from the <a href="https://github.com/DranKof/NutStash/releases">releases</a> section above.

**Attach a Secret Message:**
1) Select and drag an image and a text file onto the .exe file
2) Click the left plus for unencrypted or right plus for very rudimentary encryption (bytewise ROT13)
3) The original files are not modified, the output should appear in the same location as the original with the extension ".out" so you will have to rename it back to whatever file type it was if you want to view it

**Detach a Secret Message:**
1) Drag the image onto the .exe file and assuming it has an encrypted or unencrypted message
2) One of the two minus buttons should work (it will tell you if it can't find the start of the secret message and if both fail...the image probably just doesn't have a secret message in it and you chose the wrong file)
3) The output should appear as a new text file (output.txt) in the same location as the dragged-secret-message-holding image

# Does it work with other file types?

Sure, just trick it by giving it the appended file a name that ends in something like ".jpg", ".png", ".gif" or whatever.
As for the appended file, you can just rename your hidden exe or whatever into a ".txt" file.

So yeah, even with this rudimentary demo, you could easily hide your super duper secret files inside of other files. Just...don't actually do that becacuse...

# Should I actually use this to hide my secrets?

It's designed to be a hyper-simplistic demo and as such the encryption sucks and there's a greater than 1 in 281,474,976,710,656 chance that you'll lose your file due to the weak uniqueness of the start flag (the hidden message start flag may occur naturally in a file due to planets in the cosmos lining up). Though if that DOES happen, you just have to run the extracted file through the program again, so it's not that dangerous. Just...don't actually use it for that purpose until this gets some more updates.

# Will new versions of the program work on files that have hidden messages that were hidden with older versions of this program?

Unencrypted files? Probably. Encrypted files? Probably not.
