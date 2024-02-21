<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.day = New System.Windows.Forms.Label()
        Me.BasicSalary = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.salary = New System.Windows.Forms.TextBox()
        Me.MonthPay = New System.Windows.Forms.Label()
        Me.pay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.EmployeeFirstName = New System.Windows.Forms.Label()
        Me.EmployeeLastName = New System.Windows.Forms.Label()
        Me.EmployeeID = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.thedate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BankName = New System.Windows.Forms.Label()
        Me.AccountNumber = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.bank = New System.Windows.Forms.TextBox()
        Me.daysWorked = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'day
        '
        Me.day.AutoSize = True
        Me.day.Location = New System.Drawing.Point(228, 215)
        Me.day.Name = "day"
        Me.day.Size = New System.Drawing.Size(89, 17)
        Me.day.TabIndex = 0
        Me.day.Text = "Days worked"
        '
        'BasicSalary
        '
        Me.BasicSalary.AutoSize = True
        Me.BasicSalary.Location = New System.Drawing.Point(228, 244)
        Me.BasicSalary.Name = "BasicSalary"
        Me.BasicSalary.Size = New System.Drawing.Size(86, 17)
        Me.BasicSalary.TabIndex = 1
        Me.BasicSalary.Text = "Basic Salary"
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(355, 266)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(156, 35)
        Me.Submit.TabIndex = 2
        Me.Submit.Text = "Calculate Pay"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'salary
        '
        Me.salary.Location = New System.Drawing.Point(355, 241)
        Me.salary.Name = "salary"
        Me.salary.Size = New System.Drawing.Size(156, 22)
        Me.salary.TabIndex = 3
        Me.salary.Text = "10000"
        '
        'MonthPay
        '
        Me.MonthPay.AutoSize = True
        Me.MonthPay.Location = New System.Drawing.Point(247, 325)
        Me.MonthPay.Name = "MonthPay"
        Me.MonthPay.Size = New System.Drawing.Size(32, 17)
        Me.MonthPay.TabIndex = 5
        Me.MonthPay.Text = "Pay"
        '
        'pay
        '
        Me.pay.Location = New System.Drawing.Point(355, 320)
        Me.pay.Name = "pay"
        Me.pay.ReadOnly = True
        Me.pay.Size = New System.Drawing.Size(156, 22)
        Me.pay.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(361, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Payroll Program"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(507, 376)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(123, 21)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.Text = "Western Union"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(636, 376)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(70, 21)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.Text = "Crypto"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(374, 376)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(119, 21)
        Me.RadioButton3.TabIndex = 10
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Bank Transfer"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 377)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Payment Method :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(531, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 35)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Make Payment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(355, 114)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(138, 22)
        Me.TextBox1.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(355, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 22)
        Me.TextBox2.TabIndex = 14
        '
        'EmployeeFirstName
        '
        Me.EmployeeFirstName.AutoSize = True
        Me.EmployeeFirstName.Location = New System.Drawing.Point(228, 91)
        Me.EmployeeFirstName.Name = "EmployeeFirstName"
        Me.EmployeeFirstName.Size = New System.Drawing.Size(76, 17)
        Me.EmployeeFirstName.TabIndex = 15
        Me.EmployeeFirstName.Text = "First Name"
        '
        'EmployeeLastName
        '
        Me.EmployeeLastName.AutoSize = True
        Me.EmployeeLastName.Location = New System.Drawing.Point(228, 119)
        Me.EmployeeLastName.Name = "EmployeeLastName"
        Me.EmployeeLastName.Size = New System.Drawing.Size(76, 17)
        Me.EmployeeLastName.TabIndex = 16
        Me.EmployeeLastName.Text = "Last Name"
        '
        'EmployeeID
        '
        Me.EmployeeID.AutoSize = True
        Me.EmployeeID.Location = New System.Drawing.Point(228, 61)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(87, 17)
        Me.EmployeeID.TabIndex = 17
        Me.EmployeeID.Text = "Employee ID"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(355, 55)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(138, 22)
        Me.TextBox3.TabIndex = 18
        '
        'thedate
        '
        Me.thedate.AllowDrop = True
        Me.thedate.Location = New System.Drawing.Point(636, 12)
        Me.thedate.Name = "thedate"
        Me.thedate.Size = New System.Drawing.Size(159, 22)
        Me.thedate.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(592, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Date :"
        '
        'BankName
        '
        Me.BankName.AutoSize = True
        Me.BankName.Location = New System.Drawing.Point(228, 154)
        Me.BankName.Name = "BankName"
        Me.BankName.Size = New System.Drawing.Size(81, 17)
        Me.BankName.TabIndex = 21
        Me.BankName.Text = "Bank Name"
        '
        'AccountNumber
        '
        Me.AccountNumber.AutoSize = True
        Me.AccountNumber.Location = New System.Drawing.Point(228, 187)
        Me.AccountNumber.Name = "AccountNumber"
        Me.AccountNumber.Size = New System.Drawing.Size(113, 17)
        Me.AccountNumber.TabIndex = 23
        Me.AccountNumber.Text = "Account Number"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(355, 182)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 24
        '
        'bank
        '
        Me.bank.Location = New System.Drawing.Point(355, 149)
        Me.bank.Name = "bank"
        Me.bank.Size = New System.Drawing.Size(100, 22)
        Me.bank.TabIndex = 25
        '
        'daysWorked
        '
        Me.daysWorked.Location = New System.Drawing.Point(355, 212)
        Me.daysWorked.Name = "daysWorked"
        Me.daysWorked.Size = New System.Drawing.Size(100, 22)
        Me.daysWorked.TabIndex = 26
        Me.daysWorked.Text = "20"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.daysWorked)
        Me.Controls.Add(Me.bank)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.AccountNumber)
        Me.Controls.Add(Me.BankName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.thedate)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.EmployeeID)
        Me.Controls.Add(Me.EmployeeLastName)
        Me.Controls.Add(Me.EmployeeFirstName)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pay)
        Me.Controls.Add(Me.MonthPay)
        Me.Controls.Add(Me.salary)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.BasicSalary)
        Me.Controls.Add(Me.day)
        Me.Name = "Form1"
        Me.Text = "payroll"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents day As Label
    Friend WithEvents BasicSalary As Label
    Friend WithEvents Submit As Button
    Friend WithEvents salary As TextBox
    Friend WithEvents MonthPay As Label
    Friend WithEvents pay As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents EmployeeFirstName As Label
    Friend WithEvents EmployeeLastName As Label
    Friend WithEvents EmployeeID As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents thedate As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents BankName As Label
    Friend WithEvents AccountNumber As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents bank As TextBox
    Friend WithEvents daysWorked As TextBox
End Class
