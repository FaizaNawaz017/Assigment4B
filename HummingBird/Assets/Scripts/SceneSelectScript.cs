using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelectScript : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Scene01Button":
                SceneManager.LoadScene("Penguins");
                break;
            case "Scene02Button":
                SceneManager.LoadScene("FlowerIsland");
                break;
        }
    }
}
