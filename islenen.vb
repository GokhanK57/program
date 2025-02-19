Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Bugün Güzel Bir Gün") 'Form1 başlatıldığında ekrana yazı gelir
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Ben 1.butonum") 'Form1 içindeki 1.butona basınca yazı gelir
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide() 'Me yazdığımda hangi form üzerinde çalışıyorsam o gizlenir
        Form2.Show() 'Form2 görünür hale gelir
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show("Ben 4.butonum")
    End Sub
End Class
