## Documentacion

```mermaid
classDiagram
    class Bolillero{
        +Bolillas: List~int~
        +Numeros: List~int~
        +Jugar(List~int~) bool
        +SacarBolilla() 
        +MeterBolillas()
        +JugarNVeces(List~int~. int) 
    }
    class IJugada{
        <<interface>>
        +NumeroAlAzar: int
        +ElegirBolillaAleatoria() int
    }
    class JugadaRandom{
        +NumeroAlAzar() int
        +ElegirBolilla() int
    }
    Bolillero --> IJugada
    JugadaRandom --|> IJugada
    
```

