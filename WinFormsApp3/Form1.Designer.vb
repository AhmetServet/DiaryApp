<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.diaryTextBox = New System.Windows.Forms.RichTextBox()
        Me.diaryList = New System.Windows.Forms.ComboBox()
        Me.diaryName = New System.Windows.Forms.TextBox()
        Me.directoryLabel = New System.Windows.Forms.Label()
        Me.newDiary = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Window
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Location = New System.Drawing.Point(703, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 32)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Kaydet"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Window
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.Location = New System.Drawing.Point(703, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Sil"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Window
        Me.Button4.Location = New System.Drawing.Point(704, 413)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 25)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Çıkış"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 423)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Karakter Sayısı:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 423)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "0"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Window
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.Location = New System.Drawing.Point(704, 171)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(30, 33)
        Me.Button5.TabIndex = 27
        Me.Button5.Text = "A"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Window
        Me.Button6.Location = New System.Drawing.Point(731, 171)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(30, 33)
        Me.Button6.TabIndex = 28
        Me.Button6.Text = "A"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Window
        Me.Button7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button7.Location = New System.Drawing.Point(704, 210)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(28, 25)
        Me.Button7.TabIndex = 29
        Me.Button7.Text = "K"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SaveFileDialog1
        '
        '
        'diaryTextBox
        '
        Me.diaryTextBox.Location = New System.Drawing.Point(26, 36)
        Me.diaryTextBox.Name = "diaryTextBox"
        Me.diaryTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.diaryTextBox.Size = New System.Drawing.Size(661, 378)
        Me.diaryTextBox.TabIndex = 22
        Me.diaryTextBox.Text = ""
        '
        'diaryList
        '
        Me.diaryList.FormattingEnabled = True
        Me.diaryList.Location = New System.Drawing.Point(26, 7)
        Me.diaryList.Name = "diaryList"
        Me.diaryList.Size = New System.Drawing.Size(175, 23)
        Me.diaryList.TabIndex = 20
        '
        'diaryName
        '
        Me.diaryName.Location = New System.Drawing.Point(207, 7)
        Me.diaryName.Name = "diaryName"
        Me.diaryName.Size = New System.Drawing.Size(480, 23)
        Me.diaryName.TabIndex = 21
        '
        'directoryLabel
        '
        Me.directoryLabel.AutoSize = True
        Me.directoryLabel.Location = New System.Drawing.Point(169, 423)
        Me.directoryLabel.Name = "directoryLabel"
        Me.directoryLabel.Size = New System.Drawing.Size(0, 15)
        Me.directoryLabel.TabIndex = 13
        '
        'newDiary
        '
        Me.newDiary.Location = New System.Drawing.Point(704, 36)
        Me.newDiary.Name = "newDiary"
        Me.newDiary.Size = New System.Drawing.Size(74, 32)
        Me.newDiary.TabIndex = 25
        Me.newDiary.Text = "Yeni"
        Me.newDiary.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.newDiary)
        Me.Controls.Add(Me.directoryLabel)
        Me.Controls.Add(Me.diaryName)
        Me.Controls.Add(Me.diaryList)
        Me.Controls.Add(Me.diaryTextBox)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diary App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents diaryTextBox As RichTextBox
    Friend WithEvents diaryList As ComboBox
    Friend WithEvents diaryName As TextBox
    Friend WithEvents directoryLabel As Label
    Friend WithEvents newDiary As Button
End Class
