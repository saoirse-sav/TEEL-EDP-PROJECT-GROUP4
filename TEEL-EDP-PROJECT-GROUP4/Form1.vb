Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub LoadData()
        Try
            OpenConnection()
            Dim query As String = "SELECT rental_id, car_model, renter_name, start_date, end_date FROM rentals WHERE is_deleted = 0"
            Dim da As New MySqlDataAdapter(query, conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            dgvRentals.DataSource = dt
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        LoadData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtCarModel.Text = "" Or txtRenterName.Text = "" Or txtStartDate.Text = "" Or txtEndDate.Text = "" Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If

        Try
            OpenConnection()
            Dim query As String = "INSERT INTO rentals (car_model, renter_name, start_date, end_date) VALUES (@car, @renter, @start, @end)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@car", txtCarModel.Text)
            cmd.Parameters.AddWithValue("@renter", txtRenterName.Text)
            cmd.Parameters.AddWithValue("@start", txtStartDate.Text)
            cmd.Parameters.AddWithValue("@end", txtEndDate.Text)

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Record Added!")
            LoadData()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtID.Text = "" Then
            MessageBox.Show("Select a record first.")
            Return
        End If

        Try
            OpenConnection()
            Dim query As String = "UPDATE rentals SET car_model=@car, renter_name=@renter, start_date=@start, end_date=@end WHERE rental_id=@id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@car", txtCarModel.Text)
            cmd.Parameters.AddWithValue("@renter", txtRenterName.Text)
            cmd.Parameters.AddWithValue("@start", txtStartDate.Text)
            cmd.Parameters.AddWithValue("@end", txtEndDate.Text) 'dapat year muna, bago months, then days.
            cmd.Parameters.AddWithValue("@id", txtID.Text) 'same here

            cmd.ExecuteNonQuery()
            conn.Close()

            MessageBox.Show("Record Updated!")
            LoadData()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtID.Text = "" Then
            MessageBox.Show("Select a record to delete.")
            Return
        End If

        Try
            OpenConnection()
            Dim query As String = "UPDATE rentals SET is_deleted = 1 WHERE rental_id=@id"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.ExecuteNonQuery()

            conn.Close()

            MessageBox.Show("Record Deleted!")
            LoadData()
            ClearFields()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvRentals_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRentals.CellContentClick
        If e.RowIndex >= 0 Then
            txtID.Text = dgvRentals.Rows(e.RowIndex).Cells(0).Value.ToString()
            txtCarModel.Text = dgvRentals.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtRenterName.Text = dgvRentals.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtStartDate.Text = dgvRentals.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtEndDate.Text = dgvRentals.Rows(e.RowIndex).Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    Private Sub ClearFields()
        txtID.Clear()
        txtCarModel.Clear()
        txtRenterName.Clear()
        txtStartDate.Clear()
        txtEndDate.Clear()
    End Sub
End Class
