[<img src="" width="50%" height="50%">](https://user-images.githubusercontent.com/34622204/164943219-412e9d6e-9192-44b2-8968-ff5006d991eb.PNG)
XeX Tool GUI
Originally by mLoaD | Open Sourced & Optimized by Serenity
Build and Tested on Windows 10/11 64-Bit with .NET Framework 4.8
About
XeX MiniGUI for xorloser's latest XeXTool. Thank you for your program and your hard work. I've created this little tool so you do not always have to edit default.xex with the command tool manually.
Features

Drag & Drop Support - Simply drag XEX/XEXP files into the interface
Progress Tracking - Real-time progress bars and detailed logging
Asynchronous Operations - Non-blocking UI that remains responsive during operations
Comprehensive XEX Operations:

Patch XEX files with XEXP updates
Create backups of original files
Convert between binary/compressed/encrypted formats
Extract detailed file information
Region and security modifications


Advanced File Operations - Copy, move, and delete with progress feedback
Error Handling - Robust error handling with detailed logging

How to Use
Reading XEX Info Files:

Select the XEX file (drag & drop or use file browser)
Click Basic or Extended from the menu
Click Read Info Log to view the generated information

Patching XEX Files:

Load your XEX file
Load your XEXP patch file
Choose output destination
Click Patch and monitor progress
Files are automatically cleaned up after successful patching

Creating Backups:

Load your XEX file
Click the Backup button
Choose backup location and filename
Monitor progress in the log window

Recent Updates
Version 2.0 - UI Optimization & Stability

Fixed UI Freezing - Resolved issues where interface would become unresponsive after operations
Enhanced Async Operations - Improved async/await implementation for better responsiveness
Progress Reporting - Added comprehensive progress tracking for all operations
Better Error Handling - Enhanced exception handling with detailed logging
Memory Management - Improved process cleanup and resource disposal
Cancellation Support - Added ability to cancel long-running operations
Visual Feedback - Enhanced progress bars and status messages

Technical Improvements

Replaced blocking Invoke() calls with non-blocking BeginInvoke()
Removed Application.DoEvents() calls that caused message loop interference
Implemented TaskCompletionSource for proper async process handling
Added comprehensive process cleanup with event handler unsubscription
Enhanced file operation methods with progress reporting
Improved drag & drop validation and error handling

System Requirements

Windows 10/11 64-bit
.NET Framework 4.8 or higher
XeXTool.exe (automatically installed if missing)

Building from Source

Clone the repository
Open in Visual Studio 2019 or later
Restore NuGet packages
Build in Release mode for optimal performance

Credits

xorloser - Original XeXTool developer
mLoaD - Original GUI implementation
Serenity - Open source optimization and enhancements

License
This project is open source. Please respect the original authors' work and contributions.
Support
For issues, feature requests, or contributions, please use the GitHub repository's issue tracker.
