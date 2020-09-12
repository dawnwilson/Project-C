﻿using System;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    //public Item item;
    private bool canPickup = false;

    private void Update()
    {
        if (canPickup && Input.GetMouseButtonDown(1))
        {
           // PickUpItem();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canPickup = true;
            Debug.Log("Pick Me!");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        canPickup = false;
        Debug.Log("I'm Out!");
    }

    // private void PickUpItem()
    // {
    //     Debug.Log($"You picked up {item.name}");
    //     bool wasPickedUp = Inventory.instance.Add(item);
    //     if (wasPickedUp)
    //     {
    //         Destroy(this.gameObject);
    //     }
    // }
}
