ECHO OFF

ECHO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
ECHO Build Instigate Debug
ECHO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

"C:\Program Files (x86)\MSBuild\14.0\Bin\msbuild.exe" instigate.sln /t:Rebuild /p:Configuration="Release";Platform="Any CPU" /nologo /fileLogger /v:m
