using UnityEngine;
using Entities;

namespace EntitiesHomework
{
    public class StatsController : MonoBehaviour
    {
        [SerializeField] private MonoEntity player;
        private IHealthComponent healthComponent;
        private IMoveComponent moveComponent;
        private IAttackComponent attackComponent;

        private void Start()
        {
            this.healthComponent = this.player.Element<IHealthComponent>();
            this.moveComponent = this.player.Element<IMoveComponent>();
            this.attackComponent = this.player.Element<IAttackComponent>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                Debug.Log("Player Statistic: \n" +
                          $"Health: {healthComponent.Health} " + 
                          $"Move Speed: {moveComponent.MoveSpeed} " +
                          $"Attack Range: {attackComponent.AttackRange}");
            }
        }
    }
}