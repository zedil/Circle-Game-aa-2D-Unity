using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class yonetim : MonoBehaviour
{

    public Text donencemberlevel;
    public Text bir;
    public Text iki;
    public Text uc;
    public int kactanekucukobje;
    GameObject DonenCember;
    GameObject bgacember;
    public Animator anim;
    // Start is called before the first frame update
    


    void Start()
    {

        DonenCember = GameObject.FindGameObjectWithTag("Donencember");
        bgacember = GameObject.FindGameObjectWithTag("bgacember");


    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }



    public void oyunbitti()
    {
        StartCoroutine(bitti());

    }

    IEnumerator bitti()
    {
        DonenCember.GetComponent<donus>().enabled = false;
        bgacember.GetComponent<bgacem>().enabled = false;
        anim.SetTrigger("oyunbitti");
        yield return new WaitForSeconds(1);
        
        
        PlayAgain();

    }

    void Update()
    {
        
    }



}
