﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblPermissao = New System.Windows.Forms.Label()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.btnImpirmir = New System.Windows.Forms.Button()
        Me.cboPermissao = New System.Windows.Forms.ComboBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.dgvUsuario = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.permissao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpListagem = New System.Windows.Forms.TabPage()
        Me.tpCadastro = New System.Windows.Forms.TabPage()
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tpListagem.SuspendLayout()
        Me.tpCadastro.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(-21, -244)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(1388, 22)
        Me.txtDescricao.TabIndex = 74
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(-183, -244)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(1388, 22)
        Me.txtCodigo.TabIndex = 73
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(69, -156)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(1388, 22)
        Me.txtTipo.TabIndex = 77
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(357, -244)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(1388, 22)
        Me.txtValor.TabIndex = 75
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(-187, -176)
        Me.lblModelo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(53, 16)
        Me.lblModelo.TabIndex = 71
        Me.lblModelo.Text = "Modelo"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(65, -176)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(35, 16)
        Me.lblTipo.TabIndex = 72
        Me.lblTipo.Text = "Tipo"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(-183, -156)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(1388, 22)
        Me.txtModelo.TabIndex = 76
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(353, -263)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(39, 16)
        Me.lblValor.TabIndex = 69
        Me.lblValor.Text = "Valor"
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(-25, -263)
        Me.lblDescricao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(69, 16)
        Me.lblDescricao.TabIndex = 70
        Me.lblDescricao.Text = "Descrição"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(-187, -263)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblCodigo.TabIndex = 68
        Me.lblCodigo.Text = "Código"
        '
        'lblPermissao
        '
        Me.lblPermissao.AutoSize = True
        Me.lblPermissao.Location = New System.Drawing.Point(482, 7)
        Me.lblPermissao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPermissao.Name = "lblPermissao"
        Me.lblPermissao.Size = New System.Drawing.Size(72, 16)
        Me.lblPermissao.TabIndex = 81
        Me.lblPermissao.Text = "Permissão"
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.document
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(120, 466)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(123, 54)
        Me.btnNovo.TabIndex = 8
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(108, 29)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(369, 22)
        Me.txtUsuario.TabIndex = 84
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(18, 29)
        Me.txtCod.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(83, 22)
        Me.txtCod.TabIndex = 83
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(722, 29)
        Me.txtSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(124, 22)
        Me.txtSenha.TabIndex = 85
        '
        'btnImpirmir
        '
        Me.btnImpirmir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.print_view
        Me.btnImpirmir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImpirmir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImpirmir.Location = New System.Drawing.Point(775, 466)
        Me.btnImpirmir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(123, 54)
        Me.btnImpirmir.TabIndex = 7
        Me.btnImpirmir.Text = "Imprimir"
        Me.btnImpirmir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImpirmir.UseVisualStyleBackColor = True
        '
        'cboPermissao
        '
        Me.cboPermissao.FormattingEnabled = True
        Me.cboPermissao.Location = New System.Drawing.Point(484, 27)
        Me.cboPermissao.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPermissao.Name = "cboPermissao"
        Me.cboPermissao.Size = New System.Drawing.Size(228, 24)
        Me.cboPermissao.TabIndex = 82
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(513, 466)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(123, 54)
        Me.btnExcluir.TabIndex = 5
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.binoculars
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(644, 466)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(123, 54)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.doc_info
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(382, 466)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(123, 54)
        Me.btnAlterar.TabIndex = 3
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.external_hd
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(251, 466)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(123, 54)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'dgvUsuario
        '
        Me.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nome, Me.permissao})
        Me.dgvUsuario.Location = New System.Drawing.Point(4, 7)
        Me.dgvUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvUsuario.Name = "dgvUsuario"
        Me.dgvUsuario.RowHeadersWidth = 51
        Me.dgvUsuario.Size = New System.Drawing.Size(986, 404)
        Me.dgvUsuario.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.Width = 125
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.MinimumWidth = 6
        Me.nome.Name = "nome"
        Me.nome.Width = 125
        '
        'permissao
        '
        Me.permissao.HeaderText = "Permissão"
        Me.permissao.MinimumWidth = 6
        Me.permissao.Name = "permissao"
        Me.permissao.Width = 125
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(718, 7)
        Me.lblSenha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(46, 16)
        Me.lblSenha.TabIndex = 79
        Me.lblSenha.Text = "Senha"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(104, 10)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(44, 16)
        Me.lblNome.TabIndex = 80
        Me.lblNome.Text = "Nome"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Location = New System.Drawing.Point(12, 10)
        Me.lblCod.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(51, 16)
        Me.lblCod.TabIndex = 78
        Me.lblCod.Text = "Código"
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpListagem)
        Me.TabControl1.Controls.Add(Me.tpCadastro)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1005, 447)
        Me.TabControl1.TabIndex = 86
        '
        'tpListagem
        '
        Me.tpListagem.Controls.Add(Me.dgvUsuario)
        Me.tpListagem.Location = New System.Drawing.Point(4, 25)
        Me.tpListagem.Name = "tpListagem"
        Me.tpListagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListagem.Size = New System.Drawing.Size(997, 418)
        Me.tpListagem.TabIndex = 0
        Me.tpListagem.Text = "Listagem"
        Me.tpListagem.UseVisualStyleBackColor = True
        '
        'tpCadastro
        '
        Me.tpCadastro.Controls.Add(Me.cboPermissao)
        Me.tpCadastro.Controls.Add(Me.txtSenha)
        Me.tpCadastro.Controls.Add(Me.lblPermissao)
        Me.tpCadastro.Controls.Add(Me.lblCod)
        Me.tpCadastro.Controls.Add(Me.lblSenha)
        Me.tpCadastro.Controls.Add(Me.lblNome)
        Me.tpCadastro.Controls.Add(Me.txtCod)
        Me.tpCadastro.Controls.Add(Me.txtUsuario)
        Me.tpCadastro.Location = New System.Drawing.Point(4, 25)
        Me.tpCadastro.Name = "tpCadastro"
        Me.tpCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCadastro.Size = New System.Drawing.Size(997, 418)
        Me.tpCadastro.TabIndex = 1
        Me.tpCadastro.Text = "Cadastro"
        Me.tpCadastro.UseVisualStyleBackColor = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 543)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnImpirmir)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblDescricao)
        Me.Controls.Add(Me.lblCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Usuario"
        CType(Me.dgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tpListagem.ResumeLayout(False)
        Me.tpCadastro.ResumeLayout(False)
        Me.tpCadastro.PerformLayout()
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
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents btnImpirmir As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents dgvUsuario As System.Windows.Forms.DataGridView
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpListagem As TabPage
    Friend WithEvents tpCadastro As TabPage
End Class
