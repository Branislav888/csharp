using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace PokemonGame
{
    /// <summary>
    /// Interaction logic for Window_PokemonBattle.xaml
    /// </summary>
    public partial class Window_PokemonBattle : Window
    {
        public GameEngine gameEngine { get; set; } = new GameEngine();
        public List<string> FightLogger { get; set; } = new List<string>();
        public Window_PokemonBattle()
        {
            InitializeComponent();

            RefreshElements();

        }
        private void RefreshElements()
        {
            //Zobrazenie spravneho poctu zivotov
            ProgressBar_Pokemon1_HP.Value = gameEngine.FirstPokemon.Health;
            Label_Pokemon1_HP.Content = $"{gameEngine.FirstPokemon.Health}/ 100";

            ProgressBar_Pokemon2_HP.Value = gameEngine.SecondPokemon.Health;
            Label_Pokemon2_HP.Content = $"{gameEngine.SecondPokemon.Health}/ 100";

            ListView_FightLogger.Items.Clear();
            foreach (var log in FightLogger)
            {
                ListView_FightLogger.Items.Add(log);
            }

            if (gameEngine.FirstPokemon.Health <= 0)
            {
                Label_Pokemon1_HP.Content = "LOSER!";
                Label_Pokemon2_HP.Content = "WINNER!";
            }

            if (gameEngine.SecondPokemon.Health <= 0)
            {    
                Label_Pokemon1_HP.Content = "WINNER!";
                Label_Pokemon2_HP.Content = "LOSER!";
            }
            if (gameEngine.SecondPokemon.Health <= 0 && gameEngine.FirstPokemon.Health <= 0)
            {
                Button_LA.IsEnabled = false;
                Button_MA.IsEnabled = false;
                Button_HA.IsEnabled = false;
                Button_Heal.IsEnabled = false;
            }

        }
        private void ATAttack()
        {
            Random rnd = new Random();
            var value = rnd.Next(0, 99);

            if (value < 10)
            {
                var damage = gameEngine.FirstPokemon.Attack1();
                var pokemonSurvived = gameEngine.FirstPokemon.TakeDamage(damage);
                FightLogger.Add($"{gameEngine.SecondPokemon.Name} used Light Attack and dealt {damage} damage to {gameEngine.FirstPokemon.Name}");

            }
            else if (value >= 10 &&  value < 30)
            {
                var damage = gameEngine.SecondPokemon.Attack2();
                var pokemonSurvived = gameEngine.FirstPokemon.TakeDamage(damage);
                FightLogger.Add($"{gameEngine.SecondPokemon.Name} used Medium Attack and dealt {damage} damage to {gameEngine.FirstPokemon.Name}");
            }
            else if (value >= 30 && value < 80)
            {
                var damage = gameEngine.SecondPokemon.Attack3();
                var pokemonSurvived = gameEngine.FirstPokemon.TakeDamage(damage);
                FightLogger.Add($"{gameEngine.SecondPokemon.Name} used High Attack and dealt {damage} damage to {gameEngine.FirstPokemon.Name}");
            }
            else if (value >= 80)
            {
                var heal = gameEngine.SecondPokemon.Heal();
                FightLogger.Add($"{gameEngine.SecondPokemon.Name} used Heal.");
            }

        }
        //Light Attack
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var damege = gameEngine.FirstPokemon.Attack1();
            var pokemonSurvived = gameEngine.SecondPokemon.TakeDamage(damege);
            FightLogger.Add($"{gameEngine.FirstPokemon.Name} used Light Attack and dealt {damege} damage to {gameEngine.SecondPokemon.Name}");

            if (pokemonSurvived)
            {
                ATAttack();
            }

                   
            RefreshElements();
        }
        //Medium Attack
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var damege = gameEngine.FirstPokemon.Attack1();
            var pokemonSurvived = gameEngine.SecondPokemon.TakeDamage(damege);
            FightLogger.Add($"{gameEngine.FirstPokemon.Name} used Medium Attack and dealt {damege} damage to {gameEngine.SecondPokemon.Name}");

            if (pokemonSurvived)
            {
                ATAttack();
            }

            ATAttack();
            RefreshElements();
        }
        //Hard Attack
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var damege = gameEngine.FirstPokemon.Attack1();
            var pokemonSurvived = gameEngine.SecondPokemon.TakeDamage(damege);
            FightLogger.Add($"{gameEngine.FirstPokemon.Name} used High Attack and dealt {damege} damage to {gameEngine.SecondPokemon.Name}");

            if (pokemonSurvived)
            {
                ATAttack();
            }

            ATAttack();
            RefreshElements();
        }
        //Heal
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var heal = gameEngine.FirstPokemon.Heal();
            gameEngine.FirstPokemon.TakeHeal(heal);
            FightLogger.Add($"{gameEngine.FirstPokemon.Name} used Heal and was healt {heal}.");

           
            RefreshElements();
        }

         
    }
}
