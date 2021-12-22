Imports MySql.Data.MySqlClient
Public Class Form1
    Dim comando As New MySqlConnection
    Dim connectionString As String = "Server=localhost; database=visualb; UId=root; pwd="
    Dim mysqlConnection As MySqlConnection = New MySqlConnection(connectionString)
    Dim selección As MySqlCommand = New MySqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            mysqlConnection.Open()
            MsgBox("Conexión establecida con la BBDD correctamente!", MsgBoxStyle.Information, "Conexión establecida")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        selección.Connection = mysqlConnection
        selección.CommandText = "SELECT * FROM Usuarios;"
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter(selección)
        da.Fill(dt)
        DataGridView1.DataSource = dt
        mysqlConnection.Close()
    End Sub
End Class
