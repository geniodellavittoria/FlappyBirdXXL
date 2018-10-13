using System;
using UnityEngine;

namespace Application
{
    public interface IColumn
    {
        event Action OnDamage;
        void OnTriggerEnter2D(Collider2D other);
    }
}
