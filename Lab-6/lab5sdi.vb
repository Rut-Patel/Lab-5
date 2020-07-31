''''''''''''''''''''''''''''''''''''''''''
''Name:- Rut Patel
''SID:- 100774814
''Purpose:- Creating a single Document Interface notepad using VB.net.
''Reference: - In class codes, Austin Garrod
''''''''''''''''''''''''''''''''''''''''

Option Strict On
Imports System.IO

Public Class lab5sdi

    ''' <summary>
    ''' Event fires when open button is clicked.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Open_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        Dim filestream As StreamReader

        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            filestream = New StreamReader(OpenFileDialog.FileName)
            txtTextArea.Text = filestream.ReadToEnd()
            lblStripStatus.Text = "Loaded " + OpenFileDialog.FileName

            filestream.Close()
        End If
    End Sub
    ''' <summary>
    ''' Event fires when New button from the menu is selected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub New_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        txtTextArea.Clear()

        lblStripStatus.Text = "New file created"
    End Sub

    ''' <summary>
    ''' Event Fires when the Save and Save As button from the menu is selected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click, mnuFileSaveAs.Click
        Dim outputstream As StreamWriter

        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            outputstream = New StreamWriter(SaveFileDialog.FileName)
            outputstream.Write(txtTextArea.Text)

            outputstream.Close()

            lblStripStatus.Text = "File Saved " + SaveFileDialog.FileName
        End If
    End Sub
    ''' <summary>
    ''' Event Fires when the Exit button from the menu is selected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Dim dialog As DialogResult
        If txtTextArea.Text = "" Then
            Application.Exit()
        Else
            dialog = MessageBox.Show("Want to save your work ?", "Message", MessageBoxButtons.YesNo)

            If dialog = DialogResult.Yes Then
                Dim outputstream As StreamWriter

                If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                    outputstream = New StreamWriter(SaveFileDialog.FileName)
                    outputstream.Write(txtTextArea.Text)

                    outputstream.Close()

                    lblStripStatus.Text = "File Saved " + SaveFileDialog.FileName
                ElseIf dialog = DialogResult.No Then

                    Application.Exit()
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' Event Fires when the Close button from the menu is selected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Close_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click
        Dim dialog As DialogResult

        If txtTextArea.Text = "" Then
            Me.Close()
            lblStripStatus.Text = "File Closed"
        Else
            dialog = MessageBox.Show("Want to save your work ?", "Message", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                Dim outputstream As StreamWriter

                If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                    outputstream = New StreamWriter(SaveFileDialog.FileName)
                    outputstream.Write(txtTextArea.Text)

                    outputstream.Close()

                    lblStripStatus.Text = "File Saved " + SaveFileDialog.FileName
                    txtTextArea.Text = ""
                ElseIf dialog = DialogResult.No Then
                    lblStripStatus.Text = "File Closed"
                    Application.Exit()
                End If
            End If
        End If
    End Sub
    ''' <summary>
    ''' Event Fires when the Copy button from the menu is selected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Copy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        txtTextArea.Copy()
    End Sub
    ''' <summary>
    ''' Event Fires when the Cut button from the menu is selected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Cut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        txtTextArea.Cut()
    End Sub
    ''' <summary>
    ''' Event Fires when the Paste button from the menu is selected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Paste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        txtTextArea.Paste()
    End Sub
    ''' <summary>
    ''' Event Fires when the About button from the menu is selected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub About_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        Dim aboutModal As New frmabout

        aboutModal.ShowDialog()
    End Sub
    ''' <summary>
    ''' Event Fires when the form is closed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ConfirmClose(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult

        If txtTextArea.Text = "" Then
            Application.Exit()
        Else
            dialog = MessageBox.Show("Want to save your work ?", "Message", MessageBoxButtons.YesNo)
            If dialog = DialogResult.Yes Then
                Dim outputstream As StreamWriter

                If SaveFileDialog.ShowDialog() = DialogResult.OK Then
                    outputstream = New StreamWriter(SaveFileDialog.FileName)
                    outputstream.Write(txtTextArea.Text)

                    outputstream.Close()

                    lblStripStatus.Text = "File Saved " + SaveFileDialog.FileName
                ElseIf dialog = DialogResult.No Then

                    Application.Exit()
                End If
            End If
        End If
    End Sub
End Class
