using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC1 : Assets.Scripts.Interfaces.CharacterController, IInteractable
{
    private string _charName = "Guarda";

    private void Start()
    {
        Animator = GetComponent<Animator>();
    }

    public void Interact()
    {
        LookAtPlayer();
        int valor = Random.Range(minInclusive:1, maxExclusive:3);
        StartCoroutine(DialogManager.Instance.ShowDialog($"{_charName}.{valor}"));
    }
}
