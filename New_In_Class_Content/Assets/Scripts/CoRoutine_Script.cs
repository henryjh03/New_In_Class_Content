using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutineExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndPrint(1f));

        InvokeRepeating("UpdateAIpathfinding", 0f, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateAIpathfinding()
    {
        Debug.Log("doing the griddy");
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        Debug.Log("first message NO TIME PASS");
        yield return new WaitForSeconds(waitTime);
        Debug.Log("second message " + waitTime + " HAS PASSED");
        yield return new WaitForSeconds(waitTime + 4);
        Debug.Log("Third message " + waitTime + " plus " + 4 + " HAS PASSED");
    }
}
