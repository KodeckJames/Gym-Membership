<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        Label4 = New Label()
        btnDelete = New Button()
        lblTotalPreview = New Label()
        txtSearch = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(237, 134)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter name"
        TextBox1.Size = New Size(218, 31)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(237, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 28)
        Label1.TabIndex = 1
        Label1.Text = "Member's Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(545, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 28)
        Label2.TabIndex = 2
        Label2.Text = "Select Plan"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AllowDrop = True
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(545, 134)
        ComboBox1.MaxLength = 100
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(279, 33)
        ComboBox1.TabIndex = 3
        ComboBox1.Tag = "Monthly"
        ComboBox1.Text = "Select Plan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(931, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 28)
        Label3.TabIndex = 4
        Label3.Text = "Duration (Units):" & vbCrLf
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(931, 133)
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(180, 31)
        NumericUpDown1.TabIndex = 5
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(606, 201)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 34)
        Button1.TabIndex = 6
        Button1.Text = "Add Member"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(309, 380)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(802, 317)
        DataGridView1.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(309, 340)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 28)
        Label4.TabIndex = 8
        Label4.Text = "List of Members:"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(1127, 380)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(233, 33)
        btnDelete.TabIndex = 9
        btnDelete.Text = "Delete Selected Member"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' lblTotalPreview
        ' 
        lblTotalPreview.AutoSize = True
        lblTotalPreview.Font = New Font("Segoe UI", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTotalPreview.Location = New Point(1127, 133)
        lblTotalPreview.Name = "lblTotalPreview"
        lblTotalPreview.Size = New Size(155, 28)
        lblTotalPreview.TabIndex = 10
        lblTotalPreview.Text = "Total: KES 0.00"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(476, 293)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(150, 31)
        txtSearch.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(309, 293)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 28)
        Label5.TabIndex = 12
        Label5.Text = "Search Member:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(221, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(1040, 38)
        Label6.TabIndex = 13
        Label6.Text = "Jacked Homies Gym Membership and Subscriptions Management System"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1783, 732)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(txtSearch)
        Controls.Add(lblTotalPreview)
        Controls.Add(btnDelete)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(Button1)
        Controls.Add(NumericUpDown1)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblTotalPreview As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label

End Class
