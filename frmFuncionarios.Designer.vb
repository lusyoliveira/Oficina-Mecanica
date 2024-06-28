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
        Me.mkdTelefone = New System.Windows.Forms.MaskedTextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.btnImpirmir = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
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
        Me.endereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.lblTelefone = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.gpbClientes = New System.Windows.Forms.GroupBox()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.lblSalario = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'mkdRg
        '
        Me.mkdRg.Location = New System.Drawing.Point(301, 134)
        Me.mkdRg.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdRg.Mask = "MG - 00.000.000"
        Me.mkdRg.Name = "mkdRg"
        Me.mkdRg.Size = New System.Drawing.Size(132, 22)
        Me.mkdRg.TabIndex = 40
        '
        'mkdCpf
        '
        Me.mkdCpf.Location = New System.Drawing.Point(161, 134)
        Me.mkdCpf.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdCpf.Mask = "000.000.000-00"
        Me.mkdCpf.Name = "mkdCpf"
        Me.mkdCpf.Size = New System.Drawing.Size(132, 22)
        Me.mkdCpf.TabIndex = 39
        '
        'mkdCep
        '
        Me.mkdCep.Location = New System.Drawing.Point(670, 89)
        Me.mkdCep.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdCep.Mask = "00000-000"
        Me.mkdCep.Name = "mkdCep"
        Me.mkdCep.Size = New System.Drawing.Size(132, 22)
        Me.mkdCep.TabIndex = 38
        '
        'mkdTelefone
        '
        Me.mkdTelefone.Location = New System.Drawing.Point(20, 134)
        Me.mkdTelefone.Margin = New System.Windows.Forms.Padding(4)
        Me.mkdTelefone.Mask = "(000) 0000-0000"
        Me.mkdTelefone.Name = "mkdTelefone"
        Me.mkdTelefone.Size = New System.Drawing.Size(132, 22)
        Me.mkdTelefone.TabIndex = 37
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(489, 89)
        Me.txtCidade.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(173, 22)
        Me.txtCidade.TabIndex = 36
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(301, 89)
        Me.txtEstado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(180, 22)
        Me.txtEstado.TabIndex = 35
        '
        'btnImpirmir
        '
        Me.btnImpirmir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImpirmir.Location = New System.Drawing.Point(1343, 569)
        Me.btnImpirmir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(109, 42)
        Me.btnImpirmir.TabIndex = 7
        Me.btnImpirmir.Text = "Imprimir"
        Me.btnImpirmir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImpirmir.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(1343, 507)
        Me.btnSair.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(109, 42)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(20, 89)
        Me.txtBairro.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(273, 22)
        Me.txtBairro.TabIndex = 34
        '
        'btnExcluir
        '
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(1343, 381)
        Me.btnExcluir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(109, 42)
        Me.btnExcluir.TabIndex = 5
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(1343, 443)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(109, 42)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(1343, 321)
        Me.btnAlterar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(109, 42)
        Me.btnAlterar.TabIndex = 3
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(1343, 252)
        Me.btnSalvar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(109, 42)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(1343, 181)
        Me.btnNovo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(109, 42)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(489, 39)
        Me.txtEndereco.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(313, 22)
        Me.txtEndereco.TabIndex = 33
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(111, 39)
        Me.txtNome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(370, 22)
        Me.txtNome.TabIndex = 32
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(20, 39)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(83, 22)
        Me.txtCodigo.TabIndex = 31
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(297, 114)
        Me.lblRg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(27, 16)
        Me.lblRg.TabIndex = 30
        Me.lblRg.Text = "RG"
        '
        'Grade
        '
        Me.Grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nome, Me.endereco, Me.bairro, Me.cidade, Me.estado, Me.telefone, Me.cep, Me.cpf, Me.rg, Me.cargo, Me.salario})
        Me.Grade.Location = New System.Drawing.Point(20, 164)
        Me.Grade.Margin = New System.Windows.Forms.Padding(4)
        Me.Grade.Name = "Grade"
        Me.Grade.RowHeadersWidth = 51
        Me.Grade.Size = New System.Drawing.Size(1316, 473)
        Me.Grade.TabIndex = 0
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
        'endereco
        '
        Me.endereco.HeaderText = "Endereço"
        Me.endereco.MinimumWidth = 6
        Me.endereco.Name = "endereco"
        Me.endereco.Width = 125
        '
        'bairro
        '
        Me.bairro.HeaderText = "Bairro"
        Me.bairro.MinimumWidth = 6
        Me.bairro.Name = "bairro"
        Me.bairro.Width = 125
        '
        'cidade
        '
        Me.cidade.HeaderText = "Cidade"
        Me.cidade.MinimumWidth = 6
        Me.cidade.Name = "cidade"
        Me.cidade.Width = 125
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.MinimumWidth = 6
        Me.estado.Name = "estado"
        Me.estado.Width = 125
        '
        'telefone
        '
        Me.telefone.HeaderText = "Telefone"
        Me.telefone.MinimumWidth = 6
        Me.telefone.Name = "telefone"
        Me.telefone.Width = 125
        '
        'cep
        '
        Me.cep.HeaderText = "CEP"
        Me.cep.MinimumWidth = 6
        Me.cep.Name = "cep"
        Me.cep.Width = 125
        '
        'cpf
        '
        Me.cpf.HeaderText = "CPF"
        Me.cpf.MinimumWidth = 6
        Me.cpf.Name = "cpf"
        Me.cpf.Width = 125
        '
        'rg
        '
        Me.rg.HeaderText = "RG"
        Me.rg.MinimumWidth = 6
        Me.rg.Name = "rg"
        Me.rg.Width = 125
        '
        'cargo
        '
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.MinimumWidth = 6
        Me.cargo.Name = "cargo"
        Me.cargo.Width = 125
        '
        'salario
        '
        Me.salario.HeaderText = "Salário"
        Me.salario.MinimumWidth = 6
        Me.salario.Name = "salario"
        Me.salario.Width = 125
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(157, 114)
        Me.lblCpf.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(33, 16)
        Me.lblCpf.TabIndex = 29
        Me.lblCpf.Text = "CPF"
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(666, 69)
        Me.lblCep.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(34, 16)
        Me.lblCep.TabIndex = 28
        Me.lblCep.Text = "CEP"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(16, 115)
        Me.lblTelefone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(61, 16)
        Me.lblTelefone.TabIndex = 27
        Me.lblTelefone.Text = "Telefone"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(297, 69)
        Me.lblEstado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(50, 16)
        Me.lblEstado.TabIndex = 26
        Me.lblEstado.Text = "Estado"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(485, 69)
        Me.lblCidade.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(51, 16)
        Me.lblCidade.TabIndex = 25
        Me.lblCidade.Text = "Cidade"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(16, 69)
        Me.lblBairro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(43, 16)
        Me.lblBairro.TabIndex = 24
        Me.lblBairro.Text = "Bairro"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(107, 19)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(44, 16)
        Me.lblNome.TabIndex = 23
        Me.lblNome.Text = "Nome"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(485, 19)
        Me.lblEndereco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(66, 16)
        Me.lblEndereco.TabIndex = 22
        Me.lblEndereco.Text = "Endereço"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(16, 19)
        Me.lblCodigo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(51, 16)
        Me.lblCodigo.TabIndex = 21
        Me.lblCodigo.Text = "Codigo"
        '
        'gpbClientes
        '
        Me.gpbClientes.Controls.Add(Me.txtCidade)
        Me.gpbClientes.Controls.Add(Me.lblCidade)
        Me.gpbClientes.Controls.Add(Me.txtSalario)
        Me.gpbClientes.Controls.Add(Me.txtEstado)
        Me.gpbClientes.Controls.Add(Me.lblEstado)
        Me.gpbClientes.Controls.Add(Me.lblSalario)
        Me.gpbClientes.Controls.Add(Me.txtBairro)
        Me.gpbClientes.Controls.Add(Me.txtCargo)
        Me.gpbClientes.Controls.Add(Me.txtEndereco)
        Me.gpbClientes.Controls.Add(Me.lblBairro)
        Me.gpbClientes.Controls.Add(Me.mkdRg)
        Me.gpbClientes.Controls.Add(Me.txtNome)
        Me.gpbClientes.Controls.Add(Me.lblCargo)
        Me.gpbClientes.Controls.Add(Me.txtCodigo)
        Me.gpbClientes.Controls.Add(Me.mkdCpf)
        Me.gpbClientes.Controls.Add(Me.btnImpirmir)
        Me.gpbClientes.Controls.Add(Me.mkdCep)
        Me.gpbClientes.Controls.Add(Me.lblNome)
        Me.gpbClientes.Controls.Add(Me.btnSair)
        Me.gpbClientes.Controls.Add(Me.lblEndereco)
        Me.gpbClientes.Controls.Add(Me.btnExcluir)
        Me.gpbClientes.Controls.Add(Me.lblCodigo)
        Me.gpbClientes.Controls.Add(Me.mkdTelefone)
        Me.gpbClientes.Controls.Add(Me.btnConsultar)
        Me.gpbClientes.Controls.Add(Me.btnAlterar)
        Me.gpbClientes.Controls.Add(Me.btnSalvar)
        Me.gpbClientes.Controls.Add(Me.btnNovo)
        Me.gpbClientes.Controls.Add(Me.lblRg)
        Me.gpbClientes.Controls.Add(Me.Grade)
        Me.gpbClientes.Controls.Add(Me.lblCpf)
        Me.gpbClientes.Controls.Add(Me.lblTelefone)
        Me.gpbClientes.Controls.Add(Me.lblCep)
        Me.gpbClientes.Location = New System.Drawing.Point(13, 13)
        Me.gpbClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.gpbClientes.Name = "gpbClientes"
        Me.gpbClientes.Padding = New System.Windows.Forms.Padding(4)
        Me.gpbClientes.Size = New System.Drawing.Size(1473, 659)
        Me.gpbClientes.TabIndex = 41
        Me.gpbClientes.TabStop = False
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(629, 134)
        Me.txtSalario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(173, 22)
        Me.txtSalario.TabIndex = 45
        '
        'lblSalario
        '
        Me.lblSalario.AutoSize = True
        Me.lblSalario.Location = New System.Drawing.Point(625, 114)
        Me.lblSalario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalario.Name = "lblSalario"
        Me.lblSalario.Size = New System.Drawing.Size(50, 16)
        Me.lblSalario.TabIndex = 44
        Me.lblSalario.Text = "Salário"
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(441, 134)
        Me.txtCargo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(173, 22)
        Me.txtCargo.TabIndex = 43
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(437, 114)
        Me.lblCargo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(44, 16)
        Me.lblCargo.TabIndex = 42
        Me.lblCargo.Text = "Cargo"
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
        'frmFuncionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1509, 694)
        Me.Controls.Add(Me.gpbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmFuncionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Funcionários"
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbClientes.ResumeLayout(False)
        Me.gpbClientes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents mkdRg As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkdCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkdCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mkdTelefone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents btnImpirmir As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
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
    Friend WithEvents lblTelefone As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents lblBairro As System.Windows.Forms.Label
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents lblEndereco As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents gpbClientes As System.Windows.Forms.GroupBox
    Friend WithEvents txtSalario As System.Windows.Forms.TextBox
    Friend WithEvents lblSalario As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nome As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents endereco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bairro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cpf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents salario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
End Class
