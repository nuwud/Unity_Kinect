# Kinect_Unity
Introduction to Kinect v2 in Unity

#### Specifications
* RGB 1920 x 1080
* IR/Depth 512 x 424
* Recommended distance - 4 ft 6 inches.
* No motor for auto-adjust
* 4-microphone array
* 6 skeleton detection
* 25 joints each

![Screenshot](http://glitchbeam.blob.core.windows.net/media/2015/05/kinectskeleton-map2.png)

# Download and install the SDK
* Kinect SDK [http://www.microsoft.com/en-us/download/details.aspx?id=44561](http://www.microsoft.com/en-us/download/details.aspx?id=44561)

Installs the following
* Kinect Studio:
  * Record and playback.  Playback can simulate a physical Kinect.
  * Use for testing hardware features.
* SDK Browser:  Has code samples for all hardware features.

# Unity
##Requirements
* Unity [http://unity3d.com](http://unity3d.com)
* Kinect v2 Plugin for Unity [http://go.microsoft.com/fwlink/?LinkID=513177](http://go.microsoft.com/fwlink/?LinkID=513177)
* Visual Studio 2013 [http://visualstudio.com](http://visualstudio.com)

###Tutorials
* Unity/Kinect v2 - Getting Started [http://glitchbeam.com/getting-started-kinect-v2-and-unity-on-windows/](http://glitchbeam.com/getting-started-kinect-v2-and-unity-on-windows/)
* Kinect v2 Joint Map [http://glitchbeam.com/kinect-v2-joint-map/](http://glitchbeam.com/kinect-v2-joint-map/)
* Unity & Visual Studio 2013 [http://glitchbeam.com/using-visual-studio-2013-for-main-unity-ide/](http://glitchbeam.com/using-visual-studio-2013-for-main-unity-ide/)
* Unity Tutorials [http://unity3d.com/learn/tutorials/modules](http://unity3d.com/learn/tutorials/modules)

###Examples
* Cursor - Left hand is mapped to a cursor.  Box color changes when cursor collides.
* Player Controller - Left & Right hand mapped to player input.
* Body Particles - ParticleSystems spawn and follow joint positions.
