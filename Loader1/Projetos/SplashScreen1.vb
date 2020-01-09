Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Management
Imports System.Net
Imports System.Security.AccessControl
Imports System.Security.Principal
Public NotInheritable Class SplashScreen1

    'TODO: Este formulário pode ser facilmente configurado como a tela inicial da aplicação através da edição da aba "Aplicação"
    '  no Designer de Projeto ("Propriedades" dentro do menu "Projetos").


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Verifica se você está conectado a internet
        Try
            If My.Computer.Network.IsAvailable = False Then
                MsgBox("Você não está conextado a internet", MsgBoxStyle.OkOnly)
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            ' Verificando se existe o Diretório padrão
            If System.IO.Directory.Exists(NewDiretorio) Then
            Else
                Dim mPrincipal As WindowsPrincipal = New WindowsPrincipal(WindowsIdentity.GetCurrent)
                ' Criando diretório padrão
                'System.IO.Directory.CreateDirectory(NewDiretorio)
                Dim di As DirectoryInfo = New DirectoryInfo(NewDiretorio)
                di.Create()
                ' Verificar preniosões da pasta
                Try
                    ' Adicione a entrada de controle de acesso ao diretório.
                    AddDirectorySecurity(NewDiretorio, MeuDominio & "\" & NomeComput, FileSystemRights.ReadData, AccessControlType.Allow)
                    ' Remova a entrada de controle de acesso do diretório.
                    'RemoveDirectorySecurity(DirectoryName, di, FileSystemRights.ReadData, AccessControlType.Allow)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            ' Verificando se o arquivo de Senhas e Configuração está no Diretório
            If IO.File.Exists(NewDiretorio & "\" & ArquivoPadrao) Then
                Dim fluxoTexto As IO.StreamReader
                fluxoTexto = New IO.StreamReader(NewDiretorio & "\" & ArquivoPadrao)
                linhaTexto = fluxoTexto.ReadLine
                While Not fluxoTexto.EndOfStream
                    txtLinhas = linhaTexto
                    linhaTexto = fluxoTexto.ReadLine
                End While
                fluxoTexto.Close()
            Else
                'Criando arquivo padrão e escrevendo senha do administrador
                Dim fluxoTexto As IO.StreamWriter
                Dim txtNovaLinha As String = "ADMIN;ADMIN;" & Mid(Date.Now, 1, 10) & ";" & Mid(TimeString, 1, 5) & ";" & ProcessorId & ";" & MACAddress & ";" & MotherboardID & ";ADMINISTRADOR;C:\Program Files\Notepad++\notepad++.exe"
                fluxoTexto = New IO.StreamWriter(NewDiretorio & "\" & ArquivoPadrao, True)
                fluxoTexto.WriteLine(txtNovaLinha)
                fluxoTexto.Close()
            End If
            If IO.File.Exists(NewDiretorio & "\" & ArquivoPadrao) Then
                Dim Arquivo As New StreamReader(NewDiretorio & "\" & ArquivoPadrao)
                Dim Texto As String = ""
                While Not Arquivo.EndOfStream
                    Texto = Arquivo.ReadLine()
                    Vetor = Split(Texto, ";")
                End While
                Arquivo.Close()
            End If
            Var_User = Vetor(0)  ' Variável Usuario
            Var_Senh = Vetor(1)  ' Variável Senha 
            Var_Data = Vetor(2)  ' Variável Data de abertura da senha
            Var_Hora = Vetor(3)  ' Variável Hora da abertura da senha
            Var_Proc = Vetor(4)  ' Variável Nº do Processador
            Var_Macs = Vetor(5)  ' Variável Nº do MAC
            Var_Mate = Vetor(6)  ' Variável Nº da Placa Mãe
            Var_Tipo = Vetor(7)  ' Variável Tipo de Usuário Administrador ou Usuario do Sistema
            Var_Exes = Vetor(8)  ' Chama o programa EXE externo
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

End Class
