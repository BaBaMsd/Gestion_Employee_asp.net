Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Public Class home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("user") = "" Then
            Response.Redirect("auth.aspx")
        End If
        SElection()

    End Sub

    Protected Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
       
        Try
            Dim query As String = "INSERT INTO Employee VALUES(@id,@nni,@nom,@prenom,@telephone,@idDep)"
            If id_emp.Text = "" Or nni_emp.Text = "" Or nom_emp.Text = "" Or prenom_emp.Text = "" Or tel_emp.Text = "" Or idDep.Text = "" Then
                Response.Write("Il faut Saisir Tout les Champs")
                Exit Sub
            End If
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-1S91SBO\MED;Initial Catalog=GestionEmp;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", id_emp.Text)
                    cmd.Parameters.AddWithValue("@nni", nni_emp.Text)
                    cmd.Parameters.AddWithValue("@nom", nom_emp.Text)
                    cmd.Parameters.AddWithValue("@prenom", prenom_emp.Text)
                    cmd.Parameters.AddWithValue("@telephone", tel_emp.Text)
                    cmd.Parameters.AddWithValue("@idDep", idDep.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    SElection()
                    Response.Redirect("home.aspx")
                    con.Close()

                End Using

            End Using
        Catch ex As Exception

            Response.Write(ex)

        End Try
    End Sub
    Public Sub SElection()
        Dim query As String = "SELECT * FROM Employee"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-1S91SBO\MED;Initial Catalog=GestionEmp;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using de As New SqlDataAdapter()
                    de.SelectCommand = cmd
                    Using dt As New DataTable()
                        de.Fill(dt)
                        DonnesEmp.DataSource = dt
                        DonnesEmp.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim query As String = "UPDATE Employee SET nni=@nni,nom=@nom,prenom=@prenom,telephone=@telephone,idDep=@idDep where id=@id"
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-1S91SBO\MED;Initial Catalog=GestionEmp;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", id_emp.Text)
                    cmd.Parameters.AddWithValue("@nni", nni_emp.Text)
                    cmd.Parameters.AddWithValue("@nom", nom_emp.Text)
                    cmd.Parameters.AddWithValue("@prenom", prenom_emp.Text)
                    cmd.Parameters.AddWithValue("@telephone", tel_emp.Text)
                    cmd.Parameters.AddWithValue("@idDep", idDep.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    SElection()
                    Response.Redirect("home.aspx")
                    con.Close()

                End Using

            End Using
        Catch ex As Exception

            Response.Write("IL y'avais une erreur ")

        End Try

    End Sub


    Protected Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim query As String = "DELETE FROM Employee where id=@id"
            Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-1S91SBO\MED;Initial Catalog=GestionEmp;Integrated Security=True")
                Using cmd As SqlCommand = New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@id", id_emp.Text)

                    con.Open()
                    cmd.ExecuteNonQuery()
                    SElection()
                    Response.Redirect("home.aspx")
                    con.Close()

                End Using

            End Using
        Catch ex As Exception

            Response.Write(ex)

        End Try

    End Sub

    Protected Sub btnCherch_Click(sender As Object, e As EventArgs) Handles btnCherch.Click
        Dim query As String = "SELECT * FROM Employee where id=@id"
        Using con As SqlConnection = New SqlConnection("Data Source=DESKTOP-1S91SBO\MED;Initial Catalog=GestionEmp;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(query, con)
                cmd.Parameters.AddWithValue("@id", id_emp.Text)
                Using de As New SqlDataAdapter()
                    de.SelectCommand = cmd
                    Using dt As New DataTable()
                        de.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            id_emp.Text = dt.Rows(0)(0).ToString()
                            nni_emp.Text = dt.Rows(0)(1).ToString()
                            nom_emp.Text = dt.Rows(0)(2).ToString()
                            prenom_emp.Text = dt.Rows(0)(3).ToString()
                            tel_emp.Text = dt.Rows(0)(4).ToString()
                            idDep.Text = dt.Rows(0)(5).ToString()
                        End If
                        DonnesEmp.DataSource = dt
                        DonnesEmp.DataBind()
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Protected Sub BtnDec_Click(sender As Object, e As EventArgs) Handles BtnDec.Click
        Response.Redirect("WF1.aspx")
    End Sub

    Protected Sub BtnDec0_Click(sender As Object, e As EventArgs) Handles BtnDeco.Click
        Session("user") = ""
        Response.Redirect("auth.aspx")
    End Sub
End Class