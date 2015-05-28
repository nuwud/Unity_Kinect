# KinectGettingStarted
Kinect v2 getting started guide for various environments.

#### Specifications
* RGB 1920 x 1080
* IR/Depth 512 x 424
* Recommended distance - 4 ft 6 inches.
* No motor for auto-adjust
* 4-microphone array
* 6 skeleton detection
* 25 joints each

![Screenshot](http://glitchbeam.blob.core.windows.net/media/2015/05/kinectskeleton-map2.png)


# Step 1 - Download and install the SDK
##Kinect SDK
[http://www.microsoft.com/en-us/download/details.aspx?id=44561](http://www.microsoft.com/en-us/download/details.aspx?id=44561)

Comes with the following apps:
* Kinect Studio:
  * Record and playback.  Playback can simulate a physical Kinect.
  * Use for testing hardware features.
* SDK Browser:  Has code samples for all hardware features.


# Step 2 - Select your environment
##Unity
####Requirements:
* Unity: [http://unity3d.com](http://unity3d.com)
* Kinect v2 Plugin for Unity: [http://go.microsoft.com/fwlink/?LinkID=513177](http://go.microsoft.com/fwlink/?LinkID=513177)
* Visual Studio 2013: [http://visualstudio.com](http://visualstudio.com)

####Tutorials:
* Unity/Kinect v2 - Getting Started: [http://glitchbeam.com/getting-started-kinect-v2-and-unity-on-windows/](http://glitchbeam.com/getting-started-kinect-v2-and-unity-on-windows/)
* Kinect v2 Joint Map: [http://glitchbeam.com/kinect-v2-joint-map/](http://glitchbeam.com/kinect-v2-joint-map/)
* Unity & Visual Studio 2013: [http://glitchbeam.com/using-visual-studio-2013-for-main-unity-ide/](http://glitchbeam.com/using-visual-studio-2013-for-main-unity-ide/)
* Unity Tutorials: [http://unity3d.com/learn/tutorials/modules](http://unity3d.com/learn/tutorials/modules)

####Examples (Incuded in this repo):
* Unity_KinectBasic:  This is the basic unmodified KinectView example that comes with the Kinect for Unity Plugin.  It displays:  RGB, Infrared, Depth, Body
* Unity_KFW2Examples:
  * Cursor - Left hand is mapped to a cursor.  Box color changes when cursor collides.
  * Player Controller - Left & Right hand mapped to player input.
  * Body Particles - ParticleSystems spawn and follow joint positions.


##openFrameworks
####Requirements:
* openFrameworks for Visual Studio 2012: [http://www.openframeworks.cc/versions/v0.8.4/of_v0.8.4_vs_release.zip](http://www.openframeworks.cc/versions/v0.8.4/of_v0.8.4_vs_release.zip)
* MS Visual Studio Express 2012: [http://www.microsoft.com/en-us/download/details.aspx?id=34673](http://www.microsoft.com/en-us/download/details.aspx?id=34673)
* ofxKinectForWindows2 addon: [https://github.com/elliotwoods/ofxKinectForWindows2/tree/0.8.4](https://github.com/elliotwoods/ofxKinectForWindows2/tree/0.8.4)

#####Supported:
* Grab all the image streams (color, depth, IR, long exposure IR, body index)
* Generate a 3D ofMesh (point cloud or stitched mesh) with texture coordinates
* Track bodies (skeleton points, bone maps)
* Transfer coordinates

#####Not supported:
* Audio
* Some remapping functions

####Tutorials:
* Setting up openFrameworks and VSE2012: [http://rbarraza.com/setting-up-visual-studio-2012-express-and-openframeworks-0-8-4/](http://rbarraza.com/setting-up-visual-studio-2012-express-and-openframeworks-0-8-4/)
* Setting up Kinect v2 w/ openFrameworks: [http://rbarraza.com/setting-up-kinect-2-for-openframeworks/](http://rbarraza.com/setting-up-kinect-2-for-openframeworks/)

####Examples:
* Rick Barraza's Git: [https://github.com/rickbarraza?tab=repositories](https://github.com/rickbarraza?tab=repositories)


##Processing
####Requirements:
* Processing: [https://processing.org/download/](https://processing.org/download/)

####Tutorials:
* Getting Started w/ Kinect v2: [http://channel9.msdn.com/coding4fun/kinect/Processing-for-Kinect-for-Windows-v2](http://channel9.msdn.com/coding4fun/kinect/Processing-for-Kinect-for-Windows-v2)

##Cinder
####Requirements:
* Cinder for Visual Studio 2013: [http://libcinder.org/releases/cinder_0.8.6_vc2013.zip](http://libcinder.org/releases/cinder_0.8.6_vc2013.zip)
* Visual Studio 2013: [http://visualstudio.com](http://visualstudio.com)

####Tutorials:
* Getting Started w/ Kinect v2 & Cinder: [http://channel9.msdn.com/coding4fun/kinect/Cinder-openFrameworks-Kinect-for-Windows-v2-and-getting-started](http://channel9.msdn.com/coding4fun/kinect/Cinder-openFrameworks-Kinect-for-Windows-v2-and-getting-started)
