<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblRg = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.mkdTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.mkdCep = New System.Windows.Forms.MaskedTextBox()
        Me.mkdCpf = New System.Windows.Forms.MaskedTextBox()
        Me.mkdRg = New System.Windows.Forms.MaskedTextBox()
        Me.mskCel = New System.Windows.Forms.MaskedTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblCelular = New System.Windows.Forms.Label()
        Me.mskDnascimento = New System.Windows.Forms.MaskedTextBox()
        Me.cboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.lblEstadoCivil = New System.Windows.Forms.Label()
        Me.lblDtNasc = New System.Windows.Forms.Label()
        Me.btnImpirmir = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpListagem = New System.Windows.Forms.TabPage()
        Me.tbCadastro = New System.Windows.Forms.TabPage()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tpListagem.SuspendLayout()
        Me.tbCadastro.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 12)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Codigo"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(12, 61)
        Me.lblEndereco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(66, 16)
        Me.lblEndereco.TabIndex = 1
        Me.lblEndereco.Text = "Endereço"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(104, 12)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(44, 16)
        Me.lblNome.TabIndex = 2
        Me.lblNome.Text = "Nome"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(455, 61)
        Me.lblBairro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(43, 16)
        Me.lblBairro.TabIndex = 3
        Me.lblBairro.Text = "Bairro"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(890, 61)
        Me.lblCidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(51, 16)
        Me.lblCidade.TabIndex = 4
        Me.lblCidade.Text = "Cidade"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(634, 61)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(50, 16)
        Me.lblEstado.TabIndex = 5
        Me.lblEstado.Text = "Estado"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(12, 108)
        Me.lblTelefone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(61, 16)
        Me.lblTelefone.TabIndex = 6
        Me.lblTelefone.Text = "Telefone"
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(1017, 10)
        Me.lblCep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(34, 16)
        Me.lblCep.TabIndex = 7
        Me.lblCep.Text = "CEP"
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(747, 12)
        Me.lblCpf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(33, 16)
        Me.lblCpf.TabIndex = 8
        Me.lblCpf.Text = "CPF"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(887, 12)
        Me.lblRg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(27, 16)
        Me.lblRg.TabIndex = 9
        Me.lblRg.Text = "RG"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(16, 30)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(83, 22)
        Me.txtCodigo.TabIndex = 10
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(107, 31)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(375, 22)
        Me.txtNome.TabIndex = 11
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(16, 80)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(435, 22)
        Me.txtEndereco.TabIndex = 12
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(459, 80)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(171, 22)
        Me.txtBairro.TabIndex = 13
        '
        'txtEstado
        '
        Me.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado.Location = New System.Drawing.Point(638, 80)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(248, 22)
        Me.txtEstado.TabIndex = 14
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Location = New System.Drawing.Point(894, 80)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(209, 22)
        Me.txtCidade.TabIndex = 15
        '
        'mkdTelefone
        '
        Me.mkdTelefone.Location = New System.Drawing.Point(16, 127)
        Me.mkdTelefone.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdTelefone.Mask = "(000) 0000 - 0000"
        Me.mkdTelefone.Name = "mkdTelefone"
        Me.mkdTelefone.Size = New System.Drawing.Size(132, 22)
        Me.mkdTelefone.TabIndex = 16
        Me.mkdTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mkdCep
        '
        Me.mkdCep.Location = New System.Drawing.Point(1020, 30)
        Me.mkdCep.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdCep.Mask = "00000 - 000"
        Me.mkdCep.Name = "mkdCep"
        Me.mkdCep.Size = New System.Drawing.Size(83, 22)
        Me.mkdCep.TabIndex = 17
        Me.mkdCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mkdCpf
        '
        Me.mkdCpf.Location = New System.Drawing.Point(751, 31)
        Me.mkdCpf.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdCpf.Mask = "000.000.000 - 00"
        Me.mkdCpf.Name = "mkdCpf"
        Me.mkdCpf.Size = New System.Drawing.Size(132, 22)
        Me.mkdCpf.TabIndex = 18
        Me.mkdCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mkdRg
        '
        Me.mkdRg.Location = New System.Drawing.Point(891, 31)
        Me.mkdRg.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdRg.Mask = "MG - 00.000.000"
        Me.mkdRg.Name = "mkdRg"
        Me.mkdRg.Size = New System.Drawing.Size(121, 22)
        Me.mkdRg.TabIndex = 19
        Me.mkdRg.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mskCel
        '
        Me.mskCel.Location = New System.Drawing.Point(156, 127)
        Me.mskCel.Margin = New System.Windows.Forms.Padding(4)
        Me.mskCel.Mask = "(00)0000-0000"
        Me.mskCel.Name = "mskCel"
        Me.mskCel.Size = New System.Drawing.Size(132, 22)
        Me.mskCel.TabIndex = 73
        Me.mskCel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(294, 107)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(45, 16)
        Me.lblEmail.TabIndex = 72
        Me.lblEmail.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmail.Location = New System.Drawing.Point(296, 127)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(437, 22)
        Me.txtEmail.TabIndex = 71
        '
        'lblCelular
        '
        Me.lblCelular.AutoSize = True
        Me.lblCelular.Location = New System.Drawing.Point(152, 109)
        Me.lblCelular.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCelular.Name = "lblCelular"
        Me.lblCelular.Size = New System.Drawing.Size(49, 16)
        Me.lblCelular.TabIndex = 70
        Me.lblCelular.Text = "Celular"
        '
        'mskDnascimento
        '
        Me.mskDnascimento.Location = New System.Drawing.Point(490, 30)
        Me.mskDnascimento.Margin = New System.Windows.Forms.Padding(4)
        Me.mskDnascimento.Mask = "00/00/0000"
        Me.mskDnascimento.Name = "mskDnascimento"
        Me.mskDnascimento.Size = New System.Drawing.Size(85, 22)
        Me.mskDnascimento.TabIndex = 69
        Me.mskDnascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.mskDnascimento.ValidatingType = GetType(Date)
        '
        'cboEstadoCivil
        '
        Me.cboEstadoCivil.FormattingEnabled = True
        Me.cboEstadoCivil.Location = New System.Drawing.Point(583, 30)
        Me.cboEstadoCivil.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEstadoCivil.Name = "cboEstadoCivil"
        Me.cboEstadoCivil.Size = New System.Drawing.Size(160, 24)
        Me.cboEstadoCivil.TabIndex = 68
        '
        'lblEstadoCivil
        '
        Me.lblEstadoCivil.AutoSize = True
        Me.lblEstadoCivil.Location = New System.Drawing.Point(580, 12)
        Me.lblEstadoCivil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstadoCivil.Name = "lblEstadoCivil"
        Me.lblEstadoCivil.Size = New System.Drawing.Size(78, 16)
        Me.lblEstadoCivil.TabIndex = 67
        Me.lblEstadoCivil.Text = "Estado Civil"
        '
        'lblDtNasc
        '
        Me.lblDtNasc.AutoSize = True
        Me.lblDtNasc.Location = New System.Drawing.Point(487, 12)
        Me.lblDtNasc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDtNasc.Name = "lblDtNasc"
        Me.lblDtNasc.Size = New System.Drawing.Size(79, 16)
        Me.lblDtNasc.TabIndex = 66
        Me.lblDtNasc.Text = "Nascimento"
        '
        'btnImpirmir
        '
        Me.btnImpirmir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.print_view
        Me.btnImpirmir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImpirmir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImpirmir.Location = New System.Drawing.Point(815, 524)
        Me.btnImpirmir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(118, 61)
        Me.btnImpirmir.TabIndex = 7
        Me.btnImpirmir.Text = "Imprimir"
        Me.btnImpirmir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImpirmir.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.ball_stop
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(563, 524)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(118, 61)
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
        Me.btnConsultar.Location = New System.Drawing.Point(689, 524)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(118, 61)
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
        Me.btnAlterar.Location = New System.Drawing.Point(437, 524)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(118, 61)
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
        Me.btnSalvar.Location = New System.Drawing.Point(311, 524)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(118, 61)
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
        Me.btnNovo.Location = New System.Drawing.Point(185, 524)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(118, 61)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nom, Me.RazaoSocial, Me.Nascimento, Me.EstadoCivil, Me.endereco, Me.Complemento, Me.bairro, Me.cidade, Me.estado, Me.cep, Me.Sexo, Me.rg, Me.cpf, Me.Obs, Me.Cadastro, Me.Alteracao, Me.Inativacao})
        Me.dgvCliente.Location = New System.Drawing.Point(7, 7)
        Me.dgvCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.RowHeadersWidth = 51
        Me.dgvCliente.Size = New System.Drawing.Size(1109, 462)
        Me.dgvCliente.TabIndex = 0
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
        Me.TabControl1.Controls.Add(Me.tbCadastro)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1128, 505)
        Me.TabControl1.TabIndex = 21
        '
        'tpListagem
        '
        Me.tpListagem.Controls.Add(Me.dgvCliente)
        Me.tpListagem.Location = New System.Drawing.Point(4, 25)
        Me.tpListagem.Name = "tpListagem"
        Me.tpListagem.Padding = New System.Windows.Forms.Padding(3)
        Me.tpListagem.Size = New System.Drawing.Size(1120, 476)
        Me.tpListagem.TabIndex = 0
        Me.tpListagem.Text = "Listagem"
        Me.tpListagem.UseVisualStyleBackColor = True
        '
        'tbCadastro
        '
        Me.tbCadastro.Controls.Add(Me.mskCel)
        Me.tbCadastro.Controls.Add(Me.txtNome)
        Me.tbCadastro.Controls.Add(Me.lblEmail)
        Me.tbCadastro.Controls.Add(Me.lblEstado)
        Me.tbCadastro.Controls.Add(Me.txtEmail)
        Me.tbCadastro.Controls.Add(Me.lblCidade)
        Me.tbCadastro.Controls.Add(Me.lblCelular)
        Me.tbCadastro.Controls.Add(Me.lblTelefone)
        Me.tbCadastro.Controls.Add(Me.mskDnascimento)
        Me.tbCadastro.Controls.Add(Me.lblBairro)
        Me.tbCadastro.Controls.Add(Me.cboEstadoCivil)
        Me.tbCadastro.Controls.Add(Me.lblCep)
        Me.tbCadastro.Controls.Add(Me.lblEstadoCivil)
        Me.tbCadastro.Controls.Add(Me.lblNome)
        Me.tbCadastro.Controls.Add(Me.lblDtNasc)
        Me.tbCadastro.Controls.Add(Me.lblCpf)
        Me.tbCadastro.Controls.Add(Me.mkdRg)
        Me.tbCadastro.Controls.Add(Me.lblEndereco)
        Me.tbCadastro.Controls.Add(Me.mkdCpf)
        Me.tbCadastro.Controls.Add(Me.lblRg)
        Me.tbCadastro.Controls.Add(Me.mkdCep)
        Me.tbCadastro.Controls.Add(Me.lblCodigo)
        Me.tbCadastro.Controls.Add(Me.mkdTelefone)
        Me.tbCadastro.Controls.Add(Me.txtCodigo)
        Me.tbCadastro.Controls.Add(Me.txtCidade)
        Me.tbCadastro.Controls.Add(Me.txtEndereco)
        Me.tbCadastro.Controls.Add(Me.txtEstado)
        Me.tbCadastro.Controls.Add(Me.txtBairro)
        Me.tbCadastro.Location = New System.Drawing.Point(4, 25)
        Me.tbCadastro.Name = "tbCadastro"
        Me.tbCadastro.Padding = New System.Windows.Forms.Padding(3)
        Me.tbCadastro.Size = New System.Drawing.Size(1120, 476)
        Me.tbCadastro.TabIndex = 1
        Me.tbCadastro.Text = "Cadastro"
        Me.tbCadastro.UseVisualStyleBackColor = True
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        Me.codigo.Width = 125
        '
        'nom
        '
        Me.nom.HeaderText = "Nome"
        Me.nom.MinimumWidth = 6
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        Me.nom.Width = 125
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
        Me.Obs.HeaderText = "Observacao"
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
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1152, 608)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnImpirmir)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnExcluir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tpListagem.ResumeLayout(False)
        Me.tbCadastro.ResumeLayout(False)
        Me.tbCadastro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents lblCep As System.Windows.Forms.Label
    Friend WithEvents lblCpf As System.Windows.Forms.Label
    Friend WithEvents lblRg As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents mkdTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkdCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkdCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkdRg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents btnImpirmir As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents mskCel As MaskedTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblCelular As Label
    Friend WithEvents mskDnascimento As MaskedTextBox
    Friend WithEvents cboEstadoCivil As ComboBox
    Friend WithEvents lblEstadoCivil As Label
    Friend WithEvents lblDtNasc As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpListagem As TabPage
    Friend WithEvents tbCadastro As TabPage
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents nom As DataGridViewTextBoxColumn
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
