Dim objFSO 'File System Object
Set objFSO = CreateObject("Scripting.FileSystemObject")
Dim objTS 'Text Stream Object
Const ForWriting = 2
Set objTS = objFSO.OpenTextFile("command.txt", ForWriting, True)
objTS.Write(InputBox("Choose the internal name for the shortcut, do not use spaces"))
objTS.Close()
Set objTS = objFSO.OpenTextFile("program.txt", ForWriting, True)
objTS.Write(InputBox("Choose the program that you would like to run. If it has spaces, add quotes on both sides"))
objTS.Close()
Dim objShell
Set objShell = WScript.CreateObject("WScript.Shell")
objShell.Run "skipUACcreate.bat"