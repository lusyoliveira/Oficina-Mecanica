<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.txtDescricao = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtTipo = New System.Windows.Forms.TextBox
        Me.txtValor = New System.Windows.Forms.TextBox
        Me.lblModelo = New System.Windows.Forms.Label
        Me.lblTipo = New System.Windows.Forms.Label
        Me.txtModelo = New System.Windows.Forms.TextBox
        Me.lblValor = New System.Windows.Forms.Label
        Me.lblDescricao = New System.Windows.Forms.Label
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.lblPermissao = New System.Windows.Forms.Label
        Me.btnNovo = New System.Windows.Forms.Button
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.txtCod = New System.Windows.Forms.TextBox
        Me.txtSenha = New System.Windows.Forms.TextBox
        Me.btnImpirmir = New System.Windows.Forms.Button
        Me.gpbUsuarios = New System.Windows.Forms.GroupBox
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.Grade = New System.Windows.Forms.DataGridView
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.permissao = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblSenha = New System.Windows.Forms.Label
        Me.lblCod = New System.Windows.Forms.Label
        Me.lblNome = New System.Windows.Forms.Label
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.cboPermissao = New System.Windows.Forms.ComboBox
        Me.gpbUsuarios.SuspendLayout()
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(-16, -198)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(1042, 20)
        Me.txtDescricao.TabIndex = 74
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(-137, -198)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(1042, 20)
        Me.txtCodigo.TabIndex = 73
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(52, -127)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(1042, 20)
        Me.txtTipo.TabIndex = 77
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(268, -198)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(1042, 20)
        Me.txtValor.TabIndex = 75
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(-140, -143)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(42, 13)
        Me.lblModelo.TabIndex = 71
        Me.lblModelo.Text = "Modelo"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(49, -143)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 72
        Me.lblTipo.Text = "Tipo"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(-137, -127)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(1042, 20)
        Me.txtModelo.TabIndex = 76
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(265, -214)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(31, 13)
        Me.lblValor.TabIndex = 69
        Me.lblValor.Text = "Valor"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(-19, -214)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(55, 13)
        Me.lblDescricao.TabIndex = 70
        Me.lblDescricao.Text = "Descrição"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(-140, -214)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 68
        Me.lblCodigo.Text = "Código"
        '
        'lblPermissao
        '
        Me.lblPermissao.AutoSize = True
        Me.lblPermissao.Location = New System.Drawing.Point(586, 32)
        Me.lblPermissao.Name = "lblPermissao"
        Me.lblPermissao.Size = New System.Drawing.Size(55, 13)
        Me.lblPermissao.TabIndex = 81
        Me.lblPermissao.Text = "Permissão"
        '
        'btnNovo
        '
        Me.btnNovo.Image = Global.Oficina_Mecânica.My.Resources.Resources.mobsync_13
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(692, 147)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(82, 34)
        Me.btnNovo.TabIndex = 8
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(355, 79)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(226, 20)
        Me.txtNome.TabIndex = 84
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(234, 79)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(63, 20)
        Me.txtCod.TabIndex = 83
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(639, 79)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(94, 20)
        Me.txtSenha.TabIndex = 85
        '
        'btnImpirmir
        '
        Me.btnImpirmir.Image = Global.Oficina_Mecânica.My.Resources.Resources.imageres_50
        Me.btnImpirmir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImpirmir.Location = New System.Drawing.Point(692, 477)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(82, 34)
        Me.btnImpirmir.TabIndex = 7
        Me.btnImpirmir.Text = "Imprimir"
        Me.btnImpirmir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImpirmir.UseVisualStyleBackColor = True
        '
        'gpbUsuarios
        '
        Me.gpbUsuarios.Controls.Add(Me.cboPermissao)
        Me.gpbUsuarios.Controls.Add(Me.btnNovo)
        Me.gpbUsuarios.Controls.Add(Me.btnImpirmir)
        Me.gpbUsuarios.Controls.Add(Me.btnSair)
        Me.gpbUsuarios.Controls.Add(Me.btnExcluir)
        Me.gpbUsuarios.Controls.Add(Me.btnConsultar)
        Me.gpbUsuarios.Controls.Add(Me.btnAlterar)
        Me.gpbUsuarios.Controls.Add(Me.btnSalvar)
        Me.gpbUsuarios.Controls.Add(Me.Grade)
        Me.gpbUsuarios.Controls.Add(Me.lblPermissao)
        Me.gpbUsuarios.Location = New System.Drawing.Point(205, 31)
        Me.gpbUsuarios.Name = "gpbUsuarios"
        Me.gpbUsuarios.Size = New System.Drawing.Size(852, 628)
        Me.gpbUsuarios.TabIndex = 88
        Me.gpbUsuarios.TabStop = False
        '
        'btnSair
        '
        Me.btnSair.Image = Global.Oficina_Mecânica.My.Resources.Resources.mobsync_15
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(692, 423)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(82, 34)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Image = Global.Oficina_Mecânica.My.Resources.Resources.imageres_54
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(692, 305)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(82, 34)
        Me.btnExcluir.TabIndex = 5
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = Global.Oficina_Mecânica.My.Resources.Resources.shell32_023
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(692, 364)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(82, 34)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Image = Global.Oficina_Mecânica.My.Resources.Resources.mobsync_19
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(692, 250)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(82, 34)
        Me.btnAlterar.TabIndex = 3
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Image = Global.Oficina_Mecânica.My.Resources.Resources.mobsync_18
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(692, 198)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(82, 34)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Grade
        '
        Me.Grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nome, Me.permissao})
        Me.Grade.Location = New System.Drawing.Point(29, 84)
        Me.Grade.Name = "Grade"
        Me.Grade.Size = New System.Drawing.Size(599, 521)
        Me.Grade.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.Name = "nome"
        '
        'permissao
        '
        Me.permissao.HeaderText = "Permissão"
        Me.permissao.Name = "permissao"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(636, 63)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(38, 13)
        Me.lblSenha.TabIndex = 79
        Me.lblSenha.Text = "Senha"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(231, 63)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(40, 13)
        Me.lblCod.TabIndex = 78
        Me.lblCod.Text = "Código"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(352, 63)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 80
        Me.lblNome.Text = "Nome"
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'cboPermissao
        '
        Me.cboPermissao.FormattingEnabled = True
        Me.cboPermissao.Location = New System.Drawing.Point(589, 48)
        Me.cboPermissao.Name = "cboPermissao"
        Me.cboPermissao.Size = New System.Drawing.Size(172, 21)
        Me.cboPermissao.TabIndex = 82
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 779)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.gpbUsuarios)
        Me.Name = "frmUsuarios"
        Me.Text = "Cadastro de Usuario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gpbUsuarios.ResumeLayout(False)
        Me.gpbUsuarios.PerformLayout()
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblPermissao As System.Windows.Forms.Label
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents btnImpirmir As System.Windows.Forms.Button
    Friend WithEvents gpbUsuarios As System.Windows.Forms.GroupBox
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents Grade As System.Windows.Forms.DataGridView
    Friend WithEvents lblSenha As System.Windows.Forms.Label
    Friend WithEvents lblCod As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents permissao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents cboPermissao As System.Windows.Forms.ComboBox
End Class
