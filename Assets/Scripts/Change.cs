using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    // Scenes 전환을 위한 코드
    public void SceneChange()
    {
        SceneManager.LoadScene("description");
    }
}
