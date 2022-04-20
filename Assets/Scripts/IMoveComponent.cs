using UnityEngine;
namespace EntitiesHomework
{
    public interface IMoveComponent
    {
        float MoveSpeed { get; }
        Vector3 Obj_Position { get; }
        void Move(Vector3 direction);
    }
}
