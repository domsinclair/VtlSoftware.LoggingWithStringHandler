This is a solution designed to test out string handeler and Metalama logging.

The purpose behind this is to find an acceptable  way to utilise Microsoft.Extensions.Logging, injecting it via DI and producing an aspect that can then, in use, be made available to both text based and structured logging frameworks.

This takes as a starting point information gleaned from the following blog posts.

[Structured Logging and Interpolated Strings in C# 10](https://habr.com/en/articles/591171/)

[Improving logging performance with source generators](https://andrewlock.net/exploring-dotnet-6-part-8-improving-logging-performance-with-source-generators/)

[Writing a custom string interpolation handler](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/interpolated-string-handler)


It looks highly likely that any class library built to use this will need to target .Net 6 and not .net Standard 2.0
