# XeX Tool GUI

**Originally by mLoaD | Open Sourced & Optimized by Serenity**  
*Build and Tested on Windows 10/11 64-Bit with .NET Framework 4.8*

---

## About

XeX MiniGUI for xorloser's latest XeXTool.  
Thank you for your program and your hard work. I've created this little tool so you do not always have to edit `default.xex` with the command tool manually.

---

## Features

- **Drag & Drop Support** – Simply drag XEX/XEXP files into the interface
- **Progress Tracking** – Real-time progress bars and detailed logging
- **Asynchronous Operations** – Non-blocking UI that remains responsive during operations
- **Comprehensive XEX Operations:**
  - Patch XEX files with XEXP updates
  - Create backups of original files
  - Convert between binary/compressed/encrypted formats
  - Extract detailed file information
  - Region and security modifications
- **Advanced File Operations** – Copy, move, and delete with progress feedback
- **Error Handling** – Robust error handling with detailed logging

---

## How to Use

### Reading XEX Info Files:
1. Select the XEX file (drag & drop or use the file browser)
2. Click **Basic** or **Extended** from the menu
3. Click **Read Info Log** to view the generated information

### Patching XEX Files:
1. Load your XEX file
2. Load your XEXP patch file
3. Choose output destination
4. Click **Patch** and monitor progress
5. Files are automatically cleaned up after successful patching

### Creating Backups:
1. Load your XEX file
2. Click the **Backup** button
3. Choose backup location and filename
4. Monitor progress in the log window

---

## Recent Updates

### Version 2.0 – UI Optimization & Stability
- **Fixed UI Freezing** – Resolved issues where the interface would become unresponsive after operations
- **Enhanced Async Operations** – Improved async/await implementation for better responsiveness
- **Progress Reporting** – Added comprehensive progress tracking for all operations
- **Better Error Handling** – Enhanced exception handling with detailed logging
- **Memory Management** – Improved process cleanup and resource disposal
- **Cancellation Support** – Added ability to cancel long-running operations
- **Visual Feedback** – Enhanced progress bars and status messages

### Technical Improvements
- Replaced blocking `Invoke()` calls with non-blocking `BeginInvoke()`
- Removed `Application.DoEvents()` calls that caused message loop interference
- Implemented `TaskCompletionSource` for proper async process handling
- Added comprehensive process cleanup with event handler unsubscription
- Enhanced file operation methods with progress reporting
- Improved drag & drop validation and error handling

---

## System Requirements
- Windows 10/11 64-bit
- .NET Framework 4.8 or higher
- XeXTool.exe (automatically installed if missing)

---

## Building from Source
1. Clone the repository
2. Open in Visual Studio 2019 or later
3. Restore NuGet packages
4. Build in Release mode for optimal performance

---

## Credits
- **xorloser** – Original XeXTool developer
- **mLoaD** – Original GUI implementation
- **Serenity** – Open source optimization and enhancements

---

## License
This project is open source. Please respect the original authors' work and contributions.

---

## Support
For issues, feature requests, or contributions, please use the GitHub repository's issue tracker.
