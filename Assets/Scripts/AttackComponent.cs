using UnityEngine;

namespace EntitiesHomework
{
    public sealed class AttackComponent : MonoBehaviour, IAttackComponent
    {
        public static event IAttackComponent.OnPlayerAttackedDelegate playerAttackedDelegate;
        public int AttackRange => this.attackRange;
        [SerializeField] private int attackRange;
        public void Attack()
        {
            playerAttackedDelegate(attackRange);
        }
    }
}