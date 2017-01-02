using System;
using System.Collections.Generic;

namespace N2KittensView.Core
{
	public class KittenGenesisService : IKittenGenesisService
	{

		private readonly List<string> _names = new List<string>() {
			"Divikiran",
			"Anahi",
			"Ani",
			"Sanju"
		};

		public Kitten CreateNewKitten(string extra = "")
		{
			var kitten = new Kitten()
			{
				Name = _names[Random(_names.Count)] + extra,
				Price = RandomPrice(),
				ImageUrl = string.Format("http://placekitten.com/{0}/{0}", Random(20) + 300)
			};
			return kitten;
		}

		private readonly Random _random = new Random();
		protected int Random(int count)
		{
			return _random.Next(count);
		}

		protected int RandomPrice()
		{
			return Random(23) + 3;
		}
	}
}
