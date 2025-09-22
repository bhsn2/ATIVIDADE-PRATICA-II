<?php
	$numeros = [];
	$pares = [];
	$impares = [];
	
	for ($i = 0; $i < 10; $i++) {
		$numeros[] = (int) readline("Digite o " . $i+1 . "º número: ");
	}
	
	foreach ($numeros as $n) {
	    if ($n % 2 == 0) {
            $pares[] = $n;
	    }
	    else {
	        $impares[] = $n;
	    }
	}
	
	echo "\nPares: ";
	foreach ($pares as $p) {
	    echo $p ." ";
	}
	echo "\nÍmpares: ";
	foreach ($impares as $p) {
	    echo  $p ." ";
	}
?>