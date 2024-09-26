Imports Npgsql

Public Class Form2
    Private dt As DataTable

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Host=localhost;Username=postgres;Password=senha;Database=agenda"

        Using conn As New NpgsqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "SELECT id_contato, nome_contato, telefone_contato, email_contato, endereco_contato FROM contato"
                Dim da As New NpgsqlDataAdapter(sql, conn)
                dt = New DataTable()
                da.Fill(dt)
                DataGridView1.DataSource = dt

                ' Ocultar a coluna de id_contato
                DataGridView1.Columns("id_contato").Visible = False

                ' Renomear cabeçalhos das colunas
                DataGridView1.Columns("nome_contato").HeaderText = "NOME"
                DataGridView1.Columns("telefone_contato").HeaderText = "TELEFONE"
                DataGridView1.Columns("email_contato").HeaderText = "EMAIL"
                DataGridView1.Columns("endereco_contato").HeaderText = "ENDEREÇO"

                ' Configurações de estilo
                DataGridView1.DefaultCellStyle.BackColor = Color.LightGray
                DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)
                DataGridView1.DefaultCellStyle.ForeColor = Color.Black
                DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

                DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue
                DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)
                DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                DataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkBlue
                DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                DataGridView1.BorderStyle = BorderStyle.Fixed3D
                DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
                DataGridView1.GridColor = Color.LightGray

                ' Habilitar rolagem suave
                DataGridView1.ScrollBars = ScrollBars.Both

            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro ao carregar os dados: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub excluir_btn_Click(sender As Object, e As EventArgs) Handles excluir_btn.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim idContato As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("id_contato").Value)
            Dim connectionString As String = "Host=localhost;Username=postgres;Password=senha;Database=agenda"

            Using conn As New NpgsqlConnection(connectionString)
                Try
                    conn.Open()
                    Dim sql As String = "DELETE FROM contato WHERE id_contato = @id_contato"
                    Using cmd As New NpgsqlCommand(sql, conn)
                        cmd.Parameters.AddWithValue("id_contato", idContato)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Contato excluído com sucesso!")
                    ' Recarregar os dados no DataGridView
                    ReloadData(conn)
                Catch ex As Exception
                    MessageBox.Show("Ocorreu um erro ao excluir o contato: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Por favor, selecione um contato para excluir.")
        End If
    End Sub

    Private Sub ReloadData(conn As NpgsqlConnection)
        Dim sql As String = "SELECT id_contato, nome_contato, telefone_contato, email_contato, endereco_contato FROM contato"
        Dim da As New NpgsqlDataAdapter(sql, conn)
        dt = New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt

        ' Ocultar a coluna de id_contato após recarregar os dados
        DataGridView1.Columns("id_contato").Visible = False

        ' Aplicar as mesmas configurações de estilo ao recarregar
        DataGridView1.DefaultCellStyle.BackColor = Color.LightGray
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 10)
        DataGridView1.DefaultCellStyle.ForeColor = Color.Black
        DataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 12, FontStyle.Bold)
        DataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        DataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkBlue
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BorderStyle = BorderStyle.Fixed3D
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridView1.GridColor = Color.LightGray
    End Sub

    Private Sub salvar_btn_Click(sender As Object, e As EventArgs) Handles salvar_btn.Click
        Dim connectionString As String = "Host=localhost;Username=postgres;Password=eduro2003;Database=agenda"

        Using conn As New NpgsqlConnection(connectionString)
            Try
                conn.Open()
                ' Iterar pelas linhas do DataTable e salvar alterações
                For Each row As DataRow In dt.Rows
                    If row.RowState = DataRowState.Modified Then
                        Dim sql As String = "UPDATE contato SET nome_contato = @nome_contato, telefone_contato = @telefone_contato, email_contato = @email_contato, endereco_contato = @endereco_contato WHERE id_contato = @id_contato"
                        Using cmd As New NpgsqlCommand(sql, conn)
                            cmd.Parameters.AddWithValue("id_contato", row("id_contato"))
                            cmd.Parameters.AddWithValue("nome_contato", row("nome_contato"))
                            cmd.Parameters.AddWithValue("telefone_contato", row("telefone_contato"))
                            cmd.Parameters.AddWithValue("email_contato", row("email_contato"))
                            cmd.Parameters.AddWithValue("endereco_contato", row("endereco_contato"))
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
                MessageBox.Show("Alterações salvas com sucesso!")
                ' Recarregar os dados no DataGridView
                ReloadData(conn)
            Catch ex As Exception
                MessageBox.Show("Ocorreu um erro ao salvar as alterações: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

End Class
