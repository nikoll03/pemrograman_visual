<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNim = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtProdi = New System.Windows.Forms.TextBox()
        Me.txtNKehdr = New System.Windows.Forms.TextBox()
        Me.txtNTugas = New System.Windows.Forms.TextBox()
        Me.txtUts = New System.Windows.Forms.TextBox()
        Me.txtUas = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtKtrNim = New System.Windows.Forms.TextBox()
        Me.txtKtrNama = New System.Windows.Forms.TextBox()
        Me.txtKtrProdi = New System.Windows.Forms.TextBox()
        Me.txtKtrAkhir = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtKtrMutu = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "APLIKASI PENENTU NILAI MUTU MAHASISWA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nim"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Prodi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nilai Kehadiran"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(230, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nilai Tugas"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(230, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nilai UTS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(230, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nilai UAS"
        '
        'txtNim
        '
        Me.txtNim.Location = New System.Drawing.Point(75, 44)
        Me.txtNim.Name = "txtNim"
        Me.txtNim.Size = New System.Drawing.Size(100, 20)
        Me.txtNim.TabIndex = 8
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(75, 71)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(124, 20)
        Me.txtNama.TabIndex = 9
        '
        'txtProdi
        '
        Me.txtProdi.Location = New System.Drawing.Point(75, 98)
        Me.txtProdi.Name = "txtProdi"
        Me.txtProdi.Size = New System.Drawing.Size(124, 20)
        Me.txtProdi.TabIndex = 10
        '
        'txtNKehdr
        '
        Me.txtNKehdr.Location = New System.Drawing.Point(313, 45)
        Me.txtNKehdr.Name = "txtNKehdr"
        Me.txtNKehdr.Size = New System.Drawing.Size(63, 20)
        Me.txtNKehdr.TabIndex = 11
        '
        'txtNTugas
        '
        Me.txtNTugas.Location = New System.Drawing.Point(313, 73)
        Me.txtNTugas.Name = "txtNTugas"
        Me.txtNTugas.Size = New System.Drawing.Size(63, 20)
        Me.txtNTugas.TabIndex = 12
        '
        'txtUts
        '
        Me.txtUts.Location = New System.Drawing.Point(313, 100)
        Me.txtUts.Name = "txtUts"
        Me.txtUts.Size = New System.Drawing.Size(63, 20)
        Me.txtUts.TabIndex = 13
        '
        'txtUas
        '
        Me.txtUas.Location = New System.Drawing.Point(313, 126)
        Me.txtUas.Name = "txtUas"
        Me.txtUas.Size = New System.Drawing.Size(63, 20)
        Me.txtUas.TabIndex = 14
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(100, 163)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 15
        Me.btnHitung.Text = "Hitung"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(233, 163)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 23)
        Me.BtnReset.TabIndex = 16
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(88, 209)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Nim"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(292, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Nama"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(88, 253)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Prodi"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(292, 253)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Nialai Akhir"
        '
        'txtKtrNim
        '
        Me.txtKtrNim.Location = New System.Drawing.Point(45, 225)
        Me.txtKtrNim.Name = "txtKtrNim"
        Me.txtKtrNim.Size = New System.Drawing.Size(124, 20)
        Me.txtKtrNim.TabIndex = 21
        '
        'txtKtrNama
        '
        Me.txtKtrNama.Location = New System.Drawing.Point(252, 225)
        Me.txtKtrNama.Name = "txtKtrNama"
        Me.txtKtrNama.Size = New System.Drawing.Size(124, 20)
        Me.txtKtrNama.TabIndex = 22
        '
        'txtKtrProdi
        '
        Me.txtKtrProdi.Location = New System.Drawing.Point(45, 269)
        Me.txtKtrProdi.Name = "txtKtrProdi"
        Me.txtKtrProdi.Size = New System.Drawing.Size(124, 20)
        Me.txtKtrProdi.TabIndex = 23
        '
        'txtKtrAkhir
        '
        Me.txtKtrAkhir.Location = New System.Drawing.Point(252, 269)
        Me.txtKtrAkhir.Name = "txtKtrAkhir"
        Me.txtKtrAkhir.Size = New System.Drawing.Size(124, 20)
        Me.txtKtrAkhir.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(184, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Nilai Mutu"
        '
        'txtKtrMutu
        '
        Me.txtKtrMutu.Location = New System.Drawing.Point(177, 306)
        Me.txtKtrMutu.Name = "txtKtrMutu"
        Me.txtKtrMutu.Size = New System.Drawing.Size(63, 20)
        Me.txtKtrMutu.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(10, 336)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(212, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Niko Lukmanul Hakim_200511120_TIF20C"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.ClientSize = New System.Drawing.Size(411, 358)
        Me.Controls.Add(Me.txtKtrNama)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtKtrMutu)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtKtrAkhir)
        Me.Controls.Add(Me.txtKtrProdi)
        Me.Controls.Add(Me.txtKtrNim)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtUas)
        Me.Controls.Add(Me.txtUts)
        Me.Controls.Add(Me.txtNTugas)
        Me.Controls.Add(Me.txtNKehdr)
        Me.Controls.Add(Me.txtProdi)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNim)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Menghitung Nilai Mutu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNim As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtProdi As TextBox
    Friend WithEvents txtNKehdr As TextBox
    Friend WithEvents txtNTugas As TextBox
    Friend WithEvents txtUts As TextBox
    Friend WithEvents txtUas As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtKtrNim As TextBox
    Friend WithEvents txtKtrNama As TextBox
    Friend WithEvents txtKtrProdi As TextBox
    Friend WithEvents txtKtrAkhir As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtKtrMutu As TextBox
    Friend WithEvents Label14 As Label
End Class
