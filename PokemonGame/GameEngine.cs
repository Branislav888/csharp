﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    public class GameEngine
    {
        public Pokemon FirstPokemon { get; set; }
        public Pokemon SecondPokemon { get; set; }
        public GameEngine()
        {
            FirstPokemon = new Pokemon("Pikachu", 200, 1);
            SecondPokemon = new Pokemon("Charizard", 100, 1);
        }
    }
}
