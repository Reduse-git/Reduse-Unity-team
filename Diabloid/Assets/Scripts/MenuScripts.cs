using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        
    }
    public void OnClickPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void OnClickSetting()
    {
        //SceneManager.LoadScene("SampleScene");
    }
    public void OnClickExit()
    {
        //SceneManager.LoadScene("SampleScene");
    }
    public void OnClickPause()
    {
        SceneManager.LoadScene("SceneMenu");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
