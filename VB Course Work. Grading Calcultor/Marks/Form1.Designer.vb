<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnEvaluate = New Button()
        txtMarks = New TextBox()
        txtGrade = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEvaluate.Location = New Point(155, 236)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(187, 44)
        btnEvaluate.TabIndex = 0
        btnEvaluate.Text = "Evaluate"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' txtMarks
        ' 
        txtMarks.Location = New Point(155, 149)
        txtMarks.Name = "txtMarks"
        txtMarks.Size = New Size(237, 23)
        txtMarks.TabIndex = 1
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(155, 191)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(237, 23)
        txtGrade.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(131, 67)
        Label1.Name = "Label1"
        Label1.Size = New Size(247, 30)
        Label1.TabIndex = 3
        Label1.Text = "Grading scale calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(89, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 17)
        Label2.TabIndex = 4
        Label2.Text = "Grade"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(47, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 17)
        Label3.TabIndex = 5
        Label3.Text = "Enter Marks"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(522, 423)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtGrade)
        Controls.Add(txtMarks)
        Controls.Add(btnEvaluate)
        Name = "Form1"
        Text = "Grade Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEvaluate As Button
    Friend WithEvents txtMarks As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
