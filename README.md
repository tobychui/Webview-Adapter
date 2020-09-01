# Webview Adapter
Author: tobychui

Webview Adapter is a quick adapter for building GUI for your application on Windows devices
using other programming lanuages that do not natively support GUI but Web UI.
(In my case I design this to work with Golang)

It simply a .NET framework WebView element that is programmable with start paramters.

## Requirement
- .NET Framework 4.7 or above
- Windows 7 or above

## Usage

### Basic Usage
Start the GUI to a given URL
```
WebviewAdapter.exe url="http://localhost:8080"
```

### Custom Size, Icon and Title

```
WebviewAdapter.exe title="My App" width=500 height=300 icon="icon.ico"
```

### Other Supported Launch Paramters
The following are key and examples for staring paramters

|Parameter Key   |Example value| Usage| 
|----------------|-------------|------|
|title|My App|The title of the window|
|width|500|The window width|
|height|300|The window height|
|allow-resize|true|Allow window resizing|
|icon|icon.ico|The icon for the window|
|url|http://localhost:8080|URL to be displaying in Webview|
|allow-max|true|Allow window maximization|
|allow-min|true|Allow window minimization|
|allow-scroll|false|Allow scrolling in webview|
|opacity|0.5|Window opacity|
|allow-taskbar|true|Show in taskbar when window is minimized|
|top-most|true|Windows always stays at top layer|
|show-icon|true|Show window's icon|
|start-location|500,300|Window startup position on screen|

### Example Command
Although I have no idea why you will need this configuration, it will show something like this if you are launching it with other exec process call
```
WebviewAdapter.exe title="IMUS Webview Adapter" width=500 height=300 icon=icon.ico url=http://bing.com allow-max=false allow-min=false allow-resize=false start-location=0,0 opacity=0.4
```