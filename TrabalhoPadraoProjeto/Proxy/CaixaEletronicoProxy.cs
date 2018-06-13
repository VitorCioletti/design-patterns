namespace Proxy
{
	public class CaixaEletronicoProxy : ICaixaEletronico
	{
		public string ObtemClienteAtual() => new CaixaEletronico().ObtemClienteAtual();

		public int ObtemSaldoInterno() => new CaixaEletronico().ObtemSaldoInterno();
	}
}
