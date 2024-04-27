using UnityEngine;

public class SeguirJogador : MonoBehaviour
{
    public Transform Player; 
    public float suavizacao = 5f; 

    private void FixedUpdate()
    {
        if (Player != null)
        {
            
            Vector3 followP = new Vector3(Player.position.x, Player.position.y-2, transform.position.z);

            
            transform.position = Vector3.Lerp(transform.position, followP, suavizacao * Time.fixedDeltaTime);
        }
    }
}
