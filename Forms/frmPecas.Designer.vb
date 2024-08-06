<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPecas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPecas))
        Me.btnImpirmir = New System.Windows.Forms.Button()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.lblDescricao = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.dgvPeca = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpListagem = New System.Windows.Forms.TabPage()
        Me.tpCadastro = New System.Windows.Forms.TabPage()
        CType(Me.dgvPeca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tpListagem.SuspendLayout()
        Me.tpCadastro.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnImpirmir
        '
        Me.btnImpirmir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.print_view
        Me.btnImpirmir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImpirmir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImpirmir.Location = New System.Drawing.Point(765, 482)
        Me.btnImpirmir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(123, 54)
        Me.btnImpirmir.TabIndex = 7
        Me.btnImpirmir.Text = "Imprimir"
        Me.btnImpirmir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImpirmir.UseVisualStyleBackColor = True
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(692, 29)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(260, 22)
        Me.txtModelo.TabIndex = 64
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(557, 9)
        Me.lblValor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(39, 16)
        Me.lblValor.TabIndex = 56
        Me.lblValor.Text = "Valor"
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(503, 482)
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
        Me.btnConsultar.Location = New System.Drawing.Point(634, 482)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(123, 54)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(109, 9)
        Me.lblDescricao.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(69, 16)
        Me.lblDescricao.TabIndex = 57
        Me.lblDescricao.Text = "Descrição"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(19, 9)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblCodigo.TabIndex = 55
        Me.lblCodigo.Text = "Código"
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.document
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(110, 482)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(123, 54)
        Me.btnNovo.TabIndex = 8
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(688, 9)
        Me.lblModelo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(53, 16)
        Me.lblModelo.TabIndex = 58
        Me.lblModelo.Text = "Modelo"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(112, 29)
        Me.txtDescricao.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(441, 22)
        Me.txtDescricao.TabIndex = 62
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.doc_info
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(372, 482)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(123, 54)
        Me.btnAlterar.TabIndex = 3
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(22, 29)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(83, 22)
        Me.txtCodigo.TabIndex = 61
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(560, 29)
        Me.txtValor.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(124, 22)
        Me.txtValor.TabIndex = 63
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.external_hd
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(241, 482)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(123, 54)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(22, 75)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(173, 22)
        Me.txtTipo.TabIndex = 65
        '
        'dgvPeca
        '
        Me.dgvPeca.AllowUserToAddRows = False
        Me.dgvPeca.AllowUserToDeleteRows = False
        Me.dgvPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPeca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.descricao, Me.valor, Me.modelo, Me.tipo})
        Me.dgvPeca.Location = New System.Drawing.Point(7, 7)
        Me.dgvPeca.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPeca.Name = "dgvPeca"
        Me.dgvPeca.ReadOnly = True
        Me.dgvPeca.RowHeadersWidth = 51
        Me.dgvPeca.Size = New System.Drawing.Size(955, 416)
        Me.dgvPeca.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 125
        '
        'descricao
        '
        Me.descricao.HeaderText = "Descrição"
        Me.descricao.MinimumWidth = 6
        Me.descricao.Name = "descricao"
        Me.descricao.ReadOnly = True
        Me.descricao.Width = 125
        '
        'valor
        '
        Me.valor.HeaderText = "Valor"
        Me.valor.MinimumWidth = 6
        Me.valor.Name = "valor"
        Me.valor.ReadOnly = True
        Me.valor.Width = 125
        '
        'modelo
        '
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.MinimumWidth = 6
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        Me.modelo.Width = 125
        '
        'tipo
        '
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.MinimumWidth = 6
        Me.tipo.Name = "tipo"
        Me.tipo.ReadOnly = True
        Me.tipo.Width = 125
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(19, 55)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(35, 16)
        Me.lblTipo.TabIndex = 60
        Me.lblTipo.Text = "Tipo"
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
        Me.TabControl1.Size = New System.Drawing.Size(977, 459)
        Me.TabControl1.TabIndex = 66
        '
        'tpListagem
        '
        Me.tpListagem.Controls.Add(Me.dgvPeca)
        Me.tpListagem.Location = New System.Drawing.Point(4, 25)
        Me.tpListagem.Name = "tpListagem"
        Me.tpListagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListagem.Size = New System.Drawing.Size(969, 430)
        Me.tpListagem.TabIndex = 0
        Me.tpListagem.Text = "Listagem"
        Me.tpListagem.UseVisualStyleBackColor = True
        '
        'tpCadastro
        '
        Me.tpCadastro.Controls.Add(Me.txtModelo)
        Me.tpCadastro.Controls.Add(Me.lblValor)
        Me.tpCadastro.Controls.Add(Me.lblTipo)
        Me.tpCadastro.Controls.Add(Me.lblDescricao)
        Me.tpCadastro.Controls.Add(Me.txtTipo)
        Me.tpCadastro.Controls.Add(Me.lblCodigo)
        Me.tpCadastro.Controls.Add(Me.txtValor)
        Me.tpCadastro.Controls.Add(Me.lblModelo)
        Me.tpCadastro.Controls.Add(Me.txtCodigo)
        Me.tpCadastro.Controls.Add(Me.txtDescricao)
        Me.tpCadastro.Location = New System.Drawing.Point(4, 25)
        Me.tpCadastro.Name = "tpCadastro"
        Me.tpCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCadastro.Size = New System.Drawing.Size(969, 430)
        Me.tpCadastro.TabIndex = 1
        Me.tpCadastro.Text = "Cadastro"
        Me.tpCadastro.UseVisualStyleBackColor = True
        '
        'frmPecas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 558)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnImpirmir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnExcluir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPecas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Peças"
        CType(Me.dgvPeca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tpListagem.ResumeLayout(False)
        Me.tpCadastro.ResumeLayout(False)
        Me.tpCadastro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImpirmir As System.Windows.Forms.Button
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents dgvPeca As System.Windows.Forms.DataGridView
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descricao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpListagem As TabPage
    Friend WithEvents tpCadastro As TabPage
End Class
