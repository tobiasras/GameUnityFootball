
using UnityEngine;
using UnityEngine.SceneManagement;

public class inGoal : MonoBehaviour
{

    public string tagToCheck = "Football";
    public BoxCollider goalCollider;
    public string sceneName;



    public Timer timer;
    public shoot shoot;
    
   
    void Update()
    {

        Collider[] colliders = Physics.OverlapBox( goalCollider.bounds.center,  goalCollider.bounds.extents);

        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag(tagToCheck))
            {
                PlayerPrefs.SetFloat("Time", timer.CurrentTime);
                PlayerPrefs.SetInt("Kicks", shoot.Kicks);
                
                SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
            }
        }
    }
}
