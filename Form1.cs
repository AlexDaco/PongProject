using System.Windows.Forms;

namespace PongProject
{
    public partial class Pong : Form
    {
        // Geschwindigkeitsvariablen
        int cpuDirection = 6;
        int ballXSpeed = 6;
        int ballYSpeed = 6;

        // Punkte Variablen
        int playerscore = 0;
        int cpuscore = 0;

        // Spielfeld Variablen
        int bottomboundary;
        int xmidpoint;

        // Detection Variables
        bool playerdetectedup;
        bool playerdetectedown;

        int spacebarclicked = 0;

        public Pong()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            bottomboundary = ClientSize.Height - player1.Height;
            xmidpoint = ClientSize.Width / 2;
            pongtimer.Interval = 16; // Etwa 60 FPS (1000ms / 60)
        }

        private void Pong_Load(object sender, EventArgs e)
        {
            // Initialisierung nach dem Laden
        }

        private void pongtimer_Tick(object sender, EventArgs e)
        {
            Random newballspot = new Random();
            int newspot = newballspot.Next(100, ClientSize.Height - 100);

            // Bewege den Ball
            pongball.Top -= ballYSpeed;
            pongball.Left -= ballXSpeed;

            // Bewege die CPU
            cpuplayer.Top += cpuDirection;

            // Überprüfe, ob CPU den oberen oder unteren Rand trifft
            if (cpuplayer.Top < 0 || cpuplayer.Top > bottomboundary)
            {
                cpuDirection = -cpuDirection;
            }

            // Ball geht links aus dem Spielfeld (CPU gewinnt einen Punkt)
            if (pongball.Left < 0)
            {
                pongball.Left = xmidpoint;
                pongball.Top = newspot;
                ballXSpeed = -ballXSpeed;
                cpuscore++;
                cpuplayerscoreLabel.Text = cpuscore.ToString();
            }

            // Ball geht rechts aus dem Spielfeld (Spieler gewinnt einen Punkt)
            if (pongball.Left + pongball.Width > ClientSize.Width)
            {
                pongball.Left = xmidpoint;
                pongball.Top = newspot;
                ballXSpeed = -ballXSpeed;
                playerscore++;
                playerScoreLabel.Text = playerscore.ToString();
            }

            // Stelle sicher, dass der Ball innerhalb der vertikalen Grenzen bleibt
            if (pongball.Top < 0 || pongball.Top + pongball.Height > ClientSize.Height)
            {
                ballYSpeed = -ballYSpeed;
            }

            // Überprüfe, ob der Ball den Spieler oder die CPU trifft
            if (pongball.Bounds.IntersectsWith(player1.Bounds) || pongball.Bounds.IntersectsWith(cpuplayer.Bounds))
            {
                ballXSpeed = -ballXSpeed;
            }

            // Bewege den Spieler nach oben
            if (playerdetectedup && player1.Top > 0)
            {
                player1.Top -= 6; // Kleinere Schrittweite für glatte Bewegung
            }

            // Bewege den Spieler nach unten
            if (playerdetectedown && player1.Top < bottomboundary)
            {
                player1.Top += 6; // Kleinere Schrittweite für glatte Bewegung
            }

            // Überprüfe, ob ein Spieler gewonnen hat
            if (playerscore >= 10)
            {
                pongtimer.Stop();
                MessageBox.Show("Player Wins!");
                ResetGame();
            }
            else if (cpuscore >= 10)
            {
                pongtimer.Stop();
                MessageBox.Show("CPU Wins!");
                ResetGame();
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                playerdetectedup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                playerdetectedown = false;
            }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                playerdetectedup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                playerdetectedown = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                if (spacebarclicked % 2 == 0)
                {
                    pongtimer.Stop();
                }
                else
                {
                    pongtimer.Start();
                }
                spacebarclicked++;
            }
        }

        private void ResetGame()
        {
            playerscore = 0;
            cpuscore = 0;
            playerScoreLabel.Text = "0";
            cpuplayerscoreLabel.Text = "0";
            pongball.Left = xmidpoint;
            pongball.Top = ClientSize.Height / 2;
            ballXSpeed = 5;
            ballYSpeed = 5;
            pongtimer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}