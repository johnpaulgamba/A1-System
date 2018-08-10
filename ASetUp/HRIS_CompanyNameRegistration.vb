Imports System.IO
Imports MySql.Data.MySqlClient
Public Class HRIS_CompanyNameRegistration
    Dim DlgOpenFile As New OpenFileDialog()
    Public ImageLocation As String = ""

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        Try
            With DlgOpenFile
                .ShowReadOnly = True
                .Title = "Browse the  Image file. (jpg format is not valid)"
                .Filter = "Image File|*.png; *.jpg; *.gif; *.tiff; *.tif"
                .ShowDialog()
                Me.PictureBox1.Load(.FileName)
                ImageLocation = .FileName
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub SaveCommand(ByVal sql As String, ByVal b As String)
        Dim cmd As New MySqlCommand
        Dim rawData() As Byte
        Dim fs As FileStream
        Dim sPath As String
        Try
            sPath = DlgOpenFile.FileName
            fs = New FileStream(sPath, FileMode.Open, FileAccess.Read)
            rawData = New Byte(fs.Length) {}
            fs.Read(rawData, 0, fs.Length)
            fs.Close()
            connect()
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
                .CommandType = CommandType.Text
                .Parameters.AddWithValue("@CompanyImage", rawData)
                .Parameters.AddWithValue("@CompanyName", Me.CompanyName.Text.ToUpper)
                .Parameters.AddWithValue("@AddressOfCompany", Me.AddressOFCompany.Text.ToUpper)
                .Parameters.AddWithValue("@ContactNo", Me.TelNo.Text.ToUpper)
                .Parameters.AddWithValue("@EmailAddress", Me.EmailAddress.Text)
                .Parameters.AddWithValue("@TIN", Me.TIN.Text)
                .Parameters.AddWithValue("@RDOCode", Me.RDOCode.Text)
                .Parameters.AddWithValue("@Philhealth", Me.PhilHealthNo.Text)
                .Parameters.AddWithValue("@SSS", Me.SSSNo.Text)
                .Parameters.AddWithValue("@Hdmf", Me.HDMFNo.Text)
                .Parameters.AddWithValue("@Creator", APCESMainForm.UserFullName.Text.ToUpper)
                .Parameters.AddWithValue("@Active", Me.InputCheckBox1.Checked)
                .Parameters.AddWithValue("@ChangesMade", b & " on " & Now & " at " & APCESMainForm.ComputerName.Text & " by " & APCESMainForm.UserFullName.Text & vbCrLf & "")
                .ExecuteNonQuery()
                .Dispose()
                con.Close()
            End With
            FunctionClass.showMessage("The command has been successfully executed", "Command executed", "Command successful")
            HRIS_CompanyNameMainForm.Refresh_Click()
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.ToString)
        End Try
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
    Public tosave As Boolean = True
    Public companyid As Integer = 0
    Private Sub InputButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton1.Click
        If Me.tosave = True Then
            SaveCommand("INSERT INTO  Company(CompanyName, AddressofCompany, Emailaddress,ContactNo,TIN,RDOCode,SSS,Philhealth,HDMF,CompanyImage, Active, Creator, Changesmade,DateCreated,LastUpdate) " & _
                        " VALUES (@CompanyName, @AddressOfCompany, @EmailAddress,@ContactNo,@TIN,@RDOCode,@SSS,@Philhealth,@HDMF,@CompanyImage,@Active,@Creator,@Changesmade,now(),'NA')  ", "Created on")
        Else
            SaveCommand("Update Company Set CompanyName=@CompanyName, AddressOfCompany=@AddressOfCompany, TIN=@TIN, Emailaddress=@Emailaddress, " & _
                        "Active=@Active,Rdocode=@rdocode,SSS=@sss,philhealth=@Philhealth,hdmf=@hdmf,ChangesMade=Concat(@ChangesMade, ChangesMAde), " & _
                        "CompanyImage= @CompanyImage, lastupdate=now() Where CompanyID='" & companyid & "' ", "Updated on")
        End If

    End Sub

    Private Sub InputButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InputButton3.Click
        Me.Close()
    End Sub



End Class
