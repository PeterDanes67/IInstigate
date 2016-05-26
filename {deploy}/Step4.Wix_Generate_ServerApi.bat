ECHO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
ECHO Wix Package ServerApi
ECHO =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-

heat.exe ^
dir ".\Source" ^
-dr SERVERINSTALLFOLDER ^
-ke ^
-srd ^
-cg pixServerApiComponents ^
-var "var.serverApiContentLocation" ^
-gg ^
-out "Wix\src\serverApi.wxs" ^
-scom ^
-sreg ^
-suid ^
-nologo

ECHO.
