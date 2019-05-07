using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    #region Variables
    float velActual;
    public float velMax = 3f;

    public float xrl8I = 0.2f;
    public float xrl8 = 0.01f;
    public float xrl8F = 0.07f;

    public float velRot = 130f;

    Animator anime;
    #endregion

    void Awake ()
    {
        anime = GetComponent<Animator>();
	}
	
	void Update ()
    {
        // Movimentação do personagem - Rotação
        float hori = Input.GetAxisRaw("Horizontal");

        // Rotação
        Vector3 rotator = Vector3.up * hori * velRot * Time.deltaTime;

        // Movimentação do personagem - Deslocamento
        float vert = Input.GetAxisRaw("Vertical");

        if(vert > 0 && velActual < velMax)
        {
            velActual += (velActual == 0f) ? xrl8I : xrl8;
        }
        else if (vert == 0 && velActual > 0)
        {
            velActual -= xrl8F;
        }

        velActual = Mathf.Clamp(velActual, 0, velMax);

        if (velActual > 0)
        {
            transform.Rotate(rotator);
        }

        transform.Translate(Vector3.forward * velActual * Time.deltaTime);

        // Acionando a animação
        float valueAnime = Mathf.Clamp(velActual / velMax, 0, 1);
        anime.SetFloat("speed", valueAnime);
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Portal")
        {
            SceneManager.LoadScene("_go");
        }
    }
}
