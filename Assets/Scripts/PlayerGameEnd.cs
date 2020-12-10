using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Yarn.Unity;

public class PlayerGameEnd : MonoBehaviour
{

    [YarnCommand("gameFail")]
    public void gameFail()
    {
            // swtich the scene to the fail screne
            SceneManager.LoadScene("EndFail");
    }

    [YarnCommand("gameSuccess")]
    public void gameSuccess()
    {
        // swtich the scene to the success screne
        SceneManager.LoadScene("EndSuccess");
    }
            
       

}
