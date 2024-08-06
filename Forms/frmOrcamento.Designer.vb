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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gpbOrcamento = New System.Windows.Forms.GroupBox()
        Me.txtData = New System.Windows.Forms.DateTimePicker()
        Me.cboFuncionario = New System.Windows.Forms.ComboBox()
        Me.cbxDesconto = New System.Windows.Forms.CheckBox()
        Me.lblTotalgeral = New System.Windows.Forms.Label()
        Me.txtTotalgeral = New System.Windows.Forms.TextBox()
        Me.lblFuncionario = New System.Windows.Forms.Label()
        Me.cboClientes = New System.Windows.Forms.ComboBox()
        Me.lblValortotalpeca = New System.Windows.Forms.Label()
        Me.txtValortotalpeca = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.txtValortotalservico = New System.Windows.Forms.TextBox()
        Me.lblValortotalservico = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.cbxAprovado = New System.Windows.Forms.CheckBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblDesconto = New System.Windows.Forms.Label()
        Me.btnImpirmir = New System.Windows.Forms.Button()
        Me.lblServico = New System.Windows.Forms.Label()
        Me.cboServico = New System.Windows.Forms.ComboBox()
        Me.lblTotalservico = New System.Windows.Forms.Label()
        Me.txtTotalservico = New System.Windows.Forms.TextBox()
        Me.gpbServico = New System.Windows.Forms.GroupBox()
        Me.btnExcluirServico = New System.Windows.Forms.Button()
        Me.btnAdicionarSev = New System.Windows.Forms.Button()
        Me.dgvServico = New System.Windows.Forms.DataGridView()
        Me.CodServ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.servico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorservico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpbPecas = New System.Windows.Forms.GroupBox()
        Me.btnExcluirPeca = New System.Windows.Forms.Button()
        Me.btnAdicionarPeca = New System.Windows.Forms.Button()
        Me.dgvPeca = New System.Windows.Forms.DataGridView()
        Me.CodPecas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.peca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valorpeca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalpeca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotalPeca = New System.Windows.Forms.TextBox()
        Me.txtValorPeca = New System.Windows.Forms.TextBox()
        Me.lblPeca = New System.Windows.Forms.Label()
        Me.txtQuantidadePeca = New System.Windows.Forms.TextBox()
        Me.lblTotalpeca = New System.Windows.Forms.Label()
        Me.lblQuantidadepeca = New System.Windows.Forms.Label()
        Me.lblValorpeca = New System.Windows.Forms.Label()
        Me.cboPecas = New System.Windows.Forms.ComboBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.er = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnAprovar = New System.Windows.Forms.Button()
        Me.tcOrcamento = New System.Windows.Forms.TabControl()
        Me.tpListagem = New System.Windows.Forms.TabPage()
        Me.dgvOrcamento = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Funcionario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalServico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotPeca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desconto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aprovado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.tpOrcamento = New System.Windows.Forms.TabPage()
        Me.gpbOrcamento.SuspendLayout()
        Me.gpbServico.SuspendLayout()
        CType(Me.dgvServico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbPecas.SuspendLayout()
        CType(Me.dgvPeca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.er, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcOrcamento.SuspendLayout()
        Me.tpListagem.SuspendLayout()
        CType(Me.dgvOrcamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpOrcamento.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbOrcamento
        '
        Me.gpbOrcamento.Controls.Add(Me.txtData)
        Me.gpbOrcamento.Controls.Add(Me.cboFuncionario)
        Me.gpbOrcamento.Controls.Add(Me.cbxDesconto)
        Me.gpbOrcamento.Controls.Add(Me.lblTotalgeral)
        Me.gpbOrcamento.Controls.Add(Me.txtTotalgeral)
        Me.gpbOrcamento.Controls.Add(Me.lblFuncionario)
        Me.gpbOrcamento.Controls.Add(Me.cboClientes)
        Me.gpbOrcamento.Controls.Add(Me.lblValortotalpeca)
        Me.gpbOrcamento.Controls.Add(Me.txtValortotalpeca)
        Me.gpbOrcamento.Controls.Add(Me.lblCliente)
        Me.gpbOrcamento.Controls.Add(Me.txtValortotalservico)
        Me.gpbOrcamento.Controls.Add(Me.lblValortotalservico)
        Me.gpbOrcamento.Controls.Add(Me.lblData)
        Me.gpbOrcamento.Controls.Add(Me.cbxAprovado)
        Me.gpbOrcamento.Controls.Add(Me.txtNumero)
        Me.gpbOrcamento.Controls.Add(Me.txtDesconto)
        Me.gpbOrcamento.Controls.Add(Me.lblNumero)
        Me.gpbOrcamento.Controls.Add(Me.lblDesconto)
        Me.gpbOrcamento.Controls.Add(Me.btnImpirmir)
        Me.gpbOrcamento.Location = New System.Drawing.Point(8, 7)
        Me.gpbOrcamento.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbOrcamento.Name = "gpbOrcamento"
        Me.gpbOrcamento.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbOrcamento.Size = New System.Drawing.Size(1029, 123)
        Me.gpbOrcamento.TabIndex = 21
        Me.gpbOrcamento.TabStop = False
        Me.gpbOrcamento.Text = "Orçamento"
        '
        'txtData
        '
        Me.txtData.Enabled = False
        Me.txtData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtData.Location = New System.Drawing.Point(118, 37)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(112, 22)
        Me.txtData.TabIndex = 44
        '
        'cboFuncionario
        '
        Me.cboFuncionario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboFuncionario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboFuncionario.Enabled = False
        Me.cboFuncionario.FormattingEnabled = True
        Me.cboFuncionario.Location = New System.Drawing.Point(637, 38)
        Me.cboFuncionario.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFuncionario.Name = "cboFuncionario"
        Me.cboFuncionario.Size = New System.Drawing.Size(379, 24)
        Me.cboFuncionario.TabIndex = 4
        '
        'cbxDesconto
        '
        Me.cbxDesconto.AutoSize = True
        Me.cbxDesconto.Enabled = False
        Me.cbxDesconto.Location = New System.Drawing.Point(424, 88)
        Me.cbxDesconto.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxDesconto.Name = "cbxDesconto"
        Me.cbxDesconto.Size = New System.Drawing.Size(150, 20)
        Me.cbxDesconto.TabIndex = 20
        Me.cbxDesconto.Text = "Somente no Serviço"
        Me.cbxDesconto.UseVisualStyleBackColor = True
        '
        'lblTotalgeral
        '
        Me.lblTotalgeral.AutoSize = True
        Me.lblTotalgeral.Location = New System.Drawing.Point(320, 66)
        Me.lblTotalgeral.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalgeral.Name = "lblTotalgeral"
        Me.lblTotalgeral.Size = New System.Drawing.Size(74, 16)
        Me.lblTotalgeral.TabIndex = 43
        Me.lblTotalgeral.Text = "Total Geral"
        '
        'txtTotalgeral
        '
        Me.txtTotalgeral.Enabled = False
        Me.txtTotalgeral.Location = New System.Drawing.Point(323, 86)
        Me.txtTotalgeral.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalgeral.Name = "txtTotalgeral"
        Me.txtTotalgeral.Size = New System.Drawing.Size(93, 22)
        Me.txtTotalgeral.TabIndex = 23
        Me.txtTotalgeral.Text = "0"
        Me.txtTotalgeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFuncionario
        '
        Me.lblFuncionario.AutoSize = True
        Me.lblFuncionario.Location = New System.Drawing.Point(634, 18)
        Me.lblFuncionario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFuncionario.Name = "lblFuncionario"
        Me.lblFuncionario.Size = New System.Drawing.Size(77, 16)
        Me.lblFuncionario.TabIndex = 31
        Me.lblFuncionario.Text = "Funcionário"
        '
        'cboClientes
        '
        Me.cboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboClientes.Enabled = False
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.Location = New System.Drawing.Point(237, 38)
        Me.cboClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(392, 24)
        Me.cboClientes.TabIndex = 3
        '
        'lblValortotalpeca
        '
        Me.lblValortotalpeca.AutoSize = True
        Me.lblValortotalpeca.Location = New System.Drawing.Point(219, 66)
        Me.lblValortotalpeca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValortotalpeca.Name = "lblValortotalpeca"
        Me.lblValortotalpeca.Size = New System.Drawing.Size(80, 16)
        Me.lblValortotalpeca.TabIndex = 42
        Me.lblValortotalpeca.Text = "Total Peças"
        '
        'txtValortotalpeca
        '
        Me.txtValortotalpeca.Enabled = False
        Me.txtValortotalpeca.Location = New System.Drawing.Point(222, 86)
        Me.txtValortotalpeca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValortotalpeca.Name = "txtValortotalpeca"
        Me.txtValortotalpeca.Size = New System.Drawing.Size(93, 22)
        Me.txtValortotalpeca.TabIndex = 22
        Me.txtValortotalpeca.Text = "0"
        Me.txtValortotalpeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(234, 19)
        Me.lblCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(48, 16)
        Me.lblCliente.TabIndex = 30
        Me.lblCliente.Text = "Cliente"
        '
        'txtValortotalservico
        '
        Me.txtValortotalservico.Enabled = False
        Me.txtValortotalservico.Location = New System.Drawing.Point(121, 86)
        Me.txtValortotalservico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValortotalservico.Name = "txtValortotalservico"
        Me.txtValortotalservico.Size = New System.Drawing.Size(93, 22)
        Me.txtValortotalservico.TabIndex = 21
        Me.txtValortotalservico.Text = "0"
        Me.txtValortotalservico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblValortotalservico
        '
        Me.lblValortotalservico.AutoSize = True
        Me.lblValortotalservico.Location = New System.Drawing.Point(118, 66)
        Me.lblValortotalservico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValortotalservico.Name = "lblValortotalservico"
        Me.lblValortotalservico.Size = New System.Drawing.Size(87, 16)
        Me.lblValortotalservico.TabIndex = 41
        Me.lblValortotalservico.Text = "Total Serviço"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(117, 18)
        Me.lblData.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(36, 16)
        Me.lblData.TabIndex = 29
        Me.lblData.Text = "Data"
        '
        'cbxAprovado
        '
        Me.cbxAprovado.AutoSize = True
        Me.cbxAprovado.Enabled = False
        Me.cbxAprovado.Location = New System.Drawing.Point(589, 86)
        Me.cbxAprovado.Margin = New System.Windows.Forms.Padding(4)
        Me.cbxAprovado.Name = "cbxAprovado"
        Me.cbxAprovado.Size = New System.Drawing.Size(89, 20)
        Me.cbxAprovado.TabIndex = 1
        Me.cbxAprovado.Text = "Aprovado"
        Me.cbxAprovado.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Location = New System.Drawing.Point(19, 38)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(93, 22)
        Me.txtNumero.TabIndex = 0
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDesconto
        '
        Me.txtDesconto.Enabled = False
        Me.txtDesconto.Location = New System.Drawing.Point(19, 86)
        Me.txtDesconto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.Size = New System.Drawing.Size(96, 22)
        Me.txtDesconto.TabIndex = 19
        Me.txtDesconto.Text = "0"
        Me.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(16, 18)
        Me.lblNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(91, 16)
        Me.lblNumero.TabIndex = 28
        Me.lblNumero.Text = "Nº Orçamento"
        '
        'lblDesconto
        '
        Me.lblDesconto.AutoSize = True
        Me.lblDesconto.Location = New System.Drawing.Point(16, 66)
        Me.lblDesconto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDesconto.Name = "lblDesconto"
        Me.lblDesconto.Size = New System.Drawing.Size(65, 16)
        Me.lblDesconto.TabIndex = 40
        Me.lblDesconto.Text = "Desconto"
        '
        'btnImpirmir
        '
        Me.btnImpirmir.Location = New System.Drawing.Point(916, 703)
        Me.btnImpirmir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(100, 28)
        Me.btnImpirmir.TabIndex = 7
        Me.btnImpirmir.Text = "Imprimir"
        Me.btnImpirmir.UseVisualStyleBackColor = True
        '
        'lblServico
        '
        Me.lblServico.AutoSize = True
        Me.lblServico.Location = New System.Drawing.Point(16, 18)
        Me.lblServico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServico.Name = "lblServico"
        Me.lblServico.Size = New System.Drawing.Size(53, 16)
        Me.lblServico.TabIndex = 32
        Me.lblServico.Text = "Serviço"
        '
        'cboServico
        '
        Me.cboServico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboServico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboServico.Enabled = False
        Me.cboServico.FormattingEnabled = True
        Me.cboServico.Location = New System.Drawing.Point(19, 38)
        Me.cboServico.Margin = New System.Windows.Forms.Padding(4)
        Me.cboServico.Name = "cboServico"
        Me.cboServico.Size = New System.Drawing.Size(412, 24)
        Me.cboServico.TabIndex = 5
        '
        'lblTotalservico
        '
        Me.lblTotalservico.AutoSize = True
        Me.lblTotalservico.Location = New System.Drawing.Point(436, 18)
        Me.lblTotalservico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalservico.Name = "lblTotalservico"
        Me.lblTotalservico.Size = New System.Drawing.Size(39, 16)
        Me.lblTotalservico.TabIndex = 35
        Me.lblTotalservico.Text = "Valor"
        '
        'txtTotalservico
        '
        Me.txtTotalservico.Enabled = False
        Me.txtTotalservico.Location = New System.Drawing.Point(439, 39)
        Me.txtTotalservico.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalservico.Name = "txtTotalservico"
        Me.txtTotalservico.Size = New System.Drawing.Size(93, 22)
        Me.txtTotalservico.TabIndex = 8
        Me.txtTotalservico.Text = "0"
        Me.txtTotalservico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gpbServico
        '
        Me.gpbServico.Controls.Add(Me.btnExcluirServico)
        Me.gpbServico.Controls.Add(Me.btnAdicionarSev)
        Me.gpbServico.Controls.Add(Me.dgvServico)
        Me.gpbServico.Controls.Add(Me.cboServico)
        Me.gpbServico.Controls.Add(Me.lblServico)
        Me.gpbServico.Controls.Add(Me.txtTotalservico)
        Me.gpbServico.Controls.Add(Me.lblTotalservico)
        Me.gpbServico.Location = New System.Drawing.Point(7, 138)
        Me.gpbServico.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbServico.Name = "gpbServico"
        Me.gpbServico.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbServico.Size = New System.Drawing.Size(1029, 253)
        Me.gpbServico.TabIndex = 44
        Me.gpbServico.TabStop = False
        Me.gpbServico.Text = "Serviços"
        '
        'btnExcluirServico
        '
        Me.btnExcluirServico.BackgroundImage = CType(resources.GetObject("btnExcluirServico.BackgroundImage"), System.Drawing.Image)
        Me.btnExcluirServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcluirServico.Enabled = False
        Me.btnExcluirServico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluirServico.Location = New System.Drawing.Point(958, 151)
        Me.btnExcluirServico.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluirServico.Name = "btnExcluirServico"
        Me.btnExcluirServico.Size = New System.Drawing.Size(58, 55)
        Me.btnExcluirServico.TabIndex = 24
        Me.btnExcluirServico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluirServico.UseVisualStyleBackColor = True
        '
        'btnAdicionarSev
        '
        Me.btnAdicionarSev.BackgroundImage = CType(resources.GetObject("btnAdicionarSev.BackgroundImage"), System.Drawing.Image)
        Me.btnAdicionarSev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdicionarSev.Enabled = False
        Me.btnAdicionarSev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionarSev.Location = New System.Drawing.Point(958, 88)
        Me.btnAdicionarSev.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdicionarSev.Name = "btnAdicionarSev"
        Me.btnAdicionarSev.Size = New System.Drawing.Size(58, 55)
        Me.btnAdicionarSev.TabIndex = 9
        Me.btnAdicionarSev.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionarSev.UseVisualStyleBackColor = True
        '
        'dgvServico
        '
        Me.dgvServico.AllowUserToAddRows = False
        Me.dgvServico.AllowUserToDeleteRows = False
        Me.dgvServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodServ, Me.servico, Me.valorservico})
        Me.dgvServico.Location = New System.Drawing.Point(19, 70)
        Me.dgvServico.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvServico.Name = "dgvServico"
        Me.dgvServico.ReadOnly = True
        Me.dgvServico.RowHeadersWidth = 51
        Me.dgvServico.Size = New System.Drawing.Size(931, 161)
        Me.dgvServico.TabIndex = 27
        '
        'CodServ
        '
        Me.CodServ.HeaderText = "Codigo"
        Me.CodServ.MinimumWidth = 6
        Me.CodServ.Name = "CodServ"
        Me.CodServ.ReadOnly = True
        Me.CodServ.Width = 125
        '
        'servico
        '
        Me.servico.HeaderText = "Serviço"
        Me.servico.MinimumWidth = 6
        Me.servico.Name = "servico"
        Me.servico.ReadOnly = True
        Me.servico.Width = 125
        '
        'valorservico
        '
        DataGridViewCellStyle1.NullValue = "0"
        Me.valorservico.DefaultCellStyle = DataGridViewCellStyle1
        Me.valorservico.HeaderText = "Valor do Serviço"
        Me.valorservico.MinimumWidth = 6
        Me.valorservico.Name = "valorservico"
        Me.valorservico.ReadOnly = True
        Me.valorservico.Width = 125
        '
        'gpbPecas
        '
        Me.gpbPecas.Controls.Add(Me.btnExcluirPeca)
        Me.gpbPecas.Controls.Add(Me.btnAdicionarPeca)
        Me.gpbPecas.Controls.Add(Me.dgvPeca)
        Me.gpbPecas.Controls.Add(Me.txtTotalPeca)
        Me.gpbPecas.Controls.Add(Me.txtValorPeca)
        Me.gpbPecas.Controls.Add(Me.lblPeca)
        Me.gpbPecas.Controls.Add(Me.txtQuantidadePeca)
        Me.gpbPecas.Controls.Add(Me.lblTotalpeca)
        Me.gpbPecas.Controls.Add(Me.lblQuantidadepeca)
        Me.gpbPecas.Controls.Add(Me.lblValorpeca)
        Me.gpbPecas.Controls.Add(Me.cboPecas)
        Me.gpbPecas.Location = New System.Drawing.Point(8, 399)
        Me.gpbPecas.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbPecas.Name = "gpbPecas"
        Me.gpbPecas.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbPecas.Size = New System.Drawing.Size(1029, 263)
        Me.gpbPecas.TabIndex = 45
        Me.gpbPecas.TabStop = False
        Me.gpbPecas.Text = "Peças"
        '
        'btnExcluirPeca
        '
        Me.btnExcluirPeca.BackgroundImage = CType(resources.GetObject("btnExcluirPeca.BackgroundImage"), System.Drawing.Image)
        Me.btnExcluirPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcluirPeca.Enabled = False
        Me.btnExcluirPeca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluirPeca.Location = New System.Drawing.Point(957, 165)
        Me.btnExcluirPeca.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluirPeca.Name = "btnExcluirPeca"
        Me.btnExcluirPeca.Size = New System.Drawing.Size(58, 53)
        Me.btnExcluirPeca.TabIndex = 25
        Me.btnExcluirPeca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluirPeca.UseVisualStyleBackColor = True
        '
        'btnAdicionarPeca
        '
        Me.btnAdicionarPeca.BackgroundImage = CType(resources.GetObject("btnAdicionarPeca.BackgroundImage"), System.Drawing.Image)
        Me.btnAdicionarPeca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdicionarPeca.Enabled = False
        Me.btnAdicionarPeca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionarPeca.Location = New System.Drawing.Point(957, 105)
        Me.btnAdicionarPeca.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdicionarPeca.Name = "btnAdicionarPeca"
        Me.btnAdicionarPeca.Size = New System.Drawing.Size(58, 53)
        Me.btnAdicionarPeca.TabIndex = 14
        Me.btnAdicionarPeca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionarPeca.UseVisualStyleBackColor = True
        '
        'dgvPeca
        '
        Me.dgvPeca.AllowUserToAddRows = False
        Me.dgvPeca.AllowUserToDeleteRows = False
        Me.dgvPeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPeca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodPecas, Me.peca, Me.valorpeca, Me.quantidade, Me.totalpeca})
        Me.dgvPeca.Location = New System.Drawing.Point(19, 78)
        Me.dgvPeca.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvPeca.Name = "dgvPeca"
        Me.dgvPeca.ReadOnly = True
        Me.dgvPeca.RowHeadersWidth = 51
        Me.dgvPeca.Size = New System.Drawing.Size(931, 166)
        Me.dgvPeca.TabIndex = 26
        '
        'CodPecas
        '
        Me.CodPecas.HeaderText = "Código"
        Me.CodPecas.MinimumWidth = 6
        Me.CodPecas.Name = "CodPecas"
        Me.CodPecas.ReadOnly = True
        Me.CodPecas.Width = 125
        '
        'peca
        '
        Me.peca.HeaderText = "Peças"
        Me.peca.MinimumWidth = 6
        Me.peca.Name = "peca"
        Me.peca.ReadOnly = True
        Me.peca.Width = 125
        '
        'valorpeca
        '
        Me.valorpeca.HeaderText = "Valor Unitário"
        Me.valorpeca.MinimumWidth = 6
        Me.valorpeca.Name = "valorpeca"
        Me.valorpeca.ReadOnly = True
        Me.valorpeca.Width = 125
        '
        'quantidade
        '
        Me.quantidade.HeaderText = "Quantidade"
        Me.quantidade.MinimumWidth = 6
        Me.quantidade.Name = "quantidade"
        Me.quantidade.ReadOnly = True
        Me.quantidade.Width = 125
        '
        'totalpeca
        '
        Me.totalpeca.HeaderText = "Total"
        Me.totalpeca.MinimumWidth = 6
        Me.totalpeca.Name = "totalpeca"
        Me.totalpeca.ReadOnly = True
        Me.totalpeca.Width = 125
        '
        'txtTotalPeca
        '
        Me.txtTotalPeca.Enabled = False
        Me.txtTotalPeca.Location = New System.Drawing.Point(699, 44)
        Me.txtTotalPeca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalPeca.Name = "txtTotalPeca"
        Me.txtTotalPeca.Size = New System.Drawing.Size(93, 22)
        Me.txtTotalPeca.TabIndex = 13
        Me.txtTotalPeca.Text = "0"
        Me.txtTotalPeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtValorPeca
        '
        Me.txtValorPeca.Enabled = False
        Me.txtValorPeca.Location = New System.Drawing.Point(497, 44)
        Me.txtValorPeca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorPeca.Name = "txtValorPeca"
        Me.txtValorPeca.Size = New System.Drawing.Size(93, 22)
        Me.txtValorPeca.TabIndex = 11
        Me.txtValorPeca.Text = "0"
        Me.txtValorPeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPeca
        '
        Me.lblPeca.AutoSize = True
        Me.lblPeca.Location = New System.Drawing.Point(16, 22)
        Me.lblPeca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPeca.Name = "lblPeca"
        Me.lblPeca.Size = New System.Drawing.Size(46, 16)
        Me.lblPeca.TabIndex = 36
        Me.lblPeca.Text = "Peças"
        '
        'txtQuantidadePeca
        '
        Me.txtQuantidadePeca.Enabled = False
        Me.txtQuantidadePeca.Location = New System.Drawing.Point(598, 44)
        Me.txtQuantidadePeca.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantidadePeca.Name = "txtQuantidadePeca"
        Me.txtQuantidadePeca.Size = New System.Drawing.Size(93, 22)
        Me.txtQuantidadePeca.TabIndex = 12
        Me.txtQuantidadePeca.Text = "0"
        Me.txtQuantidadePeca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalpeca
        '
        Me.lblTotalpeca.AutoSize = True
        Me.lblTotalpeca.Location = New System.Drawing.Point(697, 24)
        Me.lblTotalpeca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalpeca.Name = "lblTotalpeca"
        Me.lblTotalpeca.Size = New System.Drawing.Size(38, 16)
        Me.lblTotalpeca.TabIndex = 39
        Me.lblTotalpeca.Text = "Total"
        '
        'lblQuantidadepeca
        '
        Me.lblQuantidadepeca.AutoSize = True
        Me.lblQuantidadepeca.Location = New System.Drawing.Point(595, 24)
        Me.lblQuantidadepeca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQuantidadepeca.Name = "lblQuantidadepeca"
        Me.lblQuantidadepeca.Size = New System.Drawing.Size(77, 16)
        Me.lblQuantidadepeca.TabIndex = 38
        Me.lblQuantidadepeca.Text = "Quantidade"
        '
        'lblValorpeca
        '
        Me.lblValorpeca.AutoSize = True
        Me.lblValorpeca.Location = New System.Drawing.Point(495, 24)
        Me.lblValorpeca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValorpeca.Name = "lblValorpeca"
        Me.lblValorpeca.Size = New System.Drawing.Size(88, 16)
        Me.lblValorpeca.TabIndex = 37
        Me.lblValorpeca.Text = "Valor Unitário"
        '
        'cboPecas
        '
        Me.cboPecas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cboPecas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cboPecas.Enabled = False
        Me.cboPecas.FormattingEnabled = True
        Me.cboPecas.Location = New System.Drawing.Point(19, 42)
        Me.cboPecas.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPecas.Name = "cboPecas"
        Me.cboPecas.Size = New System.Drawing.Size(470, 24)
        Me.cboPecas.TabIndex = 10
        '
        'btnConsultar
        '
        Me.btnConsultar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.binoculars
        Me.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(722, 721)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(119, 54)
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
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(595, 721)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(119, 54)
        Me.btnExcluir.TabIndex = 46
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.document
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(212, 721)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(119, 54)
        Me.btnNovo.TabIndex = 2
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.external_hd
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(339, 720)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(119, 55)
        Me.btnSalvar.TabIndex = 15
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAprovar
        '
        Me.btnAprovar.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.ok1
        Me.btnAprovar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAprovar.Enabled = False
        Me.btnAprovar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAprovar.Location = New System.Drawing.Point(466, 721)
        Me.btnAprovar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAprovar.Name = "btnAprovar"
        Me.btnAprovar.Size = New System.Drawing.Size(121, 54)
        Me.btnAprovar.TabIndex = 16
        Me.btnAprovar.Text = "Aprovar"
        Me.btnAprovar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAprovar.UseVisualStyleBackColor = True
        '
        'tcOrcamento
        '
        Me.tcOrcamento.Controls.Add(Me.tpListagem)
        Me.tcOrcamento.Controls.Add(Me.tpOrcamento)
        Me.tcOrcamento.Location = New System.Drawing.Point(12, 12)
        Me.tcOrcamento.Name = "tcOrcamento"
        Me.tcOrcamento.SelectedIndex = 0
        Me.tcOrcamento.Size = New System.Drawing.Size(1051, 698)
        Me.tcOrcamento.TabIndex = 40
        '
        'tpListagem
        '
        Me.tpListagem.Controls.Add(Me.dgvOrcamento)
        Me.tpListagem.Location = New System.Drawing.Point(4, 25)
        Me.tpListagem.Name = "tpListagem"
        Me.tpListagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListagem.Size = New System.Drawing.Size(1043, 669)
        Me.tpListagem.TabIndex = 1
        Me.tpListagem.Text = "Listagem"
        Me.tpListagem.UseVisualStyleBackColor = True
        '
        'dgvOrcamento
        '
        Me.dgvOrcamento.AllowUserToAddRows = False
        Me.dgvOrcamento.AllowUserToDeleteRows = False
        Me.dgvOrcamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrcamento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Data, Me.Cliente, Me.Funcionario, Me.TotalServico, Me.TotPeca, Me.Desconto, Me.Aprovado, Me.Total})
        Me.dgvOrcamento.Location = New System.Drawing.Point(6, 6)
        Me.dgvOrcamento.Name = "dgvOrcamento"
        Me.dgvOrcamento.ReadOnly = True
        Me.dgvOrcamento.RowHeadersWidth = 51
        Me.dgvOrcamento.RowTemplate.Height = 24
        Me.dgvOrcamento.Size = New System.Drawing.Size(1031, 657)
        Me.dgvOrcamento.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.MinimumWidth = 6
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 125
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.MinimumWidth = 6
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        Me.Data.Width = 125
        '
        'Cliente
        '
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.MinimumWidth = 6
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        Me.Cliente.Width = 125
        '
        'Funcionario
        '
        Me.Funcionario.HeaderText = "Funcionário"
        Me.Funcionario.MinimumWidth = 6
        Me.Funcionario.Name = "Funcionario"
        Me.Funcionario.ReadOnly = True
        Me.Funcionario.Width = 125
        '
        'TotalServico
        '
        Me.TotalServico.HeaderText = "Tot. Serviço"
        Me.TotalServico.MinimumWidth = 6
        Me.TotalServico.Name = "TotalServico"
        Me.TotalServico.ReadOnly = True
        Me.TotalServico.Width = 125
        '
        'TotPeca
        '
        Me.TotPeca.HeaderText = "Tot. Peças"
        Me.TotPeca.MinimumWidth = 6
        Me.TotPeca.Name = "TotPeca"
        Me.TotPeca.ReadOnly = True
        Me.TotPeca.Width = 125
        '
        'Desconto
        '
        Me.Desconto.HeaderText = "Desconto"
        Me.Desconto.MinimumWidth = 6
        Me.Desconto.Name = "Desconto"
        Me.Desconto.ReadOnly = True
        Me.Desconto.Width = 125
        '
        'Aprovado
        '
        Me.Aprovado.HeaderText = "Aprovado"
        Me.Aprovado.MinimumWidth = 6
        Me.Aprovado.Name = "Aprovado"
        Me.Aprovado.ReadOnly = True
        Me.Aprovado.Width = 125
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 125
        '
        'tpOrcamento
        '
        Me.tpOrcamento.Controls.Add(Me.gpbPecas)
        Me.tpOrcamento.Controls.Add(Me.gpbServico)
        Me.tpOrcamento.Controls.Add(Me.gpbOrcamento)
        Me.tpOrcamento.Location = New System.Drawing.Point(4, 25)
        Me.tpOrcamento.Name = "tpOrcamento"
        Me.tpOrcamento.Padding = New System.Windows.Forms.Padding(3)
        Me.tpOrcamento.Size = New System.Drawing.Size(1043, 669)
        Me.tpOrcamento.TabIndex = 0
        Me.tpOrcamento.Text = "Orçamento"
        Me.tpOrcamento.UseVisualStyleBackColor = True
        '
        'frmOrcamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 791)
        Me.Controls.Add(Me.tcOrcamento)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnAprovar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmOrcamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fazer Orçamento"
        Me.gpbOrcamento.ResumeLayout(False)
        Me.gpbOrcamento.PerformLayout()
        Me.gpbServico.ResumeLayout(False)
        Me.gpbServico.PerformLayout()
        CType(Me.dgvServico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbPecas.ResumeLayout(False)
        Me.gpbPecas.PerformLayout()
        CType(Me.dgvPeca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.er, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcOrcamento.ResumeLayout(False)
        Me.tpListagem.ResumeLayout(False)
        CType(Me.dgvOrcamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpOrcamento.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents lblServico As System.Windows.Forms.Label
    Friend WithEvents cboServico As System.Windows.Forms.ComboBox
    Friend WithEvents lblTotalservico As System.Windows.Forms.Label
    Friend WithEvents txtTotalservico As System.Windows.Forms.TextBox
    Friend WithEvents gpbServico As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluirServico As System.Windows.Forms.Button
    Friend WithEvents btnAdicionarSev As System.Windows.Forms.Button
    Friend WithEvents dgvServico As System.Windows.Forms.DataGridView
    Friend WithEvents gpbPecas As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluirPeca As System.Windows.Forms.Button
    Friend WithEvents btnAdicionarPeca As System.Windows.Forms.Button
    Friend WithEvents dgvPeca As System.Windows.Forms.DataGridView
    Friend WithEvents txtTotalPeca As System.Windows.Forms.TextBox
    Friend WithEvents txtValorPeca As System.Windows.Forms.TextBox
    Friend WithEvents lblPeca As System.Windows.Forms.Label
    Friend WithEvents txtQuantidadePeca As System.Windows.Forms.TextBox
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
    Friend WithEvents er As System.Windows.Forms.ErrorProvider
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents txtData As DateTimePicker
    Friend WithEvents CodPecas As DataGridViewTextBoxColumn
    Friend WithEvents peca As DataGridViewTextBoxColumn
    Friend WithEvents valorpeca As DataGridViewTextBoxColumn
    Friend WithEvents quantidade As DataGridViewTextBoxColumn
    Friend WithEvents totalpeca As DataGridViewTextBoxColumn
    Friend WithEvents CodServ As DataGridViewTextBoxColumn
    Friend WithEvents servico As DataGridViewTextBoxColumn
    Friend WithEvents valorservico As DataGridViewTextBoxColumn
    Friend WithEvents tcOrcamento As TabControl
    Friend WithEvents tpOrcamento As TabPage
    Friend WithEvents tpListagem As TabPage
    Friend WithEvents dgvOrcamento As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Funcionario As DataGridViewTextBoxColumn
    Friend WithEvents TotalServico As DataGridViewTextBoxColumn
    Friend WithEvents TotPeca As DataGridViewTextBoxColumn
    Friend WithEvents Desconto As DataGridViewTextBoxColumn
    Friend WithEvents Aprovado As DataGridViewCheckBoxColumn
    Friend WithEvents Total As DataGridViewCheckBoxColumn
End Class
