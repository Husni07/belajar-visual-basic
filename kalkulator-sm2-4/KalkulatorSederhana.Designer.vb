<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KalkulatorSederhana
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.textAngka1 = New System.Windows.Forms.TextBox()
        Me.textAngka2 = New System.Windows.Forms.TextBox()
        Me.plus = New System.Windows.Forms.Button()
        Me.hasilnya = New System.Windows.Forms.TextBox()
        Me.min = New System.Windows.Forms.Button()
        Me.kali = New System.Windows.Forms.Button()
        Me.bagi = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textAngka1
        '
        Me.textAngka1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textAngka1.Location = New System.Drawing.Point(26, 33)
        Me.textAngka1.Multiline = True
        Me.textAngka1.Name = "textAngka1"
        Me.textAngka1.Size = New System.Drawing.Size(162, 41)
        Me.textAngka1.TabIndex = 0
        '
        'textAngka2
        '
        Me.textAngka2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textAngka2.Location = New System.Drawing.Point(208, 33)
        Me.textAngka2.Multiline = True
        Me.textAngka2.Name = "textAngka2"
        Me.textAngka2.Size = New System.Drawing.Size(162, 41)
        Me.textAngka2.TabIndex = 1
        '
        'plus
        '
        Me.plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.plus.Location = New System.Drawing.Point(26, 98)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(75, 50)
        Me.plus.TabIndex = 2
        Me.plus.Text = "+"
        Me.plus.UseVisualStyleBackColor = True
        '
        'hasilnya
        '
        Me.hasilnya.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hasilnya.Location = New System.Drawing.Point(26, 174)
        Me.hasilnya.Multiline = True
        Me.hasilnya.Name = "hasilnya"
        Me.hasilnya.Size = New System.Drawing.Size(344, 71)
        Me.hasilnya.TabIndex = 3
        '
        'min
        '
        Me.min.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min.Location = New System.Drawing.Point(113, 98)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(75, 50)
        Me.min.TabIndex = 4
        Me.min.Text = "-"
        Me.min.UseVisualStyleBackColor = True
        '
        'kali
        '
        Me.kali.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kali.Location = New System.Drawing.Point(208, 98)
        Me.kali.Name = "kali"
        Me.kali.Size = New System.Drawing.Size(75, 50)
        Me.kali.TabIndex = 5
        Me.kali.Text = "x"
        Me.kali.UseVisualStyleBackColor = True
        '
        'bagi
        '
        Me.bagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bagi.Location = New System.Drawing.Point(289, 98)
        Me.bagi.Name = "bagi"
        Me.bagi.Size = New System.Drawing.Size(75, 50)
        Me.bagi.TabIndex = 6
        Me.bagi.Text = "/"
        Me.bagi.UseVisualStyleBackColor = True
        '
        'KalkulatorSederhana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 380)
        Me.Controls.Add(Me.bagi)
        Me.Controls.Add(Me.kali)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.hasilnya)
        Me.Controls.Add(Me.plus)
        Me.Controls.Add(Me.textAngka2)
        Me.Controls.Add(Me.textAngka1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "KalkulatorSederhana"
        Me.Text = "KALKULATOR SEDERHANA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textAngka1 As TextBox
    Friend WithEvents textAngka2 As TextBox
    Friend WithEvents plus As Button
    Friend WithEvents hasilnya As TextBox
    Friend WithEvents min As Button
    Friend WithEvents kali As Button
    Friend WithEvents bagi As Button
End Class
