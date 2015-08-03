# Unity_Kinect
The purpose of this repo is to provide a few examples of Unity + Kinect to help you get up and running quickly.

# Kinect SDK
### Download
[http://www.microsoft.com/en-us/download/details.aspx?id=44561](http://www.microsoft.com/en-us/download/details.aspx?id=44561)

### Installs the following
* Kinect Studio
  * Record and playback.  Playback can simulate a physical Kinect.
  * Use for testing hardware features.
* SDK Browser - Has code samples for all hardware features.

# Unity
### Requirements
* Unity [http://unity3d.com](http://unity3d.com)
* Kinect v2 Plugin for Unity [http://go.microsoft.com/fwlink/?LinkID=513177](http://go.microsoft.com/fwlink/?LinkID=513177)
* Visual Studio 2013 [http://visualstudio.com](http://visualstudio.com)

### Getting Started
1.  Install the Kinect SDK.
2.  Create a new project in Unity 5.
![Screenshot](https://glitchbeam.blob.core.windows.net/media/2015/05/kinect00.png)

3.  Drag folders KinectView and GreenScreen into your root Unity Asset folder.
4.  Double-click the file Kinect.2.0.1410.19000.unitypackage.
![Screenshot](https://glitchbeam.blob.core.windows.net/media/2015/05/kinect01.png)

5.  Import all of the items from the Kinect package.
![Screenshot](https://glitchbeam.blob.core.windows.net/media/2015/05/kinect02.png)

6.  Expand the KinectView folder and launch MainScene.
7.  Press play to view [RGB Cam, IR Cam, Skeletal, and Depth Map].
![Screenshot](https://glitchbeam.blob.core.windows.net/media/2015/05/kinect03.png)


### Additional Tutorials
* Kinect v2 Joint Map [http://glitchbeam.com/kinect-v2-joint-map/](http://glitchbeam.com/kinect-v2-joint-map/)
* Unity & Visual Studio 2013 [http://glitchbeam.com/using-visual-studio-2013-for-main-unity-ide/](http://glitchbeam.com/using-visual-studio-2013-for-main-unity-ide/)
* Unity Tutorials [http://unity3d.com/learn/tutorials/modules](http://unity3d.com/learn/tutorials/modules)

### Examples
* Cursor - A joint is mapped to a cursor.  Box color changes when cursor collides.
* Body Particles - ParticleSystems spawn and follow joint positions.
* Player Controller - Left & Right hand mapped to player input.  This technique is used on the following games:
  * [Hypernaut](http://glitchbeam.com/games/hypernaut/)
  * [Horizon](http://glitchbeam.com/games/horizon/)

# Support
Please create an issue ticket for questions and issues.  Thank you.
