using UnityEngine;

namespace EntitiesHomework
{
    public class RotateComponent : MonoBehaviour, IRotateComponent
    {
        [SerializeField] private Transform rotateTransform;
        [SerializeField] private float rotateSpeed;

        public Quaternion Obj_Rotation => this.rotateTransform.transform.rotation;

        public void Rotate(Vector2 mousePositionOnScreen)
        {
            // this.rotateTransform.transform.Rotate
            //     (new Vector3(mousePositionOnScreen.y * -rotateSpeed * Time.deltaTime, 
            //         mousePositionOnScreen.x * rotateSpeed * Time.deltaTime, 0f), Space.World );
            
            this.rotateTransform.transform.Rotate(Vector3.up, mousePositionOnScreen.x);
            this.rotateTransform.transform.Rotate(Vector3.right, -mousePositionOnScreen.y);
        }
    }
}