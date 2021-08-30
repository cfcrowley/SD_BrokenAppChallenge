using System.Collections.Generic;

namespace Pokemon_Repository
{
    public class PokemonRepository
    {
        List<Pokemon> _pokemonTeam = new List<Pokemon>();

        //add to list (limit pokemon to 6)
        public void AddPokemonToTeam(Pokemon pokemon)
        {
            _pokemonTeam.Add(pokemon);
        }
        //get list
        public List<Pokemon> GetPokemonTeam()
        {
            List<Pokemon> allPokes = new List<Pokemon>();
            foreach(Pokemon p in _pokemonTeam)
            {
                allPokes.Add(p);
            }
            return allPokes;
        }
        //get one pokemon
        public Pokemon GetPokemonByTeamPosition(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            return pokemon;
        }
        public Pokemon GetPokemonByNickName(string nickName)
        {
            foreach(Pokemon p in _pokemonTeam)
            {
                if (p.PokemonNickName == nickName)
                {
                    return p;
                }
            }
            return null;
        }
        //update pokemon
        public void UpdatePokemonByTeamPosition(int teamPosition, Pokemon updates)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            pokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
            pokemon.PokemonNickName = updates.PokemonNickName;
            pokemon.Level = updates.Level;
            pokemon.PokemonType = updates.PokemonType;
            pokemon.SecondaryType = updates.SecondaryType;
            pokemon.MoveOne = updates.MoveOne;
            pokemon.MoveTwo = updates.MoveTwo;
            pokemon.MoveThree = updates.MoveThree;
            pokemon.MoveFour = updates.MoveFour;
        }

        public void UpdatePokemonByNickName(string nickName, Pokemon newPokemon)
        {
            Pokemon oldPoke = GetPokemonByNickName(nickName);
            
                if (nickName != null)
                {
                oldPoke.PokemonSpeciesName = newPokemon.PokemonSpeciesName;
                oldPoke.PokemonNickName = newPokemon.PokemonNickName;
                oldPoke.Level = newPokemon.Level;
                oldPoke.PokemonType = newPokemon.PokemonType;
                oldPoke.SecondaryType = newPokemon.SecondaryType;
                oldPoke.MoveOne = newPokemon.MoveOne;
                oldPoke.MoveTwo = newPokemon.MoveTwo;
                oldPoke.MoveThree = newPokemon.MoveThree;
                oldPoke.MoveFour = newPokemon.MoveFour;
                }
            
        }

        //remove pokemon
        public void RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            _pokemonTeam.Remove(pokemon);
        }
    }
}
