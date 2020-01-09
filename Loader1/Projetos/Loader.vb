Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Management
Imports System.Net
Imports System.Text

Public Class Loader

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Size = New Size(390, 344)
        Me.Location = New Point(250, 90)   '250, 90
        Me.Panel2.Size = New Point(77, 284)
        Me.Label11.Text = "Click com o botão direito do" + vbCrLf + "mouse para abrir o menu"

    End Sub

    Private Sub e_COMBAN_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If (e.KeyCode = Keys.Enter) Or (e.KeyCode = Keys.Tab) Then
            SendKeys.Send("{TAB}")
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            Me.Hide()
        End If
    End Sub
    Private Sub PanelBarraTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Try
            If Click01 = 1 Then
                Me.Panel3.Enabled = False
                Me.PictureBox3.Enabled = False
                For x = 77 To 128
                    Me.Panel2.Size = New Point(x, 287)
                    System.Threading.Thread.Sleep(20)
                Next
                Me.Label5.Visible = True
                Me.Txt_SenhaAdm.Visible = True
                Me.Txt_SenhaAdm.Clear()
                Me.Txt_SenhaAdm.Focus()
            Else
                Me.Panel3.Enabled = True
                Me.Label5.Visible = False
                Me.Txt_SenhaAdm.Visible = False
                For x = 128 To 77 Step -1
                    Me.Panel2.Size = New Point(x, 287)
                    System.Threading.Thread.Sleep(20)
                Next
                Click01 = 1
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txt_SenhaAdm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_SenhaAdm.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                If Achar_SenhaEnt(UCase(Txt_SenhaAdm.Text), NewDiretorio & ArquivoPadrao) = "T" Then
                    If Var_Tipo = "ADMINISTRADOR" Then
                        Me.Label5.Visible = False
                        Me.Txt_SenhaAdm.Visible = False
                        '*****************************************
                        ' Abrindo janela do Form
                        '*****************************************
                        Me.Panel5.Refresh()
                        Me.Label10.Refresh()
                        For y = 390 To 910
                            Me.Size = New Point(y, 344)
                            System.Threading.Thread.Sleep(1)
                        Next
                        Me.Panel11.Visible = True
                        If Click01 = 1 Then
                            Click01 = 2
                        Else
                            Click01 = 1
                        End If
                        '****************************************
                        ' Populando ListView
                        '****************************************
                        Dim NewListas As New ListViewItem
                        ListView1.Items.Clear()
                        ListView1.View = View.Details
                        ListView1.FullRowSelect = True
                        ListView1.SmallImageList = ImageList1
                        Dim xTxtIn As New IO.StreamReader(NewDiretorio & ArquivoPadrao) ' Carrega o arquivo na memória.
                        Dim xTxtContent As String = xTxtIn.ReadToEnd() ' Lê os dados e insere na String.
                        Dim vetor() As String = xTxtContent.Split(Environment.NewLine) ' Quebra por linha o conteúdo.
                        For x As Integer = 0 To vetor.Length - 1
                            Dim s() As String = vetor(x).Split(New Char() {";"})
                            If s(0) <> "vbLf" Then
                                NewListas = ListView1.Items.Add(s(0), 0)
                            End If
                        Next
                        xTxtIn.Close()
                    ElseIf Me.Txt_SenhaAdm.Text = "" Then
                        Me.Panel11.Visible = False
                        Me.Size = New Size(384, 344)
                        Me.Panel3.Enabled = True
                        Me.PictureBox3.Enabled = True
                        Me.Label5.Visible = False
                        Me.Txt_SenhaAdm.Visible = False
                        For x = 128 To 77 Step -1
                            Me.Panel2.Size = New Point(x, 287)
                            System.Threading.Thread.Sleep(20)
                        Next
                        Me.Txt_Usuario.TabIndex = 0
                        Me.Txt_Usuario.Focus()
                        Click01 = 1
                    Else
                        MsgBox(Var_Titulo01, MsgBoxStyle.OkOnly, "Atenção!!")
                        Me.PictureBox3.Enabled = True
                        Me.Label5.Visible = False
                        Me.Txt_SenhaAdm.Clear()
                        Me.Txt_SenhaAdm.Visible = False
                        For x = 128 To 77 Step -1
                            Me.Panel2.Size = New Point(x, 287)
                            System.Threading.Thread.Sleep(20)
                        Next
                        Me.Panel3.Enabled = True
                        Me.Txt_Usuario.TabIndex = 0
                        Click01 = 1
                    End If
                Else
                    MsgBox(Var_Titulo01, MsgBoxStyle.OkOnly, "Atenção!!")
                    Me.PictureBox3.Enabled = True
                    Me.Label5.Visible = False
                    Me.Txt_SenhaAdm.Clear()
                    Me.Txt_SenhaAdm.Visible = False
                    For x = 128 To 77 Step -1
                        Me.Panel2.Size = New Point(x, 287)
                        System.Threading.Thread.Sleep(20)
                    Next
                    Me.Panel3.Enabled = True
                    Me.Txt_Usuario.TabIndex = 0
                    Click01 = 1
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub But_Confi1_Click(sender As Object, e As EventArgs) Handles But_Confi1.Click
        '************************************
        ' Confirma Senha do sistema
        '************************************
        Try
            If Me.Txt_Usuario.Text = "" Then
                MsgBox("Nome de Usuário não pode estar em Branco", MsgBoxStyle.OkOnly, "Atenção!!")
                Me.Txt_Usuario.Focus()
            ElseIf Me.Txt_Senhas.Text = "" Then
                MsgBox("Senha do Usuário não pode estar em Branco", MsgBoxStyle.OkOnly, "Atenção!!")
                Me.Txt_Senhas.Focus()
            Else
                If IO.File.Exists(NewDiretorio & "\" & ArquivoPadrao) Then
                    Proc_Texto(NewDiretorio & "\" & ArquivoPadrao, Me.Txt_Usuario.Text, ArquivoPadrao)
                    If Me.Txt_Usuario.Text = Var_User And Me.Txt_Senhas.Text = Var_Senh Then
                        Me.Close()
                        Me.Hide()
                        System.Diagnostics.Process.Start(Var_Exes)
                    Else
                        MsgBox("Usuário ou Senha não cadastrado", MsgBoxStyle.OkOnly, "Atenção!!")
                        Me.Txt_Usuario.Clear()
                        Me.Txt_Senhas.Clear()
                        Me.Txt_Usuario.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub But_Cance1_Click(sender As Object, e As EventArgs) Handles But_Cance1.Click
        '************************************
        ' Sai Senha do sistema
        '************************************
        End
    End Sub

    <Obsolete>
    Private Sub But_Confi2_Click(sender As Object, e As EventArgs) Handles But_Confi2.Click
        Select Case TipoCadastro
            Case 1
                '*****************************************
                ' Inclusão de Usuario e Senha
                '*****************************************
                Try
                    If Me.Txt_NomSen.Text = "" Then
                        MsgBox("Nome de Usuário não pode estar em Branco", MsgBoxStyle.OkOnly, "Atenção!!")
                        Me.Txt_NomSen.Focus()
                    ElseIf Me.Txt_SenSen.Text = "" Then
                        MsgBox("Senha do Usuário não pode estar em Branco", MsgBoxStyle.OkOnly, "Atenção!!")
                        Me.Txt_SenSen.Focus()
                    ElseIf Me.Txt_RedSen.Text = "" Then
                        MsgBox("Redigitação da senha do Usuário não pode estar em Branco", MsgBoxStyle.OkOnly, "Atenção!!")
                        Me.Txt_RedSen.Focus()
                    Else
                        If Me.Txt_SenSen.Text <> Me.Txt_RedSen.Text Then
                            MsgBox("Redigitação da senha do Usuário não confere", MsgBoxStyle.OkOnly, "Atenção!!")
                            Me.Txt_SenSen.Clear()
                            Me.Txt_RedSen.Clear()
                            Me.Txt_SenSen.Focus()
                            Exit Sub
                        End If
                    End If
                    FileClose(1)
                    If IO.File.Exists(NewDiretorio & "\" & ArquivoPadrao) Then
                        If ArquivoEmUso(NewDiretorio & "\" & ArquivoPadrao) = False Then
                            'Criando arquivo padrão e escrevendo senha do administrador
                            Dim fluxoTexto As IO.StreamWriter
                            Dim txtNovaLinha As String = Trim(Me.Txt_NomSen.Text & ";" & Me.Txt_SenSen.Text & ";" & Mid(Date.Now, 1, 10) & ";" & Mid(TimeString, 1, 5) & ";" & ProcessorId & ";" & MACAddress & ";" & MotherboardID & ";" & Me.CMB_Tipo.Text & ";" & Me.Txt_Program.Text)
                            fluxoTexto = New IO.StreamWriter(NewDiretorio & "\" & ArquivoPadrao, True)
                            fluxoTexto.Write(vbCrLf & txtNovaLinha)
                            fluxoTexto.Close()
                            '**************************************
                            ' Populando novamente o ListView
                            '**************************************
                            Dim NewListas As New ListViewItem
                            ListView1.Items.Clear()
                            ListView1.View = View.Details
                            ListView1.FullRowSelect = True
                            ListView1.SmallImageList = ImageList1
                            Dim xTxtIn As New IO.StreamReader(NewDiretorio & ArquivoPadrao) ' Carrega o arquivo na memória.
                            Dim xTxtContent As String = xTxtIn.ReadToEnd() ' Lê os dados e insere na String.
                            Dim vetor() As String = xTxtContent.Split(Environment.NewLine) ' Quebra por linha o conteúdo.
                            For x As Integer = 0 To vetor.Length - 1
                                Dim s() As String = vetor(x).Split(New Char() {";"})
                                NewListas = ListView1.Items.Add(s(0), 0)
                            Next
                            xTxtIn.Close()
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 2
                '*****************************************
                ' Alterando de Usuario e Senha
                '*****************************************
                If Me.Txt_NomSen.Text = "" Then
                    MsgBox("Nome de Usuário não pode estar em Branco", MsgBoxStyle.OkOnly, "Atenção!!")
                    Me.Txt_NomSen.Focus()
                ElseIf Me.Txt_SenSen.Text = "" Then
                    MsgBox("Senha do Usuário não pode estar em Branco", MsgBoxStyle.OkOnly, "Atenção!!")
                    Me.Txt_SenSen.Focus()
                ElseIf Me.Txt_RedSen.Text = "" Then
                    MsgBox("Redigitação da senha do Usuário não pode estar em Branco", MsgBoxStyle.OkOnly, "Atenção!!")
                    Me.Txt_RedSen.Focus()
                Else
                    If Me.Txt_SenSen.Text <> Me.Txt_RedSen.Text Then
                        MsgBox("Redigitação da senha do Usuário não confere", MsgBoxStyle.OkOnly, "Atenção!!")
                        Me.Txt_SenSen.Clear()
                        Me.Txt_RedSen.Clear()
                        Me.Txt_SenSen.Focus()
                        Exit Sub
                    End If
                End If
                '****************************************
                '* Excluindo linha 
                '****************************************
                EXCLUI_LINHA(Txt_NomSen.Text)
                '****************************************
                '* Regravando a linha
                '****************************************
                FileClose(1)
                If IO.File.Exists(NewDiretorio & "\" & ArquivoPadrao) Then
                    If ArquivoEmUso(NewDiretorio & "\" & ArquivoPadrao) = False Then
                        'Criando arquivo padrão e escrevendo senha do administrador
                        Dim fluxoTexto As IO.StreamWriter
                        Dim txtNovaLinha As String = Trim(Me.Txt_NomSen.Text & ";" & Me.Txt_SenSen.Text & ";" & Mid(Date.Now, 1, 10) & ";" & Mid(TimeString, 1, 5) & ";" & ProcessorId & ";" & MACAddress & ";" & MotherboardID & ";" & Me.CMB_Tipo.Text & ";" & Me.Txt_Program.Text)
                        fluxoTexto = New IO.StreamWriter(NewDiretorio & "\" & ArquivoPadrao, True)
                        fluxoTexto.Write(txtNovaLinha)
                        fluxoTexto.Close()
                        '**************************************
                        ' Populando novamente o ListView
                        '**************************************
                        Dim NewListas As New ListViewItem
                        ListView1.Items.Clear()
                        ListView1.View = View.Details
                        ListView1.FullRowSelect = True
                        ListView1.SmallImageList = ImageList1
                        Dim xTxtIn As New IO.StreamReader(NewDiretorio & ArquivoPadrao) ' Carrega o arquivo na memória.
                        Dim xTxtContent As String = xTxtIn.ReadToEnd() ' Lê os dados e insere na String.
                        Dim vetor() As String = xTxtContent.Split(Environment.NewLine) ' Quebra por linha o conteúdo.
                        For x As Integer = 0 To vetor.Length - 1
                            Dim s() As String = vetor(x).Split(New Char() {";"})
                            NewListas = ListView1.Items.Add(s(0), 0)
                        Next
                        xTxtIn.Close()
                    End If
                End If

            Case 3
            Case 4

        End Select

        Me.Txt_NomSen.Clear()
        Me.Txt_SenSen.Clear()
        Me.Txt_RedSen.Clear()
        Me.ListView1.Enabled = True
        Me.Txt_NomSen.Enabled = False
        Me.Txt_SenSen.Enabled = False
        Me.Txt_RedSen.Enabled = False
        Me.CMB_Tipo.Enabled = False
        Me.But_Confi2.Enabled = False
        Me.But_Cance2.Enabled = False
    End Sub

    Private Sub But_Cance2_Click(sender As Object, e As EventArgs) Handles But_Cance2.Click
        '*****************************************
        ' Sai do Cadastro de Senha do sistema  Panel5
        '*****************************************

        Me.Txt_NomSen.Clear()
        Me.Txt_SenSen.Clear()
        Me.Txt_RedSen.Clear()
        Me.Txt_Program.Clear()
        Me.ListView1.Enabled = True
        Me.Txt_NomSen.Enabled = False
        Me.Txt_SenSen.Enabled = False
        Me.Txt_RedSen.Enabled = False
        Me.CMB_Tipo.Enabled = False
        Me.Txt_Program.Enabled = False
        Me.But_Confi2.Enabled = False
        Me.But_Cance2.Enabled = False
        Me.But_Pesqui.Enabled = False
    End Sub

    Private Sub IncluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncluirToolStripMenuItem.Click
        '*****************************************
        ' Pup Up Incluir
        '*****************************************
        Try
            Me.ListView1.Enabled = False
            Me.Txt_NomSen.Clear()
            Me.Txt_NomSen.Enabled = True
            Me.Txt_SenSen.Clear()
            Me.Txt_SenSen.Enabled = True
            Me.Txt_RedSen.Clear()
            Me.Txt_RedSen.Enabled = True
            Me.CMB_Tipo.Enabled = True
            Me.Txt_Program.Clear()
            Me.Txt_Program.Enabled = True
            Me.But_Confi2.Enabled = True
            Me.But_Cance2.Enabled = True
            Me.But_Pesqui.Enabled = True
            Me.Txt_NomSen.Focus()
            TipoCadastro = 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AlterarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarToolStripMenuItem.Click
        '*****************************************
        ' Pup Up Alterar
        '*****************************************
        Me.ListView1.Enabled = False
        Me.Txt_NomSen.Enabled = True
        Me.Txt_SenSen.Enabled = True
        Me.Txt_RedSen.Enabled = True
        Me.CMB_Tipo.Enabled = True
        Me.Txt_Program.Enabled = True
        Me.But_Confi2.Enabled = True
        Me.But_Cance2.Enabled = True
        Me.But_Pesqui.Enabled = True
        Me.But_Pesqui.Enabled = True
        Me.Txt_NomSen.Focus()
        TipoCadastro = 2
    End Sub

    Private Sub ExcluirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcluirToolStripMenuItem.Click
        '*****************************************
        ' Pup Up Excluir
        '*****************************************
        Try
            If ListView1.SelectedItems.Count <> "0" Then
                NewCods = ListView1.SelectedItems(0).SubItems(0).Text
                If IO.File.Exists(NewDiretorio & "\" & ArquivoPadrao) Then
                    Proc_Texto(NewDiretorio & "\" & ArquivoPadrao, Trim(LimpaCaract(NewCods)), ArquivoPadrao)
                    Me.Txt_NomSen.Text = Var_User
                    If MsgBox("Confirma Exclusão do usuário " & Me.Txt_NomSen.Text & "", vbOKCancel) = 1 Then
                        EXCLUI_LINHA(Me.Txt_NomSen.Text)
                        FileClose(1)
                        RezaUsuario()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        TipoCadastro = 3
    End Sub

    Private Sub ConfigurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarToolStripMenuItem.Click
        '*****************************************
        ' Pup Up Configurar
        '*****************************************

        TipoCadastro = 4
    End Sub

    Private Sub VoltarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarToolStripMenuItem.Click
        '*****************************************
        ' Pup Up Voltar
        '*****************************************
        '*****************************************
        ' Sai do Cadastro de Senha do sistema  Panel5
        '*****************************************
        'Me.Panel11.Visible = False
        Me.Panel3.Enabled = True
        Me.PictureBox3.Enabled = True
        Me.Label5.Visible = False
        Me.Txt_SenhaAdm.Visible = False
        '*****************************************
        ' Fechando janela do Form
        '*****************************************
        For y = 910 To 390 Step -1
            Me.Size = New Point(y, 344)
            System.Threading.Thread.Sleep(1)
        Next
        '*****************************************
        ' Fechando Painel 2
        '*****************************************
        For x = 128 To 77 Step -1
            Me.Panel2.Size = New Point(x, 287)
            System.Threading.Thread.Sleep(20)
        Next
        Click01 = 1
    End Sub

    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        Try
            If ListView1.SelectedItems.Count <> "0" Then
                NewCods = ListView1.SelectedItems(0).SubItems(0).Text
                If IO.File.Exists(NewDiretorio & "\" & ArquivoPadrao) Then
                    Proc_Texto(NewDiretorio & "\" & ArquivoPadrao, Trim(LimpaCaract(NewCods)), ArquivoPadrao)
                    Me.Txt_NomSen.Text = Var_User
                    Me.CMB_Tipo.Text = Var_Tipo
                    Me.Txt_Program.Text = Var_Exes
                    Senha01 = Var_Senh
                    Label14.Text = Var_Senh
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub But_Pesqui_Click(sender As Object, e As EventArgs) Handles But_Pesqui.Click
        Try
            OpenFileDialog1.Filter = "Exe files (*.exe)|*.exe|All files (*.*)|*.*"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Txt_Program.Text = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox("Erro na codificação", MsgBoxStyle.Critical, "Erro")
        End Try
    End Sub

    Sub RezaUsuario()
        Dim NewListas As New ListViewItem
        ListView1.Items.Clear()
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.SmallImageList = ImageList1
        Dim xTxtIn As New IO.StreamReader(NewDiretorio & ArquivoPadrao) ' Carrega o arquivo na memória.
        Dim xTxtContent As String = xTxtIn.ReadToEnd() ' Lê os dados e insere na String.
        Dim vetor() As String = xTxtContent.Split(Environment.NewLine) ' Quebra por linha o conteúdo.
        For x As Integer = 0 To vetor.Length - 1
            Dim s() As String = vetor(x).Split(New Char() {";"})
            NewListas = ListView1.Items.Add(s(0), 0)
        Next
    End Sub

End Class

