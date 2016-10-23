Dim objFSO 'File System Object
Set objFSO = CreateObject("Scripting.FileSystemObject")
Dim objTS 'Text Stream Object
Const ForWriting = 2
Set objTS = objFSO.OpenTextFile("delname.txt", ForWriting, True)
objTS.Write(InputBox("What is the internal name of the shortcut that you created?"))
objTS.Close()
Dim objShell
Set objShell = WScript.CreateObject("WScript.Shell")
objShell.Run "skipUACdelete.bat"