ECHO OFF

ECHO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
ECHO Compiling ServerApi
ECHO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

cd..\..\..
"C:\Program Files (x86)\MSBuild\14.0\Bin\msbuild.exe" pix.sln /t:Rebuild /p:Configuration="Deploy.ServerApi";Platform="Any CPU" /nologo /fileLogger /v:m
cd {deploy}
cd Features
cd ServerApi
