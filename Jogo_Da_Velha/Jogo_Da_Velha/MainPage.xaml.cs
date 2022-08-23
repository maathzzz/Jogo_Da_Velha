using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Jogo_Da_Velha
{
    public partial class MainPage : ContentPage
    {
        string vez = "x";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // desabilitando
            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }

            else
            {
                btn.Text = "O";
                vez = "X";
            }

            // verificando se a primeira linha teve vencedores
            if (btn00.Text == "X" && btn01.Text == "X" && btn02.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!", "OK");
                zerar();
            }

            else if (btn00.Text == "O" && btn01.Text == "O" && btn02.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!", "OK");
                zerar();
            }

            // verificando a segunda linha
            if (btn03.Text == "X" && btn04.Text == "X" && btn05.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!", "OK");
                zerar();
            }

            else if (btn03.Text == "O" && btn04.Text == "O" && btn05.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!", "OK");
                zerar();
            }

            // verificando a terceira linha
            if (btn06.Text == "X" && btn07.Text == "X" && btn08.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!", "OK");
                zerar();
            }

            else if (btn06.Text == "O" && btn07.Text == "O" && btn08.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!", "OK");
                zerar();
            }

            // verificando a primeira coluna
            if (btn00.Text == "X" && btn03.Text == "X" && btn06.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!", "OK");
                zerar();
            }

            else if (btn00.Text == "O" && btn03.Text == "O" && btn06.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!", "OK");
                zerar();
            }

            // verificando a segunda coluna
            if (btn01.Text == "X" && btn04.Text == "X" && btn07.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!", "OK");
                zerar();
            }

            else if (btn01.Text == "O" && btn04.Text == "O" && btn07.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!", "OK");
                zerar();
            }

            // verificando a terceira coluna
            if (btn02.Text == "X" && btn05.Text == "X" && btn08.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!", "OK");
                zerar();
            }

            else if (btn02.Text == "O" && btn05.Text == "O" && btn08.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!", "OK");
                zerar();
            }

            // verificando a diagonal 1
            if (btn00.Text == "X" && btn04.Text == "X" && btn08.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!", "OK");
                zerar();
            }

            else if (btn00.Text == "O" && btn04.Text == "O" && btn08.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!", "OK");
                zerar();
            }

            // verificando a diagonal 2
            if (btn02.Text == "X" && btn04.Text == "X" && btn06.Text == "X")
            {
                await DisplayAlert("Parabéns!", "Você ganhou X!!", "OK");
                zerar();
            }

            else if (btn02.Text == "O" && btn04.Text == "O" && btn06.Text == "O")
            {
                await DisplayAlert("Parabéns!", "Você ganhou O!!", "OK");
                zerar();
            }


        }

        void zerar()
        {
            btn00.IsEnabled = true;
            btn00.Text = "";
            btn01.IsEnabled = true;
            btn01.Text = "";
            btn02.IsEnabled = true;
            btn02.Text = "";
            btn03.IsEnabled = true;
            btn03.Text = "";
            btn04.IsEnabled = true;
            btn04.Text = "";
            btn05.IsEnabled = true;
            btn05.Text = "";
            btn06.IsEnabled = true;
            btn06.Text = "";
            btn07.IsEnabled = true;
            btn07.Text = "";
            btn08.IsEnabled = true;
            btn08.Text = "";

        }

        private void Reiniciar_Clicked(object sender, EventArgs e)
        {
            btn00.IsEnabled = true;
            btn00.Text = "";
            btn01.IsEnabled = true;
            btn01.Text = "";
            btn02.IsEnabled = true;
            btn02.Text = "";
            btn03.IsEnabled = true;
            btn03.Text = "";
            btn04.IsEnabled = true;
            btn04.Text = "";
            btn05.IsEnabled = true;
            btn05.Text = "";
            btn06.IsEnabled = true;
            btn06.Text = "";
            btn07.IsEnabled = true;
            btn07.Text = "";
            btn08.IsEnabled = true;
            btn08.Text = "";
        }
    }
}
