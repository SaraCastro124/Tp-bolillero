## Documentacion

```mermaid
classDiagram
    class Bolillero{
        +Bolillas: List~int~
        +Jugar(List~int~) bool
        +SacarBolilla() int
        +MeterBolillas() int
        +JugarNVeces(List~int~. int) 
    }
    class IJugada{
        <<interface>>
        +NumeroAlAzar: int
        +ElegirBolilla() int
    }
    class JugadaRandom{
        +NumeroAlAzar() int
        +ElegirBolilla() int
    }
    Bolillero --> IJugada
    JugadaRandom --|> IJugada
    
```

