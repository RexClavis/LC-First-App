using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public LoadScene ls;
    public float second;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        ls = GetComponent<LoadScene>();
        Invoke("ChangeAfterSecond", 2.0f);
    }

    // Update is called once per frame
    public void ChangeAfterSecond()
    {
        Debug.Log("test");
        ls.ChangeScene(sceneName);
    }
}
