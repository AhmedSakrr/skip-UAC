@setlocal enableextensions
@cd /d "%~dp0"
@echo off
set /p name=<command.txt
set /p program=<program.txt
SCHTASKS /create /tn %name% /tr %program% /rl HIGHEST /sc ONCE /sd 01/01/1910 /st 00:00
del /q command.txt
del /q program.txt
cls
echo Please, create the shortcut with following details in the location field: schtasks /run /tn %name%
pause