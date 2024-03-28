using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVNameImporter : MonoBehaviour
{
    public Dictionary<string, List<string>> nameDictionary = new Dictionary<string, List<string>>();

    void Start()
    {
        LoadNamesFromCSV("Names.csv");
        GenerateRandomName();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            GenerateRandomName();
        }
    }

    private void LoadNamesFromCSV(string fileName)
    {
        string filePath = Path.Combine(Application.dataPath, "Data", fileName);

        if (!File.Exists(filePath))
        {
            Debug.LogError("CSV file not found: " + filePath);
            return;
        }

        string[] lines = File.ReadAllLines(filePath);

        // Skip the first row (header row)
        if (lines.Length > 0)
        {
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');

                if (values.Length == 2)
                {
                    string gender = values[0].Trim().ToUpper();
                    string name = values[1].Trim();

                    if (!nameDictionary.ContainsKey(gender))
                    {
                        nameDictionary[gender] = new List<string>();
                    }

                    nameDictionary[gender].Add(name);
                }
            }
        }
    }

    public (string name, string gender) GenerateRandomName()
    {
        List<string> genders = new List<string>(nameDictionary.Keys);

        if (genders.Count > 0)
        {
            string randomGender = RandomItem(genders);

            if (nameDictionary.TryGetValue(randomGender, out List<string> names) && names.Count > 0)
            {
                ShuffleList(names);
                string randomName = RandomItem(names);

                return (randomName, randomGender);
            }
            else
            {
                Debug.LogWarning("No names found for gender: " + randomGender);
            }
        }
        else
        {
            Debug.LogWarning("No genders found in the dictionary.");
        }

        // If any issues occur, return a default value
        return ("Unknown", "Unknown");
    }

    private T RandomItem<T>(List<T> list)
    {
        return list[Random.Range(0, list.Count)];
    }

    private void ShuffleList<T>(List<T> list)
    {
        int n = list.Count;
        for (int i = n - 1; i > 0; i--)
        {
            int j = Random.Range(0, list.Count);
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
