using Core.Singleton;
using UnityEngine;

namespace Core.Component
{
    public class CameraManager: Singleton<CameraManager>
    {
        public Camera mainCamera;
        
        
        public Camera MainCamera
        {
            get
            {
                return this.mainCamera;
            }
        }
        
        public void Init()
        {
            mainCamera = Camera.main;
            mainCamera.transform.position = new(0,7,-10);
            mainCamera.transform.rotation = Quaternion.Euler(new Vector3(30,0,0));
        }

    }
}