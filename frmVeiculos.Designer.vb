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
        Me.gpbVeiculos = New System.Windows.Forms.GroupBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnImpirmir = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.Grade = New System.Windows.Forms.DataGridView()
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
        Me.gpbVeiculos.SuspendLayout()
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbVeiculos
        '
        Me.gpbVeiculos.Controls.Add(Me.btnNovo)
        Me.gpbVeiculos.Controls.Add(Me.btnImpirmir)
        Me.gpbVeiculos.Controls.Add(Me.btnSair)
        Me.gpbVeiculos.Controls.Add(Me.btnExcluir)
        Me.gpbVeiculos.Controls.Add(Me.btnConsultar)
        Me.gpbVeiculos.Controls.Add(Me.btnAlterar)
        Me.gpbVeiculos.Controls.Add(Me.btnSalvar)
        Me.gpbVeiculos.Controls.Add(Me.Grade)
        Me.gpbVeiculos.Controls.Add(Me.txtRenavan)
        Me.gpbVeiculos.Controls.Add(Me.txtChassiss)
        Me.gpbVeiculos.Controls.Add(Me.txtCombustivel)
        Me.gpbVeiculos.Controls.Add(Me.txtAno)
        Me.gpbVeiculos.Controls.Add(Me.txtModelo)
        Me.gpbVeiculos.Controls.Add(Me.txtTraco)
        Me.gpbVeiculos.Controls.Add(Me.txtPlacanumero)
        Me.gpbVeiculos.Controls.Add(Me.txtPlacaletra)
        Me.gpbVeiculos.Controls.Add(Me.txtCodigo)
        Me.gpbVeiculos.Controls.Add(Me.lblRenavan)
        Me.gpbVeiculos.Controls.Add(Me.lblChassiss)
        Me.gpbVeiculos.Controls.Add(Me.lblCombustivel)
        Me.gpbVeiculos.Controls.Add(Me.lblAno)
        Me.gpbVeiculos.Controls.Add(Me.lblModelo)
        Me.gpbVeiculos.Controls.Add(Me.lblPlaca)
        Me.gpbVeiculos.Controls.Add(Me.lblCodigo)
        Me.gpbVeiculos.Location = New System.Drawing.Point(13, 13)
        Me.gpbVeiculos.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbVeiculos.Name = "gpbVeiculos"
        Me.gpbVeiculos.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbVeiculos.Size = New System.Drawing.Size(1281, 652)
        Me.gpbVeiculos.TabIndex = 0
        Me.gpbVeiculos.TabStop = False
        '
        'btnNovo
        '
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(1150, 148)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(109, 42)
        Me.btnNovo.TabIndex = 23
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnImpirmir
        '
        Me.btnImpirmir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImpirmir.Location = New System.Drawing.Point(1150, 554)
        Me.btnImpirmir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(109, 42)
        Me.btnImpirmir.TabIndex = 22
        Me.btnImpirmir.Text = "Imprimir"
        Me.btnImpirmir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImpirmir.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(1150, 487)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(109, 42)
        Me.btnSair.TabIndex = 21
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(1150, 342)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(109, 42)
        Me.btnExcluir.TabIndex = 20
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(1150, 415)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(109, 42)
        Me.btnConsultar.TabIndex = 19
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(1150, 274)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(109, 42)
        Me.btnAlterar.TabIndex = 18
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(1150, 210)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(109, 42)
        Me.btnSalvar.TabIndex = 17
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'Grade
        '
        Me.Grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.placaletra, Me.placanumero, Me.modelo, Me.ano, Me.combustivel, Me.chassiss, Me.renavan})
        Me.Grade.Location = New System.Drawing.Point(8, 122)
        Me.Grade.Margin = New System.Windows.Forms.Padding(4)
        Me.Grade.Name = "Grade"
        Me.Grade.RowHeadersWidth = 51
        Me.Grade.Size = New System.Drawing.Size(1125, 497)
        Me.Grade.TabIndex = 16
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.Width = 125
        '
        'placaletra
        '
        Me.placaletra.HeaderText = "Letra da Placa"
        Me.placaletra.MinimumWidth = 6
        Me.placaletra.Name = "placaletra"
        Me.placaletra.Width = 125
        '
        'placanumero
        '
        Me.placanumero.HeaderText = "Número da Placa"
        Me.placanumero.MinimumWidth = 6
        Me.placanumero.Name = "placanumero"
        Me.placanumero.Width = 125
        '
        'modelo
        '
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.MinimumWidth = 6
        Me.modelo.Name = "modelo"
        Me.modelo.Width = 125
        '
        'ano
        '
        Me.ano.HeaderText = "Ano de Fabricação"
        Me.ano.MinimumWidth = 6
        Me.ano.Name = "ano"
        Me.ano.Width = 125
        '
        'combustivel
        '
        Me.combustivel.HeaderText = "Combustivél"
        Me.combustivel.MinimumWidth = 6
        Me.combustivel.Name = "combustivel"
        Me.combustivel.Width = 125
        '
        'chassiss
        '
        Me.chassiss.HeaderText = "Chassiss"
        Me.chassiss.MinimumWidth = 6
        Me.chassiss.Name = "chassiss"
        Me.chassiss.Width = 125
        '
        'renavan
        '
        Me.renavan.HeaderText = "Renavan"
        Me.renavan.MinimumWidth = 6
        Me.renavan.Name = "renavan"
        Me.renavan.Width = 125
        '
        'txtRenavan
        '
        Me.txtRenavan.Location = New System.Drawing.Point(422, 92)
        Me.txtRenavan.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRenavan.Name = "txtRenavan"
        Me.txtRenavan.Size = New System.Drawing.Size(199, 22)
        Me.txtRenavan.TabIndex = 15
        '
        'txtChassiss
        '
        Me.txtChassiss.Location = New System.Drawing.Point(215, 92)
        Me.txtChassiss.Margin = New System.Windows.Forms.Padding(4)
        Me.txtChassiss.Name = "txtChassiss"
        Me.txtChassiss.Size = New System.Drawing.Size(199, 22)
        Me.txtChassiss.TabIndex = 14
        '
        'txtCombustivel
        '
        Me.txtCombustivel.Location = New System.Drawing.Point(8, 92)
        Me.txtCombustivel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCombustivel.Name = "txtCombustivel"
        Me.txtCombustivel.Size = New System.Drawing.Size(199, 22)
        Me.txtCombustivel.TabIndex = 13
        '
        'txtAno
        '
        Me.txtAno.Location = New System.Drawing.Point(448, 43)
        Me.txtAno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAno.Name = "txtAno"
        Me.txtAno.Size = New System.Drawing.Size(124, 22)
        Me.txtAno.TabIndex = 12
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(256, 41)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(184, 22)
        Me.txtModelo.TabIndex = 11
        '
        'txtTraco
        '
        Me.txtTraco.AutoSize = True
        Me.txtTraco.Location = New System.Drawing.Point(164, 43)
        Me.txtTraco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtTraco.Name = "txtTraco"
        Me.txtTraco.Size = New System.Drawing.Size(11, 16)
        Me.txtTraco.TabIndex = 10
        Me.txtTraco.Text = "-"
        '
        'txtPlacanumero
        '
        Me.txtPlacanumero.Location = New System.Drawing.Point(187, 41)
        Me.txtPlacanumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlacanumero.Name = "txtPlacanumero"
        Me.txtPlacanumero.Size = New System.Drawing.Size(61, 22)
        Me.txtPlacanumero.TabIndex = 9
        '
        'txtPlacaletra
        '
        Me.txtPlacaletra.Location = New System.Drawing.Point(95, 41)
        Me.txtPlacaletra.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPlacaletra.Name = "txtPlacaletra"
        Me.txtPlacaletra.Size = New System.Drawing.Size(61, 22)
        Me.txtPlacaletra.TabIndex = 8
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(7, 40)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(80, 22)
        Me.txtCodigo.TabIndex = 7
        '
        'lblRenavan
        '
        Me.lblRenavan.AutoSize = True
        Me.lblRenavan.Location = New System.Drawing.Point(419, 72)
        Me.lblRenavan.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRenavan.Name = "lblRenavan"
        Me.lblRenavan.Size = New System.Drawing.Size(62, 16)
        Me.lblRenavan.TabIndex = 6
        Me.lblRenavan.Text = "Renavan"
        '
        'lblChassiss
        '
        Me.lblChassiss.AutoSize = True
        Me.lblChassiss.Location = New System.Drawing.Point(212, 72)
        Me.lblChassiss.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChassiss.Name = "lblChassiss"
        Me.lblChassiss.Size = New System.Drawing.Size(62, 16)
        Me.lblChassiss.TabIndex = 5
        Me.lblChassiss.Text = "Chassiss"
        '
        'lblCombustivel
        '
        Me.lblCombustivel.AutoSize = True
        Me.lblCombustivel.Location = New System.Drawing.Point(5, 72)
        Me.lblCombustivel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCombustivel.Name = "lblCombustivel"
        Me.lblCombustivel.Size = New System.Drawing.Size(81, 16)
        Me.lblCombustivel.TabIndex = 4
        Me.lblCombustivel.Text = "Combustivél"
        '
        'lblAno
        '
        Me.lblAno.AutoSize = True
        Me.lblAno.Location = New System.Drawing.Point(445, 19)
        Me.lblAno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(122, 16)
        Me.lblAno.TabIndex = 3
        Me.lblAno.Text = "Ano de Fabricação"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(253, 21)
        Me.lblModelo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(53, 16)
        Me.lblModelo.TabIndex = 2
        Me.lblModelo.Text = "Modelo"
        '
        'lblPlaca
        '
        Me.lblPlaca.AutoSize = True
        Me.lblPlaca.Location = New System.Drawing.Point(92, 21)
        Me.lblPlaca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlaca.Name = "lblPlaca"
        Me.lblPlaca.Size = New System.Drawing.Size(42, 16)
        Me.lblPlaca.TabIndex = 1
        Me.lblPlaca.Text = "Placa"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(4, 20)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Código"
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
        'frmVeiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1309, 684)
        Me.Controls.Add(Me.gpbVeiculos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmVeiculos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Veículos"
        Me.gpbVeiculos.ResumeLayout(False)
        Me.gpbVeiculos.PerformLayout()
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpbVeiculos As System.Windows.Forms.GroupBox
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
    Friend WithEvents Grade As System.Windows.Forms.DataGridView
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
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
