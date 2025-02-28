using UnityEngine;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour
{
public void goToGame(){
    SceneManager.LoadScene("gameplay");
}

//private void scenes(string sceneName){
//UnityEngine.SceneManagement.LoadScene(sceneName);
//}
}
