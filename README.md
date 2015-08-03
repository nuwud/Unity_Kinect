# Table of Contents
- [Requirements](#requirements) - What you need.
- [Getting Started](#getting-started) - Start here if you are new to Kinect in Unity.
- [Examples Included In This Repo](#examples-included-in-this-repo) - Go here to review the examples in this repo.
- [SDK Tools](#sdk-tools) - What is installed with the Kinect SDK.
- [Additional Tutorials](#additional-tutorials) - See this if you want to expand your knowledge.
- [Support](#support) - Have questions?  Run into an issue?  Go here.

# Requirements
* [Unity](http://unity3d.com)
* [Kinect SDK](http://www.microsoft.com/en-us/download/details.aspx?id=44561)
* [Kinect v2 Plugin for Unity](http://go.microsoft.com/fwlink/?LinkID=513177)
* [Visual Studio Community](http://visualstudio.com)

# Getting Started
This section will show you the basics of setting up your environment and running the example project from the Kinect v2 Unity plugin.  If you are already familiar with this process, you can proceed to [Examples Included In This Repo](#examples-included-in-this-repo) below.

1.  Download and install the [Kinect SDK](http://www.microsoft.com/en-us/download/details.aspx?id=44561)
2.  Download and unzip the [Kinect v2 Plugin for Unity](http://go.microsoft.com/fwlink/?LinkID=513177)
3.  Create a new project in Unity 5.
![Screenshot](https://glitchbeam.blob.core.windows.net/media/2015/05/kinect00.png)

4.  Double-click the file 'Kinect.2.0.1410.19000.unitypackage'.
![Screenshot](https://glitchbeam.blob.core.windows.net/media/2015/05/kinect01.png)

5.  Import all of the items into your newly created Unity project.
![Screenshot](https://glitchbeam.blob.core.windows.net/media/2015/05/kinect02.png)

6.  Drag folder 'KinectView', located in the unzipped Kinect v2 Plugin folder, into your root Unity Asset folder.  Expand the 'KinectView' folder and launch 'MainScene'.  Press play to view RGB, IR, Joints, and Depth Mesh.
![Screenshot](https://glitchbeam.blob.core.windows.net/media/2015/05/kinect03.png)

# Examples Included In This Repo
* Cursor - A cursor is mapped to a hand joint.  Box color changes when cursor collides.
* Body Particles - ParticleSystems spawn and follow joint positions.
* Player Controller - Player horizontal input is mapped to left & right hands.  This technique is used on the following games:
  * [Hypernaut](http://glitchbeam.com/games/hypernaut/)
  * [Horizon](http://glitchbeam.com/games/horizon/)

# SDK Tools
The Kinect v2 SDK installs the following software:
* Kinect Studio
  * Record and playback.  Playback can simulate a physical Kinect.
  * Use for testing hardware features.
* SDK Browser - Has code samples for all hardware features.

# Additional Tutorials
* Kinect v2 Joint Map [http://glitchbeam.com/kinect-v2-joint-map/](http://glitchbeam.com/kinect-v2-joint-map/)
* Unity & Visual Studio [http://glitchbeam.com/using-visual-studio-2013-for-main-unity-ide/](http://glitchbeam.com/using-visual-studio-2013-for-main-unity-ide/)
* Unity Tutorials [http://unity3d.com/learn/tutorials/modules](http://unity3d.com/learn/tutorials/modules)

# Support
Please create an issue ticket for questions and issues.  Thank you.
