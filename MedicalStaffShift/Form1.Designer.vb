<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.LblStaff = New System.Windows.Forms.Label()
        Me.LBLshiftId = New System.Windows.Forms.Label()
        Me.LabelBegin = New System.Windows.Forms.Label()
        Me.LabelEnd = New System.Windows.Forms.Label()
        Me.Labelshiftstat = New System.Windows.Forms.Label()
        Me.Btnclose = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.BtnAddnew = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Labelshiftstat)
        Me.GroupBox1.Controls.Add(Me.LabelEnd)
        Me.GroupBox1.Controls.Add(Me.LabelBegin)
        Me.GroupBox1.Controls.Add(Me.LBLshiftId)
        Me.GroupBox1.Controls.Add(Me.LblStaff)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 288)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "On-Call list"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(47, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(259, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(365, 32)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(471, 32)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(153, 32)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 4
        '
        'LblStaff
        '
        Me.LblStaff.AutoSize = True
        Me.LblStaff.Location = New System.Drawing.Point(44, 16)
        Me.LblStaff.Name = "LblStaff"
        Me.LblStaff.Size = New System.Drawing.Size(38, 13)
        Me.LblStaff.TabIndex = 5
        Me.LblStaff.Text = "StaffId"
        '
        'LBLshiftId
        '
        Me.LBLshiftId.AutoSize = True
        Me.LBLshiftId.Location = New System.Drawing.Point(162, 16)
        Me.LBLshiftId.Name = "LBLshiftId"
        Me.LBLshiftId.Size = New System.Drawing.Size(37, 13)
        Me.LBLshiftId.TabIndex = 6
        Me.LBLshiftId.Text = "ShiftId"
        '
        'LabelBegin
        '
        Me.LabelBegin.AutoSize = True
        Me.LabelBegin.Location = New System.Drawing.Point(278, 16)
        Me.LabelBegin.Name = "LabelBegin"
        Me.LabelBegin.Size = New System.Drawing.Size(88, 13)
        Me.LabelBegin.TabIndex = 7
        Me.LabelBegin.Text = "Date/Time Begin"
        '
        'LabelEnd
        '
        Me.LabelEnd.AutoSize = True
        Me.LabelEnd.Location = New System.Drawing.Point(380, 16)
        Me.LabelEnd.Name = "LabelEnd"
        Me.LabelEnd.Size = New System.Drawing.Size(80, 13)
        Me.LabelEnd.TabIndex = 8
        Me.LabelEnd.Text = "Date/Time End"
        '
        'Labelshiftstat
        '
        Me.Labelshiftstat.AutoSize = True
        Me.Labelshiftstat.Location = New System.Drawing.Point(468, 16)
        Me.Labelshiftstat.Name = "Labelshiftstat"
        Me.Labelshiftstat.Size = New System.Drawing.Size(61, 13)
        Me.Labelshiftstat.TabIndex = 9
        Me.Labelshiftstat.Text = "Shift Status"
        '
        'Btnclose
        '
        Me.Btnclose.Location = New System.Drawing.Point(600, 347)
        Me.Btnclose.Name = "Btnclose"
        Me.Btnclose.Size = New System.Drawing.Size(109, 33)
        Me.Btnclose.TabIndex = 1
        Me.Btnclose.Text = "Close"
        Me.Btnclose.UseVisualStyleBackColor = True
        '
        'Btndelete
        '
        Me.Btndelete.Location = New System.Drawing.Point(406, 347)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(92, 33)
        Me.Btndelete.TabIndex = 2
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'BtnAddnew
        '
        Me.BtnAddnew.Location = New System.Drawing.Point(176, 347)
        Me.BtnAddnew.Name = "BtnAddnew"
        Me.BtnAddnew.Size = New System.Drawing.Size(116, 33)
        Me.BtnAddnew.TabIndex = 3
        Me.BtnAddnew.Text = "Add New Record"
        Me.BtnAddnew.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnAddnew)
        Me.Controls.Add(Me.Btndelete)
        Me.Controls.Add(Me.Btnclose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Labelshiftstat As Label
    Friend WithEvents LabelEnd As Label
    Friend WithEvents LabelBegin As Label
    Friend WithEvents LBLshiftId As Label
    Friend WithEvents LblStaff As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Btnclose As Button
    Friend WithEvents Btndelete As Button
    Friend WithEvents BtnAddnew As Button
End Class
