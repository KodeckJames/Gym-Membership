Imports System.IO

Public Class Form1
    
    Structure Member
        Public MemberID As Integer
        Public Name As String
        Public Plan As String
        Public StartDate As Date
        Public DurationMonths As Integer
        Public TotalCost As Decimal
    End Structure

    Dim Members As New List(Of Member)
    Dim filePath As String = "gym_data.csv"


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.AddRange({"Monthly", "Quarterly", "Annual"})
        ComboBox1.SelectedIndex = 0
        NumericUpDown1.Minimum = 1

        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).Name = "ID"
        DataGridView1.Columns(1).Name = "Member Name"
        DataGridView1.Columns(2).Name = "Plan Type"
        DataGridView1.Columns(3).Name = "Total Cost"
        DataGridView1.Columns(4).Name = "Expiry Date"

        LoadData()
        UpdateGrid()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please enter a name.")
            Return
        End If

        Dim m As New Member
        m.MemberID = Members.Count + 1
        m.Name = TextBox1.Text
        m.Plan = ComboBox1.SelectedItem.ToString()
        m.StartDate = DateTime.Now

        Dim units As Integer = CInt(NumericUpDown1.Value)
        Select Case m.Plan
            Case "Monthly"
                m.DurationMonths = units
                m.TotalCost = units * 3000
            Case "Quarterly"
                m.DurationMonths = units * 3
                m.TotalCost = units * 8000
            Case "Annual"
                m.DurationMonths = units * 12
                m.TotalCost = units * 25000
        End Select

        Members.Add(m)
        SaveData()
        UpdateGrid()

        TextBox1.Clear()
        NumericUpDown1.Value = 1
        MessageBox.Show("Member added successfully!")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Sub UpdateGrid()
        DataGridView1.Rows.Clear()
        For Each m In Members
            Dim expiry As Date = m.StartDate.AddMonths(m.DurationMonths)
            DataGridView1.Rows.Add(m.MemberID, m.Name, m.Plan, "KES " & m.TotalCost.ToString("N2"), expiry.ToShortDateString())
        Next
    End Sub

    Sub SaveData()
        Try
            Using sw As New StreamWriter(filePath)
                For Each m In Members
                    sw.WriteLine($"{m.MemberID}|{m.Name}|{m.Plan}|{m.StartDate}|{m.DurationMonths}|{m.TotalCost}")
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        End Try
    End Sub

    Sub LoadData()
        If File.Exists(filePath) Then
            Members.Clear()
            For Each line In File.ReadAllLines(filePath)
                Dim parts = line.Split("|"c)
                If parts.Length = 6 Then
                    Dim m As New Member With {
                        .MemberID = CInt(parts(0)),
                        .Name = parts(1),
                        .Plan = parts(2),
                        .StartDate = CDate(parts(3)),
                        .DurationMonths = CInt(parts(4)),
                        .TotalCost = CDec(parts(5))
                    }
                    Members.Add(m)
                End If
            Next
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class