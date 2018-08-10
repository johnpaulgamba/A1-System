Imports System.Reflection
Imports System.Net
Imports System.IO
Imports System.Threading
Imports C1.Win.C1FlexGrid
Module Launcher

    Public Sub MainLauncher(ByVal a As Integer)
        If a = 1 Then
            Cursor.Current = Cursors.Default
        Else
            Cursor.Current = Cursors.WaitCursor
        End If
    End Sub
    Public Sub MainLauncher(ByVal datagridview1 As C1FlexGrid, ByVal a As Integer)
        If a = 1 Then
            MainLauncher(0)
            With datagridview1
                .Redraw = True
                .ScrollBars = ScrollBars.Both
            End With
            Cursor.Current = Cursors.Default
        Else
            Cursor.Current = Cursors.WaitCursor
            With datagridview1
                .Redraw = False
                .ScrollBars = ScrollBars.None
            End With
            MainLauncher(1)

        End If
    End Sub
    Public Sub MainLauncher2(ByVal datagridview1 As C1FlexGrid, ByVal a As Integer)
        If a = 1 Then
            With datagridview1
                .Redraw = True
                .ScrollBars = ScrollBars.Both
            End With
        Else
            With datagridview1
                .Redraw = False
                .ScrollBars = ScrollBars.None
            End With

        End If
    End Sub
End Module