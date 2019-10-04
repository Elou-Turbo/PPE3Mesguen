<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN"
                      "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="fr">
	
	<head>
		<meta http-equiv="content-type" content="text/html; charset=UTF-8" />
		<meta http-equiv="content-language" content="fr" />
		<title>MESGUEN - AC13</title>
		<link rel="stylesheet" href="../css/tournees.css" />
	</head>
	
	<header><img src="../image/Mesguen.jpg"></header>
<section1></section1>
<section2></section2>
<aside>
    <h1>Etape</h1>
    <hr />
    <br />
    <br />
    <br />
    <br />
    <br />
	
	<body>
		<form action="AC13traitement.php" method="GET">
			<label for="Lieu" >Lieu</label>
			<select size="1" name="lieu" id="lieu">
				<option value="NULL">Selectionnez un lieu</option>
				<?php
					include 'connectAD.php';
					
					$TRNNUM = $_GET['tournee'];
					
					$sql = "SELECT LIEUID, LIEUNOM
							FROM lieu";
					
					$result = executeSQL($sql);
					
					$cpt = mysqli_num_rows($result);
					
					if ($cpt>0) {	
						while ($row = mysqli_fetch_array($result, )) {		
							echo "<option value=$row[0]>$row[1]</option>";
						}					
					} else {
						echo "<select size=\"1\" name=\"numero\" id=\"numero\" disabled=\"disabled\" >";	
						echo "<option>Aucune information...</option>";
					}		
	    		?>   
	    	</select>
			
			<br/>
			<br/>
			
			<label>Rendez-vous entre :</label>
			<input type="date" value="<?php $date = date("Y/m/d H:i:00"); echo "$date" ?>" name="RDVDebut" id="RDVDebut"/>
			
			<label>Et :</label>
			<input type="date" value="<?php $date = date("Y/m/d H:i:00"); echo "$date" ?>" name="RDVFin" id="RDVFin"/>
			
			<br/>
			<br/>
			
			<label>Pris en charge le :</label>
			<input type="date" value="" name="RDVPrise" id="RDVPrise" />
			
			<br/>
			<br/>
			
			<label>Commmentaire :</label>
			<textarea class="commentaire" name="commentaire" id="commentaire" rows="5" cols="15"></textarea>
			
			<br/>
			<br/>
			
			
			
			<input id="tournee" name="tournee" type="hidden" value="<?php echo "$TRNNUM" ?>" />
			<input id="valider" name="valider" type="submit" value="Valider"/>
			<input id="cancel" type="button" name="retour" value="Annuler" onclick="location.href='AC12.php'" />
		</form>
</aside>
<footer>

</footer>
</body>

</html>