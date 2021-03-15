<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ValueA = New System.Windows.Forms.TextBox()
        Me.ValueB = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Symbols = New System.Windows.Forms.ComboBox()
        Me.Result = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ValueA
        '
        Me.ValueA.Location = New System.Drawing.Point(89, 60)
        Me.ValueA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ValueA.MaxLength = 10
        Me.ValueA.Name = "ValueA"
        Me.ValueA.Size = New System.Drawing.Size(124, 30)
        Me.ValueA.TabIndex = 0
        Me.ValueA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ValueB
        '
        Me.ValueB.Location = New System.Drawing.Point(272, 60)
        Me.ValueB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ValueB.MaxLength = 10
        Me.ValueB.Name = "ValueB"
        Me.ValueB.Size = New System.Drawing.Size(124, 30)
        Me.ValueB.TabIndex = 1
        Me.ValueB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(146, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(189, 26)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Посчитать"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Symbols
        '
        Me.Symbols.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Symbols.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Symbols.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Symbols.FormattingEnabled = True
        Me.Symbols.Items.AddRange(New Object() {"+", "-", ":", "*"})
        Me.Symbols.Location = New System.Drawing.Point(220, 59)
        Me.Symbols.Name = "Symbols"
        Me.Symbols.Size = New System.Drawing.Size(45, 31)
        Me.Symbols.TabIndex = 4
        '
        'Result
        '
        Me.Result.Enabled = False
        Me.Result.Location = New System.Drawing.Point(146, 132)
        Me.Result.Margin = New System.Windows.Forms.Padding(4)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(189, 30)
        Me.Result.TabIndex = 5
        Me.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Введите числа, чтобы что-то с ними посчитать"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 227)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.Symbols)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ValueB)
        Me.Controls.Add(Me.ValueA)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Недокалькулятор"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ValueA As TextBox
    Friend WithEvents ValueB As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Symbols As ComboBox
    Friend WithEvents Result As TextBox
    Friend WithEvents Label1 As Label
End Class
