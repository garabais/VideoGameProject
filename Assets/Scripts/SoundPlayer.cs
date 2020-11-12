using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
	private AudioSource audio;

	public AudioClip[] attack;
	public AudioClip[] hit;
	public AudioClip[] die;
	public AudioClip[] start;
	public AudioClip[] random;
	public AudioClip[] dash;

    // Start is called before the first frame update
    void Start()
    {
		audio = GetComponent<AudioSource>();
		if(start.Length > 0){
			audio.clip = start[Random.Range(0, start.Length)];
			audio.Play();
		}
    }

	public void dashSound(){
		audio.clip = dash[Random.Range(0, dash.Length)];
		audio.Play();
	}

	public void hitSound(){
		audio.clip = hit[Random.Range(0, hit.Length)];
		audio.Play();
	}

	public void attackSound(){
		audio.clip = attack[Random.Range(0, attack.Length)];
		audio.Play();
	}

	public void dieSound(){
		audio.clip = die[Random.Range(0, die.Length)];
		audio.Play();
	}

	public void randomSound(){
		audio.clip = random[Random.Range(0, random.Length)];
		audio.Play();
	}
}
