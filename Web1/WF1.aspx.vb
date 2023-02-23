Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class WF1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("user") = "" Then
            Response.Redirect("auth.aspx")
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim query As String = "INSERT INTO Department VALUES(@id,@nom)"
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                Response.Write("Il faut Saisir Tout le Champ")
                Exit Sub
            End If
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-1S91SBO\MED;Initial Catalog=GestionEmp;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@nom", TextBox2.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    Response.Redirect("WF1.aspx")
                    con.Close()

                End Using

            End Using
        Catch ex As Exception

            Response.Write(ex)

        End Try
        


    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Protected Sub BtnDec_Click(sender As Object, e As EventArgs) Handles BtnDec.Click
        Response.Redirect("home.aspx")
    End Sub

    Protected Sub BtnDec0_Click(sender As Object, e As EventArgs) Handles BtnDec0.Click
        Session("user") = ""
        Response.Redirect("auth.aspx")
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim query2 As String = "SELECT * FROM Department WHERE id = @id"
            Dim query As String = "DELETE FROM Department WHERE id = @id"
            Dim query1 As String = "DELETE FROM Employee where idDep = @id1"

            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-1S91SBO\MED;Initial Catalog=GestionEmp;Integrated Security=True")
                Using cmd3 As SqlCommand = New SqlCommand(query2, con)
                    cmd3.Parameters.AddWithValue("@id", TextBox1.Text)
                    con.Open()
                    cmd3.ExecuteNonQuery()
                    Using de As New SqlDataAdapter()
                        de.SelectCommand = cmd3
                        Using dt As New DataTable()
                            de.Fill(dt)
                            If dt.Rows.Count = 0 Then
                                Response.Write("il faut preciser une valid id pour supprimer le department qui corespond")
                                Exit Sub
                            End If
                        End Using
                        con.Close()
                    End Using
                End Using
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    Using cmd1 As SqlCommand = New SqlCommand(query1, con)
                        cmd1.Parameters.AddWithValue("@id1", TextBox1.Text)
                        con.Open()
                        cmd1.ExecuteNonQuery()
                        con.Close()
                    End Using
                    cmd.Parameters.AddWithValue("@id", TextBox1.Text)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Response.Redirect("WF1.aspx")
                    con.Close()
                End Using

            End Using
        Catch ex As Exception

            Response.Write(ex)

        End Try

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim query As String = "SELECT * FROM Department where id=@id"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-1S91SBO\MED;Initial Catalog=GestionEmp;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", TextBox1.Text)
                Using de As New SqlDataAdapter()
                    de.SelectCommand = cmd
                    Using dt As New DataTable()
                        de.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            TextBox1.Text = dt.Rows(0)(0).ToString()
                            TextBox2.Text = dt.Rows(0)(1).ToString()
                        End If
                    End Using
                End Using
            End Using
        End Using

    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim query As String = "UPDATE Department SET nom=@nom where id=@id"
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-1S91SBO\MED;Initial Catalog=GestionEmp;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@nom", TextBox2.Text)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Response.Redirect("WF1.aspx")
                    con.Close()

                End Using

            End Using
        Catch ex As Exception

            Response.Write("IL y'avais une erreur ")

        End Try
    End Sub
End Class