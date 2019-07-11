
Option Strict On

''' <summary>
''' Original Authors Name:    Alfred Massardo
''' Edited Authors Name: Dale Waugh
''' Project Name:   CarList
''' Date:           11-July-2019
''' Description     Application to keep a list of cars.
''' </summary>

Public Class frmCarInventory

    Private carList As New SortedList                                 ' collection of all the carList in the list
    Private currentCarIdentificationNumber As String = String.Empty ' current selected car identification number
    Private editMode As Boolean = False                                 '

    ''' <summary>
    ''' btnEnter_Click - Will validate that the data entered into the controls is appropriate.
    '''                - Once the data is validated a customer object will be create using the  
    '''                - parameterized constructor. It will also insert the new customer object
    '''                - into the carList collection. It will also check to see if the data in
    '''                - the controls has been selected from the listview by the user. In that case
    '''                - it will need to update the data in the specific car object and the 
    '''                - listview as well.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As CarInventory            ' declare a Car class
        Dim carItem As ListViewItem    ' declare a ListViewItem class

        ' validate the data in the form
        If IsValidInput() = True Then

            ' set the edit flag to true
            editMode = True




            ' if the current car identification number has a no value
            ' then this is not an existing item from the listview
            If currentCarIdentificationNumber.Trim.Length = 0 Then

                ' create a new car object using the parameterized constructor
                car = New CarInventory(cmbMake.Text, txtModel.Text.Trim, cmbYear.Text, txtPrice.Text, chkNew.Checked)

                ' add the car to the carList collection
                ' using the identoification number as the key
                ' which will make the customer object easier to
                ' find in the carList collection later
                carList.Add(car.IdentificationNumber.ToString(), car)

            Else
                ' if the current car identification number has a value
                ' then the user has selected something from the list view
                ' so the data in the customer object in the carList collection
                ' must be updated

                ' so get the car from the cars collection
                ' using the selected key
                car = CType(carList.Item(currentCarIdentificationNumber), CarInventory)

                ' update the data in the specific object
                ' from the controls
                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Price = txtPrice.Text
                car.Year = cmbYear.Text
                car.CarNewStatus = chkNew.Checked
            End If

            ' clear the items from the listview control
            lvwCars.Items.Clear()

            ' loop through the carList collection
            ' and populate the list view
            For Each carEntry As DictionaryEntry In carList

                ' instantiate a new ListViewItem
                carItem = New ListViewItem()

                ' get the car from the list
                car = CType(carEntry.Value, CarInventory)

                ' assign the values to the ckecked control
                ' and the subitems
                carItem.Checked = car.CarNewStatus
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year)
                carItem.SubItems.Add(FormatCurrency(car.Price, 2))


                ' add the new instantiated and populated ListViewItem
                ' to the listview control
                lvwCars.Items.Add(carItem)

            Next carEntry

            ' Alternate looping strategy
            'For index As Integer = 0 To customerList.Count - 1

            '    ' instantiate a new ListViewItem
            '    customerItem = New ListViewItem()

            '    ' get the customer from the list
            '    customer = CType(customerList(customerList.GetKey(index)), Customer)

            '    ' assign the values to the ckecked control
            '    ' and the subitems
            '    customerItem.Checked = customer.VeryImportantPersonStatus
            '    customerItem.SubItems.Add(customer.IdentificationNumber.ToString())
            '    customerItem.SubItems.Add(customer.Title)
            '    customerItem.SubItems.Add(customer.FirstName)
            '    customerItem.SubItems.Add(customer.LastName)

            '    ' add the new instantiated and populated ListViewItem
            '    ' to the listview control
            '    lvwCustomers.Items.Add(customerItem)

            'Next index

            ' clear the controls
            Reset()

            lblResult.Text = "It worked!"
            ' set the edit flag to false
            editMode = False

        End If

    End Sub

    ''' <summary>
    ''' Reset - set the controls back to their default state.
    ''' </summary>
    Private Sub Reset()


        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        chkNew.Checked = False
        cmbMake.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        lblResult.Text = String.Empty
        lvwCars.ResetText()
        lvwCars.SelectedItems.Clear() ' Resets selected item (Simon helped resolving crash on selecting an item)
        currentCarIdentificationNumber = String.Empty

    End Sub

    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty
        Dim doubleTest As Double = 0

        ' check if the title has been selected
        If cmbMake.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's make." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If txtModel.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's model number." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If txtPrice.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's price." & vbCrLf
            returnValue = False

            ' Test if input is a string
        ElseIf Not (Double.TryParse(txtPrice.Text, doubleTest)) Then

            outputMessage += "Please enter the car's price." & vbCrLf
            returnValue = False

            ' Test if input is not negative
        ElseIf (doubleTest < 0) Then
            outputMessage += "Please enter the car's price." & vbCrLf
            ' And, set the return value to false
            returnValue = False

        End If

        If cmbYear.SelectedIndex = -1 Then
            ' If not set then error message
            outputMessage += "Please select the car's year." & vbCrLf

            ' And, set the return value to false
            returnValue = False
        End If

        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lblResult.Text = "ERRORS" & vbCrLf & outputMessage

        End If



        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function

    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnReset_Click EventHandler will clear the form and set
    ''' focus back to the input text box. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' call the rest sub routine
        Reset()

    End Sub
    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnExit_Click EventHandler will close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' This will close the form
        Me.Close()

    End Sub

    ''' <summary>
    ''' lvwCustomers_ItemCheck - used to prevent the user from checking the check box in the list view
    '''                        - if it is not in edit mode
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCustomers_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCars.ItemCheck

        ' if it is not in edit mode
        If editMode = False Then

            ' the new value to the current value
            ' so it cannot be set in the listview by the user
            e.NewValue = e.CurrentValue

        End If

    End Sub

    ''' <summary>
    ''' lvwCustomers_SelectedIndexChanged - when the user selected a row in the list it will populate the fields for editing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCars.SelectedIndexChanged

        ' constant that represents the index of the subitem in the list that
        ' holds the customer identification number 
        Const identificationSubItemIndex As Integer = 1

        If (lvwCars.SelectedItems.Count > 0) Then ' Fixes the crash when selecting a different car after having selected one already. (Simon showed me how to fix this)

            ' Get the customer identification number 
            currentCarIdentificationNumber = lvwCars.Items(lvwCars.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

            ' Use the customer identification number to get the customer from the collection object
            Dim car As CarInventory = CType(carList.Item(currentCarIdentificationNumber), CarInventory)

            ' set the controls on the form
            txtModel.Text = car.Model               ' get the first name and set the text box
            txtPrice.Text = car.Price                 ' get the last name and set the text box
            cmbMake.Text = car.Make                     ' get the title and set the combo box
            cmbYear.Text = car.Year
            chkNew.Checked = car.CarNewStatus ' get the very important person status and set the combo box

            lblResult.Text = car.GetSalutation()
        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub lvwCustomers_Click(sender As Object, e As EventArgs) Handles lvwCustomers.Click
    '    lbResult.Text = "aaa"
    'End Sub
End Class

