using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : Interactable
{
    public ParticleSystem blood;
    public GameObject text;
    public GameObject knife;
    bool isDead = false;

    private void OnMouseDown()
    {
        HandleInteraction();
    }

    public override void HandleInteraction()
    {
        if (player.inventory.Contains(key) && !isDead)
        {
            blood.Play();
            text.SetActive(true);
            knife.SetActive(true);
            isDead = true;
        }
    }
}
