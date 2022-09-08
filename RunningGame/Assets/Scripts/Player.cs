using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float speed = 1f;

    public GameObject goal;

    public GameObject panel;
    public TextMeshProUGUI text;

    public float time = 0f;

    public float endTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, goal.transform.position);
        if (distance <= 0.1f)
        {
            panel.SetActive(true);
            text.SetText(time.ToString());
            return;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (time <= endTime)
            {
                speed += 0.1f;
            }
        }
        transform.Translate(Vector3.forward* speed * Time.deltaTime);
        time += Time.deltaTime;
        Debug.Log("Max Speed : " + speed);
    }
}
