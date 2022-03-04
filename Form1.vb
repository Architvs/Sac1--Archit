Public Class Form1
    Dim english As Integer
    Dim math As Integer
    Dim PE As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Text = "         ENGLISH         " & "         " & "         Maths         " & "         " & "            PE         "


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_markscore.Click



        TextBox2.Text = InputBox("how many marks would you like to award for John's english")
        english = TextBox2.Text


        TextBox7.Text = InputBox("how many marks would you like to award for John's math")
        math = TextBox7.Text

        TextBox6.Text = InputBox("how many marks would you like to award for John's pe")
        PE = TextBox6.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_damienscore.Click


        TextBox5.Text = InputBox("how many marks would you like to award for Damien's english")
        english = TextBox5.Text


        TextBox4.Text = InputBox("how many marks would you like to award for Damien's math")
        math = TextBox4.Text

        TextBox3.Text = InputBox("how many marks would you like to award for Damien's pe")
        PE = TextBox3.Text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnmarkscore.Click

        TextBox10.Text = InputBox("how many marks would you like to award for Mark's english")
        english = TextBox10.Text


        TextBox9.Text = InputBox("how many marks would you like to award for Mark's math")
        math = TextBox9.Text

        TextBox8.Text = InputBox("how many marks would you like to award for Mark's pe")
        PE = TextBox8.Text


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnjoshuascore.Click

        TextBox14.Text = InputBox("how many marks would you like to award for Joshua's english")
        english = TextBox14.Text


        TextBox13.Text = InputBox("how many marks would you like to award for Joshua's math")
        math = TextBox13.Text

        TextBox11.Text = InputBox("how many marks would you like to award for Joshua's pe")
        PE = TextBox11.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnmariascore.Click

        TextBox19.Text = InputBox("how many marks would you like to award for Maria’s english")
        english = TextBox19.Text


        TextBox18.Text = InputBox("how many marks would you like to award for Maria’s math")
        math = TextBox18.Text

        TextBox17.Text = InputBox("how many marks would you like to award for Maria’s pe")
        PE = TextBox17.Text

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnmaryscore.Click
        TextBox12.Text = InputBox("how many marks would you like to award for Mary’s english")
        english = TextBox12.Text


        TextBox16.Text = InputBox("how many marks would you like to award for Mary’s math")
        math = TextBox16.Text

        TextBox15.Text = InputBox("how many marks would you like to award for Mary's pe")
        PE = TextBox15.Text
    End Sub
End Class
