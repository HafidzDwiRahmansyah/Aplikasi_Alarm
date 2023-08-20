Imports System.IO
Public Class Form1
    Dim s As Integer = 0
    Dim d As Path
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        DateTimePicker1.Format = DateTimePickerFormat.Time
        Timer2.Enabled = True
        TextBox1.Text = ""
    End Sub
End Class
