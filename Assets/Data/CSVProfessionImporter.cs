using DefaultNamespace;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class CSVProfessionImporter : MonoBehaviour
{
    public List<Profession> Professions;

    void Start()
    {
        LoadProfessionsFromCSV("Professions.csv");
    }

    private void Update()
    {
        
    }

    private void LoadProfessionsFromCSV(string fileName)
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
                if (values.Length == 14)
                {
                   Profession profession = gameObject.GetComponent<Profession>();

                    profession.Group = int.Parse(values[0] ?? "0");
                    profession.Name = values[1]?.Trim() ?? "";
                    profession.Description = values[2]?.Trim() ?? "";
                    profession.HireRarity = int.Parse(values[3] ?? "0");
                    profession.ActionStat = values[4]?.Trim() ?? "";

                    // Use int.TryParse for integer values
                    int parsedValue;
                    if (!int.TryParse(values[5] ?? "0", out parsedValue))
                    {
                        parsedValue = 0;
                    }
                    profession.BaseStamina = parsedValue;

                    if (!int.TryParse(values[6] ?? "0", out parsedValue))
                    {
                        parsedValue = 0;
                    }
                    profession.BaseHP = parsedValue;

                    if (!int.TryParse(values[7] ?? "0", out parsedValue))
                    {
                        parsedValue = 0;
                    }
                    profession.STR = parsedValue;

                    if (!int.TryParse(values[8] ?? "0", out parsedValue))
                    {
                        parsedValue = 0;
                    }
                    profession.INT = parsedValue;

                    if (!int.TryParse(values[9] ?? "0", out parsedValue))
                    {
                        parsedValue = 0;
                    }
                    profession.DEX = parsedValue;
                    if (!int.TryParse(values[10] ?? "0", out parsedValue))
                    {
                        parsedValue = 0;
                    }
                    profession.CON = parsedValue;
                    if (!int.TryParse(values[11] ?? "0", out parsedValue))
                    {
                        parsedValue = 0;
                    }
                    profession.WIS = parsedValue;
                    if (!int.TryParse(values[12] ?? "0", out parsedValue))
                    {
                        parsedValue = 0;
                    }
                    profession.CHA = parsedValue;
                    // Check for null or empty values before splitting
                    if (!string.IsNullOrEmpty(values[13]))
                    {
                        profession.PerkGroupIDs = values[13].Split(';').Select(int.Parse).ToList();
                    }
                    else
                    {
                        profession.PerkGroupIDs = new List<int>();
                    }
                    Professions.Add(profession);
                }
                else
                {
                    Debug.LogError("Incorrect number of columns in line: " + i);
                }
            }
        }
    }

    public Profession GetRandomProfession()
    {
        if (Professions.Count > 0)
        {
            int randomIndex = Random.Range(0, Professions.Count);
            return Professions[randomIndex];
        }
        else
        {
            Debug.LogError("No professions loaded. Load a CSV file first.");
            return null;
        }
    }
}