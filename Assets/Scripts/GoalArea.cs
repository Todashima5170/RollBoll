using UnityEngine;
using TMPro;

public class GoalArea : MonoBehaviour
{
    public GameObject GoalText;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "player") 
        {
            GoalText.SetActive(true);
        }
    }
}
