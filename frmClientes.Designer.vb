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
        Me.gpbClientes = New System.Windows.Forms.GroupBox()
        Me.Grade = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.endereco = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bairro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cpf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.btnImpirmir = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.gpbClientes.SuspendLayout()
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 24)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "Codigo"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Location = New System.Drawing.Point(417, 24)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(53, 13)
        Me.lblEndereco.TabIndex = 1
        Me.lblEndereco.Text = "Endere�o"
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Location = New System.Drawing.Point(81, 24)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(35, 13)
        Me.lblNome.TabIndex = 2
        Me.lblNome.Text = "Nome"
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Location = New System.Drawing.Point(12, 64)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(34, 13)
        Me.lblBairro.TabIndex = 3
        Me.lblBairro.Text = "Bairro"
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(393, 64)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(40, 13)
        Me.lblCidade.TabIndex = 4
        Me.lblCidade.Text = "Cidade"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(201, 64)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(40, 13)
        Me.lblEstado.TabIndex = 5
        Me.lblEstado.Text = "Estado"
        '
        'lblTelefone
        '
        Me.lblTelefone.AutoSize = True
        Me.lblTelefone.Location = New System.Drawing.Point(12, 103)
        Me.lblTelefone.Name = "lblTelefone"
        Me.lblTelefone.Size = New System.Drawing.Size(49, 13)
        Me.lblTelefone.TabIndex = 6
        Me.lblTelefone.Text = "Telefone"
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Location = New System.Drawing.Point(616, 65)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(28, 13)
        Me.lblCep.TabIndex = 7
        Me.lblCep.Text = "CEP"
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Location = New System.Drawing.Point(117, 103)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(27, 13)
        Me.lblCpf.TabIndex = 8
        Me.lblCpf.Text = "CPF"
        '
        'lblRg
        '
        Me.lblRg.AutoSize = True
        Me.lblRg.Location = New System.Drawing.Point(222, 103)
        Me.lblRg.Name = "lblRg"
        Me.lblRg.Size = New System.Drawing.Size(23, 13)
        Me.lblRg.TabIndex = 9
        Me.lblRg.Text = "RG"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(15, 39)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(63, 20)
        Me.txtCodigo.TabIndex = 10
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(83, 40)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(332, 20)
        Me.txtNome.TabIndex = 11
        '
        'txtEndereco
        '
        Me.txtEndereco.Location = New System.Drawing.Point(420, 40)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(318, 20)
        Me.txtEndereco.TabIndex = 12
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(15, 80)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(184, 20)
        Me.txtBairro.TabIndex = 13
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(204, 80)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(187, 20)
        Me.txtEstado.TabIndex = 14
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(396, 80)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(218, 20)
        Me.txtCidade.TabIndex = 15
        '
        'mkdTelefone
        '
        Me.mkdTelefone.Location = New System.Drawing.Point(15, 119)
        Me.mkdTelefone.Mask = "(000) 0000 - 0000"
        Me.mkdTelefone.Name = "mkdTelefone"
        Me.mkdTelefone.Size = New System.Drawing.Size(100, 20)
        Me.mkdTelefone.TabIndex = 16
        '
        'mkdCep
        '
        Me.mkdCep.Location = New System.Drawing.Point(620, 80)
        Me.mkdCep.Mask = "00000 - 000"
        Me.mkdCep.Name = "mkdCep"
        Me.mkdCep.Size = New System.Drawing.Size(119, 20)
        Me.mkdCep.TabIndex = 17
        '
        'mkdCpf
        '
        Me.mkdCpf.Location = New System.Drawing.Point(120, 119)
        Me.mkdCpf.Mask = "000.000.000 - 00"
        Me.mkdCpf.Name = "mkdCpf"
        Me.mkdCpf.Size = New System.Drawing.Size(100, 20)
        Me.mkdCpf.TabIndex = 18
        '
        'mkdRg
        '
        Me.mkdRg.Location = New System.Drawing.Point(225, 119)
        Me.mkdRg.Mask = "MG - 00.000.000"
        Me.mkdRg.Name = "mkdRg"
        Me.mkdRg.Size = New System.Drawing.Size(100, 20)
        Me.mkdRg.TabIndex = 19
        '
        'gpbClientes
        '
        Me.gpbClientes.Controls.Add(Me.mkdRg)
        Me.gpbClientes.Controls.Add(Me.btnImpirmir)
        Me.gpbClientes.Controls.Add(Me.mkdCpf)
        Me.gpbClientes.Controls.Add(Me.mkdCep)
        Me.gpbClientes.Controls.Add(Me.btnExcluir)
        Me.gpbClientes.Controls.Add(Me.mkdTelefone)
        Me.gpbClientes.Controls.Add(Me.btnConsultar)
        Me.gpbClientes.Controls.Add(Me.txtCidade)
        Me.gpbClientes.Controls.Add(Me.btnAlterar)
        Me.gpbClientes.Controls.Add(Me.txtEstado)
        Me.gpbClientes.Controls.Add(Me.btnSalvar)
        Me.gpbClientes.Controls.Add(Me.txtBairro)
        Me.gpbClientes.Controls.Add(Me.btnNovo)
        Me.gpbClientes.Controls.Add(Me.txtEndereco)
        Me.gpbClientes.Controls.Add(Me.Grade)
        Me.gpbClientes.Controls.Add(Me.txtNome)
        Me.gpbClientes.Controls.Add(Me.txtCodigo)
        Me.gpbClientes.Controls.Add(Me.lblCodigo)
        Me.gpbClientes.Controls.Add(Me.lblRg)
        Me.gpbClientes.Controls.Add(Me.lblEndereco)
        Me.gpbClientes.Controls.Add(Me.lblCpf)
        Me.gpbClientes.Controls.Add(Me.lblNome)
        Me.gpbClientes.Controls.Add(Me.lblCep)
        Me.gpbClientes.Controls.Add(Me.lblBairro)
        Me.gpbClientes.Controls.Add(Me.lblTelefone)
        Me.gpbClientes.Controls.Add(Me.lblCidade)
        Me.gpbClientes.Controls.Add(Me.lblEstado)
        Me.gpbClientes.Location = New System.Drawing.Point(10, 11)
        Me.gpbClientes.Name = "gpbClientes"
        Me.gpbClientes.Size = New System.Drawing.Size(841, 596)
        Me.gpbClientes.TabIndex = 20
        Me.gpbClientes.TabStop = False
        '
        'Grade
        '
        Me.Grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grade.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nom, Me.endereco, Me.bairro, Me.cidade, Me.estado, Me.telefone, Me.cep, Me.cpf, Me.rg})
        Me.Grade.Location = New System.Drawing.Point(14, 143)
        Me.Grade.Name = "Grade"
        Me.Grade.RowHeadersWidth = 51
        Me.Grade.Size = New System.Drawing.Size(723, 420)
        Me.Grade.TabIndex = 0
        '
        'codigo
        '
        Me.codigo.HeaderText = "C�digo"
        Me.codigo.MinimumWidth = 6
        Me.codigo.Name = "codigo"
        Me.codigo.Width = 125
        '
        'nom
        '
        Me.nom.HeaderText = "Nome"
        Me.nom.MinimumWidth = 6
        Me.nom.Name = "nom"
        Me.nom.Width = 125
        '
        'endereco
        '
        Me.endereco.HeaderText = "Endere�o"
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
        'btnImpirmir
        '
        Me.btnImpirmir.BackgroundImage = Global.OficinaMecanica.My.Resources.Resources.print_view
        Me.btnImpirmir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImpirmir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImpirmir.Location = New System.Drawing.Point(748, 439)
        Me.btnImpirmir.Name = "btnImpirmir"
        Me.btnImpirmir.Size = New System.Drawing.Size(82, 34)
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
        Me.btnExcluir.Location = New System.Drawing.Point(748, 334)
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
        Me.btnConsultar.Location = New System.Drawing.Point(748, 385)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(82, 34)
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
        Me.btnAlterar.Location = New System.Drawing.Point(748, 280)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(82, 34)
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
        Me.btnSalvar.Location = New System.Drawing.Point(748, 225)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(82, 34)
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
        Me.btnNovo.Location = New System.Drawing.Point(748, 169)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(82, 34)
        Me.btnNovo.TabIndex = 1
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 628)
        Me.Controls.Add(Me.gpbClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Clientes"
        Me.gpbClientes.ResumeLayout(False)
        Me.gpbClientes.PerformLayout()
        CType(Me.Grade, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents gpbClientes As System.Windows.Forms.GroupBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnNovo As System.Windows.Forms.Button
    Friend WithEvents Grade As System.Windows.Forms.DataGridView
    Friend WithEvents btnImpirmir As System.Windows.Forms.Button
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
