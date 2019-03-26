using System.Collections.Generic;
using System.IO;

namespace DfindTest.Main
{
    public class ProblemC
    {
        public static string SelectHeir(string filePath)
        {
            string inputContent = File.ReadAllText(filePath);
            string[] lines = inputContent.Split('\n');

            string[] nmValues = lines[0].Split(' ');
            int n = int.Parse(nmValues[0].Trim());
            int m = int.Parse(nmValues[1].Trim());

            string founderName = lines[1].Trim();
            Dictionary<string, double> scoreDictionary = new Dictionary<string, double>();
            scoreDictionary.Add(founderName, 1);

            for (int i = 0; i < n; i++)
            {
                string[] relationValues = lines[2 + i].Split(' ');

                string childName = relationValues[0].Trim();
                string parent1 = relationValues[1].Trim();
                string parent2 = relationValues[2].Trim();

                double score = 0;
                if (scoreDictionary.ContainsKey(parent1))
                    score += scoreDictionary[parent1] / 2;
                if (scoreDictionary.ContainsKey(parent2))
                    score += scoreDictionary[parent2] / 2;

                scoreDictionary.Add(childName, score);
            }

            scoreDictionary.Remove(founderName);


            double maxScore = -1;
            string heir = null;
            for (int i = 0; i < m; i++)
            {
                string claimer = lines[2 + n + i].Trim();

                if (scoreDictionary.ContainsKey(claimer) && scoreDictionary[claimer] >= maxScore)
                {
                    heir = claimer;
                    maxScore = scoreDictionary[claimer];
                }
            }

            return heir;
        }
    }
}
