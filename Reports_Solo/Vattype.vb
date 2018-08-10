Public Class Vattype
    Public salesinvoiceid As Integer
    Public vattype As String

    Public Sub New(ByVal a As String, ByVal b As Integer)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        salesinvoiceid = b
        vattype = a
        Me.vattypex.Text = a
    End Sub

    Private Sub btnsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        Dim cur As String = ""
        Select Case Currency.Text
            Case "Philippine Peso"
                cur = "Php"
            Case "US Dollar"
                cur = "$"
        End Select
        Dim x As New reportpreview
        With x
            .print("Reporting_salesinvoice_Solo", "id", salesinvoiceid, 4, vattype, cur)
            .Text = "Print  preview of Sales Invoice #" & salesinvoiceid
            .StartPosition = FormStartPosition.centerscreen
            .WindowState = FormWindowState.Maximized
            .Show()
        End With
        Me.Hide()

    End Sub

    Private Sub vattypex_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles vattypex.SelectedIndexChanged
        vattype = vattypex.Text
    End Sub

    Private Sub btclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btclose.Click
        Me.Close()
    End Sub
End Class