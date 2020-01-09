Imports System.IO
Imports System.Security.AccessControl

Module Mod_Diretorios
    Sub AddDirectorySecurity(ByVal FileName As String, ByVal Account As String, ByVal Rights As FileSystemRights, ByVal ControlType As AccessControlType)
        ' Create a new DirectoryInfoobject.
        Dim dInfo As New DirectoryInfo(FileName)

        ' Get a DirectorySecurity object that represents the 
        ' current security settings.
        Dim dSecurity As DirectorySecurity = dInfo.GetAccessControl()

        ' Add the FileSystemAccessRule to the security settings. 
        dSecurity.AddAccessRule(New FileSystemAccessRule(Account, Rights, ControlType))

        ' Set the new access settings.
        dInfo.SetAccessControl(dSecurity)

    End Sub


    ' Removes an ACL entry on the specified directory for the specified account.
    Sub RemoveDirectorySecurity(ByVal FileName As String, ByVal Account As String, ByVal Rights As FileSystemRights, ByVal ControlType As AccessControlType)
        ' Create a new DirectoryInfo object.
        Dim dInfo As New DirectoryInfo(FileName)

        ' Get a DirectorySecurity object that represents the 
        ' current security settings.
        Dim dSecurity As DirectorySecurity = dInfo.GetAccessControl()

        ' Add the FileSystemAccessRule to the security settings. 
        dSecurity.RemoveAccessRule(New FileSystemAccessRule(Account, Rights, ControlType))

        ' Set the new access settings.
        dInfo.SetAccessControl(dSecurity)

    End Sub
End Module
