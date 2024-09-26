Imports System
Imports Npgsql
Public Class Form1

    Private Sub sair_btn_Click(sender As Object, e As EventArgs) Handles sair_btn.Click
        Dim resposta As String
        resposta = MsgBox("Quer mesmo sair?", vbYesNo + vbInformation, "Sair")
        If resposta = vbYes Then
            MsgBox("Encerrar programa " & txt_nome.Text, , "Adeus :(")
            Application.Exit()
        End If
    End Sub


    Private Sub editar_btn_Click(sender As Object, e As EventArgs) Handles editar_btn.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub enviar_btn_Click(sender As Object, e As EventArgs) Handles enviar_btn.Click
        ' Obtém os dados do formulário
        Dim nome As String = txt_nome.Text
        Dim telefone As String = txt_telefone.Text
        Dim email As String = email_txt.Text
        Dim endereco As String = txt_endereco.Text

        ' Verifica se todos os campos estão preenchidos
        If String.IsNullOrWhiteSpace(nome) OrElse
       String.IsNullOrWhiteSpace(telefone) OrElse
       String.IsNullOrWhiteSpace(email) OrElse
       String.IsNullOrWhiteSpace(endereco) Then
            MessageBox.Show("Por favor, preencha todos os campos antes de enviar.")
            Return ' Interrompe a execução do código
        End If

        ' String de conexão com o banco de dados
        Dim connectionString As String = "Host=localhost;Username=postgres;Password=senha;Database=agenda"

        ' Cria uma nova conexão com o banco de dados
        Using conn As New NpgsqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "INSERT INTO contato (nome_contato, telefone_contato, email_contato, endereco_contato) VALUES (@nome, @telefone, @email, @endereco)"

                Using cmd As New NpgsqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("nome", nome)
                    cmd.Parameters.AddWithValue("telefone", telefone)
                    cmd.Parameters.AddWithValue("email", email)
                    cmd.Parameters.AddWithValue("endereco", endereco)

                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Contato salvo!")
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
