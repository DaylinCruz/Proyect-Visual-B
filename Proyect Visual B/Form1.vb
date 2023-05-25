Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Proyect_Visual_B.Animal

Public Class Form1
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.[Exit]()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SendToBack()
    End Sub



    Private Sub btncats_Click(sender As Object, e As EventArgs) Handles btncats.Click
        Dim cats As BindingList(Of Cat) = New BindingList(Of Cat)()
        dgvanimals.DataSource = cats
        Dim cat1 As Cat = New Cat With {
            .breed = "Siamese Cat",
            .name = "Anubis",
            .age = "3 months",
            .price = "2100"
        }
        cats.Add(cat1)
        dgvanimals.Rows(0).Cells(0).Value = "He is very affectionate"
    End Sub

    Private Sub btnbirds_Click(sender As Object, e As EventArgs) Handles btnbirds.Click
        Dim bird As BindingList(Of Bird) = New BindingList(Of Bird)()
        dgvanimals.DataSource = bird
        Dim bird1 As Bird = New Bird With {
            .breed = "Canary",
            .name = "You choose it",
            .age = "1 month",
            .price = "$350"
        }
        bird.Add(bird1)
        dgvanimals.Rows(0).Cells(0).Value = "Sings a lot"
    End Sub

    Private Sub btnreptiles_Click(sender As Object, e As EventArgs) Handles btnreptiles.Click
        Dim reptil As BindingList(Of Reptil) = New BindingList(Of Reptil)()
        dgvanimals.DataSource = reptil
        Dim reptil1 As Reptil = New Reptil With {
            .breed = "Lizard",
            .name = "You choose it",
            .age = "3 months",
            .price = "$250"
        }
        reptil.Add(reptil1)
        dgvanimals.Rows(0).Cells(0).Value = "It´s small, be careful"
    End Sub

    Private Sub btnrodents_Click(sender As Object, e As EventArgs) Handles btnrodents.Click
        Dim rodent As BindingList(Of Rodent) = New BindingList(Of Rodent)()
        dgvanimals.DataSource = rodent
        Dim rodent1 As Rodent = New Rodent With {
            .breed = "Rabbit",
            .name = "You choose it",
            .age = "1 month",
            .price = "$150"
        }
        rodent.Add(rodent1)
        dgvanimals.Rows(0).Cells(0).Value = "Likes to eat nuts, seems, lettuce and other vegetables"
    End Sub

    Private Sub btnfish_Click(sender As Object, e As EventArgs) Handles btnfish.Click
        Dim fish As BindingList(Of Fish) = New BindingList(Of Fish)()
        dgvanimals.DataSource = fish
        Dim fish1 As Fish = New Fish With {
            .breed = "Angelfish",
            .name = "You choose it",
            .age = "1 month",
            .price = "$520"
        }
        fish.Add(fish1)
        dgvanimals.Rows(0).Cells(0).Value = "Keep their water well cleaned and keep in a safe place"
    End Sub

    Private Sub btnfinish_Click(sender As Object, e As EventArgs) Handles btnfinish.Click
        MessageBox.Show("¡Data succesfully saved, we will contact you as soon as posible, good day!")
        txtname.Text = String.Empty
        txtage.Text = String.Empty
        txtphone.Text = String.Empty
    End Sub

    Private Sub btndogs_Click_1(sender As Object, e As EventArgs) Handles btndogs.Click
        Dim dogs As BindingList(Of Dog) = New BindingList(Of Dog)()
        dgvanimals.DataSource = dogs
        Dim dog1 As New Dog With {
            .breed = "Husky",
            .name = "Hachiko",
            .age = "2 months",
            .price = "$3500"}

        dogs.Add(dog1)
        dgvanimals.Rows(0).Cells(0).Value = "They have a lot of energy, they are chewers, look for appropriate toys for their entertainment"
    End Sub


End Class
