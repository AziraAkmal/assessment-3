<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homepage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BOOKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ISSUEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RETURNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LATERETURNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BORROWERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DETAILSToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.USERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DETAILSToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 132)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME TO " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ReadOBrite LIBRARY " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HOMEPAGE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BOOKToolStripMenuItem, Me.BORROWERToolStripMenuItem, Me.USERToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(805, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BOOKToolStripMenuItem
        '
        Me.BOOKToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DETAILSToolStripMenuItem, Me.ISSUEToolStripMenuItem, Me.RETURNToolStripMenuItem, Me.LATERETURNToolStripMenuItem})
        Me.BOOKToolStripMenuItem.Name = "BOOKToolStripMenuItem"
        Me.BOOKToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.BOOKToolStripMenuItem.Text = "BOOK"
        '
        'DETAILSToolStripMenuItem
        '
        Me.DETAILSToolStripMenuItem.Name = "DETAILSToolStripMenuItem"
        Me.DETAILSToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.DETAILSToolStripMenuItem.Text = "DETAILS"
        '
        'ISSUEToolStripMenuItem
        '
        Me.ISSUEToolStripMenuItem.Name = "ISSUEToolStripMenuItem"
        Me.ISSUEToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.ISSUEToolStripMenuItem.Text = "ISSUE"
        '
        'RETURNToolStripMenuItem
        '
        Me.RETURNToolStripMenuItem.Name = "RETURNToolStripMenuItem"
        Me.RETURNToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.RETURNToolStripMenuItem.Text = "RETURN"
        '
        'LATERETURNToolStripMenuItem
        '
        Me.LATERETURNToolStripMenuItem.Name = "LATERETURNToolStripMenuItem"
        Me.LATERETURNToolStripMenuItem.Size = New System.Drawing.Size(183, 26)
        Me.LATERETURNToolStripMenuItem.Text = "LATE RETURN"
        '
        'BORROWERToolStripMenuItem
        '
        Me.BORROWERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DETAILSToolStripMenuItem1})
        Me.BORROWERToolStripMenuItem.Name = "BORROWERToolStripMenuItem"
        Me.BORROWERToolStripMenuItem.Size = New System.Drawing.Size(103, 24)
        Me.BORROWERToolStripMenuItem.Text = "BORROWER"
        '
        'DETAILSToolStripMenuItem1
        '
        Me.DETAILSToolStripMenuItem1.Name = "DETAILSToolStripMenuItem1"
        Me.DETAILSToolStripMenuItem1.Size = New System.Drawing.Size(147, 26)
        Me.DETAILSToolStripMenuItem1.Text = "DETAILS"
        '
        'USERToolStripMenuItem
        '
        Me.USERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DETAILSToolStripMenuItem2})
        Me.USERToolStripMenuItem.Name = "USERToolStripMenuItem"
        Me.USERToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.USERToolStripMenuItem.Text = "USER"
        '
        'DETAILSToolStripMenuItem2
        '
        Me.DETAILSToolStripMenuItem2.Name = "DETAILSToolStripMenuItem2"
        Me.DETAILSToolStripMenuItem2.Size = New System.Drawing.Size(147, 26)
        Me.DETAILSToolStripMenuItem2.Text = "DETAILS"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Location = New System.Drawing.Point(225, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Location = New System.Drawing.Point(442, 369)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 46)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "EXIT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(616, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 161)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(23, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(165, 161)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(236, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(264, 36)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "DATE          TIME"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(264, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 36)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "USER:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(401, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 36)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "."
        '
        'homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(805, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "homepage"
        Me.Text = "homepage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BOOKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DETAILSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ISSUEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RETURNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LATERETURNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BORROWERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DETAILSToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents USERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DETAILSToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
