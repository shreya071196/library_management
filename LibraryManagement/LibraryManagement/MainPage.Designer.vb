<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminControlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.store_mi = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.issuebook = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddDepartmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.departbud_mi = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewDepartmentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooksOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.InventoryToolStripMenuItem, Me.BooksToolStripMenuItem, Me.DepartmentToolStripMenuItem, Me.BooksOrderToolStripMenuItem, Me.MembersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(723, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminControlToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AdminControlToolStripMenuItem
        '
        Me.AdminControlToolStripMenuItem.Name = "AdminControlToolStripMenuItem"
        Me.AdminControlToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AdminControlToolStripMenuItem.Text = "Admin Control"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'InventoryToolStripMenuItem
        '
        Me.InventoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.store_mi, Me.AddBooksToolStripMenuItem})
        Me.InventoryToolStripMenuItem.Name = "InventoryToolStripMenuItem"
        Me.InventoryToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.InventoryToolStripMenuItem.Text = "Inventory"
        '
        'store_mi
        '
        Me.store_mi.Name = "store_mi"
        Me.store_mi.Size = New System.Drawing.Size(152, 22)
        Me.store_mi.Text = "Store"
        '
        'BooksToolStripMenuItem
        '
        Me.BooksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.issuebook, Me.ReturnToolStripMenuItem})
        Me.BooksToolStripMenuItem.Name = "BooksToolStripMenuItem"
        Me.BooksToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.BooksToolStripMenuItem.Text = "Books"
        '
        'issuebook
        '
        Me.issuebook.Name = "issuebook"
        Me.issuebook.Size = New System.Drawing.Size(152, 22)
        Me.issuebook.Text = "Issue"
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReturnToolStripMenuItem.Text = "Return"
        '
        'DepartmentToolStripMenuItem
        '
        Me.DepartmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddDepartmentToolStripMenuItem, Me.departbud_mi, Me.ViewDepartmentDetailsToolStripMenuItem})
        Me.DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        Me.DepartmentToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.DepartmentToolStripMenuItem.Text = "Department"
        '
        'AddDepartmentToolStripMenuItem
        '
        Me.AddDepartmentToolStripMenuItem.Name = "AddDepartmentToolStripMenuItem"
        Me.AddDepartmentToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.AddDepartmentToolStripMenuItem.Text = "Add Department"
        '
        'departbud_mi
        '
        Me.departbud_mi.Name = "departbud_mi"
        Me.departbud_mi.Size = New System.Drawing.Size(203, 22)
        Me.departbud_mi.Text = "Add Department budget"
        '
        'ViewDepartmentDetailsToolStripMenuItem
        '
        Me.ViewDepartmentDetailsToolStripMenuItem.Name = "ViewDepartmentDetailsToolStripMenuItem"
        Me.ViewDepartmentDetailsToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ViewDepartmentDetailsToolStripMenuItem.Text = "View Department Details"
        '
        'BooksOrderToolStripMenuItem
        '
        Me.BooksOrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderToolStripMenuItem})
        Me.BooksOrderToolStripMenuItem.Name = "BooksOrderToolStripMenuItem"
        Me.BooksOrderToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.BooksOrderToolStripMenuItem.Text = "Books Order"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OrderToolStripMenuItem.Text = "Order"
        '
        'MembersToolStripMenuItem
        '
        Me.MembersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMembersToolStripMenuItem})
        Me.MembersToolStripMenuItem.Name = "MembersToolStripMenuItem"
        Me.MembersToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.MembersToolStripMenuItem.Text = "Members"
        '
        'AddMembersToolStripMenuItem
        '
        Me.AddMembersToolStripMenuItem.Name = "AddMembersToolStripMenuItem"
        Me.AddMembersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddMembersToolStripMenuItem.Text = "Add Members"
        '
        'AddBooksToolStripMenuItem
        '
        Me.AddBooksToolStripMenuItem.Name = "AddBooksToolStripMenuItem"
        Me.AddBooksToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddBooksToolStripMenuItem.Text = "Add books"
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LibraryManagement.My.Resources.Resources.LibraryBackground
        Me.ClientSize = New System.Drawing.Size(723, 353)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainPage"
        Me.Text = "MainPage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminControlToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents store_mi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents issuebook As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddDepartmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents departbud_mi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewDepartmentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BooksOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MembersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddMembersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBooksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
