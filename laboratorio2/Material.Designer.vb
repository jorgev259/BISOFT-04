﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Material
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBoxCourse1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonOpen = New System.Windows.Forms.Button()
        Me.ButtonSelect = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LabelChange = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomMenuStrip1 = New laboratorio2.CustomMenuStrip()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxCourse1
        '
        Me.ComboBoxCourse1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxCourse1.FormattingEnabled = True
        Me.ComboBoxCourse1.Location = New System.Drawing.Point(653, 95)
        Me.ComboBoxCourse1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxCourse1.Name = "ComboBoxCourse1"
        Me.ComboBoxCourse1.Size = New System.Drawing.Size(199, 33)
        Me.ComboBoxCourse1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.HotTrack
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.Location = New System.Drawing.Point(16, 95)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(624, 362)
        Me.DataGridView1.TabIndex = 1
        '
        'ButtonOpen
        '
        Me.ButtonOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonOpen.Location = New System.Drawing.Point(655, 155)
        Me.ButtonOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonOpen.Name = "ButtonOpen"
        Me.ButtonOpen.Size = New System.Drawing.Size(200, 41)
        Me.ButtonOpen.TabIndex = 2
        Me.ButtonOpen.Text = "Abrir"
        Me.ButtonOpen.UseVisualStyleBackColor = True
        '
        'ButtonSelect
        '
        Me.ButtonSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSelect.Location = New System.Drawing.Point(653, 293)
        Me.ButtonSelect.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonSelect.Name = "ButtonSelect"
        Me.ButtonSelect.Size = New System.Drawing.Size(200, 41)
        Me.ButtonSelect.TabIndex = 3
        Me.ButtonSelect.Text = "Subir"
        Me.ButtonSelect.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(655, 225)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(200, 41)
        Me.ButtonDelete.TabIndex = 4
        Me.ButtonDelete.Text = "Eliminar"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LabelChange
        '
        Me.LabelChange.AutoSize = True
        Me.LabelChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChange.ForeColor = System.Drawing.Color.Lime
        Me.LabelChange.Location = New System.Drawing.Point(648, 356)
        Me.LabelChange.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelChange.Name = "LabelChange"
        Me.LabelChange.Size = New System.Drawing.Size(71, 25)
        Me.LabelChange.TabIndex = 6
        Me.LabelChange.Text = "Label1"
        Me.LabelChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelChange.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(709, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cursos:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(157, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 29)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Administrador De Materiales"
        '
        'CustomMenuStrip1
        '
        Me.CustomMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomMenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.CustomMenuStrip1.Name = "CustomMenuStrip1"
        Me.CustomMenuStrip1.Size = New System.Drawing.Size(871, 25)
        Me.CustomMenuStrip1.TabIndex = 12
        Me.CustomMenuStrip1.Text = "CustomMenuStrip1"
        '
        'Material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 473)
        Me.Controls.Add(Me.CustomMenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelChange)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonSelect)
        Me.Controls.Add(Me.ButtonOpen)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBoxCourse1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Material"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxCourse1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonOpen As Button
    Friend WithEvents ButtonSelect As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents LabelChange As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CustomMenuStrip1 As CustomMenuStrip
End Class
