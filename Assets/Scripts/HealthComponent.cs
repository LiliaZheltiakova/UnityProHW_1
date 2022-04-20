using System;
using UnityEngine;

namespace EntitiesHomework
{
    public sealed class HealthComponent : MonoBehaviour, IHealthComponent
    {
        public int Health => this.health;

        [SerializeField] private int health;

        private void Start()
        {
            AttackComponent.playerAttackedDelegate += OnPlayerAttacked;
        }

        private void TakeDamage(int damage)
        {
            health -= damage;
        }

        public void OnPlayerAttacked(int damage)
        {
            TakeDamage(damage);
        }

        private void OnDisable()
        {
            AttackComponent.playerAttackedDelegate -= OnPlayerAttacked;
        }
    }
}