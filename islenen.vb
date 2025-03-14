Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Bugün Güzel Bir Gün") 'Form1 başlatıldığında ekrana yazı gelir
        Button3.Enabled = True 'Koyduğumuz butonu basılabilir hale getirir, false yaparsak basılamaz hale getirir.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Ben 1.butonum") 'Form1 içindeki 1.butona basınca yazı gelir
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide() 'Me yazdığımda hangi form üzerinde çalışıyorsam o gizlenir
        Form2.Show() 'Form2 görünür hale gelir
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Ben 3.butonum")
    End Sub
    
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = "Pazartesi" 'bu kodun çalışabilmesi için formumuz üzerinde label bulunması gerekiyor, 4. butona bastığımızda bu label'ın yazısı "içine yazdığımız yazı olacak"
    End Sub
    
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label1.Text = "Salı" 'aynı label'ı başka bir butona basıp başka yazı yazdırabiliriz
    End Sub
    
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label1.Text = "Çarşamba"
    End Sub
    
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PictureBox1.Visible = False 'Bu kodun çalışması için formumuz üzerinde bir adet PictureBox bulunması gerekiyor, kod ise butona basıldığında bu PictureBox'ı görünmez hale getiriyor
    End Sub
    
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PictureBox1.Visible = True 'Bu kod da görünür hale getiriyor
    End Sub
End Class
