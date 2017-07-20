Public Class TitleForm

    'Sub procedure to handle "Add Company" button click.
    Private Sub AddCompanyBtn_Click(sender As Object, e As EventArgs) Handles AddCompanyBtn.Click

        'Creates new company form, shows form.
        Dim add As New AddCompanyForm
        add.Show()

    End Sub

    'Sub procedure to handle "Add Product" button click.
    Private Sub AddProductBtn_Click(sender As Object, e As EventArgs) Handles AddProductBtn.Click

        'Creates new product form, shows form.
        Dim add As New AddProductForm
        add.Show()

    End Sub

    'Sub procedure to handle "Database" button click.
    Private Sub DatabaseBtn_Click(sender As Object, e As EventArgs) Handles DatabaseBtn.Click

        'Shows DatabaseForm.
        DatabaseForm.Show()

    End Sub

    'Sub procedure to handle Info button click.
    Private Sub AboutBtn_Click(sender As Object, e As EventArgs) Handles AboutBtn.Click

        'Performs event action.
        DatabaseForm.AboutToolStripMenuItem.PerformClick()

    End Sub

    'Sub procedure to handle "Exit" button click.
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click

        'Closes application.
        Me.Close()

    End Sub

End Class