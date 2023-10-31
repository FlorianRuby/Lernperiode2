# Lernperiode2

## Grob-Planung
Florian Ruby
20.10.2023 bis 22.12.2023 (🎄 Weihnachtsferien)

### Leit-Satz
In meinem zweiten Projekt möchte ich einen Währungsrechner programmieren, welcher zur Verwaltung eines Fremdwährungsportfolios genutzt werden kann. Er soll sich in der Basisversion Wechselkurse und in einer Erweiterung auch Marktentwicklungen selbständig über das Internet beziehen. Das technische Augenmerk liegt hier auf dem programmatischen Bezug von Informationen aus dem Internet und der Umrechnung der Währung. Um dises Projekt umsetzen zu können brauche ich eine API mit welcher ich Zugriff auf aktuelle Währungskurse habe, danach muss ich diese Daten automatisch in eine Datenbank eintragen um diese dann analysieren zu können und Gewinne, Verluste oder sonstiges wie prozentuale Veränderungen errechnen zu können. (99)

### Arbeitspakete für 24.10.2023
- [x] C# Projekt aufsetzen & weitere Vorgehensweise plannen.
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Projekt aufsetzen | `Code` | `Output`      |

- [x] Datenbank in welcher ich Währungen eintragen kann und wie viel ich von dieser habe.

| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datenbank | `Währungsname & Menge` | `Währung & Menge ist aufrufbar`|

Heute habe ich alles geschafft was ich mir vorgenommen hatte. 
Ich konnte das Projekt schnell aufsetzen und konnte mir auch schon einmal überlegen wie ich es angehen will. 
Danach habe ich zwei leere arrays erstellt, einen für den Währungsnamen und einen für die Menge. Darauf hin habe ich den Code geschrieben, welcher nach dem Währungsname & der Menge fragt. Danach habe ich eine formatiere Ausgabe mithilfe von [Microsoft](https://learn.microsoft.com/de-de/dotnet/api/system.console.writeline?view=net-7.0) erstellt, ich habe auch ChatGPT benutzt da ich nicht mit der Formatierung zufrieden war, da die Menge sich je nach grösse zu weit nach Links verschoben hat. Jetzt kann sich die Menge nur noch nach Rechts verschieben und es sieht nun so aus: 

![image](https://github.com/FlorianRuby/Lernperiode2/assets/142885331/59d9ac3d-d631-4df8-ab70-8483e232a295)


### Arbeitspakete für 31.10.2023
- [X] richtige API finden & herausfinden wie man diese API benutzt
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| API recherche | `nichts (sollte automatisch gehen sobald das Program offen ist)` | `Wechselkurse`      |

- [X] richtige API finden & herausfinden wie man diese API benutzt
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| API recherche | `nichts (sollte automatisch gehen sobald das Program offen ist)` | `Wechselkurse`      |

- [ ] Währungsmenge in CHF rechnen

| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei | `Währung & Menge` | `Menge umgerrechnet in CHF`|

- [ ] Währungsmenge wird in CHF angegeben mit Kursveränderung in der letzten Woche
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei & API | `n bei "Wollen sie noch weitere Währungen eintragen?"` | `Kursveränderungen in der letzten Woche in Prozent`      |

Ich konnte heute nicht alles schaffen, ich habe jetzt zwar die API und kann Wechselkurse aufrufen, aber ich kann diese noch nicht automatisch in Visual Studio abrufen, ich muss zuerst diese selbst herüberkopieren. Deswegen bin ich auch nach der API Aufgabe stecken geblieben und habe den Rest nicht geschaft. Sobald ich diese Hürde überwältigt habe sollte es aber schnell gehen da diese Aufgaben nicht lange dauern.

### Arbeitspakete für 07.10.2023

- [ ] Währungsmenge in CHF rechnen

| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei | `Währung & Menge` | `Menge umgerrechnet in CHF`|

- [ ] Währungsmenge wird in CHF angegeben mit Kursveränderung in der letzten Woche
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei & API | `n bei "Wollen sie noch weitere Währungen eintragen?"` | `Kursveränderungen in der letzten Woche in Prozent`      |

- [ ] Währungsmenge etc in einer Datei speichern und dann diese wieder auslesen
      
| Vorbereitung             | Eingabe | Erwartete Ausgabe |
| ------------------------ | ------- | ----------------- |
| Datei | `nichts, sollte automatisch am Anfang und am Ende passieren` | `derzeitiger Wert des Portfolios`      |
