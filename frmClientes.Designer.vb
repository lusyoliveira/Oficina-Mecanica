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
        Me.lblCodigo = New System.Windows.Forms.Label
        Me.lblEndereco = New System.Windows.Forms.Label
        Me.lblNome = New System.Windows.Forms.Label
        Me.lblBairro = New System.Windows.Forms.Label
        Me.lblCidade = New System.Windows.Forms.Label
        Me.lblEstado = New System.Windows.Forms.Label
        Me.lblTelefone = New System.Windows.Forms.Label
        Me.lblCep = New System.Windows.Forms.Label
        Me.lblCpf = New System.Windows.Forms.Label
        Me.lblRg = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.txtEndereco = New System.Windows.Forms.TextBox
        Me.txtBairro = New System.Windows.Forms.TextBox
        Me.txtEstado = New System.Windows.Forms.TextBox
        Me.txtCidade = New System.Windows.Forms.TextBox
        Me.mkdTelefone = New System.Windows.Forms.MaskedTextBox
        Me.mkdCep = New System.Windows.Forms.MaskedTextBox
        Me.mkdCpf = New System.Windows.Forms.MaskedTextBox
        Me.mkdRg = New System.Windows.Forms.MaskedTextBox
        Me.gpbClientes = New System.Windows.Forms.GroupBox
        Me.btnImpirmir = New System.Windows.Forms.Button
        Me.btnSair = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.btnNovo = New System.Windows.Forms.Button
        Me.Grade = New System.Windows.Forms.DataGridView
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.endereco = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bairro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cidade = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.telefone = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cep = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.rg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.gpbClientes.SuspendLayout()
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(130, 51)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Codigo"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(535, 51)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(53, 13)
        Me.lblEndereco.TabIndex = 1
        Me.lblEndereco.Text = "Endereço"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(251, 51)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 2
        Me.lblNome.Text = "Nome"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(130, 122)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(34, 13)
        Me.lblBairro.TabIndex = 3
        Me.lblBairro.Text = "Bairro"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(511, 122)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(40, 13)
        Me.lblCidade.TabIndex = 4
        Me.lblCidade.Text = "Cidade"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(319, 122)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 5
        Me.lblEstado.Text = "Estado"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(130, 181)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefone.TabIndex = 6
        Me.lblTelefone.Text = "Telefone"
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(302, 181)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(28, 13)
        Me.lblCep.TabIndex = 7
        Me.lblCep.Text = "CEP"
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(469, 181)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(27, 13)
        Me.lblCpf.TabIndex = 8
        Me.lblCpf.Text = "CPF"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(629, 181)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(23, 13)
        Me.lblRg.TabIndex = 9
        Me.lblRg.Text = "RG"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(133, 67)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(63, 20)
        Me.txtCodigo.TabIndex = 10
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(254, 67)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(226, 20)
        Me.txtNome.TabIndex = 11
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(538, 67)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(226, 20)
        Me.txtEndereco.TabIndex = 12
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(133, 138)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(131, 20)
        Me.txtBairro.TabIndex = 13
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(322, 138)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(131, 20)
        Me.txtEstado.TabIndex = 14
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(514, 138)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(131, 20)
        Me.txtCidade.TabIndex = 15
        '
        'mkdTelefone
        '
        Me.mkdTelefone.Location = New System.Drawing.Point(133, 197)
        Me.mkdTelefone.Mask = "(000) 0000 - 0000"
        Me.mkdTelefone.Name = "mkdTelefone"
        Me.mkdTelefone.Size = New System.Drawing.Size(100, 20)
        Me.mkdTelefone.TabIndex = 16
        '
        'mkdCep
        '
        Me.mkdCep.Location = New System.Drawing.Point(305, 197)
        Me.mkdCep.Mask = "00000 - 000"
        Me.mkdCep.Name = "mkdCep"
        Me.mkdCep.Size = New System.Drawing.Size(100, 20)
        Me.mkdCep.TabIndex = 17
        '
        'mkdCpf
        '
        Me.mkdCpf.Location = New System.Drawing.Point(472, 197)
        Me.mkdCpf.Mask = "000.000.000 - 00"
        Me.mkdCpf.Name = "mkdCpf"
        Me.mkdCpf.Size = New System.Drawing.Size(100, 20)
        Me.mkdCpf.TabIndex = 18
        '
        'mkdRg
        '
        Me.mkdRg.Location = New System.Drawing.Point(632, 197)
        Me.mkdRg.Mask = "MG - 00.000.000"
        Me.mkdRg.Name = "mkdRg"
        Me.mkdRg.Size = New System.Drawing.Size(100, 20)
        Me.mkdRg.TabIndex = 19
        '
        'gpbClientes
        '
        Me.gpbClientes.Controls.Add(Me.btnImpirmir)
        Me.gpbClientes.Controls.Add(Me.btnSair)
        Me.gpbClientes.Controls.Add(Me.btnExcluir)
        Me.gpbClientes.Controls.Add(Me.btnConsultar)
        Me.gpbClientes.Controls.Add(Me.btnAlterar)
        Me.gpbClientes.Controls.Add(Me.btnSalvar)
        Me.gpbClientes.Controls.Add(Me.btnNovo)
        Me.gpbClientes.Controls.Add(Me.Grade)
        Me.gpbClientes.Location = New System.Drawing.Point(104, 19)
        Me.gpbClientes.Name = "gpbClientes"
        Me.gpbClientes.Size = New System.Drawing.Size(1087, 650)
        Me.gpbClientes.TabIndex = 20
        Me.gpbClientes.TabStop = False
        '
        'btnImpirmir
        '
        Me.btnImpirmir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImpirmir.Location = New System.Drawing.Point(968, 448)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(82, 34)
        Me.btnImpirmir.TabIndex = 7
        Me.btnImpirmir.Text = "Imprimir"
        Me.btnImpirmir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnImpirmir.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSair.Location = New System.Drawing.Point(968, 498)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(82, 34)
        Me.btnSair.TabIndex = 6
        Me.btnSair.Text = "Sair"
        Me.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(968, 343)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(82, 34)
        Me.btnExcluir.TabIndex = 5
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(968, 394)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(82, 34)
        Me.btnConsultar.TabIndex = 4
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(968, 289)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(82, 34)
        Me.btnAlterar.TabIndex = 3
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalvar.Location = New System.Drawing.Point(968, 234)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(82, 34)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnNovo
        '
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(968, 178)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(82, 34)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Grade
        '
        Me.Grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nom, Me.endereco, Me.bairro, Me.cidade, Me.estado, Me.telefone, Me.cep, Me.cpf, Me.rg})
        Me.Grade.Location = New System.Drawing.Point(29, 213)
        Me.Grade.Name = "Grade"
        Me.Grade.Size = New System.Drawing.Size(898, 420)
        Me.Grade.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "Código"
        Me.codigo.Name = "codigo"
        '
        'nom
        '
        Me.nom.HeaderText = "Nome"
        Me.nom.Name = "nom"
        '
        'endereco
        '
        Me.endereco.HeaderText = "Endereço"
        Me.endereco.Name = "endereco"
        '
        'bairro
        '
        Me.bairro.HeaderText = "Bairro"
        Me.bairro.Name = "bairro"
        '
        'cidade
        '
        Me.cidade.HeaderText = "Cidade"
        Me.cidade.Name = "cidade"
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        '
        'telefone
        '
        Me.telefone.HeaderText = "Telefone"
        Me.telefone.Name = "telefone"
        '
        'cep
        '
        Me.cep.HeaderText = "CEP"
        Me.cep.Name = "cep"
        '
        'cpf
        '
        Me.cpf.HeaderText = "CPF"
        Me.cpf.Name = "cpf"
        '
        'rg
        '
        Me.rg.HeaderText = "RG"
        Me.rg.Name = "rg"
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
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 704)
        Me.Controls.Add(Me.mkdRg)
        Me.Controls.Add(Me.mkdCpf)
        Me.Controls.Add(Me.mkdCep)
        Me.Controls.Add(Me.mkdTelefone)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblRg)
        Me.Controls.Add(Me.lblCpf)
        Me.Controls.Add(Me.lblCep)
        Me.Controls.Add(Me.lblTelefone)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.lblNome)
        Me.Controls.Add(Me.lblEndereco)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.gpbClientes)
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gpbClientes.ResumeLayout(False)
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents gpbClientes As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents Grade As System.Windows.Forms.DataGridView
    Friend WithEvents btnImpirmir As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents endereco As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bairro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cpf As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog

End Class
