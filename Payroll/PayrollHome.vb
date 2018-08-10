Imports MySql.Data.MySqlClient

Public Class PayrollHome

    Public Sub InputButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton1.Click


        Dim payrolldatequery As String = ""
        If Me.payrolldatefrom.Text = Nothing And Me.payrolldateto.Text = Nothing Then
            payrolldatequery = ""
        Else
            If Me.payrolldatefrom.Text <> Nothing Then
                If payrolldateto.Text <> Nothing Then
                    payrolldatequery = " and  date_format(b.payrolldate, '%Y/%m/%d')  between '" & Format(payrolldatefrom.Value, "yyyy/MM/dd") & "' and '" & Format(payrolldateto.Value, "yyyy/MM/dd") & "' "
                Else
                    payrolldatequery = " and  b.payrolldate >= '" & Format(payrolldatefrom.Value, "yyyy/MM/dd") & "' "
                End If
            Else
                If payrolldateto.Text <> Nothing Then
                    payrolldatequery = " and b.payrolldate<= '" & Format(payrolldateto.Value, "yyyy/MM/dd") & "' "
                Else
                    payrolldatequery = " and b.payrolldate like '%%' "
                End If
            End If
        End If

        connect()
        con.Open()
        command = New MySqlCommand("select sum(a.gross) as Gross, c.companyname from payroll_register a join payroll_period b on a.payrollperiodid=b.payrollperiodid join company c on a.companyid=c.companyid where c.companyid<> 0" & payrolldatequery & " group by a.companyid ", con)
        reader = command.ExecuteReader
        Chart1.Series(0).Points.Clear()
        Do While reader.Read = True
            Chart1.Series("Series1").Points.AddXY(reader.GetString("CompanyName") & vbNewLine & Format(reader.Item("Gross"), "n2"), reader.GetInt32("Gross"))
        Loop


    End Sub


    Private Sub PayrollHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InputButton1_Click(sender, e)
        Me.payrolldatefrom.Value = fiscalyyearfrom(Now)
        Me.payrolldateto.Value = fiscalyearto(Now)
    End Sub
End Class