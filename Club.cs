using System;

public class Club
{
	private Socio miembro1, miembro2, miembro3;

	public Club(Socio miembro1, miembro2, miembro3)
	{
		this.miembro1 = miembro1;
		this.miembro2 = miembro2;
		this.miembro3 = miembro3;
	}

	public void MostrarMiembroAntiguo()
	{
		if(miembro1.getTiempoDeSocio > miembro2.getTiempoDeSocio && miembro1.getTiempoDeSocio > miembro3.getTiempoDeSocio)
		{
			Console.WriteLine(miembro1.getNombre);
		}
		else if (miembro2.getTiempoDeSocio > miembro1.getTiempoDeSocio && miembro2.getTiempoDeSocio > miembro3.getTiempoDeSocio)
        {
            Console.WriteLine(miembro2.getNombre);
        }
		else if (miembro3.getTiempoDeSocio > miembro2.getTiempoDeSocio && miembro3.getTiempoDeSocio > miembro1.getTiempoDeSocio)
        {
            Console.WriteLine(miembro3.getNombre);
        }
    }
}

public class Socio()
{
	private string nombre;
	private int tiempoDeSocio;

	public string getNombre()
	{
		return nombre;
	}

	public int getTiempoDeSocio()
	{
		return tiempoDeSocio;
	}

	public Socio(string nombre, int tiempoDeSocio)
	{
		this.nombre = nombre;
		this.tiempoDeSocio = tiempoDeSocio;
	}	

}
