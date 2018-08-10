Public Class salesorderlookup

    Private Sub inputbutton4_click(sender As system.object, e As system.eventargs) Handles inputbutton4.click
        Me.close()
    End Sub

    Private Sub searchbutton_click(sender As system.object, e As system.eventargs) Handles searchbutton.click
        Dim dateorderedquery As String = ""
        If Me.dateorderedfrom.text = Nothing And Me.dateorderedto.text = Nothing Then
            dateorderedquery = ""
        Else
            If Me.dateorderedfrom.text <> Nothing Then
                If dateorderedto.text <> Nothing Then
                    dateorderedquery = " and  date_format(a.dateordered, '%Y/%m/%d')  between '" & Format(DateOrderedFrom.Value, "yyyy/MM/dd") & "' and '" & Format(DateOrderedTo.Value, "yyyy/MM/dd") & "' "
                Else
                    dateorderedquery = " and  a.dateordered >= '" & Format(DateOrderedFrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If DateOrderedTo.Text <> Nothing Then
                    dateorderedquery = " and a.dateordered<= '" & Format(DateOrderedTo.Value, "yyyy/MM/dd") & "' "
                Else
                    dateorderedquery = " and a.dateordered like '%%' "
                End If
            End If
        End If

        Dim filterquery As String = " and  a.salesorderid like '%" & convertquotes(Me.soreference.text) & _
            "%' and customername like '%" & convertquotes(Me.customername.text) & _
            "%' and invoicenumber like '%" & convertquotes(Me.invoicenumber.text) & _
            "%' "
        loadtogrid("select a.salesorderid, concat('so  ', a.salesorderid) as soreference, " & _
                   " date_format(dateordered, '%m/%d/%y') as dateordered, invoicenumber, " & _
                   " customername, b.address from salesorder a  " & _
                   " join customers b on a.customerid=b.customerid  " & _
                   " where a.customerid=b.customerid and a.iscancelled=0 and a.isapproved=1 " & filterquery & " order by soreference desc", Me.c1flexgrid1)
    End Sub
End Class

