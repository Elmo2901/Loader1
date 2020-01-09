<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loader
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loader))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Senhas = New System.Windows.Forms.TextBox()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.But_Cance1 = New System.Windows.Forms.Button()
        Me.But_Confi1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Txt_SenhaAdm = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.But_Pesqui = New System.Windows.Forms.Button()
        Me.Txt_Program = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CMB_Tipo = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.IncluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfigurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VoltarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.But_Cance2 = New System.Windows.Forms.Button()
        Me.Txt_RedSen = New System.Windows.Forms.TextBox()
        Me.But_Confi2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_SenSen = New System.Windows.Forms.TextBox()
        Me.Txt_NomSen = New System.Windows.Forms.TextBox()
        Me.Txt_CodSen = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 25)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Sistema Loader"
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PanelBarraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelBarraTitulo.Controls.Add(Me.PictureBox2)
        Me.PanelBarraTitulo.Controls.Add(Me.PictureBox1)
        Me.PanelBarraTitulo.Controls.Add(Me.Label1)
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(3, 2)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(387, 38)
        Me.PanelBarraTitulo.TabIndex = 35
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(358, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 24)
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(332, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 24)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 322)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(909, 22)
        Me.StatusStrip1.TabIndex = 41
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        Me.ToolStripStatusLabel2.Text = "Seja Bem Vindo ao Sistema EsteCli"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(149, 17)
        Me.ToolStripStatusLabel3.Text = "Seja Bem Vindo ao Sistema"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Txt_Senhas)
        Me.Panel3.Controls.Add(Me.Txt_Usuario)
        Me.Panel3.Controls.Add(Me.But_Cance1)
        Me.Panel3.Controls.Add(Me.But_Confi1)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(134, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(241, 176)
        Me.Panel3.TabIndex = 43
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(240, 38)
        Me.Panel4.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 25)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Senha do Sistema"
        '
        'Txt_Senhas
        '
        Me.Txt_Senhas.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_Senhas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Senhas.Location = New System.Drawing.Point(55, 84)
        Me.Txt_Senhas.MaxLength = 40
        Me.Txt_Senhas.Name = "Txt_Senhas"
        Me.Txt_Senhas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Senhas.Size = New System.Drawing.Size(149, 20)
        Me.Txt_Senhas.TabIndex = 1
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_Usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Usuario.Location = New System.Drawing.Point(55, 49)
        Me.Txt_Usuario.MaxLength = 40
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(149, 20)
        Me.Txt_Usuario.TabIndex = 0
        '
        'But_Cance1
        '
        Me.But_Cance1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.But_Cance1.Image = CType(resources.GetObject("But_Cance1.Image"), System.Drawing.Image)
        Me.But_Cance1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.But_Cance1.Location = New System.Drawing.Point(122, 121)
        Me.But_Cance1.Name = "But_Cance1"
        Me.But_Cance1.Size = New System.Drawing.Size(82, 31)
        Me.But_Cance1.TabIndex = 3
        Me.But_Cance1.Text = "Cancela"
        Me.But_Cance1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.But_Cance1.UseVisualStyleBackColor = False
        '
        'But_Confi1
        '
        Me.But_Confi1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.But_Confi1.Image = CType(resources.GetObject("But_Confi1.Image"), System.Drawing.Image)
        Me.But_Confi1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.But_Confi1.Location = New System.Drawing.Point(31, 121)
        Me.But_Confi1.Name = "But_Confi1"
        Me.But_Confi1.Size = New System.Drawing.Size(82, 31)
        Me.But_Confi1.TabIndex = 2
        Me.But_Confi1.Text = "Confirma"
        Me.But_Confi1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.But_Confi1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Senha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Usuário"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Txt_SenhaAdm)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Location = New System.Drawing.Point(2, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(128, 284)
        Me.Panel2.TabIndex = 42
        '
        'Txt_SenhaAdm
        '
        Me.Txt_SenhaAdm.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_SenhaAdm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_SenhaAdm.Location = New System.Drawing.Point(8, 85)
        Me.Txt_SenhaAdm.MaxLength = 40
        Me.Txt_SenhaAdm.Name = "Txt_SenhaAdm"
        Me.Txt_SenhaAdm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_SenhaAdm.Size = New System.Drawing.Size(110, 20)
        Me.Txt_SenhaAdm.TabIndex = 44
        Me.Txt_SenhaAdm.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(2, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Senha do Administrador"
        Me.Label5.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(2, -2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(57, 57)
        Me.PictureBox3.TabIndex = 41
        Me.PictureBox3.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel6.Location = New System.Drawing.Point(390, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(20, 323)
        Me.Panel6.TabIndex = 268
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel11.Controls.Add(Me.Label14)
        Me.Panel11.Controls.Add(Me.But_Pesqui)
        Me.Panel11.Controls.Add(Me.Txt_Program)
        Me.Panel11.Controls.Add(Me.Label13)
        Me.Panel11.Controls.Add(Me.CMB_Tipo)
        Me.Panel11.Controls.Add(Me.Label12)
        Me.Panel11.Controls.Add(Me.ListView1)
        Me.Panel11.Controls.Add(Me.But_Cance2)
        Me.Panel11.Controls.Add(Me.Txt_RedSen)
        Me.Panel11.Controls.Add(Me.But_Confi2)
        Me.Panel11.Controls.Add(Me.Label6)
        Me.Panel11.Controls.Add(Me.Txt_SenSen)
        Me.Panel11.Controls.Add(Me.Txt_NomSen)
        Me.Panel11.Controls.Add(Me.Txt_CodSen)
        Me.Panel11.Controls.Add(Me.Label7)
        Me.Panel11.Controls.Add(Me.Label8)
        Me.Panel11.Controls.Add(Me.Label9)
        Me.Panel11.Location = New System.Drawing.Point(409, 46)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(497, 273)
        Me.Panel11.TabIndex = 267
        Me.Panel11.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(389, 26)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 13)
        Me.Label14.TabIndex = 303
        Me.Label14.Text = "Programa"
        Me.Label14.Visible = False
        '
        'But_Pesqui
        '
        Me.But_Pesqui.Enabled = False
        Me.But_Pesqui.Image = CType(resources.GetObject("But_Pesqui.Image"), System.Drawing.Image)
        Me.But_Pesqui.Location = New System.Drawing.Point(453, 184)
        Me.But_Pesqui.Name = "But_Pesqui"
        Me.But_Pesqui.Size = New System.Drawing.Size(33, 31)
        Me.But_Pesqui.TabIndex = 302
        Me.But_Pesqui.UseVisualStyleBackColor = True
        '
        'Txt_Program
        '
        Me.Txt_Program.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_Program.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_Program.Enabled = False
        Me.Txt_Program.Location = New System.Drawing.Point(253, 190)
        Me.Txt_Program.Name = "Txt_Program"
        Me.Txt_Program.Size = New System.Drawing.Size(196, 20)
        Me.Txt_Program.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(185, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 301
        Me.Label13.Text = "Programa"
        '
        'CMB_Tipo
        '
        Me.CMB_Tipo.BackColor = System.Drawing.SystemColors.Info
        Me.CMB_Tipo.Enabled = False
        Me.CMB_Tipo.FormattingEnabled = True
        Me.CMB_Tipo.Items.AddRange(New Object() {"USUARIO", "ADMINISTRADOR"})
        Me.CMB_Tipo.Location = New System.Drawing.Point(253, 155)
        Me.CMB_Tipo.Name = "CMB_Tipo"
        Me.CMB_Tipo.Size = New System.Drawing.Size(130, 21)
        Me.CMB_Tipo.TabIndex = 13
        Me.CMB_Tipo.Text = "USUÁRIO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(185, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 300
        Me.Label12.Text = "Tipo"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.SystemColors.Info
        Me.ListView1.BackgroundImageTiled = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HoverSelection = True
        Me.ListView1.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ListView1.Location = New System.Drawing.Point(4, 10)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(153, 208)
        Me.ListView1.TabIndex = 299
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Usuarios Cadastrados"
        Me.ColumnHeader1.Width = 200
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncluirToolStripMenuItem, Me.AlterarToolStripMenuItem, Me.ExcluirToolStripMenuItem, Me.ToolStripSeparator1, Me.ConfigurarToolStripMenuItem, Me.ToolStripSeparator2, Me.VoltarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(132, 126)
        '
        'IncluirToolStripMenuItem
        '
        Me.IncluirToolStripMenuItem.Image = CType(resources.GetObject("IncluirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IncluirToolStripMenuItem.Name = "IncluirToolStripMenuItem"
        Me.IncluirToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.IncluirToolStripMenuItem.Text = "Incluir"
        '
        'AlterarToolStripMenuItem
        '
        Me.AlterarToolStripMenuItem.Image = CType(resources.GetObject("AlterarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem"
        Me.AlterarToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.AlterarToolStripMenuItem.Text = "Alterar"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Image = CType(resources.GetObject("ExcluirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(128, 6)
        '
        'ConfigurarToolStripMenuItem
        '
        Me.ConfigurarToolStripMenuItem.Image = CType(resources.GetObject("ConfigurarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConfigurarToolStripMenuItem.Name = "ConfigurarToolStripMenuItem"
        Me.ConfigurarToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.ConfigurarToolStripMenuItem.Text = "Configurar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(128, 6)
        '
        'VoltarToolStripMenuItem
        '
        Me.VoltarToolStripMenuItem.Image = CType(resources.GetObject("VoltarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VoltarToolStripMenuItem.Name = "VoltarToolStripMenuItem"
        Me.VoltarToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.VoltarToolStripMenuItem.Text = "Voltar"
        '
        'But_Cance2
        '
        Me.But_Cance2.Enabled = False
        Me.But_Cance2.Image = CType(resources.GetObject("But_Cance2.Image"), System.Drawing.Image)
        Me.But_Cance2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.But_Cance2.Location = New System.Drawing.Point(348, 223)
        Me.But_Cance2.Name = "But_Cance2"
        Me.But_Cance2.Size = New System.Drawing.Size(82, 31)
        Me.But_Cance2.TabIndex = 16
        Me.But_Cance2.Text = "Cancela"
        Me.But_Cance2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.But_Cance2.UseVisualStyleBackColor = True
        '
        'Txt_RedSen
        '
        Me.Txt_RedSen.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_RedSen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_RedSen.Enabled = False
        Me.Txt_RedSen.Location = New System.Drawing.Point(253, 123)
        Me.Txt_RedSen.MaxLength = 10
        Me.Txt_RedSen.Name = "Txt_RedSen"
        Me.Txt_RedSen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_RedSen.Size = New System.Drawing.Size(130, 20)
        Me.Txt_RedSen.TabIndex = 12
        '
        'But_Confi2
        '
        Me.But_Confi2.Enabled = False
        Me.But_Confi2.Image = CType(resources.GetObject("But_Confi2.Image"), System.Drawing.Image)
        Me.But_Confi2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.But_Confi2.Location = New System.Drawing.Point(253, 223)
        Me.But_Confi2.Name = "But_Confi2"
        Me.But_Confi2.Size = New System.Drawing.Size(82, 31)
        Me.But_Confi2.TabIndex = 15
        Me.But_Confi2.Text = "Confirma"
        Me.But_Confi2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.But_Confi2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(184, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Redigite"
        '
        'Txt_SenSen
        '
        Me.Txt_SenSen.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_SenSen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_SenSen.Enabled = False
        Me.Txt_SenSen.Location = New System.Drawing.Point(253, 91)
        Me.Txt_SenSen.MaxLength = 10
        Me.Txt_SenSen.Name = "Txt_SenSen"
        Me.Txt_SenSen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_SenSen.Size = New System.Drawing.Size(130, 20)
        Me.Txt_SenSen.TabIndex = 11
        '
        'Txt_NomSen
        '
        Me.Txt_NomSen.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_NomSen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txt_NomSen.Enabled = False
        Me.Txt_NomSen.Location = New System.Drawing.Point(253, 57)
        Me.Txt_NomSen.MaxLength = 20
        Me.Txt_NomSen.Name = "Txt_NomSen"
        Me.Txt_NomSen.Size = New System.Drawing.Size(130, 20)
        Me.Txt_NomSen.TabIndex = 10
        '
        'Txt_CodSen
        '
        Me.Txt_CodSen.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_CodSen.Enabled = False
        Me.Txt_CodSen.Location = New System.Drawing.Point(253, 26)
        Me.Txt_CodSen.MaxLength = 10
        Me.Txt_CodSen.Name = "Txt_CodSen"
        Me.Txt_CodSen.Size = New System.Drawing.Size(100, 20)
        Me.Txt_CodSen.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(184, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Codigo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(184, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Senha"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(184, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Login"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Location = New System.Drawing.Point(410, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(497, 43)
        Me.Panel5.TabIndex = 269
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(226, 25)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Cadastro de Senhas"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(416, 278)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 16)
        Me.Label11.TabIndex = 270
        Me.Label11.Text = "."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "clock_add.png")
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Loader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 344)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelBarraTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Loader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Txt_Senhas As TextBox
    Friend WithEvents Txt_Usuario As TextBox
    Friend WithEvents But_Cance1 As Button
    Friend WithEvents But_Confi1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_SenhaAdm As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents But_Cance2 As Button
    Friend WithEvents Txt_RedSen As TextBox
    Friend WithEvents But_Confi2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Txt_SenSen As TextBox
    Friend WithEvents Txt_NomSen As TextBox
    Friend WithEvents Txt_CodSen As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents IncluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ConfigurarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents VoltarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CMB_Tipo As ComboBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Txt_Program As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents But_Pesqui As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label14 As Label
End Class
