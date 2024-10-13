using Core.Entity;

namespace Store.Test
{
	public class ClienteRepositoryTeste
	{
		[Fact]
		public void ObterPorDataTeste()
		{
			Cliente cliente = new Cliente
			{
				Id = 5, 
				Nome = "Lucas", 
				Cpf = "03416427114"
			};

			string dataIni = "2024-04-01";
			string dataFin = "2024-10-01";
		}
	}
}