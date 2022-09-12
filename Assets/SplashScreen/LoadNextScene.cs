using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadNextScene : MonoBehaviour
{
    public bool loadScene = false; //exposed this so it can be triggered by the animator, to make it easy to tweak with the animation
    public string sceneName; //scene name to load - replace with your own scene name. Remember to add it to build settings.
    
    void Start()
    {
        StartCoroutine(waitForTrigger());
    }

    IEnumerator waitForTrigger()
    {
        //loads the next level in the background. waits for loadScene to be set to true to perform the transition.

        AsyncOperation async = SceneManager.LoadSceneAsync(sceneName);
        async.allowSceneActivation = false;
        yield return new WaitUntil(() => loadScene);
        async.allowSceneActivation = true;
        while (!async.isDone)
        {
            yield return null;
        }
        
        

    }
}
