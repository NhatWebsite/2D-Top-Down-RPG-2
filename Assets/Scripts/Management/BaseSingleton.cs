using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSingleton : Singleton<BaseSingleton>
{
    [SerializeField] private string transitionName;

    private void Start()
    {
        if(transitionName == SceneManagement.Instance.SceneTransitionName)
        {
            PlayerControllers.Instance.transform.position=this.transform.position;
            CameraController.Instance.SetPlayerCameraFollow();
        }
    }

}
