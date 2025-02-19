<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtTugas = New TextBox()
        btnTambah = New Button()
        lstTugas = New ListBox()
        btnHapus = New Button()
        btnSimpan = New Button()
        btnMuat = New Button()
        SuspendLayout()
        ' 
        ' txtTugas
        ' 
        txtTugas.Location = New Point(24, 23)
        txtTugas.Name = "txtTugas"
        txtTugas.PlaceholderText = "Tugas Baru"
        txtTugas.Size = New Size(581, 27)
        txtTugas.TabIndex = 0
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(611, 24)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(137, 29)
        btnTambah.TabIndex = 1
        btnTambah.Text = "Tambah Tugas"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' lstTugas
        ' 
        lstTugas.FormattingEnabled = True
        lstTugas.Location = New Point(24, 58)
        lstTugas.Name = "lstTugas"
        lstTugas.Size = New Size(724, 264)
        lstTugas.TabIndex = 2
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(23, 326)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(210, 29)
        btnHapus.TabIndex = 3
        btnHapus.Text = "Hapus Tugas"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(255, 326)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(239, 29)
        btnSimpan.TabIndex = 4
        btnSimpan.Text = "Simpan Data"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnMuat
        ' 
        btnMuat.Location = New Point(515, 326)
        btnMuat.Name = "btnMuat"
        btnMuat.Size = New Size(233, 29)
        btnMuat.TabIndex = 5
        btnMuat.Text = "Muat Data"
        btnMuat.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(773, 380)
        Controls.Add(btnMuat)
        Controls.Add(btnSimpan)
        Controls.Add(btnHapus)
        Controls.Add(lstTugas)
        Controls.Add(btnTambah)
        Controls.Add(txtTugas)
        Name = "Form1"
        Text = "To Do List"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTugas As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents lstTugas As ListBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnMuat As Button

End Class
