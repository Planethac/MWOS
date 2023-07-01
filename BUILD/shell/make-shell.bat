@echo off
echo Compiling ...
csc /out:shell.exe /t:exe /nologo ..\..\src\k\system\shell\*.cs
echo Succes!
@echo on