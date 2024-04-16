using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    float t = .0f;

    public void AppActive()
    {
        t = 0;
    }

    private void Update()
    {
        t += Time.deltaTime;
        if (t >= 1 * 60)
        {
            SceneManager.LoadScene("END");
        }
    }
}
