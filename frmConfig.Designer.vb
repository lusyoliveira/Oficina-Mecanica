<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
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
        Me.gpbConfig = New System.Windows.Forms.GroupBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.chkEsconde = New System.Windows.Forms.CheckBox()
        Me.gpbConfig.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbConfig
        '
        Me.gpbConfig.Controls.Add(Me.btnSalvar)
        Me.gpbConfig.Controls.Add(Me.btnAlterar)
        Me.gpbConfig.Controls.Add(Me.Label1)
        Me.gpbConfig.Controls.Add(Me.txtCliente)
        Me.gpbConfig.Controls.Add(Me.chkEsconde)
        Me.gpbConfig.Location = New System.Drawing.Point(13, 13)
        Me.gpbConfig.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbConfig.Name = "gpbConfig"
        Me.gpbConfig.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gpbConfig.Size = New System.Drawing.Size(615, 255)
        Me.gpbConfig.TabIndex = 0
        Me.gpbConfig.TabStop = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(347, 155)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(209, 54)
        Me.btnSalvar.TabIndex = 6
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(49, 155)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(209, 54)
        Me.btnAlterar.TabIndex = 5
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cliente"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(47, 58)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(373, 22)
        Me.txtCliente.TabIndex = 8
        '
        'chkEsconde
        '
        Me.chkEsconde.AutoSize = True
        Me.chkEsconde.Location = New System.Drawing.Point(47, 110)
        Me.chkEsconde.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkEsconde.Name = "chkEsconde"
        Me.chkEsconde.Size = New System.Drawing.Size(185, 20)
        Me.chkEsconde.TabIndex = 7
        Me.chkEsconde.Text = "Esconder opções inativas"
        Me.chkEsconde.UseVisualStyleBackColor = True
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 292)
        Me.Controls.Add(Me.gpbConfig)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmConfig"
        Me.Text = "Configurações"
        Me.gpbConfig.ResumeLayout(False)
        Me.gpbConfig.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbConfig As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents chkEsconde As System.Windows.Forms.CheckBox
End Class
