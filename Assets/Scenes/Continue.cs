using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public void OnClickStartButton()
    {
        //�v���C�V�[���Ɉړ�
        SceneManager.LoadScene("play_scene");
    }
}
