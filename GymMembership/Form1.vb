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
        ComboBox1.Items.AddRange({"Monthly (KES 3,000)", "Quarterly (KES 8,000)", "Annually (KES 25,000)"})
        ComboBox1.SelectedIndex = 0
        NumericUpDown1.Minimum = 1

        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).Name = "ID"
        DataGridView1.Columns(1).Name = "Member Name"
        DataGridView1.Columns(2).Name = "Plan Type"
        DataGridView1.Columns(3).Name = "Total Cost"
        DataGridView1.Columns(4).Name = "Expiry Date"
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.AllowUserToAddRows = False

        lblSearchError.Text = ""
        lblSearchError.ForeColor = Color.Red

        LoadData()
        UpdateGrid()
        UpdatePricePreview()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        UpdatePricePreview()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        UpdateGrid(txtSearch.Text)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        UpdatePricePreview()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        UpdatePricePreview()
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
            Case "Monthly (KES 3,000)"
                m.DurationMonths = units
                m.TotalCost = units * 3000
            Case "Quarterly (KES 8,000)"
                m.DurationMonths = units * 3
                m.TotalCost = units * 8000
            Case "Annually (KES 25,000)"
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

    Sub UpdateGrid(Optional filter As String = "")
        DataGridView1.Rows.Clear()
        Dim found As Boolean = False

        For Each m In Members
            If String.IsNullOrEmpty(filter) OrElse m.Name.ToLower().Contains(filter.ToLower()) Then
                Dim expiry As Date = m.StartDate.AddMonths(m.DurationMonths)
                DataGridView1.Rows.Add(m.MemberID, m.Name, m.Plan, "KES " & m.TotalCost.ToString("N2"), expiry.ToShortDateString())
                found = True
            End If
        Next

        If Not String.IsNullOrEmpty(filter) AndAlso Not found Then
            lblSearchError.Text = "Sorry, member not found"
        Else
            lblSearchError.Text = ""
        End If
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
        Try
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
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim selectedID As Integer = CInt(DataGridView1.SelectedRows(0).Cells(0).Value)
                Dim memberToRemove = Members.FirstOrDefault(Function(x) x.MemberID = selectedID)
                Members.Remove(memberToRemove)

                For i As Integer = 0 To Members.Count - 1
                    Dim updatedMember = Members(i)
                    updatedMember.MemberID = i + 1
                    Members(i) = updatedMember
                Next

                SaveData()
                UpdateGrid()
                MessageBox.Show("Member deleted successfully.")
            End If
        Else
            MessageBox.Show("Please select a full row to delete.")
        End If
    End Sub

    Sub UpdatePricePreview()
        If ComboBox1.SelectedItem Is Nothing Then Exit Sub
        Dim plan As String = ComboBox1.SelectedItem.ToString()
        Dim units As Integer = CInt(NumericUpDown1.Value)
        Dim total As Decimal = 0
        Select Case plan
            Case "Monthly (KES 3,000)"
                total = units * 3000
            Case "Quarterly (KES 8,000)"
                total = units * 8000
            Case "Annually (KES 25,000)"
                total = units * 25000
        End Select
        lblTotalPreview.Text = String.Format("Total: KES {0:N2}", total)
    End Sub

End Class