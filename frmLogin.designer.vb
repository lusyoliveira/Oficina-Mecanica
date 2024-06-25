<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPermissao = New System.Windows.Forms.Label()
        Me.txtPermissao = New System.Windows.Forms.TextBox()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnEntrar = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.er = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.er, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(819, 123)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblPermissao)
        Me.GroupBox1.Controls.Add(Me.txtPermissao)
        Me.GroupBox1.Controls.Add(Me.btnSair)
        Me.GroupBox1.Controls.Add(Me.btnEntrar)
        Me.GroupBox1.Controls.Add(Me.txtSenha)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.lblSenha)
        Me.GroupBox1.Controls.Add(Me.lblUsuario)
        Me.GroupBox1.Controls.Add(Me.lblCodigo)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 131)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(785, 186)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'lblPermissao
        '
        Me.lblPermissao.AutoSize = True
        Me.lblPermissao.Location = New System.Drawing.Point(586, 19)
        Me.lblPermissao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPermissao.Name = "lblPermissao"
        Me.lblPermissao.Size = New System.Drawing.Size(72, 16)
        Me.lblPermissao.TabIndex = 87
        Me.lblPermissao.Text = "Permissão"
        '
        'txtPermissao
        '
        Me.txtPermissao.Location = New System.Drawing.Point(590, 39)
        Me.txtPermissao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPermissao.Name = "txtPermissao"
        Me.txtPermissao.Size = New System.Drawing.Size(173, 22)
        Me.txtPermissao.TabIndex = 88
        '
        'btnSair
        '
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(435, 94)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(109, 42)
        Me.btnSair.TabIndex = 9
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnEntrar
        '
        Me.btnEntrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntrar.Location = New System.Drawing.Point(253, 94)
        Me.btnEntrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEntrar.Name = "btnEntrar"
        Me.btnEntrar.Size = New System.Drawing.Size(109, 42)
        Me.btnEntrar.TabIndex = 8
        Me.btnEntrar.Text = "Entrar"
        Me.btnEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEntrar.UseVisualStyleBackColor = True
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(394, 39)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(188, 22)
        Me.txtSenha.TabIndex = 7
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(109, 39)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(277, 22)
        Me.txtUsuario.TabIndex = 6
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(23, 39)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(78, 22)
        Me.txtCodigo.TabIndex = 5
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(390, 19)
        Me.lblSenha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(46, 16)
        Me.lblSenha.TabIndex = 4
        Me.lblSenha.Text = "Senha"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(105, 19)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(54, 16)
        Me.lblUsuario.TabIndex = 3
        Me.lblUsuario.Text = "Usuário"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(19, 19)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblCodigo.TabIndex = 2
        Me.lblCodigo.Text = "Código"
        '
        'er
        '
        Me.er.ContainerControl = Me
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(815, 343)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.er, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents er As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnEntrar As System.Windows.Forms.Button
    Friend WithEvents lblPermissao As System.Windows.Forms.Label
    Friend WithEvents txtPermissao As System.Windows.Forms.TextBox

End Class
