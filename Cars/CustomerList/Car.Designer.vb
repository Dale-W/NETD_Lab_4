<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lbLastName = New System.Windows.Forms.Label()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lvwCars = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CustomerToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblResult = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(128, 534)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 28)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.CustomerToolTip.SetToolTip(Me.btnEnter, "Click to add a car.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(236, 534)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.CustomerToolTip.SetToolTip(Me.btnReset, "Click to reset the screen.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(344, 534)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.CustomerToolTip.SetToolTip(Me.btnExit, "Click to exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(112, 42)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(160, 22)
        Me.txtModel.TabIndex = 3
        Me.CustomerToolTip.SetToolTip(Me.txtModel, "Type the car's model.")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(112, 103)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(160, 22)
        Me.txtPrice.TabIndex = 7
        Me.CustomerToolTip.SetToolTip(Me.txtPrice, "Type the car's price.")
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"BMW", "Volvo", "Subaru", "Mazda", "Kia", "GMC"})
        Me.cmbMake.Location = New System.Drawing.Point(112, 9)
        Me.cmbMake.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(160, 24)
        Me.cmbMake.TabIndex = 1
        Me.CustomerToolTip.SetToolTip(Me.cmbMake, "Select the car's make.")
        '
        'lbTitle
        '
        Me.lbTitle.Location = New System.Drawing.Point(16, 9)
        Me.lbTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(88, 16)
        Me.lbTitle.TabIndex = 0
        Me.lbTitle.Text = "&Make: "
        Me.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblFirstName
        '
        Me.lblFirstName.Location = New System.Drawing.Point(16, 42)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(88, 16)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "M&odel: "
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblFirstName.UseWaitCursor = True
        '
        'lbLastName
        '
        Me.lbLastName.Location = New System.Drawing.Point(16, 107)
        Me.lbLastName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbLastName.Name = "lbLastName"
        Me.lbLastName.Size = New System.Drawing.Size(88, 16)
        Me.lbLastName.TabIndex = 6
        Me.lbLastName.Text = "&Price: "
        Me.lbLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(53, 133)
        Me.chkNew.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(79, 30)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CustomerToolTip.SetToolTip(Me.chkNew, "Check if car is new.")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lvwCars
        '
        Me.lvwCars.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvwCars.CheckBoxes = True
        Me.lvwCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCars.FullRowSelect = True
        Me.lvwCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCars.Location = New System.Drawing.Point(3, 171)
        Me.lvwCars.Margin = New System.Windows.Forms.Padding(4)
        Me.lvwCars.MultiSelect = False
        Me.lvwCars.Name = "lvwCars"
        Me.lvwCars.Size = New System.Drawing.Size(453, 302)
        Me.lvwCars.TabIndex = 9
        Me.CustomerToolTip.SetToolTip(Me.lvwCars, "Select a car to modify.")
        Me.lvwCars.UseCompatibleStateImageBehavior = False
        Me.lvwCars.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 40
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 30
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 70
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(3, 439)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(454, 91)
        Me.lblResult.TabIndex = 10
        Me.CustomerToolTip.SetToolTip(Me.lblResult, "Success or Error message will appear here.")
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2019", "2018", "2017", "2016"})
        Me.cmbYear.Location = New System.Drawing.Point(112, 73)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(160, 24)
        Me.cmbYear.TabIndex = 5
        Me.CustomerToolTip.SetToolTip(Me.cmbYear, "Select the year of the car.")
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "&Year: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.UseWaitCursor = True
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(469, 575)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lvwCars)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lbLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(487, 622)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(487, 622)
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents lbTitle As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lbLastName As Label
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lvwCars As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents CustomerToolTip As ToolTip
    Friend WithEvents lblResult As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents colPrice As ColumnHeader
End Class
