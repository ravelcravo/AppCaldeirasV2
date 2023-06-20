using AppCaldeirasV2.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppCaldeirasV2
{
    public static class Caldeira
    {

        public static void GerarCaldeiraColunas(Chart chart, string Caldeira, int NumCaldeira)
        {
            Banco banco = new Banco();
            List<string> listaDados = new List<string>();

            chart.Series.Clear();
            chart.Legends.Clear();
            chart.Titles.Clear();

            Title title = new Title();
            title.Font = new Font("Segoe UI", 20, FontStyle.Regular);
            title.ForeColor = Color.White;
            chart.Titles.Add(title);

            Legend legend = new Legend();
            legend.BackColor = Color.LightGray;
            chart.Legends.Add(legend);

            chart.BorderlineDashStyle = ChartDashStyle.Solid;
            chart.BorderlineColor = Color.WhiteSmoke;

            chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
            chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;
            chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            chart.BackColor = Color.Black;
            chart.ChartAreas[0].BackColor = Color.Black;
            chart.ForeColor = Color.White;

            chart.Series.Add("Valores Mínimos");
            chart.Series["Valores Mínimos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart.Series["Valores Mínimos"].Points.AddXY("Pressão", NiveisIndicadores.NivelMinimoPressao);
            chart.Series["Valores Mínimos"].Points.AddXY("Temperatura", NiveisIndicadores.NivelMinimoPressao);
            chart.Series["Valores Mínimos"].Points.AddXY("Nível da Água", NiveisIndicadores.NivelMinimoAgua);
            chart.Series["Valores Mínimos"].Points.AddXY("Nivel do Combustível", NiveisIndicadores.NivelMinimoCombustivel);


            chart.Series["Valores Mínimos"].Color = Color.FromArgb(192, 57, 43);
            //chart.Series["Valores Mínimos"].BackSecondaryColor = Color.DarkGray;
            chart.Series["Valores Mínimos"].LabelForeColor = Color.White;
            //chart.Series["Valores Mínimos"].BackGradientStyle = GradientStyle.TopBottom;
            chart.Series["Valores Mínimos"].IsValueShownAsLabel = true;
            //chart.Series["Valores Mínimos"].MarkerColor = Color.White;
            chart.ChartAreas[0].RecalculateAxesScale();

            chart.Series.Add("Valores Atuais");
            chart.Series["Valores Atuais"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            listaDados = banco.BuscarUltimoStatusCaldeira(Caldeira);

            double pressao = Convert.ToDouble(listaDados[0].ToString());
            double temperatura = Convert.ToDouble(listaDados[1].ToString());
            double nivelAgua = Convert.ToDouble(listaDados[2].ToString());
            double NivelCombustivel = Convert.ToDouble(listaDados[3].ToString());
            string Status = listaDados[4].ToString();
            chart.Text = $"Caldeira: {NumCaldeira}   Situação: {Status}";

            title.Text = chart.Text;


            chart.Series["Valores Atuais"].Points.AddXY("Pressão", pressao);
            chart.Series["Valores Atuais"].Points.AddXY("Temperatura", temperatura);
            chart.Series["Valores Atuais"].Points.AddXY("Nível da Água", nivelAgua);
            chart.Series["Valores Atuais"].Points.AddXY("Nível do Combustível", NivelCombustivel);
            chart.Series["Valores Atuais"].Color = Color.FromArgb(39, 174, 96);
            //chart.Series["Valores Atuais"].BackSecondaryColor = Color.Red;
            chart.Series["Valores Atuais"].LabelForeColor = Color.White;
            //chart.Series["Valores Atuais"].BackGradientStyle = GradientStyle.TopBottom;
            chart.Series["Valores Atuais"].IsValueShownAsLabel = true;
            //chart.Series["ValoresBanco"].MarkerColor = Color.White;
            chart.ChartAreas[0].RecalculateAxesScale();

          

            chart.Series.Add("Valores Máximos");
            chart.Series["Valores Máximos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chart.Series["Valores Máximos"].Points.AddXY("Pressão", NiveisIndicadores.NivelMaximoPressao);
            chart.Series["Valores Máximos"].Points.AddXY("Temperatura", NiveisIndicadores.NivelMaximoTemperatura);
            chart.Series["Valores Máximos"].Points.AddXY("Nível da Água", NiveisIndicadores.NivelMaximoAgua);
            chart.Series["Valores Máximos"].Points.AddXY("Nivel do Combustível",NiveisIndicadores.NivelMaximoCombustivel);


            chart.Series["Valores Máximos"].Color = Color.FromArgb(30, 55, 153);
            //chart.Series["Valores Máximos"].BackSecondaryColor = Color.DarkGray;
            chart.Series["Valores Máximos"].LabelForeColor = Color.White;
            //chart.Series["Valores Máximos"].BackGradientStyle = GradientStyle.TopBottom;
            chart.Series["Valores Máximos"].IsValueShownAsLabel = true;
            //chart.Series["Valores Máximos"].MarkerColor = Color.White;
            chart.ChartAreas[0].RecalculateAxesScale();

           // VerificarNiveis(Caldeira, pressao, nivelAgua, NivelCombustivel, temperatura);

        }
        public static void GerarMediaIndicadores(Chart chart, string Caldeira, int NumCaldeira)
        {
            Banco banco = new Banco();
            List<string> listaDados = new List<string>();

            chart.Series.Clear();
            chart.Legends.Clear();
            chart.Titles.Clear();

            //Title title = new Title();
            //title.Font = new Font("Segoe UI", 20, FontStyle.Regular);
            //title.ForeColor = Color.White;
            //chart.Titles.Add(title);

            chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
            chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;
            chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;

            chart.BackColor = Color.Black;
            chart.ChartAreas[0].BackColor = Color.Black;
            chart.ForeColor = Color.White;

            chart.Series.Add("ValoresBanco");
            chart.Series["ValoresBanco"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            listaDados = banco.BuscarMediaIndicadores(Caldeira);

            double pressao = Convert.ToDouble(listaDados[0].ToString());
            double temperatura = Convert.ToDouble(listaDados[1].ToString());
            double nivelAgua = Convert.ToDouble(listaDados[2].ToString());
            double NivelCombustivel = Convert.ToDouble(listaDados[3].ToString());


            chart.Series["ValoresBanco"].Points.AddXY("Temperatura", temperatura);
            chart.Series["ValoresBanco"].Points[0].Color = Color.FromArgb(192, 57, 43);
            chart.Series["ValoresBanco"].Points.AddXY("Nível da Água", nivelAgua);
            chart.Series["ValoresBanco"].Points[1].Color = Color.FromArgb(41, 128, 185);
            chart.Series["ValoresBanco"].Points.AddXY("Nível do Combustível", NivelCombustivel);
            chart.Series["ValoresBanco"].Points[2].Color = Color.FromArgb(211, 84, 0);
            chart.Series["ValoresBanco"].Points.AddXY("Pressão", pressao);
            chart.Series["ValoresBanco"].Points[3].Color = Color.FromArgb(52, 73, 94);

            chart.Series["ValoresBanco"].Color = Color.FromArgb(22, 160, 133);
            //chart.Series["ValoresBanco"].BackSecondaryColor = Color.Blue;
            chart.Series["ValoresBanco"].LabelForeColor = Color.White;
            //chart.Series["ValoresBanco"].BackGradientStyle = GradientStyle.TopBottom;
            chart.Series["ValoresBanco"].IsValueShownAsLabel = true;
            //chart.Series["ValoresBanco"].MarkerColor = Color.AliceBlue;
            chart.ChartAreas[0].RecalculateAxesScale();

            //chart.Series.Add("ValoresMaximos");
            //chart.Series["ValoresMaximos"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

            //chart.Series["ValoresMaximos"].Points.AddXY("Pressão", 1000);
            //chart.Series["ValoresMaximos"].Points.AddXY("Temperatura", 500);
            //chart.Series["ValoresMaximos"].Points.AddXY("NivelAgua", 85);
            //chart.Series["ValoresMaximos"].Points.AddXY("NivelCombustivel", 80);

            //chart.Series["ValoresMaximos"].Color = Color.Green;
            //chart.Series["ValoresMaximos"].BackSecondaryColor = Color.DarkGray;
            //chart.Series["ValoresMaximos"].LabelForeColor = Color.White;
            //chart.Series["ValoresMaximos"].BackGradientStyle = GradientStyle.TopBottom;
            //chart.Series["ValoresMaximos"].IsValueShownAsLabel = true;
            //chart.Series["ValoresMaximos"].MarkerColor = Color.White;
            //chart.ChartAreas[0].RecalculateAxesScale();


        }
        public static void GerarTimeLine(Chart chart, string Caldeira, int NumCaldeira,string TipoIndicador,Color cor)
        {
            Banco banco = new Banco();
            List<string> listaDados = new List<string>();

            chart.Series.Clear();
            chart.Legends.Clear();
            chart.Titles.Clear();

            Title title = new Title();
            title.Font = new Font("Segoe UI", 20, FontStyle.Regular);
            title.ForeColor = Color.White;
            chart.Titles.Add(title);

            chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 1;
            chart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 1;
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.White;
            chart.ChartAreas[0].AxisX.LineColor = Color.White;
            chart.ChartAreas[0].AxisY.LineColor = Color.White;

            chart.BackColor = Color.Black;
            chart.ChartAreas[0].BackColor = Color.Black;
            chart.ForeColor = Color.White;

            chart.BorderlineDashStyle = ChartDashStyle.Solid;
            chart.BorderlineColor = Color.LightGray;

            chart.Series.Add("ValoresBanco");
            chart.Series["ValoresBanco"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;

            listaDados = banco.BuscarUltimo100RegistrosPorIndicador(Caldeira,TipoIndicador);

            double pressao = 0;

            for (int i = 0; i < listaDados.Count; i++)
            {
                 pressao = Convert.ToDouble(listaDados[i].ToString());

                chart.Series["ValoresBanco"].Points.Add(pressao);
            }

            chart.Series["ValoresBanco"].Color = cor;
            //chart.Series["ValoresBanco"].BackSecondaryColor = Color.AliceBlue;
            chart.Series["ValoresBanco"].LabelForeColor = Color.White;
            //chart.Series["ValoresBanco"].BackGradientStyle = GradientStyle.TopBottom;
            chart.Series["ValoresBanco"].IsValueShownAsLabel = true;
            //chart.Series["ValoresBanco"].MarkerColor = Color.White;
            chart.ChartAreas[0].RecalculateAxesScale();



        }

        public static async void VerificarNiveis(string Caldeira,double pressao,double nivelAgua,double NivelCombustivel,double temperatura)
        {
            if (pressao > NiveisIndicadores.NivelMaximoPressao || pressao < NiveisIndicadores.NivelMinimoPressao)
            {
                Notificacao.Notificar(Caldeira, "Pressao");
                await Discord.EnviarAlertaDiscord(Sistema.WebHook,Caldeira  + " com niveis de Pressão fora do normal");
            }
            if (nivelAgua < NiveisIndicadores.NivelMinimoAgua)
            {
                Notificacao.Notificar(Caldeira, "Nível Agua");
                await Discord.EnviarAlertaDiscord(Sistema.WebHook, Caldeira + " com niveis de Agua abaixo do normal");
            }
            if (NivelCombustivel < NiveisIndicadores.NivelMinimoCombustivel)
            {
                Notificacao.Notificar(Caldeira, "Nível Combustivel");
                await Discord.EnviarAlertaDiscord(Sistema.WebHook, Caldeira + " com niveis de Combustivel abaixo do normal");
            }
            if (temperatura > NiveisIndicadores.NivelMaximoTemperatura || temperatura < NiveisIndicadores.NivelMinimoTemperatura)
            {
                Notificacao.Notificar(Caldeira, "Temperatura");
                await Discord.EnviarAlertaDiscord(Sistema.WebHook, Caldeira + " com niveis de Temperatura fora do normal");
            }


        }
    }
}
