Self Data Collector
(Versione Motorola)
====================


## INSTALLAZIONE ##
Copia i file della cartella PKG sul PdA sotto \Application\scs
Copia il file SelfDCRestore.run sul PdA sotto \Application\Startup
Effettua un Cold Reset (7+8+PWR) del PdA per installare i pacchetti.


## CONFIGURAZIONE ##
Se l'installazione è andata a buon fine trovi i file dell'applicazione sotto \Program Files\SelfDC, oltre all'icona del programma sul Desktop del PdA.
Avvia l'applicazione e richiudila per testarne il corretto funzionamento.
Apri il file CONF.TXT e verifica i parametri.
La configurazione di default è la seguente:

000000
ordine.txt
inventa.txt
etichet.txt

## RESET TERMINALE ##
Il ripristino alle impostazioni di fabbrica e l'eliminazione di tutti i programmi installati si fa con un Hard Reset (1+9+PWR).
** Attenzione: fare un reset solo se realmente necessario cancellare tutto, compreso le librerie .NET **