Imports System.IO.StreamReader
Imports MySql.Data.MySqlClient
Public Class DTR
    Dim adapter As MySqlDataAdapter
    Dim cmdBuilder As MySqlCommandBuilder
    Dim ds As New DataSet
    Dim SR As IO.StreamReader
    Dim RecNo As String
    Dim EmpID As String
    Dim TimeLog As String
    Dim tmpTime As String
    Dim FileName As String = ""
    Dim TotalRecords As Long
    Dim RecPos As Long = 0
    Dim itmListItem As ListViewItem
    Dim strData As String
    Dim Line() As String

    Dim strSQL As String
    Dim RecordNoS As String
    Dim LogDetailss As String
    Dim EmployeeID As String
    Dim line0, line1, line2, line3, line4, line5, line6, line7, line8, line9, line10 As String
    Public ano As Boolean
    Private Function CountRecords(ByVal fn As String) As Long
        Dim Count As Long
        Dim SR As IO.StreamReader
        Dim tmp As String
        SR = IO.File.OpenText(fn)
        Do While (SR.Peek <> -1)
            tmp = SR.ReadLine
            Count = Count + 1
        Loop
        SR.Close()
        Return Count
    End Function
    Private Function SplitWords(ByVal s As String) As String()
        Dim sLen As Long = s.Length - 1
        Dim data() As String = s.Split(New [Char]() {" "c, CChar(vbTab)})
        Return data
    End Function
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DlgOpenFile As New OpenFileDialog()
        With DlgOpenFile
            .ShowReadOnly = True
            .Title = "Browse the Log files"
            .Filter = "DAT Files|*.dat"
            .ShowDialog()
        End With
        FileName = DlgOpenFile.FileName
        Load_txtFile(FileName)

    End Sub
    Private Sub Load_txtFile(ByVal a As String)
        Try
            Dim i As Integer = 0
            TotalRecords = CountRecords(a) - 1
            SR = IO.File.OpenText(a)
            Do While (RecPos <= TotalRecords)

                strData = SR.ReadLine
                If RecPos > 0 Then
                    itmListItem = New ListViewItem()
                    Line = SplitWords(strData)
                    line0 = Line(0)
                    line1 = Line(1)
                    line2 = Line(2)
                    line3 = Line(3)
                    line4 = Line(4)
                    line5 = Line(5)
                    line6 = Line(6)
                    line7 = Line(7)
                    line8 = Line(8)
                    line9 = Line(9)
                    line10 = Line(10)

                End If
                Me.DataGridView1.Rows.Add()
                With Me.DataGridView1.Rows(i)
                    .Cells("col1").Value = line4
                    .Cells("col2").Value = line5
                    .Cells("col3").Value = line6
                    .Cells("col4").Value = line7
                    .Cells("col5").Value = line8
                    .Cells("col6").Value = line9
                    .Cells("col7").Value = line10
                End With
                RecPos = RecPos + 1
                i = i + 1
            Loop
            SR.Close()
            With Me.DataGridView1
                .Rows.RemoveAt(0)
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .MultiSelect = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As Double
        a = DateDiff(DateInterval.Hour, dt1.Value, DT2.Value)
        Me.num1.Value = a
    End Sub
End Class