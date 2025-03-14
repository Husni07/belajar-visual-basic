<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.ProgramKalkulatorSederhana = New System.Windows.Forms.Button()
        Me.Tugas1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BelanjaSederhana = New System.Windows.Forms.Button()
        Me.shutDown = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgramKalkulatorSederhana
        '
        Me.ProgramKalkulatorSederhana.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ProgramKalkulatorSederhana.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ProgramKalkulatorSederhana.Location = New System.Drawing.Point(12, 23)
        Me.ProgramKalkulatorSederhana.Name = "ProgramKalkulatorSederhana"
        Me.ProgramKalkulatorSederhana.Size = New System.Drawing.Size(142, 61)
        Me.ProgramKalkulatorSederhana.TabIndex = 0
        Me.ProgramKalkulatorSederhana.Text = "Kalkulator Sedeerhana"
        Me.ProgramKalkulatorSederhana.UseVisualStyleBackColor = False
        '
        'Tugas1
        '
        Me.Tugas1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Tugas1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Tugas1.Location = New System.Drawing.Point(175, 23)
        Me.Tugas1.Name = "Tugas1"
        Me.Tugas1.Size = New System.Drawing.Size(142, 61)
        Me.Tugas1.TabIndex = 1
        Me.Tugas1.Text = "Tugas 1 Hitung Nilai Akhir"
        Me.Tugas1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button3.Location = New System.Drawing.Point(501, 23)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(142, 61)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BelanjaSederhana
        '
        Me.BelanjaSederhana.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BelanjaSederhana.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BelanjaSederhana.Location = New System.Drawing.Point(338, 23)
        Me.BelanjaSederhana.Name = "BelanjaSederhana"
        Me.BelanjaSederhana.Size = New System.Drawing.Size(142, 61)
        Me.BelanjaSederhana.TabIndex = 2
        Me.BelanjaSederhana.Text = "Belanja Sederhana"
        Me.BelanjaSederhana.UseVisualStyleBackColor = False
        '
        'shutDown
        '
        Me.shutDown.BackColor = System.Drawing.Color.Red
        Me.shutDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shutDown.Location = New System.Drawing.Point(434, 377)
        Me.shutDown.Name = "shutDown"
        Me.shutDown.Size = New System.Drawing.Size(222, 61)
        Me.shutDown.TabIndex = 4
        Me.shutDown.Text = "ShutDown"
        Me.shutDown.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 450)
        Me.Controls.Add(Me.shutDown)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BelanjaSederhana)
        Me.Controls.Add(Me.Tugas1)
        Me.Controls.Add(Me.ProgramKalkulatorSederhana)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgramKalkulatorSederhana As Button
    Friend WithEvents Tugas1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BelanjaSederhana As Button
    Friend WithEvents shutDown As Button
End Class
