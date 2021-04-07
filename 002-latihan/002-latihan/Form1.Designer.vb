<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frlatihan1
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
        Me.lblNim234 = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblKelamin = New System.Windows.Forms.Label()
        Me.lblAlamat = New System.Windows.Forms.Label()
        Me.lblKota = New System.Windows.Forms.Label()
        Me.txtNim234 = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtKelamin = New System.Windows.Forms.TextBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.btList = New System.Windows.Forms.Button()
        Me.btClear = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNim234
        '
        Me.lblNim234.AutoSize = True
        Me.lblNim234.Location = New System.Drawing.Point(45, 43)
        Me.lblNim234.Name = "lblNim234"
        Me.lblNim234.Size = New System.Drawing.Size(32, 17)
        Me.lblNim234.TabIndex = 0
        Me.lblNim234.Text = "Nim"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(45, 75)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(45, 17)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "Nama"
        '
        'lblKelamin
        '
        Me.lblKelamin.AutoSize = True
        Me.lblKelamin.Location = New System.Drawing.Point(45, 110)
        Me.lblKelamin.Name = "lblKelamin"
        Me.lblKelamin.Size = New System.Drawing.Size(58, 17)
        Me.lblKelamin.TabIndex = 2
        Me.lblKelamin.Text = "Kelamin"
        '
        'lblAlamat
        '
        Me.lblAlamat.AutoSize = True
        Me.lblAlamat.Location = New System.Drawing.Point(45, 146)
        Me.lblAlamat.Name = "lblAlamat"
        Me.lblAlamat.Size = New System.Drawing.Size(51, 17)
        Me.lblAlamat.TabIndex = 3
        Me.lblAlamat.Text = "Alamat"
        '
        'lblKota
        '
        Me.lblKota.AutoSize = True
        Me.lblKota.Location = New System.Drawing.Point(45, 233)
        Me.lblKota.Name = "lblKota"
        Me.lblKota.Size = New System.Drawing.Size(37, 17)
        Me.lblKota.TabIndex = 4
        Me.lblKota.Text = "Kota"
        '
        'txtNim234
        '
        Me.txtNim234.Location = New System.Drawing.Point(324, 40)
        Me.txtNim234.Name = "txtNim234"
        Me.txtNim234.Size = New System.Drawing.Size(319, 22)
        Me.txtNim234.TabIndex = 5
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(324, 72)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(319, 22)
        Me.txtNama.TabIndex = 6
        '
        'txtKelamin
        '
        Me.txtKelamin.Location = New System.Drawing.Point(324, 107)
        Me.txtKelamin.Name = "txtKelamin"
        Me.txtKelamin.Size = New System.Drawing.Size(319, 22)
        Me.txtKelamin.TabIndex = 7
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(324, 143)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAlamat.Size = New System.Drawing.Size(319, 75)
        Me.txtAlamat.TabIndex = 8
        '
        'txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(324, 231)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(319, 22)
        Me.txtKota.TabIndex = 9
        '
        'btList
        '
        Me.btList.Location = New System.Drawing.Point(348, 285)
        Me.btList.Name = "btList"
        Me.btList.Size = New System.Drawing.Size(75, 23)
        Me.btList.TabIndex = 10
        Me.btList.Text = "List"
        Me.btList.UseVisualStyleBackColor = True
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(442, 285)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(75, 23)
        Me.btClear.TabIndex = 11
        Me.btClear.Text = "Clear"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(535, 285)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(75, 23)
        Me.btExit.TabIndex = 12
        Me.btExit.Text = "Exit"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'Frlatihan1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 355)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.btList)
        Me.Controls.Add(Me.txtKota)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtKelamin)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNim234)
        Me.Controls.Add(Me.lblKota)
        Me.Controls.Add(Me.lblAlamat)
        Me.Controls.Add(Me.lblKelamin)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNim234)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Frlatihan1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Latihan 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNim234 As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblKelamin As System.Windows.Forms.Label
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents lblKota As System.Windows.Forms.Label
    Friend WithEvents txtNim234 As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtKelamin As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents btList As System.Windows.Forms.Button
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents btExit As System.Windows.Forms.Button

End Class
