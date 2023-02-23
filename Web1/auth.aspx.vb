Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class auth
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("user") = ""

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Login As String = TextBox1.Text
            Dim Password As String = TextBox2.Text
            Dim query As String = "SELECT CONVERT(varchar(200), DECRYPTBYPASSPHRASE('PWD',PWD)) AS PASSDECRIPTER, NOM FROM Auth WHERE NOM = '" & Login & "' AND CONVERT(varchar(200), DECRYPTBYPASSPHRASE('PWD',PWD))= '" & Password & "'"
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-1S91SBO\MED;Initial Catalog=GestionEmp;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Using de As New SqlDataAdapter()
                        de.SelectCommand = cmd
                        Using dt As New DataTable()
                            de.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                Session("user") = Login
                                Response.Redirect("home.aspx")
                            Else
                                Response.Redirect("auth.aspx")
                            End If
                        End Using

                        con.Close()
                    End Using

                End Using

            End Using
        Catch ex As Exception

            Response.Write("Il y a quelques chose qui n'est pas correct")

        End Try
    End Sub
End Class