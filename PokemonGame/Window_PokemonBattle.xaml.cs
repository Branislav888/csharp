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

namespace PokemonGame
{
    /// <summary>
    /// Interaction logic for Window_PokemonBattle.xaml
    /// </summary>
    public partial class Window_PokemonBattle : Window
    {
        public GameEngine gameEngine { get; set; } = new GameEngine();   
        public Window_PokemonBattle()
        {
            InitializeComponent();

            RefreshElements();

        }
        private void RefreshElements()
        {
            ProgressBar_Pokemon1_HP.Value = gameEngine.FirstPokemon.Health;
            Label_Pokemon1_HP.Content = $"{gameEngine.FirstPokemon.Health}/ 100";

            ProgressBar_Pokemon2_HP.Value = gameEngine.SecondPokemon.Health;
            Label_Pokemon2_HP.Content = $"{gameEngine.SecondPokemon.Health}/ 100";
        }
        private void ATAttack()
        {
            Random rnd = new Random();
            var value = rnd.Next(10, 91);

            if (value < 33)
            {
                var damage = gameEnginePokemon.Attack1();
                var pokemonSurvived = gameEngine.FirstPokemon.TakeDamage(damage);

            }
            else if (value > 33 &&  value < 90)
            {
                var damage = gameEngine.SecondPokemon.Attack2();
                var pokemonSurvived = gameEngine.FirstPokemon.TakeDamage(damage);
            }
            else if (value > 80 )
            {
                  var damage = gameEngine.SecondPokemon.Attack3();
                  var pokemonSurvived = gameEngine.FirstPokemon.TakeDamage(damage);
            }
            else if (value >

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var damege = gameEngine.FirstPokemon.Attack1();
            var pokemonSurvived = gameEngine.SecondPokemon.TakeDamage(damege);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var damege = gameEngine.FirstPokemon.Attack1();
            var pokemonSurvived = gameEngine.SecondPokemon.TakeDamage(damege);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var damege = gameEngine.FirstPokemon.Attack1();
            var pokemonSurvived = gameEngine.SecondPokemon.TakeDamage(damege);
        }
    }
}
