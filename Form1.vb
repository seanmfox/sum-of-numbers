'Name: Sean Fox
'Course: CIT-161-Z03B
'Date: 5-31-19
'Program Name: Sum of Numbers
'Description: Chapter 5, Programming Challenge 1 - Create an application that sums the integers from 1 to the value entered by the user.


Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strUserInput As String = InputBox("Enter a positive integer value.", "Input Needed", "10")
        Dim intInput As Integer = CInt(strUserInput)
        Dim intTotal As Integer = 0
        For index = 1 To intInput
            intTotal += index
        Next
        MessageBox.Show("The sum of numbers 1 through " + intInput.ToString + " is " + intTotal.ToString)
    End Sub
End Class
