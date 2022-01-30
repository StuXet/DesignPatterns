using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clan
{

    static Dictionary<int, Clan> clans = new Dictionary<int, Clan>();
    public string id;
    static object _lock = new object();

    private Clan()
    {
        
    }

    public static Clan GetClan(int key)
    {
        lock (_lock)
        {
            if (!clans.ContainsKey(key))
            {
                clans.Add(key, new Clan());
            }
        }
        return clans[key];
    }
}
