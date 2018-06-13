using System;

namespace Proxy
{
	public class CaixaEletronico : ICaixaEletronico
	{
		private bool PossuiClienteUsando = true;

		private string ClienteAtual = "José Batata dos Santos";

		private bool Ligada = true;

		private int SaldoInterno = 30000;

		private Action AcaoTriggerInicial;

		public bool ClienteUsando() => PossuiClienteUsando;

		public bool EstaLigada() => Ligada;

		public string ObtemClienteAtual() => ClienteAtual;

		public int ObtemSaldoInterno() => SaldoInterno;

		// Métodos que não devem ser vistos
		
		public string ObtemConfiguracaoCaixa() => "asda2312xaz237ascXINBWIUxhq3983";

		public string ObtemLocalizacaoCaixa() => "MG/BH/STA/32x-12";

		public void DefineTriggerCaixa(Action acao) => acao = AcaoTriggerInicial;
	}
}
