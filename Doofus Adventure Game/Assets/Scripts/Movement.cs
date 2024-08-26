using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float speed;
}

[System.Serializable]
public class PulpitData
{
    public float min_pulpit_destroy_time;
    public float max_pulpit_destroy_time;
    public float pulpit_spawn_time;
}

[System.Serializable]
public class GameData
{
    public PlayerData player_data;
    public PulpitData pulpit_data;
}
public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    private float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        LoadSpeedFromJson();
    }

    void LoadSpeedFromJson()
    {
        TextAsset jsonData = Resources.Load<TextAsset>("player_data");

        if (jsonData != null)
        {
            GameData gameData = JsonUtility.FromJson<GameData>(jsonData.text);
            speed = gameData.player_data.speed;
        }
        else
        {
            Debug.LogError("JSON file not found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up") || Input.GetKey("w"))
        {
            rb.velocity = new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            rb.velocity = new Vector3(0, 0, -speed);
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
    }
}
