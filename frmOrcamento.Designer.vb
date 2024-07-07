<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrcamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrcamento))
        Me.gpbOrcamento = New System.Windows.Forms.GroupBox()
        Me.cboFuncionario = New System.Windows.Forms.ComboBox()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.cboClientes = New System.Windows.Forms.ComboBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.cbxAprovado = New System.Windows.Forms.CheckBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.btnImpirmir = New System.Windows.Forms.Button()
        Me.lblServico = New System.Windows.Forms.Label()
        Me.cboServico = New System.Windows.Forms.ComboBox()
        Me.lblTotalservico = New System.Windows.Forms.Label()
        Me.txtTotalservico = New System.Windows.Forms.TextBox()
        Me.gpbServico = New System.Windows.Forms.GroupBox()
        Me.btnExcluirservico = New System.Windows.Forms.Button()
        Me.btnOkservico = New System.Windows.Forms.Button()
        Me.Gradeservico = New System.Windows.Forms.DataGridView()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.funcionario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.servico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorservico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpbPecas = New System.Windows.Forms.GroupBox()
        Me.btnExcluirpeca = New System.Windows.Forms.Button()
        Me.btnOkpeca = New System.Windows.Forms.Button()
        Me.Gradepeca = New System.Windows.Forms.DataGridView()
        Me.nrorcamento1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.peca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorpeca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalpeca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotalpeca = New System.Windows.Forms.TextBox()
        Me.txtValorpeca = New System.Windows.Forms.TextBox()
        Me.lblPeca = New System.Windows.Forms.Label()
        Me.txtQuantidadepeca = New System.Windows.Forms.TextBox()
        Me.lblTotalpeca = New System.Windows.Forms.Label()
        Me.lblQuantidadepeca = New System.Windows.Forms.Label()
        Me.lblValorpeca = New System.Windows.Forms.Label()
        Me.cboPecas = New System.Windows.Forms.ComboBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.lblDesconto = New System.Windows.Forms.Label()
        Me.cbxDesconto = New System.Windows.Forms.CheckBox()
        Me.txtValortotalservico = New System.Windows.Forms.TextBox()
        Me.lblValortotalservico = New System.Windows.Forms.Label()
        Me.txtValortotalpeca = New System.Windows.Forms.TextBox()
        Me.lblValortotalpeca = New System.Windows.Forms.Label()
        Me.txtTotalgeral = New System.Windows.Forms.TextBox()
        Me.lblTotalgeral = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.er = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnAprovar = New System.Windows.Forms.Button()
        Me.gpbOrcamento.SuspendLayout()
        Me.gpbServico.SuspendLayout()
        CType(Me.Gradeservico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbPecas.SuspendLayout()
        CType(Me.Gradepeca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.er, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbOrcamento
        '
        Me.gpbOrcamento.Controls.Add(Me.cboFuncionario)
        Me.gpbOrcamento.Controls.Add(Me.lblFuncionario)
        Me.gpbOrcamento.Controls.Add(Me.cboClientes)
        Me.gpbOrcamento.Controls.Add(Me.lblCliente)
        Me.gpbOrcamento.Controls.Add(Me.txtData)
        Me.gpbOrcamento.Controls.Add(Me.lblData)
        Me.gpbOrcamento.Controls.Add(Me.cbxAprovado)
        Me.gpbOrcamento.Controls.Add(Me.txtNumero)
        Me.gpbOrcamento.Controls.Add(Me.lblNumero)
        Me.gpbOrcamento.Controls.Add(Me.btnImpirmir)
        Me.gpbOrcamento.Location = New System.Drawing.Point(10, 11)
        Me.gpbOrcamento.Name = "gpbOrcamento"
        Me.gpbOrcamento.Size = New System.Drawing.Size(607, 100)
        Me.gpbOrcamento.TabIndex = 21
        Me.gpbOrcamento.TabStop = False
        '
        'cboFuncionario
        '
        Me.cboFuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFuncionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboFuncionario.FormattingEnabled = True
        Me.cboFuncionario.Location = New System.Drawing.Point(290, 67)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Size = New System.Drawing.Size(306, 21)
        Me.cboFuncionario.TabIndex = 4
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Location = New System.Drawing.Point(287, 51)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(62, 13)
        Me.lblFuncionario.TabIndex = 31
        Me.lblFuncionario.Text = "Funcionário"
        '
        'cboClientes
        '
        Me.cboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.Location = New System.Drawing.Point(14, 67)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(270, 21)
        Me.cboClientes.TabIndex = 3
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(12, 51)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(39, 13)
        Me.lblCliente.TabIndex = 30
        Me.lblCliente.Text = "Cliente"
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(90, 31)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(71, 20)
        Me.txtData.TabIndex = 15
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(88, 15)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(30, 13)
        Me.lblData.TabIndex = 29
        Me.lblData.Text = "Data"
        '
        'cbxAprovado
        '
        Me.cbxAprovado.AutoSize = True
        Me.cbxAprovado.Location = New System.Drawing.Point(176, 31)
        Me.cbxAprovado.Name = "cbxAprovado"
        Me.cbxAprovado.Size = New System.Drawing.Size(72, 17)
        Me.cbxAprovado.TabIndex = 1
        Me.cbxAprovado.Text = "Aprovado"
        Me.cbxAprovado.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(14, 31)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(71, 20)
        Me.txtNumero.TabIndex = 0
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(12, 15)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(74, 13)
        Me.lblNumero.TabIndex = 28
        Me.lblNumero.Text = "Nº Orçamento"
        '
        'btnImpirmir
        '
        Me.btnImpirmir.Location = New System.Drawing.Point(687, 571)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(75, 23)
        Me.btnImpirmir.TabIndex = 7
        Me.btnImpirmir.Text = "Imprimir"
        Me.btnImpirmir.UseVisualStyleBackColor = True
        '
        'lblServico
        '
        Me.lblServico.AutoSize = True
        Me.lblServico.Location = New System.Drawing.Point(12, 15)
        Me.lblServico.Name = "lblServico"
        Me.lblServico.Size = New System.Drawing.Size(43, 13)
        Me.lblServico.TabIndex = 32
        Me.lblServico.Text = "Serviço"
        '
        'cboServico
        '
        Me.cboServico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboServico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboServico.FormattingEnabled = True
        Me.cboServico.Location = New System.Drawing.Point(14, 31)
        Me.cboServico.Name = "cboServico"
        Me.cboServico.Size = New System.Drawing.Size(310, 21)
        Me.cboServico.TabIndex = 5
        '
        'lblTotalservico
        '
        Me.lblTotalservico.AutoSize = True
        Me.lblTotalservico.Location = New System.Drawing.Point(327, 15)
        Me.lblTotalservico.Name = "lblTotalservico"
        Me.lblTotalservico.Size = New System.Drawing.Size(31, 13)
        Me.lblTotalservico.TabIndex = 35
        Me.lblTotalservico.Text = "Valor"
        '
        'txtTotalservico
        '
        Me.txtTotalservico.Location = New System.Drawing.Point(329, 32)
        Me.txtTotalservico.Name = "txtTotalservico"
        Me.txtTotalservico.Size = New System.Drawing.Size(71, 20)
        Me.txtTotalservico.TabIndex = 8
        '
        'gpbServico
        '
        Me.gpbServico.Controls.Add(Me.btnExcluirservico)
        Me.gpbServico.Controls.Add(Me.btnOkservico)
        Me.gpbServico.Controls.Add(Me.Gradeservico)
        Me.gpbServico.Controls.Add(Me.cboServico)
        Me.gpbServico.Controls.Add(Me.lblServico)
        Me.gpbServico.Controls.Add(Me.txtTotalservico)
        Me.gpbServico.Controls.Add(Me.lblTotalservico)
        Me.gpbServico.Location = New System.Drawing.Point(10, 117)
        Me.gpbServico.Name = "gpbServico"
        Me.gpbServico.Size = New System.Drawing.Size(607, 226)
        Me.gpbServico.TabIndex = 44
        Me.gpbServico.TabStop = False
        '
        'btnExcluirservico
        '
        Me.btnExcluirservico.BackgroundImage = CType(resources.GetObject("btnExcluirservico.BackgroundImage"), System.Drawing.Image)
        Me.btnExcluirservico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluirservico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluirservico.Location = New System.Drawing.Point(512, 18)
        Me.btnExcluirservico.Name = "btnExcluirservico"
        Me.btnExcluirservico.Size = New System.Drawing.Size(82, 34)
        Me.btnExcluirservico.TabIndex = 24
        Me.btnExcluirservico.Text = "Excluir"
        Me.btnExcluirservico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluirservico.UseVisualStyleBackColor = True
        '
        'btnOkservico
        '
        Me.btnOkservico.BackgroundImage = CType(resources.GetObject("btnOkservico.BackgroundImage"), System.Drawing.Image)
        Me.btnOkservico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOkservico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOkservico.Location = New System.Drawing.Point(414, 18)
        Me.btnOkservico.Name = "btnOkservico"
        Me.btnOkservico.Size = New System.Drawing.Size(82, 34)
        Me.btnOkservico.TabIndex = 9
        Me.btnOkservico.Text = "OK"
        Me.btnOkservico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOkservico.UseVisualStyleBackColor = True
        '
        'Gradeservico
        '
        Me.Gradeservico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gradeservico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.data, Me.cliente, Me.funcionario, Me.servico, Me.valorservico})
        Me.Gradeservico.Location = New System.Drawing.Point(14, 58)
        Me.Gradeservico.Name = "Gradeservico"
        Me.Gradeservico.RowHeadersWidth = 51
        Me.Gradeservico.Size = New System.Drawing.Size(580, 150)
        Me.Gradeservico.TabIndex = 27
        '
        'numero
        '
        Me.numero.HeaderText = "Número do Orçamento"
        Me.numero.MinimumWidth = 6
        Me.numero.Name = "numero"
        Me.numero.Width = 125
        '
        'data
        '
        Me.data.HeaderText = "Data"
        Me.data.MinimumWidth = 6
        Me.data.Name = "data"
        Me.data.Width = 125
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.MinimumWidth = 6
        Me.cliente.Name = "cliente"
        Me.cliente.Width = 125
        '
        'funcionario
        '
        Me.funcionario.HeaderText = "Funcionário"
        Me.funcionario.MinimumWidth = 6
        Me.funcionario.Name = "funcionario"
        Me.funcionario.Width = 125
        '
        'servico
        '
        Me.servico.HeaderText = "Serviço"
        Me.servico.MinimumWidth = 6
        Me.servico.Name = "servico"
        Me.servico.Width = 125
        '
        'valorservico
        '
        Me.valorservico.HeaderText = "Valor do Serviço"
        Me.valorservico.MinimumWidth = 6
        Me.valorservico.Name = "valorservico"
        Me.valorservico.Width = 125
        '
        'gpbPecas
        '
        Me.gpbPecas.Controls.Add(Me.btnExcluirpeca)
        Me.gpbPecas.Controls.Add(Me.btnOkpeca)
        Me.gpbPecas.Controls.Add(Me.Gradepeca)
        Me.gpbPecas.Controls.Add(Me.txtTotalpeca)
        Me.gpbPecas.Controls.Add(Me.txtValorpeca)
        Me.gpbPecas.Controls.Add(Me.lblPeca)
        Me.gpbPecas.Controls.Add(Me.txtQuantidadepeca)
        Me.gpbPecas.Controls.Add(Me.lblTotalpeca)
        Me.gpbPecas.Controls.Add(Me.lblQuantidadepeca)
        Me.gpbPecas.Controls.Add(Me.lblValorpeca)
        Me.gpbPecas.Controls.Add(Me.cboPecas)
        Me.gpbPecas.Location = New System.Drawing.Point(10, 349)
        Me.gpbPecas.Name = "gpbPecas"
        Me.gpbPecas.Size = New System.Drawing.Size(607, 274)
        Me.gpbPecas.TabIndex = 45
        Me.gpbPecas.TabStop = False
        '
        'btnExcluirpeca
        '
        Me.btnExcluirpeca.BackgroundImage = CType(resources.GetObject("btnExcluirpeca.BackgroundImage"), System.Drawing.Image)
        Me.btnExcluirpeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluirpeca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluirpeca.Location = New System.Drawing.Point(512, 229)
        Me.btnExcluirpeca.Name = "btnExcluirpeca"
        Me.btnExcluirpeca.Size = New System.Drawing.Size(82, 34)
        Me.btnExcluirpeca.TabIndex = 25
        Me.btnExcluirpeca.Text = "Excluir"
        Me.btnExcluirpeca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluirpeca.UseVisualStyleBackColor = True
        '
        'btnOkpeca
        '
        Me.btnOkpeca.BackgroundImage = CType(resources.GetObject("btnOkpeca.BackgroundImage"), System.Drawing.Image)
        Me.btnOkpeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnOkpeca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOkpeca.Location = New System.Drawing.Point(414, 229)
        Me.btnOkpeca.Name = "btnOkpeca"
        Me.btnOkpeca.Size = New System.Drawing.Size(82, 34)
        Me.btnOkpeca.TabIndex = 14
        Me.btnOkpeca.Text = "OK"
        Me.btnOkpeca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOkpeca.UseVisualStyleBackColor = True
        '
        'Gradepeca
        '
        Me.Gradepeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Gradepeca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nrorcamento1, Me.peca, Me.valorpeca, Me.quantidade, Me.totalpeca})
        Me.Gradepeca.Location = New System.Drawing.Point(14, 63)
        Me.Gradepeca.Name = "Gradepeca"
        Me.Gradepeca.RowHeadersWidth = 51
        Me.Gradepeca.Size = New System.Drawing.Size(580, 150)
        Me.Gradepeca.TabIndex = 26
        '
        'nrorcamento1
        '
        Me.nrorcamento1.HeaderText = "Número do Orcamento"
        Me.nrorcamento1.MinimumWidth = 6
        Me.nrorcamento1.Name = "nrorcamento1"
        Me.nrorcamento1.Width = 125
        '
        'peca
        '
        Me.peca.HeaderText = "Peças"
        Me.peca.MinimumWidth = 6
        Me.peca.Name = "peca"
        Me.peca.Width = 125
        '
        'valorpeca
        '
        Me.valorpeca.HeaderText = "Valor Unitário"
        Me.valorpeca.MinimumWidth = 6
        Me.valorpeca.Name = "valorpeca"
        Me.valorpeca.Width = 125
        '
        'quantidade
        '
        Me.quantidade.HeaderText = "Quantidade"
        Me.quantidade.MinimumWidth = 6
        Me.quantidade.Name = "quantidade"
        Me.quantidade.Width = 125
        '
        'totalpeca
        '
        Me.totalpeca.HeaderText = "Total"
        Me.totalpeca.MinimumWidth = 6
        Me.totalpeca.Name = "totalpeca"
        Me.totalpeca.Width = 125
        '
        'txtTotalpeca
        '
        Me.txtTotalpeca.Location = New System.Drawing.Point(418, 34)
        Me.txtTotalpeca.Name = "txtTotalpeca"
        Me.txtTotalpeca.Size = New System.Drawing.Size(71, 20)
        Me.txtTotalpeca.TabIndex = 13
        '
        'txtValorpeca
        '
        Me.txtValorpeca.Location = New System.Drawing.Point(266, 34)
        Me.txtValorpeca.Name = "txtValorpeca"
        Me.txtValorpeca.Size = New System.Drawing.Size(71, 20)
        Me.txtValorpeca.TabIndex = 11
        '
        'lblPeca
        '
        Me.lblPeca.AutoSize = True
        Me.lblPeca.Location = New System.Drawing.Point(12, 18)
        Me.lblPeca.Name = "lblPeca"
        Me.lblPeca.Size = New System.Drawing.Size(37, 13)
        Me.lblPeca.TabIndex = 36
        Me.lblPeca.Text = "Peças"
        '
        'txtQuantidadepeca
        '
        Me.txtQuantidadepeca.Location = New System.Drawing.Point(342, 34)
        Me.txtQuantidadepeca.Name = "txtQuantidadepeca"
        Me.txtQuantidadepeca.Size = New System.Drawing.Size(71, 20)
        Me.txtQuantidadepeca.TabIndex = 12
        Me.txtQuantidadepeca.Text = "0"
        '
        'lblTotalpeca
        '
        Me.lblTotalpeca.AutoSize = True
        Me.lblTotalpeca.Location = New System.Drawing.Point(416, 18)
        Me.lblTotalpeca.Name = "lblTotalpeca"
        Me.lblTotalpeca.Size = New System.Drawing.Size(31, 13)
        Me.lblTotalpeca.TabIndex = 39
        Me.lblTotalpeca.Text = "Total"
        '
        'lblQuantidadepeca
        '
        Me.lblQuantidadepeca.AutoSize = True
        Me.lblQuantidadepeca.Location = New System.Drawing.Point(340, 18)
        Me.lblQuantidadepeca.Name = "lblQuantidadepeca"
        Me.lblQuantidadepeca.Size = New System.Drawing.Size(62, 13)
        Me.lblQuantidadepeca.TabIndex = 38
        Me.lblQuantidadepeca.Text = "Quantidade"
        '
        'lblValorpeca
        '
        Me.lblValorpeca.AutoSize = True
        Me.lblValorpeca.Location = New System.Drawing.Point(265, 18)
        Me.lblValorpeca.Name = "lblValorpeca"
        Me.lblValorpeca.Size = New System.Drawing.Size(70, 13)
        Me.lblValorpeca.TabIndex = 37
        Me.lblValorpeca.Text = "Valor Unitário"
        '
        'cboPecas
        '
        Me.cboPecas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPecas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPecas.FormattingEnabled = True
        Me.cboPecas.Location = New System.Drawing.Point(14, 34)
        Me.cboPecas.Name = "cboPecas"
        Me.cboPecas.Size = New System.Drawing.Size(247, 21)
        Me.cboPecas.TabIndex = 10
        '
        'txtDesconto
        '
        Me.txtDesconto.Location = New System.Drawing.Point(632, 391)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(71, 20)
        Me.txtDesconto.TabIndex = 19
        '
        'lblDesconto
        '
        Me.lblDesconto.AutoSize = True
        Me.lblDesconto.Location = New System.Drawing.Point(628, 378)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(53, 13)
        Me.lblDesconto.TabIndex = 40
        Me.lblDesconto.Text = "Desconto"
        '
        'cbxDesconto
        '
        Me.cbxDesconto.AutoSize = True
        Me.cbxDesconto.Location = New System.Drawing.Point(632, 415)
        Me.cbxDesconto.Name = "cbxDesconto"
        Me.cbxDesconto.Size = New System.Drawing.Size(122, 17)
        Me.cbxDesconto.TabIndex = 20
        Me.cbxDesconto.Text = "Somente no Serviço"
        Me.cbxDesconto.UseVisualStyleBackColor = True
        '
        'txtValortotalservico
        '
        Me.txtValortotalservico.Location = New System.Drawing.Point(631, 454)
        Me.txtValortotalservico.Name = "txtValortotalservico"
        Me.txtValortotalservico.Size = New System.Drawing.Size(71, 20)
        Me.txtValortotalservico.TabIndex = 21
        '
        'lblValortotalservico
        '
        Me.lblValortotalservico.AutoSize = True
        Me.lblValortotalservico.Location = New System.Drawing.Point(628, 438)
        Me.lblValortotalservico.Name = "lblValortotalservico"
        Me.lblValortotalservico.Size = New System.Drawing.Size(112, 13)
        Me.lblValortotalservico.TabIndex = 41
        Me.lblValortotalservico.Text = "Valor Total do Serviço"
        '
        'txtValortotalpeca
        '
        Me.txtValortotalpeca.Location = New System.Drawing.Point(632, 497)
        Me.txtValortotalpeca.Name = "txtValortotalpeca"
        Me.txtValortotalpeca.Size = New System.Drawing.Size(71, 20)
        Me.txtValortotalpeca.TabIndex = 22
        '
        'lblValortotalpeca
        '
        Me.lblValortotalpeca.AutoSize = True
        Me.lblValortotalpeca.Location = New System.Drawing.Point(629, 481)
        Me.lblValortotalpeca.Name = "lblValortotalpeca"
        Me.lblValortotalpeca.Size = New System.Drawing.Size(106, 13)
        Me.lblValortotalpeca.TabIndex = 42
        Me.lblValortotalpeca.Text = "Valor Total do Peças"
        '
        'txtTotalgeral
        '
        Me.txtTotalgeral.Location = New System.Drawing.Point(632, 540)
        Me.txtTotalgeral.Name = "txtTotalgeral"
        Me.txtTotalgeral.Size = New System.Drawing.Size(71, 20)
        Me.txtTotalgeral.TabIndex = 23
        '
        'lblTotalgeral
        '
        Me.lblTotalgeral.AutoSize = True
        Me.lblTotalgeral.Location = New System.Drawing.Point(628, 523)
        Me.lblTotalgeral.Name = "lblTotalgeral"
        Me.lblTotalgeral.Size = New System.Drawing.Size(59, 13)
        Me.lblTotalgeral.TabIndex = 43
        Me.lblTotalgeral.Text = "Total Geral"
        '
        'btnConsultar
        '
        Me.btnConsultar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.binoculars
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(632, 201)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(82, 34)
        Me.btnConsultar.TabIndex = 17
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'er
        '
        Me.er.ContainerControl = Me
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
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(632, 253)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(82, 34)
        Me.btnExcluir.TabIndex = 46
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.document
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(632, 51)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(82, 34)
        Me.btnNovo.TabIndex = 2
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.external_hd
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(632, 102)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(82, 34)
        Me.btnSalvar.TabIndex = 15
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAprovar
        '
        Me.btnAprovar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.ok1
        Me.btnAprovar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAprovar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAprovar.Location = New System.Drawing.Point(631, 149)
        Me.btnAprovar.Name = "btnAprovar"
        Me.btnAprovar.Size = New System.Drawing.Size(82, 34)
        Me.btnAprovar.TabIndex = 16
        Me.btnAprovar.Text = "Aprovar"
        Me.btnAprovar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAprovar.UseVisualStyleBackColor = True
        '
        'frmOrcamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 643)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.txtTotalgeral)
        Me.Controls.Add(Me.lblTotalgeral)
        Me.Controls.Add(Me.txtValortotalpeca)
        Me.Controls.Add(Me.lblValortotalpeca)
        Me.Controls.Add(Me.txtValortotalservico)
        Me.Controls.Add(Me.lblValortotalservico)
        Me.Controls.Add(Me.cbxDesconto)
        Me.Controls.Add(Me.txtDesconto)
        Me.Controls.Add(Me.gpbPecas)
        Me.Controls.Add(Me.lblDesconto)
        Me.Controls.Add(Me.gpbOrcamento)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnAprovar)
        Me.Controls.Add(Me.gpbServico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmOrcamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fazer Orçamento"
        Me.gpbOrcamento.ResumeLayout(False)
        Me.gpbOrcamento.PerformLayout()
        Me.gpbServico.ResumeLayout(False)
        Me.gpbServico.PerformLayout()
        CType(Me.Gradeservico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbPecas.ResumeLayout(False)
        Me.gpbPecas.PerformLayout()
        CType(Me.Gradepeca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.er, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gpbOrcamento As System.Windows.Forms.GroupBox
    Friend WithEvents btnImpirmir As System.Windows.Forms.Button
    Friend WithEvents btnAprovar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents cbxAprovado As System.Windows.Forms.CheckBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents lblNumero As System.Windows.Forms.Label
    Friend WithEvents cboFuncionario As System.Windows.Forms.ComboBox
    Friend WithEvents lblFuncionario As System.Windows.Forms.Label
    Friend WithEvents cboClientes As System.Windows.Forms.ComboBox
    Friend WithEvents lblCliente As System.Windows.Forms.Label
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblServico As System.Windows.Forms.Label
    Friend WithEvents cboServico As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotalservico As System.Windows.Forms.Label
    Friend WithEvents txtTotalservico As System.Windows.Forms.TextBox
    Friend WithEvents gpbServico As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluirservico As System.Windows.Forms.Button
    Friend WithEvents btnOkservico As System.Windows.Forms.Button
    Friend WithEvents Gradeservico As System.Windows.Forms.DataGridView
    Friend WithEvents gpbPecas As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluirpeca As System.Windows.Forms.Button
    Friend WithEvents btnOkpeca As System.Windows.Forms.Button
    Friend WithEvents Gradepeca As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalpeca As System.Windows.Forms.TextBox
    Friend WithEvents txtValorpeca As System.Windows.Forms.TextBox
    Friend WithEvents lblPeca As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadepeca As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalpeca As System.Windows.Forms.Label
    Friend WithEvents lblQuantidadepeca As System.Windows.Forms.Label
    Friend WithEvents lblValorpeca As System.Windows.Forms.Label
    Friend WithEvents cboPecas As System.Windows.Forms.ComboBox
    Friend WithEvents txtDesconto As System.Windows.Forms.TextBox
    Friend WithEvents lblDesconto As System.Windows.Forms.Label
    Friend WithEvents cbxDesconto As System.Windows.Forms.CheckBox
    Friend WithEvents txtValortotalservico As System.Windows.Forms.TextBox
    Friend WithEvents lblValortotalservico As System.Windows.Forms.Label
    Friend WithEvents txtValortotalpeca As System.Windows.Forms.TextBox
    Friend WithEvents lblValortotalpeca As System.Windows.Forms.Label
    Friend WithEvents txtTotalgeral As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalgeral As System.Windows.Forms.Label
    Friend WithEvents nrorcamento1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents peca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valorpeca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalpeca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents er As System.Windows.Forms.ErrorProvider
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cliente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents funcionario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents servico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents valorservico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
End Class
