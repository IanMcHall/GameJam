using UnityEngine;

namespace DefaultNamespace
{
    public class Character : MonoBehaviour
    {
        // public Sprite portrait {  get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Faction Faction { get; set; }

    }
}