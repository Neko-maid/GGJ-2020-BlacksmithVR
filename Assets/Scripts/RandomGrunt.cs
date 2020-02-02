using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGrunt : MonoBehaviour
{
    public List<AudioClip> grunts;

    private Rigidbody m_rb;
    public AudioSource m_asource;
    
    public float m_last_velocity;
    public static float m_swing_threshold = 5.0f;
    public static float m_cooldown = 0.7f;
    public float m_last_grunt_time;

    public Vector3 m_last_position;

    public float m_current;

    public bool swung = false;

    void Awake()
    {
        m_asource = gameObject.GetComponent<AudioSource>();
        m_rb = gameObject.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        m_last_grunt_time = Time.time;
        m_last_velocity = 0.0f;
        m_last_position = m_rb.position;
    }

    void FixedUpdate()
    {
        if (Vector3.Distance(m_last_position, m_rb.position) > m_swing_threshold * Time.fixedDeltaTime)
        {
            if (Time.time - m_last_grunt_time > m_cooldown && !swung)
            {
                swung = true;
                m_last_grunt_time = Time.time;
                int i = Random.Range(0, grunts.Count);
                m_asource.PlayOneShot(grunts[i]);
            }
        }

        if (Vector3.Distance(m_last_position, m_rb.position) < m_swing_threshold * Time.fixedDeltaTime && swung)
        {
            swung = false;
        }

        m_last_velocity = Vector3.Distance(m_last_position, m_rb.position);
        m_last_position = m_rb.position;
    }
}
