using System;
using System.Collections.Generic;
using System.Linq;
					
class Exercicio
{
	public static void Main()
	{
		int opcao = 8;
		Dictionary<string, (string grupoMuscular, float carga, int reps)> exercicios = new Dictionary<string, (string, float, int)>();
		float valorCarga = 0;
		int qtdReps = 0;
		String resp = "";
		
		
		while (true) {
			Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Adicionar exercício");
            Console.WriteLine("2 - Listar exercícios");
            Console.WriteLine("3 - Buscar exercício por nome");
            Console.WriteLine("4 - Filtrar por grupo musuclar");
			Console.WriteLine("5 - Calcular carga total de um treino");
			Console.WriteLine("6 - Exibir exercício mais pesado");
			Console.WriteLine("7 - Remover exercício");
			Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
			
			if(!int.TryParse(Console.ReadLine(), out opcao) || opcao < 0 || opcao > 7)
			{
				Console.WriteLine("\nEntrada inválida. Digite um número entre 0 e 7.");
				continue;
			}
			
			if (opcao == 0) {
				break; 
			}
			
			switch (opcao)
			{
				case 1:
					AdicionarExercicio(exercicios, valorCarga, qtdReps);
				break;
				
				case 2:
					ListarExercicios(exercicios);
				break;
					
				case 3:
					BuscarExercicio(exercicios, resp);
				break;
					
				case 4:
					FiltrarGrupo(exercicios, resp);
				break;
					
				case 5:
					CalcularCargaTotal(exercicios);
				break;
					
				case 6:
					ExibirMaisPesado(exercicios);
				break;
					
				case 7:
					RemoverExercicio(exercicios, resp);
				break;
			}
		}
	}
	
	static void AdicionarExercicio(Dictionary<string, (string grupoMuscular, float carga, int reps)> exercicios, float valorCarga, int qtdReps)
	{
		Console.WriteLine("\nInforme o nome do exercício: ");
		string nome = Console.ReadLine();
					
		Console.WriteLine("\nInforme o grupo muscular desse exercício: ");
		string grupoMuscular = Console.ReadLine();
					
		Console.WriteLine("\nInforme a carga em kg: ");
		while (true) {

			if (float.TryParse(Console.ReadLine(), out valorCarga) && valorCarga >= 0) {
				break;
			}
			else {
				Console.WriteLine("\nCarga inválida. Informe uma valor numérico e maior que 0.");	
			}
		}
					
		while (true) {
			Console.WriteLine("\nInforme a quantidade de repetições");
			if (int.TryParse(Console.ReadLine(), out qtdReps) && qtdReps >= 1) {
				break;
			}
			else {
				Console.WriteLine("\nQuant. de repetições inválida. Informe um valor numérico e maior/igual a 1.");
			}
		}
		
		exercicios[nome] = (grupoMuscular, valorCarga, qtdReps);
	}
	
	static void ListarExercicios(Dictionary<string, (string grupoMuscular, float carga, int reps)> exercicios)
	{
		Console.WriteLine("\nLISTA DE EXERCÍCIOS REGISTRADOS: ");
		
		foreach (var ex in exercicios)
		{
			Console.WriteLine("Nome: "+ ex.Key +" - Grupo Muscular: "+ ex.Value.grupoMuscular +" - Carga: "+ ex.Value.carga +"kg - Repetições: "+ ex.Value.reps);
		}
	}
	
	static void BuscarExercicio(Dictionary<string, (string grupoMuscular, float carga, int reps)> exercicios, String resp)
	{
		Console.WriteLine("\nNome do exercício que deseja buscar: ");
		resp = Console.ReadLine();
					
		var resultado = from ex in exercicios
						where ex.Key.ToLower() == resp.ToLower()
						select ex;
					
		bool encontrado = false;
					
		foreach (var ex in resultado) 
		{
			Console.WriteLine("\nNome: "+ ex.Key +" - Grupo Muscular: "+ ex.Value.grupoMuscular +" - Carga: "+ ex.Value.carga +"kg - Repetições: "+ ex.Value.reps);
			encontrado = true;
		}
					
		if (!encontrado) {
			Console.WriteLine("\nExercício não encontrado.");	
		}
	}
	
	static void FiltrarGrupo(Dictionary<string, (string grupoMuscular, float carga, int reps)> exercicios, String resp)
	{
		Console.WriteLine("\nFiltrar exercícios por grupo musuclar: ");
		resp = Console.ReadLine();
					
		var resultado = from ex in exercicios
						where ex.Value.grupoMuscular.ToLower() == resp.ToLower()
						select ex;
						
		bool encontrado = false;
						
		foreach (var ex in resultado) 
		{
			Console.WriteLine("\nNome: "+ ex.Key +" - Grupo Muscular: "+ ex.Value.grupoMuscular +" - Carga: "+ ex.Value.carga +"kg - Repetições: "+ ex.Value.reps);
			encontrado = true;
		}
					
		if (!encontrado) {
			Console.WriteLine("\nGrupo muscular não encontrado.");	
		}
	}
	
	static void CalcularCargaTotal(Dictionary<string, (string grupoMuscular, float carga, int reps)> exercicios)
	{
		float cargaTotal = exercicios.Sum(ex => ex.Value.carga);
		Console.WriteLine("\nCarga total de um treino: " + cargaTotal + "kg.");
	}
	
	static void ExibirMaisPesado(Dictionary<string, (string grupoMuscular, float carga, int reps)> exercicios)
	{
		var maisPesado = exercicios.OrderByDescending(ex => ex.Value.carga).FirstOrDefault();
		
		Console.WriteLine("\nExercício mais pesado: ");
		Console.WriteLine("Nome: "+ maisPesado.Key +"- Carga: "+ maisPesado.Value.carga);
	}
	
	static void RemoverExercicio(Dictionary<string, (string grupoMuscular, float carga, int reps)> exercicios, String resp)
	{
		Console.WriteLine("\nInforme o nome do exercício a ser removido: ");
		resp = Console.ReadLine();
		
		if (exercicios.Remove(resp))
		{
			Console.WriteLine("Exercício removido.");
		}
		else
		{
			Console.WriteLine("Exercício não encontrado.");
		}
	}
}