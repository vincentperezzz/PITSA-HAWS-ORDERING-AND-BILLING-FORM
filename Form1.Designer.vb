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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Costofpizzalbl = New System.Windows.Forms.Label()
        Me.Costoftoppingslbl = New System.Windows.Forms.Label()
        Me.costumernametxt = New System.Windows.Forms.TextBox()
        Me.costofpizzatxt = New System.Windows.Forms.TextBox()
        Me.costoftoppingstxt = New System.Windows.Forms.TextBox()
        Me.orderquantitylbl = New System.Windows.Forms.Label()
        Me.servingoutgb = New System.Windows.Forms.GroupBox()
        Me.servingingb = New System.Windows.Forms.GroupBox()
        Me.Branchcombobox = New System.Windows.Forms.ComboBox()
        Me.Deliveryaddresstxtbx = New System.Windows.Forms.TextBox()
        Me.fordeliveryrb = New System.Windows.Forms.RadioButton()
        Me.storedineinrb = New System.Windows.Forms.RadioButton()
        Me.pizzagb = New System.Windows.Forms.GroupBox()
        Me.Veggierb = New System.Windows.Forms.RadioButton()
        Me.Beykonrb = New System.Windows.Forms.RadioButton()
        Me.Pepperonirb = New System.Windows.Forms.RadioButton()
        Me.Hawayanrb = New System.Windows.Forms.RadioButton()
        Me.Toppingsgb = New System.Windows.Forms.GroupBox()
        Me.Pineapplecb = New System.Windows.Forms.CheckBox()
        Me.Tomatocb = New System.Windows.Forms.CheckBox()
        Me.cheesecb = New System.Windows.Forms.CheckBox()
        Me.onioncb = New System.Windows.Forms.CheckBox()
        Me.Generetebtn = New System.Windows.Forms.Button()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.Receiptgb = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.editbtn = New System.Windows.Forms.Button()
        Me.confirmbtn = New System.Windows.Forms.Button()
        Me.cash = New System.Windows.Forms.TextBox()
        Me.servingplacebill = New System.Windows.Forms.Label()
        Me.servingbill = New System.Windows.Forms.Label()
        Me.placebill = New System.Windows.Forms.Label()
        Me.costumernamebill = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.change = New System.Windows.Forms.Label()
        Me.Pineappleprice = New System.Windows.Forms.Label()
        Me.totalprice = New System.Windows.Forms.Label()
        Me.tomatoprice = New System.Windows.Forms.Label()
        Me.cheeseprice = New System.Windows.Forms.Label()
        Me.onionprice = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.pizzapricebill = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.pineapplebill = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.tomatobill = New System.Windows.Forms.Label()
        Me.cheesebill = New System.Windows.Forms.Label()
        Me.onionbill = New System.Windows.Forms.Label()
        Me.Pizzatypebill = New System.Windows.Forms.Label()
        Me.orderquantitybill = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.clrbtn = New System.Windows.Forms.Button()
        Me.orderquantitynud = New System.Windows.Forms.NumericUpDown()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.servingoutgb.SuspendLayout()
        Me.servingingb.SuspendLayout()
        Me.pizzagb.SuspendLayout()
        Me.Toppingsgb.SuspendLayout()
        Me.Receiptgb.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orderquantitynud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PITSA_HAWS_ORDERING_AND_BILLING_FORM.My.Resources.Resources.PITSA_HAWS_LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("KG HAPPY Solid", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(97, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(342, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ORDERING AND BILLING FORM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Costumer Name:"
        '
        'Costofpizzalbl
        '
        Me.Costofpizzalbl.AutoSize = True
        Me.Costofpizzalbl.Location = New System.Drawing.Point(330, 113)
        Me.Costofpizzalbl.Name = "Costofpizzalbl"
        Me.Costofpizzalbl.Size = New System.Drawing.Size(77, 15)
        Me.Costofpizzalbl.TabIndex = 2
        Me.Costofpizzalbl.Text = "Cost of Pizza:"
        '
        'Costoftoppingslbl
        '
        Me.Costoftoppingslbl.AutoSize = True
        Me.Costoftoppingslbl.Location = New System.Drawing.Point(308, 142)
        Me.Costoftoppingslbl.Name = "Costoftoppingslbl"
        Me.Costoftoppingslbl.Size = New System.Drawing.Size(99, 15)
        Me.Costoftoppingslbl.TabIndex = 2
        Me.Costoftoppingslbl.Text = "Cost of Toppings:"
        '
        'costumernametxt
        '
        Me.costumernametxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.costumernametxt.Location = New System.Drawing.Point(127, 110)
        Me.costumernametxt.Name = "costumernametxt"
        Me.costumernametxt.Size = New System.Drawing.Size(170, 23)
        Me.costumernametxt.TabIndex = 1
        '
        'costofpizzatxt
        '
        Me.costofpizzatxt.Location = New System.Drawing.Point(413, 110)
        Me.costofpizzatxt.Name = "costofpizzatxt"
        Me.costofpizzatxt.ReadOnly = True
        Me.costofpizzatxt.Size = New System.Drawing.Size(103, 23)
        Me.costofpizzatxt.TabIndex = 0
        Me.costofpizzatxt.TabStop = False
        '
        'costoftoppingstxt
        '
        Me.costoftoppingstxt.Location = New System.Drawing.Point(413, 139)
        Me.costoftoppingstxt.Name = "costoftoppingstxt"
        Me.costoftoppingstxt.ReadOnly = True
        Me.costoftoppingstxt.Size = New System.Drawing.Size(103, 23)
        Me.costoftoppingstxt.TabIndex = 0
        Me.costoftoppingstxt.TabStop = False
        '
        'orderquantitylbl
        '
        Me.orderquantitylbl.AutoSize = True
        Me.orderquantitylbl.Enabled = False
        Me.orderquantitylbl.Location = New System.Drawing.Point(28, 142)
        Me.orderquantitylbl.Name = "orderquantitylbl"
        Me.orderquantitylbl.Size = New System.Drawing.Size(89, 15)
        Me.orderquantitylbl.TabIndex = 2
        Me.orderquantitylbl.Text = "Order Quantity:"
        '
        'servingoutgb
        '
        Me.servingoutgb.Controls.Add(Me.servingingb)
        Me.servingoutgb.Controls.Add(Me.fordeliveryrb)
        Me.servingoutgb.Controls.Add(Me.storedineinrb)
        Me.servingoutgb.Location = New System.Drawing.Point(20, 174)
        Me.servingoutgb.Name = "servingoutgb"
        Me.servingoutgb.Size = New System.Drawing.Size(496, 80)
        Me.servingoutgb.TabIndex = 4
        Me.servingoutgb.TabStop = False
        Me.servingoutgb.Text = "Serving"
        '
        'servingingb
        '
        Me.servingingb.Controls.Add(Me.Branchcombobox)
        Me.servingingb.Controls.Add(Me.Deliveryaddresstxtbx)
        Me.servingingb.Location = New System.Drawing.Point(143, 15)
        Me.servingingb.Name = "servingingb"
        Me.servingingb.Size = New System.Drawing.Size(347, 59)
        Me.servingingb.TabIndex = 1
        Me.servingingb.TabStop = False
        Me.servingingb.Text = "Choose Branch:"
        Me.servingingb.Visible = False
        '
        'Branchcombobox
        '
        Me.Branchcombobox.FormattingEnabled = True
        Me.Branchcombobox.Items.AddRange(New Object() {"SARIAYA BRANCH", "LUCENA BRANCH", "CANDELARIA BRANCH"})
        Me.Branchcombobox.Location = New System.Drawing.Point(13, 22)
        Me.Branchcombobox.Name = "Branchcombobox"
        Me.Branchcombobox.Size = New System.Drawing.Size(328, 23)
        Me.Branchcombobox.TabIndex = 4
        '
        'Deliveryaddresstxtbx
        '
        Me.Deliveryaddresstxtbx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Deliveryaddresstxtbx.Location = New System.Drawing.Point(13, 22)
        Me.Deliveryaddresstxtbx.Name = "Deliveryaddresstxtbx"
        Me.Deliveryaddresstxtbx.Size = New System.Drawing.Size(328, 23)
        Me.Deliveryaddresstxtbx.TabIndex = 4
        '
        'fordeliveryrb
        '
        Me.fordeliveryrb.AutoSize = True
        Me.fordeliveryrb.Location = New System.Drawing.Point(24, 48)
        Me.fordeliveryrb.Name = "fordeliveryrb"
        Me.fordeliveryrb.Size = New System.Drawing.Size(100, 19)
        Me.fordeliveryrb.TabIndex = 3
        Me.fordeliveryrb.TabStop = True
        Me.fordeliveryrb.Text = "FOR DELIVERY"
        Me.fordeliveryrb.UseVisualStyleBackColor = True
        '
        'storedineinrb
        '
        Me.storedineinrb.AutoSize = True
        Me.storedineinrb.Location = New System.Drawing.Point(24, 22)
        Me.storedineinrb.Name = "storedineinrb"
        Me.storedineinrb.Size = New System.Drawing.Size(102, 19)
        Me.storedineinrb.TabIndex = 2
        Me.storedineinrb.TabStop = True
        Me.storedineinrb.Text = "STORE DINE IN"
        Me.storedineinrb.UseVisualStyleBackColor = True
        '
        'pizzagb
        '
        Me.pizzagb.Controls.Add(Me.Veggierb)
        Me.pizzagb.Controls.Add(Me.Beykonrb)
        Me.pizzagb.Controls.Add(Me.Pepperonirb)
        Me.pizzagb.Controls.Add(Me.Hawayanrb)
        Me.pizzagb.Location = New System.Drawing.Point(20, 266)
        Me.pizzagb.Name = "pizzagb"
        Me.pizzagb.Size = New System.Drawing.Size(245, 128)
        Me.pizzagb.TabIndex = 5
        Me.pizzagb.TabStop = False
        Me.pizzagb.Text = "Pizza Type:"
        '
        'Veggierb
        '
        Me.Veggierb.AutoSize = True
        Me.Veggierb.Location = New System.Drawing.Point(21, 97)
        Me.Veggierb.Name = "Veggierb"
        Me.Veggierb.Size = New System.Drawing.Size(159, 19)
        Me.Veggierb.TabIndex = 8
        Me.Veggierb.TabStop = True
        Me.Veggierb.Text = "Veggie Pitsa W/ UNLI TEA"
        Me.Veggierb.UseVisualStyleBackColor = True
        '
        'Beykonrb
        '
        Me.Beykonrb.AutoSize = True
        Me.Beykonrb.Location = New System.Drawing.Point(21, 72)
        Me.Beykonrb.Name = "Beykonrb"
        Me.Beykonrb.Size = New System.Drawing.Size(163, 19)
        Me.Beykonrb.TabIndex = 7
        Me.Beykonrb.TabStop = True
        Me.Beykonrb.Text = "Beykon Pitsa W/ UNLI TEA"
        Me.Beykonrb.UseVisualStyleBackColor = True
        '
        'Pepperonirb
        '
        Me.Pepperonirb.AutoSize = True
        Me.Pepperonirb.Location = New System.Drawing.Point(21, 47)
        Me.Pepperonirb.Name = "Pepperonirb"
        Me.Pepperonirb.Size = New System.Drawing.Size(178, 19)
        Me.Pepperonirb.TabIndex = 6
        Me.Pepperonirb.TabStop = True
        Me.Pepperonirb.Text = "Pepperoni Pitsa W/ UNLI TEA"
        Me.Pepperonirb.UseVisualStyleBackColor = True
        '
        'Hawayanrb
        '
        Me.Hawayanrb.AutoSize = True
        Me.Hawayanrb.Location = New System.Drawing.Point(21, 22)
        Me.Hawayanrb.Name = "Hawayanrb"
        Me.Hawayanrb.Size = New System.Drawing.Size(173, 19)
        Me.Hawayanrb.TabIndex = 5
        Me.Hawayanrb.TabStop = True
        Me.Hawayanrb.Text = "Hawayan Pitsa W/ UNLI TEA"
        Me.Hawayanrb.UseVisualStyleBackColor = True
        '
        'Toppingsgb
        '
        Me.Toppingsgb.Controls.Add(Me.Pineapplecb)
        Me.Toppingsgb.Controls.Add(Me.Tomatocb)
        Me.Toppingsgb.Controls.Add(Me.cheesecb)
        Me.Toppingsgb.Controls.Add(Me.onioncb)
        Me.Toppingsgb.Enabled = False
        Me.Toppingsgb.Location = New System.Drawing.Point(271, 266)
        Me.Toppingsgb.Name = "Toppingsgb"
        Me.Toppingsgb.Size = New System.Drawing.Size(245, 128)
        Me.Toppingsgb.TabIndex = 5
        Me.Toppingsgb.TabStop = False
        Me.Toppingsgb.Text = "Toppings:"
        '
        'Pineapplecb
        '
        Me.Pineapplecb.AutoSize = True
        Me.Pineapplecb.Location = New System.Drawing.Point(26, 98)
        Me.Pineapplecb.Name = "Pineapplecb"
        Me.Pineapplecb.Size = New System.Drawing.Size(78, 19)
        Me.Pineapplecb.TabIndex = 13
        Me.Pineapplecb.Text = "Pineapple"
        Me.Pineapplecb.UseVisualStyleBackColor = True
        '
        'Tomatocb
        '
        Me.Tomatocb.AutoSize = True
        Me.Tomatocb.Location = New System.Drawing.Point(26, 73)
        Me.Tomatocb.Name = "Tomatocb"
        Me.Tomatocb.Size = New System.Drawing.Size(66, 19)
        Me.Tomatocb.TabIndex = 12
        Me.Tomatocb.Text = "Tomato"
        Me.Tomatocb.UseVisualStyleBackColor = True
        '
        'cheesecb
        '
        Me.cheesecb.AutoSize = True
        Me.cheesecb.Location = New System.Drawing.Point(26, 48)
        Me.cheesecb.Name = "cheesecb"
        Me.cheesecb.Size = New System.Drawing.Size(64, 19)
        Me.cheesecb.TabIndex = 11
        Me.cheesecb.Text = "Cheese"
        Me.cheesecb.UseVisualStyleBackColor = True
        '
        'onioncb
        '
        Me.onioncb.AutoSize = True
        Me.onioncb.Location = New System.Drawing.Point(26, 23)
        Me.onioncb.Name = "onioncb"
        Me.onioncb.Size = New System.Drawing.Size(59, 19)
        Me.onioncb.TabIndex = 10
        Me.onioncb.Text = "Onion"
        Me.onioncb.UseVisualStyleBackColor = True
        '
        'Generetebtn
        '
        Me.Generetebtn.Location = New System.Drawing.Point(20, 404)
        Me.Generetebtn.Name = "Generetebtn"
        Me.Generetebtn.Size = New System.Drawing.Size(411, 35)
        Me.Generetebtn.TabIndex = 14
        Me.Generetebtn.Text = "GENERATE BILL"
        Me.Generetebtn.UseVisualStyleBackColor = True
        '
        'exitbtn
        '
        Me.exitbtn.Location = New System.Drawing.Point(437, 423)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(75, 23)
        Me.exitbtn.TabIndex = 16
        Me.exitbtn.Text = "EXIT"
        Me.exitbtn.UseVisualStyleBackColor = True
        '
        'Receiptgb
        '
        Me.Receiptgb.Controls.Add(Me.Label5)
        Me.Receiptgb.Controls.Add(Me.Label4)
        Me.Receiptgb.Controls.Add(Me.Label3)
        Me.Receiptgb.Controls.Add(Me.PictureBox2)
        Me.Receiptgb.Controls.Add(Me.editbtn)
        Me.Receiptgb.Controls.Add(Me.confirmbtn)
        Me.Receiptgb.Controls.Add(Me.cash)
        Me.Receiptgb.Controls.Add(Me.servingplacebill)
        Me.Receiptgb.Controls.Add(Me.servingbill)
        Me.Receiptgb.Controls.Add(Me.placebill)
        Me.Receiptgb.Controls.Add(Me.costumernamebill)
        Me.Receiptgb.Controls.Add(Me.Label11)
        Me.Receiptgb.Controls.Add(Me.change)
        Me.Receiptgb.Controls.Add(Me.Pineappleprice)
        Me.Receiptgb.Controls.Add(Me.totalprice)
        Me.Receiptgb.Controls.Add(Me.tomatoprice)
        Me.Receiptgb.Controls.Add(Me.cheeseprice)
        Me.Receiptgb.Controls.Add(Me.onionprice)
        Me.Receiptgb.Controls.Add(Me.Label50)
        Me.Receiptgb.Controls.Add(Me.pizzapricebill)
        Me.Receiptgb.Controls.Add(Me.Label49)
        Me.Receiptgb.Controls.Add(Me.pineapplebill)
        Me.Receiptgb.Controls.Add(Me.Label48)
        Me.Receiptgb.Controls.Add(Me.tomatobill)
        Me.Receiptgb.Controls.Add(Me.cheesebill)
        Me.Receiptgb.Controls.Add(Me.onionbill)
        Me.Receiptgb.Controls.Add(Me.Pizzatypebill)
        Me.Receiptgb.Controls.Add(Me.orderquantitybill)
        Me.Receiptgb.Controls.Add(Me.Label12)
        Me.Receiptgb.Controls.Add(Me.Label13)
        Me.Receiptgb.Controls.Add(Me.Label47)
        Me.Receiptgb.Controls.Add(Me.Label17)
        Me.Receiptgb.Controls.Add(Me.Label52)
        Me.Receiptgb.Controls.Add(Me.Label14)
        Me.Receiptgb.Controls.Add(Me.Label15)
        Me.Receiptgb.Location = New System.Drawing.Point(534, 12)
        Me.Receiptgb.Name = "Receiptgb"
        Me.Receiptgb.Size = New System.Drawing.Size(311, 431)
        Me.Receiptgb.TabIndex = 8
        Me.Receiptgb.TabStop = False
        Me.Receiptgb.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "-------------------"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "-------------------"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "THANK YOU!"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PITSA_HAWS_ORDERING_AND_BILLING_FORM.My.Resources.Resources.barcode
        Me.PictureBox2.Location = New System.Drawing.Point(34, 309)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(240, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'editbtn
        '
        Me.editbtn.Location = New System.Drawing.Point(199, 387)
        Me.editbtn.Name = "editbtn"
        Me.editbtn.Size = New System.Drawing.Size(101, 32)
        Me.editbtn.TabIndex = 7
        Me.editbtn.Text = "EDIT ORDER"
        Me.editbtn.UseVisualStyleBackColor = True
        '
        'confirmbtn
        '
        Me.confirmbtn.Location = New System.Drawing.Point(11, 387)
        Me.confirmbtn.Name = "confirmbtn"
        Me.confirmbtn.Size = New System.Drawing.Size(180, 32)
        Me.confirmbtn.TabIndex = 7
        Me.confirmbtn.Text = "CONFIRM ORDER"
        Me.confirmbtn.UseVisualStyleBackColor = True
        '
        'cash
        '
        Me.cash.Location = New System.Drawing.Point(229, 223)
        Me.cash.Name = "cash"
        Me.cash.Size = New System.Drawing.Size(48, 23)
        Me.cash.TabIndex = 3
        '
        'servingplacebill
        '
        Me.servingplacebill.AutoSize = True
        Me.servingplacebill.Location = New System.Drawing.Point(102, 90)
        Me.servingplacebill.Name = "servingplacebill"
        Me.servingplacebill.Size = New System.Drawing.Size(0, 15)
        Me.servingplacebill.TabIndex = 2
        '
        'servingbill
        '
        Me.servingbill.AutoSize = True
        Me.servingbill.Location = New System.Drawing.Point(102, 72)
        Me.servingbill.Name = "servingbill"
        Me.servingbill.Size = New System.Drawing.Size(0, 15)
        Me.servingbill.TabIndex = 2
        '
        'placebill
        '
        Me.placebill.AutoSize = True
        Me.placebill.Location = New System.Drawing.Point(44, 90)
        Me.placebill.Name = "placebill"
        Me.placebill.Size = New System.Drawing.Size(0, 15)
        Me.placebill.TabIndex = 2
        '
        'costumernamebill
        '
        Me.costumernamebill.AutoSize = True
        Me.costumernamebill.Location = New System.Drawing.Point(102, 55)
        Me.costumernamebill.Name = "costumernamebill"
        Me.costumernamebill.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.costumernamebill.Size = New System.Drawing.Size(0, 15)
        Me.costumernamebill.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(47, 72)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Serving:"
        '
        'change
        '
        Me.change.AutoSize = True
        Me.change.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.change.Location = New System.Drawing.Point(226, 249)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(52, 15)
        Me.change.TabIndex = 2
        Me.change.Text = "₱  00.00"
        '
        'Pineappleprice
        '
        Me.Pineappleprice.AutoSize = True
        Me.Pineappleprice.Location = New System.Drawing.Point(229, 175)
        Me.Pineappleprice.Name = "Pineappleprice"
        Me.Pineappleprice.Size = New System.Drawing.Size(47, 15)
        Me.Pineappleprice.TabIndex = 2
        Me.Pineappleprice.Text = "₱  40.00"
        Me.Pineappleprice.Visible = False
        '
        'totalprice
        '
        Me.totalprice.AutoSize = True
        Me.totalprice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.totalprice.Location = New System.Drawing.Point(226, 207)
        Me.totalprice.Name = "totalprice"
        Me.totalprice.Size = New System.Drawing.Size(52, 15)
        Me.totalprice.TabIndex = 2
        Me.totalprice.Text = "₱  00.00"
        '
        'tomatoprice
        '
        Me.tomatoprice.AutoSize = True
        Me.tomatoprice.Location = New System.Drawing.Point(229, 160)
        Me.tomatoprice.Name = "tomatoprice"
        Me.tomatoprice.Size = New System.Drawing.Size(47, 15)
        Me.tomatoprice.TabIndex = 2
        Me.tomatoprice.Text = "₱  30.00"
        Me.tomatoprice.Visible = False
        '
        'cheeseprice
        '
        Me.cheeseprice.AutoSize = True
        Me.cheeseprice.Location = New System.Drawing.Point(229, 145)
        Me.cheeseprice.Name = "cheeseprice"
        Me.cheeseprice.Size = New System.Drawing.Size(47, 15)
        Me.cheeseprice.TabIndex = 2
        Me.cheeseprice.Text = "₱  25.00"
        Me.cheeseprice.Visible = False
        '
        'onionprice
        '
        Me.onionprice.AutoSize = True
        Me.onionprice.Location = New System.Drawing.Point(229, 130)
        Me.onionprice.Name = "onionprice"
        Me.onionprice.Size = New System.Drawing.Size(47, 15)
        Me.onionprice.TabIndex = 2
        Me.onionprice.Text = "₱  25.00"
        Me.onionprice.Visible = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(34, 250)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(51, 15)
        Me.Label50.TabIndex = 2
        Me.Label50.Text = "Change:"
        '
        'pizzapricebill
        '
        Me.pizzapricebill.AutoSize = True
        Me.pizzapricebill.Location = New System.Drawing.Point(229, 115)
        Me.pizzapricebill.Name = "pizzapricebill"
        Me.pizzapricebill.Size = New System.Drawing.Size(47, 15)
        Me.pizzapricebill.TabIndex = 2
        Me.pizzapricebill.Text = "₱  00.00"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(34, 228)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(104, 15)
        Me.Label49.TabIndex = 2
        Me.Label49.Text = "Payment Amount:"
        '
        'pineapplebill
        '
        Me.pineapplebill.AutoSize = True
        Me.pineapplebill.Location = New System.Drawing.Point(34, 176)
        Me.pineapplebill.Name = "pineapplebill"
        Me.pineapplebill.Size = New System.Drawing.Size(59, 15)
        Me.pineapplebill.TabIndex = 2
        Me.pineapplebill.Text = "Pineapple"
        Me.pineapplebill.Visible = False
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(34, 208)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(82, 15)
        Me.Label48.TabIndex = 2
        Me.Label48.Text = "Total Amount:"
        '
        'tomatobill
        '
        Me.tomatobill.AutoSize = True
        Me.tomatobill.Location = New System.Drawing.Point(34, 161)
        Me.tomatobill.Name = "tomatobill"
        Me.tomatobill.Size = New System.Drawing.Size(47, 15)
        Me.tomatobill.TabIndex = 2
        Me.tomatobill.Text = "Tomato"
        Me.tomatobill.Visible = False
        '
        'cheesebill
        '
        Me.cheesebill.AutoSize = True
        Me.cheesebill.Location = New System.Drawing.Point(34, 146)
        Me.cheesebill.Name = "cheesebill"
        Me.cheesebill.Size = New System.Drawing.Size(45, 15)
        Me.cheesebill.TabIndex = 2
        Me.cheesebill.Text = "Cheese"
        Me.cheesebill.Visible = False
        '
        'onionbill
        '
        Me.onionbill.AutoSize = True
        Me.onionbill.Location = New System.Drawing.Point(34, 131)
        Me.onionbill.Name = "onionbill"
        Me.onionbill.Size = New System.Drawing.Size(40, 15)
        Me.onionbill.TabIndex = 2
        Me.onionbill.Text = "Onion"
        Me.onionbill.Visible = False
        '
        'Pizzatypebill
        '
        Me.Pizzatypebill.AutoSize = True
        Me.Pizzatypebill.Location = New System.Drawing.Point(34, 116)
        Me.Pizzatypebill.Name = "Pizzatypebill"
        Me.Pizzatypebill.Size = New System.Drawing.Size(56, 15)
        Me.Pizzatypebill.TabIndex = 2
        Me.Pizzatypebill.Text = "No Order"
        '
        'orderquantitybill
        '
        Me.orderquantitybill.AutoSize = True
        Me.orderquantitybill.Location = New System.Drawing.Point(9, 116)
        Me.orderquantitybill.Name = "orderquantitybill"
        Me.orderquantitybill.Size = New System.Drawing.Size(19, 15)
        Me.orderquantitybill.TabIndex = 2
        Me.orderquantitybill.Text = "0x"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(34, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Costumer:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(129, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "RECEIPT "
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(14, 191)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(287, 15)
        Me.Label47.TabIndex = 0
        Me.Label47.Text = "==================================="
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(9, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(292, 15)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "---------------------------------------------------------"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(9, 266)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(292, 15)
        Me.Label52.TabIndex = 0
        Me.Label52.Text = "*********************************************************"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(292, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "*********************************************************"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(292, 15)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "*********************************************************"
        '
        'clrbtn
        '
        Me.clrbtn.Location = New System.Drawing.Point(437, 398)
        Me.clrbtn.Name = "clrbtn"
        Me.clrbtn.Size = New System.Drawing.Size(75, 23)
        Me.clrbtn.TabIndex = 15
        Me.clrbtn.Text = "CLEAR"
        Me.clrbtn.UseVisualStyleBackColor = True
        '
        'orderquantitynud
        '
        Me.orderquantitynud.Enabled = False
        Me.orderquantitynud.Location = New System.Drawing.Point(127, 140)
        Me.orderquantitynud.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.orderquantitynud.Name = "orderquantitynud"
        Me.orderquantitynud.Size = New System.Drawing.Size(170, 23)
        Me.orderquantitynud.TabIndex = 9
        Me.orderquantitynud.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 458)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Receiptgb)
        Me.Controls.Add(Me.clrbtn)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.Generetebtn)
        Me.Controls.Add(Me.Toppingsgb)
        Me.Controls.Add(Me.pizzagb)
        Me.Controls.Add(Me.servingoutgb)
        Me.Controls.Add(Me.costoftoppingstxt)
        Me.Controls.Add(Me.costofpizzatxt)
        Me.Controls.Add(Me.costumernametxt)
        Me.Controls.Add(Me.Costoftoppingslbl)
        Me.Controls.Add(Me.orderquantitylbl)
        Me.Controls.Add(Me.Costofpizzalbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.orderquantitynud)
        Me.Name = "Form1"
        Me.Text = "PITSA HAWS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.servingoutgb.ResumeLayout(False)
        Me.servingoutgb.PerformLayout()
        Me.servingingb.ResumeLayout(False)
        Me.servingingb.PerformLayout()
        Me.pizzagb.ResumeLayout(False)
        Me.pizzagb.PerformLayout()
        Me.Toppingsgb.ResumeLayout(False)
        Me.Toppingsgb.PerformLayout()
        Me.Receiptgb.ResumeLayout(False)
        Me.Receiptgb.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orderquantitynud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Costofpizzalbl As Label
    Friend WithEvents Costoftoppingslbl As Label
    Friend WithEvents costumernametxt As TextBox
    Friend WithEvents costofpizzatxt As TextBox
    Friend WithEvents costoftoppingstxt As TextBox
    Friend WithEvents orderquantitylbl As Label
    Friend WithEvents servingoutgb As GroupBox
    Friend WithEvents servingingb As GroupBox
    Friend WithEvents Deliveryaddresstxtbx As TextBox
    Friend WithEvents Branchcombobox As ComboBox
    Friend WithEvents fordeliveryrb As RadioButton
    Friend WithEvents storedineinrb As RadioButton
    Friend WithEvents pizzagb As GroupBox
    Friend WithEvents Veggierb As RadioButton
    Friend WithEvents Beykonrb As RadioButton
    Friend WithEvents Pepperonirb As RadioButton
    Friend WithEvents Hawayanrb As RadioButton
    Friend WithEvents Toppingsgb As GroupBox
    Friend WithEvents Pineapplecb As CheckBox
    Friend WithEvents Tomatocb As CheckBox
    Friend WithEvents cheesecb As CheckBox
    Friend WithEvents onioncb As CheckBox
    Friend WithEvents Generetebtn As Button
    Friend WithEvents exitbtn As Button
    Friend WithEvents Receiptgb As GroupBox
    Friend WithEvents servingplacebill As Label
    Friend WithEvents servingbill As Label
    Friend WithEvents placebill As Label
    Friend WithEvents costumernamebill As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Pineappleprice As Label
    Friend WithEvents tomatoprice As Label
    Friend WithEvents cheeseprice As Label
    Friend WithEvents onionprice As Label
    Friend WithEvents pizzapricebill As Label
    Friend WithEvents pineapplebill As Label
    Friend WithEvents tomatobill As Label
    Friend WithEvents cheesebill As Label
    Friend WithEvents onionbill As Label
    Friend WithEvents Pizzatypebill As Label
    Friend WithEvents orderquantitybill As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents confirmbtn As Button
    Friend WithEvents cash As TextBox
    Friend WithEvents change As Label
    Friend WithEvents totalprice As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents clrbtn As Button
    Friend WithEvents orderquantitynud As NumericUpDown
    Friend WithEvents editbtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
