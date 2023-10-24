# Lernperiode2

## Grob-Planung
Max Muster

20.10.2023 bis 22.12.2023 (🎄 Weihnachtsferien)

### Leit-Satz
In meinem zweiten Projekt möchte ich einen Währungsrechner programmieren, welcher zur Verwaltung eines Fremdwährungsportfolios genutzt werden kann. Er soll sich in der Basisversion Wechselkurse und in einer Erweiterung auch Marktentwicklungen selbständig über das Internet beziehen. Das technische Augenmerk liegt hier auf dem programmatischen Bezug von Informationen aus dem Internet und der Umrechnung der Währung. Um dises Projekt umsetzen zu können brauche ich eine API mit welcher ich Zugriff auf aktuelle Währungskurse habe, danach muss ich diese Daten automatisch in eine Datenbank eintragen um diese dann analysieren zu können und Gewinne, Verluste oder sonstiges wie prozentuale Veränderungen errechnen zu können. (99)

### Arbeitspakete für 20.10.2023
- [x] C# Projekt aufsetzen & weitere Vorgehensweise plannen.
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Projekt aufsetzen | `Code` | `Output`      |

- [x] Datenbank in welcher ich Währungen eintragen kann und wie viel ich von dieser habe.

| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datenbank | `Währungsname & Menge` | `Währung & Menge ist aufrufbar`|

Heute habe ich alles geschafft was ich mir vorgenommen hatte. Ich konnte das Projekt schnell aufsetzen und konnte mir schon einmal Überlegen wie ich es angehen will. 
Danach habe ich zwei leeren array erstellt, einen für den Währungsnamen und einen für die Menge. Darauf hin habe ich den Code geschrieben, welcher nach dem Währungsname & der Menge frag. Danach habe ich eine formatiere Ausgabe mithilfe von [Microsoft](https://learn.microsoft.com/de-de/dotnet/api/system.console.writeline?view=net-7.0) erstellt, welche die Währung und auch die Menge der Währung ausgibt, diese sieht so aus: 
--------------------------------------
          Vorhandenen Währungen
--------------------------------------
Nummer     Währung    Menge

1          eur        1.00
2          usd        100.00
3          chf        10,000.00
4          yen        100,000,000.00


### Arbeitspakete für 27.10.2023
