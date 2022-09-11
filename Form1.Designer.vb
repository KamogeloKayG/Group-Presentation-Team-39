<<<<<<< HEAD
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScreening
=======
﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
>>>>>>> 17b94be3b5827feec808198643656002c93cb477
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtfReport = New System.Windows.Forms.RichTextBox()
        Me.radSmoker = New System.Windows.Forms.RadioButton()
        Me.radAlcohol = New System.Windows.Forms.RadioButton()
        Me.radSActive = New System.Windows.Forms.RadioButton()
        Me.grpSocial = New System.Windows.Forms.GroupBox()
        Me.radDrugs = New System.Windows.Forms.RadioButton()
        Me.grpEnviro = New System.Windows.Forms.GroupBox()
        Me.radStress = New System.Windows.Forms.RadioButton()
        Me.radWater = New System.Windows.Forms.RadioButton()
        Me.radOvercrowded = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpHealth = New System.Windows.Forms.GroupBox()
        Me.radHIV = New System.Windows.Forms.RadioButton()
        Me.radSick = New System.Windows.Forms.RadioButton()
        Me.radMed = New System.Windows.Forms.RadioButton()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.radRelatives = New System.Windows.Forms.RadioButton()
        Me.grpSocial.SuspendLayout()
        Me.grpEnviro.SuspendLayout()
        Me.grpHealth.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Age:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(238, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gender:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Weight:"
        '
        'rtfReport
        '
        Me.rtfReport.Location = New System.Drawing.Point(23, 458)
        Me.rtfReport.Name = "rtfReport"
        Me.rtfReport.Size = New System.Drawing.Size(795, 227)
        Me.rtfReport.TabIndex = 3
        Me.rtfReport.Text = ""
        '
        'radSmoker
        '
        Me.radSmoker.AutoSize = True
        Me.radSmoker.Location = New System.Drawing.Point(6, 32)
        Me.radSmoker.Name = "radSmoker"
        Me.radSmoker.Size = New System.Drawing.Size(112, 20)
        Me.radSmoker.TabIndex = 0
        Me.radSmoker.TabStop = True
        Me.radSmoker.Text = "I am a smoker"
        Me.radSmoker.UseVisualStyleBackColor = True
        '
        'radAlcohol
        '
        Me.radAlcohol.AutoSize = True
        Me.radAlcohol.Location = New System.Drawing.Point(6, 75)
        Me.radAlcohol.Name = "radAlcohol"
        Me.radAlcohol.Size = New System.Drawing.Size(142, 20)
        Me.radAlcohol.TabIndex = 1
        Me.radAlcohol.TabStop = True
        Me.radAlcohol.Text = "I drink alcohol often"
        Me.radAlcohol.UseVisualStyleBackColor = True
        '
        'radSActive
        '
        Me.radSActive.AutoSize = True
        Me.radSActive.Location = New System.Drawing.Point(7, 115)
        Me.radSActive.Name = "radSActive"
        Me.radSActive.Size = New System.Drawing.Size(144, 20)
        Me.radSActive.TabIndex = 2
        Me.radSActive.TabStop = True
        Me.radSActive.Text = "I am sexually active"
        Me.radSActive.UseVisualStyleBackColor = True
        '
        'grpSocial
        '
        Me.grpSocial.Controls.Add(Me.radDrugs)
        Me.grpSocial.Controls.Add(Me.radSActive)
        Me.grpSocial.Controls.Add(Me.radSmoker)
        Me.grpSocial.Controls.Add(Me.radAlcohol)
        Me.grpSocial.Location = New System.Drawing.Point(303, 172)
        Me.grpSocial.Name = "grpSocial"
        Me.grpSocial.Size = New System.Drawing.Size(198, 211)
        Me.grpSocial.TabIndex = 5
        Me.grpSocial.TabStop = False
        Me.grpSocial.Text = "Social Habits:"
        '
        'radDrugs
        '
        Me.radDrugs.AutoSize = True
        Me.radDrugs.Location = New System.Drawing.Point(7, 152)
        Me.radDrugs.Name = "radDrugs"
        Me.radDrugs.Size = New System.Drawing.Size(177, 20)
        Me.radDrugs.TabIndex = 3
        Me.radDrugs.TabStop = True
        Me.radDrugs.Text = "I use drugs recreationally"
        Me.radDrugs.UseVisualStyleBackColor = True
        '
        'grpEnviro
        '
        Me.grpEnviro.Controls.Add(Me.radStress)
        Me.grpEnviro.Controls.Add(Me.radWater)
        Me.grpEnviro.Controls.Add(Me.radOvercrowded)
        Me.grpEnviro.Location = New System.Drawing.Point(512, 172)
        Me.grpEnviro.Name = "grpEnviro"
        Me.grpEnviro.Size = New System.Drawing.Size(305, 146)
        Me.grpEnviro.TabIndex = 6
        Me.grpEnviro.TabStop = False
        Me.grpEnviro.Text = "Environmental Factors"
        '
        'radStress
        '
        Me.radStress.AutoSize = True
        Me.radStress.Location = New System.Drawing.Point(16, 115)
        Me.radStress.Name = "radStress"
        Me.radStress.Size = New System.Drawing.Size(187, 20)
        Me.radStress.TabIndex = 5
        Me.radStress.TabStop = True
        Me.radStress.Text = "My environment is stressful"
        Me.radStress.UseVisualStyleBackColor = True
        '
        'radWater
        '
        Me.radWater.AutoSize = True
        Me.radWater.Location = New System.Drawing.Point(16, 32)
        Me.radWater.Name = "radWater"
        Me.radWater.Size = New System.Drawing.Size(255, 20)
        Me.radWater.TabIndex = 3
        Me.radWater.TabStop = True
        Me.radWater.Text = "My environment has poor water quality"
        Me.radWater.UseVisualStyleBackColor = True
        '
        'radOvercrowded
        '
        Me.radOvercrowded.AutoSize = True
        Me.radOvercrowded.Location = New System.Drawing.Point(16, 75)
        Me.radOvercrowded.Name = "radOvercrowded"
        Me.radOvercrowded.Size = New System.Drawing.Size(217, 20)
        Me.radOvercrowded.TabIndex = 4
        Me.radOvercrowded.TabStop = True
        Me.radOvercrowded.Text = "My environment is overcrowded"
        Me.radOvercrowded.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(238, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Height:"
        '
        'grpHealth
        '
        Me.grpHealth.Controls.Add(Me.radRelatives)
        Me.grpHealth.Controls.Add(Me.radHIV)
        Me.grpHealth.Controls.Add(Me.radSick)
        Me.grpHealth.Controls.Add(Me.radMed)
        Me.grpHealth.Location = New System.Drawing.Point(17, 172)
        Me.grpHealth.Name = "grpHealth"
        Me.grpHealth.Size = New System.Drawing.Size(280, 211)
        Me.grpHealth.TabIndex = 8
        Me.grpHealth.TabStop = False
        Me.grpHealth.Text = "Overall Health:"
        '
        'radHIV
        '
        Me.radHIV.AutoSize = True
        Me.radHIV.Location = New System.Drawing.Point(6, 115)
        Me.radHIV.Name = "radHIV"
        Me.radHIV.Size = New System.Drawing.Size(128, 20)
        Me.radHIV.TabIndex = 8
        Me.radHIV.TabStop = True
        Me.radHIV.Text = "I am HIV positive"
        Me.radHIV.UseVisualStyleBackColor = True
        '
        'radSick
        '
        Me.radSick.AutoSize = True
        Me.radSick.Location = New System.Drawing.Point(6, 32)
        Me.radSick.Name = "radSick"
        Me.radSick.Size = New System.Drawing.Size(200, 20)
        Me.radSick.TabIndex = 6
        Me.radSick.TabStop = True
        Me.radSick.Text = "I have pre-existing conditions"
        Me.radSick.UseVisualStyleBackColor = True
        '
        'radMed
        '
        Me.radMed.AutoSize = True
        Me.radMed.Location = New System.Drawing.Point(6, 75)
        Me.radMed.Name = "radMed"
        Me.radMed.Size = New System.Drawing.Size(214, 20)
        Me.radMed.TabIndex = 7
        Me.radMed.TabStop = True
        Me.radMed.Text = "I am currently taking medication"
        Me.radMed.UseVisualStyleBackColor = True
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(78, 15)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 22)
        Me.txtAge.TabIndex = 9
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(303, 19)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(121, 24)
        Me.cboGender.TabIndex = 10
        Me.cboGender.Text = "Select"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(78, 58)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 22)
        Me.txtWeight.TabIndex = 11
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(303, 61)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 22)
        Me.txtHeight.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(236, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(318, 29)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Select all that apply to you"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(380, 407)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 29)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Report:"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(485, 22)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(139, 46)
        Me.btnEnter.TabIndex = 15
        Me.btnEnter.Text = "Enter Details"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(568, 333)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(215, 50)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(568, 389)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(215, 47)
        Me.btnReport.TabIndex = 17
        Me.btnReport.Text = "Generate Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'radRelatives
        '
        Me.radRelatives.AutoSize = True
        Me.radRelatives.Location = New System.Drawing.Point(6, 152)
        Me.radRelatives.Name = "radRelatives"
        Me.radRelatives.Size = New System.Drawing.Size(273, 20)
        Me.radRelatives.TabIndex = 9
        Me.radRelatives.TabStop = True
        Me.radRelatives.Text = "My relatives have Auto-Immune diseases"
        Me.radRelatives.UseVisualStyleBackColor = True
        '
        'frmScreening
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 692)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.grpHealth)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grpEnviro)
        Me.Controls.Add(Me.grpSocial)
        Me.Controls.Add(Me.rtfReport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmScreening"
        Me.Text = "Screening Tool"
        Me.grpSocial.ResumeLayout(False)
        Me.grpSocial.PerformLayout()
        Me.grpEnviro.ResumeLayout(False)
        Me.grpEnviro.PerformLayout()
        Me.grpHealth.ResumeLayout(False)
        Me.grpHealth.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
<<<<<<< HEAD

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rtfReport As RichTextBox
    Friend WithEvents radSmoker As RadioButton
    Friend WithEvents radAlcohol As RadioButton
    Friend WithEvents radSActive As RadioButton
    Friend WithEvents grpSocial As GroupBox
    Friend WithEvents radDrugs As RadioButton
    Friend WithEvents grpEnviro As GroupBox
    Friend WithEvents radStress As RadioButton
    Friend WithEvents radWater As RadioButton
    Friend WithEvents radOvercrowded As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents grpHealth As GroupBox
    Friend WithEvents radSick As RadioButton
    Friend WithEvents radMed As RadioButton
    Friend WithEvents txtAge As TextBox
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents radHIV As RadioButton
    Friend WithEvents btnReport As Button
    Friend WithEvents radRelatives As RadioButton
=======
>>>>>>> 17b94be3b5827feec808198643656002c93cb477
End Class
