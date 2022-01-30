using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Clan clan;
    public int clanNum;
    public string changeClanNameTo;
    // Start is called before the first frame update
    void Start()
    {
        clan = Clan.GetClan(clanNum);
    }

    private void Update()
    {
        Debug.Log(name + " clan's name: " + clan.id);
    }

    public void ChangeClanName()
    {
        if (clan.id != changeClanNameTo)
        {
            Debug.Log(name + " hanged his clan name from \"" + clan.id + "\" to \"" + changeClanNameTo + "\"");
            clan.id = changeClanNameTo;
        }
    }
}
