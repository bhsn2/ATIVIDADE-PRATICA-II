<?php
	$produtos = [];

	for ($i = 0; $i < 4; $i++) {
		$nome = readline("Nome do ". ($i + 1) ."º produto : ");
		$quantidade = (int) readline("Quantidade: ");
		$preco = (float) readline("Preço unitário: ");
		echo "\n";
		$total = $quantidade * $preco;

		$produtos[] = [
			"nome" => $nome,
			"quantidade" => $quantidade,
			"preco" => $preco,
			"total" => $total
		];
	}

	echo "\nTabela de Produtos:\n";
	echo "\nNome\tQtd\tPreço\tTotal\n";
	foreach ($produtos as $p) {
		echo "{$p['nome']}\t{$p['quantidade']}\t{$p['preco']}\t{$p['total']}\n";
	}
?>