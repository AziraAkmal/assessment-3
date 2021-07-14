<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class borrower
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(borrower))
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.ph_num = New System.Windows.Forms.TextBox()
        Me.ic = New System.Windows.Forms.TextBox()
        Me.nme = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.search = New System.Windows.Forms.Button()
        Me.addd = New System.Windows.Forms.Button()
        Me.updte = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.list = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox5
        '
        Me.TextBox5.AcceptsReturn = True
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(833, 105)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(75, 22)
        Me.TextBox5.TabIndex = 10
        Me.TextBox5.Text = "0"
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(585, 129)
        Me.address.MaximumSize = New System.Drawing.Size(159, 140)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(159, 22)
        Me.address.TabIndex = 9
        '
        'ph_num
        '
        Me.ph_num.Location = New System.Drawing.Point(585, 62)
        Me.ph_num.Name = "ph_num"
        Me.ph_num.Size = New System.Drawing.Size(159, 22)
        Me.ph_num.TabIndex = 8
        '
        'ic
        '
        Me.ic.Location = New System.Drawing.Point(190, 129)
        Me.ic.Name = "ic"
        Me.ic.Size = New System.Drawing.Size(159, 22)
        Me.ic.TabIndex = 7
        '
        'nme
        '
        Me.nme.Location = New System.Drawing.Point(190, 65)
        Me.nme.Name = "nme"
        Me.nme.Size = New System.Drawing.Size(159, 22)
        Me.nme.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(38, 196)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 34)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "List of books " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that borrower have borrowed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(830, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 34)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No. of books" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " borrowed"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(547, -217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(456, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(147, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(63, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Borrower name"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(79, 471)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(791, 208)
        Me.DataGridView2.TabIndex = 12
        '
        'search
        '
        Me.search.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.search.Location = New System.Drawing.Point(531, 222)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(123, 42)
        Me.search.TabIndex = 1
        Me.search.Text = "SEARCH"
        Me.search.UseVisualStyleBackColor = False
        '
        'addd
        '
        Me.addd.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.addd.Location = New System.Drawing.Point(531, 326)
        Me.addd.Name = "addd"
        Me.addd.Size = New System.Drawing.Size(110, 42)
        Me.addd.TabIndex = 2
        Me.addd.Text = "ADD"
        Me.addd.UseVisualStyleBackColor = False
        '
        'updte
        '
        Me.updte.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.updte.Location = New System.Drawing.Point(755, 222)
        Me.updte.Name = "updte"
        Me.updte.Size = New System.Drawing.Size(115, 42)
        Me.updte.TabIndex = 3
        Me.updte.Text = "UPDATE"
        Me.updte.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Red
        Me.delete.Location = New System.Drawing.Point(770, 326)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(100, 42)
        Me.delete.TabIndex = 4
        Me.delete.Text = "DELETE"
        Me.delete.UseVisualStyleBackColor = False
        '
        'list
        '
        Me.list.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.list.Location = New System.Drawing.Point(12, 719)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(232, 39)
        Me.list.TabIndex = 5
        Me.list.Text = "LIST OF ALL BOOK BORROWED"
        Me.list.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.back.Location = New System.Drawing.Point(866, 933)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 42)
        Me.back.TabIndex = 6
        Me.back.Text = "BACK"
        Me.back.UseVisualStyleBackColor = False
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(12, 764)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 51
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(279, 150)
        Me.DataGridView3.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button1.Location = New System.Drawing.Point(585, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(232, 39)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "LIST OF BORROWERS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(41, 233)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(331, 160)
        Me.DataGridView1.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(497, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Address"
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(290, 764)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowHeadersWidth = 51
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(314, 150)
        Me.DataGridView4.TabIndex = 18
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(603, 764)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowHeadersWidth = 51
        Me.DataGridView5.RowTemplate.Height = 24
        Me.DataGridView5.Size = New System.Drawing.Size(315, 150)
        Me.DataGridView5.TabIndex = 19
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(833, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(75, 22)
        Me.TextBox1.TabIndex = 20
        Me.TextBox1.Text = "0"
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(378, 242)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(75, 22)
        Me.TextBox2.TabIndex = 21
        Me.TextBox2.Text = "0"
        '
        'borrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(977, 999)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.nme)
        Me.Controls.Add(Me.ic)
        Me.Controls.Add(Me.ph_num)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.list)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.updte)
        Me.Controls.Add(Me.addd)
        Me.Controls.Add(Me.search)
        Me.Name = "borrower"
        Me.Text = "borrower"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents address As TextBox
    Friend WithEvents ph_num As TextBox
    Friend WithEvents ic As TextBox
    Friend WithEvents nme As TextBox
    Friend WithEvents search As Button
    Friend WithEvents addd As Button
    Friend WithEvents updte As Button
    Friend WithEvents delete As Button
    Friend WithEvents list As Button
    Friend WithEvents back As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents DataGridView5 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
