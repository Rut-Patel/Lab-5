<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmabout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbldisplay = New System.Windows.Forms.Label()
        Me.btnagree = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbldisplay
        '
        Me.lbldisplay.Location = New System.Drawing.Point(54, 32)
        Me.lbldisplay.Name = "lbldisplay"
        Me.lbldisplay.Size = New System.Drawing.Size(130, 84)
        Me.lbldisplay.TabIndex = 0
        Me.lbldisplay.Text = "NETD-2201" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lab-5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rut Patel"
        '
        'btnagree
        '
        Me.btnagree.Location = New System.Drawing.Point(68, 138)
        Me.btnagree.Name = "btnagree"
        Me.btnagree.Size = New System.Drawing.Size(75, 23)
        Me.btnagree.TabIndex = 1
        Me.btnagree.Text = "&OK"
        Me.btnagree.UseVisualStyleBackColor = True
        '
        'frmabout
        '
        Me.AcceptButton = Me.btnagree
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(217, 194)
        Me.Controls.Add(Me.btnagree)
        Me.Controls.Add(Me.lbldisplay)
        Me.Name = "frmabout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbldisplay As Label
    Friend WithEvents btnagree As Button
End Class
