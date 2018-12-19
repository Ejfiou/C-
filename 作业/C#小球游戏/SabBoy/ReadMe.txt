编译环境是vs2010 ，如果你的是vs2008 :
请用记事本打开.sln文件,修改：
Microsoft Visual Studio Solution File, Format Version 11.00 版本
改为：
Microsoft Visual Studio Solution File, Format Version 9.00 版本

用记事本打开.csproj文件，修改：

<Project ToolsVersion="4.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
改为：
<Project ToolsVersion="2.0" DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">

即可！

===================================
我的空间：http://blog.csdn.net/hwenycocodq520
===================================