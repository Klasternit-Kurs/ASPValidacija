using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Validacija.Server
{
	public class Hab : Hub
	{
		public void Dodaj(Shared.Osoba o)
		{
			Console.WriteLine($"{o.Ime} -- {o.Prezime}");
		}
	}
}
