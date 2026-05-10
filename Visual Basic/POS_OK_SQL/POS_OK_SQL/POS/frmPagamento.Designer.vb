<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagamento
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbt_nao = New System.Windows.Forms.RadioButton()
        Me.rbt_sim = New System.Windows.Forms.RadioButton()
        Me.gbxNif = New System.Windows.Forms.GroupBox()
        Me.lblNome = New System.Windows.Forms.Label()
        Me.txt_Nome = New System.Windows.Forms.TextBox()
        Me.lblNif = New System.Windows.Forms.Label()
        Me.txt_Nif = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Valor = New System.Windows.Forms.TextBox()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.btn_Aceitar = New System.Windows.Forms.Button()
        Me.gbxNif.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(441, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Deseja factura com Num. Contribuinte  ?"
        '
        'rbt_nao
        '
        Me.rbt_nao.AutoSize = True
        Me.rbt_nao.Checked = True
        Me.rbt_nao.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_nao.Location = New System.Drawing.Point(468, 49)
        Me.rbt_nao.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbt_nao.Name = "rbt_nao"
        Me.rbt_nao.Size = New System.Drawing.Size(83, 33)
        Me.rbt_nao.TabIndex = 2
        Me.rbt_nao.TabStop = True
        Me.rbt_nao.Text = "Não"
        Me.rbt_nao.UseVisualStyleBackColor = True
        '
        'rbt_sim
        '
        Me.rbt_sim.AutoSize = True
        Me.rbt_sim.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbt_sim.Location = New System.Drawing.Point(620, 49)
        Me.rbt_sim.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbt_sim.Name = "rbt_sim"
        Me.rbt_sim.Size = New System.Drawing.Size(80, 33)
        Me.rbt_sim.TabIndex = 3
        Me.rbt_sim.Text = "Sim"
        Me.rbt_sim.UseVisualStyleBackColor = True
        '
        'gbxNif
        '
        Me.gbxNif.Controls.Add(Me.lblNome)
        Me.gbxNif.Controls.Add(Me.txt_Nome)
        Me.gbxNif.Controls.Add(Me.lblNif)
        Me.gbxNif.Controls.Add(Me.txt_Nif)
        Me.gbxNif.Location = New System.Drawing.Point(18, 95)
        Me.gbxNif.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxNif.Name = "gbxNif"
        Me.gbxNif.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbxNif.Size = New System.Drawing.Size(921, 111)
        Me.gbxNif.TabIndex = 3
        Me.gbxNif.TabStop = False
        '
        'lblNome
        '
        Me.lblNome.AutoSize = True
        Me.lblNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNome.Location = New System.Drawing.Point(306, 19)
        Me.lblNome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNome.Name = "lblNome"
        Me.lblNome.Size = New System.Drawing.Size(79, 29)
        Me.lblNome.TabIndex = 3
        Me.lblNome.Text = "Nome"
        '
        'txt_Nome
        '
        Me.txt_Nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nome.Location = New System.Drawing.Point(297, 54)
        Me.txt_Nome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Nome.Name = "txt_Nome"
        Me.txt_Nome.Size = New System.Drawing.Size(613, 35)
        Me.txt_Nome.TabIndex = 5
        '
        'lblNif
        '
        Me.lblNif.AutoSize = True
        Me.lblNif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNif.Location = New System.Drawing.Point(3, 19)
        Me.lblNif.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNif.Name = "lblNif"
        Me.lblNif.Size = New System.Drawing.Size(240, 29)
        Me.lblNif.TabIndex = 1
        Me.lblNif.Text = "Num. de Contribuinte"
        '
        'txt_Nif
        '
        Me.txt_Nif.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_Nif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Nif.Location = New System.Drawing.Point(9, 54)
        Me.txt_Nif.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_Nif.MaxLength = 9
        Me.txt_Nif.Name = "txt_Nif"
        Me.txt_Nif.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_Nif.Size = New System.Drawing.Size(257, 35)
        Me.txt_Nif.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 234)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(450, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Introduza o Numerário para pagamento : "
        '
        'txt_Valor
        '
        Me.txt_Valor.BackColor = System.Drawing.Color.White
        Me.txt_Valor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Valor.Location = New System.Drawing.Point(482, 234)
        Me.txt_Valor.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_Valor.Name = "txt_Valor"
        Me.txt_Valor.Size = New System.Drawing.Size(217, 35)
        Me.txt_Valor.TabIndex = 0
        Me.txt_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Location = New System.Drawing.Point(780, 319)
        Me.btn_Cancelar.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(150, 42)
        Me.btn_Cancelar.TabIndex = 6
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Aceitar
        '
        Me.btn_Aceitar.Location = New System.Drawing.Point(619, 319)
        Me.btn_Aceitar.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_Aceitar.Name = "btn_Aceitar"
        Me.btn_Aceitar.Size = New System.Drawing.Size(150, 42)
        Me.btn_Aceitar.TabIndex = 1
        Me.btn_Aceitar.Text = "Aceitar"
        Me.btn_Aceitar.UseVisualStyleBackColor = True
        '
        'frmPagamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 392)
        Me.Controls.Add(Me.txt_Valor)
        Me.Controls.Add(Me.btn_Cancelar)
        Me.Controls.Add(Me.btn_Aceitar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.gbxNif)
        Me.Controls.Add(Me.rbt_sim)
        Me.Controls.Add(Me.rbt_nao)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPagamento"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS Pagamento"
        Me.gbxNif.ResumeLayout(False)
        Me.gbxNif.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbt_nao As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_sim As System.Windows.Forms.RadioButton
    Friend WithEvents gbxNif As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Nif As System.Windows.Forms.TextBox
    Friend WithEvents lblNome As System.Windows.Forms.Label
    Friend WithEvents txt_Nome As System.Windows.Forms.TextBox
    Friend WithEvents lblNif As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_Valor As System.Windows.Forms.TextBox
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Aceitar As System.Windows.Forms.Button
End Class
