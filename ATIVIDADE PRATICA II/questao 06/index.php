<?php
	function areaQuadrado($lado) {
		return $lado * $lado;
	}
	function areaRetangulo($base, $altura) {
		return $base * $altura;
	}
	function areaCirculo($raio) {
		return pi() * $raio * $raio;
	}

	echo "1 – Quadrado | 2 – Retângulo | 3 – Círculo\n";
	$opcao = (int) readline("Digite o número da figura escolhida: ");

	switch ($opcao) {
		case 1:
			$lado = (float) readline("Informe a medida do lado do quadrado: ");
			echo "Área do quadrado = " . areaQuadrado($lado) . "\n";
			break;
		case 2:
			$base = (float) readline("Informe a medida da base do retângulo: ");
			$altura = (float) readline("Informe a medida da altura do retângulo: ");
			echo "Área do retângulo = " . areaRetangulo($base, $altura) . "\n";
			break;
		case 3:
			$raio = (float) readline("Informe a medida do raio do círculo: ");
			echo "Área do círculo = " . areaCirculo($raio) . "\n";
			break;
		default:
			echo "Número inválido.\n";
			break;
	}
?>