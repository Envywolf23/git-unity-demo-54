using UnityEngine;

public class Health : MonoBehaviour 
{
	public float lifePoints = 100f;
    private int vidas = 3;

    //Asigna o retorna las vidas del personaje
    public int Vidas
    {
        get
        {
            return Vidas;
        }

        set
        {
            Vidas = value;
        }
    }

    public void ApplyDamage (float damage)
	{
		lifePoints -= damage;
		//TODO: Die
	}
}
