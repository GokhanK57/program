Public Class Form1
    'Form şekli nasıl olmalı hakkında bir fotoğraf bulunmaktadır
    Dim ilksayi, ikincisayi, sonsayi As Double 'Bunlar bizim tanımlamalarımız, evrensel tanımlamalar için Public Class içine, belirli bir grup için tanımlama ise Private Sub altına yazılarak yapılır
    'As Double yazarak bu tanımlamaları bir sayısal değer olarak atamış oldum

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ilksayi = Val(TextBox1.Text) 'Formumuz üzerinde TextBox var ve kullanıcı buraya bir şey yazdığında onun sayısal değerini almasına yarar ve ilksayi'ya eşitler
        ikincisayi = Val(TextBox2.Text) 'Formumuz üzerinde TextBox var ve kullanıcı buraya bir şey yazdığında onun sayısal değerini almasına yarar ve ikincisayi'ya eşitler
        sonsayi = ilksayi + ikincisayi 'ilksayı ve ikincisayıyı sayısal değer olarak toplar
        Label2.Text = sonsayi 'toplamı Label olarak günceller
    End Sub
  
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ilksayi = Val(TextBox1.Text)
        ikincisayi = Val(TextBox2.Text)
        sonsayi = ilksayi - ikincisayi ' Yukarıdaki kodun eksilisi
        Label2.Text = sonsayi
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ilksayi = Val(TextBox1.Text)
        ikincisayi = Val(TextBox2.Text)
        sonsayi = ilksayi / ikincisayi ' Yukarıdaki kodun bölümlüsü
        Label2.Text = sonsayi
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ilksayi = Val(TextBox1.Text)
        ikincisayi = Val(TextBox2.Text)
        sonsayi = ilksayi * ikincisayi ' Yukarıdaki kodun çarpımlısı
        Label2.Text = sonsayi
    End Sub
End Class
