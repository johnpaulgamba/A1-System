Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class HistoryUpdate
    Private PrtSetupDB As New PrintDialog()
    Private WithEvents PrtDocument As New System.Drawing.Printing.PrintDocument()
    Private PageSetupDB As New PageSetupDialog()
    Private PrintPreviewDB As New PrintPreviewDialog()
    Private PrinterSettings As New System.Drawing.Printing.PrinterSettings()
    Private Sub PrinterSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrinterSetup.Click
        PageSetupDB.Document = PrtDocument
        PageSetupDB.ShowDialog()
    End Sub

    Private Sub PrintPreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewButton.Click
        With PrintPreviewDB
            .Document = PrtDocument
            .ShowDialog()
        End With
    End Sub

    Private Sub PrintDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintDocument.Click
        With PrtSetupDB

            .Document = PrtDocument
            .PrinterSettings = PrinterSettings
            If (PrtSetupDB.ShowDialog() = DialogResult.OK) Then
                PrtDocument.Print()
            End If
        End With
    End Sub
    Private Sub PrtDocument_PrintPage(ByVal sender As Object, ByVal ev As PrintPageEventArgs) Handles PrtDocument.PrintPage
        ev.Graphics.DrawString(HistoryTextbox.Text, HistoryTextbox.Font, Brushes.Black, 10, 10)
    End Sub

    Private Sub CloseForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseForm.Click
        Me.Close()
    End Sub
    Public Sub loaddata(ByVal a As String, ByVal ColumnID As String, ByVal id As Integer)
        Try
            connect()
            con.Open()
            Dim ds As New DataSet
            Dim adapter As New MySqlDataAdapter("SELECT CHANGESMADE from " & a & " Where " & ColumnID & "=" & id, con)
            adapter.Fill(ds)
            adapter.Dispose()
            con.Close()
            With ds.Tables(0).Rows(0)
                Me.HistoryTextbox.Text = .Item("ChangesMade")
            End With

        Catch ex As Exception
            FunctionClass.showMessage(ex.Message, "Exception found", "Contact system admin")
        End Try
    End Sub

End Class
