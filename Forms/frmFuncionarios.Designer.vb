<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuncionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFuncionarios))
        Me.mkdRg = New System.Windows.Forms.MaskedTextBox()
        Me.mkdCpf = New System.Windows.Forms.MaskedTextBox()
        Me.mkdCep = New System.Windows.Forms.MaskedTextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.btnImpirmir = New System.Windows.Forms.Button()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblRg = New System.Windows.Forms.Label()
        Me.Grade = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RazaoSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nascimento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCivil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Complemento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cadastro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Alteracao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Inativacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.mkdCarteira = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mkdPis = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPIS = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpListagem = New System.Windows.Forms.TabPage()
        Me.tpCadastro = New System.Windows.Forms.TabPage()
        Me.mskDnascimento = New System.Windows.Forms.MaskedTextBox()
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblDtNasc = New System.Windows.Forms.Label()
        Me.tpEmpresa = New System.Windows.Forms.TabPage()
        Me.cboCargo = New System.Windows.Forms.ComboBox()
        Me.tpContato = New System.Windows.Forms.TabPage()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.mkdcelular = New System.Windows.Forms.MaskedTextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.mkdTelefone = New System.Windows.Forms.MaskedTextBox()
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tpListagem.SuspendLayout()
        Me.tpCadastro.SuspendLayout()
        Me.tpEmpresa.SuspendLayout()
        Me.tpContato.SuspendLayout()
        Me.SuspendLayout()
        '
        'mkdRg
        '
        Me.mkdRg.Location = New System.Drawing.Point(1127, 34)
        Me.mkdRg.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdRg.Mask = "MG - 00.000.000"
        Me.mkdRg.Name = "mkdRg"
        Me.mkdRg.Size = New System.Drawing.Size(107, 22)
        Me.mkdRg.TabIndex = 40
        Me.mkdRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mkdCpf
        '
        Me.mkdCpf.Location = New System.Drawing.Point(1020, 34)
        Me.mkdCpf.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdCpf.Mask = "000.000.000-00"
        Me.mkdCpf.Name = "mkdCpf"
        Me.mkdCpf.Size = New System.Drawing.Size(99, 22)
        Me.mkdCpf.TabIndex = 39
        Me.mkdCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mkdCep
        '
        Me.mkdCep.Location = New System.Drawing.Point(16, 81)
        Me.mkdCep.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdCep.Mask = "00000-000"
        Me.mkdCep.Name = "mkdCep"
        Me.mkdCep.Size = New System.Drawing.Size(83, 22)
        Me.mkdCep.TabIndex = 38
        Me.mkdCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Location = New System.Drawing.Point(1036, 81)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(198, 22)
        Me.txtCidade.TabIndex = 36
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.Location = New System.Drawing.Point(848, 81)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(180, 22)
        Me.txtEstado.TabIndex = 35
        '
        'btnImpirmir
        '
        Me.btnImpirmir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.print_view
        Me.btnImpirmir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImpirmir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImpirmir.Location = New System.Drawing.Point(903, 602)
        Me.btnImpirmir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(125, 55)
        Me.btnImpirmir.TabIndex = 7
        Me.btnImpirmir.Text = "Imprimir"
        Me.btnImpirmir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImpirmir.UseVisualStyleBackColor = True
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(567, 81)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(273, 22)
        Me.txtBairro.TabIndex = 34
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(637, 602)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(125, 55)
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
        Me.btnConsultar.Location = New System.Drawing.Point(770, 602)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(125, 55)
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
        Me.btnAlterar.Location = New System.Drawing.Point(503, 602)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(125, 55)
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
        Me.btnSalvar.Location = New System.Drawing.Point(370, 602)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(125, 55)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.document
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(251, 602)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(111, 55)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(107, 81)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(452, 22)
        Me.txtEndereco.TabIndex = 33
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(108, 35)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(585, 22)
        Me.txtNome.TabIndex = 32
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(17, 35)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(83, 22)
        Me.txtCodigo.TabIndex = 31
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(1124, 13)
        Me.lblRg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(27, 16)
        Me.lblRg.TabIndex = 30
        Me.lblRg.Text = "RG"
        '
        'Grade
        '
        Me.Grade.AllowUserToAddRows = False
        Me.Grade.AllowUserToDeleteRows = False
        Me.Grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nome, Me.RazaoSocial, Me.Nascimento, Me.EstadoCivil, Me.endereco, Me.Complemento, Me.bairro, Me.cidade, Me.estado, Me.cep, Me.Sexo, Me.rg, Me.cpf, Me.Obs, Me.Cadastro, Me.Alteracao, Me.Inativacao})
        Me.Grade.Location = New System.Drawing.Point(7, 7)
        Me.Grade.Margin = New System.Windows.Forms.Padding(4)
        Me.Grade.Name = "Grade"
        Me.Grade.ReadOnly = True
        Me.Grade.RowHeadersWidth = 51
        Me.Grade.Size = New System.Drawing.Size(1237, 529)
        Me.Grade.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 125
        '
        'nome
        '
        Me.nome.HeaderText = "Nome"
        Me.nome.MinimumWidth = 6
        Me.nome.Name = "nome"
        Me.nome.ReadOnly = True
        Me.nome.Width = 125
        '
        'RazaoSocial
        '
        Me.RazaoSocial.HeaderText = "Razão Social"
        Me.RazaoSocial.MinimumWidth = 6
        Me.RazaoSocial.Name = "RazaoSocial"
        Me.RazaoSocial.ReadOnly = True
        Me.RazaoSocial.Width = 125
        '
        'Nascimento
        '
        Me.Nascimento.HeaderText = "Nascimento"
        Me.Nascimento.MinimumWidth = 6
        Me.Nascimento.Name = "Nascimento"
        Me.Nascimento.ReadOnly = True
        Me.Nascimento.Width = 125
        '
        'EstadoCivil
        '
        Me.EstadoCivil.HeaderText = "Est. Civil"
        Me.EstadoCivil.MinimumWidth = 6
        Me.EstadoCivil.Name = "EstadoCivil"
        Me.EstadoCivil.ReadOnly = True
        Me.EstadoCivil.Width = 125
        '
        'endereco
        '
        Me.endereco.HeaderText = "Endereço"
        Me.endereco.MinimumWidth = 6
        Me.endereco.Name = "endereco"
        Me.endereco.ReadOnly = True
        Me.endereco.Width = 125
        '
        'Complemento
        '
        Me.Complemento.HeaderText = "Complemento"
        Me.Complemento.MinimumWidth = 6
        Me.Complemento.Name = "Complemento"
        Me.Complemento.ReadOnly = True
        Me.Complemento.Width = 125
        '
        'bairro
        '
        Me.bairro.HeaderText = "Bairro"
        Me.bairro.MinimumWidth = 6
        Me.bairro.Name = "bairro"
        Me.bairro.ReadOnly = True
        Me.bairro.Width = 125
        '
        'cidade
        '
        Me.cidade.HeaderText = "Cidade"
        Me.cidade.MinimumWidth = 6
        Me.cidade.Name = "cidade"
        Me.cidade.ReadOnly = True
        Me.cidade.Width = 125
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.MinimumWidth = 6
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Width = 125
        '
        'cep
        '
        Me.cep.HeaderText = "CEP"
        Me.cep.MinimumWidth = 6
        Me.cep.Name = "cep"
        Me.cep.ReadOnly = True
        Me.cep.Width = 125
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.MinimumWidth = 6
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        Me.Sexo.Width = 125
        '
        'rg
        '
        Me.rg.HeaderText = "RG"
        Me.rg.MinimumWidth = 6
        Me.rg.Name = "rg"
        Me.rg.ReadOnly = True
        Me.rg.Width = 125
        '
        'cpf
        '
        Me.cpf.HeaderText = "CPF"
        Me.cpf.MinimumWidth = 6
        Me.cpf.Name = "cpf"
        Me.cpf.ReadOnly = True
        Me.cpf.Width = 125
        '
        'Obs
        '
        Me.Obs.HeaderText = "Observação"
        Me.Obs.MinimumWidth = 6
        Me.Obs.Name = "Obs"
        Me.Obs.ReadOnly = True
        Me.Obs.Width = 125
        '
        'Cadastro
        '
        Me.Cadastro.HeaderText = "Cadastro"
        Me.Cadastro.MinimumWidth = 6
        Me.Cadastro.Name = "Cadastro"
        Me.Cadastro.ReadOnly = True
        Me.Cadastro.Width = 125
        '
        'Alteracao
        '
        Me.Alteracao.HeaderText = "Alteração"
        Me.Alteracao.MinimumWidth = 6
        Me.Alteracao.Name = "Alteracao"
        Me.Alteracao.ReadOnly = True
        Me.Alteracao.Width = 125
        '
        'Inativacao
        '
        Me.Inativacao.HeaderText = "Inativação"
        Me.Inativacao.MinimumWidth = 6
        Me.Inativacao.Name = "Inativacao"
        Me.Inativacao.ReadOnly = True
        Me.Inativacao.Width = 125
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(1017, 13)
        Me.lblCpf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(33, 16)
        Me.lblCpf.TabIndex = 29
        Me.lblCpf.Text = "CPF"
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(14, 61)
        Me.lblCep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(34, 16)
        Me.lblCep.TabIndex = 28
        Me.lblCep.Text = "CEP"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(844, 61)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(50, 16)
        Me.lblEstado.TabIndex = 26
        Me.lblEstado.Text = "Estado"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(1032, 61)
        Me.lblCidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(51, 16)
        Me.lblCidade.TabIndex = 25
        Me.lblCidade.Text = "Cidade"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(563, 61)
        Me.lblBairro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(43, 16)
        Me.lblBairro.TabIndex = 24
        Me.lblBairro.Text = "Bairro"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(104, 14)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(44, 16)
        Me.lblNome.TabIndex = 23
        Me.lblNome.Text = "Nome"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(103, 60)
        Me.lblEndereco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(66, 16)
        Me.lblEndereco.TabIndex = 22
        Me.lblEndereco.Text = "Endereço"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(13, 14)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblCodigo.TabIndex = 21
        Me.lblCodigo.Text = "Codigo"
        '
        'mkdCarteira
        '
        Me.mkdCarteira.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdCarteira.Location = New System.Drawing.Point(572, 34)
        Me.mkdCarteira.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdCarteira.Mask = "000.000.000 - 00"
        Me.mkdCarteira.Name = "mkdCarteira"
        Me.mkdCarteira.Size = New System.Drawing.Size(107, 22)
        Me.mkdCarteira.TabIndex = 13
        Me.mkdCarteira.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(569, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Nº Cart. Trabalho"
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(17, 12)
        Me.lblNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(58, 16)
        Me.lblNumero.TabIndex = 41
        Me.lblNumero.Text = "Registro"
        '
        'txtSalario
        '
        Me.txtSalario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalario.Location = New System.Drawing.Point(687, 34)
        Me.txtSalario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(88, 22)
        Me.txtSalario.TabIndex = 45
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(20, 32)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(91, 22)
        Me.txtNumero.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(684, 13)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Salário"
        '
        'mkdPis
        '
        Me.mkdPis.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdPis.Location = New System.Drawing.Point(457, 34)
        Me.mkdPis.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdPis.Mask = "000.000.000 - 00"
        Me.mkdPis.Name = "mkdPis"
        Me.mkdPis.Size = New System.Drawing.Size(107, 22)
        Me.mkdPis.TabIndex = 12
        Me.mkdPis.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(118, 12)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Cargo"
        '
        'lblPIS
        '
        Me.lblPIS.AutoSize = True
        Me.lblPIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPIS.Location = New System.Drawing.Point(454, 14)
        Me.lblPIS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPIS.Name = "lblPIS"
        Me.lblPIS.Size = New System.Drawing.Size(28, 16)
        Me.lblPIS.TabIndex = 39
        Me.lblPIS.Text = "PIS"
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
        Me.TabControl1.Controls.Add(Me.tpEmpresa)
        Me.TabControl1.Controls.Add(Me.tpContato)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1259, 572)
        Me.TabControl1.TabIndex = 49
        '
        'tpListagem
        '
        Me.tpListagem.Controls.Add(Me.Grade)
        Me.tpListagem.Location = New System.Drawing.Point(4, 25)
        Me.tpListagem.Name = "tpListagem"
        Me.tpListagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListagem.Size = New System.Drawing.Size(1251, 543)
        Me.tpListagem.TabIndex = 0
        Me.tpListagem.Text = "Listagem"
        Me.tpListagem.UseVisualStyleBackColor = True
        '
        'tpCadastro
        '
        Me.tpCadastro.Controls.Add(Me.mskDnascimento)
        Me.tpCadastro.Controls.Add(Me.cboEstadoCivil)
        Me.tpCadastro.Controls.Add(Me.lblEstadoCivil)
        Me.tpCadastro.Controls.Add(Me.lblDtNasc)
        Me.tpCadastro.Controls.Add(Me.txtEndereco)
        Me.tpCadastro.Controls.Add(Me.lblCep)
        Me.tpCadastro.Controls.Add(Me.txtCidade)
        Me.tpCadastro.Controls.Add(Me.lblCpf)
        Me.tpCadastro.Controls.Add(Me.lblCidade)
        Me.tpCadastro.Controls.Add(Me.lblRg)
        Me.tpCadastro.Controls.Add(Me.txtEstado)
        Me.tpCadastro.Controls.Add(Me.lblEstado)
        Me.tpCadastro.Controls.Add(Me.lblCodigo)
        Me.tpCadastro.Controls.Add(Me.txtBairro)
        Me.tpCadastro.Controls.Add(Me.lblEndereco)
        Me.tpCadastro.Controls.Add(Me.lblNome)
        Me.tpCadastro.Controls.Add(Me.lblBairro)
        Me.tpCadastro.Controls.Add(Me.mkdCep)
        Me.tpCadastro.Controls.Add(Me.mkdRg)
        Me.tpCadastro.Controls.Add(Me.mkdCpf)
        Me.tpCadastro.Controls.Add(Me.txtNome)
        Me.tpCadastro.Controls.Add(Me.txtCodigo)
        Me.tpCadastro.Location = New System.Drawing.Point(4, 25)
        Me.tpCadastro.Name = "tpCadastro"
        Me.tpCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCadastro.Size = New System.Drawing.Size(1251, 543)
        Me.tpCadastro.TabIndex = 1
        Me.tpCadastro.Text = "Cadastro"
        Me.tpCadastro.UseVisualStyleBackColor = True
        '
        'mskDnascimento
        '
        Me.mskDnascimento.Location = New System.Drawing.Point(701, 34)
        Me.mskDnascimento.Margin = New System.Windows.Forms.Padding(4)
        Me.mskDnascimento.Mask = "00/00/0000"
        Me.mskDnascimento.Name = "mskDnascimento"
        Me.mskDnascimento.Size = New System.Drawing.Size(85, 22)
        Me.mskDnascimento.TabIndex = 73
        Me.mskDnascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.mskDnascimento.ValidatingType = GetType(Date)
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Location = New System.Drawing.Point(794, 34)
        Me.cboEstadoCivil.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(218, 24)
        Me.cboEstadoCivil.TabIndex = 72
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Location = New System.Drawing.Point(791, 13)
        Me.lblEstadoCivil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(78, 16)
        Me.lblEstadoCivil.TabIndex = 71
        Me.lblEstadoCivil.Text = "Estado Civil"
        '
        'lblDtNasc
        '
        Me.lblDtNasc.AutoSize = True
        Me.lblDtNasc.Location = New System.Drawing.Point(700, 13)
        Me.lblDtNasc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDtNasc.Name = "lblDtNasc"
        Me.lblDtNasc.Size = New System.Drawing.Size(79, 16)
        Me.lblDtNasc.TabIndex = 70
        Me.lblDtNasc.Text = "Nascimento"
        '
        'tpEmpresa
        '
        Me.tpEmpresa.Controls.Add(Me.cboCargo)
        Me.tpEmpresa.Controls.Add(Me.lblPIS)
        Me.tpEmpresa.Controls.Add(Me.mkdCarteira)
        Me.tpEmpresa.Controls.Add(Me.Label8)
        Me.tpEmpresa.Controls.Add(Me.Label1)
        Me.tpEmpresa.Controls.Add(Me.lblNumero)
        Me.tpEmpresa.Controls.Add(Me.mkdPis)
        Me.tpEmpresa.Controls.Add(Me.txtSalario)
        Me.tpEmpresa.Controls.Add(Me.Label9)
        Me.tpEmpresa.Controls.Add(Me.txtNumero)
        Me.tpEmpresa.Location = New System.Drawing.Point(4, 25)
        Me.tpEmpresa.Name = "tpEmpresa"
        Me.tpEmpresa.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEmpresa.Size = New System.Drawing.Size(1251, 543)
        Me.tpEmpresa.TabIndex = 2
        Me.tpEmpresa.Text = "Dados Empresa"
        Me.tpEmpresa.UseVisualStyleBackColor = True
        '
        'cboCargo
        '
        Me.cboCargo.FormattingEnabled = True
        Me.cboCargo.Location = New System.Drawing.Point(121, 32)
        Me.cboCargo.Name = "cboCargo"
        Me.cboCargo.Size = New System.Drawing.Size(329, 24)
        Me.cboCargo.TabIndex = 46
        '
        'tpContato
        '
        Me.tpContato.Controls.Add(Me.lblEmail)
        Me.tpContato.Controls.Add(Me.txtEmail)
        Me.tpContato.Controls.Add(Me.mkdcelular)
        Me.tpContato.Controls.Add(Me.lblCelular)
        Me.tpContato.Controls.Add(Me.lblTelefone)
        Me.tpContato.Controls.Add(Me.mkdTelefone)
        Me.tpContato.Location = New System.Drawing.Point(4, 25)
        Me.tpContato.Name = "tpContato"
        Me.tpContato.Padding = New System.Windows.Forms.Padding(3)
        Me.tpContato.Size = New System.Drawing.Size(1251, 543)
        Me.tpContato.TabIndex = 3
        Me.tpContato.Text = "Contato"
        Me.tpContato.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(16, 12)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 16)
        Me.lblEmail.TabIndex = 72
        Me.lblEmail.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(19, 32)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(437, 22)
        Me.txtEmail.TabIndex = 71
        '
        'mkdcelular
        '
        Me.mkdcelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkdcelular.Location = New System.Drawing.Point(604, 32)
        Me.mkdcelular.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdcelular.Mask = "(000) 0000 - 0000"
        Me.mkdcelular.Name = "mkdcelular"
        Me.mkdcelular.Size = New System.Drawing.Size(139, 22)
        Me.mkdcelular.TabIndex = 69
        Me.mkdcelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCelular.Location = New System.Drawing.Point(601, 12)
        Me.lblCelular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(49, 16)
        Me.lblCelular.TabIndex = 70
        Me.lblCelular.Text = "Celular"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(460, 12)
        Me.lblTelefone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(61, 16)
        Me.lblTelefone.TabIndex = 67
        Me.lblTelefone.Text = "Telefone"
        '
        'mkdTelefone
        '
        Me.mkdTelefone.Location = New System.Drawing.Point(464, 32)
        Me.mkdTelefone.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdTelefone.Mask = "(000) 0000-0000"
        Me.mkdTelefone.Name = "mkdTelefone"
        Me.mkdTelefone.Size = New System.Drawing.Size(132, 22)
        Me.mkdTelefone.TabIndex = 68
        '
        'frmFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1273, 678)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnImpirmir)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnExcluir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionários"
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tpListagem.ResumeLayout(False)
        Me.tpCadastro.ResumeLayout(False)
        Me.tpCadastro.PerformLayout()
        Me.tpEmpresa.ResumeLayout(False)
        Me.tpEmpresa.PerformLayout()
        Me.tpContato.ResumeLayout(False)
        Me.tpContato.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mkdRg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkdCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkdCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents btnImpirmir As System.Windows.Forms.Button
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblRg As System.Windows.Forms.Label
    Friend WithEvents Grade As System.Windows.Forms.DataGridView
    Friend WithEvents lblCpf As System.Windows.Forms.Label
    Friend WithEvents lblCep As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtSalario As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents mkdCarteira As MaskedTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents mkdPis As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblPIS As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpListagem As TabPage
    Friend WithEvents tpCadastro As TabPage
    Friend WithEvents tpEmpresa As TabPage
    Friend WithEvents tpContato As TabPage
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mkdcelular As MaskedTextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents lblTelefone As Label
    Friend WithEvents mkdTelefone As MaskedTextBox
    Friend WithEvents mskDnascimento As MaskedTextBox
    Friend WithEvents cboEstadoCivil As ComboBox
    Friend WithEvents lblEstadoCivil As Label
    Friend WithEvents lblDtNasc As Label
    Friend WithEvents cboCargo As ComboBox
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nome As DataGridViewTextBoxColumn
    Friend WithEvents RazaoSocial As DataGridViewTextBoxColumn
    Friend WithEvents Nascimento As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCivil As DataGridViewTextBoxColumn
    Friend WithEvents endereco As DataGridViewTextBoxColumn
    Friend WithEvents Complemento As DataGridViewTextBoxColumn
    Friend WithEvents bairro As DataGridViewTextBoxColumn
    Friend WithEvents cidade As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents cep As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents rg As DataGridViewTextBoxColumn
    Friend WithEvents cpf As DataGridViewTextBoxColumn
    Friend WithEvents Obs As DataGridViewTextBoxColumn
    Friend WithEvents Cadastro As DataGridViewTextBoxColumn
    Friend WithEvents Alteracao As DataGridViewTextBoxColumn
    Friend WithEvents Inativacao As DataGridViewTextBoxColumn
End Class
