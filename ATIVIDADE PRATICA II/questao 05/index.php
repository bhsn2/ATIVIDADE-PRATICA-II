<?php
	function celsiusparaFahrenheit($c) {
		return ($c * 9/5) + 32;
	}

	function fahrenheitparaCelsius($f) {
		return ($f - 32) * 5/9;
	}

	$temp = (float) readline("Informe uma temperatura: ");
	$escala = readline("Converter para (informe C ou F em maiúsculo): ");

	if ($escala == "F") {
		echo $temp . " °C = " . celsiusparaFahrenheit($temp) . " °F\n";
	} elseif ($escala == "C") {
		echo $temp . " °F = " . fahrenheitparaCelsius($temp) . " °C\n";
	} else {
		echo "Escala inválida.\n";
	}
?>