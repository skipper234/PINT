using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Data.SQLite;


namespace Interface2_Teste
{

    public partial class Inicio : Form
    {
        Gestor Ges;
        GMapControl gMapControl1;

        public Inicio(Gestor Ges)
        {
            InitializeComponent();

            this.FormClosing += Window_Closing;
            this.Ges = Ges;
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
            #region Desenhar Interface Inicial

            panel_menu.Width = this.ClientSize.Width + 15;

            int x = this.ClientSize.Height - 25;
            x = (x - 60) / 5;

            for (int i = 0; i < 5; i++)
            {
                Panel B = new Panel();
                B.Location = new System.Drawing.Point(10, 35 + i * x + i * 10);
                B.Name = "panel_" + i;
                B.Size = new System.Drawing.Size(250, x);
                B.BackColor = System.Drawing.SystemColors.ButtonHighlight;
                B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                Controls.Add(B);
            }

            Panel P_Mapa = new Panel();
            P_Mapa.Location = new System.Drawing.Point(270, 35);
            P_Mapa.Name = "panel_mapa";
            P_Mapa.Size = new System.Drawing.Size(this.ClientSize.Width - 280, this.ClientSize.Height - 45);
            P_Mapa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            P_Mapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(P_Mapa);

            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();

            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.ShowCenter = false;
            gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemmory = 5;
            gMapControl1.Location = new System.Drawing.Point(0, 0);
            gMapControl1.MarkersEnabled = true;
            gMapControl1.MaxZoom = 2;
            gMapControl1.MinZoom = 2;
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            gMapControl1.Name = "gMapControl1";
            gMapControl1.NegativeMode = false;
            gMapControl1.PolygonsEnabled = false;
            gMapControl1.RetryLoadTile = 0;
            gMapControl1.RoutesEnabled = true;
            gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.Size = new System.Drawing.Size(this.ClientSize.Width - 280, this.ClientSize.Height - 45);
            gMapControl1.TabIndex = 3;
            gMapControl1.Zoom = 0D;
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 20;

            P_Mapa.Controls.Add(gMapControl1);

            #endregion

            #region Defenir Mapa
            //usar o google provider
            gMapControl1.MapProvider = GoogleMapProvider.Instance;
            //obeter imagens apenas do servidor
            gMapControl1.Manager.Mode = AccessMode.ServerAndCache;
            //defenir proxy
            GMapProvider.WebProxy = null;
            //centar o mapa
            gMapControl1.Position = new PointLatLng(40.6566952, -7.9825116);

            //// criar as rotas

            //criar a layr das rotas
            GMapOverlay routesOverlay = new GMapOverlay("routes");
            // defenir pontos fim e inicio
            PointLatLng start = new PointLatLng(40.6698914, -7.9655776);
            PointLatLng end = new PointLatLng(40.7239619, -8.1253347);
            //criar a routa usando um provider
            GDirections route;
            GMapProviders.GoogleMap.GetDirections(out route, start, end, false, false, false, false, false);
            //transformar a routa em GMapRoute para poder ser usada no mapa
            GMapRoute r = new GMapRoute(route.Route, "route1");
            //alterar propriadades da rota
            r.Stroke.Width = 4;
            r.Stroke.Color = Color.RoyalBlue;
            //adicionar a rota a layr
            routesOverlay.Routes.Add(r);

            // 2

            start = new PointLatLng(40.8039619, -8.2253347);
            end = new PointLatLng(40.7239619, -8.1253347);
            //criar a routa usando um provider
            GMapProviders.GoogleMap.GetDirections(out route, start, end, false, false, false, false, false);
            //transformar a routa em GMapRoute para poder ser usada no mapa
            r = new GMapRoute(route.Route, "route2");
            MessageBox.Show(route.DistanceValue.ToString());
            //alterar propriadades da rota
            r.Stroke.Width = 4;
            r.Stroke.Color = Color.RoyalBlue;
            //adicionar a rota a layr
            routesOverlay.Routes.Add(r);


            routesOverlay.Routes.Add(r);

            //adicionar a layr ao mapa
            gMapControl1.Overlays.Add(routesOverlay);

            //// criar os pontos

            //criar a layr dos pontos
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            //criar o primeiro ponto
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(40.6698914, -7.9655776), GMarkerGoogleType.green);
            //adicionar o ponto a layr
            markersOverlay.Markers.Add(marker);
            //criar o segundo ponto
            marker = new GMarkerGoogle(new PointLatLng(40.7239619, -8.1253347), GMarkerGoogleType.green);
            //adicionar o ponto a layr
            markersOverlay.Markers.Add(marker);
            //criar o terceiro ponto
            marker = new GMarkerGoogle(new PointLatLng(40.8039619, -8.2253347), GMarkerGoogleType.red);
            //adicionar o ponto a layr
            markersOverlay.Markers.Add(marker);
            //adicionar a layr ao mapa
            gMapControl1.Overlays.Add(markersOverlay);




            //defenir o zoom NOTA: deve estar aqui para atualizar o mapa
            gMapControl1.Zoom = 11;

            ////clear markers
            //markersOverlay.Markers.Clear();

            #endregion

            #region Desenhar Info

            Panel ctn_panel = (Panel) this.Controls["panel_0"];

            Label lb = new Label();
            lb.Location = new System.Drawing.Point(0, 0);
            lb.Name = "label1";
            lb.Size = new System.Drawing.Size(ctn_panel.Width, ctn_panel.Height / 3);
            lb.Text = "Utilizador";
            lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ctn_panel.Controls.Add(lb);

            lb = new Label();
            lb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb.Location = new System.Drawing.Point(0, ctn_panel.Height / 3);
            lb.Name = "label2";
            lb.Size = new System.Drawing.Size(ctn_panel.Width, ctn_panel.Height / 3);
            lb.Text = Ges.Obeter_Nome_Utilizador_Login();
            lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ctn_panel.Controls.Add(lb);

            lb = new Label();
            lb.Location = new System.Drawing.Point(0, ctn_panel.Height / 3 * 2);
            lb.Name = "label4";
            lb.Size = new System.Drawing.Size(ctn_panel.Width, ctn_panel.Height / 3);
            lb.Text = "(Funcionário)";
            lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ctn_panel.Controls.Add(lb);

            ctn_panel = (Panel)this.Controls["panel_1"];

            lb = new Label();
            lb.Location = new System.Drawing.Point(0, 0);
            lb.Name = "label1";
            lb.Size = new System.Drawing.Size(ctn_panel.Width, ctn_panel.Height / 3);
            lb.Text = "Localização Utilizador";
            lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ctn_panel.Controls.Add(lb);

            lb = new Label();
            lb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb.Location = new System.Drawing.Point(0, ctn_panel.Height / 3);
            lb.Name = "label2";
            lb.Size = new System.Drawing.Size(ctn_panel.Width, ctn_panel.Height / 3);
            lb.Text = "Rua Senhora Graça";
            lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ctn_panel.Controls.Add(lb);

            lb = new Label();
            lb.Location = new System.Drawing.Point(0, ctn_panel.Height / 3 * 2);
            lb.Name = "label4";
            lb.Size = new System.Drawing.Size(ctn_panel.Width, ctn_panel.Height / 3);
            lb.Text = "(Viseu)";
            lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ctn_panel.Controls.Add(lb);

            ctn_panel = (Panel)this.Controls["panel_2"];

            lb = new Label();
            lb.Location = new System.Drawing.Point(0, 0);
            lb.Name = "label1";
            lb.Size = new System.Drawing.Size(ctn_panel.Width, ctn_panel.Height / 3);
            lb.Text = "Proximo P. Interesse";
            lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ctn_panel.Controls.Add(lb);

            lb = new Label();
            lb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb.Location = new System.Drawing.Point(0, ctn_panel.Height / 3);
            lb.Name = "label2";
            lb.Size = new System.Drawing.Size(ctn_panel.Width, ctn_panel.Height / 3);
            lb.Text = "TOMI - 3256";
            lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ctn_panel.Controls.Add(lb);

            lb = new Label();
            lb.Location = new System.Drawing.Point(0, ctn_panel.Height / 3 * 2);
            lb.Name = "label4";
            lb.Size = new System.Drawing.Size(ctn_panel.Width, ctn_panel.Height / 3);
            lb.Text = "(1.3km Restantes)";
            lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ctn_panel.Controls.Add(lb);

            ctn_panel = (Panel)this.Controls["panel_3"];

            lb = new Label();
            lb.Location = new System.Drawing.Point(0, 0);
            lb.Name = "label1";
            lb.Size = new System.Drawing.Size(ctn_panel.Width, ctn_panel.Height / 3);
            lb.Text = "Localização P. Interesse";
            lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ctn_panel.Controls.Add(lb);

            lb = new Label();
            lb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb.Location = new System.Drawing.Point(0, ctn_panel.Height / 3);
            lb.Name = "label2";
            lb.Size = new System.Drawing.Size(ctn_panel.Width, ctn_panel.Height / 3);
            lb.Text = "Quinta Corgo";
            lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ctn_panel.Controls.Add(lb);

            lb = new Label();
            lb.Location = new System.Drawing.Point(0, ctn_panel.Height / 3 * 2);
            lb.Name = "label4";
            lb.Size = new System.Drawing.Size(ctn_panel.Width, ctn_panel.Height / 3);
            lb.Text = "(Viseu)";
            lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ctn_panel.Controls.Add(lb);

            ctn_panel = (Panel)this.Controls["panel_4"];

            lb = new Label();
            lb.Location = new System.Drawing.Point(0, 0);
            lb.Name = "label1";
            lb.Size = new System.Drawing.Size(ctn_panel.Width, ctn_panel.Height / 3);
            lb.Text = "Registar Reparação";
            lb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            ctn_panel.Controls.Add(lb);

            Button bt = new Button();
            bt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bt.Location = new System.Drawing.Point(10, ctn_panel.Height / 3);
            bt.Name = "btn_registar_reparação";
            bt.Size = new System.Drawing.Size(ctn_panel.Width - 22, ctn_panel.Height / 3 * 2 - 11);
            bt.Text = "Iniciar Reparação";
            bt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            bt.UseVisualStyleBackColor = true;
            bt.Enabled = false;
            ctn_panel.Controls.Add(bt);
            


            #endregion

            //menu_utilizador_login.Text = user_login.mostrar();
            menu_utilizador_login.Text = Ges.Obeter_Nome_Utilizador_Login();

        }

        private void Window_Closing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show(this, "Sair da Aplicação?", "Tem a certeza que quer sair da aplicação ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        void Activar_Mapa()
        {
            gMapControl1.Enabled = true;
        }

        private void menu_adicionar_ustilizador_Click(object sender, EventArgs e)
        {
            Adicionar_User a = new Adicionar_User(Ges);
            gMapControl1.Enabled = false;
            a.event_Activar_Mapa += new Activar_Mapa(Activar_Mapa);
            a.Show();
        }

        private void menu_editar_utilizador_Click(object sender, EventArgs e)
        {
            Editar_User a = new Editar_User();
            gMapControl1.Enabled = false;
            a.event_Activar_Mapa += new Activar_Mapa(Activar_Mapa);
            a.Show();
        }

        private void calcularDistanciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PointLatLng start = new PointLatLng(40.713404, -8.131493);
            PointLatLng end = new PointLatLng(40.6439493, -7.9222965);
            GDirections route;
            GMapProviders.GoogleMap.GetDirections(out route, start, end, false, false, false, false, false);
            MessageBox.Show(route.DistanceValue.ToString());
        }
    }
}
