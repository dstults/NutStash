Public Class FrmApple

    ' Program by Darren Stults
    ' Icon art by Martin Berube
    ' Free use permission from http://www.iconarchive.com/show/food-icons-by-martin-berube/apple-icon.html

    Private AppleFlagBytes As Byte() = System.Text.Encoding.UTF8.GetBytes("Apple!")
    Private SneakierFlagBytes As Byte() = {15, 39, 54, 234, 42, 96}

    Private ImageFound As Boolean
    Private ImagePath As String
    Private TextFound As Boolean
    Private TextPath As String

    Private Function ByteCrypto(inputBytes() As Byte, MagicNumber As Integer)
        Dim outputBytes(inputBytes.Length - 1) As Byte
        Dim tempInt As Integer
        For intA As Integer = 0 To inputBytes.Length - 1
            tempInt = inputBytes(intA) + MagicNumber
            If tempInt > 255 Then tempInt -= 256
            If tempInt < 0 Then tempInt += 256
            outputBytes(intA) = tempInt
        Next
        Return outputBytes
    End Function

    Private Sub FrmApple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("You loaded the program!")
        Dim args() As String = Environment.GetCommandLineArgs
        If args.Length > 1 Then
            For intA As Integer = 1 To args.length - 1
                Select Case Strings.Right(args(intA), 4)
                    Case ".jpg", "jpeg", ".png", ".tga", ".tif", "tiff", ".bmp", ".gif"
                        'MsgBox("IMAGE FOUND: " & args(intA))
                        ImagePath = args(intA)
                        ImageFound = True
                    Case ".txt", "text"
                        'MsgBox("TEXT FOUND: " & args(intA))
                        TextPath = args(intA)
                        TextFound = True
                End Select
            Next
        End If
        If Not ImageFound Then
            MsgBox("No image file was selected -- this demo requires that you have an image file selected.")
            Me.Close()
        End If
        If Not TextFound Then
            'MsgBox("No text file was found -- attaching messages to files will be diabled.")
            BtnAttachApple.Enabled = False
            BtnAttachNormal.Enabled = False
        End If
    End Sub

    Private Sub AttachSecretMessage(flagBytes() As Byte, Encrypt As Boolean)
        Dim imageBytes() As Byte = My.Computer.FileSystem.ReadAllBytes(ImagePath)
        Dim inputMessage() As Byte = My.Computer.FileSystem.ReadAllBytes(TextPath)
        If Encrypt Then inputMessage = ByteCrypto(inputMessage, 13)
        My.Computer.FileSystem.WriteAllBytes(ImagePath & ".out", imageBytes, False)
        My.Computer.FileSystem.WriteAllBytes(ImagePath & ".out", flagBytes, True)
        My.Computer.FileSystem.WriteAllBytes(ImagePath & ".out", inputMessage, True)
        MsgBox("Message written to new image: " & ImagePath & ".out")
    End Sub

    Private Sub BtnAttachApple_Click(sender As Object, e As EventArgs) Handles BtnAttachApple.Click
        AttachSecretMessage(AppleFlagBytes, False)
    End Sub

    Private Sub BtnAttachNormal_Click(sender As Object, e As EventArgs) Handles BtnAttachNormal.Click
        AttachSecretMessage(SneakierFlagBytes, True)
    End Sub

    Private Sub DetachSecretMessage(flagBytes() As Byte, Decrypt As Boolean)
        Dim imageBytes() As Byte = My.Computer.FileSystem.ReadAllBytes(ImagePath)
        Dim LocationOfFlagStart As Integer = GetLocationMessageStart(imageBytes, flagBytes)
        If LocationOfFlagStart = -1 Then
            MsgBox("No flag bytes found -- no good!")
        Else
            GetAndDisplayMessage(LocationOfFlagStart, imageBytes, flagBytes, Decrypt)
        End If
    End Sub
    Private Function GetLocationMessageStart(imageBytes() As Byte, flagBytes() As Byte) As Integer
        For intByte As Integer = 0 To (imageBytes.Length - 1) - (flagBytes.Length - 1) ' 1s cancel out, can be removed, but not for now

            If imageBytes(intByte) = flagBytes(0) Then
                Dim passesTest As Boolean = True
                For intSubByte As Integer = 1 To flagBytes.Length - 1
                    If imageBytes(intByte + intSubByte) <> flagBytes(intSubByte) Then passesTest = False
                Next
                If passesTest Then Return intByte + 1
            End If
        Next
        Return -1
    End Function
    Private Sub GetAndDisplayMessage(LocationOfFlagStart As Integer, imageBytes() As Byte, flagBytes() As Byte, Decrypt As Boolean)
        Dim NewBytes(0) As Byte
        Dim intA As Integer
        'Dim output() As Byte = bytesToSearch.Skip(x).Take(10).ToArray
        For intByte As Integer = LocationOfFlagStart + (flagBytes.Length - 1) To (imageBytes.Length - 1)
            ReDim Preserve NewBytes(intA)
            NewBytes(intA) = imageBytes(intByte)
            intA += 1
        Next
        'Dim DetachedMessage As String = BitConverter.ToString(NewBytes, 0, NewBytes.Length - 1)
        'Dim DetachedMessage As String = System.Text.Encoding.UTF8.GetString(NewBytes)
        'MsgBox(DetachedMessage)
        If Decrypt Then NewBytes = ByteCrypto(NewBytes, -13)
        My.Computer.FileSystem.WriteAllBytes(".\output.txt", NewBytes, True)
            MsgBox("Message written to: .\output.txt")
    End Sub

    Private Sub BtnDetachApple_Click(sender As Object, e As EventArgs) Handles BtnDetachApple.Click
        DetachSecretMessage(AppleFlagBytes, False)
    End Sub

    Private Sub BtnDetachNormal_Click(sender As Object, e As EventArgs) Handles BtnDetachNormal.Click
        DetachSecretMessage(SneakierFlagBytes, True)
    End Sub
End Class
