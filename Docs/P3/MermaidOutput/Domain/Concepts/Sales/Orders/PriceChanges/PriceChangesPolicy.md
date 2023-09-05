﻿
# Price Changes Policy

***Ddd Domain Service***  

This view contains details information about Price Changes Policy building block, including:
- dependencies
- modules
- related processes  

---



## Domain Perspective


### Dependencies

```mermaid
  flowchart TB
    subgraph 0["Sales / Wholesale Ordering / Order Pricing"]
      1([ConfirmOffer])
      class 1 DomainPerspective
    end
    subgraph 2["Sales / Orders"]
      3([Order])
      class 3 DomainPerspective
    end
    subgraph 4["Sales / Orders / Price Changes"]
      5(Price Changes Policy)
      class 5 DomainPerspective
    end
    0-->|depends on|4
    2-->|depends on|4
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

### Related process steps

```mermaid
  flowchart TB
    0(Price Changes Policy)
    class 0 DomainPerspective
    1([ConfirmOffer])
    class 1 DomainPerspective
    0-->|is used in|1
    classDef DomainPerspective stroke:#009900
    classDef TechnologyPerspective stroke:#1F41EB
    classDef PeoplePerspective stroke:#FFF014
```

## Next steps


### Zoom-in


#### Domain perspective


##### Process Steps

[ConfirmOffer](../../WholesaleOrdering/OrderPricing/ConfirmOffer.md)  

### Zoom-out


#### Domain perspective


##### Domain Modules

[Price Changes](PriceChanges.md)  

---

[P3 Model](https://github.com/P3-model/P3-model) documentation generated from source code using [.net tooling](https://github.com/P3-model/P3-model-dotnet)