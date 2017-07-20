Public Class AddCompanyForm

    'Declares global variables.
    Private id As String
    Private Shadows name As String
    Private address As String
    Private phone As Integer
    Private email As String
    Private primaryContact As String
    Private BOH As Integer
    Private outBal As Double
    Private flag As Boolean = False

    'Declares gloable TableAdapter for Companies Table
    Private createCompany As New Database1DataSetTableAdapters.CompaniesTableAdapter()

    'Sub procedure to handle "Create" button click.
    Private Sub CreateBtn_Click(sender As Object, e As EventArgs) Handles CreateBtn.Click

        'Assigns values to variables when create is entered.
        id = CompanyIDTextBox.Text
        name = NameTextBox.Text
        address = AddressTextBox.Text
        phone = PhoneTextBox.Text
        email = EmailTextBox.Text
        primaryContact = PrimaryContactTextBox.Text
        BOH = BOHTextBox.Text
        outBal = OutBalTextBox.Text

        'Try/Catch Block handles duplicate Primary Keys in database.
        Try

            'Inserts fields into Company table row.
            createCompany.Insert(id, name, address, phone, email, primaryContact, BOH, outBal)

        Catch ex As System.Data.SqlServerCe.SqlCeException

            MsgBox("Company already exists in database!")
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
    Private Sub PhoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles PhoneTextBox.TextChanged

        'Control statement "If boolean varaible = False."
        If flag = False Then

            'Sets boolean to True.
            flag = True

            'Control statement to determine correct input type.
            If IsNumeric(PhoneTextBox.Text) = False Then

                PhoneTextBox.Clear()

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

    'Sub procedure to handle TextBox input.
    Private Sub OutBalTextBox_TextChanged(sender As Object, e As EventArgs) Handles OutBalTextBox.TextChanged

        'Control statement "If boolean varaible = False."
        If flag = False Then

            'Sets boolean to True.
            flag = True

            'Control statement to determine correct input type.
            If IsNumeric(OutBalTextBox.Text) = False Then

                OutBalTextBox.Clear()

            End If

        End If

        'Sets boolean to False.
        flag = False

    End Sub

End Class