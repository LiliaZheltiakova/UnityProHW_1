using System;
using UnityEngine;
using Entities;

namespace EntitiesHomework
{
    public class PositionOrientationStatsController : MonoBehaviour
    {
        [SerializeField] private MonoEntity player;

        private IMoveComponent moveComponent;
        private IRotateComponent rotateComponent;

        private void Start()
        {
            this.moveComponent = this.player.Element<IMoveComponent>();
            this.rotateComponent = this.player.Element<IRotateComponent>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                Debug.Log("Player position & orientation info: \n" +
                          $"Position: {moveComponent.Obj_Position} " +
                          $"Rotation: {rotateComponent.Obj_Rotation}");
            }
        }
    }
}