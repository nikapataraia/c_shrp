using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spore
{
    internal class evolution_map
    {
        private Dictionary<int, String> map = new Dictionary<int, String>();
        private int lastloadin = 0;
        public evolution_map()
        {
            generate_evolutions(2000);
        }

        private string GetRandomEvolution() {

            string[] possibleEvolutionsWithoutBody = constants.abilities
    .Where(x => x.name != "body")
    .Select(x => x.name)
    .ToArray();

            string[] finalPossibleEvolutions = possibleEvolutionsWithoutBody
                .Where(name => !possibleEvolutionsWithoutBody.Contains(name))
                .ToArray();
            Random rand = new Random();
            int index = rand.Next(finalPossibleEvolutions.Length);
            return finalPossibleEvolutions[index];
        }

        public void generate_evolutions(int chunk)
        {
            if(chunk <= lastloadin)
            {
                return;
            }
            Random rand = new Random();
            int numberOfEvolutions = rand.Next(0, (chunk - lastloadin)/5);
            for (int i = 0; i < numberOfEvolutions; i++)
            {
                int randomPosition = rand.Next(lastloadin, chunk);
                if (!map.ContainsKey(randomPosition))
                {
                    string evolutionType = GetRandomEvolution();
                    map[randomPosition] = evolutionType;
                }
                else
                {
                    i -= 1;
                }
            }
            lastloadin = chunk;

        }

        public int get_last_loaded_chunk()
        {
            return lastloadin;
        }

        public String get_evolution(int cord)
        {
            String result = map[cord];
            map.Remove(cord);
            return result;
        }

        public Boolean check_location(int cord)
        {
            return map.ContainsKey(cord);
        }
        

        public void restart()
        {
            lastloadin = 0;

        }

    }
}
