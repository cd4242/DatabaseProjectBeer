Public Class DatabaseForm

    'Sub procedure that executes on Database Form Load.
    Public Sub Database_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Adds customer information from the database to the customer DataGridView
        Me.CompaniesTableAdapter.Fill(Me.Database1DataSet.Companies)

        'Adds product information from the database to the product DataGridView
        Me.ProductsTableAdapter.Fill(Me.Database1DataSet.Products)

    End Sub

    'Sub procedure to handle Companies Table "SaveItem.Click."
    Private Sub CompaniesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CompaniesBindingNavigatorSaveItem.Click

        'Saves user entered information regarding the Company into the database
        Me.Validate()
        Me.CompaniesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet)

    End Sub

    'Sub procedure to handle Products Table "SaveItem.Click."
    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click

        'Saves user entered information regarding the Products into the database
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.ProductsTableAdapter.Update(Me.Database1DataSet)

    End Sub

    'Sub procedure to handle "Company_ID" search field.
    Private Sub Company_IDToolStripButton_Click(sender As Object, e As EventArgs) Handles Company_IDToolStripButton.Click

        'Try/Catch block handles invalid inputs.
        Try

            'Company table adapter that searches "Company_ID" field/Column.
            Me.CompaniesTableAdapter.Company_ID(Me.Database1DataSet.Companies, Company_IDToolStripTextBox.Text & "%")

        Catch ex As System.Exception 'Handles "System.Exception"

            'Standard Windows Forms Try/Catch Message. This may be changed to something else.
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

    End Sub

    'Sub procedure to handle company "Name" search field.
    Private Sub NameToolStripButton_Click(sender As Object, e As EventArgs) Handles NameToolStripButton.Click

        'Try/Catch block handles invalid inputs.
        Try

            'Company table adapter that searches "Name" field/Column.
            Me.CompaniesTableAdapter.Company_ID(Me.Database1DataSet.Companies, NameToolStripTextBox.Text & "%")

        Catch ex As System.Exception 'Handles "System.Exception"

            'Standard Windows Forms Try/Catch Message. This may be changed to something else.
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

    End Sub

    'Sub procedure to handle company "Address" search field.
    Private Sub AddressToolStripButton_Click(sender As Object, e As EventArgs) Handles AddressToolStripButton.Click

        'Try/Catch block handles invalid inputs.
        Try

            'Company table adapter that searches "Address" field/Column.
            Me.CompaniesTableAdapter.Company_ID(Me.Database1DataSet.Companies, AddressToolStripTextBox.Text & "%")

        Catch ex As System.Exception 'Handles "System.Exception"

            'Standard Windows Forms Try/Catch Message. This may be changed to something else.
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

    End Sub

    'Sub procedure to handle company "Phone" search field.
    Private Sub PhoneToolStripButton_Click(sender As Object, e As EventArgs) Handles PhoneToolStripButton.Click

        'Try/Catch block handles invalid inputs.
        Try

            'Company table adapter that searches "Phone" field/Column.
            Me.CompaniesTableAdapter.Company_ID(Me.Database1DataSet.Companies, PhoneToolStripTextBox.Text & "%")

        Catch ex As System.Exception 'Handles "System.Exception"

            'Standard Windows Forms Try/Catch Message. This may be changed to something else.
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

    End Sub

    'Sub procedure to handle Products "Product_ID" search field.
    Private Sub Product_IDToolStripButton_Click(sender As Object, e As EventArgs) Handles Product_IDToolStripButton.Click

        'Try/Catch block handles invalid inputs.
        Try

            'Products table adapter that searches "Products_ID" field/Column.
            Me.ProductsTableAdapter.Product_ID(Me.Database1DataSet.Products, Product_IDToolStripTextBox.Text & "%")

        Catch ex As System.Exception 'Handles "System.Exception"

            'Standard Windows Forms Try/Catch Message. This may be changed to something else.
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

    End Sub

    'Sub procedure to handle Products "Name " search field.
    Private Sub ProductNameToolStripButton_Click(sender As Object, e As EventArgs) Handles ProductNameToolStripButton.Click

        Try

            'Products table adapter that searches "Name" field/Column.
            Me.ProductsTableAdapter.Product_ID(Me.Database1DataSet.Products, ProductNameToolStripTextBox.Text & "%")

        Catch ex As System.Exception 'Handles "System.Exception"

            'Standard Windows Forms Try/Catch Message. This may be changed to something else.
            System.Windows.Forms.MessageBox.Show(ex.Message)

        End Try

    End Sub

    'Sub procedure to handle "Add Company" menuStripItem.click.
    Private Sub AddContactToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddContactToolStripMenuItem.Click

        'Creates and shows new form2
        Dim add As New AddCompanyForm
        add.Show()

    End Sub

    'Sub procedure to handle "Add Products" menuStripItem.click.
    Private Sub AddProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddProductToolStripMenuItem.Click

        'Creates new product form, shows form.
        Dim add As New AddProductForm
        add.Show()

    End Sub

    'Sub procedure to handle "Exit" menuStripItem.click.
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        'Exits the application
        Me.Close()

    End Sub

    'Sub procedure to handle "About" menuStripItem.click.
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        'Prompts the user about the application
        MsgBox("Hayes' Beer Da'base!" + vbNewLine + "Created by: Michael K. Neumann, Nicholas Inman," + vbNewLine +
               "                     Vanessa Torres, and Charlie Detlof." + vbNewLine + "Course: POS/408" + vbNewLine + "Version: A1.1")

    End Sub

    'Sub procedure to handle "Delete All Companies" menuStripItem.click
    Private Sub CompaniesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompaniesToolStripMenuItem.Click

        'Custom MessageBox with yes or no buttons
        Dim msg = "Do you want to delete all data in Company Table?"
        Dim title = "WARNING!"
        Dim style = MessageBoxButtons.YesNo
        Dim del = MsgBox(msg, style, title)

        If DialogResult.Yes Then

            'Deletes each row from table.
            For Each row As DataRow In Database1DataSet.Companies().Rows
                row.Delete()
            Next

            'Performs Save.
            CompaniesBindingNavigatorSaveItem.PerformClick()

        ElseIf DialogResult.No Then

            Exit Sub

        End If

    End Sub

    'Sub procedure to handle "Delete All Products" menuStripItem.click
    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductsToolStripMenuItem.Click

        'Custom MessageBox with yes or no buttons
        Dim msg = "Do you want to delete all data in Company Table?"
        Dim title = "WARNING!"
        Dim style = MessageBoxButtons.YesNo
        Dim del = MsgBox(msg, style, title)

        If DialogResult.Yes Then

            'Deletes each row from table.
            For Each row As DataRow In Database1DataSet.Products().Rows
                row.Delete()
            Next

            'Performs Save.
            ProductsBindingNavigatorSaveItem.PerformClick()

        ElseIf DialogResult.No Then

            Exit Sub

        End If

    End Sub

    'Sub procedure to handle duplicate Primary Keys in Companies table.
    Private Sub CompaniesDataGridView_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles CompaniesDataGridView.DataError

        MsgBox("Database Error! COMPANY ALREADY EXISTS** OR INVALID INPUT IN FIELD." + vbNewLine + vbNewLine + "**Company ID, Address, and or Phone number already exists**")

    End Sub

    'Sub procedure to handle duplicate Primary Keys in Products table.
    Private Sub ProductsDataGridView_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles ProductsDataGridView.DataError

        MsgBox("Database Error! PRODUCT ALREADY EXISTS** OR INVALID INPUT IN FIELD." + vbNewLine + vbNewLine + "**Product ID already exists**")

    End Sub

End Class