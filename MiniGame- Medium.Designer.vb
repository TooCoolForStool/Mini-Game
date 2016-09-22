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
        Me.RunAttempt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Swing = New System.Windows.Forms.Button()
        Me.EnemyHealth = New System.Windows.Forms.ProgressBar()
        Me.PlayerHealth = New System.Windows.Forms.ProgressBar()
        Me.EnemyControl = New System.Windows.Forms.Button()
        Me.Weapon = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RunAttempt
        '
        Me.RunAttempt.Location = New System.Drawing.Point(259, 254)
        Me.RunAttempt.Name = "RunAttempt"
        Me.RunAttempt.Size = New System.Drawing.Size(75, 23)
        Me.RunAttempt.TabIndex = 0
        Me.RunAttempt.Text = "Run"
        Me.RunAttempt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Umber Hulk"
        '
        'Swing
        '
        Me.Swing.Location = New System.Drawing.Point(12, 175)
        Me.Swing.Name = "Swing"
        Me.Swing.Size = New System.Drawing.Size(75, 23)
        Me.Swing.TabIndex = 2
        Me.Swing.Text = "Swing"
        Me.Swing.UseVisualStyleBackColor = True
        '
        'EnemyHealth
        '
        Me.EnemyHealth.Location = New System.Drawing.Point(52, 91)
        Me.EnemyHealth.Name = "EnemyHealth"
        Me.EnemyHealth.Size = New System.Drawing.Size(221, 23)
        Me.EnemyHealth.TabIndex = 3
        '
        'PlayerHealth
        '
        Me.PlayerHealth.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlayerHealth.ForeColor = System.Drawing.Color.RoyalBlue
        Me.PlayerHealth.Location = New System.Drawing.Point(12, 262)
        Me.PlayerHealth.MarqueeAnimationSpeed = 10
        Me.PlayerHealth.Maximum = 10
        Me.PlayerHealth.Name = "PlayerHealth"
        Me.PlayerHealth.Size = New System.Drawing.Size(110, 15)
        Me.PlayerHealth.TabIndex = 4
        '
        'EnemyControl
        '
        Me.EnemyControl.Location = New System.Drawing.Point(285, 12)
        Me.EnemyControl.Name = "EnemyControl"
        Me.EnemyControl.Size = New System.Drawing.Size(49, 42)
        Me.EnemyControl.TabIndex = 5
        Me.EnemyControl.Text = "Enemy Control"
        Me.EnemyControl.UseVisualStyleBackColor = True
        Me.EnemyControl.Visible = False
        '
        'Weapon
        '
        Me.Weapon.Location = New System.Drawing.Point(255, 175)
        Me.Weapon.Name = "Weapon"
        Me.Weapon.Size = New System.Drawing.Size(79, 23)
        Me.Weapon.TabIndex = 6
        Me.Weapon.Text = "Find Weapon"
        Me.Weapon.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "You"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 311)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Weapon)
        Me.Controls.Add(Me.EnemyControl)
        Me.Controls.Add(Me.PlayerHealth)
        Me.Controls.Add(Me.EnemyHealth)
        Me.Controls.Add(Me.Swing)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RunAttempt)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RunAttempt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Swing As System.Windows.Forms.Button
    Friend WithEvents EnemyHealth As System.Windows.Forms.ProgressBar
    Friend WithEvents PlayerHealth As System.Windows.Forms.ProgressBar
    Friend WithEvents EnemyControl As System.Windows.Forms.Button
    Friend WithEvents Weapon As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
