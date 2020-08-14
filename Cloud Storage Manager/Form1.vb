Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recentfiles()
    End Sub

    Private Sub recentfiles()
        Guna2DataGridView1.Rows.Add(8)
        Guna2DataGridView1.Rows(0).Cells(0).Value = Image.FromFile("img\\microsoft_word_127px.png")
        Guna2DataGridView1.Rows(0).Cells(1).Value = "Laporan PKL"
        Guna2DataGridView1.Rows(0).Cells(2).Value = "DOCX"
        Guna2DataGridView1.Rows(0).Cells(3).Value = "1.3 MB"
        Guna2DataGridView1.Rows(0).Cells(4).Value = "Jul 15, 2020"
        Guna2DataGridView1.Rows(0).Cells(5).Value = Image.FromFile("img\\menu_vertical_127px.png1.png")

        Guna2DataGridView1.Rows(1).Cells(0).Value = Image.FromFile("img\\microsoft_word_127px.png")
        Guna2DataGridView1.Rows(1).Cells(1).Value = "Project Report"
        Guna2DataGridView1.Rows(1).Cells(2).Value = "DOCX"
        Guna2DataGridView1.Rows(1).Cells(3).Value = "1.3 MB"
        Guna2DataGridView1.Rows(1).Cells(4).Value = "Jul 15, 2020"
        Guna2DataGridView1.Rows(1).Cells(5).Value = Image.FromFile("img\\menu_vertical_127px.png1.png")

        Guna2DataGridView1.Rows(2).Cells(0).Value = Image.FromFile("img\\adobe_xd_127px.png")
        Guna2DataGridView1.Rows(2).Cells(1).Value = "Landing Page"
        Guna2DataGridView1.Rows(2).Cells(2).Value = "XD"
        Guna2DataGridView1.Rows(2).Cells(3).Value = "1.3 MB"
        Guna2DataGridView1.Rows(2).Cells(4).Value = "Jul 15, 2020"
        Guna2DataGridView1.Rows(2).Cells(5).Value = Image.FromFile("img\\menu_vertical_127px.png1.png")

        Guna2DataGridView1.Rows(3).Cells(0).Value = Image.FromFile("img\\microsoft_word_127px.png")
        Guna2DataGridView1.Rows(3).Cells(1).Value = "Laporan PKL"
        Guna2DataGridView1.Rows(3).Cells(2).Value = "DOCX"
        Guna2DataGridView1.Rows(3).Cells(3).Value = "1.3 MB"
        Guna2DataGridView1.Rows(3).Cells(4).Value = "Jul 15, 2020"
        Guna2DataGridView1.Rows(3).Cells(5).Value = Image.FromFile("img\\menu_vertical_127px.png1.png")

        Guna2DataGridView1.Rows(4).Cells(0).Value = Image.FromFile("img\\image_127px.png")
        Guna2DataGridView1.Rows(4).Cells(1).Value = "Logo"
        Guna2DataGridView1.Rows(4).Cells(2).Value = "PNG"
        Guna2DataGridView1.Rows(4).Cells(3).Value = "1.3 MB"
        Guna2DataGridView1.Rows(4).Cells(4).Value = "Jul 15, 2020"
        Guna2DataGridView1.Rows(4).Cells(5).Value = Image.FromFile("img\\menu_vertical_127px.png1.png")


        Guna2DataGridView1.Rows(5).Cells(0).Value = Image.FromFile("img\\image_127px.png")
        Guna2DataGridView1.Rows(5).Cells(1).Value = "Background"
        Guna2DataGridView1.Rows(5).Cells(2).Value = "JPEG"
        Guna2DataGridView1.Rows(5).Cells(3).Value = "1.3 MB"
        Guna2DataGridView1.Rows(5).Cells(4).Value = "Jul 15, 2020"
        Guna2DataGridView1.Rows(5).Cells(5).Value = Image.FromFile("img\\menu_vertical_127px.png1.png")


        Guna2DataGridView1.Rows(6).Cells(0).Value = Image.FromFile("img\\video_file_127px.png")
        Guna2DataGridView1.Rows(6).Cells(1).Value = "MTAL-267189"
        Guna2DataGridView1.Rows(6).Cells(2).Value = "MP4"
        Guna2DataGridView1.Rows(6).Cells(3).Value = "1.3 MB"
        Guna2DataGridView1.Rows(6).Cells(4).Value = "Jul 15, 2020"
        Guna2DataGridView1.Rows(6).Cells(5).Value = Image.FromFile("img\\menu_vertical_127px.png1.png")

        Guna2DataGridView1.Rows(7).Cells(0).Value = Image.FromFile("img\\psd_127px.png")
        Guna2DataGridView1.Rows(7).Cells(1).Value = "uNTITLE_PROJ"
        Guna2DataGridView1.Rows(7).Cells(2).Value = "PSD"
        Guna2DataGridView1.Rows(7).Cells(3).Value = "1.3 MB"
        Guna2DataGridView1.Rows(7).Cells(4).Value = "Jul 15, 2020"
        Guna2DataGridView1.Rows(7).Cells(5).Value = Image.FromFile("img\\menu_vertical_127px.png1.png")


    End Sub

End Class
