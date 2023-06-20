using System.Drawing;
using System.Media;
using System.Windows.Forms;
using Tulpep.NotificationWindow;


namespace AppCaldeirasV2
{
    public static class Notificacao
    {
        public static void Notificar(string Titulo,string Dado)
        {

            PopupNotifier popup = new PopupNotifier();
            popup.BodyColor = Color.DarkRed;
            popup.AnimationDuration = 100;
            popup.Delay = 10000;
            //popup.Image = Resources.sinal_de_aviso;
            popup.TitleText = Titulo;
            popup.TitleColor = Color.White;
            popup.TitlePadding = new Padding(0, 0, 100, 0);
            popup.TitleFont = new Font("Segoe UI", 20, FontStyle.Bold);
            popup.ContentText = "Níveis de "+ Dado + " fora do normal.\r\n Favor verificar";
            popup.ContentColor = Color.White;
            popup.ContentFont = new Font("Segoe UI", 12);
            popup.Popup();

            SystemSounds.Hand.Play();

        }

    }
}

