
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoseCollider : MonoBehaviour
{
    private int GameOverSceneIndex = 2;
   private void OnTriggerEnter2D(Collider2D other) {
         UnityEngine.SceneManagement.SceneManager.LoadScene(GameOverSceneIndex);
   }
}
