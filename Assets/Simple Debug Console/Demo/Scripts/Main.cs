using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test code");
        Debug.Log("test code");
        Debug.Log("test code");
        Debug.Log("test code");
        Debug.Log("test code");
        Debug.Log("test code");
        StartCoroutine(fpsCounter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator fpsCounter()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.1f);
            Debug.LogWarning(Mathf.Round((1 / Time.deltaTime)));
            Debug.LogError(Mathf.Round((1 / Time.deltaTime)));
            yield return new WaitForSeconds(0.5f);
        }
    }
}
