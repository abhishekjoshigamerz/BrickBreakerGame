
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManager : MonoBehaviour
{
    private int  firstSceneIndex = 0;
    private int SceneIndex = 0;
    public void StartGame(){
        SceneIndex++;
        firstSceneIndex++;
        //had to do this because scenemanager and unityscene manager had same names and I did not took care of that at that time. so did this
        UnityEngine.SceneManagement.SceneManager.LoadScene(firstSceneIndex);
        firstSceneIndex=0;
    }

    public void PlayAgain(){
        
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
    
    
    public void QuitGame(){
        Debug.Log("Game Quit!");
        Application.Quit();
    }
}
