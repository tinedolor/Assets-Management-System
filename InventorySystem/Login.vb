Imports System.Data.OleDb




Public Class Login



    Public cn As New OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\tinee\source\repos\AssetsManagementSystem\InventorySystem\bin\Debug\AssetsDB.mdb")
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public sql As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        logIn()
    End Sub
    Private Sub logIn()


        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If

        sql = "Select * from UserTable where user = '" & txtloguser.Text & "' and pass = '" & txtlogpw.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader

        If dr.Read = True Then

            MsgBox("Login success!", MsgBoxStyle.Information)


            Dim userRole As String = dr("role").ToString()

            If userRole = "Admin" Then

                Admin.Show()

            ElseIf userRole = "finance" Then
                Finance.Show()


            ElseIf userRole = "purchasing" Then

                Purchasing.Show()

            ElseIf userRole = "property" Then

                Propertyfrm.Show()


            ElseIf userRole = "user" Then

                Employee.Show()



            End If

        Else
                MsgBox("Login Failed!", MsgBoxStyle.Critical)
                lblattempts.Text = lblattempts.Text - 1

                If lblrole.Text = "No Account exists!!!" Or lblrole.Text = "" Then

                Else
                    Call updateattempts()

                End If

                If lblattempts.Text = 0 Then

                    Call UpdateStatus()

                    Me.Close()

                End If


            End If
    End Sub


    Private Sub updateattempts()
        Try
            If cn.State = ConnectionState.Closed Then
                cn.Open()
            End If

            sql = "UPDATE UserTable SET attempts = @attempts WHERE user = @username"
            cmd = New OleDbCommand(sql, cn)


            cmd.Parameters.AddWithValue("@attempts", lblattempts.Text)
            cmd.Parameters.AddWithValue("@username", txtloguser.Text)

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub


    Private Sub updatestatus()
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If

        sql = "Update UserTable set status = 'Deactivated' where username = '" & txtloguser.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        cmd.ExecuteNonQuery()
        MsgBox("You have reached the maximum attempts! Your account is now disabled", MsgBoxStyle.Critical)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblrole.Click

    End Sub


    Private Sub txtloguser_TextChanged(sender As Object, e As EventArgs) Handles txtloguser.TextChanged

        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If

        sql = "Select role,attempts from UserTable where user ='" & txtloguser.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader()

        If dr.Read = True Then
            lblrole.Text = dr("role").ToString
            lblattempts.Text = dr("attempts").ToString


        Else

            lblrole.Text = "NO ACCOUNT EXISTS!!!"

        End If

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
    End Sub

    Private Sub btnlogClear_Click(sender As Object, e As EventArgs) Handles btnlogClear.Click
        txtloguser.Clear()
        txtlogpw.Clear()

    End Sub
End Class
