<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AverageUnitsShipped = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtEntry = New System.Windows.Forms.TextBox()
        Me.txtEntryOutput = New System.Windows.Forms.TextBox()
        Me.txtWeekDays = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AccessibleName = "lblUnits"
        Me.Label1.Location = New System.Drawing.Point(61, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Units: "
        '
        'Label2
        '
        Me.Label2.AccessibleName = "lblDate"
        Me.Label2.Location = New System.Drawing.Point(198, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date:"
        '
        'btnEnter
        '
        Me.btnEnter.AccessibleName = "btnEnter"
        Me.btnEnter.Location = New System.Drawing.Point(28, 226)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShipped.SetToolTip(Me.btnEnter, "Calculates the Average")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.AccessibleName = "btnReset"
        Me.btnReset.Location = New System.Drawing.Point(115, 226)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShipped.SetToolTip(Me.btnReset, "Reset's the program")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AccessibleName = "btnExit"
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(202, 226)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShipped.SetToolTip(Me.btnExit, "Exit's the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtEntry
        '
        Me.txtEntry.AccessibleName = "txtEntry"
        Me.txtEntry.Location = New System.Drawing.Point(92, 38)
        Me.txtEntry.Name = "txtEntry"
        Me.txtEntry.Size = New System.Drawing.Size(100, 20)
        Me.txtEntry.TabIndex = 1
        Me.AverageUnitsShipped.SetToolTip(Me.txtEntry, "Enter values of units shipped")
        '
        'txtEntryOutput
        '
        Me.txtEntryOutput.AccessibleName = "txtEntryOutput"
        Me.txtEntryOutput.Location = New System.Drawing.Point(63, 79)
        Me.txtEntryOutput.Multiline = True
        Me.txtEntryOutput.Name = "txtEntryOutput"
        Me.txtEntryOutput.Size = New System.Drawing.Size(179, 102)
        Me.txtEntryOutput.TabIndex = 4
        '
        'txtWeekDays
        '
        Me.txtWeekDays.AccessibleName = "txtWeekDays"
        Me.txtWeekDays.Location = New System.Drawing.Point(229, 38)
        Me.txtWeekDays.Name = "txtWeekDays"
        Me.txtWeekDays.Size = New System.Drawing.Size(14, 20)
        Me.txtWeekDays.TabIndex = 3
        Me.txtWeekDays.Text = "1"
        Me.AverageUnitsShipped.SetToolTip(Me.txtWeekDays, "Number of days")
        '
        'lblOutput
        '
        Me.lblOutput.AccessibleName = "lblOutput"
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(64, 195)
        Me.lblOutput.MinimumSize = New System.Drawing.Size(179, 0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(179, 13)
        Me.lblOutput.TabIndex = 6
        Me.lblOutput.Text = "Average Units Shipped: "
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AccessibleName = "frmAverageUnitsShipped"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(304, 261)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtWeekDays)
        Me.Controls.Add(Me.txtEntryOutput)
        Me.Controls.Add(Me.txtEntry)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(320, 300)
        Me.MinimumSize = New System.Drawing.Size(320, 300)
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents AverageUnitsShipped As ToolTip
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtEntry As TextBox
    Friend WithEvents txtEntryOutput As TextBox
    Friend WithEvents txtWeekDays As TextBox
    Friend WithEvents lblOutput As Label
End Class
