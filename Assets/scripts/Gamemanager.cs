using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamemanager : MonoBehaviour {

    bool gamehasended = false;

    public float restartdelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame ()
    

    {
        if (gamehasended == false)
        {
            gamehasended = true;
            Debug.Log("GAMEOVER");
            Invoke("Restart", restartdelay );
        }
        
    }
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
