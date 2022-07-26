# [GeckoFX] Intercept & Capture

Shows how to Intercept request(s), capture response(s), customize GeckoPreferences, handle certificate errors, change useragent++.

GeckoFX is a Firefox browser control which you can use in a Windows Forms and WPF project.

# Example:

![Alt text](/capture.png?raw=true "Example")

# Instructions:

Installing Geckofx/GeckoWebBrowser in your project

1. Install nuget-package: Geckofx60.64
2. Set solution platform to "AnyCPU" and uncheck "Prefer 32-bit" in the project properties (Properties -> Build).
3. Build Project, a Firefox64 folder should appear in the debug folder
4. Reference the directory path: Xpcom.Initialize(Environment.CurrentDirectory + "\\Firefox64");

Request Interception happens in MainForm.cs -> GeckoOnObserveHttpModifyRequest event.

Response capture happens in HttpObserver.cs -> Observe

Please see the example project. Submit issue if you need help.

# Requirements

- Visual Studio 2017+
- .NET Framework 4+
- Geckofx60.64 (NuGet Package)

# Credits:

To "hindlemail" for his NuGet package Geckofx60.64 (https://hg.sr.ht/~hindlemail/geckofx)
