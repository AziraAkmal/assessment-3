<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class bookdetails
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(bookdetails))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BookdDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookdDataSet = New assessment_3.bookdDataSet()
        Me.search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.isbn = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.year = New System.Windows.Forms.TextBox()
        Me.title = New System.Windows.Forms.TextBox()
        Me.author = New System.Windows.Forms.TextBox()
        Me.publisher = New System.Windows.Forms.TextBox()
        Me.category = New System.Windows.Forms.TextBox()
        Me.add = New System.Windows.Forms.Button()
        Me.updte = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.list = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookdDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookdDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 291)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(983, 232)
        Me.DataGridView1.TabIndex = 0
        '
        'BookdDataSetBindingSource
        '
        Me.BookdDataSetBindingSource.DataSource = Me.BookdDataSet
        Me.BookdDataSetBindingSource.Position = 0
        '
        'BookdDataSet
        '
        Me.BookdDataSet.DataSetName = "bookdDataSet"
        Me.BookdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'search
        '
        Me.search.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.search.Location = New System.Drawing.Point(573, 114)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(85, 34)
        Me.search.TabIndex = 1
        Me.search.Text = "SEARCH"
        Me.search.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(125, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ISBN"
        '
        'isbn
        '
        Me.isbn.Location = New System.Drawing.Point(187, 109)
        Me.isbn.Name = "isbn"
        Me.isbn.Size = New System.Drawing.Size(100, 22)
        Me.isbn.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "YEAR OF PUBLICATION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "TITLE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "AUTHOR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(306, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "PUBLISHER"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(306, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "CATEGORY"
        '
        'year
        '
        Me.year.Location = New System.Drawing.Point(187, 176)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(100, 22)
        Me.year.TabIndex = 9
        '
        'title
        '
        Me.title.Location = New System.Drawing.Point(187, 250)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(100, 22)
        Me.title.TabIndex = 10
        '
        'author
        '
        Me.author.Location = New System.Drawing.Point(408, 111)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(130, 22)
        Me.author.TabIndex = 11
        '
        'publisher
        '
        Me.publisher.Location = New System.Drawing.Point(408, 176)
        Me.publisher.Name = "publisher"
        Me.publisher.Size = New System.Drawing.Size(130, 22)
        Me.publisher.TabIndex = 12
        '
        'category
        '
        Me.category.Location = New System.Drawing.Point(408, 247)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(130, 22)
        Me.category.TabIndex = 13
        '
        'add
        '
        Me.add.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.add.Location = New System.Drawing.Point(573, 176)
        Me.add.Name = "add"
        Me.add.Size = New System.Drawing.Size(85, 34)
        Me.add.TabIndex = 14
        Me.add.Text = "ADD"
        Me.add.UseVisualStyleBackColor = False
        '
        'updte
        '
        Me.updte.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.updte.Location = New System.Drawing.Point(710, 114)
        Me.updte.Name = "updte"
        Me.updte.Size = New System.Drawing.Size(85, 34)
        Me.updte.TabIndex = 15
        Me.updte.Text = "UPDATE"
        Me.updte.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.back.Location = New System.Drawing.Point(848, 229)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(85, 34)
        Me.back.TabIndex = 17
        Me.back.Text = "BACK"
        Me.back.UseVisualStyleBackColor = False
        '
        'list
        '
        Me.list.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.list.Location = New System.Drawing.Point(593, 238)
        Me.list.Name = "list"
        Me.list.Size = New System.Drawing.Size(182, 34)
        Me.list.TabIndex = 18
        Me.list.Text = "LIST OF BOOKS"
        Me.list.UseVisualStyleBackColor = False
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Red
        Me.delete.Location = New System.Drawing.Point(710, 176)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(85, 34)
        Me.delete.TabIndex = 19
        Me.delete.Text = "DELETE"
        Me.delete.UseVisualStyleBackColor = False
        '
        'bookdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1017, 535)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.list)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.updte)
        Me.Controls.Add(Me.add)
        Me.Controls.Add(Me.category)
        Me.Controls.Add(Me.publisher)
        Me.Controls.Add(Me.author)
        Me.Controls.Add(Me.title)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.isbn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "bookdetails"
        Me.Text = "bookdetails"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookdDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookdDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BookdDataSetBindingSource As BindingSource
    Friend WithEvents BookdDataSet As bookdDataSet
    Friend WithEvents search As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents isbn As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents year As TextBox
    Friend WithEvents title As TextBox
    Friend WithEvents author As TextBox
    Friend WithEvents publisher As TextBox
    Friend WithEvents category As TextBox
    Friend WithEvents add As Button
    Friend WithEvents updte As Button
    Friend WithEvents back As Button
    Friend WithEvents list As Button
    Friend WithEvents delete As Button
End Class
