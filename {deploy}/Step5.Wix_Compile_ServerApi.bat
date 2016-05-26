ECHO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
ECHO Wix Compile ServerApi
ECHO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
candle.exe -dserverApiContentLocation=..\Features\ServerApi\source\ -out Wix\obj\ -arch x86 -nologo Wix\src\serverApi.wxs
ECHO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
ECHO.
