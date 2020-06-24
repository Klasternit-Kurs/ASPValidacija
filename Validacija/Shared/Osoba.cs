using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Validacija.Shared
{
	public class Validator : AbstractValidator<Osoba>
	{
		public Validator()
		{
			RuleFor(o => o.Ime).NotEmpty().WithMessage("Ne sme prazno!")
							.MinimumLength(4).WithMessage("Iznad 3 karaktera!");
			RuleFor(o => o.Prezime).Must(p => Test(p)).WithMessage("Nope :/");

		}

		public bool Test(string s) =>
					!string.IsNullOrEmpty(s) && !(s.Length < 3);


	}
	public class Osoba
	{
		public string Ime { get; set; }
		public string Prezime { get; set; }
	}
}
