<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txtloguser = New System.Windows.Forms.TextBox()
        Me.txtlogpw = New System.Windows.Forms.TextBox()
        Me.btn_Login = New System.Windows.Forms.Button()
        Me.btnlogClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblrole = New System.Windows.Forms.Label()
        Me.lblattempts = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'txtloguser
        '
        Me.txtloguser.Location = New System.Drawing.Point(162, 71)
        Me.txtloguser.Name = "txtloguser"
        Me.txtloguser.Size = New System.Drawing.Size(164, 20)
        Me.txtloguser.TabIndex = 5
        '
        'txtlogpw
        '
        Me.txtlogpw.Location = New System.Drawing.Point(162, 134)
        Me.txtlogpw.Name = "txtlogpw"
        Me.txtlogpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtlogpw.Size = New System.Drawing.Size(164, 20)
        Me.txtlogpw.TabIndex = 6
        '
        'btn_Login
        '
        Me.btn_Login.Location = New System.Drawing.Point(143, 274)
        Me.btn_Login.Name = "btn_Login"
        Me.btn_Login.Size = New System.Drawing.Size(75, 23)
        Me.btn_Login.TabIndex = 7
        Me.btn_Login.Text = "Login"
        Me.btn_Login.UseVisualStyleBackColor = True
        '
        'btnlogClear
        '
        Me.btnlogClear.Location = New System.Drawing.Point(251, 274)
        Me.btnlogClear.Name = "btnlogClear"
        Me.btnlogClear.Size = New System.Drawing.Size(75, 23)
        Me.btnlogClear.TabIndex = 8
        Me.btnlogClear.Text = "Clear"
        Me.btnlogClear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(77, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Role"
        '
        'lblrole
        '
        Me.lblrole.AutoSize = True
        Me.lblrole.Location = New System.Drawing.Point(159, 181)
        Me.lblrole.Name = "lblrole"
        Me.lblrole.Size = New System.Drawing.Size(0, 13)
        Me.lblrole.TabIndex = 10
        '
        'lblattempts
        '
        Me.lblattempts.AutoSize = True
        Me.lblattempts.Location = New System.Drawing.Point(159, 227)
        Me.lblattempts.Name = "lblattempts"
        Me.lblattempts.Size = New System.Drawing.Size(13, 13)
        Me.lblattempts.TabIndex = 12
        Me.lblattempts.Text = "3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(77, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Attempts"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 397)
        Me.Controls.Add(Me.lblattempts)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblrole)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnlogClear)
        Me.Controls.Add(Me.btn_Login)
        Me.Controls.Add(Me.txtlogpw)
        Me.Controls.Add(Me.txtloguser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtloguser As TextBox
    Friend WithEvents txtlogpw As TextBox
    Friend WithEvents btn_Login As Button
    Friend WithEvents btnlogClear As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblrole As Label
    Friend WithEvents lblattempts As Label
    Friend WithEvents Label6 As Label
End Class
