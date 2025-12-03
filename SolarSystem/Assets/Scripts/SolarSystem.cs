using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    // Attributes
    // public
    public Transform satelite1;
    public Transform satelite2;
    public Transform camara;

    // private
    private int _rotationSpeedSol = 30;
    private int _rotationSpeedSatelite1 = 90;
    private int _rotationSpeedSatelite2 = 45;
    private Vector3 distanciaCamara = new Vector3(0, 0, -9);


    void Start()
    {
        transform.localScale = new Vector3(2, 2, 2);
        transform.position = new Vector3(10, 0, 0);

        satelite1.localScale = new Vector3(1, 1, 1);
        satelite1.position = new Vector3(5, 0, 0);

        satelite2.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        satelite2.position = new Vector3(2, 0, 0);

    }

    void Update()
    {
        transform.LookAt(Vector3.zero);
        satelite1.LookAt(transform.position);
        satelite2.LookAt(satelite1.position);

        transform.RotateAround(Vector3.zero, Vector3.forward, _rotationSpeedSol * Time.deltaTime);
        satelite1.RotateAround(transform.position, transform.up, _rotationSpeedSatelite1 * Time.deltaTime);
        satelite2.RotateAround(satelite1.position, satelite1.right, _rotationSpeedSatelite2 * Time.deltaTime);

        Debug.DrawLine(transform.position, Vector3.zero, Color.green);
        Debug.DrawLine(transform.position, satelite1.position, Color.red);
        Debug.DrawLine(transform.position, satelite2.position, Color.blue);
        Debug.DrawLine(satelite1.position, satelite2.position, Color.brown);

        float _angulo = Vector3.Angle(satelite2.right, Vector3.right);
        if (_angulo < 90f) satelite2.localScale *= 0.99f;
        else satelite2.localScale *= 1.01f;
        print("El ángulo es de " + _angulo);
    }

    void LateUpdate()
    {
        camara.position = transform.position + distanciaCamara;
        camara.LookAt(transform.position);
    }
}
