using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class SceneManagement : Singleton<SceneManagement>
{
    public SceneManagement(string sceneTransitionName)
    {
        SceneTransitionName = sceneTransitionName;
    }

    
    public string SceneTransitionName { get; private set; } 
    public void SetTransitionName(string sceneTransitionName)
    {
        this.SceneTransitionName = sceneTransitionName;
    }
   /* public void SetTransitionName(string sceneTransitionName, string transitionName)
    {
        transitionName = sceneTransitionName; this.SceneTransitionName = transitionName;
    }*/
}
