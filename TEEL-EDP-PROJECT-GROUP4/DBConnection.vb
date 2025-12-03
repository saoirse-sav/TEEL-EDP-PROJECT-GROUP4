Imports MySql.Data.MySqlClient
Module DBConnection
        Public conn As MySqlConnection

        ' Replace this with your school’s database settings later
        Public connectionString As String = "server=localhost;user id=root;password=;database=car_rental_db;"

        ' Function to open connection
        Public Sub OpenConnection()
            Try
                conn = New MySqlConnection(connectionString)
                conn.Open()
            Catch ex As Exception
                MessageBox.Show("Error connecting to database: " & ex.Message)
            End Try
        End Sub

        ' Function to close connection
        Public Sub CloseConnection()
            Try
                If conn IsNot Nothing Then
                    conn.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("Error closing connection: " & ex.Message)
            End Try
        End Sub

    End Module


