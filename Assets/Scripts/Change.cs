using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change : MonoBehaviour
{
    // Scenes ��ȯ�� ���� �ڵ�
    public void SceneChange()
    {
        SceneManager.LoadScene("description");
    }
}
