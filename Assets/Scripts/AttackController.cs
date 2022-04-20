using System;
using UnityEngine;
using Entities;

namespace EntitiesHomework
{
    public class AttackController : MonoBehaviour
    {
        [SerializeField] private MonoEntity player;
        private IAttackComponent attackComponent;

        private void Start()
        {
            attackComponent = this.player.Element<IAttackComponent>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                attackComponent.Attack();
            }
        }
    }
}