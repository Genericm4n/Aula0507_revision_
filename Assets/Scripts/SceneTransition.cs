using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour {

	void Start () {

        StartCoroutine("ReturnScene");
	}

    IEnumerator ReturnScene()
    {
        yield return new WaitForSeconds(3f);

        SceneManager.LoadScene("EX_");
    }
}
