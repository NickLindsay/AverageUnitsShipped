Public Class frmAverageUnitsShipped
    'Lab 1 : Average Units Shipped
    'By: Nicholas Lindsay
    'Date: 07 February 2018
    'Description: This program will allows users to enter in values of total amount of shipment for 7 days. Then,it will take the average.

    Const minimumValueSize As Integer = 0    ' This declares that no values can be smaller than 0
    Const maximumValueSize As Integer = 1000 ' This declares that no values can be bigger than 1000
    Private weekDays(6) As Integer           ' This declares that only 6 integers can be inputed
    Dim counter As Integer = 0               ' This will increase the days everytime a valid number is entered 
    Dim userinput As Integer = 0             ' This declares that user input cannot be a decimal value
    Dim total As Integer = 0                 ' This declares the total of all the input values added together
    Dim average As Double = 0                ' This declares the average of the average units shipped by dividing the total by 7
    Dim maxDays As Integer = 7               ' This declares the max amount of days in a week

    Dim a As Decimal = 2.5D
    Dim b As Decimal = 4D
    Dim c As Decimal = 12.7D

    Dim i As Integer = 4
    Dim j As Integer = 8
    Dim k As Integer = 17


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtEntry.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' For use of closing the progam

        Me.Close() ' This button will allow users to close the program
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' This will allows users to reset the program
        txtEntry.Text = ""               ' This will make the the input entry clear
        txtEntryOutput.Text = ""         ' This will clear the Entry Ouput text box
        txtEntry.Enabled = True          ' This will allow the user to enter a value into the input box
        txtEntryOutput.Enabled = True    ' This will allow user input to be stored into the Entry Output box
        txtWeekDays.Text = 1.ToString    ' This will allow for numbers days to increase with numeric entry and to be stored
        btnEnter.Enabled = True          ' This will allow the enter button to be used again
        counter = 0                      ' This will reset the counter back to 0
        total = 0                        ' This will reset the total back to 0
        average = 0                      ' This will reset the average back to 0
        txtEntry.Focus()                 ' This will allow the focus to go back to the input entry when reset



    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim x As Integer = i + j

        ' This is the equation to calculate average of units shipped
        lblOutput.Text = "Average Units Shipped: "  ' This will display the message with the average with 2 decimal places




    End Sub

    Private Sub txtEntryOutput_TextChanged(sender As Object, e As EventArgs) Handles txtEntryOutput.TextChanged

    End Sub

    Private Sub lblOutput_Click(sender As Object, e As EventArgs) Handles lblOutput.Click

    End Sub
End Class
