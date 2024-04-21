using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Door : MonoBehaviour {
 
    public int Levelload = 1;

    public GameMaster gm; 
    // Use this for initialization
    void Start () {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
    } 
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            savescore();
            gm.Inputtext.text = ("Z");
        }
    } 
    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.Z))
            {
                savescore();
                //SceneManager.LoadScene(Levelload);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
        }
    } 
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            gm.Inputtext.text = ("");
        }
    } 
    void savescore()
    {
        PlayerPrefs.SetInt("points", gm.points);
    }
}