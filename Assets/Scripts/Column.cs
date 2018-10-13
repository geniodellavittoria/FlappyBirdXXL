using System;
using System.Collections;
using System.Collections.Generic;
using Application;
using UnityEngine;

public class Column : MonoBehaviour, IColumn {

    public event Action OnDamage = delegate {};

	public void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<Bird> () != null)
        {
            GameControl.instance.BirdScored();
        }
    }
}
