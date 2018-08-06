# WPFInterop
Here we will illustrate how `WPF` interacts with `other frameworks`, that is, hosting WPF content in programs of other framework (e.g., WinForms, Win32, and MFC), or hosting the content of other framework in WPF programs.


## Projects
This solution consists of several projects, some of which are dynamic link libraries (DLL) and others are executable programs (EXE). Usually, the DLL is built with a `Control`, which can be hosted in other EXEs.  

The whole solution is based on `Visual Studio 2017`, equipped with projects of `Visual C#` and `Visual C++`.

### WpfControl  
`WPF User Control Library (.NET Framework)` project based on C#. It's built with a `UserControl` which will be hosted in other programs.

### WinFormControl  
`Windows Forms Control Library (.NET Framework)` project based on C#. A `Windows Forms UserControl` wrapped `WPF User Control` is built as an `COM/AxtiveX`. This project has demostrated how to indirectly build `WPF Control` as `DirectX` component, which can be widely used by programs of other framework.

### Win32App_CLR  
`Windows Desktop Application (Win32)` project based on C++/CLI, hosting WPF Control in Win32 Application within mamaged C++ (C++/CLR).

### MFCAPP  
`MFC Application` based on C++, hosting WPF control in MFC only with unmanaged c++, without C++/CLR.


## References
- https://docs.microsoft.com/en-us/dotnet/framework/wpf/advanced/walkthrough-hosting-wpf-content-in-win32
- https://stackoverflow.com/questions/2186829/is-it-possible-to-package-wpf-window-as-com-object
- https://www.codeproject.com/Articles/12673/Calling-Managed-NET-C-COM-Objects-from-Unmanaged-C
- https://www.codeproject.com/Articles/1256/Exposing-Windows-Forms-Controls-as-ActiveX-control
- https://www.telerik.com/support/kb/winforms/details/wrapping-a-net-user-control-as-an-activex
