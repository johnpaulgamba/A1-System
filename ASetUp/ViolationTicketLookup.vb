Public Class ViolationTicketLookup
    Private filteritem As String
    Public valuexx As Integer
    Public from As String
   
    Sub New(ByVal a As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub C1FlexGrid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1FlexGrid1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.C1FlexGrid1.Rows.Selected.Count - 1 < 0 Then
                showMessage("you are required to select a valid item.", "invalid item", "not valid", 3)
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Me.violation.Text = Nothing
        Me.employee.Text = Nothing
    End Sub

    Private Sub itemlookup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        employee.Focus()
    End Sub
    Private Sub itemname_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles violation.KeyDown, employee.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim itemnamefilter As String = ""
                itemnamefilter = " and concat(b.LastName, ' ', b.FirstName, ' ', b.LastName) like '%" & convertQuotes(Me.employee.Text) & _
                    "%' and c.violationdetails like '%" & convertQuotes(Me.violation.Text) & "%'"
                loadtoGrid("select a.ticketid,a.ticketno,concat(b.LastName, ' ', b.FirstName, ' ', b.LastName) as Employee, c.ViolationDetails, a.Status from hris_violationticket a join hris_employee b on a.employeeid=b.employeeid join hris_violation_Setup c on a.violationid=c.violationid " & _
                       " where a.Status='OPEN'  " & itemnamefilter, Me.C1FlexGrid1)
            Catch ex As Exception
            End Try
        ElseIf e.KeyCode = Keys.Down Then
            C1FlexGrid1.Focus()
        End If
    End Sub

    Public Sub Searchbutton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Searchbutton.Click
        Try
            Dim itemnamefilter As String = ""
            itemnamefilter = " and concat(b.LastName, ' ', b.FirstName, ' ', b.LastName) like '%" & convertQuotes(Me.employee.Text) & _
                "%' and c.violationdetails like '%" & convertQuotes(Me.violation.Text) & "%'"
            loadtoGrid("select a.ticketid,a.ticketno,concat(b.LastName, ' ', b.FirstName, ' ', b.LastName) as Employee, c.ViolationDetails, a.Status from hris_violationticket a join hris_employee b on a.employeeid=b.employeeid join hris_violation_Setup c on a.violationid=c.violationid " & _
                   " where a.Status='OPEN'  " & itemnamefilter, Me.C1FlexGrid1)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub InputButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton4.Click, C1FlexGrid1.DoubleClick
        If Me.C1FlexGrid1.Rows.Selected.Count < 0 Then
            showMessage("you are required to select a valid item.", "invalid item", "not valid", 3)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
        Me.Close()
    End Sub
End Class

