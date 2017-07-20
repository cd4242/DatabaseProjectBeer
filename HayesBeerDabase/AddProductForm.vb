Public Class AddProductForm

    'Declares global variables.
    Private id As String
    Private price As Integer
    Private Shadows location As String
    Private Shadows name As String
    Private quantity As Integer
    Private BOH As Integer
    Private flag As Boolean = False

    'Declares gloable TableAdapter for Products Table
    Private createProduct As New Database1DataSetTableAdapters.ProductsTableAdapter()

    'Sub procedure to handle "Create" button click.
    Private Sub CreateBtn_Click(sender As Object, e As EventArgs) Handles CreateBtn.Click

        'Assigns values to variables when create is entered.
        id = ProductIDTextBox.Text
        name = NameTextBox.Text
        quantity = QuantityTextBox.Text
        location = LocationTextBox.Text
        price = PriceTextBox.Text
        BOH = BOHTextBox.Text

        'Try/Catch Block handles duplicate Primary Keys in database.
        Try

            'Inserts fields into Products table row.
            createProduct.Insert(id, name, quantity, price, location, BOH)

        Catch ex As System.Data.SqlServerCe.SqlCeException

            MsgBox("Product already exists in database!")
            DatabaseForm.Show()
            Exit Sub

        End Try

        'Reloads DatabaseForm Public Sub procedure.
        DatabaseForm.Database_Load(e, e)

        Me.Close()

    End Sub

    'Sub procedure to handle "Cancel" button click.
    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click

        'Closes the form
        Me.Close()

    End Sub

    'Sub procedure to handle TextBox input.
    Private Sub QuantityTextBox_TextChanged(sender As Object, e As EventArgs) Handles QuantityTextBox.TextChanged

        Dim intValue As Integer
        'Control statement "If boolean varaible = False."
        If flag = False Then

            'Sets boolean to True.
            flag = True

            'Control statement to determine correct input type.
            If IsNumeric(QuantityTextBox.Text) = False Then

                QuantityTextBox.Clear()

            ElseIf Not Integer.TryParse(QuantityTextBox.Text, intValue) OrElse intValue < 0 Then 'Checks for letter/symbol characters

                QuantityTextBox.Clear()

            End If

        End If

        'Sets boolean to False.
        flag = False

    End Sub

    'Sub procedure to handle TextBox input.
    Private Sub PriceTextBox_TextChanged(sender As Object, e As EventArgs) Handles PriceTextBox.TextChanged

        'Control statement "If boolean varaible = False."
        If flag = False Then

            'Sets boolean to True.
            flag = True

            'Control statement to determine correct input type.
            If IsNumeric(PriceTextBox.Text) = False Then

                PriceTextBox.Clear()

            End If

        End If

        'Sets boolean to False.
        flag = False

    End Sub

    'Sub procedure to handle TextBox input.
    Private Sub BOHTextBox_TextChanged(sender As Object, e As EventArgs) Handles BOHTextBox.TextChanged

        Dim intValue As Integer
        'Control statement "If boolean varaible = False."
        If flag = False Then

            'Sets boolean to True.
            flag = True

            'Control statement to determine correct input type.
            If IsNumeric(BOHTextBox.Text) = False Then

                BOHTextBox.Clear()

            ElseIf Not Integer.TryParse(BOHTextBox.Text, intValue) OrElse intValue < 0 Then 'Checks for letter/symbol characters

                BOHTextBox.Clear()

            End If

        End If

        'Sets boolean to False.
        flag = False

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


    End Sub
End Class