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
        Me.SuspendLayout()
        '
        'Generate_btn
        '
        Me.Generate_btn.Location = New System.Drawing.Point(227, 229)
        Me.Generate_btn.Name = "Generate_btn"
        Me.Generate_btn.Size = New System.Drawing.Size(123, 23)
        Me.Generate_btn.TabIndex = 0
        Me.Generate_btn.Text = "Generate"
        Me.Generate_btn.UseVisualStyleBackColor = True
        '
        'Return_list
        '
        Me.Return_list.FormattingEnabled = True
        Me.Return_list.Location = New System.Drawing.Point(12, 105)
        Me.Return_list.Name = "Return_list"
        Me.Return_list.Size = New System.Drawing.Size(209, 147)
        Me.Return_list.TabIndex = 1
        '
        'BaseSet1ed_check
        '
        Me.BaseSet1ed_check.AutoSize = True
        Me.BaseSet1ed_check.Checked = True
        Me.BaseSet1ed_check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BaseSet1ed_check.Location = New System.Drawing.Point(13, 13)
        Me.BaseSet1ed_check.Name = "BaseSet1ed_check"
        Me.BaseSet1ed_check.Size = New System.Drawing.Size(96, 17)
        Me.BaseSet1ed_check.TabIndex = 2
        Me.BaseSet1ed_check.Text = "Base Set 1 ed."
        Me.BaseSet1ed_check.UseVisualStyleBackColor = True
        '
        'Alchemy_check
        '
        Me.Alchemy_check.AutoSize = True
        Me.Alchemy_check.Location = New System.Drawing.Point(13, 59)
        Me.Alchemy_check.Name = "Alchemy_check"
        Me.Alchemy_check.Size = New System.Drawing.Size(66, 17)
        Me.Alchemy_check.TabIndex = 3
        Me.Alchemy_check.Text = "Alchemy"
        Me.Alchemy_check.UseVisualStyleBackColor = True
        '
        'Veto_btn
        '
        Me.Veto_btn.Location = New System.Drawing.Point(227, 200)
        Me.Veto_btn.Name = "Veto_btn"
        Me.Veto_btn.Size = New System.Drawing.Size(122, 23)
        Me.Veto_btn.TabIndex = 4
        Me.Veto_btn.Text = "Veto"
        Me.Veto_btn.UseVisualStyleBackColor = True
        '
        'Error_lbl
        '
        Me.Error_lbl.AutoSize = True
        Me.Error_lbl.Location = New System.Drawing.Point(224, 138)
        Me.Error_lbl.Name = "Error_lbl"
        Me.Error_lbl.Size = New System.Drawing.Size(45, 13)
        Me.Error_lbl.TabIndex = 5
        Me.Error_lbl.Text = "Error_lbl"
        Me.Error_lbl.Visible = False
        '
        'Prosperity_check
        '
        Me.Prosperity_check.AutoSize = True
        Me.Prosperity_check.Location = New System.Drawing.Point(13, 82)
        Me.Prosperity_check.Name = "Prosperity_check"
        Me.Prosperity_check.Size = New System.Drawing.Size(72, 17)
        Me.Prosperity_check.TabIndex = 6
        Me.Prosperity_check.Text = "Prosperity"
        Me.Prosperity_check.UseVisualStyleBackColor = True
        '
        'Veto_attack_check
        '
        Me.Veto_attack_check.AutoSize = True
        Me.Veto_attack_check.Location = New System.Drawing.Point(227, 154)
        Me.Veto_attack_check.Name = "Veto_attack_check"
        Me.Veto_attack_check.Size = New System.Drawing.Size(123, 17)
        Me.Veto_attack_check.TabIndex = 7
        Me.Veto_attack_check.Text = "Veto all attack cards"
        Me.Veto_attack_check.UseVisualStyleBackColor = True
        '
        'Veto_curser_check
        '
        Me.Veto_curser_check.AutoSize = True
        Me.Veto_curser_check.Location = New System.Drawing.Point(227, 177)
        Me.Veto_curser_check.Name = "Veto_curser_check"
        Me.Veto_curser_check.Size = New System.Drawing.Size(122, 17)
        Me.Veto_curser_check.TabIndex = 8
        Me.Veto_curser_check.Text = "Veto all curser cards"
        Me.Veto_curser_check.UseVisualStyleBackColor = True
        '
        'BaseSet2ed_check
        '
        Me.BaseSet2ed_check.AutoSize = True
        Me.BaseSet2ed_check.Location = New System.Drawing.Point(13, 36)
        Me.BaseSet2ed_check.Name = "BaseSet2ed_check"
        Me.BaseSet2ed_check.Size = New System.Drawing.Size(96, 17)
        Me.BaseSet2ed_check.TabIndex = 9
        Me.BaseSet2ed_check.Text = "Base Set 2 ed."
        Me.BaseSet2ed_check.UseVisualStyleBackColor = True
        '
        'DarkAges_check
        '
        Me.DarkAges_check.AutoSize = True
        Me.DarkAges_check.Location = New System.Drawing.Point(116, 13)
        Me.DarkAges_check.Name = "DarkAges_check"
        Me.DarkAges_check.Size = New System.Drawing.Size(76, 17)
        Me.DarkAges_check.TabIndex = 10
        Me.DarkAges_check.Text = "Dark Ages"
        Me.DarkAges_check.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 259)
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
End Class
