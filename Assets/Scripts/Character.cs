using UnityEngine;
using UnityEngine.Analytics;

namespace DefaultNamespace
{
    public class Character : MonoBehaviour
    {
        // public Sprite portrait { get; set; }
        public string Name;
        public string Title;
        public string Description;
        public string Gender;
        public Faction Faction;
        public CSVNameImporter nameGenerator;

        void Start()
        {
            InitializeCharacter();
        }

        void InitializeCharacter()
        {
            nameGenerator = FindAnyObjectByType<CSVNameImporter>();
            if (nameGenerator != null)
            {
                (Name, Gender) = nameGenerator.GenerateRandomName();
                Debug.Log($"{Name} {Gender} from the character class");
            }
            else
            {
                Debug.LogError("CSVNameImporter not found in the scene!");
            }
        }
    }
}