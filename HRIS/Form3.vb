Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim orno As String = InputBox("Enter OR number", "Request OR Number", Nothing)
            Do Until orno.Count > 0 And orno.Count <= 7
                If orno.Count > 7 Then
                    orno = InputBox("Enter OR number", "Request OR Number", Nothing)
                End If
            Loop

            If IsNumeric(orno) = True And Len(orno) <> 7 Then
                MessageBox.Show("not equal to 7")
            ElseIf IsNumeric(orno) = True And Len(orno) = 7 Then
                TextBox1.Text = orno
            Else
                MessageBox.Show("not numeric")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class