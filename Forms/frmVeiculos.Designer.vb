<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVeiculos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVeiculos))
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnImpirmir = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.dgvVeiculos = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.placaletra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.placanumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ano = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.combustivel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chassiss = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.renavan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtRenavan = New System.Windows.Forms.TextBox()
        Me.txtChassiss = New System.Windows.Forms.TextBox()
        Me.txtCombustivel = New System.Windows.Forms.TextBox()
        Me.txtAno = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtTraco = New System.Windows.Forms.Label()
        Me.txtPlacanumero = New System.Windows.Forms.TextBox()
        Me.txtPlacaletra = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblRenavan = New System.Windows.Forms.Label()
        Me.lblChassiss = New System.Windows.Forms.Label()
        Me.lblCombustivel = New System.Windows.Forms.Label()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblPlaca = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpListagem = New System.Windows.Forms.TabPage()
        Me.tpCadastro = New System.Windows.Forms.TabPage()
        CType(Me.dgvVeiculos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tpListagem.SuspendLayout()
        Me.tpCadastro.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.document
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(273, 539)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(109, 55)
        Me.btnNovo.TabIndex = 23
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnImpirmir
        '
        Me.btnImpirmir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.print_view
        Me.btnImpirmir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImpirmir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImpirmir.Location = New System.Drawing.Point(870, 539)
        Me.btnImpirmir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(109, 55)
        Me.btnImpirmir.TabIndex = 22
        Me.btnImpirmir.Text = "Imprimir"
        Me.btnImpirmir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImpirmir.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(624, 539)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(109, 55)
        Me.btnExcluir.TabIndex = 20
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.binoculars
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(741, 539)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(121, 55)
        Me.btnConsultar.TabIndex = 19
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.doc_info
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(507, 539)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(109, 55)
        Me.btnAlterar.TabIndex = 18
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.external_hd
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(390, 539)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(109, 55)
        Me.btnSalvar.TabIndex = 17
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'dgvVeiculos
        '
        Me.dgvVeiculos.AllowUserToAddRows = False
        Me.dgvVeiculos.AllowUserToDeleteRows = False
        Me.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVeiculos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.placaletra, Me.placanumero, Me.modelo, Me.ano, Me.combustivel, Me.chassiss, Me.renavan})
        Me.dgvVeiculos.Location = New System.Drawing.Point(7, 7)
        Me.dgvVeiculos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvVeiculos.Name = "dgvVeiculos"
        Me.dgvVeiculos.ReadOnly = True
        Me.dgvVeiculos.RowHeadersWidth = 51
        Me.dgvVeiculos.Size = New System.Drawing.Size(1177, 477)
        Me.dgvVeiculos.TabIndex = 16
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 125
        '
        'placaletra
        '
        Me.placaletra.HeaderText = "Letra da Placa"
        Me.placaletra.MinimumWidth = 6
        Me.placaletra.Name = "placaletra"
        Me.placaletra.ReadOnly = True
        Me.placaletra.Width = 125
        '
        'placanumero
        '
        Me.placanumero.HeaderText = "Número da Placa"
        Me.placanumero.MinimumWidth = 6
        Me.placanumero.Name = "placanumero"
        Me.placanumero.ReadOnly = True
        Me.placanumero.Width = 125
        '
        'modelo
        '
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.MinimumWidth = 6
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        Me.modelo.Width = 125
        '
        'ano
        '
        Me.ano.HeaderText = "Ano de Fabricação"
        Me.ano.MinimumWidth = 6
        Me.ano.Name = "ano"
        Me.ano.ReadOnly = True
        Me.ano.Width = 125
        '
        'combustivel
        '
        Me.combustivel.HeaderText = "Combustivél"
        Me.combustivel.MinimumWidth = 6
        Me.combustivel.Name = "combustivel"
        Me.combustivel.ReadOnly = True
        Me.combustivel.Width = 125
        '
        'chassiss
        '
        Me.chassiss.HeaderText = "Chassiss"
        Me.chassiss.MinimumWidth = 6
        Me.chassiss.Name = "chassiss"
        Me.chassiss.ReadOnly = True
        Me.chassiss.Width = 125
        '
        'renavan
        '
        Me.renavan.HeaderText = "Renavan"
        Me.renavan.MinimumWidth = 6
        Me.renavan.Name = "renavan"
        Me.renavan.ReadOnly = True
        Me.renavan.Width = 125
        '
        'txtRenavan
        '
        Me.txtRenavan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRenavan.Location = New System.Drawing.Point(1005, 33)
        Me.txtRenavan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRenavan.Name = "txtRenavan"
        Me.txtRenavan.Size = New System.Drawing.Size(164, 22)
        Me.txtRenavan.TabIndex = 15
        '
        'txtChassiss
        '
        Me.txtChassiss.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChassiss.Location = New System.Drawing.Point(798, 33)
        Me.txtChassiss.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChassiss.Name = "txtChassiss"
        Me.txtChassiss.Size = New System.Drawing.Size(199, 22)
        Me.txtChassiss.TabIndex = 14
        '
        'txtCombustivel
        '
        Me.txtCombustivel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCombustivel.Location = New System.Drawing.Point(591, 33)
        Me.txtCombustivel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCombustivel.Name = "txtCombustivel"
        Me.txtCombustivel.Size = New System.Drawing.Size(199, 22)
        Me.txtCombustivel.TabIndex = 13
        '
        'txtAno
        '
        Me.txtAno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAno.Location = New System.Drawing.Point(458, 33)
        Me.txtAno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(124, 22)
        Me.txtAno.TabIndex = 12
        '
        'txtModelo
        '
        Me.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Location = New System.Drawing.Point(266, 31)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(184, 22)
        Me.txtModelo.TabIndex = 11
        '
        'txtTraco
        '
        Me.txtTraco.AutoSize = True
        Me.txtTraco.Location = New System.Drawing.Point(174, 33)
        Me.txtTraco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtTraco.Name = "txtTraco"
        Me.txtTraco.Size = New System.Drawing.Size(11, 16)
        Me.txtTraco.TabIndex = 10
        Me.txtTraco.Text = "-"
        '
        'txtPlacanumero
        '
        Me.txtPlacanumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacanumero.Location = New System.Drawing.Point(193, 30)
        Me.txtPlacanumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlacanumero.Name = "txtPlacanumero"
        Me.txtPlacanumero.Size = New System.Drawing.Size(61, 22)
        Me.txtPlacanumero.TabIndex = 9
        '
        'txtPlacaletra
        '
        Me.txtPlacaletra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlacaletra.Location = New System.Drawing.Point(105, 31)
        Me.txtPlacaletra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlacaletra.Name = "txtPlacaletra"
        Me.txtPlacaletra.Size = New System.Drawing.Size(61, 22)
        Me.txtPlacaletra.TabIndex = 8
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(17, 30)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(80, 22)
        Me.txtCodigo.TabIndex = 7
        '
        'lblRenavan
        '
        Me.lblRenavan.AutoSize = True
        Me.lblRenavan.Location = New System.Drawing.Point(1002, 13)
        Me.lblRenavan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRenavan.Name = "lblRenavan"
        Me.lblRenavan.Size = New System.Drawing.Size(62, 16)
        Me.lblRenavan.TabIndex = 6
        Me.lblRenavan.Text = "Renavan"
        '
        'lblChassiss
        '
        Me.lblChassiss.AutoSize = True
        Me.lblChassiss.Location = New System.Drawing.Point(795, 13)
        Me.lblChassiss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChassiss.Name = "lblChassiss"
        Me.lblChassiss.Size = New System.Drawing.Size(62, 16)
        Me.lblChassiss.TabIndex = 5
        Me.lblChassiss.Text = "Chassiss"
        '
        'lblCombustivel
        '
        Me.lblCombustivel.AutoSize = True
        Me.lblCombustivel.Location = New System.Drawing.Point(588, 13)
        Me.lblCombustivel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCombustivel.Name = "lblCombustivel"
        Me.lblCombustivel.Size = New System.Drawing.Size(81, 16)
        Me.lblCombustivel.TabIndex = 4
        Me.lblCombustivel.Text = "Combustivél"
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.Location = New System.Drawing.Point(455, 13)
        Me.lblAno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(122, 16)
        Me.lblAno.TabIndex = 3
        Me.lblAno.Text = "Ano de Fabricação"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(263, 12)
        Me.lblModelo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(53, 16)
        Me.lblModelo.TabIndex = 2
        Me.lblModelo.Text = "Modelo"
        '
        'lblPlaca
        '
        Me.lblPlaca.AutoSize = True
        Me.lblPlaca.Location = New System.Drawing.Point(105, 12)
        Me.lblPlaca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(42, 16)
        Me.lblPlaca.TabIndex = 1
        Me.lblPlaca.Text = "Placa"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(14, 12)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código"
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
        Me.TabControl1.Size = New System.Drawing.Size(1196, 520)
        Me.TabControl1.TabIndex = 24
        '
        'tpListagem
        '
        Me.tpListagem.Controls.Add(Me.dgvVeiculos)
        Me.tpListagem.Location = New System.Drawing.Point(4, 25)
        Me.tpListagem.Name = "tpListagem"
        Me.tpListagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListagem.Size = New System.Drawing.Size(1188, 491)
        Me.tpListagem.TabIndex = 0
        Me.tpListagem.Text = "Listagem"
        Me.tpListagem.UseVisualStyleBackColor = True
        '
        'tpCadastro
        '
        Me.tpCadastro.Controls.Add(Me.txtRenavan)
        Me.tpCadastro.Controls.Add(Me.txtChassiss)
        Me.tpCadastro.Controls.Add(Me.lblCodigo)
        Me.tpCadastro.Controls.Add(Me.txtCombustivel)
        Me.tpCadastro.Controls.Add(Me.lblPlaca)
        Me.tpCadastro.Controls.Add(Me.txtAno)
        Me.tpCadastro.Controls.Add(Me.lblModelo)
        Me.tpCadastro.Controls.Add(Me.txtModelo)
        Me.tpCadastro.Controls.Add(Me.lblAno)
        Me.tpCadastro.Controls.Add(Me.txtTraco)
        Me.tpCadastro.Controls.Add(Me.lblCombustivel)
        Me.tpCadastro.Controls.Add(Me.txtPlacanumero)
        Me.tpCadastro.Controls.Add(Me.lblChassiss)
        Me.tpCadastro.Controls.Add(Me.txtPlacaletra)
        Me.tpCadastro.Controls.Add(Me.lblRenavan)
        Me.tpCadastro.Controls.Add(Me.txtCodigo)
        Me.tpCadastro.Location = New System.Drawing.Point(4, 25)
        Me.tpCadastro.Name = "tpCadastro"
        Me.tpCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCadastro.Size = New System.Drawing.Size(1188, 491)
        Me.tpCadastro.TabIndex = 1
        Me.tpCadastro.Text = "Cadastro"
        Me.tpCadastro.UseVisualStyleBackColor = True
        '
        'frmVeiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 620)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnImpirmir)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnAlterar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmVeiculos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Veículos"
        CType(Me.dgvVeiculos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tpListagem.ResumeLayout(False)
        Me.tpCadastro.ResumeLayout(False)
        Me.tpCadastro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtRenavan As System.Windows.Forms.TextBox
    Friend WithEvents txtChassiss As System.Windows.Forms.TextBox
    Friend WithEvents txtCombustivel As System.Windows.Forms.TextBox
    Friend WithEvents txtAno As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtTraco As System.Windows.Forms.Label
    Friend WithEvents txtPlacanumero As System.Windows.Forms.TextBox
    Friend WithEvents txtPlacaletra As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblRenavan As System.Windows.Forms.Label
    Friend WithEvents lblChassiss As System.Windows.Forms.Label
    Friend WithEvents lblCombustivel As System.Windows.Forms.Label
    Friend WithEvents lblAno As System.Windows.Forms.Label
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents lblPlaca As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents dgvVeiculos As System.Windows.Forms.DataGridView
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents placaletra As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents placanumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ano As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents combustivel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chassiss As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents renavan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents btnImpirmir As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpListagem As TabPage
    Friend WithEvents tpCadastro As TabPage
End Class
