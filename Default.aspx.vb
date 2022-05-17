Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles bsal.TextChanged

        'Basic codes
        eyer1.Text = Val(bsal.Text) * 0.13
        eyee2.Text = Val(bsal.Text) * 0.055
        eyee3.Text = Val(bsal.Text) * 0.05
        eyer3.Text = Val(bsal.Text) * 0.05
        dueamt.Text = (Val(bsal.Text) - Val(eyee2.Text) - Val(eyee3.Text)) + Val(allows.Text)
        gross.Text = Val(bsal.Text) + Val(allows.Text)

        'delearing variables chargeable rate
        Dim c1 As Decimal = 365
        Dim c2 As Decimal = 110
        Dim c3 As Decimal = 130
        Dim c4 As Decimal = 3000
        Dim c5 As Decimal = 16395
        Dim c6 As Decimal = 20000

        '1st rate <= 365
        If Val(dueamt.Text) <= c1 Then
            intax.Text = 0
            netsal.Text = Val(dueamt.Text)

            '2nd rate <= 110
        ElseIf (Val(dueamt.Text) - c1) <= c2 Then
            Dim d1 As Decimal = Val(dueamt.Text) - c1

            If d1 < c2 Then
                Dim tax As Decimal = (d1) * 0.05
                intax.Text = tax
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)

            ElseIf d1 = c2 Then
                intax.Text = 5.5

                netsal.Text = Val(dueamt.Text) - Val(intax.Text)
            End If

            '3rd rate <= 130
        ElseIf (Val(dueamt.Text) - Val(475)) <= c3 Then
            Dim d2 As Decimal = Val(dueamt.Text) - Val(475)

            If d2 < c3 Then
                Dim tax1 As Decimal = (d2) * 0.1
                intax.Text = tax1 + Val(5.5)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)

            ElseIf d2 = c3 Then

                intax.Text = Val(13) + Val(5.5)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)
            End If

            '4th rate <= 3,000
        ElseIf (Val(dueamt.Text) - Val(605)) <= c4 Then
            Dim d2 As Decimal = Val(dueamt.Text) - Val(605)

            If d2 < c4 Then
                Dim tax1 As Decimal = (d2) * 0.175
                intax.Text = tax1 + Val(5.5) + Val(13)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)
            ElseIf d2 = c4 Then

                intax.Text = Val(525) + Val(5.5) + Val(13)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)

            End If


            '5th rate <= 16,395
        ElseIf (Val(dueamt.Text) - Val(3605)) <= c5 Then
            Dim d2 As Decimal = Val(dueamt.Text) - Val(3605)

            If d2 < c5 Then
                Dim tax1 As Decimal = (d2) * 0.25
                intax.Text = tax1 + Val(5.5) + Val(13) + Val(525)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)
            ElseIf d2 = c5 Then

                intax.Text = Val(525) + Val(5.5) + Val(13) + Val(4098.75)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)

            End If


            '6th rate <= 20,000
        ElseIf (Val(dueamt.Text) - Val(20000)) <= c6 Then
            Dim d2 As Decimal = Val(dueamt.Text) - Val(20000)

            If d2 < c6 Then
                Dim tax1 As Decimal = (d2) * 0.3
                intax.Text = tax1 + Val(5.5) + Val(13) + Val(525) + Val(4098.75)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)
            ElseIf d2 = c6 Then

                intax.Text = Val(525) + Val(5.5) + Val(13) + Val(4098.75) + Val(6000)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)

            End If


            'exceeding > 20,000
        ElseIf (Val(dueamt.Text) - Val(20000)) > c6 Then
            Dim d2 As Decimal = Val(dueamt.Text) - Val(20000)

            If d2 > c6 Then
                Dim tax1 As Decimal = (d2) * 0.3
                intax.Text = tax1 + Val(5.5) + Val(13) + Val(525) + Val(4098.75)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)


            End If
        End If
    End Sub

    Protected Sub allows_TextChanged(sender As Object, e As EventArgs) Handles allows.TextChanged
        dueamt.Text = (Val(bsal.Text) - Val(eyee2.Text) - Val(eyee3.Text)) + Val(allows.Text)
        gross.Text = Val(bsal.Text) + Val(allows.Text)



        'delearing variables chargeable rate
        Dim c1 As Decimal = 365
        Dim c2 As Decimal = 110
        Dim c3 As Decimal = 130
        Dim c4 As Decimal = 3000
        Dim c5 As Decimal = 16395
        Dim c6 As Decimal = 20000

        '1st rate <= 365
        If Val(dueamt.Text) <= c1 Then
            intax.Text = 0
            netsal.Text = Val(dueamt.Text)

            '2nd rate <= 110
        ElseIf (Val(dueamt.Text) - c1) <= c2 Then
            Dim d1 As Decimal = Val(dueamt.Text) - c1

            If d1 < c2 Then
                Dim tax As Decimal = (d1) * 0.05
                intax.Text = tax
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)

            ElseIf d1 = c2 Then
                intax.Text = 5.5

                netsal.Text = Val(dueamt.Text) - Val(intax.Text)
            End If

            '3rd rate <= 130
        ElseIf (Val(dueamt.Text) - Val(475)) <= c3 Then
            Dim d2 As Decimal = Val(dueamt.Text) - Val(475)

            If d2 < c3 Then
                Dim tax1 As Decimal = (d2) * 0.1
                intax.Text = tax1 + Val(5.5)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)

            ElseIf d2 = c3 Then

                intax.Text = Val(13) + Val(5.5)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)
            End If

            '4th rate <= 3,000
        ElseIf (Val(dueamt.Text) - Val(605)) <= c4 Then
            Dim d2 As Decimal = Val(dueamt.Text) - Val(605)

            If d2 < c4 Then
                Dim tax1 As Decimal = (d2) * 0.175
                intax.Text = tax1 + Val(5.5) + Val(13)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)
            ElseIf d2 = c4 Then

                intax.Text = Val(525) + Val(5.5) + Val(13)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)

            End If


            '5th rate <= 16,395
        ElseIf (Val(dueamt.Text) - Val(3605)) <= c5 Then
            Dim d2 As Decimal = Val(dueamt.Text) - Val(3605)

            If d2 < c5 Then
                Dim tax1 As Decimal = (d2) * 0.25
                intax.Text = tax1 + Val(5.5) + Val(13) + Val(525)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)
            ElseIf d2 = c5 Then

                intax.Text = Val(525) + Val(5.5) + Val(13) + Val(4098.75)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)

            End If


            '6th rate <= 20,000
        ElseIf (Val(dueamt.Text) - Val(20000)) <= c6 Then
            Dim d2 As Decimal = Val(dueamt.Text) - Val(20000)

            If d2 < c6 Then
                Dim tax1 As Decimal = (d2) * 0.3
                intax.Text = tax1 + Val(5.5) + Val(13) + Val(525) + Val(4098.75)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)
            ElseIf d2 = c6 Then

                intax.Text = Val(525) + Val(5.5) + Val(13) + Val(4098.75) + Val(6000)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)

            End If


            'exceeding > 20,000
        ElseIf (Val(dueamt.Text) - Val(20000)) > c6 Then
            Dim d2 As Decimal = Val(dueamt.Text) - Val(20000)

            If d2 > c6 Then
                Dim tax1 As Decimal = (d2) * 0.3
                intax.Text = tax1 + Val(5.5) + Val(13) + Val(525) + Val(4098.75)
                netsal.Text = Val(dueamt.Text) - Val(intax.Text)


            End If
        End If
    End Sub

End Class