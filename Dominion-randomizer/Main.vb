'Copyright (c) 2016 Liang Zhu

'Permission is hereby granted, free of charge, to any person obtaining
'a copy of this software and associated documentation files (the
'"Software"), to deal in the Software without restriction, including
'without limitation the rights to use, copy, modify, merge, publish,
'distribute, sublicense, and/or sell copies of the Software, and to
'permit persons to whom the Software is furnished to do so, subject to
'the following conditions:

'The above copyright notice and this permission notice shall be
'included in all copies or substantial portions of the Software.

'THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
'EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
'MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
'IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
'CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
'TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
'SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Public Class Main
    Dim pool_list As New SortedSet(Of String)
    Dim ret_list As New SortedSet(Of String)
    Dim temp_list As New SortedSet(Of String)
    Dim rnd = New Random()
    Dim veto_flag As Boolean = 0
    Dim split_line As String = "---New cards---"
    Dim egg As New EasterEgg(5)

    'Veto_type removes cards from pool_list with a certain type only usable if input variable is >= 3
    Sub Veto_type(n As Integer)
        If n >= 3 Then
            Dim veto_list As New List(Of String)
            For Each item As String In pool_list
                Dim isolated_card_values = Split(item, ".")
                If isolated_card_values(n) = 1 Then
                    veto_list.Add(item)
                End If
            Next
            For Each item As String In veto_list
                pool_list.Remove(item)
            Next
        End If
    End Sub

    Sub Main_exp(ByVal expantion As SortedSet(Of String))
        Dim exp_list As New SortedSet(Of String)
        exp_list.UnionWith(expantion)
        For index As Integer = 0 To NumericUpDownExp.Value - 1
            Dim picked_card = exp_list(rnd.Next(0, exp_list.Count))
            ret_list.Add(picked_card)
            exp_list.Remove(picked_card)
            pool_list.Remove(picked_card)
        Next
        For index As Integer = NumericUpDownExp.Value To 9
            Dim picked_card = pool_list(rnd.Next(0, pool_list.Count))
            ret_list.Add(picked_card)
            pool_list.Remove(picked_card)
        Next
    End Sub

    Sub Radio_state_change(r As RadioButton, c As CheckBox)
        If r.Checked Then
            RadioButtonNone.Checked = 1
        End If
        r.Enabled = c.Checked
    End Sub

    Private Sub Generate_btn_Click(sender As Object, e As EventArgs) Handles Generate_btn.Click
        pool_list.Clear()
        ret_list.Clear()
        Return_list.Items.Clear()
        temp_list.Clear()
        Error_lbl.Visible = 0
        veto_flag = 0
        egg.Clear()

        If BaseSet1ed_check.Checked Then
            pool_list.UnionWith(BaseSet.cards_common)
            pool_list.UnionWith(BaseSet.cards_1ed)
        End If
        If BaseSet2ed_check.Checked Then
            pool_list.UnionWith(BaseSet.cards_common)
            pool_list.UnionWith(BaseSet.cards_2ed)
        End If
        If Intrigue1ed_check.Checked Then
            pool_list.UnionWith(Intrigue.cards_common)
            pool_list.UnionWith(Intrigue.cards_1ed)
        End If
        If Intrigue2ed_check.Checked Then
            pool_list.UnionWith(Intrigue.cards_common)
            pool_list.UnionWith(Intrigue.cards_2ed)
        End If
        If Alchemy_check.Checked Then
            pool_list.UnionWith(Alchemy.cards)
        End If
        If Prosperity_check.Checked Then
            pool_list.UnionWith(Prosperity.cards)
        End If
        If DarkAges_check.Checked Then
            pool_list.UnionWith(DarkAges.cards)
        End If
        If Adventures_check.Checked Then
            pool_list.UnionWith(Adventures.cards)
        End If
        If Empires_check.Checked Then
            pool_list.UnionWith(Empires.cards)
        End If
        If pool_list.Count > 0 Then
            If Veto_attack_check.Checked Then
                Veto_type(3)
            End If
            If Veto_curser_check.Checked Then
                Veto_type(4)
            End If
            If RadioButtonNone.Checked Then
                For index As Integer = 0 To 9
                    Dim picked_card = pool_list(rnd.Next(0, pool_list.Count))
                    ret_list.Add(picked_card)
                    pool_list.Remove(picked_card)
                Next
            ElseIf RadioButtonBase1.Checked Then
                temp_list.UnionWith(BaseSet.cards_common)
                temp_list.UnionWith(BaseSet.cards_1ed)
                Main_exp(temp_list)
                temp_list.Clear()
            ElseIf RadioButtonBase2.Checked Then
                temp_list.UnionWith(BaseSet.cards_common)
                temp_list.UnionWith(BaseSet.cards_2ed)
                Main_exp(temp_list)
                temp_list.Clear()
            ElseIf RadioButtonIntrigue1.Checked Then
                temp_list.UnionWith(Intrigue.cards_common)
                temp_list.UnionWith(Intrigue.cards_1ed)
                Main_exp(temp_list)
                temp_list.Clear()
            ElseIf RadioButtonIntrigue2.Checked Then
                temp_list.UnionWith(Intrigue.cards_common)
                temp_list.UnionWith(Intrigue.cards_2ed)
                Main_exp(temp_list)
                temp_list.Clear()
            ElseIf RadioButtonAlchemy.Checked Then
                Main_exp(Alchemy.cards)
            ElseIf RadioButtonProsperity.Checked Then
                Main_exp(Prosperity.cards)
            ElseIf RadioButtonDarkAges.Checked Then
                Main_exp(DarkAges.cards)
            ElseIf RadioButtonAdventures.Checked Then
                Main_exp(Adventures.cards)
            ElseIf RadioButtonEmpires.Checked Then
                Main_exp(Empires.cards)
            End If
            For Each item As String In ret_list
                Dim isolated_card_values = Split(item, ".")
                Return_list.Items.Add("Cost: " & isolated_card_values(2) & " " & isolated_card_values(1))
            Next
        Else
            Error_lbl.Text = "No expantions selected"
            Error_lbl.Visible = 1
        End If
    End Sub

    Private Sub Veto_btn_Click(sender As Object, e As EventArgs) Handles Veto_btn.Click
        If pool_list.Count > 0 And Return_list.SelectedIndex >= 0 And Return_list.SelectedItem <> split_line Then
            If Not veto_flag Then
                Return_list.Items.Add(split_line)
                veto_flag = 1
            End If
            Error_lbl.Visible = 0
            Return_list.Items.Remove(Return_list.SelectedItem)
            Dim picked_card As String = pool_list(rnd.Next(0, pool_list.Count))
            pool_list.Remove(picked_card)
            Dim isolated_card_values = Split(picked_card, ".")
            Return_list.Items.Add("Cost: " & isolated_card_values(2) & " " & isolated_card_values(1))
        ElseIf Return_list.SelectedIndex < 0 And pool_list.Count > 0 Or Return_list.SelectedItem = split_line Then
            Error_lbl.Text = "No cards selected"
            Error_lbl.Visible = 1
        Else
            Error_lbl.Text = "Not enough cards in pool"
            Error_lbl.Visible = 1
        End If
    End Sub
    Private Sub Error_lbl_Click(sender As Object, e As EventArgs) Handles Error_lbl.Click
        egg.Trigger()
    End Sub

    Private Sub BaseSet1ed_check_CheckedChanged(sender As Object, e As EventArgs) Handles BaseSet1ed_check.CheckedChanged
        Radio_state_change(RadioButtonBase1, BaseSet1ed_check)
    End Sub

    Private Sub BaseSet2ed_check_CheckedChanged(sender As Object, e As EventArgs) Handles BaseSet2ed_check.CheckedChanged
        Radio_state_change(RadioButtonBase2, BaseSet2ed_check)
    End Sub

    Private Sub Intrigue1ed_check_CheckedChanged(sender As Object, e As EventArgs) Handles Intrigue1ed_check.CheckedChanged
        Radio_state_change(RadioButtonIntrigue1, Intrigue1ed_check)
    End Sub

    Private Sub Intrigue2ed_check_CheckedChanged(sender As Object, e As EventArgs) Handles Intrigue2ed_check.CheckedChanged
        Radio_state_change(RadioButtonIntrigue2, Intrigue2ed_check)
    End Sub

    Private Sub Alchemy_check_CheckedChanged(sender As Object, e As EventArgs) Handles Alchemy_check.CheckedChanged
        Radio_state_change(RadioButtonAlchemy, Alchemy_check)
    End Sub

    Private Sub Prosperity_check_CheckedChanged(sender As Object, e As EventArgs) Handles Prosperity_check.CheckedChanged
        Radio_state_change(RadioButtonProsperity, Prosperity_check)
    End Sub

    Private Sub DarkAges_check_CheckedChanged(sender As Object, e As EventArgs) Handles DarkAges_check.CheckedChanged
        Radio_state_change(RadioButtonDarkAges, DarkAges_check)
    End Sub

    Private Sub Adventures_check_CheckedChanged(sender As Object, e As EventArgs) Handles Adventures_check.CheckedChanged
        Radio_state_change(RadioButtonAdventures, Adventures_check)
    End Sub

    Private Sub Empires_check_CheckedChanged(sender As Object, e As EventArgs) Handles Empires_check.CheckedChanged
        Radio_state_change(RadioButtonEmpires, Empires_check)
    End Sub
End Class
