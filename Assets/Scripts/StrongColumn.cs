using System;
using UnityEngine;

namespace Application
{
    public class StrongColumn: MonoBehaviour, IColumn
    {
        [SerializeField]
        private float hp = 20;

        public event Action OnDamage = delegate { };

        public StrongColumn()
        {
        }

        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.GetComponent<Bird>() != null)
            {
                GameControl.instance.BirdScored();
            }
        }


    }
}
