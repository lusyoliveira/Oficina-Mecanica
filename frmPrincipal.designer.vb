<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InícioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriarUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermissãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncináriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeçasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VeículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 933)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1379, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(96, 20)
        Me.ToolStripStatusLabel1.Text = "Bem - Vindo!"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InícioToolStripMenuItem, Me.CadastrosToolStripMenuItem, Me.ServiçosToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1379, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InícioToolStripMenuItem
        '
        Me.InícioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CriarUsuárioToolStripMenuItem, Me.ConfiguraçõesToolStripMenuItem})
        Me.InícioToolStripMenuItem.Name = "InícioToolStripMenuItem"
        Me.InícioToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.InícioToolStripMenuItem.Text = "Início"
        '
        'CriarUsuárioToolStripMenuItem
        '
        Me.CriarUsuárioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoUsuárioToolStripMenuItem, Me.PermissãoToolStripMenuItem})
        Me.CriarUsuárioToolStripMenuItem.Name = "CriarUsuárioToolStripMenuItem"
        Me.CriarUsuárioToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.CriarUsuárioToolStripMenuItem.Text = "Criar Usuário"
        '
        'NovoUsuárioToolStripMenuItem
        '
        Me.NovoUsuárioToolStripMenuItem.Name = "NovoUsuárioToolStripMenuItem"
        Me.NovoUsuárioToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.NovoUsuárioToolStripMenuItem.Text = "Novo Usuário"
        '
        'PermissãoToolStripMenuItem
        '
        Me.PermissãoToolStripMenuItem.Name = "PermissãoToolStripMenuItem"
        Me.PermissãoToolStripMenuItem.Size = New System.Drawing.Size(182, 26)
        Me.PermissãoToolStripMenuItem.Text = "Permissão"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FuncináriosToolStripMenuItem, Me.PeçasToolStripMenuItem, Me.VeículosToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FuncináriosToolStripMenuItem
        '
        Me.FuncináriosToolStripMenuItem.Name = "FuncináriosToolStripMenuItem"
        Me.FuncináriosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.FuncináriosToolStripMenuItem.Text = "Funcionários"
        '
        'PeçasToolStripMenuItem
        '
        Me.PeçasToolStripMenuItem.Name = "PeçasToolStripMenuItem"
        Me.PeçasToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PeçasToolStripMenuItem.Text = "Peças"
        '
        'VeículosToolStripMenuItem
        '
        Me.VeículosToolStripMenuItem.Name = "VeículosToolStripMenuItem"
        Me.VeículosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.VeículosToolStripMenuItem.Text = "Veículos"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FToolStripMenuItem})
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(77, 24)
        Me.ServiçosToolStripMenuItem.Text = "Serviços"
        '
        'FToolStripMenuItem
        '
        Me.FToolStripMenuItem.Name = "FToolStripMenuItem"
        Me.FToolStripMenuItem.Size = New System.Drawing.Size(204, 26)
        Me.FToolStripMenuItem.Text = "Fazer Orçamento"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(48, 24)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 959)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPrincipal"
        Me.Text = "Oficina Mecânica"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InícioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriarUsuárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncináriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeçasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VeículosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiçosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovoUsuárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermissãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
