Imports System.Data.OleDb

Module Connection



    Public cn As New OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public sql As String


    Public Sub connection()
        cn.Close()
        cn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tinee\source\repos\AssetsManagementSystem\InventorySystem\bin\Debug\AssetsDB.mdb"
        cn.Open()
        MsgBox("Connection Success!", MsgBoxStyle.Information)

    End Sub

End Module
