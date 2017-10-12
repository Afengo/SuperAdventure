using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Engine;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();
            _player = new Player(10, 10, 20, 0, 1);
            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

            //Location location = new Location(1, "Home", "This is your house.");

            /*db db1 = new db();
            MySqlDataReader adatok = db1.lekerdezes();
            Dictionary<string, string> helyek = new Dictionary<string, string>();
            while (adatok.Read())
            {
                string nev = adatok.GetString(0);
                string leiras = adatok.GetString(1);
                Console.WriteLine(nev + "," + leiras);
                Location hely = new Location(1, nev, leiras);
                helyek.Add(nev, leiras);
            }
            */

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }

        private void btnWest_Click(object sender, EventArgs e)
        {

        }

        private void btnSouth_Click(object sender, EventArgs e)
        {

        }

        private void btnEast_Click(object sender, EventArgs e)
        {

        }

        private void btnUseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnUsePotion_Click(object sender, EventArgs e)
        {

        }
    }
}
