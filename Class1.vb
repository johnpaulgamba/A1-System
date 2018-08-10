Imports C1.Win.C1FlexGrid
Imports System.IO
Imports DevComponents.DotNetBar
Imports MySql.Data.MySqlClient
Imports C1.Win.C1Command
Imports C1.Win.C1InputPanel
Public Class FunctionClass

#Region "Sales ORders and Sales Quotations And Sales bookings and Sales Contracts"
    Public Shared Sub ColumnVisible(ByVal a As Boolean, ByVal DATAGRIDVIEW1 As C1FlexGrid, ByVal ButtonItem5 As DevComponents.DotNetBar.ButtonItem, ByVal c1command1 As C1.Win.C1Command.C1CommandMenu)
        With DATAGRIDVIEW1
            MainLauncher(0)
            Try
                Dim i As Integer = 0
                Dim j As Integer = ButtonItem5.SubItems.Count - 2
                For i = 1 To j
                    Dim x As String = Trim(ButtonItem5.SubItems(i).Text.Replace(" ", ""))
                    '  MessageBox.Show(x)
                    If a = False Then
                        c1command1.CommandLinks.Item(i - 1).Command.Checked = Convert.ToBoolean(CType(ButtonItem5.SubItems(i), DevComponents.DotNetBar.ButtonItem).Checked)
                        .Cols(x).Visible = Convert.ToBoolean(CType(ButtonItem5.SubItems(i), DevComponents.DotNetBar.ButtonItem).Checked)
                    Else
                        CType(ButtonItem5.SubItems(i), DevComponents.DotNetBar.ButtonItem).Checked = c1command1.CommandLinks.Item(i - 1).Command.Checked
                        .Cols(x).Visible = c1command1.CommandLinks.Item(i - 1).Command.Checked
                    End If
                    If .Cols(x).Visible = True Then .AutoSizeCol(DATAGRIDVIEW1.Cols(x).Index)
                Next
            Catch ex As Exception
            Finally
                MainLauncher(1)
            End Try
        End With
    End Sub
    Public Shared Sub ColumnVisible(ByVal DATAGRIDVIEW1 As C1FlexGrid, ByVal c1command1 As C1.Win.C1Command.C1CommandMenu)
        With DATAGRIDVIEW1
            MainLauncher(0)
            Try
                Dim i As Integer = 0
                Dim j As Integer = c1command1.CommandLinks.Count - 1
                For i = 0 To j
                    Dim x As String = c1command1.CommandLinks.Item(i).Text.Replace(" ", "")
                    .Cols(x).Visible = c1command1.CommandLinks.Item(i).Command.Checked
                    If .Cols(x).Visible = True Then .AutoSizeCol(DATAGRIDVIEW1.Cols(x).Index)
                Next
            Catch ex As Exception
            End Try
            MainLauncher(1)
        End With
    End Sub
    Public Shared Sub GridStyle(ByVal DatagridView1 As C1FlexGrid)
        With DatagridView1
            '.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom
            'Dim cs = .Styles.Fixed
            'cs.BackgroundImage = baketechmainform.ImageList1.Images("header.png")
            'cs.BackgroundImageLayout = ImageAlignEnum.Stretch
            'cs.Border.Width = 0
            'cs.Border.Color = SystemColors.Control
            'cs.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
            '.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom
            .AllowFiltering = False
            .IgnoreDiacritics = False
            .ScrollBars = ScrollBars.Both
            .ScrollOptions = ScrollFlags.None
            .ExtendLastCol = True
            .Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
            ' .Styles.SelectedColumnHeader.BackColor = baketechmainform.BackgroundColor
            .Styles.Normal.Border.Color = SystemColors.Control
            .Styles.Normal.Border.Direction = BorderDirEnum.Both
            .Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
            '.Styles.Normal.Margins.Top = 1
            '.Styles.Normal.Margins.Bottom = 1
            .Styles.Normal.Border.Width = 1
            .Glyphs(GlyphEnum.Checked) = APCESMainForm.ImageList1.Images("checkbox.png")
            .Glyphs(GlyphEnum.Unchecked) = APCESMainForm.ImageList1.Images("checkbox_no.png")
            .ShowCellLabels = False
            .ShowThemedHeaders = ShowThemedHeadersEnum.None
            .Styles.Highlight.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Flat
            .Styles.Highlight.BackColor = SystemColors.Highlight
            .Styles.Highlight.Border.Color = Color.Silver
            .Styles.Highlight.Font = New Font(.Font.FontFamily, .Font.Size + 1, FontStyle.Bold)
            .Styles.Highlight.Border.Width = 1

            .Styles.EmptyArea.BackColor = Color.White
            .Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Double
            .Styles.EmptyArea.Border.Width = 10

            .Styles.Normal.TextEffect = TextEffectEnum.Flat
            .Styles.Normal.TextEffect = TextEffectEnum.Flat
            .Styles.Normal.Trimming = StringTrimming.EllipsisCharacter

            .Styles.Fixed.BackColor = APCESMainForm.BackgroundColor
            .Styles.Fixed.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Flat
            .Styles.Fixed.Border.Color = SystemColors.GrayText


            .AllowSorting = AllowSortingEnum.None
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
            Dim m_Skins As New Hashtable()
            'm_Skins.Add("Notebook", "Normal{Font:Viner Hand ITC, 11.25pt;BackColor:LightCyan;ForeColor:DarkBlue;Border:Flat,1,DarkCyan,Horizontal;}	Fixed{Font:Courier New, 9.75pt;BackColor:PaleTurquoise;ForeColor:Black;Border:Flat,2,Firebrick,Vertical;}	Highlight{Font:Viner Hand ITC, 11.25pt, style=Bold, Underline;BackColor:LightCyan;ForeColor:Red;}")
            '   DatagridView1.Styles.ParseString(m_Skins("Notebook"))
        End With
    End Sub
    ' Public m_Skins As New Hashtable()

    ' Public m_Skins As New Hashtable()

    Public Shared Sub GridStyle2(ByVal DatagridView1 As C1FlexGrid)
        With DatagridView1
            .AllowFiltering = False
            .ScrollOptions = ScrollFlags.None
            .ShowCellLabels = False
            .IgnoreDiacritics = False
            .ScrollBars = ScrollBars.Both
            .Glyphs(GlyphEnum.Checked) = APCESMainForm.ImageList1.Images("checkbox.png")
            .Glyphs(GlyphEnum.Unchecked) = APCESMainForm.ImageList1.Images("checkbox_no.png")
            .Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
            .Styles.Normal.Border.Color = Color.Silver
            .Styles.Normal.Border.Width = 1
            .Styles.Highlight.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
            .Styles.Highlight.Border.Color = Color.Silver
            .Styles.Highlight.Border.Width = 1
            .Styles.EmptyArea.BackColor = Color.White
            .Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Double
            .Styles.EmptyArea.Border.Width = 10
            .Styles.Normal.TextEffect = TextEffectEnum.Flat
            .Styles.Normal.TextEffect = TextEffectEnum.Flat
            .AllowSorting = AllowSortingEnum.None
            .Styles.EmptyArea.BackColor = Color.White
            .Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
        End With
    End Sub
    Public Shared Sub GridStyle3(ByVal DatagridView1 As C1FlexGrid)
        With DatagridView1
            .AllowFiltering = True
            .IgnoreDiacritics = False
            .ScrollBars = ScrollBars.Both
            .ScrollOptions = ScrollFlags.None
            .VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom
            .AllowFreezing = True
            .ShowCellLabels = False
            .Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Flat
            .Styles.Normal.Border.Direction = BorderDirEnum.Both
            .Styles.Normal.Border.Color = Color.Gainsboro
            .Styles.Normal.Border.Width = 1
            .Styles.Normal.TextEffect = TextEffectEnum.Flat
            .Styles.Highlight.TextEffect = TextEffectEnum.Flat

            .Styles.Alternate.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Flat
            .Styles.Alternate.Border.Direction = BorderDirEnum.Both
            .Styles.Alternate.Border.Color = Color.Gainsboro
            .Styles.Alternate.Border.Width = 1
            .Glyphs(GlyphEnum.Checked) = APCESMainForm.ImageList1.Images("checkbox.png")
            .Glyphs(GlyphEnum.Unchecked) = APCESMainForm.ImageList1.Images("checkbox_no.png")

            .Styles.Highlight.TextEffect = TextEffectEnum.Flat
            '.Styles.Alternate.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
            '.Styles.Alternate.Border.Color = Color.Silver
            '.Styles.Alternate.Border.Width = 1
            .Styles.Alternate.BackColor = Color.WhiteSmoke
            .Styles.Highlight.BackColor = Color.DeepSkyBlue
            .Styles.Highlight.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Flat
            .Styles.Highlight.Border.Color = SystemColors.Control
            .Styles.Highlight.Border.Width = 0
            .Styles.Alternate.TextEffect = TextEffectEnum.Flat
            .Styles.SelectedRowHeader.BackColor = Color.DeepSkyBlue

            .Styles.EmptyArea.BackColor = Color.White
            .Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Double
            .Styles.EmptyArea.Border.Width = 10

            .AllowSorting = AllowSortingEnum.SingleColumn
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
        End With
    End Sub
    Public Shared Sub GridStyle4(ByVal DatagridView1 As C1FlexGrid)
        With DatagridView1
            .AllowFiltering = False
            .IgnoreDiacritics = False
            .ScrollBars = ScrollBars.Both
            .ScrollOptions = ScrollFlags.None
            .ShowCellLabels = False
            .VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Custom
            .ShowThemedHeaders = ShowThemedHeadersEnum.None
            .AllowFreezing = True
            .Styles.Normal.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
            .Styles.Normal.Border.Direction = BorderDirEnum.Both
            .Styles.Normal.Border.Color = Color.Gainsboro
            .Styles.Normal.Border.Width = 1
            .Styles.Normal.TextEffect = TextEffectEnum.Flat
            .Styles.Highlight.TextEffect = TextEffectEnum.Flat

            '.Styles.Alternate.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Flat
            '.Styles.Alternate.Border.Direction = BorderDirEnum.Both
            '.Styles.Alternate.Border.Color = Color.Gainsboro
            '.Styles.Alternate.Border.Width = 1

            .Glyphs(GlyphEnum.Checked) = APCESMainForm.ImageList1.Images("checkbox.png")
            .Glyphs(GlyphEnum.Unchecked) = APCESMainForm.ImageList1.Images("checkbox_no.png")
            .Styles.Highlight.TextEffect = TextEffectEnum.Flat
            '.Styles.Alternate.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
            '.Styles.Alternate.Border.Color = Color.Silver
            '.Styles.Alternate.Border.Width = 1
            '.Styles.Alternate.BackColor = Color.WhiteSmoke
            .Styles.Highlight.BackColor = Color.DeepSkyBlue
            .Styles.Highlight.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Flat
            .Styles.Highlight.Border.Color = SystemColors.Control
            .Styles.Highlight.Border.Width = 0
            .Styles.Highlight.ForeColor = Color.White
            '.Styles.Alternate.TextEffect = TextEffectEnum.Flat
            .Styles.SelectedRowHeader.BackColor = Color.DeepSkyBlue

            .Styles.EmptyArea.BackColor = Color.White
            .Styles.EmptyArea.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
            .Styles.EmptyArea.Border.Width = 10

            .AllowSorting = AllowSortingEnum.SingleColumn
            .AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Columns
        End With
    End Sub
    Public Shared Sub ColumnVisible2(ByVal a As Boolean, ByVal DATAGRIDVIEW1 As C1FlexGrid, ByVal ButtonItem5 As DevComponents.DotNetBar.ButtonItem, ByVal c1command1 As C1.Win.C1Command.C1CommandMenu)
        With DATAGRIDVIEW1
            .Redraw = False
            Try
                Dim i As Integer = 0
                Dim j As Integer = ButtonItem5.SubItems.Count - 2
                For i = 1 To j
                    Dim x As String = Trim(ButtonItem5.SubItems(i).Text.Replace(" ", ""))
                    '  MessageBox.Show(x)
                    If a = False Then
                        c1command1.CommandLinks.Item(i - 1).Command.Checked = Convert.ToBoolean(CType(ButtonItem5.SubItems(i), DevComponents.DotNetBar.ButtonItem).Checked)
                        .Cols(x).Visible = Convert.ToBoolean(CType(ButtonItem5.SubItems(i), DevComponents.DotNetBar.ButtonItem).Checked)
                        .Cols(x).AllowEditing = False
                    Else
                        CType(ButtonItem5.SubItems(i), DevComponents.DotNetBar.ButtonItem).Checked = c1command1.CommandLinks.Item(i - 1).Command.Checked
                        .Cols(x).Visible = c1command1.CommandLinks.Item(i - 1).Command.Checked
                        .Cols(x).AllowEditing = False
                    End If
                    If .Cols(x).Visible = True Then .AutoSizeCol(DATAGRIDVIEW1.Cols(x).Index)
                Next
                .Cols(1).AllowEditing = True
            Catch ex As Exception
                '  MessageBox.Show(ex.Message)
            End Try
            .Redraw = True
        End With
    End Sub
    Public Shared Sub ColumnVisible(ByVal a As Boolean, ByVal DATAGRIDVIEW1 As C1FlexGrid, ByVal ButtonItem5 As DevComponents.DotNetBar.ButtonItem, ByVal c1command1 As C1.Win.C1Command.C1CommandMenu, ByVal col As Integer)
        With DATAGRIDVIEW1
            .Redraw = False
            Try
                Dim i As Integer = 0
                Dim j As Integer = ButtonItem5.SubItems.Count - 2
                For i = 1 To j
                    Dim x As String = Trim(ButtonItem5.SubItems(i).Text.Replace(" ", ""))
                    '  MessageBox.Show(x)
                    If a = False Then
                        c1command1.CommandLinks.Item(i - 1).Command.Checked = Convert.ToBoolean(CType(ButtonItem5.SubItems(i), DevComponents.DotNetBar.ButtonItem).Checked)
                        .Cols(x).Visible = Convert.ToBoolean(CType(ButtonItem5.SubItems(i), DevComponents.DotNetBar.ButtonItem).Checked)
                    Else
                        CType(ButtonItem5.SubItems(i), DevComponents.DotNetBar.ButtonItem).Checked = c1command1.CommandLinks.Item(i - 1).Command.Checked
                        .Cols(x).Visible = c1command1.CommandLinks.Item(i - 1).Command.Checked
                    End If
                    If .Cols(x).Visible = True Then .AutoSizeCol(DATAGRIDVIEW1.Cols(x).Index)
                Next
            Catch ex As Exception
                '  MessageBox.Show(ex.Message)
            End Try
            .Redraw = True
        End With
    End Sub
    Public Shared Sub countrowsof2(ByVal a As Integer, ByVal DataGridView1 As C1FlexGrid) ' this is for sales order formatiing
        With DataGridView1
            .Redraw = False
            Dim x As Integer = 1
            Dim y As Integer = DataGridView1.Rows.Count - 1
            For x = 1 To y
                .Item(x, 0) = a + x
                If Convert.ToBoolean(.Item(x, "Cancelled")) = True Then
                    .Rows(x).StyleNew.BackColor = Color.LavenderBlush
                    .Rows(x).StyleNew.Border.Direction = BorderDirEnum.Both
                    .Rows(x).StyleNew.Border.Width = 0
                    .Rows(x).StyleNew.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
                ElseIf Convert.ToBoolean(.Item(x, "Hold")) = True Then
                    .Rows(x).StyleNew.BackColor = Color.Honeydew
                    .Rows(x).StyleNew.Border.Direction = BorderDirEnum.Both
                    .Rows(x).StyleNew.Border.Width = 0
                    .Rows(x).StyleNew.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
                Else
                    .Rows(x).StyleDisplay.BackColor = Color.White
                End If
            Next
            .Redraw = True
        End With
    End Sub
    Public Shared Sub countrowsof3(ByVal a As Integer, ByVal DataGridView1 As C1FlexGrid)
        With DataGridView1
            .Redraw = False
            Dim x As Integer = 1
            Dim y As Integer = DataGridView1.Rows.Count - 1
            For x = 1 To y
                .Item(x, 0) = a + x
                If Convert.ToBoolean(.Item(x, "Cancelled")) = True Then
                    .Rows(x).StyleNew.BackColor = Color.LavenderBlush
                ElseIf Convert.ToBoolean(.Item(x, "Pending")) = True Then
                    .Rows(x).StyleNew.BackColor = Color.Honeydew
                Else
                    .Rows(x).StyleDisplay.BackColor = Color.White
                End If
            Next
            .Redraw = True
        End With
    End Sub
    Public Shared Sub countrowsof4(ByVal a As Integer, ByVal DataGridView1 As C1FlexGrid, ByVal a1 As Color, _
                                   ByVal a2 As Color, ByVal a3 As Color, ByVal a4 As Color) 'this is for sales booking format
        With DataGridView1
            .Redraw = False
            Dim x As Integer = 1
            Dim y As Integer = DataGridView1.Rows.Count - 1
            While x <= y
                .Item(x, 0) = a + x
                'If Convert.ToBoolean(.Item(x, "Cancelled")) = True Then
                '    .Rows(x).StyleNew.BackColor = a1
                '    .Rows(x).StyleNew.ForeColor = baketechmainform.FontColorCancelled.Color
                'ElseIf Convert.ToBoolean(.Item(x, "AcceptedTranspo")) = True Then
                '    .Rows(x).StyleNew.BackColor = baketechmainform.a7Color.Color
                '    .Rows(x).StyleNew.ForeColor = baketechmainform.FontColorReadyforSched.Color
                'ElseIf Convert.ToBoolean(.Item(x, "SentToTranspo")) = True Then
                '    .Rows(x).StyleNew.BackColor = baketechmainform.a6Color.Color
                '    .Rows(x).StyleNew.ForeColor = baketechmainform.FontColorSentToTranspo.Color
                'ElseIf Convert.ToBoolean(.Item(x, "Picked")) = True Then
                '    .Rows(x).StyleNew.ForeColor = baketechmainform.FontColorsOrdersPicked.Color
                '    .Rows(x).StyleNew.BackColor = baketechmainform.a5Color.Color
                'ElseIf Convert.ToBoolean(.Item(x, "Printed")) = True Then
                '    .Rows(x).StyleNew.BackColor = a4
                '    .Rows(x).StyleNew.ForeColor = baketechmainform.FontColorPicklistPrinted.Color

                'ElseIf Convert.ToBoolean(.Item(x, "AcceptedWH")) = True Then
                '    .Rows(x).StyleNew.ForeColor = baketechmainform.FontColorReadyToPick.Color
                '    .Rows(x).StyleNew.BackColor = a3
                'ElseIf Convert.ToBoolean(.Item(x, "Sent")) = True Then
                '    .Rows(x).StyleNew.BackColor = a2
                '    .Rows(x).StyleNew.ForeColor = baketechmainform.FontColorSentToWarehouse.Color
                'Else
                '    .Rows(x).StyleDisplay.BackColor = SystemColors.Window
                'End If
                x = x + 1
            End While
            .Redraw = True
        End With
    End Sub
    Public Shared Sub countrowsof5(ByVal a As Integer, ByVal DataGridView1 As C1FlexGrid) 'this is for sales booking format
        With DataGridView1
            .Redraw = False
            Dim x As Integer = 1
            Dim y As Integer = DataGridView1.Rows.Count - 1
            For x = 1 To y
                .Item(x, 0) = a + x
            Next
            .Redraw = True
        End With
    End Sub
    Public Shared Sub countrowsof6(ByVal a As Integer, ByVal DataGridView1 As C1FlexGrid)
        With DataGridView1
            .Redraw = False
            Dim x As Integer = 1
            Dim y As Integer = DataGridView1.Rows.Count - 1
            For x = 1 To y
                .Item(x, 0) = a + x
            Next
            .Redraw = True
        End With
    End Sub
    Public Shared Sub countrowsof7(ByVal a As Integer, ByVal DataGridView1 As C1FlexGrid) 'this for picklist main form
        With DataGridView1
            .Redraw = False
            Dim x As Integer = 1
            Dim y As Integer = DataGridView1.Rows.Count - 1
            While x <= y
                .Item(x, 0) = a + x
                If Convert.ToBoolean(.Item(x, "Cancelled")) = True Then
                    ' .Rows(x).StyleNew.BackColor = baketechmainform.a1Color.Color
                    '.Rows(x).StyleNew.ForeColor = baketechmainform.FontColorCancelled.Color
                ElseIf Convert.ToBoolean(.Item(x, "AcceptedTranspo")) = True Then
                    '.Rows(x).StyleNew.BackColor = baketechmainform.a7Color.Color
                    '.Rows(x).StyleNew.ForeColor = baketechmainform.FontColorReadyforSched.Color
                ElseIf Convert.ToBoolean(.Item(x, "SentToTranspo")) = True Then
                    '.Rows(x).StyleNew.BackColor = baketechmainform.a6Color.Color
                    '.Rows(x).StyleNew.ForeColor = baketechmainform.FontColorSentToTranspo.Color
                ElseIf Convert.ToBoolean(.Item(x, "Picked")) = True Then
                    '.Rows(x).StyleNew.BackColor = baketechmainform.a5Color.Color
                    '.Rows(x).StyleNew.ForeColor = baketechmainform.FontColorsOrdersPicked.Color
                ElseIf Convert.ToBoolean(.Item(x, "Printed")) = True Then
                    '.Rows(x).StyleNew.BackColor = baketechmainform.a4Color.Color
                    '.Rows(x).StyleNew.ForeColor = baketechmainform.FontColorPicklistPrinted.Color
                ElseIf Convert.ToBoolean(.Item(x, "AcceptedWH")) = True Then
                    '.Rows(x).StyleNew.BackColor = baketechmainform.a3Color.Color
                    '.Rows(x).StyleNew.ForeColor = baketechmainform.FontColorReadyToPick.Color
                ElseIf Convert.ToBoolean(.Item(x, "Sent")) = True Then
                    '.Rows(x).StyleNew.BackColor = baketechmainform.a2Color.Color
                    '.Rows(x).StyleNew.ForeColor = baketechmainform.FontColorSentToWarehouse.Color
                Else
                    .Rows(x).StyleDisplay.BackColor = SystemColors.Window
                End If
                x = x + 1
            End While
            .Redraw = True
        End With
    End Sub
    Public Shared Sub countrowsPickReleaseAcceptance(ByVal a As Integer, ByVal DataGridView1 As C1FlexGrid) 'this for pick release acceptance main form
        With DataGridView1
            .Redraw = False
            Dim x As Integer = 1
            Dim y As Integer = DataGridView1.Rows.Count - 1
            For x = 1 To y
                .Item(x, 0) = a + x
                If Convert.ToBoolean(.Item(x, "Cancelled")) = True Then
                    '.Rows(x).StyleNew.BackColor = baketechmainform.a1Color.Color
                ElseIf Convert.ToBoolean(.Item(x, "AcceptedTranspo")) = True Then
                    ' .Rows(x).StyleNew.BackColor = baketechmainform.a7Color.Color
                ElseIf Convert.ToBoolean(.Item(x, "SentToTranspo")) = True Then
                    ' .Rows(x).StyleNew.BackColor = baketechmainform.a6Color.Color
                    ' .Rows(x).StyleNew.Font = New Font(baketechmainform.MainFont.Text, DataGridView1.Font.Size, FontStyle.Bold)  ''''''''''''''''''''''''''''''''''''''''''''''''''
                Else
                    .Rows(x).StyleDisplay.BackColor = SystemColors.Window
                End If
            Next
            .Redraw = True
        End With
    End Sub
    Public Shared Sub countrowsof8(ByVal a As Integer, ByVal DataGridView1 As C1FlexGrid)
        With DataGridView1
            .Redraw = False
            Dim x As Integer = 1
            Dim y As Integer = DataGridView1.Rows.Count - 1
            For x = 1 To y
                .Item(x, 0) = a + x
                If Convert.ToBoolean(.Item(x, "Cancelled")) = True Then
                    ' .Rows(x).StyleNew.BackColor = baketechmainform.a1Color.Color
                ElseIf Convert.ToBoolean(.Item(x, "AcceptedTranspo")) = True Then
                    ' .Rows(x).StyleNew.BackColor = baketechmainform.a7Color.Color
                    ' .Rows(x).StyleNew.ForeColor = baketechmainform.FontColorReadyforSched.Color
                ElseIf Convert.ToBoolean(.Item(x, "SentToTranspo")) = True Then
                    '.Rows(x).StyleNew.BackColor = baketechmainform.a6Color.Color
                    ' .Rows(x).StyleNew.ForeColor = baketechmainform.FontColorSentToTranspo.Color
                ElseIf Convert.ToBoolean(.Item(x, "Picked")) = True Then
                    '.Rows(x).StyleNew.BackColor = baketechmainform.a5Color.Color
                    '.Rows(x).StyleNew.ForeColor = baketechmainform.FontColorsOrdersPicked.Color
                ElseIf Convert.ToBoolean(.Item(x, "Printed")) = True Then
                    ' .Rows(x).StyleNew.BackColor = baketechmainform.a4Color.Color
                    ' .Rows(x).StyleNew.ForeColor = baketechmainform.FontColorPicklistPrinted.Color
                ElseIf Convert.ToBoolean(.Item(x, "AcceptedWH")) = True Then
                    ' .Rows(x).StyleNew.BackColor = baketechmainform.a3Color.Color
                    '.Rows(x).StyleNew.ForeColor = baketechmainform.FontColorReadyToPick.Color
                ElseIf Convert.ToBoolean(.Item(x, "Sent")) = True Then
                    ' .Rows(x).StyleNew.BackColor = baketechmainform.a2Color.Color
                    ' .Rows(x).StyleNew.ForeColor = baketechmainform.FontColorSentToWarehouse.Color
                Else
                    .Rows(x).StyleNew.BackColor = Color.White
                End If
            Next
            .Redraw = True
        End With
    End Sub
    Public Shared Function DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs, ByVal DataGridView1 As C1FlexGrid, ByVal C1ContextMenu1 As C1ContextMenu) As Integer
        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            Dim x As Integer = DataGridView1.HitTest(e.Location.X, e.Location.Y).Row
            DataGridView1.Row = x
            Return x
        End If

    End Function
#End Region
    Public Shared Sub LoadingItemBrands(ByVal sql As String, ByVal DatagridView1 As C1FlexGrid, _
                                       ByVal nextpage As ButtonItem, ByVal movetolast As ButtonItem, _
                                       ByVal first As ButtonItem, ByVal previous As ButtonItem, _
                                       ByVal pagenumber As TextBoxItem, ByVal textbox1 As LabelItem, _
                                       ByVal labelitem9 As LabelItem)
        Try
            'Form3.C1ThemeController1.SetTheme(DatagridView1, "VS2013Light")
            'DatagridView1.Styles.Normal.BackColor = Color.White
            MainLauncher(DatagridView1, 0)
            gridgripstyle(DatagridView1)
            nextpage.Enabled = False
            previous.Enabled = False
            movetolast.Enabled = False
            first.Enabled = False
            pagenumber.Enabled = False
            ' labelitem9.Visible = False
            connect()
            con.Open()
            '   Application.DoEvents()
            Dim pagingAdapter As New MySqlDataAdapter("LoadAllData", con)
            pagingAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            pagingAdapter.SelectCommand.Parameters.AddWithValue("@StringQuery", sql)
            Dim ds As New DataSet
            pagingAdapter.Fill(ds)
            con.Close()
            DatagridView1.Redraw = False
            DatagridView1.DataSource = ds.Tables(0)
            'For i As Integer = 1 To DatagridView1.Cols.Count - 1
            '    If DatagridView1.Cols(i).Caption.ToString.ToLower.Replace(" ", "") = "customername" Or DatagridView1.Cols(i).Caption.ToString.ToLower.Replace(" ", "") = "branch/site" Or DatagridView1.Cols(i).Caption.ToString.ToLower.Replace(" ", "") = "parentname" Or DatagridView1.Cols(i).Caption.ToString.ToLower.Replace(" ", "") = "parent" Then
            '        DatagridView1.Cols(i).Width = 300
            '    End If
            'Next
            For i As Integer = 1 To DatagridView1.Rows.Count - 1
                With DatagridView1.Rows(i)
                    .Item(0) = i
                End With
            Next
            Dim totalrecords As Integer = 0
            totalrecords = ds.Tables(0).Rows.Count
            textbox1.Text = "Displaying " & totalrecords.ToString("n0") & " of " & totalrecords.ToString("n0") & " record(s)"
            '  textbox1.ForeColor = Color.Black
            'textbox1.Image = Nothing
            DatagridView1.Redraw = True
            'DatagridView1.Cols(0).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MainLauncher(DatagridView1, 1)
        End Try
    End Sub

    Public Shared Sub ColumnVisible(ByVal a As C1.Win.C1FlexGrid.C1FlexGrid, ByVal b As DevComponents.DotNetBar.ButtonItem)
        With a
            .Redraw = False
            Try
                Dim i As Integer = 0
                Dim j As Integer = b.SubItems.Count - 2
                For i = 1 To j
                    Dim x As String = Trim(b.SubItems(i).Text).Replace(" ", "")
                    .Cols(x).Visible = Convert.ToBoolean(CType(b.SubItems(i), DevComponents.DotNetBar.ButtonItem).Checked)
                    If .Cols(x).Visible = True Then .AutoSizeCol(.Cols(x).Index)
                Next
                .AutoSizeCol(.Cols("Active").Index)
            Catch ex As Exception
            End Try
            .Redraw = True
        End With
    End Sub
    Public Shared Sub TimerTick(ByVal a As C1FlexGrid, ByVal b As DevComponents.DotNetBar.SliderItem)
        Try
            If b.Value = 0 Then b.Value = 1
            a.Rows(0).StyleDisplay.Font = New Font("Arial", b.Value + 1, FontStyle.Bold)
            a.Font = New Font(APCESMainForm.RibbonFontComboBox1.Text, b.Value)
            a.Styles.Highlight.Font = New Font(APCESMainForm.RibbonFontComboBox1.Text, b.Value)
            b.Text = Format(((b.Value / 8) * 100), "n0") & "%"
            b.Tooltip = b.Text
            For Each x In a.Cols
                If x.Visible = True Then
                    a.AutoSizeCol(x.Index)
                End If
            Next
        Catch ex As Exception
        Finally
            MainLauncher(a, 1)
        End Try
    End Sub


    Public Shared Sub exporttoexcel(ByVal a As DataTable, ByVal b As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            Dim saveFileDialog1 As New SaveFileDialog
            saveFileDialog1.Filter = "Excel File|*.xls"
            saveFileDialog1.Title = "Save an Excel File"
            saveFileDialog1.ShowDialog()
            Dim strFileName As String = saveFileDialog1.FileName
            If strFileName = "" Then
            ElseIf saveFileDialog1.CheckFileExists = True Then
                File.Delete(strFileName)
                GoTo hehe
            Else
hehe:
                b.SaveExcel(strFileName, C1.Win.C1FlexGrid.FileFlags.VisibleOnly)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub loadingvaluestoComboBoxes(ByVal sql As String, ByVal a As DevComponents.DotNetBar.Controls.ComboBoxEx, ByVal displaymem As String, ByVal valuemem As String)
        Try
            Dim PagingAdapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            PagingAdapter = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            PagingAdapter.Fill(ds)
            con.Close()
            With a
                .DataSource = ds.Tables(0)
                .DisplayMember = displaymem.ToString
                .ValueMember = valuemem.ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub loadingvaluestoComboBoxes(ByVal sql As String, ByVal a As DevComponents.DotNetBar.Controls.ComboTree, ByVal displaymem As String, ByVal valuemem As String)
        Try
            Dim PagingAdapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            PagingAdapter = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            PagingAdapter.Fill(ds)
            con.Close()
            With a
                .DataSource = ds.Tables(0)
                .DisplayMembers = displaymem.ToString
                .ValueMember = valuemem.ToString
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub loadingvaluestoComboBoxes(ByVal sql As String, ByVal a As C1.Win.C1List.C1Combo, ByVal displaymem As String, ByVal valuemem As String)
        Try
            Dim PagingAdapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            PagingAdapter = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            PagingAdapter.Fill(ds)
            con.Close()
            With a
                .DataSource = ds.Tables(0)
                .DisplayMember = displaymem.ToString
                .ValueMember = valuemem.ToString
                .ColumnWidth = 0
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub loadingvaluestoComboBoxes(ByVal sql As String, ByVal a As ComboBox, ByVal displaymem As String, ByVal valuemem As String)
        Try
            Dim PagingAdapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            PagingAdapter = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            PagingAdapter.Fill(ds)
            con.Close()
            With a
                .DataSource = ds.Tables(0)
                .DisplayMember = displaymem
                .ValueMember = valuemem
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub loadingvaluestolistbox(ByVal sql As String, ByVal a As ListBox, ByVal displaymem As String, ByVal valuemem As String)
        Try
            Dim PagingAdapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            PagingAdapter = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            PagingAdapter.Fill(ds)
            con.Close()
            With a
                .DataSource = ds.Tables(0)
                .DisplayMember = displaymem
                .ValueMember = valuemem
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub loadingvaluestoComboBoxes(ByVal sql As String, ByVal a As ComboBox, ByVal displaymem As String, ByVal valuemem As String, ByVal x As Integer)
        Try
            Dim PagingAdapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            PagingAdapter = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            PagingAdapter.Fill(ds)
            con.Close()
            With a
                .DataSource = ds.Tables(0)
                .DisplayMember = displaymem
                .ValueMember = valuemem
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub loadingvaluestoComboBoxes(ByVal sql As String, ByVal a As C1.Win.C1InputPanel.InputComboBox, ByVal displaymem As String, ByVal valuemem As String)
        Try
            Dim PagAdapter As New MySqlDataAdapter
            Dim PagDS As New DataSet
            connect()
            con.Open()
            PagAdapter = New MySqlDataAdapter("LoadAllData", con)
            PagAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            PagAdapter.SelectCommand.Parameters.AddWithValue("@StringQuery", sql)
            PagDS = New DataSet
            PagAdapter.Fill(PagDS)
            con.Close()
            With a
                .Items.Clear()
                .DataSource = PagDS.Tables(0)
                .DisplayMember = displaymem.ToString
                .ValueMember = valuemem.ToString
                .SelectedIndex = -1
                If .Items.Count < 2 Then .GripHandleVisible = False Else .GripHandleVisible = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#Region "Page Navigations"
    Public Shared Function gotoFirst(ByVal scrollval As Integer, ByVal previous As ButtonItem, ByVal nextPage As ButtonItem, _
                         ByVal first As ButtonItem, ByVal last As ButtonItem, _
                         ByVal pagingds As DataSet, ByVal totalrecords As Integer, _
                         ByVal pagenumber As TextBoxItem, ByVal pagingadapter As MySqlDataAdapter, _
                         ByVal DataGridView1 As C1FlexGrid, ByVal TextBox1 As LabelItem, ByVal b As Boolean) As Integer
        'MainLauncher(0)
        scrollval = 0
        If scrollval <= 0 Then
            scrollval = 0 : previous.Enabled = False : first.Enabled = False
        End If
        If totalrecords <= MaximumToDisplay Then
            nextPage.Enabled = False : last.Enabled = False
        Else
            nextPage.Enabled = True : last.Enabled = True
        End If
        pagingds.Clear()
        pagingadapter.Fill(pagingds, scrollval, MaximumToDisplay, "towns")
        countrow(scrollval, previous, nextPage, first, last, pagingds, totalrecords, pagenumber, pagingadapter, DataGridView1, TextBox1, b)
        pagenumber.Text = Val(scrollval / MaximumToDisplay) + 1
        ' MainLauncher(1)
        Return scrollval
    End Function
    Public Shared Sub ClearPanel(ByVal BasicSearchOption As C1.Win.C1InputPanel.C1InputPanel)
        Dim haha As New C1.Win.C1InputPanel.InputComboBox
        Dim xd As New C1.Win.C1InputPanel.InputTextBox
        Dim yz As New C1.Win.C1InputPanel.InputDatePicker
        Dim xdd As New C1.Win.C1InputPanel.InputCheckBox
        Dim xdd1 As New C1.Win.C1InputPanel.InputRadioButton
        Dim num As New C1.Win.C1InputPanel.InputNumericBox
        For x As Integer = 1 To BasicSearchOption.Items.Count - 1
            If haha.GetType.Equals(BasicSearchOption.Items(x).GetType()) = True Then
                CType(BasicSearchOption.Items(x), C1.Win.C1InputPanel.InputComboBox).SelectedIndex = -1
            ElseIf xd.GetType.Equals(BasicSearchOption.Items(x).GetType()) = True Then
                CType(BasicSearchOption.Items(x), C1.Win.C1InputPanel.InputTextBox).Text = vbNullString
            ElseIf yz.GetType.Equals(BasicSearchOption.Items(x).GetType()) = True Then
                CType(BasicSearchOption.Items(x), C1.Win.C1InputPanel.InputDatePicker).Text = vbNullString
            ElseIf xdd.GetType.Equals(BasicSearchOption.Items(x).GetType()) = True Then
                CType(BasicSearchOption.Items(x), C1.Win.C1InputPanel.InputCheckBox).CheckState = CheckState.Indeterminate
            ElseIf xdd1.GetType.Equals(BasicSearchOption.Items(x).GetType()) = True Then
                If CType(BasicSearchOption.Items(x), C1.Win.C1InputPanel.InputRadioButton).Text.Replace("&", "") = "Both" Then
                    CType(BasicSearchOption.Items(x), C1.Win.C1InputPanel.InputRadioButton).Checked = True
                Else
                    CType(BasicSearchOption.Items(x), C1.Win.C1InputPanel.InputRadioButton).Checked = False
                End If
            ElseIf num.GetType.Equals(BasicSearchOption.Items(x).GetType()) = True Then
                CType(BasicSearchOption.Items(x), C1.Win.C1InputPanel.InputNumericBox).Value = 0
            End If

        Next
    End Sub
    Public Shared Function PreviousPageClick(ByVal scrollval As Integer, ByVal previous As ButtonItem, ByVal nextPage As ButtonItem, _
                         ByVal first As ButtonItem, ByVal last As ButtonItem, _
                         ByVal pagingds As DataSet, ByVal totalrecords As Integer, _
                         ByVal pagenumber As TextBoxItem, ByVal pagingadapter As MySqlDataAdapter, _
                         ByVal DataGridView1 As C1FlexGrid, ByVal TextBox1 As LabelItem, ByVal b As Boolean) As Integer
        MainLauncher(0)
        If previous.Enabled = False Then Return scrollval : Exit Function
        scrollval = scrollval - MaximumToDisplay
        If scrollval <= 0 Then
            scrollval = 0
            previous.Enabled = False
            first.Enabled = False
        Else
            first.Enabled = True
            previous.Enabled = True
        End If
        nextPage.Enabled = True
        last.Enabled = True
        pagingds.Clear()
        pagingadapter.Fill(pagingds, scrollval, MaximumToDisplay, "towns")
        countrow(scrollval, previous, nextPage, first, last, pagingds, totalrecords, pagenumber, pagingadapter, DataGridView1, TextBox1, b)
        pagenumber.Text = Val(scrollval / MaximumToDisplay) + 1
        MainLauncher(1)
        Return scrollval
    End Function
    Public Shared Function NavigatePageType(ByVal scrollval As Integer, ByVal previous As ButtonItem, ByVal nextPage As ButtonItem, _
                         ByVal first As ButtonItem, ByVal last As ButtonItem, _
                         ByVal pagingds As DataSet, ByVal totalrecords As Integer, _
                         ByVal pagenumber As TextBoxItem, ByVal pagingadapter As MySqlDataAdapter, _
                         ByVal DataGridView1 As C1FlexGrid, ByVal TextBox1 As LabelItem, ByVal b As Boolean) As Integer
        If Not IsNumeric(pagenumber.Text) Then
            Return scrollval : Exit Function
        ElseIf Val(pagenumber.Text) = 0 Then
            Return scrollval : Exit Function
        Else
            Dim i As Integer = (Math.Ceiling(totalrecords / MaximumToDisplay)) + 1
            If Val(pagenumber.Text) >= i Then
                MessageBox.Show("No page to display.") : pagenumber.Text = (scrollval / MaximumToDisplay) + 1 : Return scrollval : Exit Function
            ElseIf pagenumber.Text = "1" Then
                gotoFirst(scrollval, previous, nextPage, first, last, pagingds, totalrecords, pagenumber, pagingadapter, DataGridView1, TextBox1, b)
            Else
                If Val(pagenumber.Text) = Val(i) - 1 Then
                    last.Enabled = False : nextPage.Enabled = False : first.Enabled = True : previous.Enabled = True
                Else
                    previous.Enabled = True : first.Enabled = True : last.Enabled = True : nextPage.Enabled = True
                End If
            End If
        End If
        Try
            scrollval = (pagenumber.Text * MaximumToDisplay) - MaximumToDisplay
            pagingds.Clear()
            pagingadapter.Fill(pagingds, scrollval, MaximumToDisplay, "towns")
            countrow(scrollval, previous, nextPage, first, last, pagingds, totalrecords, pagenumber, pagingadapter, DataGridView1, TextBox1, b)
            pagenumber.Text = Val(scrollval / MaximumToDisplay) + 1
        Catch ex As Exception
        End Try
        Return scrollval
    End Function
    Public Shared Function LastPageClick(ByVal scrollval As Integer, ByVal previous As ButtonItem, ByVal nextPage As ButtonItem, _
                         ByVal first As ButtonItem, ByVal last As ButtonItem, _
                         ByVal pagingds As DataSet, ByVal totalrecords As Integer, _
                         ByVal pagenumber As TextBoxItem, ByVal pagingadapter As MySqlDataAdapter, _
                         ByVal DataGridView1 As C1FlexGrid, ByVal TextBox1 As LabelItem, ByVal b As Boolean) As Integer
        Try
            MainLauncher(0)
            If last.Enabled = False Then Return scrollval : Exit Function
            Dim i As Integer = (Math.Floor(totalrecords / MaximumToDisplay)) + 1
            scrollval = (i * MaximumToDisplay) - MaximumToDisplay
            pagenumber.Text = i
            pagingds.Clear()
            pagingadapter.Fill(pagingds, scrollval, MaximumToDisplay, "towns")
            countrow(scrollval, previous, nextPage, first, last, pagingds, totalrecords, pagenumber, pagingadapter, DataGridView1, TextBox1, b)
            nextPage.Enabled = False
            last.Enabled = False
            previous.Enabled = True
            first.Enabled = True
        Catch ex As Exception
        Finally
            MainLauncher(1)
        End Try
        Return scrollval
    End Function
    Public Shared Function NextPageClick(ByVal scrollval As Integer, ByVal previous As ButtonItem, ByVal nextPage As ButtonItem, _
                         ByVal first As ButtonItem, ByVal last As ButtonItem, _
                         ByVal pagingds As DataSet, ByVal totalrecords As Integer, _
                         ByVal pagenumber As TextBoxItem, ByVal pagingadapter As MySqlDataAdapter, _
                         ByVal DataGridView1 As C1FlexGrid, ByVal TextBox1 As LabelItem, ByVal b As Boolean) As Integer
        Try
            MainLauncher(0)
            If nextPage.Enabled = False Then Return scrollval : Exit Function
            scrollval = scrollval + MaximumToDisplay
            pagingds.Clear()
            pagingadapter.Fill(pagingds, scrollval, MaximumToDisplay, "towns")
            countrow(scrollval, previous, nextPage, first, last, pagingds, totalrecords, pagenumber, pagingadapter, DataGridView1, TextBox1, b)
            first.Enabled = True : previous.Enabled = True
            pagenumber.Text = Val(scrollval / MaximumToDisplay) + 1
            If scrollval >= totalrecords - MaximumToDisplay Then
                nextPage.Enabled = False : last.Enabled = False
                Return scrollval
                Exit Function
            Else
                previous.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MainLauncher(1)
        End Try
        Return scrollval
    End Function
    Public Shared Function countrow(ByVal scrollval As Integer, ByVal previous As ButtonItem, ByVal nextPage As ButtonItem, _
                         ByVal first As ButtonItem, ByVal last As ButtonItem, _
                         ByVal pagingds As DataSet, ByVal totalrecords As Integer, _
                         ByVal pagenumber As TextBoxItem, _
                         ByVal pagingadapter As MySqlDataAdapter, _
                         ByVal DataGridView1 As C1FlexGrid, _
                         ByVal Textbox1 As LabelItem, _
                         ByVal IfPerFormStyle As Boolean) As Integer
        Try
            Dim x As Integer = scrollval
            If x + MaximumToDisplay > totalrecords Then
                x = x + DataGridView1.Rows.Count - 1
            Else
                x = x + MaximumToDisplay
            End If
            Textbox1.Text = "Displaying " & Format(x, "N0") & " of " & Format(totalrecords, "N0") & " records"
        Catch ex As Exception
            Textbox1.Text = "Displaying 0 of 0 records"
            first.Enabled = False
            last.Enabled = False
            nextPage.Enabled = False
            previous.Enabled = False
        End Try
        Return scrollval
    End Function
    Public Shared Sub countrowsof(ByVal a As Integer, ByVal DataGridView1 As C1FlexGrid)
        Try
            Dim x As Integer = 1
            Dim y As Integer = DataGridView1.Rows.Count - 1
            With DataGridView1
                For x = 1 To y
                    DataGridView1.Item(x, 0) = a + x
                    If Convert.ToBoolean(.Item(x, "Active")) = False Then
                        .Rows(x).StyleNew.BackColor = Color.LavenderBlush
                        .Rows(x).StyleNew.Border.Direction = BorderDirEnum.Both
                        .Rows(x).StyleNew.Border.Width = 0
                        .Rows(x).StyleNew.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
                    Else
                        .Rows(x).StyleDisplay.BackColor = SystemColors.Window
                    End If
                Next
            End With
        Catch ex As Exception
        End Try

    End Sub
    Public Shared Sub countrowsofDeliveryTripTicket(ByVal a As Integer, ByVal DataGridView1 As C1FlexGrid)
        Try
            Dim x As Integer = 1
            Dim y As Integer = DataGridView1.Rows.Count - 1
            With DataGridView1
                For x = 1 To y
                    DataGridView1.Item(x, 0) = a + x
                Next
            End With
        Catch ex As Exception
        End Try

    End Sub
    Public Shared Sub countrowsofRowCountOnly(ByVal a As Integer, ByVal DataGridView1 As C1FlexGrid)
        Dim x As Integer = 1
        Dim y As Integer = DataGridView1.Rows.Count - 1
        With DataGridView1
            For x = 1 To y
                DataGridView1.Item(x, 0) = a + x
            Next
        End With
    End Sub
    Public Shared Sub loadingbookedqty(ByVal sql As String, ByVal c1flexgrid1 As C1.Win.C1FlexGrid.C1FlexGrid, ByVal sliderzoombutton As DevComponents.DotNetBar.SliderItem)
        Try
            MainLauncher2(c1flexgrid1, 0)
            Dim BookDs As New DataSet
            Dim BookAdapter As New MySqlDataAdapter
            connect()
            con.Open()
            BookAdapter = New MySqlDataAdapter(sql, con)
            BookAdapter.Fill(BookDs)
            con.Close()
            With c1flexgrid1
                .DataSource = BookDs.Tables(0)
                If .Tag = "hahaha" Then
                    .Cols("AcceptedQty(T)").TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("BookedQty(S)").Format = "n0"
                    .Cols("OrderedQty").Format = "n0"
                    .Cols("AcceptedQty(T)").Format = "n0"
                    .Cols("BookedQty(S)").TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("OrderedQty").TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("BookedQty(S)").TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("PickedQty(WH)").TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("OrderedQty").TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("OrderedQty").Caption = "Ordered"
                    .Cols("BookedQty(S)").Caption = "Booked"
                    .Cols("PickedQty(WH)").Caption = "Picked"
                    .Cols("AcceptedQty(T)").Caption = "Released"

                ElseIf .Tag = "angel" Then
                    '  LockCell(c1flexgrid1)
                    .Cols("AcceptedQty(T)").StyleDisplay.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("BookedQty(S)").StyleDisplay.Format = "n0"
                    .Cols("BookedQty(S)").Visible = False
                    .Cols("AcceptedQty(T)").Visible = False
                    .Cols("BookedQty(S)").StyleDisplay.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("BookedQty(S)").TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("PickedQty(WH)").TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("PickedQty(WH)").Caption = "Quantity"
                    .Cols("TotalWt(kgs)").TextAlign = TextAlignEnum.RightCenter
                    .Cols("TotalWt(kgs)").StyleDisplay.Format = "n2"
                    .Cols("Column1").Caption = ""
                    .Cols("PickReleasedOrderID").Visible = False
                    .Cols("OrderedQty").Caption = "Ordered"
                    .Cols("BookedQty(S)").Caption = "Booked"
                    .Cols("PickedQty(WH)").Caption = "Picked"
                    .Cols("AcceptedQty(T)").Caption = "Released"
                ElseIf .Tag = "jhanjhan" Then
                    .Cols("col").Caption = ""
                    .Cols("Quantity").Format = "N0"
                    .Cols("Quantity").TextAlign = TextAlignEnum.CenterCenter
                ElseIf .Tag = "tan" Then
                    .Cols("col").Caption = ""
                    .Cols("Quantity").Format = "N0"
                    .Cols("Quantity").TextAlign = TextAlignEnum.CenterCenter
                    .Cols("StockInQty").Format = "N0"
                    .Cols("StockInQty").TextAlign = TextAlignEnum.CenterCenter
                Else
                    .Cols("BookedQty").StyleDisplay.Format = "n0"
                    .Cols("SoQty").StyleDisplay.Format = "n0"
                    .Cols("SoQty").Caption = "OrderedQty"
                    '   .Cols("Warehouse").TextAlign = TextAlignEnum.LeftCenter
                    '   .Cols("OnHand").Format = "n0"
                    '   .Cols("Onhand").TextAlign = TextAlignEnum.RightCenter
                    ' .Cols("OnHand").TextAlignFixed = TextAlignEnum.RightCenter
                    .Cols("BookedQty").StyleDisplay.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("SOQty").StyleDisplay.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("BookedQty").TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("PickedQty").TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                    .Cols("SOQty").TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter
                End If
                ZOomFlex(c1flexgrid1, sliderzoombutton)
                countFlexRow(c1flexgrid1)
                .AutoSizeCols()
            End With
        Catch ex As Exception
            '       MessageBox.Show(ex.Message)
        Finally
            MainLauncher2(c1flexgrid1, 1)
        End Try
    End Sub
    Public Shared Sub LockCell(ByVal datagridview As C1FlexGrid)
        With datagridview
            Dim x As CellStyle = datagridview.Styles.Add("locked")
            Dim y As CellStyle = datagridview.Styles.Add("news")
            .Glyphs(GlyphEnum.Checked) = APCESMainForm.ImageList1.Images("checkbox.png")
            .Glyphs(GlyphEnum.Unchecked) = APCESMainForm.ImageList1.Images("checkbox_no.png")

            .Styles.Normal.BackColor = .Styles.EmptyArea.BackColor
            .Styles.Alternate.BackColor = .Styles.EmptyArea.BackColor
            x.BackColor = .Styles.Normal.BackColor
            x.Border.Direction = BorderDirEnum.Horizontal
            x.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Inset
            x.Border.Color = SystemColors.Control

            y.BackColor = .Styles.Normal.BackColor
            y.Border.Direction = BorderDirEnum.Both
            y.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Dotted
            y.Border.Color = SystemColors.Control
            .Styles.SelectedColumnHeader.BackColor = .Styles.Normal.BackColor
            .Styles.SelectedColumnHeader.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Flat
            .Styles.SelectedColumnHeader.BackColor = Color.White
            .Styles.SelectedRowHeader.BackColor = Color.Gold
            .Styles.Highlight.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.None
            .Styles.Normal.Trimming = StringTrimming.None
            With .Styles.EmptyArea
                .Border.Direction = BorderDirEnum.Horizontal
                .Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Inset
                .Border.Color = SystemColors.Control
            End With
            .Cols(0).Style = y
            .Rows(0).Style = x
        End With
    End Sub
    Public Shared Sub ZOomFlex(ByVal c1flexgrid1 As C1.Win.C1FlexGrid.C1FlexGrid, ByVal sliderzoombutton As DevComponents.DotNetBar.SliderItem)
        Try
            If sliderzoombutton.Value = 0 Then sliderzoombutton.Value = 1
            With c1flexgrid1
                .Font = New Font(APCESMainForm.RibbonFontComboBox1.Text, sliderzoombutton.Value, FontStyle.Regular)
                .Rows(0).StyleDisplay.Font = New Font("Arial", sliderzoombutton.Value + 1, FontStyle.Bold)
                .AutoSizeCols()
            End With
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Sub countFlexRow(ByVal c1flexgrid1 As C1.Win.C1FlexGrid.C1FlexGrid)
        Dim a As Integer = 1
        Dim b As Integer = c1flexgrid1.Rows.Count - 1
        For a = 1 To b
            With c1flexgrid1
                .Item(a, 0) = a
            End With
        Next
    End Sub
    Public Shared Sub DatagridAfterSelect(ByVal datagridview1 As C1.Win.C1FlexGrid.C1FlexGrid, _
                                          ByVal c1flexgrid1 As C1.Win.C1FlexGrid.C1FlexGrid, _
                                          ByVal sliderzoombutton As DevComponents.DotNetBar.SliderItem, _
                                          ByVal SOReferenceLabel As Label, _
                                          ByVal SBReferenceLabel As Label, _
                                          ByVal DeliverToLabel As Label, _
                                          ByVal POCancellationLabel As Label, _
                                          ByVal OrderDatelabel As Label, _
                                          ByVal DeliveryDateLabel As Label, _
                                          ByVal statuslabel As Label, _
                                          ByVal bookcountlabel As Label)
        Try
            Dim a As Integer = 0
            Try
                datagridview1.Rows(1).Selected = False
                a = datagridview1.Rows(datagridview1.RowSel).Item("SalesBookingID")
            Catch ex As Exception
                a = 0
            End Try
            FunctionClass.loadingbookedqty("SELECT  b.Quantity as SOQty, c.BookedQty, (Select PickedQty from PicklistOrders where OrderID=b.OrderID AND " & _
                                            " SalesBookingRequestID=c.SalesBookingRequestID) as PickedQty, b.UOM,a.ItemCode,  a.ItemName, c.AdditionalDetails   from SalesOrderOrders b, " & _
                                            " Items a, SalesBookingQtyRequested c where a.ItemID=b.ItemID and c.OrderID = b.OrderID  AND c.SalesBookingID ='" & a & _
                                            "' order by ItemName", c1flexgrid1, sliderzoombutton)
            With datagridview1.Rows(datagridview1.RowSel)
                SOReferenceLabel.Text = .Item("SOReference")
                SBReferenceLabel.Text = .Item("SBReference")
                DeliverToLabel.Text = .Item("DeliverTo")
                POCancellationLabel.Text = .Item("POCancellation")
                OrderDatelabel.Text = .Item("DateOrdered")
                DeliveryDateLabel.Text = .Item("DeliveryDate")
                statuslabel.Text = .Item("Status")
                bookcountlabel.Text = .Item("BookCount")
            End With
        Catch ex As Exception
            '  MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Shared Sub DatagridAfterSelect2(ByVal datagridview1 As C1.Win.C1FlexGrid.C1FlexGrid, _
                                         ByVal c1flexgrid1 As C1.Win.C1FlexGrid.C1FlexGrid, _
                                         ByVal sliderzoombutton As DevComponents.DotNetBar.SliderItem, _
                                         ByVal SOReferenceLabel As Label, _
                                         ByVal SBReferenceLabel As Label, _
                                         ByVal DeliverToLabel As Label, _
                                         ByVal POCancellationLabel As Label, _
                                         ByVal OrderDatelabel As Label, _
                                         ByVal DeliveryDateLabel As Label, _
                                         ByVal statuslabel As Label, _
                                         ByVal bookcountlabel As Label)
        Try
            Dim a As Integer = 0
            Dim b As Integer = 0
            Try
                datagridview1.Rows(1).Selected = False
                a = datagridview1.Rows(datagridview1.RowSel).Item("SalesBookingID")
            Catch ex As Exception
                a = 0
            End Try
            FunctionClass.loadingbookedqty("SELECT  b.Quantity as SOQty, c.BookedQty, (Select PickedQty from PicklistOrders where OrderID=b.OrderID AND " & _
                                            " SalesBookingRequestID=c.SalesBookingRequestID LIMIT 1) as PickedQty, b.UOM,a.ItemCode,  a.ItemName  from SalesOrderOrders b, " & _
                                            " Items a, SalesBookingQtyRequested c where a.ItemID=b.ItemID and c.OrderID = b.OrderID  AND c.SalesBookingID ='" & a & _
                                 "' order by ItemName", c1flexgrid1, sliderzoombutton)

            With datagridview1.Rows(datagridview1.RowSel)
                SOReferenceLabel.Text = .Item("SOReference")
                SBReferenceLabel.Text = .Item("SBReference")
                DeliverToLabel.Text = .Item("DeliverTo")
                POCancellationLabel.Text = .Item("POCancellation")
                OrderDatelabel.Text = .Item("DateOrdered")
                DeliveryDateLabel.Text = .Item("DeliveryDate")
                statuslabel.Text = .Item("BookingStatus")
                bookcountlabel.Text = .Item("BookCount")
            End With
        Catch ex As Exception
        End Try
    End Sub
    Public Shared Sub DatagridAfterSelect3(ByVal datagridview1 As C1.Win.C1FlexGrid.C1FlexGrid, _
                                         ByVal c1flexgrid1 As C1.Win.C1FlexGrid.C1FlexGrid, _
                                         ByVal sliderzoombutton As DevComponents.DotNetBar.SliderItem, _
                                         ByVal SOReferenceLabel As Label, _
                                         ByVal SBReferenceLabel As Label, _
                                         ByVal DeliverToLabel As Label, _
                                         ByVal POCancellationLabel As Label, _
                                         ByVal OrderDatelabel As Label, _
                                         ByVal DeliveryDateLabel As Label, _
                                         ByVal statuslabel As Label, _
                                         ByVal bookcountlabel As Label)

    End Sub
    Public Shared Sub DeliveryTripTicketAfterSelect(ByVal datagridview1 As C1.Win.C1FlexGrid.C1FlexGrid, ByVal sliderZoomButton As SliderItem, ByVal c1flexgrid As C1FlexGrid, ByVal TripTicketId As Integer)
        Try
            Dim a As Integer = 0
            Try
                a = datagridview1.Rows(datagridview1.RowSel).Item("PickReleaseID")
            Catch ex As Exception
                a = 0
            End Try
            FunctionClass.loadingbookedqty("SELECT c.PickReleasedOrderID, (Select BookedQty from SalesBookingQtyRequested where SalesBookingRequestID=c.SalesBookingRequestID) as 'BookedQty(S)', " & _
                                            " (Select PickedQty from PicklistOrders where OrderID=b.OrderID AND " & _
                                            " SalesBookingRequestID=c.SalesBookingRequestID) as 'PickedQty(WH)', c.AcceptedQty as 'AcceptedQty(T)',  b.UOM,a.ItemCode,  a.ItemName, (a.TheoWt *c.AcceptedQty) as 'TotalWt(kgs)' , ' '  from SalesOrderOrders b, " & _
                                            " Items a, PickReleasedOrders c where a.ItemID=b.ItemID and c.OrderID = b.OrderID  AND c.PickReleaseID ='" & a & _
                                            "' AND c.PickReleasedOrderID IN (SELECT PickreleasedOrderID from TripTicketItems Where tripTicketId=" & _
                                            TripTicketId & ") order by ItemName", c1flexgrid, sliderZoomButton)
        Catch ex As Exception
            FunctionClass.loadingbookedqty("SELECT c.PickReleasedOrderID, (Select BookedQty from SalesBookingQtyRequested where SalesBookingRequestID=c.SalesBookingRequestID) as 'BookedQty(S)', " & _
                                            " (Select PickedQty from PicklistOrders where OrderID=b.OrderID AND " & _
                                            " SalesBookingRequestID=c.SalesBookingRequestID) as 'PickedQty(WH)', c.AcceptedQty as 'AcceptedQty(T)',  b.UOM,a.ItemCode,  a.ItemName, (a.TheoWt *c.AcceptedQty) as 'TotalWt(kgs)' , ' '  from SalesOrderOrders b, " & _
                                            " Items a, PickReleasedOrders c where a.ItemID=b.ItemID and c.OrderID = b.OrderID  AND c.PickReleaseID ='0' order by ItemName", c1flexgrid, sliderZoomButton)
        End Try
    End Sub
    Public Shared Sub loadtoGrid(ByVal sql As String, ByVal b As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            MainLauncher(0)
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            adapter = New MySqlDataAdapter(sql, con)
            ds = New DataSet
            adapter.Fill(ds)
            con.Close()
            con.Dispose()
            With b
                .Redraw = False
                .Rows.Count = ds.Tables(0).Rows.Count + 1
                .Cols.Count = ds.Tables(0).Columns.Count + 2
                Dim dr As DataRow, dc As DataColumn
                Dim rowIndex%, colIndex%
                rowIndex = 1
                For Each dr In ds.Tables(0).Rows
                    colIndex = 1
                    b(rowIndex, 0) = rowIndex
                    For Each dc In ds.Tables(0).Columns
                        b(rowIndex, colIndex) = dr(dc)
                        colIndex = colIndex + 1
                    Next
                    .Rows(rowIndex).Clear(ClearFlags.Style)
                    rowIndex = rowIndex + 1
                Next
                b.AutoSizeCols()
                .Redraw = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            'command.Dispose()
            con.Close()
            MainLauncher(1)
        End Try
    End Sub
    Public Shared Sub loadtoGrid2(ByVal sql As String, ByVal b As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            MainLauncher(0)
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            adapter = New MySqlDataAdapter("LoadAllData", con)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            adapter.SelectCommand.Parameters.AddWithValue("@StringQuery", sql)
            adapter.SelectCommand.CommandTimeout = 50000
            ds = New DataSet
            adapter.Fill(ds)
            con.Close()
            con.Dispose()
            With b
                .Redraw = False
                .Rows.Count = ds.Tables(0).Rows.Count + 1
                .Cols.Count = ds.Tables(0).Columns.Count + 2
                Dim dr As DataRow, dc As DataColumn
                Dim rowIndex%, colIndex%
                rowIndex = 1
                For Each dr In ds.Tables(0).Rows
                    colIndex = 1
                    b(rowIndex, 0) = rowIndex
                    For Each dc In ds.Tables(0).Columns
                        b(rowIndex, colIndex) = dr(dc)
                        colIndex = colIndex + 1
                    Next
                    .Rows(rowIndex).Clear(ClearFlags.Style)
                    rowIndex = rowIndex + 1
                Next
                b.AutoSizeCols()
                .Redraw = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            command.Dispose()
            con.Close()
            MainLauncher(1)
        End Try
    End Sub
    Public Shared Sub loadtoGrid_2Parameters(ByVal sql As String, ByVal OrderQuery As String, ByVal FilterQuery As String, ByVal b As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            MainLauncher(0)
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            adapter = New MySqlDataAdapter(sql, con)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            adapter.SelectCommand.Parameters.AddWithValue("@FilterQuery", FilterQuery)
            adapter.SelectCommand.Parameters.AddWithValue("@OrderQuery", OrderQuery)
            adapter.SelectCommand.CommandTimeout = 50000
            ds = New DataSet
            adapter.Fill(ds)
            con.Close()
            con.Dispose()
            With b
                .Redraw = False
                .Rows.Count = ds.Tables(0).Rows.Count + 1
                .Cols.Count = ds.Tables(0).Columns.Count + 2
                Dim dr As DataRow, dc As DataColumn
                Dim rowIndex%, colIndex%
                rowIndex = 1
                For Each dr In ds.Tables(0).Rows
                    colIndex = 1
                    b(rowIndex, 0) = rowIndex
                    For Each dc In ds.Tables(0).Columns
                        b(rowIndex, colIndex) = dr(dc)
                        colIndex = colIndex + 1
                    Next
                    .Rows(rowIndex).Clear(ClearFlags.Style)
                    rowIndex = rowIndex + 1
                Next
                b.AutoSizeCols()
                .Redraw = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            command.Dispose()
            con.Close()
            MainLauncher(1)
        End Try
    End Sub
    
    Public Shared Sub loadtoGrid3(ByVal sql As String, ByVal id As Integer, ByVal b As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            MainLauncher(0)
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            adapter = New MySqlDataAdapter(sql, con)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            adapter.SelectCommand.Parameters.AddWithValue("@ID", id)
            adapter.SelectCommand.CommandTimeout = 50000
            ds = New DataSet
            adapter.Fill(ds)
            con.Close()
            con.Dispose()
            With b
                .Redraw = False
                .Rows.Count = ds.Tables(0).Rows.Count + 1
                .Cols.Count = ds.Tables(0).Columns.Count + 2
                Dim dr As DataRow, dc As DataColumn
                Dim rowIndex%, colIndex%
                rowIndex = 1
                For Each dr In ds.Tables(0).Rows
                    colIndex = 1
                    b(rowIndex, 0) = rowIndex
                    For Each dc In ds.Tables(0).Columns
                        b(rowIndex, colIndex) = dr(dc)
                        colIndex = colIndex + 1
                    Next
                    .Rows(rowIndex).Clear(ClearFlags.Style)
                    rowIndex = rowIndex + 1
                Next
                b.AutoSizeCols()
                .Redraw = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            command.Dispose()
            con.Close()
            MainLauncher(1)
        End Try
    End Sub
    Public Shared Sub loadtoGrid4(ByVal sql As String, ByVal id As Integer, ByVal id2 As Integer, ByVal b As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            MainLauncher(0)
            Dim adapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            adapter = New MySqlDataAdapter(sql, con)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            adapter.SelectCommand.Parameters.AddWithValue("@ID", id)
            adapter.SelectCommand.Parameters.AddWithValue("@ID2", id2)
            adapter.SelectCommand.CommandTimeout = 50000
            ds = New DataSet
            adapter.Fill(ds)
            con.Close()
            con.Dispose()
            With b
                .Redraw = False
                .Rows.Count = ds.Tables(0).Rows.Count + 1
                .Cols.Count = ds.Tables(0).Columns.Count + 2
                Dim dr As DataRow, dc As DataColumn
                Dim rowIndex%, colIndex%
                rowIndex = 1
                For Each dr In ds.Tables(0).Rows
                    colIndex = 1
                    b(rowIndex, 0) = rowIndex
                    For Each dc In ds.Tables(0).Columns
                        b(rowIndex, colIndex) = dr(dc)
                        colIndex = colIndex + 1
                    Next
                    .Rows(rowIndex).Clear(ClearFlags.Style)
                    rowIndex = rowIndex + 1
                Next
                b.AutoSizeCols()
                .Redraw = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            command.Dispose()
            con.Close()
            MainLauncher(1)
        End Try
    End Sub
#End Region
    Public Shared Sub ExportGrid(ByVal datagridview1 As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "Excel files (*.xls)|*.xls"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            If saveFileDialog1.ShowDialog() = DialogResult.OK And saveFileDialog1.FileName <> "" Then
                datagridview1.SaveExcel(saveFileDialog1.FileName, C1.Win.C1FlexGrid.FileFlags.IncludeFixedCells Or C1.Win.C1FlexGrid.FileFlags.VisibleOnly)
            Else
                Exit Sub
            End If
            Dim x As New C1.Win.C1Win7Pack.C1TaskDialog
            With x
                .MainInstruction = "Export complete!"
                .Content = "The file you have requested has been successfully exported to " & saveFileDialog1.FileName
                .WindowTitle = "Export complete"
                .CommonButtons = C1.Win.C1Win7Pack.TaskDialogCommonButtons.Ok
                .Show()
            End With
        Catch ex As Exception

        End Try

    End Sub
    Public Shared Sub gridgripstyle(ByVal flexgrid As C1FlexGrid)
        With flexgrid
            .Glyphs(GlyphEnum.Checked) = APCESMainForm.ImageList1.Images("checkbox.png")
            .Glyphs(GlyphEnum.Unchecked) = APCESMainForm.ImageList1.Images("checkbox_no.png")
        End With
    End Sub
    Public Shared Sub showMessage(ByVal messagecontent As String, ByVal instruc As String, ByVal windowtitle As String)
        Dim x As New C1.Win.C1Win7Pack.C1TaskDialog
        With x
            .MainInstruction = instruc
            .WindowTitle = windowtitle
            .MainCommonIcon = C1.Win.C1Win7Pack.TaskDialogCommonIcon.Information
            .Content = messagecontent
            .CommonButtons = C1.Win.C1Win7Pack.TaskDialogCommonButtons.Ok
            .Show()
        End With
    End Sub

    Public Shared Sub loadtoGridNew(ByVal sql As String, ByVal b As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            MainLauncher(0)
            Dim pagingAdapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            pagingAdapter = New MySqlDataAdapter("LoadAllData", con)
            pagingAdapter.SelectCommand.Parameters.AddWithValue("@StringQuery", sql)
            pagingAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            ds = New DataSet
            pagingAdapter.Fill(ds)
            con.Close()
            With b
                .Redraw = False
                If ds.Tables(0).Rows.Count <= 0 Then .Rows(0).Visible = False Else .Rows(0).Visible = True
                .Rows.Count = ds.Tables(0).Rows.Count + 1
                .Cols.Count = ds.Tables(0).Columns.Count + 2
                Dim dr As DataRow, dc As DataColumn
                Dim rowIndex%, colIndex%
                rowIndex = 1
                For Each dr In ds.Tables(0).Rows
                    colIndex = 1
                    b(rowIndex, 0) = rowIndex
                    For Each dc In ds.Tables(0).Columns
                        b(rowIndex, colIndex) = dr(dc)
                        colIndex = colIndex + 1
                    Next
                    rowIndex = rowIndex + 1
                Next
                b.AutoSizeCols()
                .Redraw = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            command.Dispose()
            con.Close()
            MainLauncher(1)
        End Try
    End Sub
    Public Shared Sub loadtoGridNew2(ByVal sql As String, ByVal id As Integer, ByVal b As C1.Win.C1FlexGrid.C1FlexGrid)
        Try
            MainLauncher(0)
            Dim pagingAdapter As New MySqlDataAdapter
            Dim ds As New DataSet
            connect()
            con.Open()
            pagingAdapter = New MySqlDataAdapter(sql, con)
            pagingAdapter.SelectCommand.Parameters.AddWithValue("@ID", id)
            pagingAdapter.SelectCommand.CommandType = CommandType.StoredProcedure
            ds = New DataSet
            pagingAdapter.Fill(ds)
            con.Close()
            With b
                .Redraw = False
                If ds.Tables(0).Rows.Count <= 0 Then .Rows(0).Visible = False Else .Rows(0).Visible = True
                .Rows.Count = ds.Tables(0).Rows.Count + 1
                .Cols.Count = ds.Tables(0).Columns.Count + 2
                Dim dr As DataRow, dc As DataColumn
                Dim rowIndex%, colIndex%
                rowIndex = 1
                For Each dr In ds.Tables(0).Rows
                    colIndex = 1
                    b(rowIndex, 0) = rowIndex
                    For Each dc In ds.Tables(0).Columns
                        b(rowIndex, colIndex) = dr(dc)
                        colIndex = colIndex + 1
                    Next
                    rowIndex = rowIndex + 1
                Next
                b.AutoSizeCols()
                .Redraw = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

            command.Dispose()
            con.Close()
            MainLauncher(1)
        End Try
    End Sub
    Public Shared Function GetFirstDayOfMonth(ByVal dtDate As DateTime) As DateTime
        Dim dtFrom As DateTime = dtDate
        dtFrom = dtFrom.AddDays(-(dtFrom.Day - 1))
        Return dtFrom
    End Function

    Public Shared Function GetLastDayOfMonth(ByVal dtDate As DateTime) As DateTime
        Dim dtTo As New DateTime(dtDate.Year, dtDate.Month, 1)
        dtTo = dtTo.AddMonths(1)
        dtTo = dtTo.AddDays(-(dtTo.Day))
        Return dtTo
    End Function
    Public Shared Function checkifpayrollexists(ByVal payrollperiodid As Integer, ByVal employeeid As Integer) As Boolean
        Dim result As Boolean
        connect()
        con.Open()
        command = New MySqlCommand
        With command
            .CommandText = "Select * from payroll_register where payrollperiodid='" & payrollperiodid & "' and employeeid='" & employeeid & "'"
            .Connection = con
            reader = .ExecuteReader
        End With
        If reader.Read = True Then
            result = True
        Else
            result = False
        End If
        reader.Close()
        command.Dispose()
        con.Close()
        Return result
    End Function
    Public Shared Function GetWTAX(ByVal taxableincome As Double, ByVal payrollgroup As String) As Double
        Dim ds As New DataSet
        Dim wtax As Double
        command = New MySqlCommand
        connect()
        con.Open()
        With command
            .Connection = con
            .CommandType = CommandType.StoredProcedure
            .CommandText = "GetValue_WitholdingTax"
            .Parameters.AddWithValue("@taxableincomes", taxableincome)
            .Parameters.AddWithValue("@payrollgroups", payrollgroup)
        End With
        Dim da As New MySqlDataAdapter
        da.SelectCommand = command
        da.SelectCommand.CommandTimeout = 1000
        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            ' MessageBox.Show(ds.Tables(0).Rows(0).Item(1).ToString() & " " & ds.Tables(0).Rows(0).Item(0).ToString())
            wtax = ds.Tables(0).Rows(0).Item(1).ToString
        End If
        ds.Dispose()
        da.Dispose()
        Return wtax
    End Function
    Public Shared Function GetWTAX1(ByVal employeeid As Integer) As Double
        Dim wtax As Double
        connect()
        con.Open()
        command = New MySqlCommand
        With command
            .CommandText = "Select EmployeeID, wtax from hris_employee where employeeid='" & employeeid & "'"
            .Connection = con
            reader = .ExecuteReader
        End With

        If reader.Read = True Then
            wtax = reader.Item("wtax")
        End If
        reader.Close()
        command.Dispose()
        con.Close()
        Return wtax
    End Function
    Public Shared Function GetSSSEE(ByVal employeeid As Integer) As Double
        Dim sssee As Double
        connect()
        con.Open()
        command = New MySqlCommand
        With command
            .CommandText = "Select a.EmployeeID, format(b.ee,2) as EE from hris_employee a join ssstable b where a.BasicPayMonth between b.rangefrom and b.rangeto and a.employeeid='" & employeeid & "'"
            .Connection = con
            reader = .ExecuteReader
        End With

        If reader.Read = True Then
            sssee = reader.Item("EE")
        End If
        reader.Close()
        command.Dispose()
        con.Close()
        Return sssee
    End Function
    
    Public Shared Function GetPHICEE(ByVal employeeid As Integer) As Double
        Dim phicee As Double
        connect()
        con.Open()
        command = New MySqlCommand
        With command
            .CommandText = "Select a.EmployeeID, (case when b.compute = 1 then format(a.BasicPayMonth*b.EEShare,2) else b.eeshare end) as EE" & _
                " from hris_employee a join phictable b where a.BasicPayMonth between b.rangefrom and b.rangeto and a.employeeid = '" & employeeid & "'"
            .Connection = con
            reader = .ExecuteReader
        End With

        If reader.Read = True Then
            phicee = reader.Item("EE")
        End If
        reader.Close()
        command.Dispose()
        con.Close()
        Return phicee
    End Function
    Public Shared Function GetHDMFEE(ByVal employeeid As Integer) As Double
        Dim hdmfee As Double

        connect()
        con.Open()
        command = New MySqlCommand
        With command
            .CommandText = "Select a.EmployeeID, (case when a.hdmfee<>0 then a.hdmfee else (case when b.compute = 1 then b.salarycredit*b.hdmfee else b.hdmfee end) end) as EE from hris_employee a join hdmftable b where a.BasicPayMonth between b.rangefrom and b.rangeto and a.employeeid='" & employeeid & "'"
            .Connection = con
            reader = .ExecuteReader
        End With
        If reader.Read = True Then
            hdmfee = reader.Item("EE")
        End If
        reader.Close()
        command.Dispose()
        con.Close()
        Return hdmfee
    End Function
    Public Shared Function GetCOLA(ByVal employeeid As Integer) As Double
        Dim colas As Double

        connect()
        con.Open()
        command = New MySqlCommand
        With command
            .CommandText = "Select a.cola from hris_employee a where a.employeeid='" & employeeid & "'"
            .Connection = con
            reader = .ExecuteReader
        End With
        If reader.Read = True Then
            colas = reader.Item("cola")
        End If
        reader.Close()
        command.Dispose()
        con.Close()
        Return colas
    End Function
    Public Shared Function GetBasicSalaryTotal(ByVal payrollperiod As Integer) As Double
        Dim BasicX As Double

        connect()
        con.Open()
        command = New MySqlCommand
        With command
            .CommandText = "Select (case when a.netpay<>0 then sum(a.NetPay) else 0 end) as Total from payroll_register a where a.payrollperiodid='" & payrollperiod & "' and a.register_type='REGULAR'"
            .Connection = con
            reader = .ExecuteReader
        End With
        If reader.Read = True Then
            BasicX = reader.Item("Total")
        End If
        reader.Close()
        command.Dispose()
        con.Close()
        Return BasicX
    End Function
    Public Shared Function GetOnVoucherTotal(ByVal payrollperiod As Integer) As Double
        Dim BasicX As Double

        connect()
        con.Open()
        command = New MySqlCommand
        With command
            .CommandText = "Select (case when a.netpay<>0 then sum(a.NetPay) else 0 end) as Total from payroll_register a where a.payrollperiodid='" & payrollperiod & "' and a.register_type='ALLOWANCE'"
            .Connection = con
            reader = .ExecuteReader
        End With
        If reader.Read = True Then
            BasicX = reader.Item("Total")
        End If
        reader.Close()
        command.Dispose()
        con.Close()
        Return BasicX
    End Function
   
End Class