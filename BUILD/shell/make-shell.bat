@echo off
csc /out:shell.exe /t:exe /nologo ..\..\src\k\system\shell\*.cs
@echo on
exit