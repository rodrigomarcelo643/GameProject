using System.Collections.Generic;
using UnityEngine;

public static class EnvConfig
{
    private static Dictionary<string, string> envVars;

    public static string Get(string key)
    {
        if (envVars == null)
            Load();

        return envVars.ContainsKey(key) ? envVars[key] : null;
    }

    private static void Load()
    {
        envVars = new Dictionary<string, string>();
        TextAsset envFile = Resources.Load<TextAsset>("env");

        if (envFile == null)
        {
            Debug.LogError("env.txt not found in Resources/");
            return;
        }

        string[] lines = envFile.text.Split('\n');
        foreach (string line in lines)
        {
            if (!line.Contains("=")) continue;
            string[] parts = line.Split('=');
            string key = parts[0].Trim();
            string value = parts[1].Trim();
            envVars[key] = value;
        }

        Debug.Log("Environment variables loaded.");
    }
}
