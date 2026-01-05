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
        components = New ComponentModel.Container()
        Timer1 = New Timer(components)
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        NumericUpDown1 = New NumericUpDown()
        Button1 = New Button()
        DataGridView1 = New DataGridView()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(34, 57)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter name"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 25)
        Label1.TabIndex = 1
        Label1.Text = "Member Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(235, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 25)
        Label2.TabIndex = 2
        Label2.Text = "Select Plan"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.AllowDrop = True
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Monthly", "Quarterly", "Annually"})
        ComboBox1.Location = New Point(235, 57)
        ComboBox1.MaxLength = 100
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(255, 33)
        ComboBox1.TabIndex = 3
        ComboBox1.Tag = "Monthly"
        ComboBox1.Text = "Select Plan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(612, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 25)
        Label3.TabIndex = 4
        Label3.Text = "Duration (Units):" & vbCrLf
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(612, 58)
        NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(180, 31)
        NumericUpDown1.TabIndex = 5
        NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(34, 135)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 34)
        Button1.TabIndex = 6
        Button1.Text = "Add Member"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(34, 198)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(360, 299)
        DataGridView1.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1253, 639)
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

    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView

End Class
