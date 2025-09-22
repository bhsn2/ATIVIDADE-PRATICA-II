<?php
	$frutas = [];

	for ($i = 0; $i < 5; $i++) {
		$frutas[] = readline("Digite a " . ($i + 1) . "ª fruta: ");
	}

	sort($frutas);

	echo "\nFrutas em ordem alfabética:\n";
	foreach ($frutas as $f) {
		echo $f . "\n";
	}
?>