using System;
using System.Collections.Generic;

namespace FactoryPatternEx2
{
	public interface IDataAccess
	{
		public void SaveData();
		public List<Product> LoadData();

	}
}

