''''''''''''''''''''''''''''''''''''''''''
''Name:- Rut Patel
''SID:- 100774814
''Purpose:- Creating a single Document Interface notepad using VB.net.
''Reference: - In class codes, Austin Garrod
''''''''''''''''''''''''''''''''''''''''

Option Strict On
Imports System.IO
Public Class lab5sdi
    Private Sub Open_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        Dim filestream As StreamReader

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            filestream = New StreamReader(OpenFileDialog.FileName)
            txtTextArea.Text = filestream.ReadToEnd()
            lblStripStatus.Text = "Loaded " + OpenFileDialog.FileName

            filestream.Close()
        End If
    End Sub

    Private Sub New_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        txtTextArea.Clear()

        lblStripStatus.Text = "New file created"
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click, mnuFileSaveAs.Click
        Dim outputstream As StreamWriter

        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            outputstream = New StreamWriter(SaveFileDialog.FileName)
            outputstream.Write(txtTextArea.Text)

            outputstream.Close()

            lblStripStatus.Text = "File Saved " + SaveFileDialog.FileName
        End If
    End Sub

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Application.Exit()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Me.Close()
    End Sub

    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        txtTextArea.Copy()
    End Sub

    Private Sub Cut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        txtTextArea.Cut()
    End Sub

    Private Sub Paste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        txtTextArea.Paste()
    End Sub

    Private Sub About_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click

    End Sub
End Class
