ERREUR SQL : 8 May 2019 - 13:26:28.000000 --> SELECT ETPID, LIEUNOM 
						FROM commune, lieu, etape 
						WHERE commune.VILID = lieu.VILID 
						AND etape.LIEUID = lieu.LIEUID 
						AND TRNNUM =  : (You have an error in your SQL syntax; check the manual that corresponds to your MySQL server version for the right syntax to use near '' at line 5) 
ERREUR SQL : 8 May 2019 - 13:28:10.000000 --> SELECT ETPID, LIEUNOM 
						FROM commune, lieu, etape 
						WHERE commune.VILID = lieu.VILID 
						AND etape.LIEUID = lieu.LIEUID 
						AND TRNNUM =  : (You have an error in your SQL syntax; check the manual that corresponds to your MySQL server version for the right syntax to use near '' at line 5) 
ERREUR SQL : 8 May 2019 - 13:28:11.000000 --> SELECT ETPID, LIEUNOM 
						FROM commune, lieu, etape 
						WHERE commune.VILID = lieu.VILID 
						AND etape.LIEUID = lieu.LIEUID 
						AND TRNNUM =  : (You have an error in your SQL syntax; check the manual that corresponds to your MySQL server version for the right syntax to use near '' at line 5) 
ERREUR SQL : 8 May 2019 - 13:28:11.000000 --> SELECT ETPID, LIEUNOM 
						FROM commune, lieu, etape 
						WHERE commune.VILID = lieu.VILID 
						AND etape.LIEUID = lieu.LIEUID 
						AND TRNNUM =  : (You have an error in your SQL syntax; check the manual that corresponds to your MySQL server version for the right syntax to use near '' at line 5) 
ERREUR SQL : 8 May 2019 - 13:28:11.000000 --> SELECT ETPID, LIEUNOM 
						FROM commune, lieu, etape 
						WHERE commune.VILID = lieu.VILID 
						AND etape.LIEUID = lieu.LIEUID 
						AND TRNNUM =  : (You have an error in your SQL syntax; check the manual that corresponds to your MySQL server version for the right syntax to use near '' at line 5) 
ERREUR SQL : 8 May 2019 - 13:28:11.000000 --> SELECT ETPID, LIEUNOM 
						FROM commune, lieu, etape 
						WHERE commune.VILID = lieu.VILID 
						AND etape.LIEUID = lieu.LIEUID 
						AND TRNNUM =  : (You have an error in your SQL syntax; check the manual that corresponds to your MySQL server version for the right syntax to use near '' at line 5) 
ERREUR SQL : 9 May 2019 - 10:32:02.000000 --> INSERT INTO tournee(TRNNUM, VEHIMMAT, CHFID, TRNCOMMENTAIRE, TRNDTE) 
				VALUES (9+1,'AO454DL',0,'','2019/05/09 10:32:00') : (Duplicate entry '10' for key 'PRIMARY') 
ERREUR SQL : 9 May 2019 - 10:32:20.000000 --> INSERT INTO tournee(TRNNUM, VEHIMMAT, CHFID, TRNCOMMENTAIRE, TRNDTE) 
				VALUES (9+1,'AO454DL',0,'','2019/05/09 10:32:00') : (Duplicate entry '10' for key 'PRIMARY') 
ERREUR SQL : 9 May 2019 - 10:32:22.000000 --> INSERT INTO tournee(TRNNUM, VEHIMMAT, CHFID, TRNCOMMENTAIRE, TRNDTE) 
				VALUES (9+1,'AO454DL',0,'','2019/05/09 10:32:00') : (Duplicate entry '10' for key 'PRIMARY') 
ERREUR SQL : 9 May 2019 - 10:38:05.000000 --> SELECT ETPID, LIEUNOM 
						FROM commune, lieu, etape 
						WHERE commune.VILID = lieu.VILID 
						AND etape.LIEUID = lieu.LIEUID 
						AND TRNNUM =  : (You have an error in your SQL syntax; check the manual that corresponds to your MySQL server version for the right syntax to use near '' at line 5) 
ERREUR SQL : 13 Sep 2019 - 9:14:19.000000 --> SELECT TRNNUM,TRNDTE,CHFNOM,VEHIMMAT 
							FROM tournee,chauffeur 
							WHERE tournee.CHFID=chauffeur.CHFID; : () 
ERREUR SQL : 13 Sep 2019 - 9:49:02.000000 --> INSERT INTO tournee(TRNNUM, VEHIMMAT, CHFID, TRNCOMMENTAIRE, TRNDTE) 
				VALUES (+1,'',11,'','2019/09/13 09:48:00') : (Cannot add or update a child row: a foreign key constraint fails (`bdd_mesguen`.`tournee`, CONSTRAINT `tournee_ibfk_1` FOREIGN KEY (`VEHIMMAT`) REFERENCES `vehicule` (`VEHIMMAT`))) 
ERREUR SQL : 13 Sep 2019 - 9:49:43.000000 --> INSERT INTO tournee(TRNNUM, VEHIMMAT, CHFID, TRNCOMMENTAIRE, TRNDTE) 
				VALUES (+1,'',11,'','2019/09/13 09:48:00') : (Cannot add or update a child row: a foreign key constraint fails (`bdd_mesguen`.`tournee`, CONSTRAINT `tournee_ibfk_1` FOREIGN KEY (`VEHIMMAT`) REFERENCES `vehicule` (`VEHIMMAT`))) 
ERREUR SQL : 20 Sep 2019 - 11:39:12.000000 --> SELECT TRNNUM,TRNDTE,CHFNOM,VEHIMMAT 
							FROM tournee,chauffeur 
							WHERE tournee.CHFID=chauffeur.CHFID; : () 
