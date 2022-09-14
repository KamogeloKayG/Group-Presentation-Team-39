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
        Me.Checkboxsmoke = New System.Windows.Forms.CheckBox()
        Me.checkboxAnxmeds = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBoxhighbloodmeds = New System.Windows.Forms.CheckBox()
        Me.CheckBoxhivpositive = New System.Windows.Forms.CheckBox()
        Me.CheckBoxexebvirus = New System.Windows.Forms.CheckBox()
        Me.CheckBoxcholesterolmeds = New System.Windows.Forms.CheckBox()
        Me.CheckBoxregularPactivity = New System.Windows.Forms.CheckBox()
        Me.CheckBoxObese = New System.Windows.Forms.CheckBox()
        Me.CheckBoxcontact = New System.Windows.Forms.CheckBox()
        Me.CheckBoxUnprotectedsex = New System.Windows.Forms.CheckBox()
        Me.txtgender = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtdrugintake = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Checkboxsmoke
        '
        Me.Checkboxsmoke.AutoSize = True
        Me.Checkboxsmoke.Location = New System.Drawing.Point(6, 21)
        Me.Checkboxsmoke.Name = "Checkboxsmoke"
        Me.Checkboxsmoke.Size = New System.Drawing.Size(72, 20)
        Me.Checkboxsmoke.TabIndex = 0
        Me.Checkboxsmoke.Text = "Smoke"
        Me.Checkboxsmoke.UseVisualStyleBackColor = True
        '
        'checkboxAnxmeds
        '
        Me.checkboxAnxmeds.AutoSize = True
        Me.checkboxAnxmeds.Location = New System.Drawing.Point(6, 60)
        Me.checkboxAnxmeds.Name = "checkboxAnxmeds"
        Me.checkboxAnxmeds.Size = New System.Drawing.Size(141, 20)
        Me.checkboxAnxmeds.TabIndex = 1
        Me.checkboxAnxmeds.Text = "Anxiety Medication"
        Me.checkboxAnxmeds.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBoxhighbloodmeds)
        Me.GroupBox1.Controls.Add(Me.CheckBoxhivpositive)
        Me.GroupBox1.Controls.Add(Me.CheckBoxexebvirus)
        Me.GroupBox1.Controls.Add(Me.CheckBoxcholesterolmeds)
        Me.GroupBox1.Controls.Add(Me.CheckBoxregularPactivity)
        Me.GroupBox1.Controls.Add(Me.CheckBoxObese)
        Me.GroupBox1.Controls.Add(Me.CheckBoxcontact)
        Me.GroupBox1.Controls.Add(Me.CheckBoxUnprotectedsex)
        Me.GroupBox1.Controls.Add(Me.Checkboxsmoke)
        Me.GroupBox1.Controls.Add(Me.checkboxAnxmeds)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(966, 262)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select all that apply"
        '
        'CheckBoxhighbloodmeds
        '
        Me.CheckBoxhighbloodmeds.AutoSize = True
        Me.CheckBoxhighbloodmeds.Location = New System.Drawing.Point(191, 213)
        Me.CheckBoxhighbloodmeds.Name = "CheckBoxhighbloodmeds"
        Me.CheckBoxhighbloodmeds.Size = New System.Drawing.Size(133, 20)
        Me.CheckBoxhighbloodmeds.TabIndex = 9
        Me.CheckBoxhighbloodmeds.Text = "High Blood Meds"
        Me.CheckBoxhighbloodmeds.UseVisualStyleBackColor = True
        '
        'CheckBoxhivpositive
        '
        Me.CheckBoxhivpositive.AutoSize = True
        Me.CheckBoxhivpositive.Location = New System.Drawing.Point(191, 106)
        Me.CheckBoxhivpositive.Name = "CheckBoxhivpositive"
        Me.CheckBoxhivpositive.Size = New System.Drawing.Size(102, 20)
        Me.CheckBoxhivpositive.TabIndex = 8
        Me.CheckBoxhivpositive.Text = "HIV Positive"
        Me.CheckBoxhivpositive.UseVisualStyleBackColor = True
        '
        'CheckBoxexebvirus
        '
        Me.CheckBoxexebvirus.AutoSize = True
        Me.CheckBoxexebvirus.Location = New System.Drawing.Point(191, 60)
        Me.CheckBoxexebvirus.Name = "CheckBoxexebvirus"
        Me.CheckBoxexebvirus.Size = New System.Drawing.Size(88, 20)
        Me.CheckBoxexebvirus.TabIndex = 7
        Me.CheckBoxexebvirus.Text = "Exebvirus"
        Me.CheckBoxexebvirus.UseVisualStyleBackColor = True
        '
        'CheckBoxcholesterolmeds
        '
        Me.CheckBoxcholesterolmeds.AutoSize = True
        Me.CheckBoxcholesterolmeds.Location = New System.Drawing.Point(191, 21)
        Me.CheckBoxcholesterolmeds.Name = "CheckBoxcholesterolmeds"
        Me.CheckBoxcholesterolmeds.Size = New System.Drawing.Size(166, 20)
        Me.CheckBoxcholesterolmeds.TabIndex = 6
        Me.CheckBoxcholesterolmeds.Text = "Cholesterol Medication"
        Me.CheckBoxcholesterolmeds.UseVisualStyleBackColor = True
        '
        'CheckBoxregularPactivity
        '
        Me.CheckBoxregularPactivity.AutoSize = True
        Me.CheckBoxregularPactivity.Location = New System.Drawing.Point(6, 159)
        Me.CheckBoxregularPactivity.Name = "CheckBoxregularPactivity"
        Me.CheckBoxregularPactivity.Size = New System.Drawing.Size(176, 20)
        Me.CheckBoxregularPactivity.TabIndex = 5
        Me.CheckBoxregularPactivity.Text = "Regular Physical Activity"
        Me.CheckBoxregularPactivity.UseVisualStyleBackColor = True
        '
        'CheckBoxObese
        '
        Me.CheckBoxObese.AutoSize = True
        Me.CheckBoxObese.Location = New System.Drawing.Point(6, 214)
        Me.CheckBoxObese.Name = "CheckBoxObese"
        Me.CheckBoxObese.Size = New System.Drawing.Size(70, 20)
        Me.CheckBoxObese.TabIndex = 4
        Me.CheckBoxObese.Text = "Obese"
        Me.CheckBoxObese.UseVisualStyleBackColor = True
        '
        'CheckBoxcontact
        '
        Me.CheckBoxcontact.AutoSize = True
        Me.CheckBoxcontact.Location = New System.Drawing.Point(191, 159)
        Me.CheckBoxcontact.Name = "CheckBoxcontact"
        Me.CheckBoxcontact.Size = New System.Drawing.Size(77, 20)
        Me.CheckBoxcontact.TabIndex = 3
        Me.CheckBoxcontact.Text = "Contact "
        Me.CheckBoxcontact.UseVisualStyleBackColor = True
        '
        'CheckBoxUnprotectedsex
        '
        Me.CheckBoxUnprotectedsex.AutoSize = True
        Me.CheckBoxUnprotectedsex.Location = New System.Drawing.Point(6, 106)
        Me.CheckBoxUnprotectedsex.Name = "CheckBoxUnprotectedsex"
        Me.CheckBoxUnprotectedsex.Size = New System.Drawing.Size(129, 20)
        Me.CheckBoxUnprotectedsex.TabIndex = 2
        Me.CheckBoxUnprotectedsex.Text = "Unprotected Sex"
        Me.CheckBoxUnprotectedsex.UseVisualStyleBackColor = True
        '
        'txtgender
        '
        Me.txtgender.Location = New System.Drawing.Point(151, 66)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(100, 22)
        Me.txtgender.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 48)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Gender" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "1. Male" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2. Female"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(47, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(355, 77)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "View Results"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(354, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Age"
        '
        'txtage
        '
        Me.txtage.Location = New System.Drawing.Point(425, 55)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(100, 22)
        Me.txtage.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(642, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Drugintake"
        '
        'txtdrugintake
        '
        Me.txtdrugintake.Location = New System.Drawing.Point(771, 52)
        Me.txtdrugintake.Name = "txtdrugintake"
        Me.txtdrugintake.Size = New System.Drawing.Size(100, 22)
        Me.txtdrugintake.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.txtdrugintake)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtgender)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Checkboxsmoke As CheckBox
    Friend WithEvents checkboxAnxmeds As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBoxhivpositive As CheckBox
    Friend WithEvents CheckBoxexebvirus As CheckBox
    Friend WithEvents CheckBoxcholesterolmeds As CheckBox
    Friend WithEvents CheckBoxregularPactivity As CheckBox
    Friend WithEvents CheckBoxObese As CheckBox
    Friend WithEvents CheckBoxcontact As CheckBox
    Friend WithEvents CheckBoxUnprotectedsex As CheckBox
    Friend WithEvents txtgender As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBoxhighbloodmeds As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtdrugintake As TextBox
End Class
