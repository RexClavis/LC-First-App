using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneAfterSecond : MonoBehaviour
{
    // Start is called before the first frame update
    public LoadScene ls;
    public float second;
    public string sceneName;

    void Start()
    {
        Invoke("ChangeAfterSecond", second);
    }

    public void ChangeAfterSecond()
    {
        ls.ChangeScene(sceneName);
    }
}
