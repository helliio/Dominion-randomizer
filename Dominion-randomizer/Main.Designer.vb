<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.Generate_btn = New System.Windows.Forms.Button()
        Me.Return_list = New System.Windows.Forms.ListBox()
        Me.BaseSet1ed_check = New System.Windows.Forms.CheckBox()
        Me.Alchemy_check = New System.Windows.Forms.CheckBox()
        Me.Veto_btn = New System.Windows.Forms.Button()
        Me.Error_lbl = New System.Windows.Forms.Label()
        Me.Prosperity_check = New System.Windows.Forms.CheckBox()
        Me.Veto_attack_check = New System.Windows.Forms.CheckBox()
        Me.Veto_curser_check = New System.Windows.Forms.CheckBox()
        Me.BaseSet2ed_check = New System.Windows.Forms.CheckBox()
        Me.DarkAges_check = New System.Windows.Forms.CheckBox()
        Me.RadioButtonNone = New System.Windows.Forms.RadioButton()
        Me.RadioButtonBase1 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonBase2 = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAlchemy = New System.Windows.Forms.RadioButton()
        Me.RadioButtonProsperity = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDarkAges = New System.Windows.Forms.RadioButton()
        Me.NumericUpDownExp = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDownExp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Generate_btn
        '
        Me.Generate_btn.Location = New System.Drawing.Point(227, 251)
        Me.Generate_btn.Name = "Generate_btn"
        Me.Generate_btn.Size = New System.Drawing.Size(158, 23)
        Me.Generate_btn.TabIndex = 0
        Me.Generate_btn.Text = "Generate"
        Me.Generate_btn.UseVisualStyleBackColor = True
        '
        'Return_list
        '
        Me.Return_list.FormattingEnabled = True
        Me.Return_list.Location = New System.Drawing.Point(12, 127)
        Me.Return_list.Name = "Return_list"
        Me.Return_list.Size = New System.Drawing.Size(209, 147)
        Me.Return_list.TabIndex = 1
        '
        'BaseSet1ed_check
        '
        Me.BaseSet1ed_check.AutoSize = True
        Me.BaseSet1ed_check.Checked = True
        Me.BaseSet1ed_check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BaseSet1ed_check.Location = New System.Drawing.Point(32, 35)
        Me.BaseSet1ed_check.Name = "BaseSet1ed_check"
        Me.BaseSet1ed_check.Size = New System.Drawing.Size(96, 17)
        Me.BaseSet1ed_check.TabIndex = 2
        Me.BaseSet1ed_check.Text = "Base Set 1 ed."
        Me.BaseSet1ed_check.UseVisualStyleBackColor = True
        '
        'Alchemy_check
        '
        Me.Alchemy_check.AutoSize = True
        Me.Alchemy_check.Location = New System.Drawing.Point(32, 81)
        Me.Alchemy_check.Name = "Alchemy_check"
        Me.Alchemy_check.Size = New System.Drawing.Size(66, 17)
        Me.Alchemy_check.TabIndex = 3
        Me.Alchemy_check.Text = "Alchemy"
        Me.Alchemy_check.UseVisualStyleBackColor = True
        '
        'Veto_btn
        '
        Me.Veto_btn.Location = New System.Drawing.Point(227, 222)
        Me.Veto_btn.Name = "Veto_btn"
        Me.Veto_btn.Size = New System.Drawing.Size(158, 23)
        Me.Veto_btn.TabIndex = 4
        Me.Veto_btn.Text = "Veto"
        Me.Veto_btn.UseVisualStyleBackColor = True
        '
        'Error_lbl
        '
        Me.Error_lbl.AutoSize = True
        Me.Error_lbl.Location = New System.Drawing.Point(227, 139)
        Me.Error_lbl.Name = "Error_lbl"
        Me.Error_lbl.Size = New System.Drawing.Size(45, 13)
        Me.Error_lbl.TabIndex = 5
        Me.Error_lbl.Text = "Error_lbl"
        Me.Error_lbl.Visible = False
        '
        'Prosperity_check
        '
        Me.Prosperity_check.AutoSize = True
        Me.Prosperity_check.Location = New System.Drawing.Point(32, 104)
        Me.Prosperity_check.Name = "Prosperity_check"
        Me.Prosperity_check.Size = New System.Drawing.Size(72, 17)
        Me.Prosperity_check.TabIndex = 6
        Me.Prosperity_check.Text = "Prosperity"
        Me.Prosperity_check.UseVisualStyleBackColor = True
        '
        'Veto_attack_check
        '
        Me.Veto_attack_check.AutoSize = True
        Me.Veto_attack_check.Location = New System.Drawing.Point(230, 176)
        Me.Veto_attack_check.Name = "Veto_attack_check"
        Me.Veto_attack_check.Size = New System.Drawing.Size(123, 17)
        Me.Veto_attack_check.TabIndex = 7
        Me.Veto_attack_check.Text = "Veto all attack cards"
        Me.Veto_attack_check.UseVisualStyleBackColor = True
        '
        'Veto_curser_check
        '
        Me.Veto_curser_check.AutoSize = True
        Me.Veto_curser_check.Location = New System.Drawing.Point(230, 199)
        Me.Veto_curser_check.Name = "Veto_curser_check"
        Me.Veto_curser_check.Size = New System.Drawing.Size(122, 17)
        Me.Veto_curser_check.TabIndex = 8
        Me.Veto_curser_check.Text = "Veto all curser cards"
        Me.Veto_curser_check.UseVisualStyleBackColor = True
        '
        'BaseSet2ed_check
        '
        Me.BaseSet2ed_check.AutoSize = True
        Me.BaseSet2ed_check.Location = New System.Drawing.Point(32, 58)
        Me.BaseSet2ed_check.Name = "BaseSet2ed_check"
        Me.BaseSet2ed_check.Size = New System.Drawing.Size(96, 17)
        Me.BaseSet2ed_check.TabIndex = 9
        Me.BaseSet2ed_check.Text = "Base Set 2 ed."
        Me.BaseSet2ed_check.UseVisualStyleBackColor = True
        '
        'DarkAges_check
        '
        Me.DarkAges_check.AutoSize = True
        Me.DarkAges_check.Location = New System.Drawing.Point(154, 35)
        Me.DarkAges_check.Name = "DarkAges_check"
        Me.DarkAges_check.Size = New System.Drawing.Size(76, 17)
        Me.DarkAges_check.TabIndex = 10
        Me.DarkAges_check.Text = "Dark Ages"
        Me.DarkAges_check.UseVisualStyleBackColor = True
        '
        'RadioButtonNone
        '
        Me.RadioButtonNone.AutoSize = True
        Me.RadioButtonNone.Checked = True
        Me.RadioButtonNone.Location = New System.Drawing.Point(12, 12)
        Me.RadioButtonNone.Name = "RadioButtonNone"
        Me.RadioButtonNone.Size = New System.Drawing.Size(156, 17)
        Me.RadioButtonNone.TabIndex = 11
        Me.RadioButtonNone.TabStop = True
        Me.RadioButtonNone.Text = "No main expantion selected"
        Me.RadioButtonNone.UseVisualStyleBackColor = True
        '
        'RadioButtonBase1
        '
        Me.RadioButtonBase1.AutoSize = True
        Me.RadioButtonBase1.Location = New System.Drawing.Point(12, 35)
        Me.RadioButtonBase1.Name = "RadioButtonBase1"
        Me.RadioButtonBase1.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonBase1.TabIndex = 12
        Me.RadioButtonBase1.UseVisualStyleBackColor = True
        '
        'RadioButtonBase2
        '
        Me.RadioButtonBase2.AutoSize = True
        Me.RadioButtonBase2.Enabled = False
        Me.RadioButtonBase2.Location = New System.Drawing.Point(12, 59)
        Me.RadioButtonBase2.Name = "RadioButtonBase2"
        Me.RadioButtonBase2.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonBase2.TabIndex = 13
        Me.RadioButtonBase2.UseVisualStyleBackColor = True
        '
        'RadioButtonAlchemy
        '
        Me.RadioButtonAlchemy.AutoSize = True
        Me.RadioButtonAlchemy.Enabled = False
        Me.RadioButtonAlchemy.Location = New System.Drawing.Point(12, 82)
        Me.RadioButtonAlchemy.Name = "RadioButtonAlchemy"
        Me.RadioButtonAlchemy.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonAlchemy.TabIndex = 14
        Me.RadioButtonAlchemy.UseVisualStyleBackColor = True
        '
        'RadioButtonProsperity
        '
        Me.RadioButtonProsperity.AutoSize = True
        Me.RadioButtonProsperity.Enabled = False
        Me.RadioButtonProsperity.Location = New System.Drawing.Point(12, 104)
        Me.RadioButtonProsperity.Name = "RadioButtonProsperity"
        Me.RadioButtonProsperity.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonProsperity.TabIndex = 15
        Me.RadioButtonProsperity.UseVisualStyleBackColor = True
        '
        'RadioButtonDarkAges
        '
        Me.RadioButtonDarkAges.AutoSize = True
        Me.RadioButtonDarkAges.Enabled = False
        Me.RadioButtonDarkAges.Location = New System.Drawing.Point(134, 36)
        Me.RadioButtonDarkAges.Name = "RadioButtonDarkAges"
        Me.RadioButtonDarkAges.Size = New System.Drawing.Size(14, 13)
        Me.RadioButtonDarkAges.TabIndex = 16
        Me.RadioButtonDarkAges.UseVisualStyleBackColor = True
        '
        'NumericUpDownExp
        '
        Me.NumericUpDownExp.Location = New System.Drawing.Point(329, 155)
        Me.NumericUpDownExp.Maximum = New Decimal(New Integer() {9, 0, 0, 0})
        Me.NumericUpDownExp.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownExp.Name = "NumericUpDownExp"
        Me.NumericUpDownExp.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDownExp.TabIndex = 17
        Me.NumericUpDownExp.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(227, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Minimum main exp:"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 285)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDownExp)
        Me.Controls.Add(Me.RadioButtonDarkAges)
        Me.Controls.Add(Me.RadioButtonProsperity)
        Me.Controls.Add(Me.RadioButtonAlchemy)
        Me.Controls.Add(Me.RadioButtonBase2)
        Me.Controls.Add(Me.RadioButtonBase1)
        Me.Controls.Add(Me.RadioButtonNone)
        Me.Controls.Add(Me.DarkAges_check)
        Me.Controls.Add(Me.BaseSet2ed_check)
        Me.Controls.Add(Me.Veto_curser_check)
        Me.Controls.Add(Me.Veto_attack_check)
        Me.Controls.Add(Me.Prosperity_check)
        Me.Controls.Add(Me.Error_lbl)
        Me.Controls.Add(Me.Veto_btn)
        Me.Controls.Add(Me.Alchemy_check)
        Me.Controls.Add(Me.BaseSet1ed_check)
        Me.Controls.Add(Me.Return_list)
        Me.Controls.Add(Me.Generate_btn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dominion Randomizer"
        CType(Me.NumericUpDownExp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Generate_btn As Button
    Friend WithEvents Return_list As ListBox
    Friend WithEvents BaseSet1ed_check As CheckBox
    Friend WithEvents Alchemy_check As CheckBox
    Friend WithEvents Veto_btn As Button
    Friend WithEvents Error_lbl As Label
    Friend WithEvents Prosperity_check As CheckBox
    Friend WithEvents Veto_attack_check As CheckBox
    Friend WithEvents Veto_curser_check As CheckBox
    Friend WithEvents BaseSet2ed_check As CheckBox
    Friend WithEvents DarkAges_check As CheckBox
    Friend WithEvents RadioButtonNone As RadioButton
    Friend WithEvents RadioButtonBase1 As RadioButton
    Friend WithEvents RadioButtonBase2 As RadioButton
    Friend WithEvents RadioButtonAlchemy As RadioButton
    Friend WithEvents RadioButtonProsperity As RadioButton
    Friend WithEvents RadioButtonDarkAges As RadioButton
    Friend WithEvents NumericUpDownExp As NumericUpDown
    Friend WithEvents Label1 As Label
End Class
