using UnityEngine;

namespace EntitiesHomework
{
    public sealed class MoveComponent : MonoBehaviour, IMoveComponent
    {
        [SerializeField] private Transform moveTransform;
        [SerializeField] private float moveSpeed;

        public float MoveSpeed => this.moveSpeed;
        public Vector3 Obj_Position => this.moveTransform.transform.position;

        public void Move(Vector3 direction)
        {
            this.moveTransform.position += direction * (Time.deltaTime * this.moveSpeed);
        }
    }
}