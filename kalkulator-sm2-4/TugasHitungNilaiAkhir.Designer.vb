<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TugasHitungNilaiAkhir
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
        Me.txtKehadiran = New System.Windows.Forms.TextBox()
        Me.Judul = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUts = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtQuiz = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUas = New System.Windows.Forms.TextBox()
        Me.buttonHitung = New System.Windows.Forms.Button()
        Me.txtNilaiAkhir = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtKehadiran
        '
        Me.txtKehadiran.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKehadiran.Location = New System.Drawing.Point(189, 68)
        Me.txtKehadiran.Name = "txtKehadiran"
        Me.txtKehadiran.Size = New System.Drawing.Size(100, 30)
        Me.txtKehadiran.TabIndex = 0
        '
        'Judul
        '
        Me.Judul.AutoSize = True
        Me.Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Judul.Location = New System.Drawing.Point(12, 19)
        Me.Judul.Name = "Judul"
        Me.Judul.Size = New System.Drawing.Size(341, 29)
        Me.Judul.TabIndex = 1
        Me.Judul.Text = "Tugas 1 Husni (Hitung Nilai)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kehadiran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tugas"
        '
        'txtTugas
        '
        Me.txtTugas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTugas.Location = New System.Drawing.Point(189, 113)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(100, 30)
        Me.txtTugas.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "UTS"
        '
        'txtUts
        '
        Me.txtUts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUts.Location = New System.Drawing.Point(189, 206)
        Me.txtUts.Name = "txtUts"
        Me.txtUts.Size = New System.Drawing.Size(100, 30)
        Me.txtUts.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(54, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quiz"
        '
        'txtQuiz
        '
        Me.txtQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuiz.Location = New System.Drawing.Point(189, 161)
        Me.txtQuiz.Name = "txtQuiz"
        Me.txtQuiz.Size = New System.Drawing.Size(100, 30)
        Me.txtQuiz.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "UAS"
        '
        'txtUas
        '
        Me.txtUas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUas.Location = New System.Drawing.Point(189, 252)
        Me.txtUas.Name = "txtUas"
        Me.txtUas.Size = New System.Drawing.Size(100, 30)
        Me.txtUas.TabIndex = 9
        '
        'buttonHitung
        '
        Me.buttonHitung.BackColor = System.Drawing.SystemColors.ControlDark
        Me.buttonHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonHitung.Location = New System.Drawing.Point(59, 306)
        Me.buttonHitung.Name = "buttonHitung"
        Me.buttonHitung.Size = New System.Drawing.Size(230, 49)
        Me.buttonHitung.TabIndex = 11
        Me.buttonHitung.Text = "Hitung Nilai Akhir"
        Me.buttonHitung.UseVisualStyleBackColor = False
        '
        'txtNilaiAkhir
        '
        Me.txtNilaiAkhir.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNilaiAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNilaiAkhir.Location = New System.Drawing.Point(59, 372)
        Me.txtNilaiAkhir.Multiline = True
        Me.txtNilaiAkhir.Name = "txtNilaiAkhir"
        Me.txtNilaiAkhir.ReadOnly = True
        Me.txtNilaiAkhir.Size = New System.Drawing.Size(230, 41)
        Me.txtNilaiAkhir.TabIndex = 12
        Me.txtNilaiAkhir.Text = "...."
        Me.txtNilaiAkhir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TugasHitungNilaiAkhir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(377, 450)
        Me.Controls.Add(Me.txtNilaiAkhir)
        Me.Controls.Add(Me.buttonHitung)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUts)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQuiz)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTugas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Judul)
        Me.Controls.Add(Me.txtKehadiran)
        Me.Name = "TugasHitungNilaiAkhir"
        Me.Text = "TugasHitungNilaiAkhir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtKehadiran As TextBox
    Friend WithEvents Judul As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTugas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUts As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtQuiz As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUas As TextBox
    Friend WithEvents buttonHitung As Button
    Friend WithEvents txtNilaiAkhir As TextBox
End Class
