using System;
using UnityEngine;
using UnityEngine.UIElements;

public class SeguirJogador : MonoBehaviour
{
    public Transform Player; 
    public float suavizacao = 5f;
    public Transform alvo;
    RaycastHit hit = new RaycastHit();
    public float ajusteCamera;

    private void FixedUpdate()
    {
        if (Player != null)
        {
            
            Vector3 followP = new Vector3(Player.position.x, Player.position.y-2, transform.position.z);



            if (Physics.Linecast(followP,transform.position, out hit))
            {
              transform.position = transform.position;
               // transform.position = hit.point + transform.forward * ajusteCamera;
                Debug.Log(hit.point + transform.forward * ajusteCamera);
            }
            else
            {
            transform.position = Vector3.Lerp(transform.position, followP, suavizacao * Time.fixedDeltaTime);
            }


        }
    }
}
