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
        components = New ComponentModel.Container()
        txt_nombre = New TextBox()
        txt_apellido = New TextBox()
        txt_tomo = New TextBox()
        txt_posicion = New TextBox()
        txt_asiento = New TextBox()
        combo_b_prefijo = New ComboBox()
        txt_horasT = New TextBox()
        txt_salarioxH = New TextBox()
        txt_diasT = New TextBox()
        txt_horasX = New TextBox()
        txt_salarioB = New TextBox()
        txt_salarioN = New TextBox()
        txt_seguroS = New TextBox()
        txt_seguroE = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label1 = New Label()
        txt_impuestoSR = New TextBox()
        txt_descuento1 = New TextBox()
        txt_descuento2 = New TextBox()
        txt_descuento3 = New TextBox()
        btn_calcular = New Button()
        SuspendLayout()
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(45, 91)
        txt_nombre.MaxLength = 15
        txt_nombre.Name = "txt_nombre"
        txt_nombre.PlaceholderText = "Nombre"
        txt_nombre.Size = New Size(233, 23)
        txt_nombre.TabIndex = 0
        ' 
        ' txt_apellido
        ' 
        txt_apellido.Location = New Point(286, 91)
        txt_apellido.MaxLength = 15
        txt_apellido.Name = "txt_apellido"
        txt_apellido.PlaceholderText = "Apellido"
        txt_apellido.Size = New Size(233, 23)
        txt_apellido.TabIndex = 1
        ' 
        ' txt_tomo
        ' 
        txt_tomo.Location = New Point(103, 147)
        txt_tomo.MaxLength = 4
        txt_tomo.Name = "txt_tomo"
        txt_tomo.PlaceholderText = "Tomo"
        txt_tomo.Size = New Size(73, 23)
        txt_tomo.TabIndex = 3
        txt_tomo.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_posicion
        ' 
        txt_posicion.Location = New Point(286, 147)
        txt_posicion.MaxLength = 1
        txt_posicion.Name = "txt_posicion"
        txt_posicion.PlaceholderText = "Posición"
        txt_posicion.Size = New Size(100, 23)
        txt_posicion.TabIndex = 4
        txt_posicion.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_asiento
        ' 
        txt_asiento.Location = New Point(183, 147)
        txt_asiento.MaxLength = 5
        txt_asiento.Name = "txt_asiento"
        txt_asiento.PlaceholderText = "asiento"
        txt_asiento.Size = New Size(97, 23)
        txt_asiento.TabIndex = 5
        txt_asiento.TextAlign = HorizontalAlignment.Center
        ' 
        ' combo_b_prefijo
        ' 
        combo_b_prefijo.FormattingEnabled = True
        combo_b_prefijo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"})
        combo_b_prefijo.Location = New Point(44, 147)
        combo_b_prefijo.MaxLength = 1
        combo_b_prefijo.Name = "combo_b_prefijo"
        combo_b_prefijo.Size = New Size(53, 23)
        combo_b_prefijo.TabIndex = 6
        ' 
        ' txt_horasT
        ' 
        txt_horasT.Location = New Point(45, 246)
        txt_horasT.MaxLength = 2
        txt_horasT.Name = "txt_horasT"
        txt_horasT.PlaceholderText = "Horas de trabajos"
        txt_horasT.Size = New Size(100, 23)
        txt_horasT.TabIndex = 7
        ' 
        ' txt_salarioxH
        ' 
        txt_salarioxH.Location = New Point(166, 246)
        txt_salarioxH.Name = "txt_salarioxH"
        txt_salarioxH.PlaceholderText = "Salario por hora"
        txt_salarioxH.Size = New Size(100, 23)
        txt_salarioxH.TabIndex = 8
        ' 
        ' txt_diasT
        ' 
        txt_diasT.Location = New Point(286, 246)
        txt_diasT.MaxLength = 7
        txt_diasT.Name = "txt_diasT"
        txt_diasT.PlaceholderText = "Dias trabajados"
        txt_diasT.Size = New Size(100, 23)
        txt_diasT.TabIndex = 9
        ' 
        ' txt_horasX
        ' 
        txt_horasX.Location = New Point(419, 246)
        txt_horasX.Name = "txt_horasX"
        txt_horasX.PlaceholderText = "Horas extras"
        txt_horasX.Size = New Size(100, 23)
        txt_horasX.TabIndex = 10
        ' 
        ' txt_salarioB
        ' 
        txt_salarioB.Location = New Point(45, 307)
        txt_salarioB.Name = "txt_salarioB"
        txt_salarioB.PlaceholderText = "Salario bruto"
        txt_salarioB.Size = New Size(100, 23)
        txt_salarioB.TabIndex = 11
        ' 
        ' txt_salarioN
        ' 
        txt_salarioN.Location = New Point(419, 364)
        txt_salarioN.Name = "txt_salarioN"
        txt_salarioN.PlaceholderText = "Salario neto"
        txt_salarioN.Size = New Size(100, 23)
        txt_salarioN.TabIndex = 12
        ' 
        ' txt_seguroS
        ' 
        txt_seguroS.Location = New Point(166, 307)
        txt_seguroS.Name = "txt_seguroS"
        txt_seguroS.PlaceholderText = "Seguro social"
        txt_seguroS.Size = New Size(100, 23)
        txt_seguroS.TabIndex = 13
        ' 
        ' txt_seguroE
        ' 
        txt_seguroE.Location = New Point(286, 307)
        txt_seguroE.Name = "txt_seguroE"
        txt_seguroE.PlaceholderText = "Seguro estudiantil"
        txt_seguroE.Size = New Size(100, 23)
        txt_seguroE.TabIndex = 14
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(190, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 25)
        Label1.TabIndex = 15
        Label1.Text = "Planilla de empleado"
        ' 
        ' txt_impuestoSR
        ' 
        txt_impuestoSR.Location = New Point(419, 307)
        txt_impuestoSR.Name = "txt_impuestoSR"
        txt_impuestoSR.PlaceholderText = "Impuesto sobre la renta"
        txt_impuestoSR.Size = New Size(131, 23)
        txt_impuestoSR.TabIndex = 16
        ' 
        ' txt_descuento1
        ' 
        txt_descuento1.Location = New Point(45, 364)
        txt_descuento1.Name = "txt_descuento1"
        txt_descuento1.PlaceholderText = "descuento 1"
        txt_descuento1.Size = New Size(100, 23)
        txt_descuento1.TabIndex = 17
        ' 
        ' txt_descuento2
        ' 
        txt_descuento2.Location = New Point(166, 364)
        txt_descuento2.Name = "txt_descuento2"
        txt_descuento2.PlaceholderText = "descuento 2"
        txt_descuento2.Size = New Size(100, 23)
        txt_descuento2.TabIndex = 18
        ' 
        ' txt_descuento3
        ' 
        txt_descuento3.Location = New Point(286, 364)
        txt_descuento3.Name = "txt_descuento3"
        txt_descuento3.PlaceholderText = "descuento 3"
        txt_descuento3.Size = New Size(100, 23)
        txt_descuento3.TabIndex = 19
        ' 
        ' btn_calcular
        ' 
        btn_calcular.Location = New Point(444, 146)
        btn_calcular.Name = "btn_calcular"
        btn_calcular.Size = New Size(75, 23)
        btn_calcular.TabIndex = 20
        btn_calcular.Text = "calcular"
        btn_calcular.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(585, 450)
        Controls.Add(btn_calcular)
        Controls.Add(txt_descuento3)
        Controls.Add(txt_descuento2)
        Controls.Add(txt_descuento1)
        Controls.Add(txt_impuestoSR)
        Controls.Add(Label1)
        Controls.Add(txt_seguroE)
        Controls.Add(txt_seguroS)
        Controls.Add(txt_salarioN)
        Controls.Add(txt_salarioB)
        Controls.Add(txt_horasX)
        Controls.Add(txt_diasT)
        Controls.Add(txt_salarioxH)
        Controls.Add(txt_horasT)
        Controls.Add(combo_b_prefijo)
        Controls.Add(txt_asiento)
        Controls.Add(txt_posicion)
        Controls.Add(txt_tomo)
        Controls.Add(txt_apellido)
        Controls.Add(txt_nombre)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents txt_tomo As TextBox
    Friend WithEvents txt_posicion As TextBox
    Friend WithEvents txt_asiento As TextBox
    Friend WithEvents combo_b_prefijo As ComboBox
    Friend WithEvents txt_horasT As TextBox
    Friend WithEvents txt_salarioxH As TextBox
    Friend WithEvents txt_diasT As TextBox
    Friend WithEvents txt_horasX As TextBox
    Friend WithEvents txt_salarioB As TextBox
    Friend WithEvents txt_salarioN As TextBox
    Friend WithEvents txt_seguroS As TextBox
    Friend WithEvents txt_seguroE As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_impuestoSR As TextBox
    Friend WithEvents txt_descuento1 As TextBox
    Friend WithEvents txt_descuento2 As TextBox
    Friend WithEvents txt_descuento3 As TextBox
    Friend WithEvents btn_calcular As Button
End Class
