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
        Me.gpbVeiculos = New System.Windows.Forms.GroupBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Grade = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descricao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.gpbVeiculos.SuspendLayout()
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImpirmir
        '
        Me.btnImpirmir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.print_view
        Me.btnImpirmir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImpirmir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImpirmir.Location = New System.Drawing.Point(630, 381)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(82, 34)
        Me.btnImpirmir.TabIndex = 7
        Me.btnImpirmir.Text = "Imprimir"
        Me.btnImpirmir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImpirmir.UseVisualStyleBackColor = True
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(14, 75)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(211, 20)
        Me.txtModelo.TabIndex = 64
        '
        'lblValor
        '
        Me.lblValor.AutoSize = True
        Me.lblValor.Location = New System.Drawing.Point(416, 21)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(31, 13)
        Me.lblValor.TabIndex = 56
        Me.lblValor.Text = "Valor"
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(630, 273)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(82, 34)
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
        Me.btnConsultar.Location = New System.Drawing.Point(630, 332)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(82, 34)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'lblDescricao
        '
        Me.lblDescricao.AutoSize = True
        Me.lblDescricao.Location = New System.Drawing.Point(79, 21)
        Me.lblDescricao.Name = "lblDescricao"
        Me.lblDescricao.Size = New System.Drawing.Size(55, 13)
        Me.lblDescricao.TabIndex = 57
        Me.lblDescricao.Text = "Descrição"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(10, 21)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 55
        Me.lblCodigo.Text = "Código"
        '
        'gpbVeiculos
        '
        Me.gpbVeiculos.Controls.Add(Me.txtModelo)
        Me.gpbVeiculos.Controls.Add(Me.btnNovo)
        Me.gpbVeiculos.Controls.Add(Me.lblValor)
        Me.gpbVeiculos.Controls.Add(Me.btnImpirmir)
        Me.gpbVeiculos.Controls.Add(Me.lblDescricao)
        Me.gpbVeiculos.Controls.Add(Me.lblCodigo)
        Me.gpbVeiculos.Controls.Add(Me.btnExcluir)
        Me.gpbVeiculos.Controls.Add(Me.lblModelo)
        Me.gpbVeiculos.Controls.Add(Me.btnConsultar)
        Me.gpbVeiculos.Controls.Add(Me.txtDescricao)
        Me.gpbVeiculos.Controls.Add(Me.btnAlterar)
        Me.gpbVeiculos.Controls.Add(Me.txtCodigo)
        Me.gpbVeiculos.Controls.Add(Me.txtValor)
        Me.gpbVeiculos.Controls.Add(Me.btnSalvar)
        Me.gpbVeiculos.Controls.Add(Me.txtTipo)
        Me.gpbVeiculos.Controls.Add(Me.Grade)
        Me.gpbVeiculos.Controls.Add(Me.lblTipo)
        Me.gpbVeiculos.Location = New System.Drawing.Point(10, 11)
        Me.gpbVeiculos.Name = "gpbVeiculos"
        Me.gpbVeiculos.Size = New System.Drawing.Size(728, 516)
        Me.gpbVeiculos.TabIndex = 67
        Me.gpbVeiculos.TabStop = False
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.document
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(630, 115)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(82, 34)
        Me.btnNovo.TabIndex = 8
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(10, 58)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(42, 13)
        Me.lblModelo.TabIndex = 58
        Me.lblModelo.Text = "Modelo"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(82, 37)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(332, 20)
        Me.txtDescricao.TabIndex = 62
        '
        'btnAlterar
        '
        Me.btnAlterar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.doc_info
        Me.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(630, 218)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(82, 34)
        Me.btnAlterar.TabIndex = 3
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(14, 37)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(63, 20)
        Me.txtCodigo.TabIndex = 61
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(418, 37)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(94, 20)
        Me.txtValor.TabIndex = 63
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.external_hd
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(630, 166)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(82, 34)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(230, 75)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(131, 20)
        Me.txtTipo.TabIndex = 65
        '
        'Grade
        '
        Me.Grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.descricao, Me.valor, Me.modelo, Me.tipo})
        Me.Grade.Location = New System.Drawing.Point(14, 99)
        Me.Grade.Name = "Grade"
        Me.Grade.RowHeadersWidth = 51
        Me.Grade.Size = New System.Drawing.Size(599, 395)
        Me.Grade.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.Width = 125
        '
        'descricao
        '
        Me.descricao.HeaderText = "Descrição"
        Me.descricao.MinimumWidth = 6
        Me.descricao.Name = "descricao"
        Me.descricao.Width = 125
        '
        'valor
        '
        Me.valor.HeaderText = "Valor"
        Me.valor.MinimumWidth = 6
        Me.valor.Name = "valor"
        Me.valor.Width = 125
        '
        'modelo
        '
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.MinimumWidth = 6
        Me.modelo.Name = "modelo"
        Me.modelo.Width = 125
        '
        'tipo
        '
        Me.tipo.HeaderText = "Tipo"
        Me.tipo.MinimumWidth = 6
        Me.tipo.Name = "tipo"
        Me.tipo.Width = 125
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(226, 58)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblTipo.TabIndex = 60
        Me.lblTipo.Text = "Tipo"
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
        'frmPecas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 541)
        Me.Controls.Add(Me.gpbVeiculos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmPecas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Peças"
        Me.gpbVeiculos.ResumeLayout(False)
        Me.gpbVeiculos.PerformLayout()
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnImpirmir As System.Windows.Forms.Button
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents lblValor As System.Windows.Forms.Label
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents lblDescricao As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents gpbVeiculos As System.Windows.Forms.GroupBox
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents Grade As System.Windows.Forms.DataGridView
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
End Class
