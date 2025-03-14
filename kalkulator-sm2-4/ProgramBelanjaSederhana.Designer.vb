<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProgramBelanjaSederhana
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Judul = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtJumlah = New System.Windows.Forms.TextBox()
        Me.buttonHitung = New System.Windows.Forms.Button()
        Me.ButtonUlang = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalBayar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDiskon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBonus = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 2
        '
        'Judul
        '
        Me.Judul.AutoSize = True
        Me.Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Judul.Location = New System.Drawing.Point(52, 13)
        Me.Judul.Name = "Judul"
        Me.Judul.Size = New System.Drawing.Size(328, 29)
        Me.Judul.TabIndex = 3
        Me.Judul.Text = "Program Belanja Sederhan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Nama"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(187, 70)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(100, 30)
        Me.txtNama.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHarga.Location = New System.Drawing.Point(187, 106)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(100, 30)
        Me.txtHarga.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Jumlah"
        '
        'txtJumlah
        '
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlah.Location = New System.Drawing.Point(187, 143)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(100, 30)
        Me.txtJumlah.TabIndex = 8
        '
        'buttonHitung
        '
        Me.buttonHitung.BackColor = System.Drawing.SystemColors.ControlDark
        Me.buttonHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonHitung.Location = New System.Drawing.Point(57, 204)
        Me.buttonHitung.Name = "buttonHitung"
        Me.buttonHitung.Size = New System.Drawing.Size(112, 49)
        Me.buttonHitung.TabIndex = 12
        Me.buttonHitung.Text = "Hitung"
        Me.buttonHitung.UseVisualStyleBackColor = False
        '
        'ButtonUlang
        '
        Me.ButtonUlang.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ButtonUlang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUlang.Location = New System.Drawing.Point(187, 204)
        Me.ButtonUlang.Name = "ButtonUlang"
        Me.ButtonUlang.Size = New System.Drawing.Size(112, 49)
        Me.ButtonUlang.TabIndex = 13
        Me.ButtonUlang.Text = "Ulang"
        Me.ButtonUlang.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(64, 356)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Total Bayar"
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBayar.Location = New System.Drawing.Point(199, 353)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.Size = New System.Drawing.Size(100, 30)
        Me.txtTotalBayar.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 25)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Diskon"
        '
        'txtDiskon
        '
        Me.txtDiskon.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiskon.Location = New System.Drawing.Point(199, 316)
        Me.txtDiskon.Name = "txtDiskon"
        Me.txtDiskon.Size = New System.Drawing.Size(100, 30)
        Me.txtDiskon.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Total Harga"
        '
        'TxtTotalHarga
        '
        Me.TxtTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotalHarga.Location = New System.Drawing.Point(199, 280)
        Me.TxtTotalHarga.Name = "TxtTotalHarga"
        Me.TxtTotalHarga.Size = New System.Drawing.Size(100, 30)
        Me.TxtTotalHarga.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 25)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Bonus"
        '
        'txtBonus
        '
        Me.txtBonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBonus.Location = New System.Drawing.Point(199, 389)
        Me.txtBonus.Name = "txtBonus"
        Me.txtBonus.Size = New System.Drawing.Size(100, 30)
        Me.txtBonus.TabIndex = 20
        '
        'ProgramBelanjaSederhana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 520)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBonus)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotalBayar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDiskon)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTotalHarga)
        Me.Controls.Add(Me.ButtonUlang)
        Me.Controls.Add(Me.buttonHitung)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtJumlah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Judul)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ProgramBelanjaSederhana"
        Me.Text = "ProgramBelanjaSederhana"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Judul As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtJumlah As TextBox
    Friend WithEvents buttonHitung As Button
    Friend WithEvents ButtonUlang As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalBayar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDiskon As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTotalHarga As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBonus As TextBox
End Class
