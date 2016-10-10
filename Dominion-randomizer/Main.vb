﻿'Copyright (c) 2016 Liang Zhu

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
    Dim pool_list As New List(Of String)
    Dim ret_list As New List(Of String)
    Dim rnd = New Random()
    Dim veto_flag As Boolean = 0
    Dim split_line As String = "---New cards---"

    Private Sub Generate_btn_Click(sender As Object, e As EventArgs) Handles Generate_btn.Click
        pool_list.Clear()
        ret_list.Clear()
        Return_list.Items.Clear()
        Error_lbl.Visible = 0
        veto_flag = 0
        If Basedeck_check.Checked Then
            pool_list.AddRange(BaseSet2ed.cards)
        End If
        If Alchemy_check.Checked Then
            pool_list.AddRange(Alchemy.cards)
        End If
        If Prosperity_check.Checked Then
            pool_list.AddRange(Prosperity.cards)
        End If
        If pool_list.Count > 0 Then
            For index As Integer = 0 To 9
                Dim picked_card = pool_list(rnd.Next(0, pool_list.Count))
                ret_list.Add(picked_card)
                pool_list.Remove(picked_card)
            Next
            ret_list.Sort()
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
End Class