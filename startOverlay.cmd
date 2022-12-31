@echo off
echo %cd%
start python3 -m http.server
start "" "bin/Debug/net6.0/vscode test.exe"
