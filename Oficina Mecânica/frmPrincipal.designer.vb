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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.InícioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CriarUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NovoUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PermissãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FuncináriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PeçasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VeículosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ServiçosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 757)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1034, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(76, 17)
        Me.ToolStripStatusLabel1.Text = "Bem - Vindo!"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InícioToolStripMenuItem, Me.CadastrosToolStripMenuItem, Me.ServiçosToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1034, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InícioToolStripMenuItem
        '
        Me.InícioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CriarUsuárioToolStripMenuItem, Me.ConfiguraçõesToolStripMenuItem})
        Me.InícioToolStripMenuItem.Image = Global.Oficina_Mecânica.My.Resources.Resources.mobsync_09
        Me.InícioToolStripMenuItem.Name = "InícioToolStripMenuItem"
        Me.InícioToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.InícioToolStripMenuItem.Text = "Início"
        '
        'CriarUsuárioToolStripMenuItem
        '
        Me.CriarUsuárioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoUsuárioToolStripMenuItem, Me.PermissãoToolStripMenuItem})
        Me.CriarUsuárioToolStripMenuItem.Image = Global.Oficina_Mecânica.My.Resources.Resources.ntshrui_07
        Me.CriarUsuárioToolStripMenuItem.Name = "CriarUsuárioToolStripMenuItem"
        Me.CriarUsuárioToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CriarUsuárioToolStripMenuItem.Text = "Criar Usuário"
        '
        'NovoUsuárioToolStripMenuItem
        '
        Me.NovoUsuárioToolStripMenuItem.Name = "NovoUsuárioToolStripMenuItem"
        Me.NovoUsuárioToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.NovoUsuárioToolStripMenuItem.Text = "Novo Usuário"
        '
        'PermissãoToolStripMenuItem
        '
        Me.PermissãoToolStripMenuItem.Name = "PermissãoToolStripMenuItem"
        Me.PermissãoToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.PermissãoToolStripMenuItem.Text = "Permissão"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.FuncináriosToolStripMenuItem, Me.PeçasToolStripMenuItem, Me.VeículosToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Image = Global.Oficina_Mecânica.My.Resources.Resources.ntshrui_08
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = Global.Oficina_Mecânica.My.Resources.Resources.ntshrui_06
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'FuncináriosToolStripMenuItem
        '
        Me.FuncináriosToolStripMenuItem.Image = Global.Oficina_Mecânica.My.Resources.Resources.p2phost_1
        Me.FuncináriosToolStripMenuItem.Name = "FuncináriosToolStripMenuItem"
        Me.FuncináriosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.FuncináriosToolStripMenuItem.Text = "Funcionários"
        '
        'PeçasToolStripMenuItem
        '
        Me.PeçasToolStripMenuItem.Image = Global.Oficina_Mecânica.My.Resources.Resources.mstsc
        Me.PeçasToolStripMenuItem.Name = "PeçasToolStripMenuItem"
        Me.PeçasToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PeçasToolStripMenuItem.Text = "Peças"
        '
        'VeículosToolStripMenuItem
        '
        Me.VeículosToolStripMenuItem.Name = "VeículosToolStripMenuItem"
        Me.VeículosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.VeículosToolStripMenuItem.Text = "Veículos"
        '
        'ServiçosToolStripMenuItem
        '
        Me.ServiçosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FToolStripMenuItem})
        Me.ServiçosToolStripMenuItem.Image = Global.Oficina_Mecânica.My.Resources.Resources.calc
        Me.ServiçosToolStripMenuItem.Name = "ServiçosToolStripMenuItem"
        Me.ServiçosToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ServiçosToolStripMenuItem.Text = "Serviços"
        '
        'FToolStripMenuItem
        '
        Me.FToolStripMenuItem.Image = Global.Oficina_Mecânica.My.Resources.Resources.notepad
        Me.FToolStripMenuItem.Name = "FToolStripMenuItem"
        Me.FToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.FToolStripMenuItem.Text = "Fazer Orçamento"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1034, 779)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
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
