Imports System
Imports System.Net
Imports System.IO
Imports System.Net.Dns
Module Mod_Variaveis
    Public Click01 As String = 1
    Public ProcessorId As String = GetProcessorId()         ' Nº do Porcessador
    Public MACAddress As String = GetMACAddress()           ' Nº do MAC
    Public MotherboardID As String = GetMotherboardID()     ' Nº da Placa Mãe
    Public MeuDominio As String = Dns.GetHostName           ' Nome do Domínio
    Public NomeComput As String = Dns.GetHostName           ' Nome do Computador
    Dim NewIps As IPHostEntry = GetHostEntry(NomeComput)
    Public MeuIp As String = CType(NewIps.AddressList.GetValue(1), IPAddress).ToString()    'Nº do Ip do Computador
    Public NewDiretorio As String = "https://raw.githubusercontent.com/gustavovg/loader/master/Bco_Loader/"  ' "C:\Program Files (x86)\Loader\"    ' Nome do diretório padrão
    Public ArquivoPadrao As String = "Bco_Loader.dat"                   ' Nome do Banco de Dados 
    Public fluxoTexto As String = ""
    Public linhaTexto As String = ""
    Public txtLinhas As String = ""
    Public Vetor() As String
    Public Var_User As String = ""
    Public Var_Senh As String = ""
    Public Var_Data As String = ""
    Public Var_Hora As String = ""
    Public Var_Proc As String = ""
    Public Var_Macs As String = ""
    Public Var_Mate As String = ""
    Public Var_Tipo As String = ""
    Public Var_Exes As String = ""
    Public Var_Index_Array As String = ""
    Public Var_Titulo01 As String = "Senha Inválida!!" & Chr(13) & "Você não tem poderes de Administrador"
    Public NewCods As String = ""
    Public S() As String
    Public AchouPalavra As String
    Public TipoCadastro As String
    Public Senha01, Senha02 As String

    Public vetor_desejado() As String






End Module
