<?php
	$matriz1 = [];
	$matriz2 = [];
	$resultado = [];

	echo "Informe os valores da primeira matriz:\n\n";
	for ($i = 0; $i < 3; $i++) {
		for ($j = 0; $j < 3; $j++) {
			$matriz1[$i][$j] = (int) readline("Matriz 1[$i][$j]: ");
		}
	}

	echo "\nInforme os valores da segunda matriz:\n";
	for ($i = 0; $i < 3; $i++) {
		for ($j = 0; $j < 3; $j++) {
			$matriz2[$i][$j] = (int) readline("Matriz2[$i][$j]: ");
		}
	}

	for ($i = 0; $i < 3; $i++) {
		for ($j = 0; $j < 3; $j++) {
			$resultado[$i][$j] = $matriz1[$i][$j] + $matriz2[$i][$j];
		}
	}

	echo "\nMatriz Resultante:\n";
	for ($i = 0; $i < 3; $i++) {
		for ($j = 0; $j < 3; $j++) {
			echo $resultado[$i][$j] . "\t";
		}
		echo "\n";
	}
?>