using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BullshitRPG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            heroHP.Text = hero.CurrentHP();
            monsterHP.Text = monster.CurrentHP();
        }

        Hero hero = new Hero();
        Monster monster = new Monster();

        private void attackButton_Click(object sender, EventArgs e)
        {
            monster.TakeDamage(hero.Attack());
            hero.TakeDamage(monster.Attack());
            reportBox.Text = hero.Report() + monster.Report();
            heroHP.Text = hero.CurrentHP();
            monsterHP.Text = monster.CurrentHP();
            GameOver();
        }

        private void healButton_Click(object sender, EventArgs e)
        {
            hero.Heal();
            monster.Heal();
            hero.TakeDamage(monster.Heal());
            heroHP.Text = hero.CurrentHP();
            monsterHP.Text = monster.CurrentHP();
            reportBox.Text = hero.Report() + monster.Report();
            GameOver();
        }

        public void GameOver()
        {
            if (heroHP.Text == "0" & monsterHP.Text == "0")
                MessageBox.Show("YOU BOTH SUCK!");
            else if (monsterHP.Text == "0" )
                MessageBox.Show("YOU WIN!");
            else if (heroHP.Text == "0")
                MessageBox.Show("YOU LOSE!");
        }
    }
}
