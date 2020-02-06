Public Class FrmNutStash

    ' Program by Darren Stults
    ' Icon art by Martin Berube
    ' Free use permission from http://www.iconarchive.com/show/food-icons-by-martin-berube/apple-icon.html

    Private ReadOnly UnencryptedFlagBytes As Byte() = System.Text.Encoding.UTF8.GetBytes("Apple!")
    Private ReadOnly ROT13FlagBytes As Byte() = {15, 39, 54, 234, 42, 96}
    Private ReadOnly ComplexFlagBytes As Byte() = {15, 39, 54, 234, 42, 96, 14, 22, 53, 26, 2, 191, 61}
    Private CustomFlagBytes As Byte()

    Private InputFile1Path As String
    Private InputFile2Path As String

    Private Function File1Found() As Boolean
        Return InputFile1Path <> ""
    End Function

    Private Function File2Found() As Boolean
        Return InputFile2Path <> ""
    End Function

    Private Function WeakCrypto(inputBytes() As Byte, MagicNumber As Integer)
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

    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function

    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function

    Private Sub FrmNutStash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox("You loaded the program!")
        Dim args() As String = Environment.GetCommandLineArgs
        If args.Length > 1 Then
            For intA As Integer = 1 To args.Length - 1
                Select Case Strings.Right(args(intA), 4)
                    Case ".jpg", "jpeg", ".png", ".tga", ".tif", "tiff", ".bmp", ".gif"
                        'MsgBox("IMAGE FOUND: " & args(intA))
                        InputFile1Path = args(intA)
                    Case ".txt", "text"
                        'MsgBox("TEXT FOUND: " & args(intA))
                        InputFile2Path = args(intA)
                End Select
            Next
        End If
        RefreshDisplay()
    End Sub

    Private Sub AttachFile()
        Dim flagBytes() As Byte
        If RadEncryptNone.Checked Then
            flagBytes = UnencryptedFlagBytes
        ElseIf RadEncryptROT13.Checked Then
            flagBytes = ROT13FlagBytes
        ElseIf RadEncryptAES256.Checked Then
            flagBytes = ComplexFlagBytes
        Else
            flagBytes = UnencryptedFlagBytes
        End If

        Dim imageBytes() As Byte = My.Computer.FileSystem.ReadAllBytes(InputFile1Path)
        Dim inputMessage() As Byte = My.Computer.FileSystem.ReadAllBytes(InputFile2Path)
        If Encrypt Then inputMessage = WeakCryypto(inputMessage, 13)
        My.Computer.FileSystem.WriteAllBytes(InputFile1Path & ".out", imageBytes, False)
        My.Computer.FileSystem.WriteAllBytes(InputFile1Path & ".out", flagBytes, True)
        My.Computer.FileSystem.WriteAllBytes(InputFile1Path & ".out", inputMessage, True)
        MsgBox("Message written to new image: " & InputFile1Path & ".out")
    End Sub

    Private Sub DetachFile()
        Dim imageBytes() As Byte = My.Computer.FileSystem.ReadAllBytes(InputFile1Path)
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

    Private Function GetFileProcess(aFilter As String) As Boolean
        OpenFileDialog1.Filter = aFilter
        Select Case OpenFileDialog1.ShowDialog()
            Case DialogResult.Cancel, DialogResult.Cancel
                'MsgBox("Cancelled", MsgBoxStyle.Critical)
                Return False
        End Select
        Return True
    End Function

    Private Sub BtnLoadFile1_Click(sender As Object, e As EventArgs) Handles BtnLoadImage.Click
        If Not GetFileProcess("Images|*.bmp;*.jpg;*.jpeg;*.gif;*.tif;*.tiff;*.png|All Files|*.*") Then Exit Sub

        If Dir(OpenFileDialog1.FileName) <> "" Then
            InputFile1Path = OpenFileDialog1.FileName
        Else
            MsgBox("Invalid filename? Seriously, how did you do that? Tell me on GitHub.")
            InputFile1Path = ""
        End If
        RefreshDisplay()
    End Sub

    Private Sub BtnLoadText_Click(sender As Object, e As EventArgs) Handles BtnLoadText.Click
        If Not GetFileProcess("Images|*.txt;*.text|All Files|*.*") Then Exit Sub

        If Dir(OpenFileDialog1.FileName) <> "" Then
            InputFile2Path = OpenFileDialog1.FileName
        Else
            MsgBox("Invalid filename? Seriously, how did you do that? Tell me on GitHub.")
            InputFile1Path = ""
        End If
        RefreshDisplay()
    End Sub

    Private Sub RefreshDisplay()
        If File1Found() Then
            LblFile1.Text = "..." & Strings.Right(InputFile1Path, 12)
        Else
            LblFile1.Text = "(no file 1)"
        End If
        If File2Found() Then
            LblFile2.Text = "..." & Strings.Right(InputFile2Path, 12)
        Else
            LblFile2.Text = "(no file 2)"
        End If
        BtnProcess.Enabled = False
        If File1Found() Then
            BtnProcess.Enabled = True
            If File2Found() Then
                BtnProcess.Text = "Attach"
            Else
                BtnProcess.Text = "Detach"
            End If
        Else
            BtnProcess.Text = "Select Image"
        End If
    End Sub

    Private Sub BtnClearFile1_Click(sender As Object, e As EventArgs) Handles BtnClearFile1.Click
        InputFile1Path = ""
        RefreshDisplay()
    End Sub

    Private Sub BtnClearFile2_Click(sender As Object, e As EventArgs) Handles BtnClearFile2.Click
        InputFile2Path = ""
        RefreshDisplay()
    End Sub

    Private Sub BtnProcess_Click(sender As Object, e As EventArgs) Handles BtnProcess.Click
        If File1Found() Then
            If File2Found() Then
                AttachFile()
            Else
                DetachFile()
            End If
        End If

    End Sub
End Class
