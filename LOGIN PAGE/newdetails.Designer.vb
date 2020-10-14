<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newdetails
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.txtNewPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtNewUsername = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(38, 164)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(92, 19)
        Me.MaterialLabel2.TabIndex = 12
        Me.MaterialLabel2.Text = "PASSWORD:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(38, 76)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(93, 19)
        Me.MaterialLabel1.TabIndex = 11
        Me.MaterialLabel1.Text = "USERNAME:"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Depth = 0
        Me.txtNewPassword.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Hint = ""
        Me.txtNewPassword.Location = New System.Drawing.Point(38, 200)
        Me.txtNewPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPassword.SelectedText = ""
        Me.txtNewPassword.SelectionLength = 0
        Me.txtNewPassword.SelectionStart = 0
        Me.txtNewPassword.Size = New System.Drawing.Size(286, 23)
        Me.txtNewPassword.TabIndex = 10
        Me.txtNewPassword.UseSystemPasswordChar = False
        '
        'txtNewUsername
        '
        Me.txtNewUsername.Depth = 0
        Me.txtNewUsername.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUsername.Hint = ""
        Me.txtNewUsername.Location = New System.Drawing.Point(38, 113)
        Me.txtNewUsername.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNewUsername.SelectedText = ""
        Me.txtNewUsername.SelectionLength = 0
        Me.txtNewUsername.SelectionStart = 0
        Me.txtNewUsername.Size = New System.Drawing.Size(286, 23)
        Me.txtNewUsername.TabIndex = 9
        Me.txtNewUsername.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(42, 257)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(128, 43)
        Me.MaterialRaisedButton1.TabIndex = 13
        Me.MaterialRaisedButton1.Text = "Update Details"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'newdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 312)
        Me.Controls.Add(Me.MaterialRaisedButton1)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.txtNewUsername)
        Me.Name = "newdetails"
        Me.Text = "Updating New Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents txtNewPassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtNewUsername As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
End Class
