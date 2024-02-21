Public Class Form1
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click

        If Trim(EmployeeFirstName.Text) = "" Then
            ' If the textbox is empty, display an error message
            MsgBox("Please enter the employee's First name.", vbExclamation, "Error")
            Exit Sub
        End If

        If Trim(EmployeeLastName.Text) = "" Then
            ' If the textbox is empty, display an error message
            MsgBox("Please enter the employee's last name.", vbExclamation, "Error")
            Exit Sub
        End If

        If Trim(EmployeeID.Text) = "" Then
            ' If the textbox is empty, display an error message
            MsgBox("Please enter the employee ID.", vbExclamation, "Error")
            Exit Sub
        End If

        If Trim(day.Text) = "" Then
            ' If the textbox is empty, display an error message
            MsgBox("Please enter the number of days worked.", vbExclamation, "Error")
            Exit Sub
        End If

        If Trim(salary.Text) = "" Then
            ' If the textbox is empty, display an error message
            MsgBox("Please enter the employee's basic salary.", vbInformation, "Error")
            Exit Sub
        End If

        Dim daysWorkedValue As Integer
        Dim basicSalaryValue As Integer

        daysWorkedValue = Val(daysWorked.Text)
        basicSalaryValue = Val(salary.Text)

        If daysWorkedValue = 20 Then
            pay.Text = basicSalaryValue
        Else
            pay.Text = (basicSalaryValue) - (500 * (20 - daysWorkedValue))
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(pay.Text) = "" Then
            ' If the textbox is empty, display an error message
            MsgBox("Please confirm amount to be paid first.", vbExclamation, "Error")
            Exit Sub
        End If

        If Trim(bank.Text) = "" Then
            ' If the textbox is empty, display an error message
            MsgBox("Payment failed because no account details were entered", vbExclamation, "Error")
            Exit Sub
        End If

        If Trim(AccountNumber.Text) = "" Then
            ' If the textbox is empty, display an error message
            MsgBox("Payment failed because no account details were entered", vbExclamation, "Error")
            Exit Sub
        End If

        ' Display a message box with a notification
        MsgBox("Payment for the user is being processed.", vbInformation, "Payment Processing")

        ' Once payment processing is complete, you can display another message
        MsgBox("Payment processed successfully.", vbInformation, "Payment Processing Complete")
    End Sub
End Class
