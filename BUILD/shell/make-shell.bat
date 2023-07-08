@echo off
echo Compiling ...
csc /out:..\..\src\k\system\shell\shell.exe /t:exe /nologo ..\..\src\k\system\shell\*.cs
cd ..\..\src\k\system\gui
msbuild.exe
cp -r bin\Debug\net7.0-windows\* .
echo Succes!
@echo on