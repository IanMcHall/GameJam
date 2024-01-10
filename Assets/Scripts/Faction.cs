using UnityEngine;

namespace DefaultNamespace
{
    public class Faction : MonoBehaviour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Measurement of a character's ties to a specific faction; the higher, the more tied to that faction the character is
        public float Value { get; set; }
    }
}