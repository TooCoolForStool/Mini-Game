Public Class Form1
    Public WeaponFind As Integer
    Private Sub Run_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunAttempt.Click
        Dim Run As Object
        Run = RunAttempt
        Randomize()
        Dim RunChance As Integer = CInt(Int((100 * Rnd()) + 1))
        If RunChance > 75 Then
            MessageBox.Show("You escaped...")
            Close()
        Else
            MessageBox.Show("You failed to escape!")
        End If
        Me.EnemyControl_Click(Me.EnemyControl, EventArgs.Empty)
        RunAttempt.Visible = False
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EnemyHealth.Value = 500
        PlayerHealth.Value = 10
        MessageBox.Show("An Umber Hulk steps up to the plate!")
    End Sub
    Public Sub Swing_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Swing.Click
        Randomize()
        Dim HitChance As Integer = CInt(Int((100 * Rnd()) + 1))
        Randomize()

        If HitChance > 20 Then

            If WeaponFind = 5 Then
                MessageBox.Show("You shoot it!")
                Randomize()
                Dim GunHitValue As Integer = CInt(Int((80 * Rnd()) + 40))
                EnemyHealth.Increment(-GunHitValue)
            ElseIf WeaponFind = 4 Then
                MessageBox.Show("You swing for the fences!")
                Randomize()
                Dim StickHitValue As Integer = CInt(Int((50 * Rnd()) + 25))
                EnemyHealth.Increment(-StickHitValue)
            ElseIf WeaponFind = 3 Then
                MessageBox.Show("You stab into the foe!")
                Randomize()
                Dim ShankHitValue As Integer = CInt(Int((35 * Rnd()) + 10))
                EnemyHealth.Increment(-ShankHitValue)
            Else
                MessageBox.Show("You strike the enemy!")
                Randomize()
                Dim FistHitValue As Integer = CInt(Int((20 * Rnd()) + 5))
                EnemyHealth.Increment(-FistHitValue)
            End If
        Else
            MessageBox.Show("You missed...")
        End If
        If EnemyHealth.Value = 0 Then
            MessageBox.Show("You win!")
            Close()
        End If
        Me.EnemyControl_Click(Me.EnemyControl, EventArgs.Empty)
    End Sub
    Private Sub EnemyHealth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnemyHealth.Click
        Dim EnemyHealth As ProgressBar
        EnemyHealth = New ProgressBar()
        EnemyHealth.Minimum = 0
        EnemyHealth.Maximum = 500
        EnemyHealth.Value = 500
    End Sub

    Private Sub PlayerHealth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayerHealth.Click
        Dim PlayerHealth As ProgressBar
        PlayerHealth = New ProgressBar()
        PlayerHealth.Minimum = 0
        PlayerHealth.Maximum = 10
        PlayerHealth.Value = 10

    End Sub
    Private Sub EnemyControl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnemyControl.Click
        Dim EnemyHitChance As Integer = CInt(Int((100 * Rnd()) + 1))
        MessageBox.Show("The Umber Hulk charges you!")
        If EnemyHitChance > 60 Then
            MessageBox.Show("The Umber Hulk boars down onto you, tearing you to shreds!")
            PlayerHealth.Increment(-4)
        Else
            MessageBox.Show("The Enemy missed...")
        End If
        If PlayerHealth.Value = 0 Then
            MessageBox.Show("You died...")
        End If
    End Sub

    Public Sub Weapon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Weapon.Click
        MessageBox.Show("You look for a weapon...")
        Randomize()
        Dim WeaponFind2 As Integer = CInt(Int((5 * Rnd()) + 1))
        WeaponFind = WeaponFind2
        If WeaponFind < 3 Then
            MessageBox.Show("You failed to find a weapon...")
        End If
        If WeaponFind = 3 Then
            MessageBox.Show("You found a shank!")
        ElseIf WeaponFind = 4 Then
            MessageBox.Show("You found a 2x4!")
        ElseIf WeaponFind = 5 Then
            MessageBox.Show("You find a gun!")
        End If
        If WeaponFind > 2 Then
            Weapon.Visible = False
        End If
        Me.EnemyControl_Click(Me.EnemyControl, EventArgs.Empty)
    End Sub
End Class
