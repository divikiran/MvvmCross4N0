using System;
namespace N2KittensView.Core
{
	public interface IKittenGenesisService
	{
		Kitten CreateNewKitten(string extra = "");
	}
}
