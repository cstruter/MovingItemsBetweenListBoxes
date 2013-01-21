<?php

include "includes/listpicker.php";

$picker = new listpicker("picker");

if (!$picker->deserializable)
{
	$picker->lstFrom->addItem("Trüter", "Trüter");
	$picker->lstFrom->addItem("C#", "csharp");
	$picker->lstFrom->addItem("VB.NET", "vbnet");
	$picker->lstFrom->addItem("PHP 5", "php5");
	$picker->lstTo->addItem("MySQL", "mysql");
	$picker->lstTo->addItem("SQL", "mssql");
}

?>
<html>
	<head>
		<title>Moving items between listboxes in PHP</title>
		<script type="text/javascript" src="js/listbox.js"></script>
	</head>
	<body>
		<form method="POST">
			<?php echo $picker->render(); ?>
		<input type="submit" />
		</form>
	</body>
</html>