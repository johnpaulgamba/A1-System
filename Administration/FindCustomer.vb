Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class FindCustomer
    Private filteritem As String
    Public valuexx As Integer
    Public from As String
    Sub New(ByVal x As String)
        initializecomponent()
        If x = " " Then filteritem = "0" Else filteritem = x
    End Sub
    Private Sub searchbutton_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Searchbutton.Click
        ' If Me.branch.text = Nothing Then showmessage("you are required to select valid branch!", "invalid branch", "invalid branch", 3) : Exit Sub
        Dim itemnamefilter As String = ""
        itemnamefilter = " and customername like '%" & convertQuotes(Me.customer.Text) & _
                    "%' and address like '%" & convertQuotes(Me.Address.Text) & "%'"
        filter(itemnamefilter)
    End Sub
    Private Sub filter(ByVal filterquery As String)

        'loadtoGrid("Admin_CustomerSearch_Main", filterquery, Me.C1FlexGrid1)

    End Sub

    Private Sub inputbutton1_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.C1FlexGrid1.Rows.Selected.Count < 0 Then
            showMessage("you are required to select a valid item.", "invalid item", "not valid", 3)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub inputbutton4_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton4.Click
        Me.Close()
    End Sub


    Private Sub inputbutton2_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim i As Integer = Me.C1FlexGrid1.Rows(Me.C1FlexGrid1.RowSel).Item("itemid")
            ' Dim x As New inventory_per_location(i)
            ' With x
            '.startposition = FormStartPosition.CenterParent
            '.showdialog()
            ' End With
        Catch ex As Exception

        End Try
    End Sub
    Private Sub C1FlexGrid1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles C1FlexGrid1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.C1FlexGrid1.Rows.Selected.Count - 1 < 0 Then
                showMessage("you are required to select a valid customer.", "invalid customer", "not valid", 3)
            Else
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub ItemName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles customer.KeyDown, Address.KeyDown
        If e.KeyCode = Keys.Enter Then
            Searchbutton.PerformClick()
        ElseIf e.KeyCode = Keys.Down Then
            C1FlexGrid1.Focus()
        End If
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click

        Me.customer.Text = Nothing
        Me.Address.Text = Nothing

    End Sub
End Class