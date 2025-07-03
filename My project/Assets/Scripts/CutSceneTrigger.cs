using UnityEngine;
using UnityEngine.Playables;
public class CutSceneTrigger : MonoBehaviour
{
    public PlayableDirector _director;
    public GameObject HUD;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        _director.played += director_played;
        _director.stopped += director_stopped;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _director.Play();
        }
    }


    void director_played(PlayableDirector _dir)
    {
        HUD.SetActive(false);
    }


    void director_stopped(PlayableDirector _dir)
    {
        HUD.SetActive(true);
    }
}
