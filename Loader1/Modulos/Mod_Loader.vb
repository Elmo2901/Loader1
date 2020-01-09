Imports System.Management
Imports System.Net
Imports System.IO

Module Mod_Loader

    'Get processor ID
    Friend Function GetProcessorId() As String
        Dim strProcessorID As String = String.Empty
        Dim query As New SelectQuery("Win32_processor")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strProcessorID = info("processorID").ToString()
        Next
        Return strProcessorID
    End Function
    ' Get MAC Address
    Friend Function GetMACAddress() As String
        Dim mc As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim moc As ManagementObjectCollection = mc.GetInstances()
        Dim MacAddress As String = String.Empty
        For Each mo As ManagementObject In moc
            If (MacAddress.Equals(String.Empty)) Then
                If CBool(mo("IPEnabled")) Then MacAddress = mo("MacAddress").ToString()
                mo.Dispose()
            End If
            MacAddress = MacAddress.Replace(":", String.Empty)
        Next
        Return MacAddress
    End Function
    ' Get Motherboard ID
    Friend Function GetMotherboardID() As String
        Dim strMotherboardID As String = String.Empty
        Dim query As New SelectQuery("Win32_BaseBoard")
        Dim search As New ManagementObjectSearcher(query)
        Dim info As ManagementObject
        For Each info In search.Get()
            strMotherboardID = info("product").ToString()
        Next
        Return strMotherboardID
    End Function
    ' Encrypt HWID
    Friend Function getMD5Hash(ByVal strToHash As String) As String
        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)
        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As String = ""
        For Each b As Byte In bytesToHash
            strResult += b.ToString("x2")
        Next
        Return strResult
    End Function

    Function Achar_SenhaEnt(ByVal varPalavra As String, ByVal Arquivo As String)
        'Sub Achar_SenhaEnt(ByVal varPalavra As String, ByVal Arquivo As String)
        Var_Tipo = Nothing
        Dim oTxtIn As New IO.StreamReader(Arquivo)  '"C:\teste.log")
        Dim oTxtContent As String = oTxtIn.ReadToEnd()
        Dim oTxtArr() As String = oTxtContent.Split(";")
        Dim NewVarPalavra As String = varPalavra
        For m = 1 To UBound(oTxtArr)
            Dim NewPalavra As String = oTxtArr(m)
            If NewPalavra = NewVarPalavra Then
                Var_Tipo = oTxtArr(m + 6)
                AchouPalavra = "T"
                Exit For
            Else
                AchouPalavra = "F"
            End If
        Next
        oTxtIn.Close()
        Return AchouPalavra
    End Function

    Friend Function Proc_Texto(ByVal Var_Caminho As String, ByRef Var_Texto As String, ByRef Var_Arqui As String) As String
        '*************************************
        '* Limpando variáveis
        '*************************************
        Var_User = Nothing
        Var_Senh = Nothing
        Var_Data = Nothing
        Var_Hora = Nothing
        Var_Proc = Nothing
        Var_Macs = Nothing
        Var_Mate = Nothing
        Var_Tipo = Nothing
        Var_Exes = Nothing
        Dim oTxtIn As New IO.StreamReader(Var_Caminho) ' Carrega o arquivo na memória.
        Dim oTxtContent As String = oTxtIn.ReadToEnd() ' Lê os dados e insere na String.
        Dim vetor() As String = oTxtContent.Split(Environment.NewLine & ";") ' Quebra por linha o conteúdo.
        For x As Integer = 0 To vetor.Length - 1
            Dim S() As String = vetor(x).Split(New Char() {";"})
            For y As Integer = 0 To S.Length - 1
                Dim NewUser As String = IIf(y = 0, Trim(LimpaCaract(S(y))), S(y))
                If NewUser = Var_Texto Then
                    Var_User = Trim(LimpaCaract(S(0))) ' Variável Usuario
                    Var_Senh = S(1)  ' Variável Senha 
                    Var_Data = S(2)  ' Variável Data de abertura da senha
                    Var_Hora = S(3)  ' Variável Hora da abertura da senha
                    Var_Proc = S(4)  ' Variável Nº do Processador
                    Var_Macs = S(5)  ' Variável Nº do MAC
                    Var_Mate = S(6)  ' Variável Nº da Placa Mãe
                    Var_Tipo = S(7)  ' Variável Tipo de Usuário Administrador ou Usuario do Sistema
                    Var_Exes = S(8)  ' Chama o programa EXE externo
                    x = vetor.Length
                    Exit For
                End If
            Next
        Next
        oTxtIn.Close()
        Return ""
    End Function

    'Private Sub btnLer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLer.Click
    Friend Sub Proc_LerLinha(ByVal Var_Caminho As String, ByVal ArquivoTxt As String) 'As String
        Dim fluxoTexto As IO.StreamReader
        Dim linhaTexto As String
        If IO.File.Exists(Var_Caminho & ArquivoTxt) Then
            fluxoTexto = New IO.StreamReader(ArquivoTxt)
            linhaTexto = fluxoTexto.ReadLine

            While linhaTexto <> Nothing
                txtLinhas &= linhaTexto & Chr(13)  'vbCrLf
                linhaTexto = fluxoTexto.ReadLine
            End While
            fluxoTexto.Close()
            Exit Sub
        Else
            MessageBox.Show("Arquivo não existe")
        End If
    End Sub

    Public Function ArquivoEmUso(ByVal caminhoArquivo As String) As Boolean
        Try
            Dim fs As System.IO.FileStream = System.IO.File.OpenWrite(caminhoArquivo)
            fs.Close()
            Return False
        Catch ex As System.IO.IOException
            Return True
        End Try
    End Function

    Public Function LimpaCaract(ByRef X As String) As String
        X = Replace(X, vbLf, Space(1)) 'substitui enter por espaço
        Return X
    End Function

    Public Function EXCLUI_LINHA(ByVal V_ID As String)
        Dim pArquivo As String = NewDiretorio & ArquivoPadrao   'Application.StartupPath & "\sql_geral.txt"
        Dim Arquivo As StreamWriter
        Dim Linhas As New List(Of String)
        Using SR As New StreamReader(pArquivo)
            Linhas.AddRange(System.IO.File.ReadAllLines(pArquivo.ToString))
            SR.Dispose()
            SR.Close()
        End Using

        Arquivo = New StreamWriter(pArquivo)
        For Each Linha As String In Linhas.ToArray
            If Not Linha.Contains(V_ID) Then
                Arquivo.WriteLine(Linha)
            End If
        Next
        Arquivo.Close()
        Dim linesList As New List(Of String)(File.ReadAllLines(pArquivo))
        linesList.RemoveAt(0)

        Return ""
    End Function
    Public Function contaLinhas(ByVal caminho As String) As String
        Dim leitura As StreamReader
        Dim quantasLinhas As Integer

        leitura = File.OpenText(caminho)
        While leitura.Peek() <> -1
            leitura.ReadLine()
            quantasLinhas += 1
        End While
        leitura.Close()

        Return quantasLinhas.ToString()
    End Function
End Module
