Public Class Form1
    Private Sub orderquantitynud_ValueChanged(sender As Object, e As EventArgs) Handles orderquantitynud.ValueChanged
        Dim qty, cop As Integer
        qty = orderquantitynud.Value
        cop = Val(costofpizzatxt.Text)
        If Hawayanrb.Checked = True Then
            costofpizzatxt.Text = qty * 550
        ElseIf Pepperonirb.Checked = True Then
            costofpizzatxt.Text = qty * 450
        ElseIf Beykonrb.Checked = True Then
            costofpizzatxt.Text = qty * 480
        ElseIf Veggierb.Checked = True Then
            costofpizzatxt.Text = qty * 450
        End If
    End Sub
    Private Sub storedineinrb_CheckedChanged(sender As Object, e As EventArgs) Handles storedineinrb.CheckedChanged
        If storedineinrb.Checked Then
            servingingb.Visible = True
            servingingb.Text = "Choose Branch:"
            Branchcombobox.Visible = True
            Deliveryaddresstxtbx.Visible = False
        End If
    End Sub

    Private Sub fordeliveryrb_CheckedChanged(sender As Object, e As EventArgs) Handles fordeliveryrb.CheckedChanged
        If fordeliveryrb.Checked Then
            servingingb.Visible = True
            servingingb.Text = "Enter Delivery Address:"
            Deliveryaddresstxtbx.Visible = True
            Branchcombobox.Visible = False
        End If
    End Sub
    Private Sub Hawayanrb_CheckedChanged(sender As Object, e As EventArgs) Handles Hawayanrb.CheckedChanged
        If Hawayanrb.Checked Then
            Toppingsgb.Enabled = True
            orderquantitylbl.Enabled = True
            orderquantitynud.Enabled = True
            costofpizzatxt.Text = "550"
        ElseIf Pepperonirb.Checked Then
            Toppingsgb.Enabled = True
            orderquantitylbl.Enabled = True
            orderquantitynud.Enabled = True
            costofpizzatxt.Text = "450"
        End If

    End Sub
    Private Sub Pepperonirb_CheckedChanged(sender As Object, e As EventArgs) Handles Pepperonirb.CheckedChanged
        If Hawayanrb.Checked Then
            Toppingsgb.Enabled = True
            orderquantitylbl.Enabled = True
            orderquantitynud.Enabled = True
            costofpizzatxt.Text = "550"
        ElseIf Pepperonirb.Checked Then
            Toppingsgb.Enabled = True
            orderquantitylbl.Enabled = True
            orderquantitynud.Enabled = True
            costofpizzatxt.Text = "450"
        End If
    End Sub
    Private Sub Beykonrb_CheckedChanged(sender As Object, e As EventArgs) Handles Beykonrb.CheckedChanged
        If Beykonrb.Checked Then
            Toppingsgb.Enabled = True
            orderquantitylbl.Enabled = True
            orderquantitynud.Enabled = True
            costofpizzatxt.Text = "480"
        ElseIf Veggierb.Checked Then
            Toppingsgb.Enabled = True
            orderquantitylbl.Enabled = True
            orderquantitynud.Enabled = True
            costofpizzatxt.Text = "450"
        End If
    End Sub
    Private Sub Veggierb_CheckedChanged(sender As Object, e As EventArgs) Handles Veggierb.CheckedChanged
        If Hawayanrb.Checked Then
            Toppingsgb.Enabled = True
            orderquantitylbl.Enabled = True
            orderquantitynud.Enabled = True
            costofpizzatxt.Text = "550"
        ElseIf Pepperonirb.Checked Then
            Toppingsgb.Enabled = True
            orderquantitylbl.Enabled = True
            orderquantitynud.Enabled = True
            costofpizzatxt.Text = "450"
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles onioncb.CheckedChanged
        Dim cot As Integer
        cot = Val(costoftoppingstxt.Text)
        If onioncb.Checked = True Then
            costoftoppingstxt.Text = cot + 25
        ElseIf onioncb.Checked = False Then
            costoftoppingstxt.Text = cot - 25
        End If
    End Sub

    Private Sub cheesecb_CheckedChanged(sender As Object, e As EventArgs) Handles cheesecb.CheckedChanged
        Dim cot As Integer
        cot = Val(costoftoppingstxt.Text)
        If cheesecb.Checked = True Then
            costoftoppingstxt.Text = cot + 25
        ElseIf cheesecb.Checked = False Then
            costoftoppingstxt.Text = cot - 25
        End If
    End Sub

    Private Sub Tomatocb_CheckedChanged(sender As Object, e As EventArgs) Handles Tomatocb.CheckedChanged
        Dim cot As Integer
        cot = Val(costoftoppingstxt.Text)
        If Tomatocb.Checked = True Then
            costoftoppingstxt.Text = cot + 30
        ElseIf Tomatocb.Checked = False Then
            costoftoppingstxt.Text = cot - 30
        End If
    End Sub

    Private Sub Pineapplecb_CheckedChanged(sender As Object, e As EventArgs) Handles Pineapplecb.CheckedChanged
        Dim cot As Integer
        cot = Val(costoftoppingstxt.Text)
        If Pineapplecb.Checked = True Then
            costoftoppingstxt.Text = cot + 30
        ElseIf Pineapplecb.Checked = False Then
            costoftoppingstxt.Text = cot - 30
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles clrbtn.Click
        costumernametxt.Text = " "
        orderquantitynud.Value = 1
        orderquantitylbl.Enabled = False
        orderquantitynud.Enabled = False
        costofpizzatxt.Text = " "
        costoftoppingstxt.Text = " "
        storedineinrb.Checked = False
        fordeliveryrb.Checked = False
        servingingb.Visible = False
        Hawayanrb.Checked = False
        Pepperonirb.Checked = False
        Beykonrb.Checked = False
        Veggierb.Checked = False
        onioncb.Checked = False
        cheesecb.Checked = False
        Tomatocb.Checked = False
        Pineapplecb.Checked = False
        costoftoppingstxt.Text = " "
        Toppingsgb.Enabled = False
    End Sub

    Private Sub exit_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Close()
    End Sub

    Private Sub Generetebtn_Click(sender As Object, e As EventArgs) Handles Generetebtn.Click
        Size = New Size(877, 497)
        Receiptgb.Visible = True
        costumernametxt.Enabled = False
        orderquantitynud.Enabled = False
        servingoutgb.Enabled = False
        pizzagb.Enabled = False
        Toppingsgb.Enabled = False
        Generetebtn.Enabled = False
        clrbtn.Enabled = False

        Dim cn, sdi, fd, sdb, fda As String
        cn = costumernametxt.Text
        sdi = "STORE DINE IN"
        fd = "FOR DELIVERY"
        sdb = Branchcombobox.SelectedItem
        fda = Deliveryaddresstxtbx.Text

        costumernamebill.Text = cn
        If storedineinrb.Checked = True Then
            servingbill.Text = sdi
            servingplacebill.Text = sdb
            placebill.Text = "  Branch:"
        ElseIf fordeliveryrb.Checked = True Then
            servingbill.Text = fd
            servingplacebill.Text = fda
            placebill.Text = "Address:"
        End If

        If Hawayanrb.Checked = True Then
            Pizzatypebill.Text = "Hawayan Pitsa W/ UNLI TEA"
            pizzapricebill.Text = "₱550.00"
        ElseIf Pepperonirb.Checked = True Then
            Pizzatypebill.Text = "Pepperoni Pitsa W/ UNLI TEA"
            pizzapricebill.Text = "₱450.00"
        ElseIf Beykonrb.Checked = True Then
            Pizzatypebill.Text = "Beykon Pitsa W/ UNLI TEA"
            pizzapricebill.Text = "₱480.00"
        ElseIf Veggierb.Checked = True Then
            Pizzatypebill.Text = "Veggie Pitsa W/ UNLI TEA"
            pizzapricebill.Text = "₱450.00"
        End If

        If onioncb.Checked = True Then
            onionbill.Visible = True
            onionprice.Visible = True
        End If
        If cheesecb.Checked = True Then
            cheesebill.Visible = True
            cheeseprice.Visible = True
        End If
        If Tomatocb.Checked = True Then
            tomatobill.Visible = True
            tomatoprice.Visible = True
        End If
        If Pineapplecb.Checked = True Then
            pineapplebill.Visible = True
            Pineappleprice.Visible = True
        End If

        Dim cop, cot, oq As Integer
        cop = Val(costofpizzatxt.Text)
        cot = Val(costoftoppingstxt.Text)
        oq = orderquantitynud.Value

        totalprice.Text = "₱" & cop + cot & ".00"
        orderquantitybill.Text = oq & "x"
    End Sub

    Private Sub cash_TextChanged(sender As Object, e As EventArgs) Handles cash.TextChanged
        Dim payment, tp, cop, cot As Integer
        payment = Val(cash.Text)
        cop = Val(costofpizzatxt.Text)
        cot = Val(costoftoppingstxt.Text)
        tp = cop + cot

        change.Text = "₱" & payment - tp & ".00"
    End Sub

    Private Sub confirmbtn_Click(sender As Object, e As EventArgs) Handles confirmbtn.Click
        Dim totalorder, payment, tp, cop, cot As Integer
        payment = Val(cash.Text)
        cop = Val(costofpizzatxt.Text)
        cot = Val(costoftoppingstxt.Text)
        tp = cop + cot
        totalorder = cop + cot

        If payment < tp Then
            MsgBox("Sorry!" & vbCrLf & "Please Enter Enough Payment!", MsgBoxStyle.Information, "ORDER STATUS")
        ElseIf totalorder > 0 Then
            MsgBox("Thank You for your order!" & vbCrLf & "Your Order is now in QUEUED", MsgBoxStyle.Information, "ORDER STATUS")
            Me.Close()
        Else
            MsgBox("Please Enter Order!", MsgBoxStyle.Information, "ORDER STATUS")
        End If

    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click
        Size = New Size(550, 497)
        costumernametxt.Enabled = True
        orderquantitynud.Enabled = True
        servingoutgb.Enabled = True
        pizzagb.Enabled = True
        Toppingsgb.Enabled = True
        Generetebtn.Enabled = True
        clrbtn.Enabled = True
    End Sub
End Class

'550 - Minimize | 877 - Maximize Form
