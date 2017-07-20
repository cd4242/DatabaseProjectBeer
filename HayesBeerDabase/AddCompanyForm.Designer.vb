<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCompanyForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCompanyForm))
        Me.IdLabel = New System.Windows.Forms.Label()
        Me.CompanyIDTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneLabel = New System.Windows.Forms.Label()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.PrimaryContactLabel = New System.Windows.Forms.Label()
        Me.PrimaryContactTextBox = New System.Windows.Forms.TextBox()
        Me.BOHLabel = New System.Windows.Forms.Label()
        Me.BOHTextBox = New System.Windows.Forms.TextBox()
        Me.OutBalLabel = New System.Windows.Forms.Label()
        Me.OutBalTextBox = New System.Windows.Forms.TextBox()
        Me.CreateBtn = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        Me.IdLabel.AutoSize = True
        Me.IdLabel.Location = New System.Drawing.Point(9, 23)
        Me.IdLabel.Name = "IdLabel"
        Me.IdLabel.Size = New System.Drawing.Size(65, 13)
        Me.IdLabel.TabIndex = 0
        Me.IdLabel.Text = "Company ID"
        '
        'CompanyIDTextBox
        '
        Me.CompanyIDTextBox.Location = New System.Drawing.Point(12, 39)
        Me.CompanyIDTextBox.Name = "CompanyIDTextBox"
        Me.CompanyIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CompanyIDTextBox.TabIndex = 1
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(12, 76)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(35, 13)
        Me.NameLabel.TabIndex = 2
        Me.NameLabel.Text = "Name"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(12, 92)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 3
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(12, 125)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(45, 13)
        Me.AddressLabel.TabIndex = 4
        Me.AddressLabel.Text = "Address"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(12, 141)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 5
        '
        'PhoneLabel
        '
        Me.PhoneLabel.AutoSize = True
        Me.PhoneLabel.Location = New System.Drawing.Point(12, 173)
        Me.PhoneLabel.Name = "PhoneLabel"
        Me.PhoneLabel.Size = New System.Drawing.Size(38, 13)
        Me.PhoneLabel.TabIndex = 6
        Me.PhoneLabel.Text = "Phone"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(12, 189)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneTextBox.TabIndex = 7
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Location = New System.Drawing.Point(159, 23)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(32, 13)
        Me.EmailLabel.TabIndex = 8
        Me.EmailLabel.Text = "Email"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Location = New System.Drawing.Point(162, 39)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 9
        '
        'PrimaryContactLabel
        '
        Me.PrimaryContactLabel.AutoSize = True
        Me.PrimaryContactLabel.Location = New System.Drawing.Point(159, 76)
        Me.PrimaryContactLabel.Name = "PrimaryContactLabel"
        Me.PrimaryContactLabel.Size = New System.Drawing.Size(81, 13)
        Me.PrimaryContactLabel.TabIndex = 10
        Me.PrimaryContactLabel.Text = "Primary Contact"
        '
        'PrimaryContactTextBox
        '
        Me.PrimaryContactTextBox.Location = New System.Drawing.Point(162, 92)
        Me.PrimaryContactTextBox.Name = "PrimaryContactTextBox"
        Me.PrimaryContactTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrimaryContactTextBox.TabIndex = 11
        '
        'BOHLabel
        '
        Me.BOHLabel.AutoSize = True
        Me.BOHLabel.Location = New System.Drawing.Point(159, 125)
        Me.BOHLabel.Name = "BOHLabel"
        Me.BOHLabel.Size = New System.Drawing.Size(30, 13)
        Me.BOHLabel.TabIndex = 12
        Me.BOHLabel.Text = "BOH"
        '
        'BOHTextBox
        '
        Me.BOHTextBox.Location = New System.Drawing.Point(162, 141)
        Me.BOHTextBox.Name = "BOHTextBox"
        Me.BOHTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BOHTextBox.TabIndex = 13
        '
        'OutBalLabel
        '
        Me.OutBalLabel.AutoSize = True
        Me.OutBalLabel.Location = New System.Drawing.Point(159, 173)
        Me.OutBalLabel.Name = "OutBalLabel"
        Me.OutBalLabel.Size = New System.Drawing.Size(106, 13)
        Me.OutBalLabel.TabIndex = 14
        Me.OutBalLabel.Text = "Outstanding Balance"
        '
        'OutBalTextBox
        '
        Me.OutBalTextBox.Location = New System.Drawing.Point(162, 189)
        Me.OutBalTextBox.Name = "OutBalTextBox"
        Me.OutBalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OutBalTextBox.TabIndex = 15
        '
        'CreateBtn
        '
        Me.CreateBtn.Location = New System.Drawing.Point(197, 246)
        Me.CreateBtn.Name = "CreateBtn"
        Me.CreateBtn.Size = New System.Drawing.Size(75, 23)
        Me.CreateBtn.TabIndex = 16
        Me.CreateBtn.Text = "Create"
        Me.CreateBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Location = New System.Drawing.Point(12, 246)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 17
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'AddCompanyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 281)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.CreateBtn)
        Me.Controls.Add(Me.OutBalTextBox)
        Me.Controls.Add(Me.OutBalLabel)
        Me.Controls.Add(Me.BOHTextBox)
        Me.Controls.Add(Me.BOHLabel)
        Me.Controls.Add(Me.PrimaryContactTextBox)
        Me.Controls.Add(Me.PrimaryContactLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.PhoneLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.AddressLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.CompanyIDTextBox)
        Me.Controls.Add(Me.IdLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddCompanyForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Company"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdLabel As System.Windows.Forms.Label
    Friend WithEvents CompanyIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PhoneLabel As System.Windows.Forms.Label
    Friend WithEvents PhoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailLabel As System.Windows.Forms.Label
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PrimaryContactLabel As System.Windows.Forms.Label
    Friend WithEvents PrimaryContactTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BOHLabel As System.Windows.Forms.Label
    Friend WithEvents BOHTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OutBalLabel As System.Windows.Forms.Label
    Friend WithEvents OutBalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreateBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
End Class
