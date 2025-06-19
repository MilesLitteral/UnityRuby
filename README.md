# UnityRuby
 Ruby Scripting in Unity/C#

* [IronRuby on NuGet](https://www.nuget.org/packages/IronRuby)
* [IronRuby Source Code](https://github.com/MilesLitteral/ironruby?tab=readme-ov-file) (incase you need to install the nuget package from a local src)

HOW IT WORKS
* You will need a copy of ![GlitchEnzo's NuGet Package](https://github.com/GlitchEnzo/NuGetForUnity/releases/tag/v4.4.0) for Unity
* You can get my fork of this project here: https://github.com/MilesLitteral/NuGetForUnity

Using NuGet, Install IronRuby, it will install to the directory of the Unity Build you are currently using,
You shouldn't have to worry about .NET version in Unity as NuGet will resolve all instances of scope in C#.

In your Build folder there will be a Lib/IronRuby Folder this directory is used to read from or execute any Ruby scripts that need to be 
accessed via C# in Unity3d

While currently I'm writing an Interface Class to more easily use IronRuby in Unity, IronRuby commands will work and 
can be used to execute your custom scripts via a C# layer (examples in progress).

As a bonus any gem used in a ruby script should in fact execute in engine, Seeing as the scopes of the MSVC and Ruby are separate the
script allows them to meet rather than create a nightmare.

RoadMap:
Reflect Basic Classes in Ruby (Object, MonoBehavior, GameObject, Transform, and Debug) so C# Data may be manipulated from Ruby and vice versa
Reflect Mathf, Random, Vectors, Quaternion
Reflect ScriptableObject, Time, Gizmos, and Handles

See Also:
* https://docs.unity3d.com/Manual/ScriptingImportantClasses.html

Bugs:
N/A (For now, no known bugs)
