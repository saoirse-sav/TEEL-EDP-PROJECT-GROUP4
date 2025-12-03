<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtID = New TextBox()
        txtStartDate = New TextBox()
        txtRenterName = New TextBox()
        txtCarModel = New TextBox()
        txtEndDate = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        btnLoadData = New Button()
        dgvRentals = New DataGridView()
        CType(dgvRentals, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(272, 22)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(265, 27)
        txtID.TabIndex = 0
        ' 
        ' txtStartDate
        ' 
        txtStartDate.Location = New Point(272, 169)
        txtStartDate.Name = "txtStartDate"
        txtStartDate.Size = New Size(265, 27)
        txtStartDate.TabIndex = 1
        ' 
        ' txtRenterName
        ' 
        txtRenterName.Location = New Point(272, 119)
        txtRenterName.Name = "txtRenterName"
        txtRenterName.Size = New Size(265, 27)
        txtRenterName.TabIndex = 2
        ' 
        ' txtCarModel
        ' 
        txtCarModel.Location = New Point(272, 70)
        txtCarModel.Name = "txtCarModel"
        txtCarModel.Size = New Size(265, 27)
        txtCarModel.TabIndex = 3
        ' 
        ' txtEndDate
        ' 
        txtEndDate.Location = New Point(272, 222)
        txtEndDate.Name = "txtEndDate"
        txtEndDate.Size = New Size(265, 27)
        txtEndDate.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("BankGothic Lt BT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(228, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 19)
        Label1.TabIndex = 5
        Label1.Text = "id:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 121)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("BankGothic Lt BT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(148, 74)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 19)
        Label3.TabIndex = 10
        Label3.Text = "car model:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("BankGothic Lt BT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(134, 122)
        Label6.Name = "Label6"
        Label6.Size = New Size(132, 19)
        Label6.TabIndex = 11
        Label6.Text = "renter name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("BankGothic Lt BT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(149, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(117, 19)
        Label4.TabIndex = 12
        Label4.Text = "start date:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("BankGothic Lt BT", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(161, 226)
        Label5.Name = "Label5"
        Label5.Size = New Size(101, 19)
        Label5.TabIndex = 13
        Label5.Text = "end date:"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(108, 283)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(94, 29)
        btnAdd.TabIndex = 14
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(228, 283)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 29)
        btnUpdate.TabIndex = 15
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(463, 283)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 16
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(346, 283)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(94, 29)
        btnDelete.TabIndex = 17
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnLoadData
        ' 
        btnLoadData.Location = New Point(585, 283)
        btnLoadData.Name = "btnLoadData"
        btnLoadData.Size = New Size(94, 29)
        btnLoadData.TabIndex = 18
        btnLoadData.Text = "Load Data"
        btnLoadData.UseVisualStyleBackColor = True
        ' 
        ' dgvRentals
        ' 
        dgvRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRentals.Location = New Point(3, 336)
        dgvRentals.Name = "dgvRentals"
        dgvRentals.RowHeadersWidth = 51
        dgvRentals.Size = New Size(794, 217)
        dgvRentals.TabIndex = 19
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 554)
        Controls.Add(dgvRentals)
        Controls.Add(btnLoadData)
        Controls.Add(btnDelete)
        Controls.Add(btnClear)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtEndDate)
        Controls.Add(txtCarModel)
        Controls.Add(txtRenterName)
        Controls.Add(txtStartDate)
        Controls.Add(txtID)
        Name = "Form1"
        Text = "Car Rental System"
        CType(dgvRentals, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtID As TextBox
    Friend WithEvents txtStartDate As TextBox
    Friend WithEvents txtRenterName As TextBox
    Friend WithEvents txtCarModel As TextBox
    Friend WithEvents txtEndDate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnLoadData As Button
    Friend WithEvents dgvRentals As DataGridView

End Class
