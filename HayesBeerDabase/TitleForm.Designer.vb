<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TitleForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TitleForm))
        Me.AddCompanyBtn = New System.Windows.Forms.Button()
        Me.AddProductBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.DatabaseBtn = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.AboutBtn = New System.Windows.Forms.Button()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddCompanyBtn
        '
        Me.AddCompanyBtn.Location = New System.Drawing.Point(63, 151)
        Me.AddCompanyBtn.Name = "AddCompanyBtn"
        Me.AddCompanyBtn.Size = New System.Drawing.Size(166, 23)
        Me.AddCompanyBtn.TabIndex = 0
        Me.AddCompanyBtn.TabStop = False
        Me.AddCompanyBtn.Text = "Add Company"
        Me.AddCompanyBtn.UseVisualStyleBackColor = True
        '
        'AddProductBtn
        '
        Me.AddProductBtn.Location = New System.Drawing.Point(63, 180)
        Me.AddProductBtn.Name = "AddProductBtn"
        Me.AddProductBtn.Size = New System.Drawing.Size(166, 23)
        Me.AddProductBtn.TabIndex = 1
        Me.AddProductBtn.TabStop = False
        Me.AddProductBtn.Text = "Add Product"
        Me.AddProductBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(63, 238)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(166, 23)
        Me.ExitBtn.TabIndex = 2
        Me.ExitBtn.TabStop = False
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'DatabaseBtn
        '
        Me.DatabaseBtn.Location = New System.Drawing.Point(63, 209)
        Me.DatabaseBtn.Name = "DatabaseBtn"
        Me.DatabaseBtn.Size = New System.Drawing.Size(166, 23)
        Me.DatabaseBtn.TabIndex = 3
        Me.DatabaseBtn.TabStop = False
        Me.DatabaseBtn.Text = "Database"
        Me.DatabaseBtn.UseVisualStyleBackColor = True
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(35, 7)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(218, 138)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.LogoPictureBox.TabIndex = 4
        Me.LogoPictureBox.TabStop = False
        '
        'AboutBtn
        '
        Me.AboutBtn.BackColor = System.Drawing.SystemColors.Menu
        Me.AboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AboutBtn.ForeColor = System.Drawing.SystemColors.Menu
        Me.AboutBtn.Image = CType(resources.GetObject("AboutBtn.Image"), System.Drawing.Image)
        Me.AboutBtn.Location = New System.Drawing.Point(243, 7)
        Me.AboutBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.AboutBtn.Name = "AboutBtn"
        Me.AboutBtn.Size = New System.Drawing.Size(32, 31)
        Me.AboutBtn.TabIndex = 5
        Me.AboutBtn.TabStop = False
        Me.AboutBtn.UseVisualStyleBackColor = False
        '
        'TitleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 273)
        Me.Controls.Add(Me.AboutBtn)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.DatabaseBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.AddProductBtn)
        Me.Controls.Add(Me.AddCompanyBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TitleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hayes' Beer Da'base!"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddCompanyBtn As System.Windows.Forms.Button
    Friend WithEvents AddProductBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents DatabaseBtn As System.Windows.Forms.Button
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents AboutBtn As System.Windows.Forms.Button
End Class
