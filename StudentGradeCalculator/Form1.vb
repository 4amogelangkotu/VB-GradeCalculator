Public Class GradeCalculator
    
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        'variables
        Dim studentName As String = txtName.Text
        Dim grades(6) As Double
        Dim total As Double = 0
        Dim aps As Integer = 0
        Dim avg As Double = 0
        Dim nDis As Integer = 0

        'input validation and calculation
        Try
            'putting textbox inputs into the grade array
            grades(0) = Double.Parse(txtHL.Text)
            grades(1) = Double.Parse(txtFA.Text)
            grades(2) = Double.Parse(txtMA.Text)
            grades(3) = Double.Parse(txtLO.Text)
            grades(4) = Double.Parse(txtS1.Text)
            grades(5) = Double.Parse(txtS2.Text)
            grades(6) = Double.Parse(txtS3.Text)

            'calculating the number of distinctions, APS score, and the average grade
            For i As Integer = 0 To grades.Length - 1
                If grades(i) >= 80 Then
                    nDis += 1
                End If

                If i <> 3 Then
                    aps += CalculateAPS(grades(i))
                End If

                total += grades(i)
            Next

            avg = Math.Round((total / grades.Length), 2) 'rounding off to two decimals

            'displaying to textboxes
            txtAvg.Text = avg.ToString()
            txtAPS.Text = aps.ToString()

            'displaying to a messagebox
            MessageBox.Show(studentName & " has an average of " & avg & " with " & nDis & " distictions and an APS score of " & aps, "Results", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Please enter valid numeric grades!", "Input error.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    'function to calculate the APS point for a subject
    Private Function CalculateAPS(mark As Double) As Integer
        Select Case mark
            Case >= 80
                Return 7
            Case >= 70
                Return 6
            Case >= 60
                Return 5
            Case >= 50
                Return 4
            Case >= 40
                Return 3
            Case >= 30
                Return 2
            Case Else
                Return 1
        End Select
    End Function
End Class
