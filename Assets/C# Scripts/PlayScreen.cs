using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayScreen : MonoBehaviour
{
    public TMP_Text tooltipText;
    public GameObject tooltip;
    public string endemic, epidemic, pandemic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void endemicDifficulty()
    {
        SceneManager.LoadScene(endemic);
    }

    public void epidemicDifficulty()
    {
        SceneManager.LoadScene(epidemic);
    }

    public void pandemicDifficulty()
    {
        SceneManager.LoadScene (pandemic);
    }

    public void tooltipShow(string content)
    {
        tooltipText.text = content;
        tooltip.SetActive(true);
    }
    public void tooltipHide()
    {
        tooltip.SetActive(false);
    }
}
