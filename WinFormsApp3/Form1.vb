Imports System.Diagnostics.Eventing
Imports System.IO
Imports System.Runtime.CompilerServices

Public Class Form1

    Dim folderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\DiaryApp"
    Private Sub CreateFolder()
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim text As String = diaryTextBox.Text
        Dim filePath As String = folderPath & "\" & diaryName.Text & ".txt"
        directoryLabel.Text = filePath
        My.Computer.FileSystem.WriteAllText(filePath, text, False)


        diaryNames()
        diaryList.Text = diaryName.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If diaryList.Items.Contains(diaryName.Text) Then
            Dim Response As Integer = MsgBox("Günlüğünüzü Silmek İstiyor Musunuz?", vbYesNo, "Diary App")

            If Response = vbYes Then
                Dim filePath As String = folderPath & "\" & diaryName.Text & ".txt"
                My.Computer.FileSystem.DeleteFile(filePath)

                diaryNames()

            End If
        End If
        diaryTextBox.Clear()
        diaryName.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateFolder()
        diaryNames()
    End Sub

    Private Sub diaryNames()
        diaryList.Text = ""
        diaryList.Items.Clear()

        Dim fileNames As String() = System.IO.Directory.GetFiles(folderPath)
        For Each fileName As String In fileNames
            Dim str = System.IO.Path.GetFileName(fileName)
            diaryList.Items.Add(str.Substring(0, str.Length - 4))
        Next
    End Sub
    Private Sub Button3_SizeChanged(sender As Object, e As EventArgs) Handles Button3.SizeChanged

    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged


        newDiary.Left = Me.Size.Width - 115
        Button2.Left = Me.Size.Width - 115
        Button3.Left = Me.Size.Width - 115

        Button4.Left = Me.Size.Width - 115
        Button4.Top = Me.Size.Height - 70


        diaryTextBox.Width = Me.Size.Width - 150
        diaryTextBox.Height = Me.Size.Height - 110




        Label1.Top = Me.Size.Height - 65
        Label2.Top = Me.Size.Height - 65
        directoryLabel.Top = Me.Size.Height - 65

        Button5.Left = Me.Size.Width - 115
        Button6.Left = Me.Size.Width - 85

        Button7.Left = Me.Size.Width - 115

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fontSize As Integer = diaryTextBox.SelectionFont.Size
        fontSize += 1
        diaryTextBox.SelectionFont = New Font(diaryTextBox.Font.Name, fontSize, diaryTextBox.SelectionFont.Style)


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim fontSize As Integer = diaryTextBox.SelectionFont.Size
        fontSize -= 1
        diaryTextBox.SelectionFont = New Font(diaryTextBox.Font.Name, fontSize, diaryTextBox.SelectionFont.Style)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim font As Font = diaryTextBox.SelectionFont
        If font IsNot Nothing Then
            Dim newFontStyle As FontStyle
            If font.Bold Then
                newFontStyle = font.Style And Not FontStyle.Bold
            Else
                newFontStyle = font.Style Or FontStyle.Bold
            End If
            diaryTextBox.SelectionFont = New Font(font.FontFamily, font.Size, newFontStyle)
        End If
    End Sub



    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles diaryTextBox.TextChanged
        Label2.Text = diaryTextBox.Text.Length
    End Sub

    Private Sub diaryList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles diaryList.SelectedIndexChanged
        diaryName.Text = diaryList.Text
        Dim filePath As String = folderPath & "\" & diaryList.SelectedItem & ".txt"
        diaryTextBox.Text = My.Computer.FileSystem.ReadAllText(filePath)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles newDiary.Click
        diaryList.Text = ""
        diaryName.Clear()
        diaryTextBox.Clear()
    End Sub
End Class
