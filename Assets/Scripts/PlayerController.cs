using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	void Start ()
    {
	}
	
	void Update ()
    {
        int TouchQuant = Input.touchCount;

        if(TouchQuant > 0)
        {
            Touch firstTouch = Input.GetTouch(0);

            print(firstTouch.fingerId);

            print(firstTouch.position.x);
            print(firstTouch.position.y);

            print(firstTouch.phase);

            if (firstTouch.phase == TouchPhase.Began)
            {
                print("Primeiro toque acabou de iniciar.");
            }
        }

        for (int i = 0; i < TouchQuant; i++)
        {
            // Se quantidade de toques for 2, i = 0 e i = 1

            /*int i = TouchQuant; i > 0; i--

                   2    2 > 0
                        1 > 0
                        0 > 0
            */

            Touch touch = Input.GetTouch(i);

            Debug.Log(string.Format("Touch: {0} - X: {1}, Y: {2}", touch.fingerId, touch.position.x, touch.position.y));
        }

        foreach (Touch touch in Input.touches)
        {   
            Debug.Log(string.Format("Touch: {0} - X: {1}, Y: {2}", touch.fingerId, touch.position.x, touch.position.y));
        }
    }
}
