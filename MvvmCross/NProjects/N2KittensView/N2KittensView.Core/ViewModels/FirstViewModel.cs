using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace N2KittensView.Core.ViewModels
{
    public class FirstViewModel 
        : MvxViewModel
    {

		public FirstViewModel(IKittenGenesisService service)
		{
			var newList = new List<Kitten>();
			for (int i = 0; i < 100; i++)
			{
				var kitten = service.CreateNewKitten(i.ToString());
				newList.Add(kitten);
			}
			Kittens = newList;
		}

		private List<Kitten> __kitten;
		public List<Kitten> Kittens
		{
			get { return __kitten; }
			set { SetProperty(ref __kitten, value); }
		}
	}
}
