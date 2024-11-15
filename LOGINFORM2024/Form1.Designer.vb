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
        btnTest = New Button()
        TextBox_UN = New TextBox()
        TextBox_Pass = New TextBox()
        btn_LogIn = New Button()
        SuspendLayout()
        ' 
        ' btnTest
        ' 
        btnTest.Location = New Point(23, 25)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(154, 68)
        btnTest.TabIndex = 0
        btnTest.Text = "Check Connection"
        btnTest.UseVisualStyleBackColor = True
        ' 
        ' TextBox_UN
        ' 
        TextBox_UN.Location = New Point(267, 144)
        TextBox_UN.Name = "TextBox_UN"
        TextBox_UN.Size = New Size(100, 23)
        TextBox_UN.TabIndex = 1
        ' 
        ' TextBox_Pass
        ' 
        TextBox_Pass.Location = New Point(267, 182)
        TextBox_Pass.Name = "TextBox_Pass"
        TextBox_Pass.Size = New Size(100, 23)
        TextBox_Pass.TabIndex = 2
        ' 
        ' btn_LogIn
        ' 
        btn_LogIn.Location = New Point(267, 225)
        btn_LogIn.Name = "btn_LogIn"
        btn_LogIn.Size = New Size(100, 34)
        btn_LogIn.TabIndex = 3
        btn_LogIn.Text = "Log In "
        btn_LogIn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_LogIn)
        Controls.Add(TextBox_Pass)
        Controls.Add(TextBox_UN)
        Controls.Add(btnTest)
        Name = "Form1"
        Text = "LOG IN FORM"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTest As Button
    Friend WithEvents TextBox_UN As TextBox
    Friend WithEvents TextBox_Pass As TextBox
    Friend WithEvents btn_LogIn As Button

End Class
