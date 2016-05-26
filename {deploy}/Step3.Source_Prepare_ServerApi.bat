ECHO OFF

ECHO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
ECHO Prepare ServerApi source
ECHO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

SET "SourceDir=..\..\..\ServerApi\bin\release"
SET "TargetDir=.\Source\"

ECHO SourceDir = %SourceDir%
ECHO TargetDir = %TargetDir%

REM Create Source directory

mkdir Source

ECHO Copying ServerApi .exe files
xcopy %SourceDir%\*.exe %TargetDir%\. /Y /Q

ECHO Copying ServerApi .dll files
xcopy %SourceDir%\*.dll %TargetDir%\. /Y /Q /S

ECHO Copying ServerApi .config files
xcopy %SourceDir%\*.config %TargetDir%\. /Y /Q

ECHO Copying ServerApi API.XML files
xcopy %SourceDir%\*API.xml %TargetDir%\. /Y /Q


IF EXIST %TargetDir%\*.*.app.config del %TargetDir%\*.*.app.config /Q
IF EXIST %TargetDir%\"*.vshost.*" del %TargetDir%\"*.vshost.*" /Q
REM xcopy %TargetDir%\Kofax.TotalAgility.* ..\PixKta\Source\. /Y /Q
del %TargetDir%\Kofax.TotalAgility.* /Q
ECHO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
ECHO.


