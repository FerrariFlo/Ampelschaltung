using System.Windows.Forms;

namespace INF_Übungsbeispiel_Ampelschaltung
{
    public partial class Form1 : Form
    {
        private int speed = 10; // Geschwindigkeit des Autos
        private bool isGreen = true; //Zustand der Ampel


        public Form1()
        {
            InitializeComponent();

            // Ereignisse verknüpfen
            tmr1.Tick += Tmr1_Tick; // Auto-Timer
            tmrTrafficLight.Tick += TmrTrafficLight_Tick; // Ampel-Timer

            rbtnManual.CheckedChanged += RbtnManual_CheckedChanged;
            rbtnAutomatic.CheckedChanged += RbtnAutomatic_CheckedChanged;

            btnToGreen.Click += BtnToGreen_Click;
            btnToRed.Click += BtnToRed_Click;

            // Standard: Manuelle Steuerung
            SetManualMode();
            tmr1.Start(); // Auto startet sofort
        }

        // Timer-Tick-Ereignis
        private void Tmr1_Tick(object sender, EventArgs e)
        {
            MoveCar();
        }

        // Timer-Tick: Automatische Ampelsteuerung
        private void TmrTrafficLight_Tick(object sender, EventArgs e)
        {
            // Zustand umschalten
            ToggleTrafficLight();

            // Dauer basierend auf aktuellem Zustand setzen
            if (isGreen)
            {
                // Grünphase
                int greenDuration = GetPhaseDuration(txtGreenDuration, 3); // Standard 3 Sekunden
                tmrTrafficLight.Interval = greenDuration * 1000; // In Millisekunden
            }
            else
            {
                // Rotphase
                int redDuration = GetPhaseDuration(txtRedDuration, 3); // Standard 3 Sekunden
                tmrTrafficLight.Interval = redDuration * 1000; // In Millisekunden
            }
        }


        private int GetPhaseDuration(TextBox textBox, int defaultValue)
        {
            int duration;
            while (true)
            {
                if (int.TryParse(textBox.Text, out duration) && duration >= 2 && duration <= 10)
                {
                    return duration; // Gültiger Wert zwischen 2 und 10 Sekunden
                }

                // Ungültige Eingabe: Standardwert verwenden und Benutzer benachrichtigen
                MessageBox.Show($"Bitte geben Sie einen gültigen Wert zwischen 2 und 10 Sekunden in '{textBox.Name}' ein.",
                                "Ungültige Eingabe",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                // Fokus auf die fehlerhafte TextBox setzen
                textBox.Focus();
                textBox.Text = defaultValue.ToString(); // Standardwert setzen
            }
        }

        // Bewegung des Autos
        private void MoveCar()
        {
            // Ampelposition ermitteln
            int trafficLightX = pnlTrafficLight.Left;
            int trafficLightWidth = pnlTrafficLight.Width;

            // Auto soll anhalten, wenn die Ampel rot ist und sich das Auto noch vor der Ampel befindet
            if (!isGreen && pnlCar.Right > trafficLightX && pnlCar.Left <= trafficLightX + trafficLightWidth)
            {
                // Auto bleibt auf Höhe der Ampel stehen
                return;
            }

            // Auto bewegt sich weiter, wenn die Ampel grün ist oder es die Ampel passiert hat
            pnlCar.Left -= speed;

            // Wenn das Auto den linken Bildschirmrand verlässt
            if (pnlCar.Right < 0)
            {
                pnlCar.Left = ClientSize.Width; // Auto rechts neu positionieren
            }
        }


        // Manuelle Schaltung: Schalte auf Grün
        private void BtnToGreen_Click(object sender, EventArgs e)
        {
            isGreen = true;
            UpdateTrafficLight();
        }

        // Manuelle Schaltung: Schalte auf Rot
        private void BtnToRed_Click(object sender, EventArgs e)
        {
            isGreen = false;
            UpdateTrafficLight();
        }

        // Automatische Schaltung: Ampel umschalten
        private void ToggleTrafficLight()
        {
            isGreen = !isGreen;
            UpdateTrafficLight();
        }

        // Aktualisiere die Farbe der Ampel
        private void UpdateTrafficLight()
        {
            if (isGreen)
            {
                pnlTrafficLight.BackColor = Color.Green;
            }
            else
            {
                pnlTrafficLight.BackColor = Color.Red;
            }
        }

        // Modus: Manuelle Steuerung
        private void SetManualMode()
        {
            tmrTrafficLight.Stop(); // Automatik-Timer stoppen
            btnToGreen.Enabled = true;
            btnToRed.Enabled = true;
        }

        // Modus: Automatische Steuerung
        private void SetAutomaticMode()
        {
            tmrTrafficLight.Interval = 3000; // Wechselt alle 3 Sekunden
            tmrTrafficLight.Start();
            btnToGreen.Enabled = false;
            btnToRed.Enabled = false;
        }

        // RadioButton: Manuelle Steuerung
        private void RbtnManual_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnManual.Checked)
            {
                SetManualMode();
            }
        }

        // RadioButton: Automatische Steuerung
        private void RbtnAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAutomatic.Checked)
            {
                SetAutomaticMode();
            }
        }
    }
}
    

