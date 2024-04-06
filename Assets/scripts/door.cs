using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    private bool unlocked = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && unlocked)
        {
            SceneManager.LoadScene("menu");
            Debug.Log("Fim do jogo!");
        }
    }

    public void Unlock()
    {
        unlocked = true;
        Debug.Log("chave coletada");
    }
}
