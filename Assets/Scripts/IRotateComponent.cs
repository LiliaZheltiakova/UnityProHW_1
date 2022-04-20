using UnityEngine;

namespace EntitiesHomework
{
    public interface IRotateComponent
    {
        Quaternion Obj_Rotation { get; }
        void Rotate(Vector2 mousePositionOnScreen);
    }
}