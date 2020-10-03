<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.button_Start_Task = New System.Windows.Forms.Button()
        Me.button_Cancel_Task = New System.Windows.Forms.Button()
        Me.button_Toggle = New System.Windows.Forms.Button()
        Me.button_Close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button_Start_Task
        '
        Me.button_Start_Task.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_Start_Task.Location = New System.Drawing.Point(377, 59)
        Me.button_Start_Task.Name = "button_Start_Task"
        Me.button_Start_Task.Size = New System.Drawing.Size(75, 23)
        Me.button_Start_Task.TabIndex = 7
        Me.button_Start_Task.Text = "Start Task"
        Me.button_Start_Task.UseVisualStyleBackColor = True
        '
        'button_Cancel_Task
        '
        Me.button_Cancel_Task.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_Cancel_Task.Location = New System.Drawing.Point(377, 88)
        Me.button_Cancel_Task.Name = "button_Cancel_Task"
        Me.button_Cancel_Task.Size = New System.Drawing.Size(75, 23)
        Me.button_Cancel_Task.TabIndex = 6
        Me.button_Cancel_Task.Text = "Cancel Task"
        Me.button_Cancel_Task.UseVisualStyleBackColor = True
        '
        'button_Toggle
        '
        Me.button_Toggle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_Toggle.Location = New System.Drawing.Point(377, 117)
        Me.button_Toggle.Name = "button_Toggle"
        Me.button_Toggle.Size = New System.Drawing.Size(75, 23)
        Me.button_Toggle.TabIndex = 5
        Me.button_Toggle.Text = "Toggle"
        Me.button_Toggle.UseVisualStyleBackColor = True
        '
        'button_Close
        '
        Me.button_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_Close.Location = New System.Drawing.Point(377, 146)
        Me.button_Close.Name = "button_Close"
        Me.button_Close.Size = New System.Drawing.Size(75, 23)
        Me.button_Close.TabIndex = 4
        Me.button_Close.Text = "Close"
        Me.button_Close.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 181)
        Me.Controls.Add(Me.button_Start_Task)
        Me.Controls.Add(Me.button_Cancel_Task)
        Me.Controls.Add(Me.button_Toggle)
        Me.Controls.Add(Me.button_Close)
        Me.Name = "FormMain"
        Me.Text = "MyFormsHugeProgressJob VB"
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents button_Start_Task As Button
    Private WithEvents button_Cancel_Task As Button
    Private WithEvents button_Toggle As Button
    Private WithEvents button_Close As Button
End Class
