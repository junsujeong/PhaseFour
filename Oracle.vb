Imports Microsoft.VisualBasic

Public Class Oracle
    Public Enum ResponseType
        OK
        Cancel
    End Enum

    Friend Shared Result As ResponseType
    Friend Shared UserName As String
    Friend Shared Password As String
    Friend Shared Server As String
    Friend Shared Login_Window As New FormClassLogin
    Private Shared frmEmployee As New FormClassEmployee

    Friend Shared OracleConnection As New System.Data.OracleClient.OracleConnection



    Public Shared Sub LogInAtRunTime()

    End Sub
End Class
