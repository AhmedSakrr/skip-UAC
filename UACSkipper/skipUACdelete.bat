@setlocal enableextensions
@cd /d "%~dp0"
@echo off
set /p delname=<delname.txt
SCHTASKS /Delete /TN %delname% /f
del /q "delname.txt"
