Weidmuller Security Declaration Form.

• Microsoft Excel 2013 or later is required for this application to create PDF files.

• The "Data" folder is required to be in the same folder as the executable, ensure that this folder is available!

• To add new user accounts to the application, select “Configuration” from the menu strip.

• The Configuration tool requires you to provide your Windows login credentials for access (the password for the computer you are using the application on).

• Once you have set up user accounts and associated signatures with them you can login by selecting “Login”.

• Be sure to set the “Save Directory Root” folder in the configuration. At the time of writing this should be on the global server in “Australia\Common Files\Warehouse\Security Declarations”. This is where the directory structure for saved files will be built. The file will be saved in the form: "Security Declaration [Domestic or International]" -> "[Current Year]" -> "[Current Month]" -> "SD[D or I]_[DDMMYY]_[First Consignment Number in Listbox]". So as an example, for a Domestic consignment, number 8775023090020 issued on the 13th of December 2020 the file would be saved as "I:\Australia\Common Files\Warehouse\Security Declarations\Security Declaration Domestic\2020\December\SDD_131220_8775023090020.pdf". If this location is not changed then the save file directory structure will be built in the desktop folder.

• If no user is logged in the form will be printed without a signature and whatever name is entered into the "Issued by:" text field.

• If a user is logged in, attempting to create a new consignment will ask for the current users password.

• Yes, you WILL need to provide a password each and every time you go to create a consignment with a logged in user, this is essential for security because the logged in users signature will be added to the document.

• Unfortunately the image tool in Excel doesn't play nicely with .png files without a heap of Win32-API wrangling so I have just used .jpg format images. When creating a new signature image it should be 600x200 pixels.

• I do NOT have access to any passwords in a plain text format, only as the result of running a SHA-512(secure hashing algorithm) on the concatenation of the password and a 128-bit randomly generated salt. Because SHA-512 is a “one-way function”, with current computing power this is pretty much impossible to reverse, so fear not, nobody will have access to your passwords if you are worried that using a password that you use elsewhere may be compromised (not that I encourage using the same password in multiple places, but hey I know people do). 


All design and implementation by Miles Williams - 2020.