using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumManager : MonoBehaviour
{
    public GameObject pendulumPrefab; // Prefab do pêndulo
    public int numberOfPendulums = 3; // Número de pêndulos
    public float[] speeds; // Velocidades dos pêndulos
    public float limit = 75f;
    public bool randomStart = false;
    private float[] randomOffsets; // Offsets aleatórios

    void Awake()
    {
        if (randomStart)
        {
            // Defina as velocidades desejadas
            speeds = new float[] { 1.0f, 1.5f, 2.0f };
            randomOffsets = new float[speeds.Length];

            // Gere offsets aleatórios para cada velocidade
            for (int i = 0; i < speeds.Length; i++)
            {
                randomOffsets[i] = Random.Range(0f, 1f);
            }
        }

        // Instancie os pêndulos
        for (int i = 0; i < numberOfPendulums; i++)
        {
            GameObject pendulum = Instantiate(pendulumPrefab, transform);
            PendulumScript pendulumScript = pendulum.GetComponent<PendulumScript>();

            // Atribua as velocidades e offsets aleatórios aos pêndulos
            pendulumScript.speed = speeds[i % speeds.Length];
            pendulumScript.randomStart = randomStart;
            pendulumScript.random = randomOffsets[i % speeds.Length];
        }
    }

    void Update()
    {
        // A classe pai não precisa de lógica de atualização neste exemplo
    }
}