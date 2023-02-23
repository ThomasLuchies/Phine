# Phine
Phine is een contentplatform waarop korte videos te vinden zijn die kunnen bekeken worden door iedereen. 
De UI van de applicatie zal gebaseerd zijn op TikTok.  Op elk moment zal er één video op het scherm getoond worden. 
Om naar de volgende video te gaan moet de gebruiker op de pijltjes toets omlaag drukken en om naar de vorige video te gaan moet er op de pijltjes toets omhoog indrukken. 
Verder is het ook mogelijk om de video te likken. Dit kan gedaan worden door op het lik symbool te drukken. Ook kan er op de video worden gecomment.
Voor het uploaden en downloaden van video’s wordt een centrale server gebruikt die een database bevat. 
Het uploaden en downloaden wordt opgestuurd doormiddel van SFTP. 
De tijdslimiet van een video is 30 seconden. Om dit in de achtergrond van de applicatie werkend te krijgen zal er gebruik gemaakt worden van asynchronous I/O. 
Voor het liken zal de threadpool gebruikt worden aangezien er geen respons van de thread nodig is. 
Er is geen respons nodig omdat het liken op lage prioriteit ligt omdat het registreren van een like niet noodzakelijk is.  
Voor commenten zullen tasks gebruikt worden om het in de database te zetten omdat comments op een hogere prioriteit ligt en het noodzakelijk is om aan de gebruiker 
door te geven of de comment is geplaatst. Verder zal voor de comments uitlezen plinq worden gebruikt voor de mogelijk van een groot aantal comments op een video.
Wij vinden dat comments op een hogere prioriteit liggen aangezien hiermee een gesprek tussen meerdere gebruikers kan plaats vinden. 
Echter wordt er bij likes enkel vanaf één gebruiker gecommuniceerd waardoor de prioriteit lager ligt. 
Verder zal er ook een inlog systeem in de app zitten met minimale beveiliging. Hiervoor heeft de gebruiker een gebruikersnaam, email en wachtwoord nodig.
Aangezien er meerdere threads op het zelfde moment draaien zal er gebruik worden gemaakt van aysnc await om de applicatie responsive te houden.
Deze app wordt gemaakt in UWP.
